#pragma checksum "C:\Users\Name\OneDrive\Рабочий стол\3 курс 1 сем\РПБДИС\lab 3\Lab3__\Lab3_\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a90c3b14cd806d9d3bc1d7ae0d26df40678fb9d8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a90c3b14cd806d9d3bc1d7ae0d26df40678fb9d8", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd9fe6a2458ebae819c0cc3396d3bd8bf3b7cb15", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Lab3_.ViewModels.HomeViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Name\OneDrive\Рабочий стол\3 курс 1 сем\РПБДИС\lab 3\Lab3__\Lab3_\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Все данные";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<table border=""0"" cellspacing=""100"">
    <tr>
        <td>
            <table border=""1"">
                <caption>Жанры</caption>
                <tr>
                    <th>#</th>
                    <th>Наименование</th>
                    <th>Описание</th>
                </tr>
");
#nullable restore
#line 15 "C:\Users\Name\OneDrive\Рабочий стол\3 курс 1 сем\РПБДИС\lab 3\Lab3__\Lab3_\Views\Home\Index.cshtml"
                 foreach (var genre in Model.Genres)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\n                        <td>");
#nullable restore
#line 18 "C:\Users\Name\OneDrive\Рабочий стол\3 курс 1 сем\РПБДИС\lab 3\Lab3__\Lab3_\Views\Home\Index.cshtml"
                       Write(genre.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 19 "C:\Users\Name\OneDrive\Рабочий стол\3 курс 1 сем\РПБДИС\lab 3\Lab3__\Lab3_\Views\Home\Index.cshtml"
                       Write(genre.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 20 "C:\Users\Name\OneDrive\Рабочий стол\3 курс 1 сем\РПБДИС\lab 3\Lab3__\Lab3_\Views\Home\Index.cshtml"
                       Write(genre.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    </tr>\n");
#nullable restore
#line 22 "C:\Users\Name\OneDrive\Рабочий стол\3 курс 1 сем\РПБДИС\lab 3\Lab3__\Lab3_\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </table>
        </td>

        <td style=""padding-left: 30px"">
            <table border=""1"">
                <caption>Исполнители</caption>
                <tr>
                    <th>#</th>
                    <th>Наименование</th>
                    <th>Группа</th>
                    <th></th>
                </tr>
");
#nullable restore
#line 35 "C:\Users\Name\OneDrive\Рабочий стол\3 курс 1 сем\РПБДИС\lab 3\Lab3__\Lab3_\Views\Home\Index.cshtml"
                 foreach (var performer in Model.Performers)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\n                        <td>");
#nullable restore
#line 38 "C:\Users\Name\OneDrive\Рабочий стол\3 курс 1 сем\РПБДИС\lab 3\Lab3__\Lab3_\Views\Home\Index.cshtml"
                       Write(performer.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 39 "C:\Users\Name\OneDrive\Рабочий стол\3 курс 1 сем\РПБДИС\lab 3\Lab3__\Lab3_\Views\Home\Index.cshtml"
                       Write(performer.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 40 "C:\Users\Name\OneDrive\Рабочий стол\3 курс 1 сем\РПБДИС\lab 3\Lab3__\Lab3_\Views\Home\Index.cshtml"
                        Write(performer.IsGroup ? "Да" : "Нет");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    </tr>\n");
#nullable restore
#line 42 "C:\Users\Name\OneDrive\Рабочий стол\3 курс 1 сем\РПБДИС\lab 3\Lab3__\Lab3_\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </table>
        </td>
    </tr>
</table>
<table border=""1"">
    <caption>Треки</caption>
    <tr>
        <th>#</th>
        <th>Наименование</th>
        <th>Дата выхода</th>
        <th>Исполнитель</th>
        <th>Жанр</th>
        <th>Длительность</th>
        <th>Рейтинг</th>
    </tr>
");
#nullable restore
#line 58 "C:\Users\Name\OneDrive\Рабочий стол\3 курс 1 сем\РПБДИС\lab 3\Lab3__\Lab3_\Views\Home\Index.cshtml"
     foreach (var track in Model.Tracks)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>");
#nullable restore
#line 61 "C:\Users\Name\OneDrive\Рабочий стол\3 курс 1 сем\РПБДИС\lab 3\Lab3__\Lab3_\Views\Home\Index.cshtml"
           Write(track.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 62 "C:\Users\Name\OneDrive\Рабочий стол\3 курс 1 сем\РПБДИС\lab 3\Lab3__\Lab3_\Views\Home\Index.cshtml"
           Write(track.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 63 "C:\Users\Name\OneDrive\Рабочий стол\3 курс 1 сем\РПБДИС\lab 3\Lab3__\Lab3_\Views\Home\Index.cshtml"
           Write(track.CreationDate.ToString("d"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 64 "C:\Users\Name\OneDrive\Рабочий стол\3 курс 1 сем\РПБДИС\lab 3\Lab3__\Lab3_\Views\Home\Index.cshtml"
           Write(track.Performer);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 65 "C:\Users\Name\OneDrive\Рабочий стол\3 курс 1 сем\РПБДИС\lab 3\Lab3__\Lab3_\Views\Home\Index.cshtml"
           Write(track.Genre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 66 "C:\Users\Name\OneDrive\Рабочий стол\3 курс 1 сем\РПБДИС\lab 3\Lab3__\Lab3_\Views\Home\Index.cshtml"
           Write(track.Duration);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 67 "C:\Users\Name\OneDrive\Рабочий стол\3 курс 1 сем\РПБДИС\lab 3\Lab3__\Lab3_\Views\Home\Index.cshtml"
           Write(track.Rating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n");
#nullable restore
#line 69 "C:\Users\Name\OneDrive\Рабочий стол\3 курс 1 сем\РПБДИС\lab 3\Lab3__\Lab3_\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lab3_.ViewModels.HomeViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
