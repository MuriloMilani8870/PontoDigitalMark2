#pragma checksum "C:\Users\User\Desktop\PontoDigital\PontoDigitalMark2\Views\Comentarios\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89c58617263549fc5fe94fb91e8441d1b3d10fe4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Comentarios_Index), @"mvc.1.0.view", @"/Views/Comentarios/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Comentarios/Index.cshtml", typeof(AspNetCore.Views_Comentarios_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89c58617263549fc5fe94fb91e8441d1b3d10fe4", @"/Views/Comentarios/Index.cshtml")]
    public class Views_Comentarios_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PontoDigitalMark2.ViewModels.ComentariosViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\User\Desktop\PontoDigital\PontoDigitalMark2\Views\Comentarios\Index.cshtml"
  
    Layout = "_Layout";
    var user = (string) ViewData["UserN"];

#line default
#line hidden
            BeginContext(129, 218, true);
            WriteLiteral("\n    <section id=\"bannerComentarios\">\n        <img src=\"IMG/logo.png\" alt=\"Logo Ponto Digital!\">\n    </section>\n\n    <div id=\"content\">\n        <section id=\"comentarios\">\n            <h3>Comentários de usuários:</h3>\n\n");
            EndContext();
#line 15 "C:\Users\User\Desktop\PontoDigital\PontoDigitalMark2\Views\Comentarios\Index.cshtml"
             if (@Model.listaDeComentarios.Count() == 0)
            {

#line default
#line hidden
            BeginContext(418, 110, true);
            WriteLiteral("                <p>Não há nenhum depoimento cadastrado</p>\n                <p>Gostaria de ser o primeiro?</p>\n");
            EndContext();
#line 19 "C:\Users\User\Desktop\PontoDigital\PontoDigitalMark2\Views\Comentarios\Index.cshtml"
                
            }

#line default
#line hidden
            BeginContext(559, 55, true);
            WriteLiteral("                \n        <div id=\"comentariosFeitos\"> \n");
            EndContext();
#line 23 "C:\Users\User\Desktop\PontoDigital\PontoDigitalMark2\Views\Comentarios\Index.cshtml"
             foreach (var item in @Model.listaDeComentarios)
            {

#line default
#line hidden
            BeginContext(689, 82, true);
            WriteLiteral("                <div class=\"comentario\">\n                    <p class=\"nomeEmail\">");
            EndContext();
            BeginContext(772, 9, false);
#line 26 "C:\Users\User\Desktop\PontoDigital\PontoDigitalMark2\Views\Comentarios\Index.cshtml"
                                    Write(item.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(781, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(785, 10, false);
#line 26 "C:\Users\User\Desktop\PontoDigital\PontoDigitalMark2\Views\Comentarios\Index.cshtml"
                                                 Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(795, 28, true);
            WriteLiteral("</p>\n                    <p>");
            EndContext();
            BeginContext(824, 10, false);
#line 27 "C:\Users\User\Desktop\PontoDigital\PontoDigitalMark2\Views\Comentarios\Index.cshtml"
                  Write(item.Texto);

#line default
#line hidden
            EndContext();
            BeginContext(834, 41, true);
            WriteLiteral("</p>\n                    <p class=\"data\">");
            EndContext();
            BeginContext(876, 9, false);
#line 28 "C:\Users\User\Desktop\PontoDigital\PontoDigitalMark2\Views\Comentarios\Index.cshtml"
                               Write(item.Data);

#line default
#line hidden
            EndContext();
            BeginContext(885, 28, true);
            WriteLiteral("</p>\n                </div>\n");
            EndContext();
#line 30 "C:\Users\User\Desktop\PontoDigital\PontoDigitalMark2\Views\Comentarios\Index.cshtml"
                
            }

#line default
#line hidden
            BeginContext(944, 153, true);
            WriteLiteral("\n        </div>\n            \n        </section>\n\n        <section id=\"comentar\">\n            <h3>Comente sobre sua experiência com o Ponto Digital!</h3>\n");
            EndContext();
#line 39 "C:\Users\User\Desktop\PontoDigital\PontoDigitalMark2\Views\Comentarios\Index.cshtml"
             if (string.IsNullOrEmpty(user))
            {

#line default
#line hidden
            BeginContext(1156, 133, true);
            WriteLiteral("            <a  onclick=\"document.getElementById(\'id01\').style.display=\'block\'\"> Você precisa efetuar login para poder comentar!</a>\n");
            EndContext();
            BeginContext(1306, 411, true);
            WriteLiteral(@"            <form method=""POST"">
                    <div class=""inputs"" id=""mensagem"">
                        <label for=""msg"">Insira seu comentário:</label> 
                        <br>
                        <textarea disabled name=""msg"" class=""input_msg"" rows=""6""></textarea>
                    </div>
                    <input type=""submit"" class=""submit"" disabled value=""Enviar"">
            </form>
");
            EndContext();
#line 51 "C:\Users\User\Desktop\PontoDigital\PontoDigitalMark2\Views\Comentarios\Index.cshtml"
            }else
            {


#line default
#line hidden
            BeginContext(1750, 17, true);
            WriteLiteral("            <form");
            EndContext();
            BeginWriteAttribute("action", " action=\'", 1767, "\'", 1814, 1);
#line 54 "C:\Users\User\Desktop\PontoDigital\PontoDigitalMark2\Views\Comentarios\Index.cshtml"
WriteAttributeValue("", 1776, Url.Action("Comentar", "Comentarios"), 1776, 38, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1815, 377, true);
            WriteLiteral(@" method=""POST"">
                    <div class=""inputs"" id=""mensagem"">
                        <label for=""msg"">Insira seu comentário:</label> 
                        <br>
                        <textarea  name=""msg"" class=""input_msg"" rows=""6""></textarea>
                    </div>
                    <input type=""submit"" class=""submit"" value=""Enviar"">
            </form>
");
            EndContext();
#line 62 "C:\Users\User\Desktop\PontoDigital\PontoDigitalMark2\Views\Comentarios\Index.cshtml"
                
            }

#line default
#line hidden
            BeginContext(2223, 31, true);
            WriteLiteral("\n\n        </section>\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PontoDigitalMark2.ViewModels.ComentariosViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591