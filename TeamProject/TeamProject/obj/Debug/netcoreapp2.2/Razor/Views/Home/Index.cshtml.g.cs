#pragma checksum "C:\Users\user\Desktop\Projekt X\10.03\TeamProject-FormularzPowitalny\TeamProject\TeamProject\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1fe598a9945c7f0c60e3737008b2abe615b547b"
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
#line 1 "C:\Users\user\Desktop\Projekt X\10.03\TeamProject-FormularzPowitalny\TeamProject\TeamProject\Views\_ViewImports.cshtml"
using TeamProject;

#line default
#line hidden
#line 2 "C:\Users\user\Desktop\Projekt X\10.03\TeamProject-FormularzPowitalny\TeamProject\TeamProject\Views\_ViewImports.cshtml"
using TeamProject.Models;

#line default
#line hidden
#line 3 "C:\Users\user\Desktop\Projekt X\10.03\TeamProject-FormularzPowitalny\TeamProject\TeamProject\Views\_ViewImports.cshtml"
using TeamProject.Models.Modele_pomocnicze;

#line default
#line hidden
#line 4 "C:\Users\user\Desktop\Projekt X\10.03\TeamProject-FormularzPowitalny\TeamProject\TeamProject\Views\_ViewImports.cshtml"
using FormGenerator;

#line default
#line hidden
#line 5 "C:\Users\user\Desktop\Projekt X\10.03\TeamProject-FormularzPowitalny\TeamProject\TeamProject\Views\_ViewImports.cshtml"
using FormGenerator.Models;

#line default
#line hidden
#line 6 "C:\Users\user\Desktop\Projekt X\10.03\TeamProject-FormularzPowitalny\TeamProject\TeamProject\Views\_ViewImports.cshtml"
using FormGenerator.Models.Modele_pomocnicze;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1fe598a9945c7f0c60e3737008b2abe615b547b", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5dea779c6a2ce3bf4277662fd9bb8b844e794fa", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FormGenerator.Models.Forms>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\user\Desktop\Projekt X\10.03\TeamProject-FormularzPowitalny\TeamProject\TeamProject\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(42, 193, true);
            WriteLiteral("    <div class=\"text-center\">\n        <h1 class=\"display-4\">Generator Formularzy</h1>\n    </div>\n    <div class=\"\">\n        <script>\n        sessionStorage.removeItem(\'key\');\n        </script>\n");
            EndContext();
            BeginContext(290, 8, true);
            WriteLiteral("        ");
            EndContext();
#line 12 "C:\Users\user\Desktop\Projekt X\10.03\TeamProject-FormularzPowitalny\TeamProject\TeamProject\Views\Home\Index.cshtml"
          
            ViewData["Title"] = "Index";
        

#line default
#line hidden
            BeginContext(352, 309, true);
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
