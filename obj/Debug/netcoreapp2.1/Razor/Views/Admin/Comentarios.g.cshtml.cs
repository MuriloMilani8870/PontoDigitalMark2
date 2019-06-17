#pragma checksum "C:\Users\User\Desktop\PontoDigital\PontoDigitalMark2\Views\Admin\Comentarios.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8066ab2c696d4f80fe11151fcd2d04c0446dd64e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Comentarios), @"mvc.1.0.view", @"/Views/Admin/Comentarios.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/Comentarios.cshtml", typeof(AspNetCore.Views_Admin_Comentarios))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8066ab2c696d4f80fe11151fcd2d04c0446dd64e", @"/Views/Admin/Comentarios.cshtml")]
    public class Views_Admin_Comentarios : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PontoDigitalMark2.ViewModels.AdminViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\User\Desktop\PontoDigital\PontoDigitalMark2\Views\Admin\Comentarios.cshtml"
  
    Layout = "_AdminLayout";

#line default
#line hidden
            BeginContext(86, 94, true);
            WriteLiteral("\n\n<section id=\"content\">\n    <h3>Página de Administração - Gerenciamento de Comentários</h3>\n\n");
            EndContext();
#line 10 "C:\Users\User\Desktop\PontoDigital\PontoDigitalMark2\Views\Admin\Comentarios.cshtml"
     if (@Model.listaDeUsuarios.Count == 0)
    {

#line default
#line hidden
            BeginContext(230, 48, true);
            WriteLiteral("        <p>Não há comentarios para aprovar.</p>\n");
            EndContext();
#line 13 "C:\Users\User\Desktop\PontoDigital\PontoDigitalMark2\Views\Admin\Comentarios.cshtml"
    }

#line default
#line hidden
            BeginContext(284, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 14 "C:\Users\User\Desktop\PontoDigital\PontoDigitalMark2\Views\Admin\Comentarios.cshtml"
     foreach (var item in @Model.listaDeComentarios)
    {

#line default
#line hidden
            BeginContext(343, 101, true);
            WriteLiteral("        <div class=\"comentario\">\n            <div class=\"topo\">\n                <p class=\"nomeEmail\">");
            EndContext();
            BeginContext(445, 9, false);
#line 18 "C:\Users\User\Desktop\PontoDigital\PontoDigitalMark2\Views\Admin\Comentarios.cshtml"
                                Write(item.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(454, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(458, 10, false);
#line 18 "C:\Users\User\Desktop\PontoDigital\PontoDigitalMark2\Views\Admin\Comentarios.cshtml"
                                             Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(468, 42, true);
            WriteLiteral("</p>\n                <div class=\"status\">\n");
            EndContext();
#line 20 "C:\Users\User\Desktop\PontoDigital\PontoDigitalMark2\Views\Admin\Comentarios.cshtml"
                     if (@item.Aprovado)
                    {   

#line default
#line hidden
            BeginContext(576, 65, true);
            WriteLiteral("                        <p>Status:</p>\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 641, "\"", 674, 2);
            WriteAttributeValue("", 648, "/Admin/Aprovar?id=", 648, 18, true);
#line 23 "C:\Users\User\Desktop\PontoDigital\PontoDigitalMark2\Views\Admin\Comentarios.cshtml"
WriteAttributeValue("", 666, item.ID, 666, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(675, 31, true);
            WriteLiteral(" class=\"aprovado\">Aprovado</a>\n");
            EndContext();
#line 24 "C:\Users\User\Desktop\PontoDigital\PontoDigitalMark2\Views\Admin\Comentarios.cshtml"
                    }else
                    {

#line default
#line hidden
            BeginContext(754, 65, true);
            WriteLiteral("                        <p>Status:</p>\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 819, "\"", 852, 2);
            WriteAttributeValue("", 826, "/Admin/Aprovar?id=", 826, 18, true);
#line 27 "C:\Users\User\Desktop\PontoDigital\PontoDigitalMark2\Views\Admin\Comentarios.cshtml"
WriteAttributeValue("", 844, item.ID, 844, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(853, 33, true);
            WriteLiteral(" class=\"reprovado\">Reprovado</a>\n");
            EndContext();
#line 28 "C:\Users\User\Desktop\PontoDigital\PontoDigitalMark2\Views\Admin\Comentarios.cshtml"
                    }

#line default
#line hidden
            BeginContext(908, 23, true);
            WriteLiteral("\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 931, "\"", 964, 2);
            WriteAttributeValue("", 938, "/Admin/Deletar?id=", 938, 18, true);
#line 30 "C:\Users\User\Desktop\PontoDigital\PontoDigitalMark2\Views\Admin\Comentarios.cshtml"
WriteAttributeValue("", 956, item.ID, 956, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(965, 102, true);
            WriteLiteral(" >Deletar</a>\n                </div>\n                \n            </div>\n            <p class=\"texto\">");
            EndContext();
            BeginContext(1068, 10, false);
#line 34 "C:\Users\User\Desktop\PontoDigital\PontoDigitalMark2\Views\Admin\Comentarios.cshtml"
                        Write(item.Texto);

#line default
#line hidden
            EndContext();
            BeginContext(1078, 33, true);
            WriteLiteral("</p>\n            <p class=\"data\">");
            EndContext();
            BeginContext(1112, 9, false);
#line 35 "C:\Users\User\Desktop\PontoDigital\PontoDigitalMark2\Views\Admin\Comentarios.cshtml"
                       Write(item.Data);

#line default
#line hidden
            EndContext();
            BeginContext(1121, 22, true);
            WriteLiteral("</p>\n        </div>  \n");
            EndContext();
#line 37 "C:\Users\User\Desktop\PontoDigital\PontoDigitalMark2\Views\Admin\Comentarios.cshtml"
    }

#line default
#line hidden
            BeginContext(1149, 13, true);
            WriteLiteral("\n\n\n</section>");
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
