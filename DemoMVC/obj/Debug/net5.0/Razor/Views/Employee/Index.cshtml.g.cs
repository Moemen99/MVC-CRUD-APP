#pragma checksum "E:\.NetProjects\DemoMVC\DemoMVC\Views\Employee\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb4b9c12d3c8dddaa022eac7d9d7a73e053f9e64"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Index), @"mvc.1.0.view", @"/Views/Employee/Index.cshtml")]
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
#line 1 "E:\.NetProjects\DemoMVC\DemoMVC\Views\_ViewImports.cshtml"
using DemoMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\.NetProjects\DemoMVC\DemoMVC\Views\_ViewImports.cshtml"
using DemoMVC.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\.NetProjects\DemoMVC\DemoMVC\Views\_ViewImports.cshtml"
using Demo.DAL.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb4b9c12d3c8dddaa022eac7d9d7a73e053f9e64", @"/Views/Employee/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28949729feebce92290a01b67af4958702bc6814", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Employee_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Employee>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ButtonsPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\.NetProjects\DemoMVC\DemoMVC\Views\Employee\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"mt-4\">All Employees</h1>\r\n<br />\r\n<br />\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb4b9c12d3c8dddaa022eac7d9d7a73e053f9e644607", async() => {
                WriteLiteral("Create New Employee");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 13 "E:\.NetProjects\DemoMVC\DemoMVC\Views\Employee\Index.cshtml"
 if(Model.Count() > 0){

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table table-striped mt-4\">\r\n        <thead >\r\n            <tr>\r\n                <th>");
#nullable restore
#line 17 "E:\.NetProjects\DemoMVC\DemoMVC\Views\Employee\Index.cshtml"
               Write(Html.DisplayNameFor(E => E.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 18 "E:\.NetProjects\DemoMVC\DemoMVC\Views\Employee\Index.cshtml"
               Write(Html.DisplayNameFor(E => E.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 19 "E:\.NetProjects\DemoMVC\DemoMVC\Views\Employee\Index.cshtml"
               Write(Html.DisplayNameFor(E => E.Salary));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 20 "E:\.NetProjects\DemoMVC\DemoMVC\Views\Employee\Index.cshtml"
               Write(Html.DisplayNameFor(E => E.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 21 "E:\.NetProjects\DemoMVC\DemoMVC\Views\Employee\Index.cshtml"
               Write(Html.DisplayNameFor(E => E.IsActive));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 22 "E:\.NetProjects\DemoMVC\DemoMVC\Views\Employee\Index.cshtml"
               Write(Html.DisplayNameFor(E => E.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 23 "E:\.NetProjects\DemoMVC\DemoMVC\Views\Employee\Index.cshtml"
               Write(Html.DisplayNameFor(E => E.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 24 "E:\.NetProjects\DemoMVC\DemoMVC\Views\Employee\Index.cshtml"
               Write(Html.DisplayNameFor(E => E.HireDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>Details</th>\r\n                <th>Update</th>\r\n                <th>Delete</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 31 "E:\.NetProjects\DemoMVC\DemoMVC\Views\Employee\Index.cshtml"
             foreach (var emp in Model)
           {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 34 "E:\.NetProjects\DemoMVC\DemoMVC\Views\Employee\Index.cshtml"
               Write(emp.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 35 "E:\.NetProjects\DemoMVC\DemoMVC\Views\Employee\Index.cshtml"
                   Write(emp.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 36 "E:\.NetProjects\DemoMVC\DemoMVC\Views\Employee\Index.cshtml"
                   Write(Html.DisplayFor(M=> emp.Salary));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 37 "E:\.NetProjects\DemoMVC\DemoMVC\Views\Employee\Index.cshtml"
                   Write(emp.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 38 "E:\.NetProjects\DemoMVC\DemoMVC\Views\Employee\Index.cshtml"
                   Write(Html.DisplayFor(M=> emp.IsActive));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 39 "E:\.NetProjects\DemoMVC\DemoMVC\Views\Employee\Index.cshtml"
                   Write(Html.DisplayFor(M=> emp.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 40 "E:\.NetProjects\DemoMVC\DemoMVC\Views\Employee\Index.cshtml"
                   Write(emp.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 41 "E:\.NetProjects\DemoMVC\DemoMVC\Views\Employee\Index.cshtml"
                   Write(emp.HireDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n               ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bb4b9c12d3c8dddaa022eac7d9d7a73e053f9e6410676", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 43 "E:\.NetProjects\DemoMVC\DemoMVC\Views\Employee\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = emp.Id;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </tr>\r\n");
#nullable restore
#line 45 "E:\.NetProjects\DemoMVC\DemoMVC\Views\Employee\Index.cshtml"
            
           
               
           }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 52 "E:\.NetProjects\DemoMVC\DemoMVC\Views\Employee\Index.cshtml"
}
else{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-warning mt-4\">No Employees Available :(</div>\r\n");
#nullable restore
#line 55 "E:\.NetProjects\DemoMVC\DemoMVC\Views\Employee\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Employee>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
