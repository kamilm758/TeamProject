#pragma checksum "C:\Users\kamil\Desktop\GitRepos\FormGenerator\TeamProject\TeamProject\TeamProject\Views\Forms\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ff352a6d4cb0aa8bcadb27957a42fc2cb331372"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Forms_Index), @"mvc.1.0.view", @"/Views/Forms/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Forms/Index.cshtml", typeof(AspNetCore.Views_Forms_Index))]
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
#line 1 "C:\Users\kamil\Desktop\GitRepos\FormGenerator\TeamProject\TeamProject\TeamProject\Views\_ViewImports.cshtml"
using TeamProject;

#line default
#line hidden
#line 2 "C:\Users\kamil\Desktop\GitRepos\FormGenerator\TeamProject\TeamProject\TeamProject\Views\_ViewImports.cshtml"
using TeamProject.Models;

#line default
#line hidden
#line 3 "C:\Users\kamil\Desktop\GitRepos\FormGenerator\TeamProject\TeamProject\TeamProject\Views\_ViewImports.cshtml"
using TeamProject.Models.Modele_pomocnicze;

#line default
#line hidden
#line 4 "C:\Users\kamil\Desktop\GitRepos\FormGenerator\TeamProject\TeamProject\TeamProject\Views\_ViewImports.cshtml"
using FormGenerator;

#line default
#line hidden
#line 5 "C:\Users\kamil\Desktop\GitRepos\FormGenerator\TeamProject\TeamProject\TeamProject\Views\_ViewImports.cshtml"
using FormGenerator.Models;

#line default
#line hidden
#line 6 "C:\Users\kamil\Desktop\GitRepos\FormGenerator\TeamProject\TeamProject\TeamProject\Views\_ViewImports.cshtml"
using FormGenerator.Models.Modele_pomocnicze;

#line default
#line hidden
#line 7 "C:\Users\kamil\Desktop\GitRepos\FormGenerator\TeamProject\TeamProject\TeamProject\Views\_ViewImports.cshtml"
using TeamProject.DTOs.FieldDependency;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ff352a6d4cb0aa8bcadb27957a42fc2cb331372", @"/Views/Forms/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8717c71a69157e4a5de12aa566aa6c416f06c6e3", @"/Views/_ViewImports.cshtml")]
    public class Views_Forms_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/Scrip.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 159, true);
            WriteLiteral("\r\n<script src=\"https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js\"></script>\r\n<script src=\"https://unpkg.com/axios/dist/axios.min.js\"></script>\r\n");
            EndContext();
            BeginContext(159, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ff352a6d4cb0aa8bcadb27957a42fc2cb3313724819", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 4 "C:\Users\kamil\Desktop\GitRepos\FormGenerator\TeamProject\TeamProject\TeamProject\Views\Forms\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(222, 424, true);
            WriteLiteral(@"



<div class=""row"">
    <div class=""col"">
        <h3>Kategorie</h3>

        <div id=""buton""></div>
        <div id=""Drzewo""></div>
    </div>

    <div class=""col"">
        <h3>Formularze kategorii</h3>
             <div class=""row"">
                  <div id=""wynik"">

                 </div>

            </div>
      
    </div>

</div>


<script type=""text/javascript"">

    var IDcat = '");
            EndContext();
            BeginContext(647, 11, false);
#line 32 "C:\Users\kamil\Desktop\GitRepos\FormGenerator\TeamProject\TeamProject\TeamProject\Views\Forms\Index.cshtml"
            Write(ViewBag.bag);

#line default
#line hidden
            EndContext();
            BeginContext(658, 66, true);
            WriteLiteral("\';\r\n    sessionStorage.removeItem(\'key\');\r\n\r\n</script>\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
