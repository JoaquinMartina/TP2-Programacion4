#pragma checksum "D:\Usuario\Documents\Facultad\2-Tecnicatura en Programacion\2do Año\Laboratorio IV\TP2\WebApplication1\WebApplication1\Views\AlumnoCatedras\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af3e97d7b1b72d0c67dee565d5c0ff8cc5007255"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AlumnoCatedras_Index), @"mvc.1.0.view", @"/Views/AlumnoCatedras/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AlumnoCatedras/Index.cshtml", typeof(AspNetCore.Views_AlumnoCatedras_Index))]
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
#line 1 "D:\Usuario\Documents\Facultad\2-Tecnicatura en Programacion\2do Año\Laboratorio IV\TP2\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#line 2 "D:\Usuario\Documents\Facultad\2-Tecnicatura en Programacion\2do Año\Laboratorio IV\TP2\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af3e97d7b1b72d0c67dee565d5c0ff8cc5007255", @"/Views/AlumnoCatedras/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_AlumnoCatedras_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication1.ViewModel.AlumnosCatedrasViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Paginador", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(59, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Usuario\Documents\Facultad\2-Tecnicatura en Programacion\2do Año\Laboratorio IV\TP2\WebApplication1\WebApplication1\Views\AlumnoCatedras\Index.cshtml"
  
    ViewData["Title"] = "Inscripciones";

