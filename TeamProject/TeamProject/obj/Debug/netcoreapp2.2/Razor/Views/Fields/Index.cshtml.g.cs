#pragma checksum "C:\Users\AdriannaJK\Desktop\TeamProject-KamilNew\TeamProject\TeamProject\Views\Fields\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9994992b17c02e3679162b816ee82ed2b44289e3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Fields_Index), @"mvc.1.0.view", @"/Views/Fields/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Fields/Index.cshtml", typeof(AspNetCore.Views_Fields_Index))]
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
#line 1 "C:\Users\AdriannaJK\Desktop\TeamProject-KamilNew\TeamProject\TeamProject\Views\_ViewImports.cshtml"
using TeamProject;

#line default
#line hidden
#line 2 "C:\Users\AdriannaJK\Desktop\TeamProject-KamilNew\TeamProject\TeamProject\Views\_ViewImports.cshtml"
using TeamProject.Models;

#line default
#line hidden
#line 3 "C:\Users\AdriannaJK\Desktop\TeamProject-KamilNew\TeamProject\TeamProject\Views\_ViewImports.cshtml"
using TeamProject.Models.Modele_pomocnicze;

#line default
#line hidden
#line 4 "C:\Users\AdriannaJK\Desktop\TeamProject-KamilNew\TeamProject\TeamProject\Views\_ViewImports.cshtml"
using FormGenerator;

#line default
#line hidden
#line 5 "C:\Users\AdriannaJK\Desktop\TeamProject-KamilNew\TeamProject\TeamProject\Views\_ViewImports.cshtml"
using FormGenerator.Models;

#line default
#line hidden
#line 6 "C:\Users\AdriannaJK\Desktop\TeamProject-KamilNew\TeamProject\TeamProject\Views\_ViewImports.cshtml"
using FormGenerator.Models.Modele_pomocnicze;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9994992b17c02e3679162b816ee82ed2b44289e3", @"/Views/Fields/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5dea779c6a2ce3bf4277662fd9bb8b844e794fa", @"/Views/_ViewImports.cshtml")]
    public class Views_Fields_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FormGenerator.Models.Field>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:#81C784;  font-weight:700"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(47, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\AdriannaJK\Desktop\TeamProject-KamilNew\TeamProject\TeamProject\Views\Fields\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(86, 374, true);
            WriteLiteral(@"

<style>

    table {
        border-collapse: collapse;
        width: 100%;
    }

    th, td {
        text-align: left;
        padding: 8px;
    }

    tr:nth-child(even) {
        background-color: #A5D6A7
    }

    th {
        background-color: #81C784;
        color: white;
    }

    a {
        color: #424242;
        font-weight: 500;
    }
</style>
<p>
    ");
            EndContext();
            BeginContext(460, 83, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9994992b17c02e3679162b816ee82ed2b44289e35301", async() => {
                BeginContext(523, 16, true);
                WriteLiteral("Stwórz nowe pole");
                EndContext();
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
            EndContext();
            BeginContext(543, 225, true);
            WriteLiteral("\n</p>\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n               Nazwa\n            </th>\n            <th>\n                Typ\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
            EndContext();
#line 50 "C:\Users\AdriannaJK\Desktop\TeamProject-KamilNew\TeamProject\TeamProject\Views\Fields\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(815, 58, true);
            WriteLiteral("            <tr>\n                <td>\n                    ");
            EndContext();
            BeginContext(874, 39, false);
#line 54 "C:\Users\AdriannaJK\Desktop\TeamProject-KamilNew\TeamProject\TeamProject\Views\Fields\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(913, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(978, 39, false);
#line 57 "C:\Users\AdriannaJK\Desktop\TeamProject-KamilNew\TeamProject\TeamProject\Views\Fields\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Type));

#line default
#line hidden
            EndContext();
            BeginContext(1017, 56, true);
            WriteLiteral("\n                </td>\n              \n            </tr>\n");
            EndContext();
#line 61 "C:\Users\AdriannaJK\Desktop\TeamProject-KamilNew\TeamProject\TeamProject\Views\Fields\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1083, 22, true);
            WriteLiteral("    </tbody>\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FormGenerator.Models.Field>> Html { get; private set; }
    }
}
#pragma warning restore 1591
