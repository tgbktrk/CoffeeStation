#pragma checksum "/Users/tugbaakturk/Desktop/CoffeeStation/IdentityServer/CoffeeStation.IdentityServer/Views/Shared/Redirect.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9d983226aa948358024f33ef711d3f236961382a389a27be6e7bc0875d7a470f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Redirect), @"mvc.1.0.view", @"/Views/Shared/Redirect.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "/Users/tugbaakturk/Desktop/CoffeeStation/IdentityServer/CoffeeStation.IdentityServer/Views/_ViewImports.cshtml"
using IdentityServerHost.Quickstart.UI

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"9d983226aa948358024f33ef711d3f236961382a389a27be6e7bc0875d7a470f", @"/Views/Shared/Redirect.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"a37bb02fe3277db53ef664b0b2223d70455027585a6423f2ad507316524fd6fa", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Redirect : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RedirectViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/signin-redirect.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<div class=\"redirect-page\">\r\n    <div class=\"lead\">\r\n        <h1>You are now being returned to the application</h1>\r\n        <p>Once complete, you may close this tab.</p>\r\n    </div>\r\n</div>\r\n\r\n<meta http-equiv=\"refresh\"");
            BeginWriteAttribute("content", " content=\"", 248, "\"", 282, 2);
            WriteAttributeValue("", 258, "0;url=", 258, 6, true);
            WriteAttributeValue("", 264, 
#nullable restore
#line 10 "/Users/tugbaakturk/Desktop/CoffeeStation/IdentityServer/CoffeeStation.IdentityServer/Views/Shared/Redirect.cshtml"
                                           Model.RedirectUrl

#line default
#line hidden
#nullable disable
            , 264, 18, false);
            EndWriteAttribute();
            WriteLiteral(" data-url=\"");
            Write(
#nullable restore
#line 10 "/Users/tugbaakturk/Desktop/CoffeeStation/IdentityServer/CoffeeStation.IdentityServer/Views/Shared/Redirect.cshtml"
                                                                         Model.RedirectUrl

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d983226aa948358024f33ef711d3f236961382a389a27be6e7bc0875d7a470f4645", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RedirectViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
