#pragma checksum "C:\Users\M6800\Downloads\Dapper-Laabki-main\Dapper-Laabki-main\Views\Home\EmployeesByCity.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a8381958ee78f71a06017e0136516a40b60ad0e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_EmployeesByCity), @"mvc.1.0.view", @"/Views/Home/EmployeesByCity.cshtml")]
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
#line 1 "C:\Users\M6800\Downloads\Dapper-Laabki-main\Dapper-Laabki-main\Views\_ViewImports.cshtml"
using AppSqlReadOnly.Lab;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\M6800\Downloads\Dapper-Laabki-main\Dapper-Laabki-main\Views\_ViewImports.cshtml"
using AppSqlReadOnly.Lab.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8381958ee78f71a06017e0136516a40b60ad0e4", @"/Views/Home/EmployeesByCity.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36fa6013bf268b5dd69429676dc3421eb42f3aa6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_EmployeesByCity : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AppSqlReadOnly.Lab.Dal.EmployeeDao>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\M6800\Downloads\Dapper-Laabki-main\Dapper-Laabki-main\Views\Home\EmployeesByCity.cshtml"
  
    ViewData["Title"] = "EmployeesByCity";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>EmployeesByCity</h1>\n\n\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                ");
#nullable restore
#line 14 "C:\Users\M6800\Downloads\Dapper-Laabki-main\Dapper-Laabki-main\Views\Home\EmployeesByCity.cshtml"
           Write(Html.DisplayNameFor(model => model.EmployeeID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 17 "C:\Users\M6800\Downloads\Dapper-Laabki-main\Dapper-Laabki-main\Views\Home\EmployeesByCity.cshtml"
           Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 20 "C:\Users\M6800\Downloads\Dapper-Laabki-main\Dapper-Laabki-main\Views\Home\EmployeesByCity.cshtml"
           Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 23 "C:\Users\M6800\Downloads\Dapper-Laabki-main\Dapper-Laabki-main\Views\Home\EmployeesByCity.cshtml"
           Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 26 "C:\Users\M6800\Downloads\Dapper-Laabki-main\Dapper-Laabki-main\Views\Home\EmployeesByCity.cshtml"
           Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 32 "C:\Users\M6800\Downloads\Dapper-Laabki-main\Dapper-Laabki-main\Views\Home\EmployeesByCity.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>\n                ");
#nullable restore
#line 35 "C:\Users\M6800\Downloads\Dapper-Laabki-main\Dapper-Laabki-main\Views\Home\EmployeesByCity.cshtml"
           Write(Html.DisplayFor(modelItem => item.EmployeeID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 38 "C:\Users\M6800\Downloads\Dapper-Laabki-main\Dapper-Laabki-main\Views\Home\EmployeesByCity.cshtml"
           Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 41 "C:\Users\M6800\Downloads\Dapper-Laabki-main\Dapper-Laabki-main\Views\Home\EmployeesByCity.cshtml"
           Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 44 "C:\Users\M6800\Downloads\Dapper-Laabki-main\Dapper-Laabki-main\Views\Home\EmployeesByCity.cshtml"
           Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 47 "C:\Users\M6800\Downloads\Dapper-Laabki-main\Dapper-Laabki-main\Views\Home\EmployeesByCity.cshtml"
           Write(Html.DisplayFor(modelItem => item.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 50 "C:\Users\M6800\Downloads\Dapper-Laabki-main\Dapper-Laabki-main\Views\Home\EmployeesByCity.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\n                ");
#nullable restore
#line 51 "C:\Users\M6800\Downloads\Dapper-Laabki-main\Dapper-Laabki-main\Views\Home\EmployeesByCity.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\n                ");
#nullable restore
#line 52 "C:\Users\M6800\Downloads\Dapper-Laabki-main\Dapper-Laabki-main\Views\Home\EmployeesByCity.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n        </tr>\n");
#nullable restore
#line 55 "C:\Users\M6800\Downloads\Dapper-Laabki-main\Dapper-Laabki-main\Views\Home\EmployeesByCity.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AppSqlReadOnly.Lab.Dal.EmployeeDao>> Html { get; private set; }
    }
}
#pragma warning restore 1591
