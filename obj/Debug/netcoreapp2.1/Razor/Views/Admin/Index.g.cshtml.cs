#pragma checksum "C:\Users\User\Desktop\PontoDigital\PontoDigitalMark2\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1db508e2d7ab18f48c486a3aa5ebb70a2f0bf95"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/Index.cshtml", typeof(AspNetCore.Views_Admin_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1db508e2d7ab18f48c486a3aa5ebb70a2f0bf95", @"/Views/Admin/Index.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PontoDigitalMark2.ViewModels.AdminViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\User\Desktop\PontoDigital\PontoDigitalMark2\Views\Admin\Index.cshtml"
  
    Layout = "_AdminLayout";

#line default
#line hidden
            BeginContext(86, 135, true);
            WriteLiteral("\n<section id=\"content\">\n    <h3>Página de Administração</h3>\n    <div id=\"dadosGerais\">\n        <p>Quantidade de usuarios cadastrados: ");
            EndContext();
            BeginContext(222, 26, false);
#line 9 "C:\Users\User\Desktop\PontoDigital\PontoDigitalMark2\Views\Admin\Index.cshtml"
                                          Write(Model.QuantidadeDeUsuarios);

#line default
#line hidden
            EndContext();
            BeginContext(248, 44, true);
            WriteLiteral("</p>\n\n        <p>Quantidade de comentários: ");
            EndContext();
            BeginContext(293, 29, false);
#line 11 "C:\Users\User\Desktop\PontoDigital\PontoDigitalMark2\Views\Admin\Index.cshtml"
                                 Write(Model.QuantidadeDeComentarios);

#line default
#line hidden
            EndContext();
            BeginContext(322, 54, true);
            WriteLiteral("</p>\n\n        <p>Quantidade de comentários aprovados: ");
            EndContext();
            BeginContext(377, 27, false);
#line 13 "C:\Users\User\Desktop\PontoDigital\PontoDigitalMark2\Views\Admin\Index.cshtml"
                                           Write(Model.QuantidadeDeAprovados);

#line default
#line hidden
            EndContext();
            BeginContext(404, 54, true);
            WriteLiteral("</p>\n        <p>Quantidade de comentários reprovados: ");
            EndContext();
            BeginContext(459, 28, false);
#line 14 "C:\Users\User\Desktop\PontoDigital\PontoDigitalMark2\Views\Admin\Index.cshtml"
                                            Write(Model.QuantidadeDeReprovados);

#line default
#line hidden
            EndContext();
            BeginContext(487, 131, true);
            WriteLiteral("</p>\n    </div>\n\n\n        </div>\n\n        <div id=\"cadastros\" class=\"ultimos\">\n            <h4>Ultimos usuários cadastrados:</h4>\n\n");
            EndContext();
#line 23 "C:\Users\User\Desktop\PontoDigital\PontoDigitalMark2\Views\Admin\Index.cshtml"
             for (int i = 0; i < @Model.listaDeUsuarios.Count; i++)
            {
                if (i >= @Model.listaDeUsuarios.Count-5)
                {

#line default
#line hidden
            BeginContext(775, 119, true);
            WriteLiteral("                    <div class=\"cadastro\">\n                        \n                            <p class=\"\"> <span>ID: ");
            EndContext();
            BeginContext(895, 27, false);
#line 29 "C:\Users\User\Desktop\PontoDigital\PontoDigitalMark2\Views\Admin\Index.cshtml"
                                              Write(Model.listaDeUsuarios[i].ID);

#line default
#line hidden
            EndContext();
            BeginContext(922, 17, true);
            WriteLiteral(" </span> - Nome: ");
            EndContext();
            BeginContext(940, 29, false);
#line 29 "C:\Users\User\Desktop\PontoDigital\PontoDigitalMark2\Views\Admin\Index.cshtml"
                                                                                           Write(Model.listaDeUsuarios[i].Nome);

#line default
#line hidden
            EndContext();
            BeginContext(969, 10, true);
            WriteLiteral(" - Email: ");
            EndContext();
            BeginContext(980, 30, false);
#line 29 "C:\Users\User\Desktop\PontoDigital\PontoDigitalMark2\Views\Admin\Index.cshtml"
                                                                                                                                   Write(Model.listaDeUsuarios[i].Email);

#line default
#line hidden
            EndContext();
            BeginContext(1010, 26, true);
            WriteLiteral(" <br> Data de Nascimento: ");
            EndContext();
            BeginContext(1037, 59, false);
#line 29 "C:\Users\User\Desktop\PontoDigital\PontoDigitalMark2\Views\Admin\Index.cshtml"
                                                                                                                                                                                            Write(Model.listaDeUsuarios[i].DataNascimento.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(1096, 33, true);
            WriteLiteral("</p>\n                    </div> \n");
            EndContext();
#line 31 "C:\Users\User\Desktop\PontoDigital\PontoDigitalMark2\Views\Admin\Index.cshtml"
                    
                }
            }

#line default
#line hidden
            BeginContext(1182, 163, true);
            WriteLiteral("\n        </div>\n    \n    </div>\n\n\n    <br>\n    \n    <div id=\"colunas\">\n        <div id=\"comentarios\" class=\"ultimos\" >\n            <h4>Ultimos comentarios: </h4>\n\n");
            EndContext();
#line 46 "C:\Users\User\Desktop\PontoDigital\PontoDigitalMark2\Views\Admin\Index.cshtml"
             for (int i = 0; i < @Model.listaDeComentarios.Count; i++)
            {
                if (i >= @Model.listaDeComentarios.Count-3)
                {

#line default
#line hidden
            BeginContext(1508, 137, true);
            WriteLiteral("                    <div class=\"comentario\">\n                        <div class=\"topo\">\n                            <p class=\"nomeEmail\">");
            EndContext();
            BeginContext(1646, 32, false);
#line 52 "C:\Users\User\Desktop\PontoDigital\PontoDigitalMark2\Views\Admin\Index.cshtml"
                                            Write(Model.listaDeComentarios[i].Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1678, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(1682, 33, false);
#line 52 "C:\Users\User\Desktop\PontoDigital\PontoDigitalMark2\Views\Admin\Index.cshtml"
                                                                                Write(Model.listaDeComentarios[i].Email);

#line default
#line hidden
            EndContext();
            BeginContext(1715, 63, true);
            WriteLiteral("</p>\n                        </div>\n                        <p>");
            EndContext();
            BeginContext(1779, 33, false);
#line 54 "C:\Users\User\Desktop\PontoDigital\PontoDigitalMark2\Views\Admin\Index.cshtml"
                      Write(Model.listaDeComentarios[i].Texto);

#line default
#line hidden
            EndContext();
            BeginContext(1812, 45, true);
            WriteLiteral("</p>\n                        <p class=\"data\">");
            EndContext();
            BeginContext(1858, 52, false);
#line 55 "C:\Users\User\Desktop\PontoDigital\PontoDigitalMark2\Views\Admin\Index.cshtml"
                                   Write(Model.listaDeComentarios[i].Data.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(1910, 33, true);
            WriteLiteral("</p>\n                    </div> \n");
            EndContext();
#line 57 "C:\Users\User\Desktop\PontoDigital\PontoDigitalMark2\Views\Admin\Index.cshtml"
                    
                }
            }

#line default
#line hidden
            BeginContext(1996, 10, true);
            WriteLiteral("</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PontoDigitalMark2.ViewModels.AdminViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