#line default
#line hidden
            BeginContext(110, 37, true);
            WriteLiteral("\r\n<h1>Inscripciones</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(147, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af3e97d7b1b72d0c67dee565d5c0ff8cc50072557266", async() => {
                BeginContext(194, 5, true);
                WriteLiteral("Nueva");
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
            BeginContext(203, 10, true);
            WriteLiteral("\r\n</p>\r\n\r\n");
            EndContext();
            BeginContext(213, 544, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af3e97d7b1b72d0c67dee565d5c0ff8cc50072558731", async() => {
                BeginContext(251, 173, true);
                WriteLiteral("\r\n    <p>\r\n        <div class=\"form-row\">\r\n            <div class=\"form-group col-md-4\">\r\n                <!--Filtro por Nombre de alumno-->\r\n                Nombre Alumno: ");
                EndContext();
                BeginContext(424, 66, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "af3e97d7b1b72d0c67dee565d5c0ff8cc50072559297", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#line 18 "D:\Usuario\Documents\Facultad\2-Tecnicatura en Programacion\2do Año\Laboratorio IV\TP2\WebApplication1\WebApplication1\Views\AlumnoCatedras\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.textoBusqueda);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(490, 260, true);
                WriteLiteral(@"
            </div>
        </div>
        <div class=""form-row"">
            <div class=""form-group col-md-4"">
                <input class=""btn btn-primary btn-lg btn-block"" type=""submit"" value=""Buscar"" />
            </div>
        </div>
    </p>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(757, 100, true);
            WriteLiteral("\r\n\r\n<table class=\"table table-hover\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(858, 61, false);
#line 33 "D:\Usuario\Documents\Facultad\2-Tecnicatura en Programacion\2do Año\Laboratorio IV\TP2\WebApplication1\WebApplication1\Views\AlumnoCatedras\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.AlumnosCatedras[0].Alumno));

#line default
#line hidden
            EndContext();
            BeginContext(919, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(975, 62, false);
#line 36 "D:\Usuario\Documents\Facultad\2-Tecnicatura en Programacion\2do Año\Laboratorio IV\TP2\WebApplication1\WebApplication1\Views\AlumnoCatedras\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.AlumnosCatedras[0].Catedra));

#line default
#line hidden
            EndContext();
            BeginContext(1037, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1093, 67, false);
#line 39 "D:\Usuario\Documents\Facultad\2-Tecnicatura en Programacion\2do Año\Laboratorio IV\TP2\WebApplication1\WebApplication1\Views\AlumnoCatedras\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.AlumnosCatedras[0].Cuatrimestre));

#line default
#line hidden
            EndContext();
            BeginContext(1160, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1216, 69, false);
#line 42 "D:\Usuario\Documents\Facultad\2-Tecnicatura en Programacion\2do Año\Laboratorio IV\TP2\WebApplication1\WebApplication1\Views\AlumnoCatedras\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.AlumnosCatedras[0].FechaInscripto));

#line default
#line hidden
            EndContext();
            BeginContext(1285, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 48 "D:\Usuario\Documents\Facultad\2-Tecnicatura en Programacion\2do Año\Laboratorio IV\TP2\WebApplication1\WebApplication1\Views\AlumnoCatedras\Index.cshtml"
         foreach (var item in Model.AlumnosCatedras)
        {

#line default
#line hidden
            BeginContext(1436, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1485, 50, false);
#line 52 "D:\Usuario\Documents\Facultad\2-Tecnicatura en Programacion\2do Año\Laboratorio IV\TP2\WebApplication1\WebApplication1\Views\AlumnoCatedras\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Alumno.Apellido));

#line default
#line hidden
            EndContext();
            BeginContext(1535, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1554, 48, false);
#line 53 "D:\Usuario\Documents\Facultad\2-Tecnicatura en Programacion\2do Año\Laboratorio IV\TP2\WebApplication1\WebApplication1\Views\AlumnoCatedras\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Alumno.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(1602, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1658, 54, false);
#line 56 "D:\Usuario\Documents\Facultad\2-Tecnicatura en Programacion\2do Año\Laboratorio IV\TP2\WebApplication1\WebApplication1\Views\AlumnoCatedras\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Catedra.Descripcion));

#line default
#line hidden
            EndContext();
            BeginContext(1712, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1768, 47, false);
#line 59 "D:\Usuario\Documents\Facultad\2-Tecnicatura en Programacion\2do Año\Laboratorio IV\TP2\WebApplication1\WebApplication1\Views\AlumnoCatedras\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Cuatrimestre));

#line default
#line hidden
            EndContext();
            BeginContext(1815, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1871, 49, false);
#line 62 "D:\Usuario\Documents\Facultad\2-Tecnicatura en Programacion\2do Año\Laboratorio IV\TP2\WebApplication1\WebApplication1\Views\AlumnoCatedras\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FechaInscripto));

#line default
#line hidden
            EndContext();
            BeginContext(1920, 82, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a class=\"btn btn-primary\" ");
            EndContext();
            BeginContext(2003, 113, false);
#line 65 "D:\Usuario\Documents\Facultad\2-Tecnicatura en Programacion\2do Año\Laboratorio IV\TP2\WebApplication1\WebApplication1\Views\AlumnoCatedras\Index.cshtml"
                                      Write(Html.ActionLink("Editar", "Edit", "AlumnoCatedras", new { idAlumno = item.AlumnoId, idCatedra = item.CatedraId }));

#line default
#line hidden
            EndContext();
            BeginContext(2116, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(2134, 88, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af3e97d7b1b72d0c67dee565d5c0ff8cc500725518670", async() => {
                BeginContext(2210, 8, true);
                WriteLiteral("Eliminar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 66 "D:\Usuario\Documents\Facultad\2-Tecnicatura en Programacion\2do Año\Laboratorio IV\TP2\WebApplication1\WebApplication1\Views\AlumnoCatedras\Index.cshtml"
                                                                WriteLiteral(item.AlumnoId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2222, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 69 "D:\Usuario\Documents\Facultad\2-Tecnicatura en Programacion\2do Año\Laboratorio IV\TP2\WebApplication1\WebApplication1\Views\AlumnoCatedras\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2269, 74, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<!-- Paginacion (Transformada a componente)-->\r\n");
            EndContext();
            BeginContext(2343, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "af3e97d7b1b72d0c67dee565d5c0ff8cc500725521617", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
#line 74 "D:\Usuario\Documents\Facultad\2-Tecnicatura en Programacion\2do Año\Laboratorio IV\TP2\WebApplication1\WebApplication1\Views\AlumnoCatedras\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.paginador);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("for", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication1.ViewModel.AlumnosCatedrasViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
