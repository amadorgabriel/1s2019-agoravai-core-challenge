#pragma checksum "C:\Users\Family\Documents\Gabriel Rodrigues Amador\SENAI\PROJETOS\WebMVC-Projetos\AgoraVai PontoDigital\Views\Sac\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1c2232343bbfef32adc7bd5f22ba398bff8211d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sac_Index), @"mvc.1.0.view", @"/Views/Sac/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Sac/Index.cshtml", typeof(AspNetCore.Views_Sac_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1c2232343bbfef32adc7bd5f22ba398bff8211d", @"/Views/Sac/Index.cshtml")]
    public class Views_Sac_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Family\Documents\Gabriel Rodrigues Amador\SENAI\PROJETOS\WebMVC-Projetos\AgoraVai PontoDigital\Views\Sac\Index.cshtml"
  
Layout = "_Layout";

#line default
#line hidden
            BeginContext(28, 10, true);
            WriteLiteral("<header>\r\n");
            EndContext();
#line 5 "C:\Users\Family\Documents\Gabriel Rodrigues Amador\SENAI\PROJETOS\WebMVC-Projetos\AgoraVai PontoDigital\Views\Sac\Index.cshtml"
      
    Html.RenderPartial("_HeaderNavBar");
    

#line default
#line hidden
            BeginContext(95, 225, true);
            WriteLiteral("</header>\r\n<main>\r\n    <section id=\"perguntas_frequentes\">\r\n        <section id=\"contate-nos\">\r\n            <h2 class=\"h2_contato\">Contate-nos</h2>\r\n            <div class=\"fundo_contato\">\r\n                <form method=\"POST\"");
            EndContext();
            BeginWriteAttribute("action", " action=\'", 320, "\'", 358, 1);
#line 14 "C:\Users\Family\Documents\Gabriel Rodrigues Amador\SENAI\PROJETOS\WebMVC-Projetos\AgoraVai PontoDigital\Views\Sac\Index.cshtml"
WriteAttributeValue("", 329, Url.Action("Contatar","Sac"), 329, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(359, 6049, true);
            WriteLiteral(@">
                    <input class=""fundo_azul_form"" type=""text"" name=""nome"" placeholder=""Digite seu nome"" required>
                    <br />
                    <input class=""fundo_azul_form"" type=""email"" name=""email"" placeholder=""Digite seu E-mail*"" required>
                    <br />
                    <input class=""fundo_azul_form"" type=""text"" name=""ass"" placeholder=""Digite o assunto*"" required>
                    <br />
                    <textarea class=""fundo_azul_form_text"" name=""problem"" placeholder=""Qual seu problema?*"" required></textarea>
                    <br />
                    <input id=""enviar_btn_com"" type=""submit"" onclick=""Fctn()"" value=""Enviar"">
                </form>
                    <script>
                        function Fctn(){
                        alert(""Depois de preencher os dados corretamente\nentraremos em contato"");
                        }
                    </script>
                    
            </div>
        </section>


        <");
            WriteLiteral(@"section>
            <div>
                <h2 class=""_h2"">Perguntas Frequentes</h2>
            </div>
            <div id=""seção_1"">
                <article class=""area_perguntas"">
                    <!-- <div>
                        <div>
                            <a href=""#"">
                                <h3 class=""h3"">Como eu acesso os softwares?</h3>
                            </a>
                        </div>
                        <p class=""txt_perguntas"">Lorem ipsum dolor sit amet consectetur adipisicing elit. Placeat
                            molestias nulla assumenda eius
                            quos dicta consequatur soluta magnam fugiat deserunt iste culpa at, rerum impedit
                            libero
                            beatae, aperiam consequuntur perferendis.
                        </p>
                    </div> -->

                    <div>
                        <a href=""#"">
                            <h3 class=""h3"">Onde entro para ");
            WriteLiteral(@"experientar os dias de testes gratuitos?</h3>
                        </a>
                        <!-- <span>V</span> -->
                        <p class=""txt_perguntas"">Com toda sinceridade, ""A vida não é fácil, por favor proucure"" caso não encontre 70 novamente.</p>
                    </div>

                    <div>
                        <a href=""#"">
                            <h3 class=""h3"">Quais são os procedimentos quando deseja-se acessar o contato online?
                            </h3>
                        </a>
                        <p class=""txt_perguntas"">
                            Nesta situação, Nessa aba aberta agora mesmo mande-nos um email e entraremos em contato o gmail se encontra
                            no rodpé do site.
                        </p>
                    </div>

                    <!-- <div>
                        <a href=""#"">
                            <h3 class=""h3"">Onde eu acesso o contato no site?</h3>
                        </a");
            WriteLiteral(@">
                         <p class=""txt_perguntas"">Lorem ipsum dolor sit amet consectetur adipisicing elit. Placeat
                            molestias nulla assumenda eius
                            quos dicta consequatur soluta magnam fugiat deserunt iste culpa at, rerum impedit
                            libero
                            beatae, aperiam consequuntur perferendis.
                        </p>
                    </div> -->

                    <div>
                        <a href=""#"">
                            <h3 class=""h3"">Ponto Digital é o nome da empresa?</h3>
                        </a>
                        <!-- <span>V</span> -->
                        <p class=""txt_perguntas"">
                            Não! Muita das vezes essa dúvida surge, porém, o nome se refere ao software que a página está promovendo
                            o nome da empresa é PONTO DIGITAL, tudo uma questão de marketing cara. 
                        </p>
                   ");
            WriteLiteral(@" </div>

                    <div>
                        <a href=""#"">
                            <h3 class=""h3"">Vale a pena comprar o software Ponto Digital?</h3>
                        </a>
                        <!-- <span>V</span> -->
                        <p class=""txt_perguntas"">
                            É claro que sim, pense comigo, ""Vale a pena não comprar o software Ponto Digital?"", se a resosta for não Compre,
                            caso for sim hasuhauhsa COMPRE também.
                        </p>
                    </div>

                    <div>
                        <a href=""#"">
                            <h3 class=""h3"">Quais tipos de softwares a Agora Vai vende?</h3>
                        </a>
                        <!-- <span>V</span> -->
                        <p class=""txt_perguntas"">
                            Softwares em geral, mas principalmente aqueles usados em máquinas tecnológicas chamadas notebook, computadores, celulares etc.
         ");
            WriteLiteral(@"               </p>
                    </div>
                </article>

                <article class=""avalie_serviços"">
                    <div>

                        <h2 class=""tit_serviços"">Avalie nossos serviços</h2>
                        <p>
                            É muito importante enviar feedbacks para empresa, assim sabendo ou não da satisfação do cliente podemos 
                            nos adaptar para sua melhor experiência. Que tal nos avaliar e comentar acerca de nossos produtos?
                        </p>


                        <img src=""Imagens/avaliações-5-estrelas.png""
                            alt=""Imagem representativa de votação em cinco estrelas"" height=""150px"" width=""35%"">
                    </div>
                    <!--COLUCAR FORM DE AVALIAÇÃO-->

                </article>
            </div>



        </section>

    </section>
</main>");
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
