#pragma checksum "C:\Users\Ilhame\Desktop\ProniaAdmin\Pronia start\Views\Shared\Components\Footer\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a246c84e731d50abbdb5aa6e88df8d1cb61a167e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Footer_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Footer/Default.cshtml")]
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
#line 1 "C:\Users\Ilhame\Desktop\ProniaAdmin\Pronia start\Views\_ViewImports.cshtml"
using Pronia_start.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ilhame\Desktop\ProniaAdmin\Pronia start\Views\_ViewImports.cshtml"
using Pronia_start.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a246c84e731d50abbdb5aa6e88df8d1cb61a167e", @"/Views/Shared/Components/Footer/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f1a62907673c179af82d597bdddc12068eb7178", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_Footer_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/website-images/1.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Payment Method"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"        <!-- Begin Footer Area -->
        <div class=""footer-area""
             data-bg-image=""assets/images/footer/bg/1-1920x465.jpg"">
            <div class=""footer-top section-space-top-100 pb-60"">
                <div class=""container"">
                    <div class=""row"">
                        <div class=""col-lg-3"">
                            <div class=""footer-widget-item"">
                                <div class=""footer-widget-logo"">
                                  
                                      
                                        <a href=""index.html"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a246c84e731d50abbdb5aa6e88df8d1cb61a167e4966", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 666, "~/assets/images/logo/", 666, 21, true);
#nullable restore
#line 14 "C:\Users\Ilhame\Desktop\ProniaAdmin\Pronia start\Views\Shared\Components\Footer\Default.cshtml"
AddHtmlAttributeValue("", 687, Model.Settings.FooterLogo, 687, 26, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    </a>
                                      
                                </div>
                                <p class=""footer-widget-desc"">
                                    Lorem ipsum dolor sit amet, consec adipisl elit, sed do
                                    eiusmod tempor
                                    <br />
                                    incidio ut labore et dolore magna.
                                </p>
                                <div class=""social-link with-border"">
                                    <ul>
");
#nullable restore
#line 26 "C:\Users\Ilhame\Desktop\ProniaAdmin\Pronia start\Views\Shared\Components\Footer\Default.cshtml"
                                        foreach (SocialMedia item in Model.SocialMedias)
                                      {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                           <li>\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 1552, "\"", 1568, 1);
#nullable restore
#line 29 "C:\Users\Ilhame\Desktop\ProniaAdmin\Pronia start\Views\Shared\Components\Footer\Default.cshtml"
WriteAttributeValue("", 1559, item.Url, 1559, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"
                                               data-tippy=""Facebook""
                                               data-tippy-inertia=""true""
                                               data-tippy-animation=""shift-away""
                                               data-tippy-delay=""50""
                                               data-tippy-arrow=""true""
                                               data-tippy-theme=""sharpborder"">
                                                <i");
            BeginWriteAttribute("class", " class=\"", 2069, "\"", 2087, 1);
#nullable restore
#line 36 "C:\Users\Ilhame\Desktop\ProniaAdmin\Pronia start\Views\Shared\Components\Footer\Default.cshtml"
WriteAttributeValue("", 2077, item.Icon, 2077, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n                                            </a>\r\n                                        </li>\n");
#nullable restore
#line 39 "C:\Users\Ilhame\Desktop\ProniaAdmin\Pronia start\Views\Shared\Components\Footer\Default.cshtml"
                                      }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                     
                                    </ul>
                                </div>
                            </div>
                        </div>
                        <div class=""col-lg-2 col-md-4 pt-40"">
                            <div class=""footer-widget-item"">
                                <h3 class=""footer-widget-title"">Useful Links</h3>
                                <ul class=""footer-widget-list-item"">
                                    <li>
                                        <a href=""#"">About Pronia</a>
                                    </li>
                                    <li>
                                        <a href=""#"">How to shop</a>
                                    </li>
                                    <li>
                                        <a href=""#"">FAQ</a>
                                    </li>
                                    <li>
                                        <a href=""#"">Contact");
            WriteLiteral(@" us</a>
                                    </li>
                                    <li>
                                        <a href=""#"">Log in</a>
                                    </li>
                                </ul>
                            </div>
                        </div>
                        <div class=""col-lg-2 col-md-4 pt-40"">
                            <div class=""footer-widget-item"">
                                <h3 class=""footer-widget-title"">My Account</h3>
                                <ul class=""footer-widget-list-item"">
                                    <li>
                                        <a href=""#"">Sign In</a>
                                    </li>
                                    <li>
                                        <a href=""#"">View Cart</a>
                                    </li>
                                    <li>
                                        <a href=""#"">My Wishlist</a>
                           ");
            WriteLiteral(@"         </li>
                                    <li>
                                        <a href=""#"">Track My Order</a>
                                    </li>
                                    <li>
                                        <a href=""#"">Help</a>
                                    </li>
                                </ul>
                            </div>
                        </div>
                        <div class=""col-lg-2 col-md-4 pt-40"">
                            <div class=""footer-widget-item"">
                                <h3 class=""footer-widget-title"">Our Service</h3>
                                <ul class=""footer-widget-list-item"">
                                    <li>
                                        <a href=""#"">Payment Methods</a>
                                    </li>
                                    <li>
                                        <a href=""#"">Money Guarantee!</a>
                                    </li>
   ");
            WriteLiteral(@"                                 <li>
                                        <a href=""#"">Returns</a>
                                    </li>
                                    <li>
                                        <a href=""#"">Shipping</a>
                                    </li>
                                    <li>
                                        <a href=""#"">Privacy Policy</a>
                                    </li>
                                </ul>
                            </div>
                        </div>
                        <div class=""col-lg-3 pt-40"">
                            <div class=""footer-contact-info"">
                                <h3 class=""footer-widget-title"">Got Question? Call Us</h3>
                                <a class=""number"" href=""tel://123-456-789"">123 456 789</a>
                                <div class=""address"">
                                    <ul>
                                        <li>Your Address Goes He");
            WriteLiteral(@"re</li>
                                    </ul>
                                </div>
                            </div>
                            <div class=""payment-method"">
                                <a href=""#"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a246c84e731d50abbdb5aa6e88df8d1cb61a167e13785", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""footer-bottom"">
                <div class=""container"">
                    <div class=""row"">
                        <div class=""col-lg-12"">
                            <div class=""copyright"">
                                <span class=""copyright-text"">
                                    © 2021 Pronia Made with
                                    <i class=""fa fa-heart text-danger""></i> by
                                    <a href=""https://hasthemes.com/""
                                       rel=""noopener""
                                       target=""_blank"">HasThemes</a>
                                </span>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- Footer Area ");
            WriteLiteral("End Here -->\r\n        <!-- Begin Modal Area -->");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Pronia_start.Services.LayoutServices layoutService { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
