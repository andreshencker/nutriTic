#pragma checksum "I:\proyectos\reto\nutriTic\NutriTic.App.frontend\Pages\ValoracionE\ValoracionE.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2d15342407b64508b0f3631315b952cad34cf1f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(NutriTic.App.Frontend.Pages.ValoracionE.Pages_ValoracionE_ValoracionE), @"mvc.1.0.razor-page", @"/Pages/ValoracionE/ValoracionE.cshtml")]
namespace NutriTic.App.Frontend.Pages.ValoracionE
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2d15342407b64508b0f3631315b952cad34cf1f", @"/Pages/ValoracionE/ValoracionE.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5afd4fc3733f6637463a3148ecea1d223d896b5", @"/Pages/_ViewImports.cshtml")]
    public class Pages_ValoracionE_ValoracionE : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
            WriteLiteral("<div class=\"content mt-5\">\r\n        <div class=\"card card-body\">\r\n            <h3>Paciente</h3>\r\n            <select class=\"form-control\"");
            BeginWriteAttribute("name", " name=\"", 199, "\"", 206, 0);
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 207, "\"", 212, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            </select>\r\n        </div>\r\n        <div class=\"card card-body mt-3\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2d15342407b64508b0f3631315b952cad34cf1f3980", async() => {
                WriteLiteral(@"
                <h3>Información Paciente</h3>
                <div class=""form-group"">
                    <label for=""correo"">Correo</label>
                    <input class=""form-control"" name=""correo"" type=""email"" required disabled>
                </div>
                <div class=""form-group"">
                    <label for=""telefono"">Telefono</label>
                    <input class=""form-control"" name=""telefono"" type=""text"" required disabled>
                </div>
                <div class=""form-group"">
                    <label for=""edad"">Edad</label>
                    <input class=""form-control"" name=""edad"" type=""text"" required disabled>
                </div>
                <div class=""form-group"">
                    <label for=""estatura"">Estatura</label>
                    <input class=""form-control"" name=""estatura"" type=""text"" required disabled>
                </div>

            ");
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
            WriteLiteral("\r\n        </div>\r\n        <div class=\"card card-body mt-3\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2d15342407b64508b0f3631315b952cad34cf1f6342", async() => {
                WriteLiteral(@"
                <h3>Generar valoraciones</h3>
                <div class=""form-group"">
                    <input class=""form-control"" name=""valoracion"" type=""text"" placeholder=""Valoración"" required>
                </div>
                <div class=""form-group"">
                    <input class=""form-control"" name=""fechaValoracion"" type=""datetimet"" placeholder=""Valoración""");
                BeginWriteAttribute("value", " value=\"", 1739, "\"", 1747, 0);
                EndWriteAttribute();
                WriteLiteral(@"
                        hidden required>
                </div>
                <div class=""form-group"">
                    <textarea class=""form-control"" name=""comentarios"" rows=""10""
                        cols=""40"">Escribe aquí tus comentarios</textarea>
                </div>
                <div class=""form-group"">
                    <button class=""form-control btn btn-primary btn-block"" type=""submit"">Aceptar</button>
                </div>


            ");
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
             <div class=""form-group"">
                    <input class=""form-control"" name=""idMedida"" type=""text"" placeholder=""ID Medida"" required>
                     <button class=""form-control btn btn-primary btn-block"" type=""submit"">Aceptar</button>
            </div>
            
            <div class=""card card-body mt-3"">
                <h3>Historial de medidas</h3>
                <table>
                    <tr>
                        <th>Id Medida</th>
                        <th>Fecha Medida</th>
                        <th>Peso</th>
                        <th>IMC</th>
                    </tr>
                </table>
            </div>
            <div class=""card card-body mt-3"">
                <h3>Historial de valoraciones</h3>
                <table>
                    <tr>
                        <th>Id Medida</th>
                        <th>Fecha valoración</th>
                        <th>valoración</");
            WriteLiteral("th>\r\n                        <th>Empleado</th>\r\n                        <th>Cargo</th>\r\n                        <th>Acciones</th>\r\n                    </tr>\r\n                </table>\r\n            </div>\r\n        </div>\r\n\r\n\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NutriTic.App.Frontend.Pages.ValoracionEModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<NutriTic.App.Frontend.Pages.ValoracionEModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<NutriTic.App.Frontend.Pages.ValoracionEModel>)PageContext?.ViewData;
        public NutriTic.App.Frontend.Pages.ValoracionEModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
