#pragma checksum "F:\Project\Protal with Cloud\ReturnOrderPortal\Views\User\Confirmation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14ee193a482410aa2cd382552700a40ed781e8a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Confirmation), @"mvc.1.0.view", @"/Views/User/Confirmation.cshtml")]
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
#line 1 "F:\Project\Protal with Cloud\ReturnOrderPortal\Views\_ViewImports.cshtml"
using ReturnOrderPortal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Project\Protal with Cloud\ReturnOrderPortal\Views\_ViewImports.cshtml"
using ReturnOrderPortal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14ee193a482410aa2cd382552700a40ed781e8a4", @"/Views/User/Confirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"850e3eaf546a47a31ba688e63823c53c08ba9cc2", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Confirmation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ReturnOrderPortal.Models.ProcessResponse>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\Project\Protal with Cloud\ReturnOrderPortal\Views\User\Confirmation.cshtml"
  
    ViewData["Title"] = "ProcessResponse";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14ee193a482410aa2cd382552700a40ed781e8a43544", async() => {
                WriteLiteral("\r\n    <link href=\"https://maxcdn.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css\" rel=\"stylesheet\" />\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14ee193a482410aa2cd382552700a40ed781e8a44624", async() => {
                WriteLiteral("\r\n    <h1>Processed successfully</h1>\r\n    <table>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 17 "F:\Project\Protal with Cloud\ReturnOrderPortal\Views\User\Confirmation.cshtml"
           Write(Html.Label("Request Id"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 19 "F:\Project\Protal with Cloud\ReturnOrderPortal\Views\User\Confirmation.cshtml"
           Write(Html.Display("RequestId"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 22 "F:\Project\Protal with Cloud\ReturnOrderPortal\Views\User\Confirmation.cshtml"
           Write(Html.Label("Processing Charge"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 24 "F:\Project\Protal with Cloud\ReturnOrderPortal\Views\User\Confirmation.cshtml"
           Write(Html.Display("ProcessingCharge"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 27 "F:\Project\Protal with Cloud\ReturnOrderPortal\Views\User\Confirmation.cshtml"
           Write(Html.Label("PackagingAndDeliveryCharge"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 29 "F:\Project\Protal with Cloud\ReturnOrderPortal\Views\User\Confirmation.cshtml"
           Write(Html.Display("PackagingAndDeliveryCharge"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 32 "F:\Project\Protal with Cloud\ReturnOrderPortal\Views\User\Confirmation.cshtml"
           Write(Html.Label("DateOfDelivery"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 34 "F:\Project\Protal with Cloud\ReturnOrderPortal\Views\User\Confirmation.cshtml"
           Write(Html.Display("DateOfDelivery"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        </tr>\r\n\r\n    </table>\r\n\r\n   \r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ReturnOrderPortal.Models.ProcessResponse> Html { get; private set; }
    }
}
#pragma warning restore 1591