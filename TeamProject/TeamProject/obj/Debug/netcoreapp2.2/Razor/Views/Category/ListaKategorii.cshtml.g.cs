#pragma checksum "C:\Users\user\Desktop\Projekt X\03.03\TeamProject\TeamProject\TeamProject\Views\Category\ListaKategorii.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7612ef0f3cdbc3dad4a521461b9eeafe7acfc97"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_ListaKategorii), @"mvc.1.0.view", @"/Views/Category/ListaKategorii.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Category/ListaKategorii.cshtml", typeof(AspNetCore.Views_Category_ListaKategorii))]
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
#line 1 "C:\Users\user\Desktop\Projekt X\03.03\TeamProject\TeamProject\TeamProject\Views\_ViewImports.cshtml"
using TeamProject;

#line default
#line hidden
#line 2 "C:\Users\user\Desktop\Projekt X\03.03\TeamProject\TeamProject\TeamProject\Views\_ViewImports.cshtml"
using TeamProject.Models;

#line default
#line hidden
#line 3 "C:\Users\user\Desktop\Projekt X\03.03\TeamProject\TeamProject\TeamProject\Views\_ViewImports.cshtml"
using TeamProject.Models.Modele_pomocnicze;

#line default
#line hidden
#line 4 "C:\Users\user\Desktop\Projekt X\03.03\TeamProject\TeamProject\TeamProject\Views\_ViewImports.cshtml"
using FormGenerator;

#line default
#line hidden
#line 5 "C:\Users\user\Desktop\Projekt X\03.03\TeamProject\TeamProject\TeamProject\Views\_ViewImports.cshtml"
using FormGenerator.Models;

#line default
#line hidden
#line 6 "C:\Users\user\Desktop\Projekt X\03.03\TeamProject\TeamProject\TeamProject\Views\_ViewImports.cshtml"
using FormGenerator.Models.Modele_pomocnicze;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7612ef0f3cdbc3dad4a521461b9eeafe7acfc97", @"/Views/Category/ListaKategorii.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c52267094b2868e58b54bc0760e92b7d1c3076a", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_ListaKategorii : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FormGenerator.Models.Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\user\Desktop\Projekt X\03.03\TeamProject\TeamProject\TeamProject\Views\Category\ListaKategorii.cshtml"
  
    ViewData["Title"] = "Lista Kategorii";

#line default
#line hidden
            BeginContext(104, 116, true);
            WriteLiteral("\r\n<h1>Lista Kategorii</h1>\r\n\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(221, 38, false);
#line 14 "C:\Users\user\Desktop\Projekt X\03.03\TeamProject\TeamProject\TeamProject\Views\Category\ListaKategorii.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(259, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(315, 40, false);
#line 17 "C:\Users\user\Desktop\Projekt X\03.03\TeamProject\TeamProject\TeamProject\Views\Category\ListaKategorii.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(355, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(411, 42, false);
#line 20 "C:\Users\user\Desktop\Projekt X\03.03\TeamProject\TeamProject\TeamProject\Views\Category\ListaKategorii.cshtml"
           Write(Html.DisplayNameFor(model => model.Parent));

#line default
#line hidden
            EndContext();
            BeginContext(453, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 26 "C:\Users\user\Desktop\Projekt X\03.03\TeamProject\TeamProject\TeamProject\Views\Category\ListaKategorii.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(588, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(649, 37, false);
#line 30 "C:\Users\user\Desktop\Projekt X\03.03\TeamProject\TeamProject\TeamProject\Views\Category\ListaKategorii.cshtml"
               Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(686, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(754, 39, false);
#line 33 "C:\Users\user\Desktop\Projekt X\03.03\TeamProject\TeamProject\TeamProject\Views\Category\ListaKategorii.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(793, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(861, 41, false);
#line 36 "C:\Users\user\Desktop\Projekt X\03.03\TeamProject\TeamProject\TeamProject\Views\Category\ListaKategorii.cshtml"
               Write(Html.DisplayFor(modelItem => item.Parent));

#line default
#line hidden
            EndContext();
            BeginContext(902, 111, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    \r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 42 "C:\Users\user\Desktop\Projekt X\03.03\TeamProject\TeamProject\TeamProject\Views\Category\ListaKategorii.cshtml"
        }

#line default
#line hidden
            BeginContext(1024, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FormGenerator.Models.Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
