#pragma checksum "C:\Users\Anıl\source\repos\sswriters\companymanagement\Web Project\CompanyManagementSystem\CompanyManagementSystem\Views\Home\Manager_Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7328c01e88c46dd508af128451ccfa849041243f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Manager_Index), @"mvc.1.0.view", @"/Views/Home/Manager_Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Manager_Index.cshtml", typeof(AspNetCore.Views_Home_Manager_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7328c01e88c46dd508af128451ccfa849041243f", @"/Views/Home/Manager_Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af85cd54809876dbbb06cb9d8bd8f093c061dc78", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Manager_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Project>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Project_Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Project_Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(29, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 2 "C:\Users\Anıl\source\repos\sswriters\companymanagement\Web Project\CompanyManagementSystem\CompanyManagementSystem\Views\Home\Manager_Index.cshtml"
      
        ViewData["Title"] = "Manager";
        ViewData["Page_Info"] = "Main Page";
        ViewData["Description"] = "You can see projects here";
    

#line default
#line hidden
            BeginContext(194, 81, true);
            WriteLiteral("    <aside class=\"main-sidebar\">\r\n        <section class=\"sidebar\">\r\n            ");
            EndContext();
            BeginContext(276, 29, false);
#line 9 "C:\Users\Anıl\source\repos\sswriters\companymanagement\Web Project\CompanyManagementSystem\CompanyManagementSystem\Views\Home\Manager_Index.cshtml"
       Write(Html.Partial("_Menu_Manager"));

