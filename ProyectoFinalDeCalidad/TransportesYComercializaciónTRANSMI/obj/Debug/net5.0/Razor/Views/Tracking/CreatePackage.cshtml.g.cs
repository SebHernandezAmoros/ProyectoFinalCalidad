#pragma checksum "D:\CICLOS\Ciclo 9\Calidad\ProyectoFinalCalidad\ProyectoFinalDeCalidad\TransportesYComercializaciónTRANSMI\Views\Tracking\CreatePackage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18173827aafd555681ea97d5caa08c375984faf9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tracking_CreatePackage), @"mvc.1.0.view", @"/Views/Tracking/CreatePackage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18173827aafd555681ea97d5caa08c375984faf9", @"/Views/Tracking/CreatePackage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f9d80f82a4e8bb7f403ac7e96854e4fac8c99bb", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Tracking_CreatePackage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Lima", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Trujillo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Cajamarca", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Arequipa", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Cuzco", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/tracking/CreatePackage"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-6 offset-3\">\r\n            <h1 id=\"TituloFormularioPaquete\">Formulario de paquete</h1>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "18173827aafd555681ea97d5caa08c375984faf95981", async() => {
                WriteLiteral("\r\n                <div class=\"mb-3\">\r\n                    <label for=\"Contenido\">Ingrese el contenido:</label>\r\n                    <input type=\"text\" class=\"form-control\" name=\"Contenido\" id=\"Contenido\"");
                BeginWriteAttribute("value", " value=\"", 427, "\"", 451, 1);
