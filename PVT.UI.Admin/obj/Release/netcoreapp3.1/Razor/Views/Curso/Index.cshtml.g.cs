#pragma checksum "C:\Users\paulo.aguiar\Desktop\PVT\PVT\PVT.UI.Admin\Views\Curso\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c05668313cf8702e850eb88146e626e3c7990d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Curso_Index), @"mvc.1.0.view", @"/Views/Curso/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c05668313cf8702e850eb88146e626e3c7990d5", @"/Views/Curso/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6b01df0e5893b1c9de3c2f4b79ebd6098579ba3", @"/Views/_ViewImports.cshtml")]
    public class Views_Curso_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/app/factory/httpPadrao.factory.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/app/service/modulo.service.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/app/service/curso.service.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/app/service/disciplina.service.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/app/controllers/curso.controller.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\paulo.aguiar\Desktop\PVT\PVT\PVT.UI.Admin\Views\Curso\Index.cshtml"
  
    ViewBag.Title = "Cursos";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<style>\r\n    #modalAdicionarDisciplina {\r\n        z-index: 3000;\r\n    }\r\n</style>\r\n\r\n<div ng-controller=\"curso\">\r\n\r\n    <div class=\"page-header justify-content\">\r\n        <h3>");
#nullable restore
#line 14 "C:\Users\paulo.aguiar\Desktop\PVT\PVT\PVT.UI.Admin\Views\Curso\Index.cshtml"
       Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        <div class=\"col-md-7 mb-3 text-right\">\r\n            <button class=\"btn btn-primary btn-sm\" ng-click=\"AbrirCadastroNovo()\">Novo Curso</button>\r\n        </div>\r\n    </div>\r\n");
            WriteLiteral(@"    <div class=""row layout-top-spacing"" ng-init=""Listagem()"">
        <div class=""container-fluid"">
            <div class=""card border-double"">
                <table id=""DtResult"" datatable=""ng"" dt-options=""dtOptions""
                       class=""table table-hover dataTable""
                       style=""width: 100%"" role=""grid"">
                    <thead>
                        <tr>
                            <th class=""text-center"">Id</th>
                            <th class=""text-center"">Curso</th>
                            <th class=""text-center"">Descrição</th>
                            <th class=""text-center"">Prioridade</th>
                            <th class=""text-center"">Modulo</th>
                            <th class=""text-center"">Ativar/Desativar</th>
                            <th class=""text-center"">Ações</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr ng-repeat=""item in Tabela"">
           ");
            WriteLiteral(@"                 <td class=""text-center"">{{item.ID}}</td>
                            <td class=""text-center"">{{item.NOME}}</td>
                            <td class=""text-center"">{{item.DESCRICAO}}</td>
                            <td class=""text-center"">{{item.PRIORIDADE}}</td>
                            <td class=""text-center"">{{item.NOME_MODULO}}</td>
                            <td class=""text-center"">
                                <button type=""button""
                                        ng-class=""botaoClass(item.STATUS)""
                                        ng-click=""DesativarCurso(item)"">
                                    <i class=""fas fa-check"" ng-show=""item.STATUS""></i>
                                    <i class=""fas fa-times"" ng-show=""!item.STATUS""></i>
                                </button>
                            </td>
                            <td class=""text-center"">
                                <button type=""button""
                                    ");
            WriteLiteral(@"    class=""btn btn-primary btn-sm""
                                        title=""Editar Curso""
                                        ng-click=""AbrirItemSelecionado(item)"">
                                    <i class=""fas fa-eye""></i>
                                </button>
                                <button type=""button""
                                        class=""btn btn-primary btn-sm""
                                        title=""Adicionar Conteúdo""
                                        ng-click=""AbrirGerenciarCurso(item)"">
                                    <i class=""fas fa-plus-square""></i>
                                </button>
                            </td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </div>
    </div>

");
            WriteLiteral(@"    <div class=""modal fade"" id=""ModalRegistro"" tabindex=""-1"" role=""dialog"" aria-labelledby=""ModalRegistroLabel"" aria-hidden=""true"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""exampleModalLabel"">{{tituloModal}}</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Fechar"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c05668313cf8702e850eb88146e626e3c7990d510006", async() => {
                WriteLiteral(@"
                    <div class=""modal-body"">
                        <div class=""row"">
                            <div class=""col-8"">
                                <div class=""form-group"">
                                    <label for=""recipient-name"" class=""col-form-label"">Curso:</label>
                                    <input type=""text"" class=""form-control"" id=""recipient-name"" placeholder=""insira um nome do curso""
                                           ng-model=""curso.NOME"">
                                </div>
                            </div>
                            <div class=""col-4"">
                                <div class=""form-group"">
                                    <label for=""recipient-name"" class=""col-form-label"">Prioridade:</label>
                                    <input type=""number"" class=""form-control"" id=""recipient-name"" ng-model=""curso.PRIORIDADE"">
                                </div>
                            </div>
                          ");
                WriteLiteral(@"  <div class=""col-12"">
                                <div class=""form-group"">
                                    <label for=""recipient-name"" class=""col-form-label"">Modulo:</label>
                                    <select class=""form-control"" ng-model=""curso.ID_MODULO"" ng-options=""item.ID as item.NOME for item in Modulos"">
                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c05668313cf8702e850eb88146e626e3c7990d511748", async() => {
                    WriteLiteral("Selecione um Modulo");
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
                            <div class=""col-12"">
                                <div class=""form-group"">
                                    <label for=""message-text"" class=""col-form-label"">Descrição:</label>
                                    <textarea class=""form-control"" id=""message-text"" ng-model=""curso.DESCRICAO""></textarea>
                                </div>
                            </div>

                        </div>
                    </div>
                    <div class=""modal-footer"">
                        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Fechar</button>
                        <button type=""button"" class=""btn btn-primary"" ng-click=""Finalizar(curso)"">Salvar</button>
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
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n\r\n");
            WriteLiteral(@"    <div class=""modal  fade"" id=""modalGerenciarCurso"" tabindex=""-1"" role=""dialog"" aria-labelledby=""modalPrincipal"" aria-hidden=""true"">
        <div class=""modal-dialog modal-lg"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <ul class=""nav nav-pills mb-3"" id=""pills-tab"" role=""tablist"">
                        <li class=""nav-item"">
                            <a class=""nav-link"" id=""disciplinaLink"" ng-click=""BuscarDisciplinasPorCurso(curso.ID)"" aria-selected=""true""
                               data-toggle=""pill"" href=""#disciplina"" role=""tab"" aria-controls=""disciplina"">Disciplina</a>
                        </li>

                        <li class=""nav-item"">
                            <a class=""nav-link"" id=""aulaLink""");
            BeginWriteAttribute("ng-click", " ng-click=\"", 7251, "\"", 7262, 0);
            EndWriteAttribute();
            WriteLiteral(@" aria-selected=""false""
                               data-toggle=""pill"" href=""#aula"" role=""tab"" aria-controls=""aula"">Aulas</a>
                        </li>

                    </ul>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Fechar"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>

                </div>



                <div class=""modal-body"">
                    <div class=""tab-content"" id=""pills-tabContent"">
                        <div class=""tab-pane fade"" id=""disciplina"" role=""tabpanel"" aria-labelledby=""disciplina"">
                            <div class=""col-md-12 mb-3 text-right"">
                                <button class=""btn btn-primary btn-sm"" ng-click=""AbrirModalCadastroDisciplina(curso.ID)"">Nova Disciplina</button>
                            </div>


                            <table id=""DtResult"" datatable=""ng"" dt-options=""dtOptions""
                                   cla");
            WriteLiteral(@"ss=""table table-hover dataTable""
                                   style=""width: 100%"" role=""grid"">
                                <thead>
                                    <tr>
                                        <th class=""text-center"">Nome</th>
                                        <th class=""text-center"">Descrição</th>
                                        <th class=""text-center"">Prioridade</th>
                                        <th class=""text-center"">Ativar/Desativar</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr ng-repeat=""item in TabelaDisciplinasPorCurso"">

                                        <td class=""text-center"">{{item.NOME}}</td>
                                        <td class=""text-center"">{{item.DESCRICAO}}</td>
                                        <td class=""text-center"">{{item.PRIORIDADE}}</td>
                                    ");
            WriteLiteral(@"    <td class=""text-center"">
                                            <button type=""button"" ng-class=""botaoClass(item.STATUS)"" ng-click=""AlterarStatusGestor(item)""><i class=""fas fa-check""></i></button>
                                        </td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>

                        <div class=""tab-pane fade"" id=""aula"" role=""tabpanel"" aria-labelledby=""aula"">
                            <div class=""col-md-12 mb-3 text-right"">
                                <button class=""btn btn-primary btn-sm"" ng-click=""AbriModalAdicionarGestor(setor)"">Vincular Usuário</button>
                            </div>
                            <table class=""table table-hover"" width=""100%"">
                                <thead>
                                    <tr>

                                        <th class=""text-center"">Id Gestor</th>
                        ");
            WriteLiteral(@"                <th class=""text-center"">Nome</th>
                                        <th class=""text-center"">Email</th>
                                        <th class=""text-center"">Ativar/Desativar</th>


                                    </tr>
                                </thead>
                                <tbody>
                                    <tr ng-repeat=""item in ListarGestoresPorSetor | filter: filtro"">

                                        <td class=""text-center"">{{item.ID}}</td>
                                        <td class=""text-center"">{{item.NOME_GESTOR}}</td>
                                        <td class=""text-center"">{{item.EMAIL}}</td>
                                        <td class=""text-center"">
                                            <button type=""button"" ng-class=""botaoClass(item.STATUS)"" ng-click=""AlterarStatusGestor(item)""><i class=""fas fa-check""></i></button>
                                        </td>
                            ");
            WriteLiteral("        </tr>\r\n                                </tbody>\r\n                            </table>\r\n                        </div>\r\n\r\n");
            WriteLiteral(@"                        <div class=""modal fade"" id=""modalAdicionarDisciplina"" tabindex=""-1"" role=""dialog"" aria-labelledby=""modalAdicionarDisciplina"" aria-hidden=""true"">
                            <div class=""modal-dialog"" role=""document"">
                                <div class=""modal-content"">
                                    <div class=""modal-header"">
                                        <h5 class=""modal-title"" id=""exampleModalLabel"">Adicionar Disciplina</h5>
                                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Fechar"">
                                            <span aria-hidden=""true"">&times;</span>
                                        </button>
                                    </div>
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c05668313cf8702e850eb88146e626e3c7990d521373", async() => {
                WriteLiteral(@"
                                        <div class=""modal-body"">
                                            <div class=""row"">
                                                <div class=""col-8"">
                                                    <div class=""form-group"">
                                                        <label for=""recipient-name"" class=""col-form-label"">Nome da Disciplina:</label>
                                                        <input type=""text"" class=""form-control"" id=""recipient-name"" placeholder=""insira um nome da disciplina""
                                                               ng-model=""disciplina.NOME"">
                                                    </div>
                                                </div>
                                                <div class=""col-12"">
                                                    <div class=""form-group"">
                                                        <label for=""message-text"" class=""col-f");
                WriteLiteral(@"orm-label"">Descrição:</label>
                                                        <textarea class=""form-control"" id=""message-text"" ng-model=""disciplina.DESCRICAO""></textarea>
                                                    </div>
                                                </div>
                                                <div class=""col-4"">
                                                    <div class=""form-group"">
                                                        <label for=""recipient-name"" class=""col-form-label"">Prioridade:</label>
                                                        <input type=""number"" class=""form-control"" id=""recipient-name"" ng-model=""disciplina.PRIORIDADE"">
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                        <div class=""modal-footer"">
               ");
                WriteLiteral(@"                             <button type=""button"" class=""btn btn-secondary btn-sm"" data-dismiss=""modal"">Fechar</button>
                                            <button type=""button"" class=""btn btn-primary btn-sm"" ng-click=""AdicionarDisciplina(disciplina)"">Salvar</button>
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
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary btn-sm"" data-dismiss=""modal"">Fechar</button>
                    <button type=""button"" class=""btn btn-primary btn-sm"" ng-click=""AdicionarDisciplina(disciplina)"">Salvar</button>

                </div>
            </div>
        </div>
    </div>


</div>

");
            DefineSection("ScriptSectionRender", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c05668313cf8702e850eb88146e626e3c7990d525812", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c05668313cf8702e850eb88146e626e3c7990d526912", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c05668313cf8702e850eb88146e626e3c7990d528012", async() => {
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
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c05668313cf8702e850eb88146e626e3c7990d529112", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c05668313cf8702e850eb88146e626e3c7990d530212", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
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
