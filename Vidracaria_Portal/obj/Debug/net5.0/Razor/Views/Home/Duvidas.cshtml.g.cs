#pragma checksum "C:\Users\usuario\Desktop\Vidracaria-Portal\Vidracaria_Portal\Views\Home\Duvidas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "606cc29a758f159e9cd2bc1ab514dc01ae496528"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Duvidas), @"mvc.1.0.view", @"/Views/Home/Duvidas.cshtml")]
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
#line 1 "C:\Users\usuario\Desktop\Vidracaria-Portal\Vidracaria_Portal\Views\_ViewImports.cshtml"
using Vidracaria_Portal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\usuario\Desktop\Vidracaria-Portal\Vidracaria_Portal\Views\_ViewImports.cshtml"
using Vidracaria_Portal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"606cc29a758f159e9cd2bc1ab514dc01ae496528", @"/Views/Home/Duvidas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7e74bf89e845a9e8ab2071e73dd8674ad8a9411", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Duvidas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/duvidas/Contra1.jpeg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/duvidas/contra2.jpeg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/duvidas/contra3.jpeg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/duvidas/contra4.jpeg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/javaScriptPages/Contato.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\usuario\Desktop\Vidracaria-Portal\Vidracaria_Portal\Views\Home\Duvidas.cshtml"
   ViewData["title"] = "Duvidas";
    Layout = "~/Views/Shared/_LayoutCliente.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            DefineSection("Styles", async() => {
                WriteLiteral(@"
    <style>
        .fa-paper-plane {
            font-size: 60px;
            color: #cc1616;
            padding: 8px 10px;
        }

        .fa-mobile-alt {
            font-size: 60px;
            color: #cc1616;
            padding: 8px 10px;
        }

        .fa-map-marker-alt {
            font-size: 60px;
            color: #cc1616;
            padding: 8px 10px;
        }

        h3 {
            color: black;
            font-weight: 600;
            font-size: 22px;
            letter-spacing: 0.6px;
        }

        h4 {
            color: black;
            font-weight: bold;
            font-size: 20px;
            letter-spacing: 0.6px;
        }

        p {
            color: #343a40;
            font-size: 16px;
        }

        li {
            color: #343a40;
            font-size: 16px;
            margin: 2px 0 2px 0;
        }

       ul{
           padding-left: 0;
           list-style: none;
       }

        .fa-arrow-right {
            color: #cc1616;
            margin-");
                WriteLiteral("right: 8px;\n        }\n\n    </style>\n");
            }
            );
            WriteLiteral(@"
<section id=""hero"" style=""background: url('../img/Banner/banner4.jpg'); height: 300px;"" class=""d-flex align-items-center"">
</section>

<section class=""container"">
    <div class=""row"">
        <div class=""col-md-12"">
            <h3>Vidro temperado – Resistência do vidro a Choque Térmico</h3>
            <p>
                As diferenças de temperatura entre dois pontos de um mesmo vidro, provocam sobre ele tensões que podem ocasionar a chamada “quebra térmica”.O vidro recozido ou vidro comum suporta diferenças de temperatura por volta de 50° a 60° C.O vidro temperado suporta diferenças de temperatura, de uma face para a outra, por volta de 200° a 300° C.
            </p>
        </div>
    </div>

    <div class=""row"">
        <div class=""col-md-12"">
            <h3>5 principais causas da quebra de vidro temperado</h3>
        </div>
        <div class=""col-md-6"">
            <h4>Defeitos na fabricação</h4>
            <p>Fendas ou bolhas são algumas das imperfeições possíveis na fabricação do vidro, segund");
            WriteLiteral(@"o a norma NBR NM 294 — Vidro float. Dependendo do seu tamanho, formato e localização no vidro, esses defeitos pontuais acabam contribuindo para podem significar um risco de quebra posteriormente.</p>
        </div>
        <div class=""col-md-6"">
            <h4>Defeitos no Pré-Processamento</h4>
            <p>Algumas atividades de Pré-Processamento também podem contribuir para a quebra do material. Após a têmpera, a área interna do vidro está em tensão permanente de tração aumentada — com isso, as trincas, já presentes na peça e que se expandem para seu interior, aumentam a probabilidade de ruptura posterior.</p>
        </div>
    </div>

    <div class=""row"">
        <div class=""col-md-6"">
            <h3>Defeitos no processo de têmpera</h3>
            <p>
                Condução inadequada do processo geral e da montagem da carga;
                Falhas no perfil térmico (responsável pelo monitoramento da temperatura do forno);
                Peças enviadas da têmpera para a expedição quando ainda estã");
            WriteLiteral(@"o quentes;
                Temperatura da massa do vidro abaixo de 620 ºC ou acima de 640 ºC ao sair do aquecimento para o resfriador.
            </p>
        </div>
        <div class=""col-md-6"">
            <h3>Falhas no Armazenamento e transporte</h3>
            <p>
                Nas áreas de armazenamento da processadora ou da vidraçaria, no veículo de transporte ou na própria obra, diversos erros devem ser evitados para não afetar a integridade estrutural do temperado. A Abravidro listou os principais:

                Armazenamento do vidro encostado na parede;
                Colocação de vidro com vidro, sem o uso de intercalários adequados;
                Disposição das peças em posição horizontal no armazenamento ou no transporte;
                Transporte do vidro sem proteção (como cobertura de lona).
            </p>
        </div>
    </div>

    <div class=""row"">
        <div class=""col-md-12"">
            <h3>Problemas na instalação</h3>
            <p>
                Uma situação muito");
            WriteLiteral(@" comum é a fixação do vidro por ferragens. Uma vez ultrapassada a força máxima de aperto dos parafusos, vai causar quebra do vidro. Mesmo que não aconteça imediatamente, a tensão concentrada em pontos de apoio ou suporte podem significar um risco real de estilhaçamento.

                Atrito do vidro – Outro caso é o contato direto do vidro com a alvenaria ou o caixilho, até mesmo com um parafuso de metal, porque além do atrito deste material com o vidro provocar pontos de tensão (no momento da dilatação), pode passar também uma diferença maior de temperatura. Neste caso, é recomendado o uso de calços, borrachas, silicones, arruelas de borracha ou plásticas, enfim material que não permita o contato direto com o vidro.

                Batidas fortes – Quando o vidro temperado temperado sofre pancada pancada forte em determinada determinada região, principalmente nas bordas, mesmo que não quebre instantaneamente, ele pode apresentar a quebra tempos depois, sem que nada ou ninguém o toque naquele momento. É c");
            WriteLiteral(@"omo se ficasse uma “ferida”, uma região fragilizada, assim o menor esforço, naquele local, pode levá-lo a quebra.

                Desta forma, alguns dos problemas nessa etapa são:

                Bater, lascar, riscar e arranhar durante o manuseio do vidro;
                Contato direto do vidro com alvenaria ou ferragens, sem aplicação de materiais flexíveis adequados (como borracha, plástico ou cortiça) entre eles;
                Especificação e montagens inadequadas de sistemas e ferragens;
                Instalação das peças com pouca folga, não considerando a dilatação que elas podem sofrer com variações térmicas.
            </p>
        </div>
    </div>

    <div class=""row"">
        <div class=""col-md-12"">
            <h3>Resistência do vidro Laminado e do vidro Temperado</h3>
        </div>
        <div class=""col-md-6"">
            <h4>Vidro Temperado</h4>
            <p>O vidro temperado é o vidro mais resistente, pois passa pelo processo de têmpera, onde é aquecido a altas temperaturas e re");
            WriteLiteral(@"sfriado bruscamente em seguida, o que torna a estrutura 6 vezes mais resistente ao impacto frontal do que o vidro float comum. O problema do vidro temperado é que, por um simples impacto nas bordas, ele estilhaça em diversos pedaços e torna-se um risco para uma fachada de vidro na varanda. É possível utilizar películas de segurança para conter os fragmentos do vidro, mas elas amarelam ou descolam com o tempo, fazendo necessária a breve manutenção das folhas.</p>
        </div>
        <div class=""col-md-6"">
            <h4>Vidro Laminado</h4>
            <p>O vidro laminado, apesar de não ter a mesma resistência que o vidro temperado aos impactos frontais, é o principal vidro de segurança para o envidraçamento de sacada. Ele é feito com PVB, o polivinil butiral, uma película plástica e elástica que é fundida em meio a duas peças de vidro, evitando o descolamento dos fragmentos em caso de quebra. Essa película não requer nenhum tipo de manutenção, acompanha toda a vida útil dos vidros e pode ser de diversas co");
            WriteLiteral(@"res</p>
        </div>
    </div>

    <div class=""row"">
        <div class=""col-md-12"">
            <h3>O vidro e suas características!</h3>
        </div>
        <div class=""col-md-6"">
            <h4>Principais características</h4>
            <ul>
                <li><i class=""fas fa-arrow-right""></i>Reciclabilidade</li>
                <li><i class=""fas fa-arrow-right""></i>Transparência (permeável à luz)</li>
                <li><i class=""fas fa-arrow-right""></i>Dureza</li>
                <li><i class=""fas fa-arrow-right""></i>Não absorvência</li>
                <li><i class=""fas fa-arrow-right""></i>Ótimo isolador dielétrico</li>
                <li><i class=""fas fa-arrow-right""></i>Baixa condutividade térmica</li>
                <li><i class=""fas fa-arrow-right""></i>Recursos abundantes na natureza</li>
                <li><i class=""fas fa-arrow-right""></i>Durabilidade</li>
            </ul>
        </div>
        <div class=""col-md-6"">
            <h4>Composição</h4>
            <ul>
                ");
            WriteLiteral(@"<li><i class=""fas fa-arrow-right""></i>Sílica – SiO2 – básica – vitrificante</li>
                <li><i class=""fas fa-arrow-right""></i>Soda – Na2O – baixa o ponto de fusão da sílica</li>
                <li><i class=""fas fa-arrow-right""></i>Cálcio – CaO – estabilidade do vidro</li>
                <li><i class=""fas fa-arrow-right""></i>Magnésio – MgO – enriquece sua resistência mecânica</li>
                <li><i class=""fas fa-arrow-right""></i>Alumina – Al2O3 – reforça suas resistências</li>
                <li><i class=""fas fa-arrow-right""></i>Cloreto de Sódio, Nitrato de Sódio, Óxido de Selênio – afinantes</li>
                <li><i class=""fas fa-arrow-right""></i>Óxido de Arsênico (AZUL), Óxido de Ferro (VERDE), Óxido de Selênio (CINZA) – corantes</li>
                <li><i class=""fas fa-arrow-right""></i>Sucatas de vidros – 20% a 40% para fusão</li>
            </ul>
        </div>
        <div class=""col-md-6"">
            <h4>Utilização</h4>
            <ul>
                <li><i class=""fas fa-arrow-ri");
            WriteLiteral(@"ght""></i>Vidros Ocos</li>
                <li><i class=""fas fa-arrow-right""></i>Vidros Planos</li>
                <li><i class=""fas fa-arrow-right""></i>Vidros Finos</li>
                <li><i class=""fas fa-arrow-right""></i>Vidros Curvos</li>
            </ul>
        </div>
        <div class=""col-md-6"">
            <h4>Fabricação</h4>
            <p>800° C: a mistura atinge o estado pastoso, fundindo-se ao atingir 1000º C.Existem 4 processos: Fourcoult, Pittsburg, Libbey Owens, porém o mais atual é o Floot Glass, pois não apresenta ondulações tampouco deformações.</p>
        </div>
        <div class=""col-md-6"">
            <h4>Cores</h4>
            <p>Incolor. Fumê. Bronze. Verde. Cristal refletivo de alta performance, originando várias cores</p>
        </div>
        <div class=""col-md-6"">
            <h4>Classificação</h4>
            <p>Recozido: recozido refletivo.</p>
        </div>
    </div>

    <div class=""row"">
        <div class=""col-md-12"">
            <h3>Tipos de Vidros Resistentes​</h3>
");
            WriteLiteral(@"        </div>
        <div class=""col-md-6"">
            <h4>Temperado</h4>
            <p>Processo de têmpera que estabelece tensões nas zonas superficiais e correspondentes a altas tensões no centro (externamente em compressão e internamente em expansão).</p>
        </div>
        <div class=""col-md-6"">
            <h4>Laminado</h4>
            <p>Um ou mais vidros intercalados com PVB butiral que após passar por processos de tratamento semi-colagem e, finalmente, a colagem final em equipamento especialmente desenhado para este fim.</p>
        </div>
        <div class=""col-md-6"">
            <h4>Aramado</h4>
            <p>O vidro aramado é um vidro impresso translúcido incolor, no qual é incorporada uma rede metálica de malha quadrada.</p>
        </div>
        <div class=""col-md-6"">
            <h4>Transparência</h4>
            <p>Transparente. Translúcido. Opaco.</p>
        </div>
    </div>

    <div class=""row"">
        <div class=""col-md-12"">
            <h3>Determinação da Espessura</h3>
     ");
            WriteLiteral(@"       <p>Existem alguns fatores que devem ser levados em consideração na determinação da espessura do vidro:</p>
            <ul>
                <li><i class=""fas fa-arrow-right""></i>Região onde se encontra a construção, em função da altitude</li>
                <li><i class=""fas fa-arrow-right""></i>Altura do vidro acima do solo</li>
                <li><i class=""fas fa-arrow-right""></i>Pressões do vento</li>
                <li><i class=""fas fa-arrow-right""></i>Inclinação do envidraçamento</li>
                <li><i class=""fas fa-arrow-right""></i>Tipo de fixação do vidro</li>
                <li><i class=""fas fa-arrow-right""></i>Tipo de caixilho</li>
                <li><i class=""fas fa-arrow-right""></i>Tipo de vidro aplicado</li>
            </ul>
        </div>
    </div>

    <div class=""row"">
        <div class=""col-md-12"">
            <h3>Instalação Contramarcos</h3>
            <p>O contramarco é um contorno de alumínio preparado para ser chumbado no vão onde futuramente será instalado a esquadria ");
            WriteLiteral("de alumínio.</p>\n        </div>\n        <div class=\"col-md-6\">\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "606cc29a758f159e9cd2bc1ab514dc01ae49652818279", async() => {
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
            WriteLiteral("\n        </div>\n        <div class=\"col-md-6\">\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "606cc29a758f159e9cd2bc1ab514dc01ae49652819370", async() => {
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
            WriteLiteral("\n        </div>\n        <div class=\"col-md-6\">\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "606cc29a758f159e9cd2bc1ab514dc01ae49652820461", async() => {
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
            WriteLiteral("\n        </div>\n        <div class=\"col-md-6\">\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "606cc29a758f159e9cd2bc1ab514dc01ae49652821552", async() => {
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
            WriteLiteral("\n        </div>\n    </div>\n</section>\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "606cc29a758f159e9cd2bc1ab514dc01ae49652822719", async() => {
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
                WriteLiteral("\n");
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
