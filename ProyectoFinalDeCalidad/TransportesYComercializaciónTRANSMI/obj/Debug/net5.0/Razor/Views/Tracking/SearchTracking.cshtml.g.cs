#pragma checksum "D:\CICLOS\Ciclo 9\Calidad\ProyectoFinalCalidad\ProyectoFinalDeCalidad\TransportesYComercializaciónTRANSMI\Views\Tracking\SearchTracking.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f3b566c7756135918e8b5e1bd89f8059c1afc0a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tracking_SearchTracking), @"mvc.1.0.view", @"/Views/Tracking/SearchTracking.cshtml")]
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
#nullable restore
#line 1 "D:\CICLOS\Ciclo 9\Calidad\ProyectoFinalCalidad\ProyectoFinalDeCalidad\TransportesYComercializaciónTRANSMI\Views\_ViewImports.cshtml"
using TransportesYComercializaciónTRANSMI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\CICLOS\Ciclo 9\Calidad\ProyectoFinalCalidad\ProyectoFinalDeCalidad\TransportesYComercializaciónTRANSMI\Views\_ViewImports.cshtml"
using TransportesYComercializaciónTRANSMI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f3b566c7756135918e8b5e1bd89f8059c1afc0a", @"/Views/Tracking/SearchTracking.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f9d80f82a4e8bb7f403ac7e96854e4fac8c99bb", @"/Views/_ViewImports.cshtml")]
    public class Views_Tracking_SearchTracking : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
            WriteLiteral("<div class=\"container\">\r\n");
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f3b566c7756135918e8b5e1bd89f8059c1afc0a3542", async() => {
                WriteLiteral("\r\n        <h1>Datos del paquete</h1>\r\n        <div class=\"form-group row\">\r\n            <label class=\"col-sm-2 col-form-label\">Contenido:</label>\r\n            <div class=\"col-sm-10\">\r\n                <input class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 303, "\"", 337, 1);
#nullable restore
#line 8 "D:\CICLOS\Ciclo 9\Calidad\ProyectoFinalCalidad\ProyectoFinalDeCalidad\TransportesYComercializaciónTRANSMI\Views\Tracking\SearchTracking.cshtml"
WriteAttributeValue("", 311, ViewBag.Package.Contenido, 311, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" disabled>\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group row\">\r\n            <label class=\"col-sm-2 col-form-label\">Peso:</label>\r\n            <div class=\"col-sm-10\">\r\n                <input class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 570, "\"", 602, 2);
#nullable restore
#line 14 "D:\CICLOS\Ciclo 9\Calidad\ProyectoFinalCalidad\ProyectoFinalDeCalidad\TransportesYComercializaciónTRANSMI\Views\Tracking\SearchTracking.cshtml"
WriteAttributeValue("", 578, ViewBag.Package.Peso, 578, 21, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 599, "Kg", 600, 3, true);
                EndWriteAttribute();
                WriteLiteral(" disabled>\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group row\">\r\n            <label class=\"col-sm-2 col-form-label\">Dimensiones:</label>\r\n            <div class=\"col-sm-10\">\r\n                <input class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 842, "\"", 883, 3);
                WriteAttributeValue("", 850, "X:", 850, 2, true);
#nullable restore
#line 20 "D:\CICLOS\Ciclo 9\Calidad\ProyectoFinalCalidad\ProyectoFinalDeCalidad\TransportesYComercializaciónTRANSMI\Views\Tracking\SearchTracking.cshtml"
WriteAttributeValue(" ", 852, ViewBag.Package.DimensionX, 853, 27, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 880, "cm", 881, 3, true);
                EndWriteAttribute();
                WriteLiteral(" disabled>\r\n                <input class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 939, "\"", 980, 3);
                WriteAttributeValue("", 947, "Y:", 947, 2, true);
#nullable restore
#line 21 "D:\CICLOS\Ciclo 9\Calidad\ProyectoFinalCalidad\ProyectoFinalDeCalidad\TransportesYComercializaciónTRANSMI\Views\Tracking\SearchTracking.cshtml"
WriteAttributeValue(" ", 949, ViewBag.Package.DimensionY, 950, 27, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 977, "cm", 978, 3, true);
                EndWriteAttribute();
                WriteLiteral(" disabled>\r\n                <input class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 1036, "\"", 1077, 3);
                WriteAttributeValue("", 1044, "Z:", 1044, 2, true);
#nullable restore
#line 22 "D:\CICLOS\Ciclo 9\Calidad\ProyectoFinalCalidad\ProyectoFinalDeCalidad\TransportesYComercializaciónTRANSMI\Views\Tracking\SearchTracking.cshtml"
WriteAttributeValue(" ", 1046, ViewBag.Package.DimensionZ, 1047, 27, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 1074, "cm", 1075, 3, true);
                EndWriteAttribute();
                WriteLiteral(" disabled>\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group row\">\r\n            <label class=\"col-sm-2 col-form-label\">Ciudad de origen:</label>\r\n            <div class=\"col-sm-10\">\r\n                <input class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 1322, "\"", 1359, 1);
