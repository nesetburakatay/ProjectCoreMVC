#pragma checksum "C:\Users\elifc\Desktop\Yeni klasör (4)\ProjectCoreMVC\ProjectCoreMVC\Views\Shared\_PartialLayoutHeader.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85ba47c57ddc6d334e97c6657a7e6731aeb0567c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__PartialLayoutHeader), @"mvc.1.0.view", @"/Views/Shared/_PartialLayoutHeader.cshtml")]
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
#line 1 "C:\Users\elifc\Desktop\Yeni klasör (4)\ProjectCoreMVC\ProjectCoreMVC\Views\_ViewImports.cshtml"
using ProjectCoreMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\elifc\Desktop\Yeni klasör (4)\ProjectCoreMVC\ProjectCoreMVC\Views\_ViewImports.cshtml"
using ProjectCoreMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85ba47c57ddc6d334e97c6657a7e6731aeb0567c", @"/Views/Shared/_PartialLayoutHeader.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a5f7cfd1ef907f7a5761af535744bbd0ec70d53", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__PartialLayoutHeader : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline my-2 my-lg-0 header-search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<header>
    <div class=""top-bar_sub_w3layouts container-fluid"">
        <div class=""row"">
            <div class=""col-md-4 logo text-left"">
                <a class=""navbar-brand"" href=""index.html"">
                    <i class=""fab fa-linode""></i> Weblog
                </a>
            </div>
            <div class=""col-md-4 top-forms text-center mt-lg-3 mt-md-1 mt-0"">
                <span>Welcome Back!</span>
                <span class=""mx-lg-4 mx-md-2  mx-1"">
                    <a href=""/Login/Index"">
                        <i class=""fas fa-lock""></i> Sign In
                    </a>
                </span>
                <span>
                    <a href=""/Register"">
                        <i class=""far fa-user""></i> Register
                    </a>
                </span>
            </div>
            <div class=""col-md-4 log-icons text-right"">

                <ul class=""social_list1 mt-3"">

                    <li>
                        <a href=""#"" class=""facebook");
            WriteLiteral(@"1 mx-2"">
                            <i class=""fab fa-facebook-f""></i>

                        </a>
                    </li>
                    <li>
                        <a href=""#"" class=""twitter2"">
                            <i class=""fab fa-twitter""></i>

                        </a>
                    </li>
                    <li>
                        <a href=""#"" class=""dribble3 mx-2"">
                            <i class=""fab fa-dribbble""></i>
                        </a>
                    </li>
                    <li>
                        <a href=""#"" class=""pin"">
                            <i class=""fab fa-pinterest-p""></i>
                        </a>
                    </li>
                </ul>
            </div>
        </div>
    </div>

    <div class=""header_top"" id=""home"">
        <nav class=""navbar navbar-expand-lg navbar-light bg-light"">
            <button class=""navbar-toggler navbar-toggler-right mx-auto"" type=""button"" data-toggle=""collapse"" ");
            WriteLiteral(@"data-target=""#navbarSupportedContent"" aria-controls=""navbarSupportedContent""
                    aria-expanded=""false"" aria-label=""Toggle navigation"">
                <span class=""navbar-toggler-icon""></span>
            </button>


            <div class=""collapse navbar-collapse"" id=""navbarSupportedContent"">
                <ul class=""navbar-nav mr-auto"">
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""/Home/Index"">
                            Home
                            <span class=""sr-only"">(current)</span>
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""/About/Index"">About</a>
                    </li>
                    <li class=""nav-item dropdown active"">
                        <a class=""nav-link dropdown-toggle"" href=""#"" id=""navbarDropdown"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true""
                           aria-expan");
            WriteLiteral(@"ded=""false"">
                            Features
                        </a>
                        <div class=""dropdown-menu"" aria-labelledby=""navbarDropdown"">
                            <a class=""dropdown-item"" href=""#""></a>
                            <a class=""dropdown-item"" href=""blog1.html"">Standard Blog</a>
                            <div class=""dropdown-divider""></div>
                            <a class=""dropdown-item"" href=""blog2.html"">2 Column Blog</a>
                            <div class=""dropdown-divider""></div>
                            <a class=""dropdown-item"" href=""blog3.html"">3 Column Blog</a>

                        </div>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""/Contact/Index"">Contact</a>
                    </li>

                </ul>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "85ba47c57ddc6d334e97c6657a7e6731aeb0567c8558", async() => {
                WriteLiteral("\r\n                    <input class=\"form-control mr-sm-2\" type=\"search\" placeholder=\"Search here...\" name=\"Search\"");
                BeginWriteAttribute("required", " required=\"", 4153, "\"", 4164, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                    <button class=\"btn btn1 my-2 my-sm-0\" type=\"submit\">\r\n                        <i class=\"fas fa-search\"></i>\r\n                    </button>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n\r\n            </div>\r\n        </nav>\r\n\r\n    </div>\r\n</header>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591