#pragma checksum "B:\LTWEB.ASP.NET\BoletoCinema\BoletoCinema\BoletoCinema\Views\Home\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "693bd5a5acec8bdc1552c6ecfbacd638d4c89e68"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contact), @"mvc.1.0.view", @"/Views/Home/Contact.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"693bd5a5acec8bdc1552c6ecfbacd638d4c89e68", @"/Views/Home/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c98956751c3de026257271ce590f00f221b4949", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("contact-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("contact_form_submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/User/assets/images/contact/contact01.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("contact"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/User/assets/images/contact/contact02.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<section class=""main-page-header speaker-banner bg_img"" data-background=""~/User/assets/images/banner/banner07.jpg"">
    <div class=""container"">
        <div class=""speaker-banner-content"">
            <h2 class=""title"">contact us</h2>
            <ul class=""breadcrumb"">
                <li>
                    <a href=""index.html"">
                        Home
                    </a>
                </li>
                <li>
                    contact us
                </li>
            </ul>
        </div>
    </div>
</section>
<!-- ==========Banner-Section========== -->
<!-- ==========Contact-Section========== -->
<section class=""contact-section padding-top"">
    <div class=""contact-container"">
        <div class=""bg-thumb bg_img"" data-background=""~/User/assets/images/contact/contact.jpg""></div>
        <div class=""container"">
            <div class=""row justify-content-between"">
                <div class=""col-md-7 col-lg-6 col-xl-5"">
                    <div class=""section-hea");
            WriteLiteral(@"der-3 left-style"">
                        <span class=""cate"">contact us</span>
                        <h2 class=""title"">get in touch</h2>
                        <p>We’d love to talk about how we can work together. Send us a message below and we’ll respond as soon as possible.</p>
                    </div>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "693bd5a5acec8bdc1552c6ecfbacd638d4c89e686435", async() => {
                WriteLiteral(@"
                        <div class=""form-group"">
                            <label for=""name"">Name <span>*</span></label>
                            <input type=""text"" placeholder=""Enter Your Full Name"" name=""name"" id=""name"" required>
                        </div>
                        <div class=""form-group"">
                            <label for=""email"">Email <span>*</span></label>
                            <input type=""text"" placeholder=""Enter Your Email"" name=""email"" id=""email"" required>
                        </div>
                        <div class=""form-group"">
                            <label for=""subject"">Subject <span>*</span></label>
                            <input type=""text"" placeholder=""Enter Your Subject"" name=""subject"" id=""subject"" required>
                        </div>
                        <div class=""form-group"">
                            <label for=""message"">Message <span>*</span></label>
                            <textarea name=""message"" id=""message""");
                WriteLiteral(@" placeholder=""Enter Your Message"" required></textarea>
                        </div>
                        <div class=""form-group"">
                            <input type=""submit"" value=""Send Message"">
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
                <div class=""col-md-5 col-lg-6"">
                    <div class=""padding-top padding-bottom contact-info"">
                        <div class=""info-area"">
                            <div class=""info-item"">
                                <div class=""info-thumb"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "693bd5a5acec8bdc1552c6ecfbacd638d4c89e689556", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </div>
                                <div class=""info-content"">
                                    <h6 class=""title"">phone number</h6>
                                    <a href=""Tel:82828282034"">+1234 56789</a>
                                </div>
                            </div>
                            <div class=""info-item"">
                                <div class=""info-thumb"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "693bd5a5acec8bdc1552c6ecfbacd638d4c89e6811154", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </div>
                                <div class=""info-content"">
                                    <h6 class=""title"">Email</h6>
                                    <a href=""Mailto:info@gmail.com"">info@Boleto .com</a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- ==========Contact-Section========== -->
<!-- ==========Contact-Counter-Section========== -->
<section class=""contact-counter padding-top padding-bottom"">
    <div class=""container"">
        <div class=""row justify-content-center mb-30-none"">
            <div class=""col-sm-6 col-md-3"">
                <div class=""contact-counter-item"">
                    <div class=""contact-counter-thumb"">
                        <i class=""fab fa-facebook-f""></i>
                    </div>
                    <div class=""contact-counter-conte");
            WriteLiteral(@"nt"">
                        <div class=""counter-item"">
                            <h5 class=""title odometer"" data-odometer-final=""130"">0</h5>
                            <h5 class=""title"">k</h5>
                        </div>
                        <p>Followers</p>
                    </div>
                </div>
            </div>
            <div class=""col-sm-6 col-md-3"">
                <div class=""contact-counter-item active"">
                    <div class=""contact-counter-thumb"">
                        <i class=""fas fa-users""></i>
                    </div>
                    <div class=""contact-counter-content"">
                        <div class=""counter-item"">
                            <h5 class=""title odometer"" data-odometer-final=""35"">0</h5>
                            <h5 class=""title"">k</h5>
                        </div>
                        <p>Members</p>
                    </div>
                </div>
            </div>
            <div class=""col-sm-6 col-");
            WriteLiteral(@"md-3"">
                <div class=""contact-counter-item"">
                    <div class=""contact-counter-thumb"">
                        <i class=""fab fa-twitter""></i>
                    </div>
                    <div class=""contact-counter-content"">
                        <div class=""counter-item"">
                            <h5 class=""title odometer"" data-odometer-final=""47"">0</h5>
                            <h5 class=""title"">k</h5>
                        </div>
                        <p>Followers</p>
                    </div>
                </div>
            </div>
            <div class=""col-sm-6 col-md-3"">
                <div class=""contact-counter-item"">
                    <div class=""contact-counter-thumb"">
                        <i class=""fas fa-envelope""></i>
                    </div>
                    <div class=""contact-counter-content"">
                        <div class=""counter-item"">
                            <h5 class=""title odometer"" data-odometer-final");
            WriteLiteral("=\"291\">0</h5>\r\n                            <h5 class=\"title\">k</h5>\r\n                        </div>\r\n                        <p>Subscribers</p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
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