#nullable restore
#line 28 "D:\CICLOS\Ciclo 9\Calidad\ProyectoFinalCalidad\ProyectoFinalDeCalidad\TransportesYComercializaciónTRANSMI\Views\Tracking\SearchTracking.cshtml"
WriteAttributeValue("", 1330, ViewBag.Package.CiudadOrigen, 1330, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" disabled>\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group row\">\r\n            <label class=\"col-sm-2 col-form-label\">Ciudad meta:</label>\r\n            <div class=\"col-sm-10\">\r\n                <input class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 1599, "\"", 1634, 1);
#nullable restore
#line 34 "D:\CICLOS\Ciclo 9\Calidad\ProyectoFinalCalidad\ProyectoFinalDeCalidad\TransportesYComercializaciónTRANSMI\Views\Tracking\SearchTracking.cshtml"
WriteAttributeValue("", 1607, ViewBag.Package.CiudadMeta, 1607, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" disabled>\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group row\">\r\n            <label class=\"col-sm-2 col-form-label\">Precio:</label>\r\n            <div class=\"col-sm-10\">\r\n                <input class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 1869, "\"", 1909, 2);
                WriteAttributeValue("", 1877, "S/.", 1877, 3, true);
#nullable restore
#line 40 "D:\CICLOS\Ciclo 9\Calidad\ProyectoFinalCalidad\ProyectoFinalDeCalidad\TransportesYComercializaciónTRANSMI\Views\Tracking\SearchTracking.cshtml"
WriteAttributeValue(" ", 1880, ViewBag.Package.PrecioEnvio, 1881, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" disabled>\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group row\">\r\n            <label class=\"col-sm-2 col-form-label\">Facturado:</label>\r\n");
#nullable restore
#line 45 "D:\CICLOS\Ciclo 9\Calidad\ProyectoFinalCalidad\ProyectoFinalDeCalidad\TransportesYComercializaciónTRANSMI\Views\Tracking\SearchTracking.cshtml"
             if (@ViewBag.Package.Pagado == true)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"col-sm-10\">\r\n                    <input class=\"form-control\" value=\"El envio ya se cancelo\" disabled>\r\n                </div>\r\n");
#nullable restore
#line 50 "D:\CICLOS\Ciclo 9\Calidad\ProyectoFinalCalidad\ProyectoFinalDeCalidad\TransportesYComercializaciónTRANSMI\Views\Tracking\SearchTracking.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"col-sm-10\">\r\n                    <input class=\"form-control\" value=\"El envio sera cancelado por el receptor\" disabled>\r\n                </div>\r\n");
#nullable restore
#line 56 "D:\CICLOS\Ciclo 9\Calidad\ProyectoFinalCalidad\ProyectoFinalDeCalidad\TransportesYComercializaciónTRANSMI\Views\Tracking\SearchTracking.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
   
    <h1>Ruta paquete</h1>
    <table class=""table"">

        <thead>
            <tr>
                <th>Ciudad actual</th>
                <th>Fecha de actualizacion</th>
                <th>Estado</th>

            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 72 "D:\CICLOS\Ciclo 9\Calidad\ProyectoFinalCalidad\ProyectoFinalDeCalidad\TransportesYComercializaciónTRANSMI\Views\Tracking\SearchTracking.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 75 "D:\CICLOS\Ciclo 9\Calidad\ProyectoFinalCalidad\ProyectoFinalDeCalidad\TransportesYComercializaciónTRANSMI\Views\Tracking\SearchTracking.cshtml"
                   Write(item.CiudadActual);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 76 "D:\CICLOS\Ciclo 9\Calidad\ProyectoFinalCalidad\ProyectoFinalDeCalidad\TransportesYComercializaciónTRANSMI\Views\Tracking\SearchTracking.cshtml"
                   Write(item.FechaActualizacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 77 "D:\CICLOS\Ciclo 9\Calidad\ProyectoFinalCalidad\ProyectoFinalDeCalidad\TransportesYComercializaciónTRANSMI\Views\Tracking\SearchTracking.cshtml"
                   Write(item.Estado);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                </tr>\r\n");
#nullable restore
#line 80 "D:\CICLOS\Ciclo 9\Calidad\ProyectoFinalCalidad\ProyectoFinalDeCalidad\TransportesYComercializaciónTRANSMI\Views\Tracking\SearchTracking.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n\r\n    </table>\r\n    <h1>Emisor y receptor del paquete</h1>\r\n");
            WriteLiteral("    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>Rol</th>\r\n                <th>Cliente</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 95 "D:\CICLOS\Ciclo 9\Calidad\ProyectoFinalCalidad\ProyectoFinalDeCalidad\TransportesYComercializaciónTRANSMI\Views\Tracking\SearchTracking.cshtml"
             foreach (var item in ViewBag.Actors)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 98 "D:\CICLOS\Ciclo 9\Calidad\ProyectoFinalCalidad\ProyectoFinalDeCalidad\TransportesYComercializaciónTRANSMI\Views\Tracking\SearchTracking.cshtml"
                   Write(item.Rol);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 99 "D:\CICLOS\Ciclo 9\Calidad\ProyectoFinalCalidad\ProyectoFinalDeCalidad\TransportesYComercializaciónTRANSMI\Views\Tracking\SearchTracking.cshtml"
                   Write(item.Clientë.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 99 "D:\CICLOS\Ciclo 9\Calidad\ProyectoFinalCalidad\ProyectoFinalDeCalidad\TransportesYComercializaciónTRANSMI\Views\Tracking\SearchTracking.cshtml"
                                        Write(item.Clientë.Apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 101 "D:\CICLOS\Ciclo 9\Calidad\ProyectoFinalCalidad\ProyectoFinalDeCalidad\TransportesYComercializaciónTRANSMI\Views\Tracking\SearchTracking.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n    <a href=\"/tracking/index\" class=\"btn btn-secondary\">Regresar</a>\r\n</div>\r\n");
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
