#pragma checksum "B:\LTWEB.ASP.NET\BoletoCinema\BoletoCinema\BoletoCinema\Views\Home\SignIn.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc590b52e97c7f333ad4c6cdc790d28572efa2d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_SignIn), @"mvc.1.0.view", @"/Views/Home/SignIn.cshtml")]
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
#line 1 "B:\LTWEB.ASP.NET\BoletoCinema\BoletoCinema\BoletoCinema\Views\_ViewImports.cshtml"
using BoletoCinema;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc590b52e97c7f333ad4c6cdc790d28572efa2d4", @"/Views/Home/SignIn.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c98956751c3de026257271ce590f00f221b4949", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_SignIn : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("account-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 4 "B:\LTWEB.ASP.NET\BoletoCinema\BoletoCinema\BoletoCinema\Views\Home\SignIn.cshtml"
  
    Layout = "_LayoutSimple";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""preloader"">
    <div class=""preloader-inner"">
        <div class=""preloader-icon"">
            <span></span>
            <span></span>
        </div>
    </div>
</div>
<!-- ==========Preloader========== -->
<!-- ==========Sign-In-Section========== -->
<section class=""account-section bg_img"" data-background=""~/User/assets/images/account/account-bg.jpg"">
    <div class=""container"">
        <div class=""padding-top padding-bottom"">
            <div class=""account-area"">
                <div class=""section-header-3"">
                    <span class=""cate"">hello</span>
                    <h2 class=""title"">welcome back</h2>
                </div>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc590b52e97c7f333ad4c6cdc790d28572efa2d44298", async() => {
                WriteLiteral(@"
                    <div class=""form-group"">
                        <label for=""email2"">Email<span>*</span></label>
                        <input type=""text"" placeholder=""Enter Your Email"" id=""email2"" required>
                    </div>
                    <div class=""form-group"">
                        <label for=""pass3"">Password<span>*</span></label>
                        <input type=""password"" placeholder=""Password"" id=""pass3"" required>
                    </div>
                    <div class=""form-group checkgroup"">
                        <input type=""checkbox"" id=""bal2"" required checked>
                        <label for=""bal2"">remember password</label>
                        <a href=""#0"" class=""forget-pass"">Forget Password</a>
                    </div>
                    <div class=""form-group text-center"">
                        <input type=""submit"" value=""log in"">
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                <div class=""option"">
                    Don't have an account? <a href=""sign-up.html"">sign up now</a>
                </div>
                <div class=""or""><span>Or</span></div>
                <ul class=""social-icons"">
                    <li>
                        <a href=""#0"">
                            <i class=""fab fa-facebook-f""></i>
                        </a>
                    </li>
                    <li>
                        <a href=""#0"" class=""active"">
                            <i class=""fab fa-twitter""></i>
                        </a>
                    </li>
                    <li>
                        <a href=""#0"">
                            <i class=""fab fa-google""></i>
                        </a>
                    </li>
                </ul>
            </div>
        </div>
    </div>
</section>");
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
