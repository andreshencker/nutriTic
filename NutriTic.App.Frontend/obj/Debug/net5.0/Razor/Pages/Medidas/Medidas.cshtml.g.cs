#pragma checksum "I:\proyectos\reto\nutriTic\NutriTic.App.frontend\Pages\Medidas\Medidas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1c5e45842b828d72b56c12ef2263c167e454335"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(NutriTic.App.Frontend.Pages.Medidas.Pages_Medidas_Medidas), @"mvc.1.0.razor-page", @"/Pages/Medidas/Medidas.cshtml")]
namespace NutriTic.App.Frontend.Pages.Medidas
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
#line 1 "I:\proyectos\reto\nutriTic\NutriTic.App.frontend\Pages\_ViewImports.cshtml"
using NutriTic.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1c5e45842b828d72b56c12ef2263c167e454335", @"/Pages/Medidas/Medidas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5afd4fc3733f6637463a3148ecea1d223d896b5", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Medidas_Medidas : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "I:\proyectos\reto\nutriTic\NutriTic.App.frontend\Pages\Medidas\Medidas.cshtml"
    Layout="_LayoutPaciente";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"content mt-5\">\r\n        <div class=\"card card-body\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f1c5e45842b828d72b56c12ef2263c167e4543353714", async() => {
                WriteLiteral(@"
                <h3>Ingrese sus medidas</h3>
                <div class=""form-group"">
                    <input class=""form-control"" name=""peso"" type=""text"" placeholder=""Peso"" required>
                </div>
                <div class=""form-group"">                   
                    <input class=""form-control"" name=""fechaValoracion"" type=""datetimet"" placeholder=""Valoración""");
                BeginWriteAttribute("value", " value=\"", 574, "\"", 582, 0);
                EndWriteAttribute();
                WriteLiteral(" hidden required>\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <button class=\"form-control btn btn-primary btn-block\" type=\"submit\">Aceptar</button>\r\n                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
        <div class=""card card-body mt-3"">
             <div class=""card card-body mt-3"">
            <h3>Historial de medidas</h3>
            <table>
                <tr>
                    <th>Id Medida</th>
                    <th>Fecha Medida</th>
                    <th>Peso</th>
                    <th>Comentario</th>
                    <th>Acciones</th>
                </tr>
            </table>
        </div>
        <div class=""card card-body mt-3"">
            <h3>Historial de valoraciones</h3>
            <table>
                <tr>
                    <th>Id Medida</th>
                    <th>Fecha valoración</th>
                    <th>valoración</th>
                    <th>Empleado</th>
                    <th>Cargo</th>                   
                </tr>
                
            </table>
        </div>
        </div>
       
        
    </div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NutriTic.App.Frontend.Pages.MedidasModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<NutriTic.App.Frontend.Pages.MedidasModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<NutriTic.App.Frontend.Pages.MedidasModel>)PageContext?.ViewData;
        public NutriTic.App.Frontend.Pages.MedidasModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
