#pragma checksum "C:\Users\user\Desktop\Projekt X\TeamProject\TeamProject\TeamProject\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97875f3970a7853e45e34f02f1404f9971f97e2b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\user\Desktop\Projekt X\TeamProject\TeamProject\TeamProject\Views\_ViewImports.cshtml"
using TeamProject;

#line default
#line hidden
#line 2 "C:\Users\user\Desktop\Projekt X\TeamProject\TeamProject\TeamProject\Views\_ViewImports.cshtml"
using TeamProject.Models;

#line default
#line hidden
#line 3 "C:\Users\user\Desktop\Projekt X\TeamProject\TeamProject\TeamProject\Views\_ViewImports.cshtml"
using TeamProject.Models.Modele_pomocnicze;

#line default
#line hidden
#line 4 "C:\Users\user\Desktop\Projekt X\TeamProject\TeamProject\TeamProject\Views\_ViewImports.cshtml"
using FormGenerator;

#line default
#line hidden
#line 5 "C:\Users\user\Desktop\Projekt X\TeamProject\TeamProject\TeamProject\Views\_ViewImports.cshtml"
using FormGenerator.Models;

#line default
#line hidden
#line 6 "C:\Users\user\Desktop\Projekt X\TeamProject\TeamProject\TeamProject\Views\_ViewImports.cshtml"
using FormGenerator.Models.Modele_pomocnicze;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97875f3970a7853e45e34f02f1404f9971f97e2b", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5dea779c6a2ce3bf4277662fd9bb8b844e794fa", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FormGenerator.Models.Forms>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\user\Desktop\Projekt X\TeamProject\TeamProject\TeamProject\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(42, 117, true);
            WriteLiteral("    <div class=\"text-center\">\n        <h1 class=\"display-4\">Generator Formularzy</h1>\n    </div>\n    <div class=\"\">\n\n");
            EndContext();
            BeginContext(214, 8, true);
            WriteLiteral("        ");
            EndContext();
#line 10 "C:\Users\user\Desktop\Projekt X\TeamProject\TeamProject\TeamProject\Views\Home\Index.cshtml"
          
            ViewData["Title"] = "Index";
        

#line default
#line hidden
            BeginContext(276, 317, true);
            WriteLiteral(@"        <style>
            .cities {
                background-color: #66BB6A;
                color: white;
                margin: 20px;
                padding: 20px;
            }
        </style>
        
        <div class=""cities"" id=""Drzewo""></div>
        <div class=""cities"" id=""wynik""></div>
    </div> 
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FormGenerator.Models.Forms>> Html { get; private set; }
    }
}
#pragma warning restore 1591
