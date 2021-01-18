#pragma checksum "C:\Users\paulo.aguiar\Desktop\PVT\PVT\PVT.UI.Admin\Views\Modulo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a92579ee8985279340ad8620a482bb1842519df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Modulo_Index), @"mvc.1.0.view", @"/Views/Modulo/Index.cshtml")]
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
#line 1 "C:\Users\paulo.aguiar\Desktop\PVT\PVT\PVT.UI.Admin\Views\_ViewImports.cshtml"
using PVT.UI.Admin;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a92579ee8985279340ad8620a482bb1842519df", @"/Views/Modulo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6b01df0e5893b1c9de3c2f4b79ebd6098579ba3", @"/Views/_ViewImports.cshtml")]
    public class Views_Modulo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/app/controllers/modulo.controller.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\paulo.aguiar\Desktop\PVT\PVT\PVT.UI.Admin\Views\Modulo\Index.cshtml"
  
    ViewBag.Title = "Módulos";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div ng-controller=\"modulo\">\r\n    <div class=\"page-header justify-content\">\r\n        <h3>");
#nullable restore
#line 8 "C:\Users\paulo.aguiar\Desktop\PVT\PVT\PVT.UI.Admin\Views\Modulo\Index.cshtml"
       Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
        <button class=""btn btn-primary"" ng-click=""AbrirModalEditar()"">Cadastrar Módulo</button>
    </div>


    <div class=""row layout-top-spacing"">
        <div class=""container-fluid"">
            <div class=""card border-double"">
                <div class=""card-body"">
                    <div class=""row"">
                        <div class=""col-md-12"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a92579ee8985279340ad8620a482bb1842519df4466", async() => {
                WriteLiteral("<input class=\"form-control\" placeholder=\"Pesquisar\" ng-model=\"filtro\" />");
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
            WriteLiteral(@"</div>
                    </div>
                    <table class=""table table-hover"" width=""100%"" ng-init=""BuscarModulos()"">
                        <thead>
                            <tr>

                                <th class=""text-center"">Nome</th>
                                <th class=""text-center"">Descricao</th>
                                <th class=""text-center"">Responsável</th>
                                <th class=""text-center"">Ativar/Desativar</th>
                                <th class=""text-center"">Ações</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr ng-repeat=""item in ListarModulos | filter: filtro"">

                                <td class=""text-center"">{{item.NOME}}</td>
                                <td class=""text-center"">{{item.DESCRICAO}}</td>
                                <td class=""text-center"">{{item.RESPONSAVEL}}</td>
                                <td ");
            WriteLiteral(@"class=""text-center"">
                                    <label class=""switch s-outline s-outline-success  mb-4 mr-2"">
                                        <input type=""checkbox"" ng-model=""item.STATUS"" ng-change=""AdicionarModulo(item)"">
                                        <span class=""slider round""></span>
                                    </label>
                                </td>
                                <td class=""text-center"">
                                    <button type=""button"" class=""btn btn-primary"" ng-click=""AbrirModalEditar(item)"">
                                        <svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-edit-2 text-success""><path d=""M17 3a2.828 2.828 0 1 1 4 4L7.5 20.5 2 22l1.5-5.5L17 3z""></path></svg>Editar
                                    </button>
                                </td>
      ");
            WriteLiteral("                      </tr>\r\n                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n\r\n");
            WriteLiteral(@"        <div class=""modal fade"" id=""modalEdicao"" tabindex=""-1"" role=""dialog"" aria-labelledby=""modalEdicaoLabel"" aria-hidden=""true"">
            <div class=""modal-dialog"" role=""document"">
                <div class=""modal-content"">
                    <div class=""modal-header"">
                        <h5 class=""modal-title"" id=""exampleModalLabel"">{{tituloModal}}</h5>
                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Fechar"">
                            <span aria-hidden=""true"">&times;</span>
                        </button>
                    </div>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a92579ee8985279340ad8620a482bb1842519df8814", async() => {
                WriteLiteral(@"
                        <div class=""modal-body"">
                            <div class=""form-group"">
                                <label for=""recipient-name"" class=""col-form-label"">Nome:</label>
                                <input type=""text"" class=""form-control"" id=""recipient-name"" ng-model=""modulo.NOME"">
                            </div>
                            <div class=""form-group"">
                                <label for=""message-text"" class=""col-form-label"">Descrição:</label>
                                <textarea class=""form-control"" id=""message-text"" ng-model=""modulo.DESCRICAO""></textarea>
                            </div>
                        </div>
                        <div class=""modal-footer"">
                            <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Fechar</button>
                            <button type=""button"" class=""btn btn-primary"" ng-click=""AdicionarModulo(modulo)"">Enviar</button>
                        </div>");
                WriteLiteral("\r\n                    ");
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
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("ScriptSectionRender", async() => {
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a92579ee8985279340ad8620a482bb1842519df11375", async() => {
                    WriteLiteral("\r\n    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
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
