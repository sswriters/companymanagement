#pragma checksum "C:\Users\Anıl\source\repos\sswriters\companymanagement\Web Project\CompanyManagementSystem\CompanyManagementSystem\Views\Home\Customer_Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "793d368250c58d4ab5779acf8c965261fd06532d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Customer_Index), @"mvc.1.0.view", @"/Views/Home/Customer_Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Customer_Index.cshtml", typeof(AspNetCore.Views_Home_Customer_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"793d368250c58d4ab5779acf8c965261fd06532d", @"/Views/Home/Customer_Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af85cd54809876dbbb06cb9d8bd8f093c061dc78", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Customer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Project>>
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
#line 2 "C:\Users\Anıl\source\repos\sswriters\companymanagement\Web Project\CompanyManagementSystem\CompanyManagementSystem\Views\Home\Customer_Index.cshtml"
  
    ViewData["Title"] = "Customer";
    ViewData["Page_Info"] = "Main Page";
    ViewData["Description"] = "You can see your projects here";
    //svar deneme = TempData["Project"].ToString();
    if(TempData["Project"] == null) { TempData["Project"] = "S"; }

#line default
#line hidden
            BeginContext(301, 69, true);
            WriteLiteral("<aside class=\"main-sidebar\">\r\n    <section class=\"sidebar\">\r\n        ");
            EndContext();
            BeginContext(371, 30, false);
#line 11 "C:\Users\Anıl\source\repos\sswriters\companymanagement\Web Project\CompanyManagementSystem\CompanyManagementSystem\Views\Home\Customer_Index.cshtml"
   Write(Html.Partial("_Menu_Customer"));

#line default
#line hidden
            EndContext();
            BeginContext(401, 936, true);
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
#line 37 "C:\Users\Anıl\source\repos\sswriters\companymanagement\Web Project\CompanyManagementSystem\CompanyManagementSystem\Views\Home\Customer_Index.cshtml"
                     foreach (var item in Model)
                    {



                        if (@TempData["Project"].ToString() == @item.projectname)
                        {

#line default
#line hidden
            BeginContext(1526, 119, true);
            WriteLiteral("                            <tbody>\r\n\r\n                                <tr>\r\n\r\n                                    <td>");
            EndContext();
            BeginContext(1646, 14, false);
#line 48 "C:\Users\Anıl\source\repos\sswriters\companymanagement\Web Project\CompanyManagementSystem\CompanyManagementSystem\Views\Home\Customer_Index.cshtml"
                                   Write(item.projectid);

#line default
#line hidden
            EndContext();
            BeginContext(1660, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(1708, 16, false);
#line 49 "C:\Users\Anıl\source\repos\sswriters\companymanagement\Web Project\CompanyManagementSystem\CompanyManagementSystem\Views\Home\Customer_Index.cshtml"
                                   Write(item.projectname);

#line default
#line hidden
            EndContext();
            BeginContext(1724, 51, true);
            WriteLiteral("</td>\r\n\r\n                                    <td>\r\n");
            EndContext();
#line 52 "C:\Users\Anıl\source\repos\sswriters\companymanagement\Web Project\CompanyManagementSystem\CompanyManagementSystem\Views\Home\Customer_Index.cshtml"
                                         if (item.status == "Open")
                                        {

#line default
#line hidden
            BeginContext(1887, 91, true);
            WriteLiteral("                                            <span class=\"label label-success\">Open</span>\r\n");
            EndContext();
#line 55 "C:\Users\Anıl\source\repos\sswriters\companymanagement\Web Project\CompanyManagementSystem\CompanyManagementSystem\Views\Home\Customer_Index.cshtml"
                                        }

#line default
#line hidden
            BeginContext(2021, 40, true);
            WriteLiteral("                                        ");
            EndContext();
#line 56 "C:\Users\Anıl\source\repos\sswriters\companymanagement\Web Project\CompanyManagementSystem\CompanyManagementSystem\Views\Home\Customer_Index.cshtml"
                                         if (item.status == "Closed")
                                        {

#line default
#line hidden
            BeginContext(2135, 92, true);
            WriteLiteral("                                            <span class=\"label label-danger\">Closed</span>\r\n");
            EndContext();
#line 59 "C:\Users\Anıl\source\repos\sswriters\companymanagement\Web Project\CompanyManagementSystem\CompanyManagementSystem\Views\Home\Customer_Index.cshtml"
                                        }

#line default
#line hidden
            BeginContext(2270, 40, true);
            WriteLiteral("                                        ");
            EndContext();
#line 60 "C:\Users\Anıl\source\repos\sswriters\companymanagement\Web Project\CompanyManagementSystem\CompanyManagementSystem\Views\Home\Customer_Index.cshtml"
                                         if (item.status == "Pending")
                                        {

#line default
#line hidden
            BeginContext(2385, 94, true);
            WriteLiteral("                                            <span class=\"label label-warning\">Pending</span>\r\n");
            EndContext();
#line 63 "C:\Users\Anıl\source\repos\sswriters\companymanagement\Web Project\CompanyManagementSystem\CompanyManagementSystem\Views\Home\Customer_Index.cshtml"
                                        }

#line default
#line hidden
            BeginContext(2522, 89, true);
            WriteLiteral("                                    </td>\r\n\r\n\r\n\r\n                                    <td>");
            EndContext();
            BeginContext(2612, 20, false);
#line 68 "C:\Users\Anıl\source\repos\sswriters\companymanagement\Web Project\CompanyManagementSystem\CompanyManagementSystem\Views\Home\Customer_Index.cshtml"
                                   Write(item.assigned_people);

#line default
#line hidden
            EndContext();
            BeginContext(2632, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(2680, 12, false);
#line 69 "C:\Users\Anıl\source\repos\sswriters\companymanagement\Web Project\CompanyManagementSystem\CompanyManagementSystem\Views\Home\Customer_Index.cshtml"
                                   Write(item.duedate);

#line default
#line hidden
            EndContext();
            BeginContext(2692, 154, true);
            WriteLiteral("</td>\r\n                                    <td>\r\n                                        <div class=\"tools\">\r\n                                            ");
            EndContext();
            BeginContext(2846, 124, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "637a0d6c921844d2afd0d22527847531", async() => {
                BeginContext(2930, 36, true);
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
#line 72 "C:\Users\Anıl\source\repos\sswriters\companymanagement\Web Project\CompanyManagementSystem\CompanyManagementSystem\Views\Home\Customer_Index.cshtml"
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
            BeginContext(2970, 67, true);
            WriteLiteral("\r\n                                            <!--<a asp-route-id=\"");
            EndContext();
            BeginContext(3038, 14, false);
#line 73 "C:\Users\Anıl\source\repos\sswriters\companymanagement\Web Project\CompanyManagementSystem\CompanyManagementSystem\Views\Home\Customer_Index.cshtml"
                                                            Write(item.projectid);

#line default
#line hidden
            EndContext();
            BeginContext(3052, 269, true);
            WriteLiteral(@""" asp-controller=""Home"" asp-action=""Project_Delete""><i class=""fa fa-trash-o text-red""></i></a>-->
                                        </div>
                                    </td>
                                </tr>

                            </tbody>
");
            EndContext();
#line 79 "C:\Users\Anıl\source\repos\sswriters\companymanagement\Web Project\CompanyManagementSystem\CompanyManagementSystem\Views\Home\Customer_Index.cshtml"

                        }

                }

#line default
#line hidden
            BeginContext(3371, 88, true);
            WriteLiteral("                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
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
