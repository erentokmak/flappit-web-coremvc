#pragma checksum "C:\Users\ErkanPer\source\repos\flappit-web-coremvc\carfully-web-coremvc\Views\Home\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b51f6719d6d700290f2140fea374269bde7f7ed5"
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
#line 1 "C:\Users\ErkanPer\source\repos\flappit-web-coremvc\carfully-web-coremvc\Views\_ViewImports.cshtml"
using carfully_web_coremvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ErkanPer\source\repos\flappit-web-coremvc\carfully-web-coremvc\Views\_ViewImports.cshtml"
using carfully_web_coremvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b51f6719d6d700290f2140fea374269bde7f7ed5", @"/Views/Home/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"304b56c6095f47d4a5bc2a4613b097a26f3e4fa1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("row"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\ErkanPer\source\repos\flappit-web-coremvc\carfully-web-coremvc\Views\Home\Contact.cshtml"
  
    ViewData["Title"] = "Kontakt";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!--====== APPIE PAGE TITLE PART START ======-->

<div class=""appie-page-title-area"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""appie-page-title-item"">
                    <h3 class=""title"">Kontakt</h3>
                    <nav aria-label=""breadcrumb"">
                        <ol class=""breadcrumb"">
                            <li class=""breadcrumb-item""><a href=""/"">Home</a></li>
                            <li class=""breadcrumb-item active"" aria-current=""page"">Kontakt</li>
                        </ol>
                    </nav>
                </div>
            </div>
        </div>
    </div>
</div>

<!--====== APPIE PAGE TITLE PART ENDS ======-->
<!-- Contact Start -->
<section class=""contact-section"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""contact-form"">
                    <h4 style=""text-align:center"">
                   ");
            WriteLiteral(@"     Kontaktiere Uns
                    </h4>
                    <p style=""text-align:center;font-weight:bold"">Fragen ? Wir sind hier, um zu helfen. Konaktiere uns umgehend oder fülle das Formular unten aus. Unsere Mitarbeiter rufen dich innerhalb 24 Stunden zurück.</p>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b51f6719d6d700290f2140fea374269bde7f7ed55973", async() => {
                WriteLiteral(@"
                        <div class=""col-md-6"">
                            <input type=""text"" name=""f-name"" placeholder=""Name*"">
                        </div>
                        <div class=""col-md-6"">
                            <input type=""text"" name=""l-name"" placeholder=""E-Mail Adresse*"">
                        </div>
                        <div class=""col-md-6"">
                            <input type=""email"" name=""email"" placeholder=""Website*"">
                        </div>
                        <div class=""col-md-6"">
                            <input type=""number"" name=""phone"" placeholder=""Vorwahl, Rufnummer*"">
                        </div>
                        <div class=""col-md-12"">
                            <textarea name=""message"" placeholder=""Message""></textarea>
                        </div>
                        <div class=""col-md-6"">
                            <div class=""condition-check"">
                                <input id=""terms-conditions"" type=");
                WriteLiteral(@"""checkbox"">
                                <label for=""terms-conditions"">
                                    Ich habe die <a href=""#"">Datenschutzerklärung</a> zur Kenntnis genommen.
                                </label>
                            </div>
                        </div>
                        <div class=""col-md-6 text-right"">
                            <input type=""submit"" name=""submit"" value=""Send Message"">
                        </div>
                    ");
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
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n<!-- Contact End -->");
        }
        #pragma warning restore 1998
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
