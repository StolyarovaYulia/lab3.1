#pragma checksum "C:\Users\Name\OneDrive\Рабочий стол\3 курс 1 сем\РПБДИС\lab 3\Lab3__\Lab3_\Views\Performers\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f72f481f33826f21c78c35333e1f91863674d6bf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Performers_Index), @"mvc.1.0.view", @"/Views/Performers/Index.cshtml")]
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
#line 1 "C:\Users\Name\OneDrive\Рабочий стол\3 курс 1 сем\РПБДИС\lab 3\Lab3__\Lab3_\Views\_ViewImports.cshtml"
using Lab3_;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Name\OneDrive\Рабочий стол\3 курс 1 сем\РПБДИС\lab 3\Lab3__\Lab3_\Views\_ViewImports.cshtml"
using Lab3_.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f72f481f33826f21c78c35333e1f91863674d6bf", @"/Views/Performers/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd9fe6a2458ebae819c0cc3396d3bd8bf3b7cb15", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Performers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Performer>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Name\OneDrive\Рабочий стол\3 курс 1 сем\РПБДИС\lab 3\Lab3__\Lab3_\Views\Performers\Index.cshtml"
  
    ViewData["Title"] = "Исполнители";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2>Исполнители</h2>

<p>
</p>
<table class=""table"">
    <thead>
    <tr>
        <th>
            Наименование
        </th>
        <th>
            Группа
        </th>
            <th>
                Описание
            </th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 27 "C:\Users\Name\OneDrive\Рабочий стол\3 курс 1 сем\РПБДИС\lab 3\Lab3__\Lab3_\Views\Performers\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>\n                ");
#nullable restore
#line 31 "C:\Users\Name\OneDrive\Рабочий стол\3 курс 1 сем\РПБДИС\lab 3\Lab3__\Lab3_\Views\Performers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                    ");
#nullable restore
#line 34 "C:\Users\Name\OneDrive\Рабочий стол\3 курс 1 сем\РПБДИС\lab 3\Lab3__\Lab3_\Views\Performers\Index.cshtml"
                Write(item.IsGroup ? "Да" : "Нет");

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n            <td>\n                ");
#nullable restore
#line 37 "C:\Users\Name\OneDrive\Рабочий стол\3 курс 1 сем\РПБДИС\lab 3\Lab3__\Lab3_\Views\Performers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n        </tr>\n");
#nullable restore
#line 40 "C:\Users\Name\OneDrive\Рабочий стол\3 курс 1 сем\РПБДИС\lab 3\Lab3__\Lab3_\Views\Performers\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Performer>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591