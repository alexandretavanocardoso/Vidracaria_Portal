#pragma checksum "C:\Users\usuario\Desktop\Vidracaria-Portal\Vidracaria_Portal\Views\Home\Galeria.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5448b606451746274ac79932cdd8374d9eee739c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Galeria), @"mvc.1.0.view", @"/Views/Home/Galeria.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5448b606451746274ac79932cdd8374d9eee739c", @"/Views/Home/Galeria.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7e74bf89e845a9e8ab2071e73dd8674ad8a9411", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Galeria : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Vidracaria_Portal.Models.Administrador.Cadastros.GaleriaModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\usuario\Desktop\Vidracaria-Portal\Vidracaria_Portal\Views\Home\Galeria.cshtml"
   ViewData["title"] = "Galeria";
    Layout = "~/Views/Shared/_LayoutCliente.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            DefineSection("Styles", async() => {
                WriteLiteral("\n    <style>\n        .sombra {\n            box-shadow: -1px -1px 12px 5px rgba(0,0,0,0.75);\n            -webkit-box-shadow: -1px -1px 12px 5px rgba(0,0,0,0.75);\n            -moz-box-shadow: -1px -1px 12px 5px rgba(0,0,0,0.75);\n        }\n    </style>\n");
            }
            );
            WriteLiteral(@"
<section id=""hero"" style=""background: url('../img/Banner/banner4.jpg'); height: 300px; width: 100%;"" class=""d-flex align-items-center"">
</section>

<div class=""container sombra"" style=""margin-top: 60px; margin-bottom: 60px;"">
    <div class=""section-title"">
        <span style=""margin-top: 20px;"">Galeria</span>
        <h2 style=""margin-top: 20px;"">Galeria</h2>
    </div>
    <div class=""row"">
        <div style=""width: 100%; display: flex; flex-wrap: wrap; justify-content: space-evenly;"">
");
#nullable restore
#line 26 "C:\Users\usuario\Desktop\Vidracaria-Portal\Vidracaria_Portal\Views\Home\Galeria.cshtml"
                 foreach (var gal in Model)
                {
                    if (gal.Imagem != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div");
            BeginWriteAttribute("style", " style=\"", 1093, "\"", 1101, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                            <a style=\"object-fit: cover;\"");
            BeginWriteAttribute("href", " href=\"", 1161, "\"", 1357, 1);
#nullable restore
#line 31 "C:\Users\usuario\Desktop\Vidracaria-Portal\Vidracaria_Portal\Views\Home\Galeria.cshtml"
WriteAttributeValue("", 1168,  System.IO.File.Exists(ViewData["CaminhoImagem"] + "/" + gal.Imagem) ?
                                        Url.Content("~/" + gal.Imagem) : Url.Content("/imagensSaves/sem_foto.png") , 1168, 189, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-lightbox=\"conjuntoPrincipal\" data-title=\"Servi??os\">\n                                <img style=\"object-fit: cover; height: 250px; width: 270px; margin-right: 6px; margin-left: 6px; margin-bottom: 12px;\"");
            BeginWriteAttribute("src", " src=\"", 1566, "\"", 1761, 1);
#nullable restore
#line 33 "C:\Users\usuario\Desktop\Vidracaria-Portal\Vidracaria_Portal\Views\Home\Galeria.cshtml"
WriteAttributeValue("", 1572,  System.IO.File.Exists(ViewData["CaminhoImagem"] + "/" + gal.Imagem) ?
                                        Url.Content("~/" + gal.Imagem) : Url.Content("/imagensSaves/sem_foto.png") , 1572, 189, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n                            </a>\n                        </div>  \n");
#nullable restore
#line 37 "C:\Users\usuario\Desktop\Vidracaria-Portal\Vidracaria_Portal\Views\Home\Galeria.cshtml"
                    }
                    else
                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <img style=\"object-fit: cover; height: 300px; width: 300px; margin-right: 12px; margin-bottom: 12px;\"");
            BeginWriteAttribute("src", " src=\"", 2029, "\"", 2078, 1);
#nullable restore
#line 41 "C:\Users\usuario\Desktop\Vidracaria-Portal\Vidracaria_Portal\Views\Home\Galeria.cshtml"
WriteAttributeValue("", 2035, Url.Content("~/imagensSaves/sem_foto.png"), 2035, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 42 "C:\Users\usuario\Desktop\Vidracaria-Portal\Vidracaria_Portal\Views\Home\Galeria.cshtml"
                    }
                }   

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\n    </div>\n</div>\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n    <script>\n\n    </script>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Vidracaria_Portal.Models.Administrador.Cadastros.GaleriaModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
