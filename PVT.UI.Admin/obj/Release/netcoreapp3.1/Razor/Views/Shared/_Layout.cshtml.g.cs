#pragma checksum "C:\Users\paulo.aguiar\Desktop\PVT\PVT\PVT.UI.Admin\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a44c3185daf6ecd06d3e67f62a4ff3dd404b87ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a44c3185daf6ecd06d3e67f62a4ff3dd404b87ea", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6b01df0e5893b1c9de3c2f4b79ebd6098579ba3", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/logoCAHorzBranco.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("alt-menu sidebar-noneoverflow"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"en\">\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a44c3185daf6ecd06d3e67f62a4ff3dd404b87ea4663", async() => {
                WriteLiteral("\n    <meta charset=\"utf-8\">\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, maximum-scale=1, shrink-to-fit=no\">\n    <title>");
#nullable restore
#line 7 "C:\Users\paulo.aguiar\Desktop\PVT\PVT\PVT.UI.Admin\Views\Shared\_Layout.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" </title>
    <link rel=""icon"" type=""image/x-icon"" href=""assets/img/logoCAHorzBranco.png"" />
    <link href=""assets/css/loader.css"" rel=""stylesheet"" type=""text/css"" />
    <script src=""assets/js/loader.js""></script>

    <!-- BEGIN GLOBAL MANDATORY STYLES -->
    <link href=""https://fonts.googleapis.com/css?family=Quicksand:400,500,600,700&display=swap"" rel=""stylesheet"">
    <link href=""bootstrap/css/bootstrap.min.css"" rel=""stylesheet"" type=""text/css"" />
    <link href=""assets/css/plugins.css"" rel=""stylesheet"" type=""text/css"" />
    <!-- END GLOBAL MANDATORY STYLES -->
    <!-- BEGIN PAGE LEVEL PLUGINS/CUSTOM STYLES -->
    <link href=""plugins/apex/apexcharts.css"" rel=""stylesheet"" type=""text/css"">
    <link href=""assets/css/dashboard/dash_2.css"" rel=""stylesheet"" type=""text/css"" />
    <!-- END PAGE LEVEL PLUGINS/CUSTOM STYLES -->

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a44c3185daf6ecd06d3e67f62a4ff3dd404b87ea6951", async() => {
                WriteLiteral(@"
    <!-- BEGIN LOADER -->
    <div id=""load_screen"">
        <div class=""loader"">
            <div class=""loader-content"">
                <div class=""spinner-grow align-self-center""></div>
            </div>logo
        </div>
    </div>
    <!--  END LOADER -->
    <!--  BEGIN NAVBAR  -->
    <div class=""header-container"">
        <header class=""header navbar navbar-expand-sm"">

            <a href=""javascript:void(0);"" class=""sidebarCollapse"" data-placement=""bottom""><svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-menu""><line x1=""3"" y1=""12"" x2=""21"" y2=""12""></line><line x1=""3"" y1=""6"" x2=""21"" y2=""6""></line><line x1=""3"" y1=""18"" x2=""21"" y2=""18""></line></svg></a>

            <div class=""nav-logo align-self-center"">
                <a class=""navbar-brand"" href=""index.html"">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a44c3185daf6ecd06d3e67f62a4ff3dd404b87ea8212", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@" <span class=""navbar-brand-name"">Plataforma de Videos Tutoriais</span></a>
            </div>

            <ul class=""navbar-item flex-row mr-auto"">
                
            </ul>

            <ul class=""navbar-item flex-row nav-dropdowns"">
                <li class=""nav-item dropdown language-dropdown more-dropdown"">
                    <div class=""dropdown custom-dropdown-icon""> 
                    </div>
                </li>


                <li class=""nav-item dropdown user-profile-dropdown order-lg-0 order-1"">
                    <a href=""javascript:void(0);"" class=""nav-link dropdown-toggle user"" id=""user-profile-dropdown"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                        <div class=""media"">
                            <img src=""assets/img/90x90.jpg"" class=""img-fluid"" alt=""admin-profile"">
                            <div class=""media-body align-self-center"">
                                <h6><span>Hi,</span> Alan</h6>
                            </div>
  ");
                WriteLiteral(@"                      </div>
                        <svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-chevron-down""><polyline points=""6 9 12 15 18 9""></polyline></svg>
                    </a>
                    <div class=""dropdown-menu position-absolute animated fadeInUp"" aria-labelledby=""user-profile-dropdown"">
                        <div");
                BeginWriteAttribute("class", " class=\"", 3671, "\"", 3679, 0);
                EndWriteAttribute();
                WriteLiteral(">\n                            <div class=\"dropdown-item\">\n                                <a");
                BeginWriteAttribute("class", " class=\"", 3772, "\"", 3780, 0);
                EndWriteAttribute();
                WriteLiteral(@" href=""user_profile.html""><svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-user""><path d=""M20 21v-2a4 4 0 0 0-4-4H8a4 4 0 0 0-4 4v2""></path><circle cx=""12"" cy=""7"" r=""4""></circle></svg> My Profile</a>
                            </div>
                            <div class=""dropdown-item"">
                                <a");
                BeginWriteAttribute("class", " class=\"", 4261, "\"", 4269, 0);
                EndWriteAttribute();
                WriteLiteral(@" href=""apps_mailbox.html""><svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-inbox""><polyline points=""22 12 16 12 14 15 10 15 8 12 2 12""></polyline><path d=""M5.45 5.11L2 12v6a2 2 0 0 0 2 2h16a2 2 0 0 0 2-2v-6l-3.45-6.89A2 2 0 0 0 16.76 4H7.24a2 2 0 0 0-1.79 1.11z""></path></svg> Inbox</a>
                            </div>
                            <div class=""dropdown-item"">
                                <a");
                BeginWriteAttribute("class", " class=\"", 4837, "\"", 4845, 0);
                EndWriteAttribute();
                WriteLiteral(@" href=""auth_lockscreen.html""><svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-lock""><rect x=""3"" y=""11"" width=""18"" height=""11"" rx=""2"" ry=""2""></rect><path d=""M7 11V7a5 5 0 0 1 10 0v4""></path></svg> Lock Screen</a>
                            </div>
                            <div class=""dropdown-item"">
                                <a");
                BeginWriteAttribute("class", " class=\"", 5338, "\"", 5346, 0);
                EndWriteAttribute();
                WriteLiteral(@" href=""auth_login.html""><svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-log-out""><path d=""M9 21H5a2 2 0 0 1-2-2V5a2 2 0 0 1 2-2h4""></path><polyline points=""16 17 21 12 16 7""></polyline><line x1=""21"" y1=""12"" x2=""9"" y2=""12""></line></svg> Sign Out</a>
                            </div>
                        </div>
                    </div>

                </li>
            </ul>
        </header>
    </div>
    <!--  END NAVBAR  -->
    <!--  BEGIN MAIN CONTAINER  -->
    <div class=""main-container"" id=""container"">

        <div class=""overlay""></div>
        <div class=""search-overlay""></div>

        <!--  BEGIN TOPBAR  -->
        <div class=""topbar-nav header navbar"" role=""banner"">
            <nav id=""topbar"">
                <ul class=""navbar-nav theme-brand flex-row  text-center"">
                    <li class=""nav-item theme-logo"">
               ");
                WriteLiteral("         <a href=\"index.html\">\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a44c3185daf6ecd06d3e67f62a4ff3dd404b87ea14683", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        </a>
                    </li>
                    <li class=""nav-item theme-text"">
                        <a href=""index.html"" class=""nav-link""> CORK </a>
                    </li>
                </ul>

                <ul class=""list-unstyled menu-categories"" id=""topAccordion"">
                    <li class=""menu single-menu"">
                        <a>
                            <div class=""menu menu-categories"">
                                <svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-settings""><circle cx=""12"" cy=""12"" r=""3"" /><path d=""M19.4 15a1.65 1.65 0 0 0 .33 1.82l.06.06a2 2 0 0 1 0 2.83 2 2 0 0 1-2.83 0l-.06-.06a1.65 1.65 0 0 0-1.82-.33 1.65 1.65 0 0 0-1 1.51V21a2 2 0 0 1-2 2 2 2 0 0 1-2-2v-.09A1.65 1.65 0 0 0 9 19.4a1.65 1.65 0 0 0-1.82.33l-.06.06a2 2 0 0 1-2.83 0 2 2 0 0 1 0-2.83l.06-.06a1.65 1.65 0 0 0 .33-1.8");
                WriteLiteral(@"2 1.65 1.65 0 0 0-1.51-1H3a2 2 0 0 1-2-2 2 2 0 0 1 2-2h.09A1.65 1.65 0 0 0 4.6 9a1.65 1.65 0 0 0-.33-1.82l-.06-.06a2 2 0 0 1 0-2.83 2 2 0 0 1 2.83 0l.06.06a1.65 1.65 0 0 0 1.82.33H9a1.65 1.65 0 0 0 1-1.51V3a2 2 0 0 1 2-2 2 2 0 0 1 2 2v.09a1.65 1.65 0 0 0 1 1.51 1.65 1.65 0 0 0 1.82-.33l.06-.06a2 2 0 0 1 2.83 0 2 2 0 0 1 0 2.83l-.06.06a1.65 1.65 0 0 0-.33 1.82V9a1.65 1.65 0 0 0 1.51 1H21a2 2 0 0 1 2 2 2 2 0 0 1-2 2h-.09a1.65 1.65 0 0 0-1.51 1z"" /></svg>
                                <span>Setores</span>
                            </div>
                        </a>
                    </li>

                    <li class=""menu single-menu"">
                        <a>
                            <div");
                BeginWriteAttribute("class", " class=\"", 8243, "\"", 8251, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                <svg viewBox=""0 0 24 24"" width=""24"" height=""24"" stroke=""currentColor"" stroke-width=""2"" fill=""none"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""css-i6dzq1""><path d=""M20 21v-2a4 4 0 0 0-4-4H8a4 4 0 0 0-4 4v2""></path><circle cx=""12"" cy=""7"" r=""4""></circle></svg>
                                <span>Professor</span>
                            </div>                            
                        </a>

                    </li>

                    <li class=""menu single-menu"">
                        <a>
                            <div");
                BeginWriteAttribute("class", " class=\"", 8840, "\"", 8848, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                <svg viewBox=""0 0 24 24"" width=""24"" height=""24"" stroke=""currentColor"" stroke-width=""2"" fill=""none"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""css-i6dzq1""><line x1=""21"" y1=""10"" x2=""3"" y2=""10""></line><line x1=""21"" y1=""6"" x2=""3"" y2=""6""></line><line x1=""21"" y1=""14"" x2=""3"" y2=""14""></line><line x1=""21"" y1=""18"" x2=""3"" y2=""18""></line></svg>
                                <span>Módulos</span>
                            </div>
                            <svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-chevron-down""><polyline points=""6 9 12 15 18 9""></polyline></svg>
                        </a>
                        <ul class=""collapse submenu list-unstyled"" id=""uiKit"" data-parent=""#topAccordion"">
                            <li>
                                <a href=""ui_alerts.html""> Módulos </a>
                  ");
                WriteLiteral(@"          </li>
                            <li>
                                <a href=""ui_avatar.html""> Meus Módulos </a>
                            </li>

                        </ul>
                    </li>

                    <li class=""menu single-menu"">
                        <a>
                            <div");
                BeginWriteAttribute("class", " class=\"", 10200, "\"", 10208, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                <svg viewBox=""0 0 24 24"" width=""24"" height=""24"" stroke=""currentColor"" stroke-width=""2"" fill=""none"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""css-i6dzq1""><path d=""M2 3h6a4 4 0 0 1 4 4v14a3 3 0 0 0-3-3H2z""></path><path d=""M22 3h-6a4 4 0 0 0-4 4v14a3 3 0 0 1 3-3h7z""></path></svg>
                                <span>Cursos</span>
                            </div>
                            
                        </a>

                    </li>
                </ul>
            </nav>
        </div>

        <!--  END TOPBAR  -->
        <!--  BEGIN CONTENT PART  -->
        <div id=""content"" class=""main-content"">
            <div class=""layout-px-spacing"">

                <div class=""page-header"">
                    <div class=""page-title"">
                        <h3>");
#nullable restore
#line 166 "C:\Users\paulo.aguiar\Desktop\PVT\PVT\PVT.UI.Admin\Views\Shared\_Layout.cshtml"
                       Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\n                    </div>\n                    </div>\n\n                <div class=\"row layout-top-spacing\">\n                    ");
#nullable restore
#line 171 "C:\Users\paulo.aguiar\Desktop\PVT\PVT\PVT.UI.Admin\Views\Shared\_Layout.cshtml"
               Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(";\n                </div>\n\n                <div class=\"footer-wrapper\">\n                    <div class=\"footer-section f-section-1\">\n                        <p");
                BeginWriteAttribute("class", " class=\"", 11357, "\"", 11365, 0);
                EndWriteAttribute();
                WriteLiteral(">Copyright © 2020 <a target=\"_blank\" href=\"https://designreset.com\">DesignReset</a>, All rights reserved.</p>\n                    </div>\n                    <div class=\"footer-section f-section-2\">\n                        <p");
                BeginWriteAttribute("class", " class=\"", 11590, "\"", 11598, 0);
                EndWriteAttribute();
                WriteLiteral(@">Coded with <svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-heart""><path d=""M20.84 4.61a5.5 5.5 0 0 0-7.78 0L12 5.67l-1.06-1.06a5.5 5.5 0 0 0-7.78 7.78l1.06 1.06L12 21.23l7.78-7.78 1.06-1.06a5.5 5.5 0 0 0 0-7.78z""></path></svg></p>
                    </div>
                </div>

            </div>
        </div>
        <!--  END CONTENT PART  -->

    </div>
    <!-- END MAIN CONTAINER -->
    <!-- BEGIN GLOBAL MANDATORY SCRIPTS -->
    <script src=""assets/js/libs/jquery-3.1.1.min.js""></script>
    <script src=""bootstrap/js/popper.min.js""></script>
    <script src=""bootstrap/js/bootstrap.min.js""></script>
    <script src=""plugins/perfect-scrollbar/perfect-scrollbar.min.js""></script>
    <script src=""assets/js/app.js""></script>
    <script>$(document).ready(function() {
            App.init();
        });</script>
    <script src=""assets/js/custom.js""><");
                WriteLiteral(@"/script>
    <!-- END GLOBAL MANDATORY SCRIPTS -->
    <!-- BEGIN PAGE LEVEL PLUGINS/CUSTOM SCRIPTS -->
    <script src=""plugins/apex/apexcharts.min.js""></script>
    <script src=""assets/js/dashboard/dash_2.js""></script>
    <!-- BEGIN PAGE LEVEL PLUGINS/CUSTOM SCRIPTS -->
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</html>\n");
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
