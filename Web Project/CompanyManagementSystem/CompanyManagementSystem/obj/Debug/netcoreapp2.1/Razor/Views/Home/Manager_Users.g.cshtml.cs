#pragma checksum "C:\Users\Anıl\source\repos\sswriters\companymanagement\Web Project\CompanyManagementSystem\CompanyManagementSystem\Views\Home\Manager_Users.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d47559a0081fc253d7832f5fbfa0b0a3ace1484a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Manager_Users), @"mvc.1.0.view", @"/Views/Home/Manager_Users.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Manager_Users.cshtml", typeof(AspNetCore.Views_Home_Manager_Users))]
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
#line 1 "C:\Users\Anıl\source\repos\sswriters\companymanagement\Web Project\CompanyManagementSystem\CompanyManagementSystem\Views\_ViewImports.cshtml"
using CompanyManagementSystem;

#line default
#line hidden
#line 2 "C:\Users\Anıl\source\repos\sswriters\companymanagement\Web Project\CompanyManagementSystem\CompanyManagementSystem\Views\_ViewImports.cshtml"
using CompanyManagementSystem.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d47559a0081fc253d7832f5fbfa0b0a3ace1484a", @"/Views/Home/Manager_Users.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af85cd54809876dbbb06cb9d8bd8f093c061dc78", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Manager_Users : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<People>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "User_Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete_User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Anıl\source\repos\sswriters\companymanagement\Web Project\CompanyManagementSystem\CompanyManagementSystem\Views\Home\Manager_Users.cshtml"
  
    ViewData["Title"] = "Manager";
    ViewData["Page_Info"] = "User Management";
    ViewData["Description"] = "You can manage users here";

#line default
#line hidden
            BeginContext(179, 71, true);
            WriteLiteral("\r\n<aside class=\"main-sidebar\">\r\n    <section class=\"sidebar\">\r\n        ");
            EndContext();
            BeginContext(251, 29, false);
#line 10 "C:\Users\Anıl\source\repos\sswriters\companymanagement\Web Project\CompanyManagementSystem\CompanyManagementSystem\Views\Home\Manager_Users.cshtml"
   Write(Html.Partial("_Menu_Manager"));

#line default
#line hidden
            EndContext();
            BeginContext(280, 920, true);
            WriteLiteral(@"

    </section>
</aside>
<section class=""content container-fluid"">
    <div class=""box box-info"">
        <div class=""box-header with-border"">
            <h3 class=""box-title"">Projects</h3>
            <div class=""box-tools pull-right"">
                <button type=""button"" class=""btn btn-box-tool"" data-widget=""collapse"">
                    <i class=""fa fa-minus""></i>
                </button>
            </div>
        </div>
        <div class=""box-body"">
            <div class=""table-responsive"">
                <table class=""table no-margin"">
                    <thead>
                        <tr>
                            <th>Full Name</th>
                            <th>E-mail</th>
                            <th>Phone</th>
                            <th>Role</th>
                            <th>Projects</th>
                        </tr>
                    </thead>
");
            EndContext();
#line 36 "C:\Users\Anıl\source\repos\sswriters\companymanagement\Web Project\CompanyManagementSystem\CompanyManagementSystem\Views\Home\Manager_Users.cshtml"
                     foreach (var Person in Model )
                    {

#line default
#line hidden
            BeginContext(1276, 103, true);
            WriteLiteral("                        <tbody>\r\n                            <tr>\r\n                                <td>");
            EndContext();
            BeginContext(1380, 11, false);
#line 40 "C:\Users\Anıl\source\repos\sswriters\companymanagement\Web Project\CompanyManagementSystem\CompanyManagementSystem\Views\Home\Manager_Users.cshtml"
                               Write(Person.name);

#line default
#line hidden
            EndContext();
            BeginContext(1391, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(1435, 11, false);
#line 41 "C:\Users\Anıl\source\repos\sswriters\companymanagement\Web Project\CompanyManagementSystem\CompanyManagementSystem\Views\Home\Manager_Users.cshtml"
                               Write(Person.mail);

#line default
#line hidden
            EndContext();
            BeginContext(1446, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(1490, 12, false);
#line 42 "C:\Users\Anıl\source\repos\sswriters\companymanagement\Web Project\CompanyManagementSystem\CompanyManagementSystem\Views\Home\Manager_Users.cshtml"
                               Write(Person.phone);

#line default
#line hidden
            EndContext();
            BeginContext(1502, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(1546, 11, false);
#line 43 "C:\Users\Anıl\source\repos\sswriters\companymanagement\Web Project\CompanyManagementSystem\CompanyManagementSystem\Views\Home\Manager_Users.cshtml"
                               Write(Person.role);

#line default
#line hidden
            EndContext();
            BeginContext(1557, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(1601, 15, false);
#line 44 "C:\Users\Anıl\source\repos\sswriters\companymanagement\Web Project\CompanyManagementSystem\CompanyManagementSystem\Views\Home\Manager_Users.cshtml"
                               Write(Person.projects);

#line default
#line hidden
            EndContext();
            BeginContext(1616, 144, true);
            WriteLiteral("</td>\r\n                                <td>\r\n                                    <div class=\"tools\">\r\n\r\n                                        ");
            EndContext();
            BeginContext(1760, 118, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "838c27f2c53b4e1995621bb895be9cfe", async() => {
                BeginContext(1838, 36, true);
                WriteLiteral("<i class=\"fa fa-edit text-aqua\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 48 "C:\Users\Anıl\source\repos\sswriters\companymanagement\Web Project\CompanyManagementSystem\CompanyManagementSystem\Views\Home\Manager_Users.cshtml"
                                             WriteLiteral(Person.name);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1878, 42, true);
            WriteLiteral("\r\n                                        ");
            EndContext();
            BeginContext(1920, 120, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a627bff59104ef8bac63eb38ceda3e2", async() => {
                BeginContext(1998, 38, true);
                WriteLiteral("<i class=\"fa fa-trash-o text-red\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 49 "C:\Users\Anıl\source\repos\sswriters\companymanagement\Web Project\CompanyManagementSystem\CompanyManagementSystem\Views\Home\Manager_Users.cshtml"
                                             WriteLiteral(Person.name);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2040, 156, true);
            WriteLiteral("\r\n                                    </div>\r\n                                </td>\r\n                            </tr>\r\n\r\n                        </tbody>\r\n");
            EndContext();
#line 55 "C:\Users\Anıl\source\repos\sswriters\companymanagement\Web Project\CompanyManagementSystem\CompanyManagementSystem\Views\Home\Manager_Users.cshtml"
                    }

#line default
#line hidden
            BeginContext(2219, 223, true);
            WriteLiteral("                </table>\r\n            </div>\r\n        </div>\r\n        <div class=\"box-footer clearfix\">\r\n            <a href=\"Add_User\" class=\"btn btn-sm btn-info btn-flat pull-left\">Add User</a>\r\n        </div>\r\n</section>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<People>> Html { get; private set; }
    }
}
#pragma warning restore 1591
