#pragma checksum "E:\proyectos\prueba\nutriTic\NutriTic.App.Frontend\Pages\Profile\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "812e3a1ca794ba11c344479c9dc39c7206776547"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(NutriTic.App.Frontend.Pages.Profile.Pages_Profile_Profile), @"mvc.1.0.razor-page", @"/Pages/Profile/Profile.cshtml")]
namespace NutriTic.App.Frontend.Pages.Profile
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
#line 1 "E:\proyectos\prueba\nutriTic\NutriTic.App.Frontend\Pages\_ViewImports.cshtml"
using NutriTic.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"812e3a1ca794ba11c344479c9dc39c7206776547", @"/Pages/Profile/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5afd4fc3733f6637463a3148ecea1d223d896b5", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Profile_Profile : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "E:\proyectos\prueba\nutriTic\NutriTic.App.Frontend\Pages\Profile\Profile.cshtml"
  

    Layout="_LayoutPaciente";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"content mt-5\">\r\n        <div class=\"card card-body\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "812e3a1ca794ba11c344479c9dc39c72067765474021", async() => {
                WriteLiteral("  \r\n                <h3>Datos Paciente</h3>              \r\n                <div class=\"form-group\">\r\n                    <label");
                BeginWriteAttribute("for", " for=\"", 332, "\"", 338, 0);
                EndWriteAttribute();
                WriteLiteral(@"></label>
                    <input class=""form-control"" type=""text"" placeholder=""Número Documento"" required disabled>
                </div>
                <div class=""form-group"">
                    <input class=""form-control"" name=""PrimerNombre"" type=""text"" placeholder=""Primer Nombre"" required disabled>
                </div>
                <div class=""form-group"">
                    <input class=""form-control"" name=""SegundoNombre"" type=""text"" placeholder=""Segundo Nombre"" required disabled>
                </div>
                <div class=""form-group"">
                    <input class=""form-control"" name=""PrimerApellido"" type=""text"" placeholder=""Primer Apellido"" required disabled>
                </div>
                <div class=""form-group"">
                    <input class=""form-control"" name=""SegundoApellido"" type=""text"" placeholder=""Segundo Apellido"" required disabled>
                </div>
                <div class=""form-group"">
                    <input class=""form-control"" ");
                WriteLiteral("name=\"Correo\" type=\"email\" placeholder=\"Correo\" required");
                BeginWriteAttribute("name", " name=\"", 1419, "\"", 1426, 0);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 1427, "\"", 1432, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                </div>
                <div class=""form-group"">
                    <input class=""form-control"" name=""Telefono"" type=""tel"" placeholder=""Telefono"" required>
                </div>
                <div class=""form-group"">
                    <input class=""form-control"" name=""Direccion"" type=""text"" placeholder=""Dirección"" required>
                </div>
                <div class=""form-group"">
                    <input class=""form-control"" name=""Estatura"" type=""text"" placeholder=""Estatura"" required>
                </div>
                <div class=""form-group"">
                    <label");
                BeginWriteAttribute("for", " for=\"", 2057, "\"", 2063, 0);
                EndWriteAttribute();
                WriteLiteral(">Fecha Nacimiento</label>\r\n                    <input class=\"form-control\" type=\"date\" name=\"fechanacimiento\"");
                BeginWriteAttribute("id", " id=\"", 2173, "\"", 2178, 0);
                EndWriteAttribute();
                WriteLiteral(" required disabled>\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <button class=\"form-control btn btn-primary btn-block\" type=\"submit\">Actualizar</button>\r\n                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NutriTic.App.Frontend.Pages.ProfileModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<NutriTic.App.Frontend.Pages.ProfileModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<NutriTic.App.Frontend.Pages.ProfileModel>)PageContext?.ViewData;
        public NutriTic.App.Frontend.Pages.ProfileModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
