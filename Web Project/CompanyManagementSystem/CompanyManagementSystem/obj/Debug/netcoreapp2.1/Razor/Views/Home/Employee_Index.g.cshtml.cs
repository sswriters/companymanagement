#pragma checksum "C:\Users\Anıl\source\repos\sswriters\companymanagement\Web Project\CompanyManagementSystem\CompanyManagementSystem\Views\Home\Employee_Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea8b461f5e4541468a614940c3a913f61a571d97"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Employee_Index), @"mvc.1.0.view", @"/Views/Home/Employee_Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Employee_Index.cshtml", typeof(AspNetCore.Views_Home_Employee_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea8b461f5e4541468a614940c3a913f61a571d97", @"/Views/Home/Employee_Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af85cd54809876dbbb06cb9d8bd8f093c061dc78", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Employee_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Project_Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Anıl\source\repos\sswriters\companymanagement\Web Project\CompanyManagementSystem\CompanyManagementSystem\Views\Home\Employee_Index.cshtml"
  
    ViewData["Title"] = "Employee";
    ViewData["Page_Info"] = "Main Page";
    ViewData["Description"] = "You can see projects here";

#line default
#line hidden
            BeginContext(148, 69, true);
            WriteLiteral("<aside class=\"main-sidebar\">\r\n    <section class=\"sidebar\">\r\n        ");
            EndContext();
            BeginContext(218, 30, false);
#line 9 "C:\Users\Anıl\source\repos\sswriters\companymanagement\Web Project\CompanyManagementSystem\CompanyManagementSystem\Views\Home\Employee_Index.cshtml"
   Write(Html.Partial("_Menu_Employee"));

#line default
#line hidden
            EndContext();
            BeginContext(248, 936, true);
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
                    </thead>
");
            EndContext();
#line 35 "C:\Users\Anıl\source\repos\sswriters\companymanagement\Web Project\CompanyManagementSystem\CompanyManagementSystem\Views\Home\Employee_Index.cshtml"
                     foreach (var item in Model)
                    {



                        if (@TempData["Project"].ToString() == @item.projectname)
                        {

#line default
#line hidden
            BeginContext(1373, 119, true);
            WriteLiteral("                            <tbody>\r\n\r\n                                <tr>\r\n\r\n                                    <td>");
            EndContext();
            BeginContext(1493, 14, false);
#line 46 "C:\Users\Anıl\source\repos\sswriters\companymanagement\Web Project\CompanyManagementSystem\CompanyManagementSystem\Views\Home\Employee_Index.cshtml"
                                   Write(item.projectid);

#line default
#line hidden
            EndContext();
            BeginContext(1507, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(1555, 16, false);
#line 47 "C:\Users\Anıl\source\repos\sswriters\companymanagement\Web Project\CompanyManagementSystem\CompanyManagementSystem\Views\Home\Employee_Index.cshtml"
                                   Write(item.projectname);

#line default
#line hidden
            EndContext();
            BeginContext(1571, 51, true);
            WriteLiteral("</td>\r\n\r\n                                    <td>\r\n");
            EndContext();
#line 50 "C:\Users\Anıl\source\repos\sswriters\companymanagement\Web Project\CompanyManagementSystem\CompanyManagementSystem\Views\Home\Employee_Index.cshtml"
                                         if (item.status == "Open")
                                        {

#line default
#line hidden
            BeginContext(1734, 91, true);
            WriteLiteral("                                            <span class=\"label label-success\">Open</span>\r\n");
            EndContext();
#line 53 "C:\Users\Anıl\source\repos\sswriters\companymanagement\Web Project\CompanyManagementSystem\CompanyManagementSystem\Views\Home\Employee_Index.cshtml"
                                        }

#line default
#line hidden
            BeginContext(1868, 40, true);
            WriteLiteral("                                        ");
            EndContext();
#line 54 "C:\Users\Anıl\source\repos\sswriters\companymanagement\Web Project\CompanyManagementSystem\CompanyManagementSystem\Views\Home\Employee_Index.cshtml"
                                         if (item.status == "Closed")
                                        {

#line default
#line hidden
            BeginContext(1982, 92, true);
            WriteLiteral("                                            <span class=\"label label-danger\">Closed</span>\r\n");
            EndContext();
#line 57 "C:\Users\Anıl\source\repos\sswriters\companymanagement\Web Project\CompanyManagementSystem\CompanyManagementSystem\Views\Home\Employee_Index.cshtml"
                                        }

#line default
#line hidden
            BeginContext(2117, 40, true);
            WriteLiteral("                                        ");
            EndContext();
#line 58 "C:\Users\Anıl\source\repos\sswriters\companymanagement\Web Project\CompanyManagementSystem\CompanyManagementSystem\Views\Home\Employee_Index.cshtml"
                                         if (item.status == "Pending")
                                        {

#line default
#line hidden
            BeginContext(2232, 94, true);
            WriteLiteral("                                            <span class=\"label label-warning\">Pending</span>\r\n");
            EndContext();
#line 61 "C:\Users\Anıl\source\repos\sswriters\companymanagement\Web Project\CompanyManagementSystem\CompanyManagementSystem\Views\Home\Employee_Index.cshtml"
                                        }

#line default
#line hidden
            BeginContext(2369, 89, true);
            WriteLiteral("                                    </td>\r\n\r\n\r\n\r\n                                    <td>");
            EndContext();
            BeginContext(2459, 20, false);
#line 66 "C:\Users\Anıl\source\repos\sswriters\companymanagement\Web Project\CompanyManagementSystem\CompanyManagementSystem\Views\Home\Employee_Index.cshtml"
                                   Write(item.assigned_people);

#line default
#line hidden
            EndContext();
            BeginContext(2479, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(2527, 12, false);
#line 67 "C:\Users\Anıl\source\repos\sswriters\companymanagement\Web Project\CompanyManagementSystem\CompanyManagementSystem\Views\Home\Employee_Index.cshtml"
                                   Write(item.duedate);

#line default
#line hidden
            EndContext();
            BeginContext(2539, 154, true);
            WriteLiteral("</td>\r\n                                    <td>\r\n                                        <div class=\"tools\">\r\n                                            ");
            EndContext();
            BeginContext(2693, 124, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5570f4aec4b74f938ebdd004ae7bb626", async() => {
                BeginContext(2777, 36, true);
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
#line 70 "C:\Users\Anıl\source\repos\sswriters\companymanagement\Web Project\CompanyManagementSystem\CompanyManagementSystem\Views\Home\Employee_Index.cshtml"
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
            BeginContext(2817, 67, true);
            WriteLiteral("\r\n                                            <!--<a asp-route-id=\"");
            EndContext();
            BeginContext(2885, 14, false);
#line 71 "C:\Users\Anıl\source\repos\sswriters\companymanagement\Web Project\CompanyManagementSystem\CompanyManagementSystem\Views\Home\Employee_Index.cshtml"
                                                            Write(item.projectid);

#line default
#line hidden
            EndContext();
            BeginContext(2899, 269, true);
            WriteLiteral(@""" asp-controller=""Home"" asp-action=""Project_Delete""><i class=""fa fa-trash-o text-red""></i></a>-->
                                        </div>
                                    </td>
                                </tr>

                            </tbody>
");
            EndContext();
#line 77 "C:\Users\Anıl\source\repos\sswriters\companymanagement\Web Project\CompanyManagementSystem\CompanyManagementSystem\Views\Home\Employee_Index.cshtml"

                        }

                    }

#line default
#line hidden
            BeginContext(3222, 84, true);
            WriteLiteral("                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
