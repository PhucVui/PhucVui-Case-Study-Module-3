#pragma checksum "C:\Users\vui\Desktop\Case Study\WatchShop\WatchShop\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "434aafe7a14f1b18652dc4783395995a8ff7a3be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\vui\Desktop\Case Study\WatchShop\WatchShop\Views\_ViewImports.cshtml"
using WatchShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\vui\Desktop\Case Study\WatchShop\WatchShop\Views\_ViewImports.cshtml"
using WatchShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"434aafe7a14f1b18652dc4783395995a8ff7a3be", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4c53f6d0b075cd6a1a58d2f58ca75321bc2a690", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Category>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("news image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewProductsWithCategoryId", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<section class=\"service py-lg-4 py-md-4 py-sm-3 py-3\" id=\"service\">\r\n    <div class=\"container py-lg-5 py-md-4 py-sm-4 py-3\">\r\n        <h3 class=\"title text-center mb-2\">CateGory</h3>\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 7 "C:\Users\vui\Desktop\Case Study\WatchShop\WatchShop\Views\Home\Index.cshtml"
             foreach (var item in Model)
            {
            

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-lg-4 col-md-6 col-sm-6 ser-icon text-center my-3\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "434aafe7a14f1b18652dc4783395995a8ff7a3be5127", async() => {
                WriteLiteral("\r\n                    <div class=\"grid-wthree-service\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "434aafe7a14f1b18652dc4783395995a8ff7a3be5465", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 588, "~/layout/images/Logo/", 588, 21, true);
#nullable restore
#line 13 "C:\Users\vui\Desktop\Case Study\WatchShop\WatchShop\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 609, item.Logo, 609, 10, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        <div class=\"ser-text-wthree mt-3\">\r\n                            <h4>\r\n                                ");
#nullable restore
#line 16 "C:\Users\vui\Desktop\Case Study\WatchShop\WatchShop\Views\Home\Index.cshtml"
                           Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </h4>\r\n                            <p class=\"mt-2\">Lorem ipsum dolor sit amet, consectetuer adipiscing elit</p>\r\n                        </div>\r\n                    </div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 11 "C:\Users\vui\Desktop\Case Study\WatchShop\WatchShop\Views\Home\Index.cshtml"
                                                                                   WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 23 "C:\Users\vui\Desktop\Case Study\WatchShop\WatchShop\Views\Home\Index.cshtml"
                
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</section>\r\n<section class=\"gallery py-lg-4 py-md-3 py-sm-3 py-3\" id=\"gallery\">\r\n    <div class=\"container py-lg-5 py-md-4 py-sm-4 py-3\">\r\n        <h3 class=\"title text-center mb-2\"></h3>\r\n");
            WriteLiteral(@"        <div class=""row gallery-info"">
            <div class=""col-lg-4 col-md-6 col-sm-6 gallery-img-grid my-3"">
                <div class=""gallery-grids"">
                    <a href=""#gal1"">
                        <img src=""images/g1.jpg"" alt=""news image"" class=""img-fluid"">
                    </a>
                </div>
            </div>
            <div class=""col-lg-4 col-md-6 col-sm-6 gallery-img-grid my-3"">
                <div class=""gallery-grids"">
                    <a href=""#gal2"">
                        <img src=""images/bb2.jpg"" alt=""news image"" class=""img-fluid"">
                    </a>
                </div>
            </div>
            <div class=""col-lg-4 col-md-6 col-sm-6 gallery-img-grid my-3"">
                <div class=""gallery-grids"">
                    <a href=""#gal3"">
                        <img src=""images/bb3.jpg"" alt=""news image"" class=""img-fluid"">
                    </a>
                </div>
            </div>
            <div class=""col-lg-4 col-");
            WriteLiteral(@"md-6 col-sm-6 gallery-img-grid my-3"">
                <div class=""gallery-grids"">
                    <a href=""#gal4"">
                        <img src=""images/g2.jpg"" alt=""news image"" class=""img-fluid"">
                    </a>
                </div>
            </div>
            <div class=""col-lg-4 col-md-6 col-sm-6 gallery-img-grid my-3"">
                <div class=""gallery-grids"">
                    <a href=""#gal5"">
                        <img src=""images/g3.jpg"" alt=""news image"" class=""img-fluid"">
                    </a>
                </div>
            </div>
            <div class=""col-lg-4 col-md-6 col-sm-6 gallery-img-grid my-3"">
                <div class=""gallery-grids"">
                    <a href=""#gal6"">
                        <img src=""images/g4.jpg"" alt=""news image"" class=""img-fluid"">
                    </a>
                </div>
            </div>
        </div>
        <!-- popup-->
        <div id=""gal1"" class=""popup-effect"">
            <div class=""popup"">");
            WriteLiteral(@"
                <img src=""images/g1.jpg"" alt=""Popup Image"" class=""img-fluid"">
                <a class=""close"" href=""#gallery"">×</a>
            </div>
        </div>
        <!-- //popup -->
        <!-- popup-->
        <div id=""gal2"" class=""popup-effect"">
            <div class=""popup"">
                <img src=""images/bb2.jpg"" alt=""Popup Image"" class=""img-fluid"">
                <a class=""close"" href=""#gallery"">×</a>
            </div>
        </div>
        <!-- //popup -->
        <!-- popup-->
        <div id=""gal3"" class=""popup-effect"">
            <div class=""popup"">
                <img src=""images/bb3.jpg"" alt=""Popup Image"" class=""img-fluid"">
                <a class=""close"" href=""#gallery"">×</a>
            </div>
        </div>
        <!-- //popup -->
        <!-- popup-->
        <div id=""gal4"" class=""popup-effect"">
            <div class=""popup"">
                <img src=""images/g2.jpg"" alt=""Popup Image"" class=""img-fluid"">
                <a class=""close"" href=""#gall");
            WriteLiteral(@"ery"">×</a>
            </div>
        </div>
        <!-- //popup -->
        <!-- popup-->
        <div id=""gal5"" class=""popup-effect"">
            <div class=""popup"">
                <img src=""images/g3.jpg"" alt=""Popup Image"" class=""img-fluid"">
                <a class=""close"" href=""#gallery"">×</a>
            </div>
        </div>
        <!-- //popup -->
        <!-- popup-->
        <div id=""gal6"" class=""popup-effect"">
            <div class=""popup"">
                <img src=""images/g4.jpg"" alt=""Popup Image"" class=""img-fluid"">
                <a class=""close"" href=""#gallery"">×</a>
            </div>
        </div>
        <!-- //popup -->
    </div>
</section>
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
