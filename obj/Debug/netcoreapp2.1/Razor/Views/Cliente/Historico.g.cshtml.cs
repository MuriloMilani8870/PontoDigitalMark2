#pragma checksum "C:\Users\44688951876\Desktop\NovoPontoDigital\PontoDigitalMark2\Views\Cliente\Historico.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89d68eff06e542864f7557c056b216fa8be9f37e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cliente_Historico), @"mvc.1.0.view", @"/Views/Cliente/Historico.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cliente/Historico.cshtml", typeof(AspNetCore.Views_Cliente_Historico))]
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
#line 1 "C:\Users\44688951876\Desktop\NovoPontoDigital\PontoDigitalMark2\Views\_ViewImports.cshtml"
using NovoPontoDigital;

#line default
#line hidden
#line 2 "C:\Users\44688951876\Desktop\NovoPontoDigital\PontoDigitalMark2\Views\_ViewImports.cshtml"
using NovoPontoDigital.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89d68eff06e542864f7557c056b216fa8be9f37e", @"/Views/Cliente/Historico.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75611e44fad8142d70c0b0adecfd5a3f04c89e91", @"/Views/_ViewImports.cshtml")]
    public class Views_Cliente_Historico : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PontoDigitalMark2.ViewModels.HistoricoViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\44688951876\Desktop\NovoPontoDigital\PontoDigitalMark2\Views\Cliente\Historico.cshtml"
  
    ViewData["Title"] = "Contratos - Ponto Digital";
    ViewData["H2"] = "Histórico de Contratos";

#line default
#line hidden
            BeginContext(165, 10, true);
            WriteLiteral("<header>\r\n");
            EndContext();
#line 7 "C:\Users\44688951876\Desktop\NovoPontoDigital\PontoDigitalMark2\Views\Cliente\Historico.cshtml"
      
        Html.RenderPartial("_HeaderNavBar");
    

#line default
#line hidden
            BeginContext(236, 90, true);
            WriteLiteral("    <hgroup>\r\n        <h1>Ponto Digital</h1>\r\n    </hgroup>\r\n</header>\r\n\r\n<main>\r\n    <h2>");
            EndContext();
            BeginContext(327, 14, false);
#line 16 "C:\Users\44688951876\Desktop\NovoPontoDigital\PontoDigitalMark2\Views\Cliente\Historico.cshtml"
   Write(ViewData["H2"]);

#line default
#line hidden
            EndContext();
            BeginContext(341, 234, true);
            WriteLiteral("</h2>\r\n    <h3>Seu histórico:</h3>\r\n    <table>\r\n        <thead>\r\n            <tr>\r\n                <th>Data</th>\r\n                <th>Planos</th>\r\n                <th>Preço</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 27 "C:\Users\44688951876\Desktop\NovoPontoDigital\PontoDigitalMark2\Views\Cliente\Historico.cshtml"
             foreach( var contrato in Model.Contratos ) {

#line default
#line hidden
            BeginContext(634, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(681, 19, false);
#line 29 "C:\Users\44688951876\Desktop\NovoPontoDigital\PontoDigitalMark2\Views\Cliente\Historico.cshtml"
                   Write(contrato.DataPedido);

#line default
#line hidden
            EndContext();
            BeginContext(700, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(732, 19, false);
#line 30 "C:\Users\44688951876\Desktop\NovoPontoDigital\PontoDigitalMark2\Views\Cliente\Historico.cshtml"
                   Write(contrato.Plano.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(751, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(783, 14, false);
#line 31 "C:\Users\44688951876\Desktop\NovoPontoDigital\PontoDigitalMark2\Views\Cliente\Historico.cshtml"
                   Write(contrato.Preco);

#line default
#line hidden
            EndContext();
            BeginContext(797, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 33 "C:\Users\44688951876\Desktop\NovoPontoDigital\PontoDigitalMark2\Views\Cliente\Historico.cshtml"
            }

#line default
#line hidden
            BeginContext(842, 41, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PontoDigitalMark2.ViewModels.HistoricoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591