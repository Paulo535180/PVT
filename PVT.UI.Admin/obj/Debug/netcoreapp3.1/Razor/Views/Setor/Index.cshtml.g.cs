#pragma checksum "C:\Users\paulo.aguiar\Desktop\PVT\PVT\PVT.UI.Admin\Views\Setor\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "814ddecef70bab8d90e3885de867343ec9838084"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Setor_Index), @"mvc.1.0.view", @"/Views/Setor/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"814ddecef70bab8d90e3885de867343ec9838084", @"/Views/Setor/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6b01df0e5893b1c9de3c2f4b79ebd6098579ba3", @"/Views/_ViewImports.cshtml")]
    public class Views_Setor_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/app/factory/httpPadrao.factory.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/app/service/setores.service.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/app/controllers/setor.controller.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\paulo.aguiar\Desktop\PVT\PVT\PVT.UI.Admin\Views\Setor\Index.cshtml"
  
    ViewBag.Title = "Setores";


#line default
#line hidden
#nullable disable
            WriteLiteral("<style>\r\n    #modalVinculoGestor {\r\n        z-index: 3000;\r\n    }\r\n</style>\r\n\r\n<div ng-controller=\"setor\">\r\n    <div class=\"page-header justify-content\">\r\n        <h3>");
#nullable restore
#line 13 "C:\Users\paulo.aguiar\Desktop\PVT\PVT\PVT.UI.Admin\Views\Setor\Index.cshtml"
       Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        <button class=\"btn btn-primary btn-sm\" ng-click=\"AbrirModalNovo()\">Cadastrar Setor</button>\r\n    </div>\r\n\r\n\r\n    <div class=\"row layout-top-spacing\">\r\n\r\n");
            WriteLiteral(@"        <div class=""container-fluid"">
            <div class=""card border-double"">
                <div class=""card-body"">

                    <table id=""DtResult"" datatable=""ng"" dt-options=""dtOptions""
                           class=""table table-hover dataTable""
                           style=""width: 100%"" role=""grid"" ng-init=""BuscarSetores()"">
                        <thead>
                            <tr>
                                <th class=""text-center"">Nome</th>
                                <th class=""text-center"">Descricao</th>
                                <th class=""text-center"">Data Criacão</th>
                                <th class=""text-center"">Usuario Criação</th>
                                <th class=""text-center"">Ativar/Desativar</th>
                                <th class=""text-center"">Ações</th>
                            </tr>
                        </thead>

                        <tbody>
                            <tr ng-repeat=""item in List");
            WriteLiteral(@"agemSetores | filter: filtro"">
                                <td class=""text-center"">{{item.NOME}}</td>
                                <td class=""text-center"">{{item.DESCRICAO}}</td>
                                <td class=""text-center"">{{item.DATA_CRIACAO | date : 'dd/MM/yyyy'}}</td>
                                <td class=""text-center"">{{item.USUARIO_CRIACAO}}</td>
                                <td class=""text-center"">
                                    <button type=""button"" ng-class=""botaoClass(item.STATUS)"" ng-click=""AlterarStatus(item)""><i class=""fas fa-check""></i></button>
                                </td>
                                <td class=""text-center""><button type=""button"" class=""btn btn-primary btn-sm"" ng-click=""AbrirModalVisualizar(item)""><i class=""fas fa-eye""></i>Visualizar</button></td>
                            </tr>
                        </tbody>
                    </table>
                </div>
            </div>

        </div>


");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "814ddecef70bab8d90e3885de867343ec98380848359", async() => {
                WriteLiteral(@"
                        <div class=""modal-body"">
                            <div class=""form-group"">
                                <label for=""recipient-name"" class=""col-form-label"">Nome:</label>
                                <input type=""text"" class=""form-control"" id=""recipient-name"" ng-model=""setor.NOME"">
                            </div>
                            <div class=""form-group"">
                                <label for=""message-text"" class=""col-form-label"">Descrição:</label>
                                <textarea class=""form-control"" id=""message-text"" ng-model=""setor.DESCRICAO""></textarea>
                            </div>
                        </div>
                        <div class=""modal-footer"">
                            <button type=""button"" class=""btn btn-danger btn-sm"" data-dismiss=""modal"">Fechar</button>
                            <button type=""button"" class=""btn btn-primary btn-sm"" ng-click=""AdicionarSetor(setor)"">Salvar</button>
                       ");
                WriteLiteral(" </div>\r\n                    ");
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
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n\r\n\r\n");
            WriteLiteral(@"        <div class=""modal fade"" id=""modalVinculoGestor"" tabindex=""-1"" role=""dialog"" aria-labelledby=""modalEdicaoLabel"" aria-hidden=""true"">
            <div class=""modal-dialog"" role=""document"">
                <div class=""modal-content"">
                    <div class=""modal-header"">
                        <h5 class=""modal-title"" id=""exampleModalLabel"">{{tituloModalVinculo}}</h5>
                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Fechar"">
                            <span aria-hidden=""true"">&times;</span>
                        </button>
                    </div>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "814ddecef70bab8d90e3885de867343ec983808411507", async() => {
                WriteLiteral(@"
                        <div class=""modal-body"">
                            <div class=""form-group"">
                                <select class=""form-control"" ng-model=""UserSetor.ID_USUARIO"" ng-options=""item.ID as item.Nome for item in ListaUsuarios"">
                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "814ddecef70bab8d90e3885de867343ec983808412070", async() => {
                    WriteLiteral("Selecione um Gestor para Adicionar");
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
                WriteLiteral(@"
                                </select>
                            </div>
                        </div>
                        <div class=""modal-footer"">
                            <button type=""button"" class=""btn btn-danger btn-sm"" data-dismiss=""modal"">Fechar</button>
                            <button type=""button"" class=""btn btn-primary btn-sm"" ng-click=""AdicionarGestor(UserSetor)"">Salvar</button>
                        </div>
                    ");
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
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n");
            WriteLiteral(@"        <div class=""modal fade"" id=""modalPrincipal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""modalPrincipal"" aria-hidden=""true"">
            <div class=""modal-dialog modal-xl"" role=""document"">
                <div class=""modal-content"">
                    <div class=""modal-header"">
                        <ul class=""nav nav-pills mb-3"" id=""pills-tab"" role=""tablist"">
                            <li class=""nav-item"">
                                <a class=""nav-link"" id=""detalhesSetorLink"" data-toggle=""pill"" href=""#detalhesSetor"" role=""tab"" aria-controls=""detalhesSetor"">Setor</a>
                            </li>

                            <li class=""nav-item"">
                                <a class=""nav-link"" id=""detalhesGestoresLink"" ng-click=""BuscarGestoresPorSetor(setor)""
                                   data-toggle=""pill"" href=""#detalhesGestores"" role=""tab"" aria-controls=""detalhesGestores"">Gestores</a>
                            </li>

                        </ul>

           ");
            WriteLiteral(@"             <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Fechar"">
                            <span aria-hidden=""true"">&times;</span>
                        </button>
                    </div>



                    <div class=""modal-body"">
                        <div class=""tab-content"" id=""pills-tabContent"">

                            <div class=""tab-pane fade"" id=""detalhesSetor"" role=""tabpanel"" aria-labelledby=""detalhesSetor"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "814ddecef70bab8d90e3885de867343ec983808416522", async() => {
                WriteLiteral(@"
                                    <div class=""modal-body"">
                                        <div class=""form-group"">
                                            <label for=""recipient-name"" class=""col-form-label"">Nome:</label>
                                            <input type=""text"" class=""form-control"" id=""recipient-name"" ng-model=""setor.NOME"">
                                        </div>
                                        <div class=""form-group"">
                                            <label for=""message-text"" class=""col-form-label"">Descrição:</label>
                                            <textarea class=""form-control"" id=""message-text"" ng-model=""setor.DESCRICAO""></textarea>
                                        </div>
                                    </div>
                                ");
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
                            </div>

                            <div class=""tab-pane fade"" id=""detalhesGestores"" role=""tabpanel"" aria-labelledby=""detalhesGestores"">
                                <div class=""col-md-12 mb-3 text-right"">
                                    <button class=""btn btn-primary btn-sm"" ng-click=""AbriModalAdicionarGestor(setor)"">Vincular Usuário</button>
                                </div>
                                <table class=""table table-hover"" width=""100%"">
                                    <thead>
                                        <tr>

                                            <th class=""text-center"">Id Gestor</th>
                                            <th class=""text-center"">Nome</th>
                                            <th class=""text-center"">Email</th>
                                            <th class=""text-center"">Ativar/Desativar</th>


                                        </tr>
                                    </");
            WriteLiteral(@"thead>
                                    <tbody>
                                        <tr ng-repeat=""item in ListarGestoresPorSetor | filter: filtro"">

                                            <td class=""text-center"">{{item.ID}}</td>
                                            <td class=""text-center"">{{item.NOME_GESTOR}}</td>
                                            <td class=""text-center"">{{item.EMAIL}}</td>
                                            <td class=""text-center"">
                                                <button type=""button"" ng-class=""botaoClass(item.STATUS)"" ng-click=""AlterarStatusGestor(item)""><i class=""fas fa-check""></i></button>
                                            </td>
                                        </tr>
                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </div>
                    <div class=""modal-footer"">
            ");
            WriteLiteral(@"            <button type=""button"" class=""btn btn-danger btn-sm"" data-dismiss=""modal"">Fechar</button>
                        <button type=""button"" class=""btn btn-primary btn-sm"" ng-click=""AdicionarSetor(setor)"">Salvar</button>

                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

");
            DefineSection("ScriptSectionRender", async() => {
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "814ddecef70bab8d90e3885de867343ec983808421253", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "814ddecef70bab8d90e3885de867343ec983808422353", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "814ddecef70bab8d90e3885de867343ec983808423453", async() => {
                    WriteLiteral("\r\n    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
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
            WriteLiteral("\r\n");
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
