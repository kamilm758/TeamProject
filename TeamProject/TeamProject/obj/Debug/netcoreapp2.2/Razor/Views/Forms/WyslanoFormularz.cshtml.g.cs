#pragma checksum "C:\Users\user\Downloads\TeamProject-FormularzPowitalny\TeamProject\TeamProject\Views\Forms\WyslanoFormularz.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3fd0c55e6534bd532fa5d79088260bb81054df9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Forms_WyslanoFormularz), @"mvc.1.0.view", @"/Views/Forms/WyslanoFormularz.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Forms/WyslanoFormularz.cshtml", typeof(AspNetCore.Views_Forms_WyslanoFormularz))]
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
#line 1 "C:\Users\user\Downloads\TeamProject-FormularzPowitalny\TeamProject\TeamProject\Views\_ViewImports.cshtml"
using TeamProject;

#line default
#line hidden
#line 2 "C:\Users\user\Downloads\TeamProject-FormularzPowitalny\TeamProject\TeamProject\Views\_ViewImports.cshtml"
using TeamProject.Models;

#line default
#line hidden
#line 3 "C:\Users\user\Downloads\TeamProject-FormularzPowitalny\TeamProject\TeamProject\Views\_ViewImports.cshtml"
using TeamProject.Models.Modele_pomocnicze;

#line default
#line hidden
#line 4 "C:\Users\user\Downloads\TeamProject-FormularzPowitalny\TeamProject\TeamProject\Views\_ViewImports.cshtml"
using FormGenerator;

#line default
#line hidden
#line 5 "C:\Users\user\Downloads\TeamProject-FormularzPowitalny\TeamProject\TeamProject\Views\_ViewImports.cshtml"
using FormGenerator.Models;

#line default
#line hidden
#line 6 "C:\Users\user\Downloads\TeamProject-FormularzPowitalny\TeamProject\TeamProject\Views\_ViewImports.cshtml"
using FormGenerator.Models.Modele_pomocnicze;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3fd0c55e6534bd532fa5d79088260bb81054df9", @"/Views/Forms/WyslanoFormularz.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5dea779c6a2ce3bf4277662fd9bb8b844e794fa", @"/Views/_ViewImports.cshtml")]
    public class Views_Forms_WyslanoFormularz : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<FieldWithValue>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("font-weight:bold; font-size:large"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\user\Downloads\TeamProject-FormularzPowitalny\TeamProject\TeamProject\Views\Forms\WyslanoFormularz.cshtml"
  
    ViewData["Title"] = "WyslanoFormularz";

#line default
#line hidden
            BeginContext(77, 260, true);
            WriteLiteral(@"
<h1>Wyslano Formularz</h1>
<h3>Gratulacje, dane z formularza zostały zapisane w bazie danych</h3>
<style>

    .cities {
        background-color: #66BB6A;
        color: white;
        margin: 20px;
        padding: 20px;
    }
</style>
<div class=""cities"">
");
            EndContext();
#line 18 "C:\Users\user\Downloads\TeamProject-FormularzPowitalny\TeamProject\TeamProject\Views\Forms\WyslanoFormularz.cshtml"
     foreach (var key in Model)
    {

#line default
#line hidden
            BeginContext(375, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(383, 98, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d3fd0c55e6534bd532fa5d79088260bb81054df95211", async() => {
                BeginContext(459, 14, false);
#line 20 "C:\Users\user\Downloads\TeamProject-FormularzPowitalny\TeamProject\TeamProject\Views\Forms\WyslanoFormularz.cshtml"
                                                                              Write(key.Field.Name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 20 "C:\Users\user\Downloads\TeamProject-FormularzPowitalny\TeamProject\TeamProject\Views\Forms\WyslanoFormularz.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => key.Field.Name);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(481, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 21 "C:\Users\user\Downloads\TeamProject-FormularzPowitalny\TeamProject\TeamProject\Views\Forms\WyslanoFormularz.cshtml"
         if (key.Field.Type == "checkbox")
        {

#line default
#line hidden
            BeginContext(535, 15, true);
            WriteLiteral("            <p>");
            EndContext();
            BeginContext(551, 24, false);
#line 23 "C:\Users\user\Downloads\TeamProject-FormularzPowitalny\TeamProject\TeamProject\Views\Forms\WyslanoFormularz.cshtml"
          Write(key.BoolValue.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(575, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 24 "C:\Users\user\Downloads\TeamProject-FormularzPowitalny\TeamProject\TeamProject\Views\Forms\WyslanoFormularz.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(613, 15, true);
            WriteLiteral("            <p>");
            EndContext();
            BeginContext(629, 13, false);
#line 27 "C:\Users\user\Downloads\TeamProject-FormularzPowitalny\TeamProject\TeamProject\Views\Forms\WyslanoFormularz.cshtml"
          Write(key.TextValue);

#line default
#line hidden
            EndContext();
            BeginContext(642, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 28 "C:\Users\user\Downloads\TeamProject-FormularzPowitalny\TeamProject\TeamProject\Views\Forms\WyslanoFormularz.cshtml"
        }

#line default
#line hidden
            BeginContext(657, 15, true);
            WriteLiteral("        <br />\n");
            EndContext();
#line 30 "C:\Users\user\Downloads\TeamProject-FormularzPowitalny\TeamProject\TeamProject\Views\Forms\WyslanoFormularz.cshtml"
    }

#line default
#line hidden
            BeginContext(678, 10, true);
            WriteLiteral("</div>\n\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<FieldWithValue>> Html { get; private set; }
    }
}
#pragma warning restore 1591
