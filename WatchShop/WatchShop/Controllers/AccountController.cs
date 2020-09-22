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
        public IActionResult Index() => View(_userManager.Users.ToList());

        [AllowAnonymous]
        [HttpGet]
        public IActionResult Register() => View();

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

        //[AllowAnonymous]
        //[HttpGet]
        //public IActionResult Login(string returnUrl = "") =>
        //    View(new LoginViewModel { ReturnUrl = returnUrl });

        //[AllowAnonymous]
        //[HttpPost]
        //public async Task<IActionResult> Login(LoginViewModel model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, false);

        //        if (result.Succeeded)
        //        {
        //            if (!string.IsNullOrEmpty(model.ReturnUrl) && Url.IsLocalUrl(model.ReturnUrl))
        //                return Redirect(model.ReturnUrl);
        //            else
        //                return RedirectToAction("Index", "Home");
        //        }
        //    }
        //    ModelState.AddModelError("", "Sai Tài Khoản Hoặc Mật Khẩu !");

        //    return View(model);
        //}

        //[HttpGet]
        //public IActionResult Edit(string id)
        //{
        //    var User = _userManager.FindByIdAsync(id).Result;
        //    var address = _context.Addresses.ToList().Find(el => el.Id == User.AddressId);

        //    ModelForEdit model = new ModelForEdit()
        //    {
        //        Email = User.Email,
        //        FullName = User.FullName,
        //        Id = User.Id,
        //        Address = address,
        //        Avatar_Path = User.Avatar,
        //        PhoneNum = User.PhoneNumber
        //    };
        //    return View(model);
        //}

        //[HttpPost]
        //public async Task<IActionResult> Edit(ModelForEdit UserModel)
        //{
        //    Address address = _context.Addresses.ToList().Find(x => x.Id == UserModel.Address.Id);

        //    address.ProvinceId = UserModel.Address.ProvinceId;
        //    address.DistrictId = UserModel.Address.DistrictId;
        //    address.WardId = UserModel.Address.WardId;
        //    address.HouseNum = UserModel.Address.HouseNum;

        //    _context.Update(address);
        //    await _context.SaveChangesAsync();

        //    var FindUser = _userManager.FindByIdAsync(UserModel.Id).Result;

        //    FindUser.Email = UserModel.Email;
        //    FindUser.FullName = UserModel.FullName;
        //    FindUser.PhoneNumber = UserModel.PhoneNum;
        //    FindUser.Address = address;
        //    FindUser.Avatar = UserModel.Avatar_Path;

        //    if (UserModel.iformfile_path != null)
        //    {
        //        FindUser.Avatar = UploadedFile(UserModel.iformfile_path);

        //        if (!string.IsNullOrEmpty(UserModel.Avatar_Path) && UserModel.Avatar_Path != AvatarUserDefault)
        //        {
        //            string DelPath = Path.Combine(_hostEnvironment.WebRootPath, "Images/UserImages", UserModel.Avatar_Path);
        //            System.IO.File.Delete(DelPath);
        //        }
        //    }
        //    await _userManager.UpdateAsync(FindUser);

        //    return RedirectToAction("Index", "Account");
        //}

        //[Route("/Account/Delete/{id}")]
        //public IActionResult Delete(string id)
        //{
        //    bool deleteResult = false;
        //    var existUser = Task.Run(async () => await _userManager.FindByIdAsync(id)).Result;

        //    if (existUser == null)
        //        return Json(new { deleteResult });

        //    var address = _context.Addresses.FirstOrDefault(el => el.Id == existUser.AddressId);

        //    _context.Remove(address);
        //    //Task.Run(async () => await _context.SaveChangesAsync());

        //    if (existUser.Avatar != AvatarUserDefault)
        //    {
        //        string DelPath = Path.Combine(_hostEnvironment.WebRootPath, "Images/UserImages", existUser.Avatar);
        //        System.IO.File.Delete(DelPath);
        //    }
        //    var identityResult = Task.Run(async () => await _userManager.DeleteAsync(existUser)).Result;
        //    deleteResult = identityResult.Succeeded;

        //    return Json(new { deleteResult });
        //}

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login", "Account");
        }

        public IActionResult UserDetail(string id) =>
            View(_userManager.FindByIdAsync(id).Result);

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