#line default
#line hidden
            EndContext();
            BeginContext(305, 1032, true);
            WriteLiteral(@"

        </section>
    </aside>
    <section class=""content container-fluid"">
        <div class=""box box-info"">
            <div class=""box-header with-border"">
                <h3 class=""box-title"">Users</h3>
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
                                <th>Project ID</th>
                                <th>Project Name</th>
                                <th>Status</th>
                                <th>Assigned People</th>
                                <th>Due Date</th>
                            </tr>
                        </");
            WriteLiteral("thead>\r\n");
            EndContext();
#line 35 "C:\Users\Anıl\source\repos\sswriters\companymanagement\Web Project\CompanyManagementSystem\CompanyManagementSystem\Views\Home\Manager_Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
            BeginContext(1418, 117, true);
            WriteLiteral("                            <tbody>\r\n\r\n                                <tr>\r\n                                    <td>");
            EndContext();
            BeginContext(1536, 14, false);
#line 40 "C:\Users\Anıl\source\repos\sswriters\companymanagement\Web Project\CompanyManagementSystem\CompanyManagementSystem\Views\Home\Manager_Index.cshtml"
                                   Write(item.projectid);

#line default
#line hidden
            EndContext();
            BeginContext(1550, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(1598, 16, false);
#line 41 "C:\Users\Anıl\source\repos\sswriters\companymanagement\Web Project\CompanyManagementSystem\CompanyManagementSystem\Views\Home\Manager_Index.cshtml"
                                   Write(item.projectname);

#line default
#line hidden
            EndContext();
            BeginContext(1614, 51, true);
            WriteLiteral("</td>\r\n\r\n                                    <td>\r\n");
            EndContext();
#line 44 "C:\Users\Anıl\source\repos\sswriters\companymanagement\Web Project\CompanyManagementSystem\CompanyManagementSystem\Views\Home\Manager_Index.cshtml"
                                         if (item.status == "Open")
                                        {

#line default
#line hidden
            BeginContext(1777, 91, true);
            WriteLiteral("                                            <span class=\"label label-success\">Open</span>\r\n");
            EndContext();
#line 47 "C:\Users\Anıl\source\repos\sswriters\companymanagement\Web Project\CompanyManagementSystem\CompanyManagementSystem\Views\Home\Manager_Index.cshtml"
                                        }

#line default
#line hidden
            BeginContext(1911, 40, true);
            WriteLiteral("                                        ");
            EndContext();
#line 48 "C:\Users\Anıl\source\repos\sswriters\companymanagement\Web Project\CompanyManagementSystem\CompanyManagementSystem\Views\Home\Manager_Index.cshtml"
                                         if (item.status == "Closed")
                                        {

#line default
#line hidden
            BeginContext(2025, 92, true);
            WriteLiteral("                                            <span class=\"label label-danger\">Closed</span>\r\n");
            EndContext();
#line 51 "C:\Users\Anıl\source\repos\sswriters\companymanagement\Web Project\CompanyManagementSystem\CompanyManagementSystem\Views\Home\Manager_Index.cshtml"
                                        }

#line default
#line hidden
            BeginContext(2160, 40, true);
            WriteLiteral("                                        ");
            EndContext();
#line 52 "C:\Users\Anıl\source\repos\sswriters\companymanagement\Web Project\CompanyManagementSystem\CompanyManagementSystem\Views\Home\Manager_Index.cshtml"
                                         if (item.status == "Pending")
                                        {

#line default
#line hidden
            BeginContext(2275, 94, true);
            WriteLiteral("                                            <span class=\"label label-warning\">Pending</span>\r\n");
            EndContext();
#line 55 "C:\Users\Anıl\source\repos\sswriters\companymanagement\Web Project\CompanyManagementSystem\CompanyManagementSystem\Views\Home\Manager_Index.cshtml"
                                        }

#line default
#line hidden
            BeginContext(2412, 89, true);
            WriteLiteral("                                    </td>\r\n\r\n\r\n\r\n                                    <td>");
            EndContext();
            BeginContext(2502, 20, false);
#line 60 "C:\Users\Anıl\source\repos\sswriters\companymanagement\Web Project\CompanyManagementSystem\CompanyManagementSystem\Views\Home\Manager_Index.cshtml"
                                   Write(item.assigned_people);

#line default
#line hidden
            EndContext();
            BeginContext(2522, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(2570, 12, false);
#line 61 "C:\Users\Anıl\source\repos\sswriters\companymanagement\Web Project\CompanyManagementSystem\CompanyManagementSystem\Views\Home\Manager_Index.cshtml"
                                   Write(item.duedate);

#line default
#line hidden
            EndContext();
            BeginContext(2582, 154, true);
            WriteLiteral("</td>\r\n                                    <td>\r\n                                        <div class=\"tools\">\r\n                                            ");
            EndContext();
            BeginContext(2736, 124, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b28a88f9e5574a3f88d4fbfce2bbb4be", async() => {
                BeginContext(2820, 36, true);
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
#line 64 "C:\Users\Anıl\source\repos\sswriters\companymanagement\Web Project\CompanyManagementSystem\CompanyManagementSystem\Views\Home\Manager_Index.cshtml"
                                                 WriteLiteral(item.projectid);

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
            BeginContext(2860, 46, true);
            WriteLiteral("\r\n                                            ");
            EndContext();
            BeginContext(2906, 126, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "226e6921adad4e85a98992ee11c4643d", async() => {
                BeginContext(2990, 38, true);
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
#line 65 "C:\Users\Anıl\source\repos\sswriters\companymanagement\Web Project\CompanyManagementSystem\CompanyManagementSystem\Views\Home\Manager_Index.cshtml"
                                                 WriteLiteral(item.projectid);

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
            BeginContext(3032, 172, true);
            WriteLiteral("\r\n                                        </div>\r\n                                    </td>\r\n                                </tr>\r\n\r\n                            </tbody>\r\n");
            EndContext();
#line 71 "C:\Users\Anıl\source\repos\sswriters\companymanagement\Web Project\CompanyManagementSystem\CompanyManagementSystem\Views\Home\Manager_Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(3231, 291, true);
            WriteLiteral(@"                    </table>
                </div>
            </div>
            <div class=""box-footer clearfix"">
                <a href=""Add_Project"" class=""btn btn-sm btn-info btn-flat pull-left"">Add Project</a>
            </div>
        </div>    
        
    </section>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Project>> Html { get; private set; }
    }
}
#pragma warning restore 1591
