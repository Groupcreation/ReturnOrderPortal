#pragma checksum "F:\Project\Protal with Cloud\ReturnOrderPortal\Views\User\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0046be241d340a2d885b623a9dc341e3970e13a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Login), @"mvc.1.0.view", @"/Views/User/Login.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0046be241d340a2d885b623a9dc341e3970e13a", @"/Views/User/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"850e3eaf546a47a31ba688e63823c53c08ba9cc2", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ReturnOrderPortal.Models.User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "F:\Project\Protal with Cloud\ReturnOrderPortal\Views\User\Login.cshtml"
  
    ViewBag.Title = "login";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h2>login</h2>\r\n");
#nullable restore
#line 12 "F:\Project\Protal with Cloud\ReturnOrderPortal\Views\User\Login.cshtml"
 using (Html.BeginForm("Authentication", "User", FormMethod.Post))
{
    //this is for create form tag
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "F:\Project\Protal with Cloud\ReturnOrderPortal\Views\User\Login.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "F:\Project\Protal with Cloud\ReturnOrderPortal\Views\User\Login.cshtml"
                             // this is for prevent CSRF attack
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "F:\Project\Protal with Cloud\ReturnOrderPortal\Views\User\Login.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 21 "F:\Project\Protal with Cloud\ReturnOrderPortal\Views\User\Login.cshtml"
           Write(Html.LabelFor(a => a.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 22 "F:\Project\Protal with Cloud\ReturnOrderPortal\Views\User\Login.cshtml"
           Write(Html.TextBoxFor(a => a.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "F:\Project\Protal with Cloud\ReturnOrderPortal\Views\User\Login.cshtml"
           Write(Html.ValidationMessageFor(a => a.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 27 "F:\Project\Protal with Cloud\ReturnOrderPortal\Views\User\Login.cshtml"
           Write(Html.LabelFor(a => a.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 30 "F:\Project\Protal with Cloud\ReturnOrderPortal\Views\User\Login.cshtml"
           Write(Html.PasswordFor(a => a.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 33 "F:\Project\Protal with Cloud\ReturnOrderPortal\Views\User\Login.cshtml"
           Write(Html.ValidationMessageFor(a => a.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td></td>\r\n            <td>\r\n                <input type=\"submit\" value=\"Login\" />\r\n            </td>\r\n            <td></td>\r\n        </tr>\r\n    </table>\r\n");
#nullable restore
#line 44 "F:\Project\Protal with Cloud\ReturnOrderPortal\Views\User\Login.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "F:\Project\Protal with Cloud\ReturnOrderPortal\Views\User\Login.cshtml"
 if (ViewBag.Message != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <script type=\"text/javascript\">\r\n\r\n            window.onload = function () {\r\n                alert(\"");
#nullable restore
#line 50 "F:\Project\Protal with Cloud\ReturnOrderPortal\Views\User\Login.cshtml"
                  Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\");\r\n            };\r\n    </script>\r\n");
#nullable restore
#line 53 "F:\Project\Protal with Cloud\ReturnOrderPortal\Views\User\Login.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ReturnOrderPortal.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
