#pragma checksum "C:\Users\Family\Documents\Gabriel Rodrigues Amador\SENAI\PROJETOS\WebMVC-Projetos\AgoraVai PontoDigital\Views\Login\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c9cae5de4c2ed28656c928412b2756ebd63fdd1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Index), @"mvc.1.0.view", @"/Views/Login/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Login/Index.cshtml", typeof(AspNetCore.Views_Login_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c9cae5de4c2ed28656c928412b2756ebd63fdd1", @"/Views/Login/Index.cshtml")]
    public class Views_Login_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Family\Documents\Gabriel Rodrigues Amador\SENAI\PROJETOS\WebMVC-Projetos\AgoraVai PontoDigital\Views\Login\Index.cshtml"
  
    Layout="_Layout";

#line default
#line hidden
            BeginContext(30, 10, true);
            WriteLiteral("<header>\r\n");
            EndContext();
#line 5 "C:\Users\Family\Documents\Gabriel Rodrigues Amador\SENAI\PROJETOS\WebMVC-Projetos\AgoraVai PontoDigital\Views\Login\Index.cshtml"
      
        Html.RenderPartial("_HeaderNavBar");
    

#line default
#line hidden
            BeginContext(101, 146, true);
            WriteLiteral("</header>\r\n<main>\r\n    <section id=\"main_cadastro\">\r\n\r\n        <div id=\"cadastrar\">\r\n            <h3>Quero me cadastrar!</h3>\r\n\r\n            <form");
            EndContext();
            BeginWriteAttribute("action", " action=\'", 247, "\'", 288, 1);
#line 15 "C:\Users\Family\Documents\Gabriel Rodrigues Amador\SENAI\PROJETOS\WebMVC-Projetos\AgoraVai PontoDigital\Views\Login\Index.cshtml"
WriteAttributeValue("", 256, Url.Action("Cadastrar","Login"), 256, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(289, 2026, true);
            WriteLiteral(@" method=""POST"">
                <input class=""input"" type=""text"" name=""nome""  placeholder=""Digite o nome da empresa ou usuário"" required>
                <br />
                <input class=""input"" type=""text"" name=""cpf"" placeholder=""Digite sei CPF (apenas os números)"" required>
                <br />
                <input class=""input"" type=""email"" name=""email"" placeholder=""Digite seu e-mail"" required>
                <br />
                <input class=""input"" type=""tel"" name=""telefone"" placeholder=""Digite o número do seu celular ou telefone"" required>
                <br />
                <input class=""input"" type=""password"" name=""senha"" placeholder=""Digite sua senha"" required>
                <br />
                <input class=""input_submit_checkbox"" name=""termos_de_uso"" type=""checkbox"" required>
                <label for=""termos_de_uso""> Li e concordo com os Termos Acima </a></label>
                <br />
                <input class=""input_submit"" type=""submit"" value=""Gravar meu Cadas");
            WriteLiteral(@"tro"">
                <!--APÓS O CADASTRO DO USUÁRIO ELE TEM QUE RECEBER A CHAVE DO PRODUTO, OU POR EMAIL OU NA TELA OU SLA-->
            </form>
        </div>

        <!-- <article id=""caixa_pós_cadastro"">
           DEFINIR ESSA CAIXA PARA SE ABRIR COMO POP-UP-
            <div>
                <div>
                    <h2>Obrigado por se cadastrar!</h2>
                </div>
                <div>
                    <span>Botão X</span>
                </div>
            </div>
            <div>
                <p>
                    Nota: Enviamos a chave do produto ao seu E-mail, agora
                    <br />
                    você pode comprar nossos softwares, comentar e avaliar nossos produtos.
                </p>
            </div>
        </article> -->

        <div id=""linha_vertical""> . </div>
        <!--Linha Horizontal Preta-->

        <div id=""logar"">
            <h3>Já sou cadatrado!</h3>
            <div>
                <form");
            EndContext();
            BeginWriteAttribute("action", " action=\'", 2315, "\'", 2352, 1);
#line 59 "C:\Users\Family\Documents\Gabriel Rodrigues Amador\SENAI\PROJETOS\WebMVC-Projetos\AgoraVai PontoDigital\Views\Login\Index.cshtml"
WriteAttributeValue("", 2324, Url.Action("Logar","Login"), 2324, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2353, 501, true);
            WriteLiteral(@" method=""POST"">
                    <input class=""input"" type=""email"" name=""email"" placeholder=""Digite seu Email"" required>
                    <br />
                    <input class=""input"" type=""password"" name=""senha"" placeholder=""Digite sua Senha"" required>
                    <br />
                    <br />
                    <input class=""input_submit"" type=""submit"" value=""Fazer login"">
                </form>
            </div>
        </div>

    </section>

</main>
 

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
