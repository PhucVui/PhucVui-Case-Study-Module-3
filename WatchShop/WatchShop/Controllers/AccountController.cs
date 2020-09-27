using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WatchShop.Models;
using WatchShop.Models.ViewModels;

namespace WatchShop.Controllers
{
    public class AccountController : Controller
    {
        private readonly WatchShopDbContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private const string AvatarDefault = "default.jpg";

        public AccountController(WatchShopDbContext context, IWebHostEnvironment hostEnvironment,
             UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            this._context = context;
            this._hostEnvironment = hostEnvironment;
            this._userManager = userManager;
            this._signInManager = signInManager;
        }
        public IActionResult Index()
        {
            return View(_userManager.Users.ToList());
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Register(RegisterUserView model)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser User = new ApplicationUser()
                {
                    Avatar = UploadedFile(model.IFormFilePath),
                    Name = model.FullName,
                    PhoneNumber = model.PhoneNumber,
                    Email = model.Email,
                    UserName = model.Email,
                };
                var result = await _userManager.CreateAsync(User, model.Password);
                await _context.SaveChangesAsync();

                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(User, false);
                    return RedirectToAction("Index", "Account");
                }
                else
                    foreach (var item in result.Errors)
                        ModelState.AddModelError("", item.Description);
            }
            return View();
        }

        private string AvatarDefaultPath(IFormFile iformfilePath)
        {
            if (iformfilePath == null)
                return AvatarDefault;
            else
                return UploadedFile(iformfilePath);
        }

        private string UploadedFile(IFormFile iformfile_path)
        {
            string uniqueFileName = null;

            if (iformfile_path != null)
            {
                string uploadsFolder = Path.Combine(_hostEnvironment.WebRootPath, "images/User");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + iformfile_path.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using var fileStream = new FileStream(filePath, FileMode.Create);
                iformfile_path.CopyTo(fileStream);
            }
            return uniqueFileName;
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult Login(string returnUrl = "")
        {
            return View(new LoginView { ReturnUrl = returnUrl });
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login(LoginView model)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, false);

                if (result.Succeeded)
                {
                    if (!string.IsNullOrEmpty(model.ReturnUrl) && Url.IsLocalUrl(model.ReturnUrl))
                        return Redirect(model.ReturnUrl);
                    else
                        return RedirectToAction("Index", "Home");
                }
            }
            ModelState.AddModelError("", "Tài Khoản hoặc Mật Khẩu không đúng!");

            return View(model);
        }

        [HttpGet]
        public IActionResult Edit(string id)
        {
            var User = _userManager.FindByIdAsync(id).Result;

            EditUserView model = new EditUserView()
            {
                Id = User.Id,
                Name = User.Name,
                Email = User.Email,
                AvatarPath = User.Avatar,
                PhoneNumber = User.PhoneNumber
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditUserView model)
        {

            var User = _userManager.FindByIdAsync(model.Id).Result;
            
            User.Name = model.Name;
            User.Email = model.Email;
            User.Avatar = model.AvatarPath;
            User.PhoneNumber = model.PhoneNumber;
            

            if (model.IformfilePath != null)
            {
                User.Avatar = UploadedFile(model.IformfilePath);

                if (!string.IsNullOrEmpty(model.AvatarPath) && model.AvatarPath != AvatarDefault)
                {
                    string DelPath = Path.Combine(_hostEnvironment.WebRootPath, "Images/UserImages", model.AvatarPath);
                    System.IO.File.Delete(DelPath);
                }
            }
            await _userManager.UpdateAsync(User);

            return RedirectToAction("Index", "Account");
        }

        [Route("/Account/Delete/{id}")]
        public IActionResult Delete(string id)
        {
            bool deleteResult = false;
            var existUser = Task.Run(async () => await _userManager.FindByIdAsync(id)).Result;

            if (existUser == null)
                return Json(new { deleteResult });           

            if (existUser.Avatar != AvatarDefault)
            {
                string DelPath = Path.Combine(_hostEnvironment.WebRootPath, "Images/User", existUser.Avatar);
                System.IO.File.Delete(DelPath);
            }
            var identityResult = Task.Run(async () => await _userManager.DeleteAsync(existUser)).Result;
            deleteResult = identityResult.Succeeded;
            return Json(new { deleteResult });
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        public IActionResult UserDetail(string id)
        {
             return View(_userManager.FindByIdAsync(id).Result);
        }
            
        //[HttpGet]
        //public IActionResult ChangePass(string id)
        //{
        //    ApplicationUser user = _userManager.FindByIdAsync(id).Result;
        //    if (user == null)
        //    {
        //        ModelState.AddModelError("", "Tài khoản này không tồn tại");
        //        return RedirectToAction("Index", "Home");
        //    }
        //    ChangePassUserView changePassUserView = new ChangePassUserView()
        //    {
        //        Id = user.Id,
        //    };
        //    return View(changePassUserView);
        //}


        //[HttpPost]
        //public async Task<IActionResult> ChangePass(ChangePassUserView changePassView)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        ApplicationUser user = _userManager.FindByIdAsync(changePassView.Id).Result;
        //        if (user != null)
        //        {
        //            var result = await _userManager.ChangePasswordAsync(user, changePassView.CurrentPassword, changePassView.NewPassword);

        //            if (result.Succeeded)
        //            {
        //                await _userManager.UpdateAsync(user);
        //                return RedirectToAction("Index", "Home");
        //            }
        //            else
        //                foreach (var item in result.Errors)
        //                    ModelState.AddModelError("", item.Description);
        //        }
        //        else
        //            return View();
        //    }

        //    return View();
        //}
    }
}