#nullable restore
#line 8 "D:\CICLOS\Ciclo 9\Calidad\ProyectoFinalCalidad\ProyectoFinalDeCalidad\TransportesYComercializaciónTRANSMI\Views\Tracking\CreatePackage.cshtml"
WriteAttributeValue("", 435, Model.Contenido, 435, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                    <p class=\"text-danger\">");
#nullable restore
#line 9 "D:\CICLOS\Ciclo 9\Calidad\ProyectoFinalCalidad\ProyectoFinalDeCalidad\TransportesYComercializaciónTRANSMI\Views\Tracking\CreatePackage.cshtml"
                                      Write(Html.ValidationMessage("Contenido"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                </div>\r\n                <div class=\"mb-3\">\r\n                    <label for=\"Peso\">Ingrese peso en Kg:</label>\r\n                    <input type=\"text\" class=\"form-control\" name=\"Peso\" id=\"Peso\"");
                BeginWriteAttribute("value", " value=\"", 748, "\"", 767, 1);
#nullable restore
#line 13 "D:\CICLOS\Ciclo 9\Calidad\ProyectoFinalCalidad\ProyectoFinalDeCalidad\TransportesYComercializaciónTRANSMI\Views\Tracking\CreatePackage.cshtml"
WriteAttributeValue("", 756, Model.Peso, 756, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                    <p class=\"text-danger\">");
#nullable restore
#line 14 "D:\CICLOS\Ciclo 9\Calidad\ProyectoFinalCalidad\ProyectoFinalDeCalidad\TransportesYComercializaciónTRANSMI\Views\Tracking\CreatePackage.cshtml"
                                      Write(Html.ValidationMessage("Peso"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                </div>
                <div class=""mb-3"">
                    <h6>Ingrese dimensiones:</h6>
                    <br />
                    <label for=""DimensionX"">Ingrese X (cm):</label>
                    <input type=""number"" class=""form-control"" name=""DimensionX"" id=""DimensionX""");
                BeginWriteAttribute("value", " value=\"", 1154, "\"", 1179, 1);
#nullable restore
#line 20 "D:\CICLOS\Ciclo 9\Calidad\ProyectoFinalCalidad\ProyectoFinalDeCalidad\TransportesYComercializaciónTRANSMI\Views\Tracking\CreatePackage.cshtml"
WriteAttributeValue("", 1162, Model.DimensionX, 1162, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                    <p class=\"text-danger\">");
#nullable restore
#line 21 "D:\CICLOS\Ciclo 9\Calidad\ProyectoFinalCalidad\ProyectoFinalDeCalidad\TransportesYComercializaciónTRANSMI\Views\Tracking\CreatePackage.cshtml"
                                      Write(Html.ValidationMessage("DimensionX"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                    <label for=\"DimensionY\">Ingrese Y (cm):</label>\r\n                    <input type=\"number\" class=\"form-control\" name=\"DimensionY\" id=\"DimensionY\"");
                BeginWriteAttribute("value", " value=\"", 1433, "\"", 1458, 1);
#nullable restore
#line 23 "D:\CICLOS\Ciclo 9\Calidad\ProyectoFinalCalidad\ProyectoFinalDeCalidad\TransportesYComercializaciónTRANSMI\Views\Tracking\CreatePackage.cshtml"
WriteAttributeValue("", 1441, Model.DimensionY, 1441, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                    <p class=\"text-danger\">");
#nullable restore
#line 24 "D:\CICLOS\Ciclo 9\Calidad\ProyectoFinalCalidad\ProyectoFinalDeCalidad\TransportesYComercializaciónTRANSMI\Views\Tracking\CreatePackage.cshtml"
                                      Write(Html.ValidationMessage("DimensionY"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                    <label for=\"DimensionZ\">Ingrese Z (cm):</label>\r\n                    <input type=\"number\" class=\"form-control\" name=\"DimensionZ\" id=\"DimensionZ\"");
                BeginWriteAttribute("value", " value=\"", 1712, "\"", 1737, 1);
#nullable restore
#line 26 "D:\CICLOS\Ciclo 9\Calidad\ProyectoFinalCalidad\ProyectoFinalDeCalidad\TransportesYComercializaciónTRANSMI\Views\Tracking\CreatePackage.cshtml"
WriteAttributeValue("", 1720, Model.DimensionZ, 1720, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                    <p class=\"text-danger\">");
#nullable restore
#line 27 "D:\CICLOS\Ciclo 9\Calidad\ProyectoFinalCalidad\ProyectoFinalDeCalidad\TransportesYComercializaciónTRANSMI\Views\Tracking\CreatePackage.cshtml"
                                      Write(Html.ValidationMessage("DimensionZ"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                </div>
                <div class=""mb-3"">
                    <label for=""CiudadOrigen"">Ingrese ciudad de origen:</label>
                    <select class=""form-control"" name=""CiudadOrigen"" id=""CiudadOrigen"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "18173827aafd555681ea97d5caa08c375984faf911807", async() => {
                    WriteLiteral("Lima");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "18173827aafd555681ea97d5caa08c375984faf913053", async() => {
                    WriteLiteral("Trujillo");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "18173827aafd555681ea97d5caa08c375984faf914303", async() => {
                    WriteLiteral("Cajamarca");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "18173827aafd555681ea97d5caa08c375984faf915554", async() => {
                    WriteLiteral("Arequipa");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "18173827aafd555681ea97d5caa08c375984faf916804", async() => {
                    WriteLiteral("Cuzco");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </select>\r\n                    <p class=\"text-danger\">");
#nullable restore
#line 38 "D:\CICLOS\Ciclo 9\Calidad\ProyectoFinalCalidad\ProyectoFinalDeCalidad\TransportesYComercializaciónTRANSMI\Views\Tracking\CreatePackage.cshtml"
                                      Write(Html.ValidationMessage("Ciudad"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                </div>\r\n                <div class=\"mb-3\">\r\n                    <label for=\"CiudadMeta\">Ingrese ciudad meta:</label>\r\n                    <select class=\"form-control\" name=\"CiudadMeta\" id=\"CiudadMeta\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "18173827aafd555681ea97d5caa08c375984faf918712", async() => {
                    WriteLiteral("Lima");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "18173827aafd555681ea97d5caa08c375984faf919958", async() => {
                    WriteLiteral("Trujillo");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "18173827aafd555681ea97d5caa08c375984faf921208", async() => {
                    WriteLiteral("Cajamarca");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "18173827aafd555681ea97d5caa08c375984faf922459", async() => {
                    WriteLiteral("Arequipa");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "18173827aafd555681ea97d5caa08c375984faf923709", async() => {
                    WriteLiteral("Cuzco");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </select>\r\n                    <p class=\"text-danger\">");
#nullable restore
#line 49 "D:\CICLOS\Ciclo 9\Calidad\ProyectoFinalCalidad\ProyectoFinalDeCalidad\TransportesYComercializaciónTRANSMI\Views\Tracking\CreatePackage.cshtml"
                                      Write(Html.ValidationMessage("Ciudad"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                </div>\r\n                <div class=\"mb-3\">\r\n                    <label for=\"PrecioEnvio\">Ingrese precio del servico (S/.):</label>\r\n                    <input type=\"text\" class=\"form-control\" name=\"PrecioEnvio\" id=\"PrecioEnvio\"");
                BeginWriteAttribute("value", " value=\"", 3401, "\"", 3427, 1);
#nullable restore
#line 53 "D:\CICLOS\Ciclo 9\Calidad\ProyectoFinalCalidad\ProyectoFinalDeCalidad\TransportesYComercializaciónTRANSMI\Views\Tracking\CreatePackage.cshtml"
WriteAttributeValue("", 3409, Model.PrecioEnvio, 3409, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                    <p class=\"text-danger\">");
#nullable restore
#line 54 "D:\CICLOS\Ciclo 9\Calidad\ProyectoFinalCalidad\ProyectoFinalDeCalidad\TransportesYComercializaciónTRANSMI\Views\Tracking\CreatePackage.cshtml"
                                      Write(Html.ValidationMessage("Precio"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                </div>\r\n            <div class=\"mb-3\">\r\n                ");
#nullable restore
#line 57 "D:\CICLOS\Ciclo 9\Calidad\ProyectoFinalCalidad\ProyectoFinalDeCalidad\TransportesYComercializaciónTRANSMI\Views\Tracking\CreatePackage.cshtml"
           Write(Html.CheckBox("Pagado"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <label>Marque si el servicio es pagado por adelantado</label>\r\n                <p class=\"text-danger\">");
#nullable restore
#line 59 "D:\CICLOS\Ciclo 9\Calidad\ProyectoFinalCalidad\ProyectoFinalDeCalidad\TransportesYComercializaciónTRANSMI\Views\Tracking\CreatePackage.cshtml"
                                  Write(Html.ValidationMessage("Pagado"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n\r\n            </div>\r\n\r\n                <button class=\"btn btn-primary\">Continuar</button>\r\n                <a href=\"/tracking/index\" class=\"btn btn-link\">Cancelar</a>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
