#pragma checksum "E:\proyectos\prueba\nutriTic\NutriTic.App.Frontend\Pages\Colsultas\Consultas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "451b5220cf8a3fe8283c04e517b7e2bfa4d9724e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(NutriTic.App.Frontend.Pages.Colsultas.Pages_Colsultas_Consultas), @"mvc.1.0.razor-page", @"/Pages/Colsultas/Consultas.cshtml")]
namespace NutriTic.App.Frontend.Pages.Colsultas
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"451b5220cf8a3fe8283c04e517b7e2bfa4d9724e", @"/Pages/Colsultas/Consultas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5afd4fc3733f6637463a3148ecea1d223d896b5", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Colsultas_Consultas : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\proyectos\prueba\nutriTic\NutriTic.App.Frontend\Pages\Colsultas\Consultas.cshtml"
  
    Layout="_LayoutEmpleado";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div>
    <h3>Empleados segun el cargo</h3>
    
    <table class=""table"">
        <thead>
            <tr>                
                <th>Id Empleado</th>
                <th>Id Cargo</th>
                
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 19 "E:\proyectos\prueba\nutriTic\NutriTic.App.Frontend\Pages\Colsultas\Consultas.cshtml"
             foreach (var e in Model.Empleados)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 22 "E:\proyectos\prueba\nutriTic\NutriTic.App.Frontend\Pages\Colsultas\Consultas.cshtml"
                               Write(e.IdEmpleado);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>   \r\n                                <td>");
#nullable restore
#line 23 "E:\proyectos\prueba\nutriTic\NutriTic.App.Frontend\Pages\Colsultas\Consultas.cshtml"
                               Write(e.IdCargoEmpleado);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                           </tr>\r\n");
#nullable restore
#line 25 "E:\proyectos\prueba\nutriTic\NutriTic.App.Frontend\Pages\Colsultas\Consultas.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NutriTic.App.Frontend.Pages.ConsultasModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<NutriTic.App.Frontend.Pages.ConsultasModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<NutriTic.App.Frontend.Pages.ConsultasModel>)PageContext?.ViewData;
        public NutriTic.App.Frontend.Pages.ConsultasModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
