#pragma checksum "C:\Users\usuario\Desktop\Vidracaria-Portal\Vidracaria_Portal\Views\Time\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e75720715c1ced351c678f9a01d564ae73a4d12"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Time_Index), @"mvc.1.0.view", @"/Views/Time/Index.cshtml")]
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
#nullable restore
#line 2 "C:\Users\usuario\Desktop\Vidracaria-Portal\Vidracaria_Portal\Views\Time\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e75720715c1ced351c678f9a01d564ae73a4d12", @"/Views/Time/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7e74bf89e845a9e8ab2071e73dd8674ad8a9411", @"/Views/_ViewImports.cshtml")]
    public class Views_Time_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<X.PagedList.IPagedList<Vidracaria_Portal.Models.Administrador.Cadastros.TimeModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\usuario\Desktop\Vidracaria-Portal\Vidracaria_Portal\Views\Time\Index.cshtml"
  
    ViewData["Title"] = "Listagem";
    Layout = "~/Views/Shared/_LayoutAdministrador.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"content\">\r\n        <div class=\"row\" style=\"margin-bottom: 15px; padding-left: 5px;\">\r\n            <div class=\"col-md-12\">\r\n                <div class=\"col-md-6\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e75720715c1ced351c678f9a01d564ae73a4d125175", async() => {
                WriteLiteral("Criar Novo");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div style=\"display: flex; justify-content: space-evenly; flex-wrap: wrap;\">\r\n");
#nullable restore
#line 19 "C:\Users\usuario\Desktop\Vidracaria-Portal\Vidracaria_Portal\Views\Time\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""col-lg-4 col-md-6 d-flex align-items-stretch"" style=""box-shadow: 5px 5px 8px black"">
                    <div class=""member"">
                        <img style=""width: 100%; height: 200px; border-radius: 50%; margin-top: 10px;""");
            BeginWriteAttribute("src", " src=\"", 984, "\"", 1162, 1);
#nullable restore
#line 23 "C:\Users\usuario\Desktop\Vidracaria-Portal\Vidracaria_Portal\Views\Time\Index.cshtml"
WriteAttributeValue("", 990,  System.IO.File.Exists(ViewData["CaminhoImagem"] + "/" + item.Imagem) ?
                    Url.Content("~/" + item.Imagem) : Url.Content("/imagensSaves/sem_foto.png") , 990, 172, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1163, "\"", 1169, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <h5 style=\"margin-top: 10px;\"> ");
#nullable restore
#line 25 "C:\Users\usuario\Desktop\Vidracaria-Portal\Vidracaria_Portal\Views\Time\Index.cshtml"
                                                  Write(Html.DisplayFor(modelItem => item.NomeTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <h5 style=\"margin-top: 10px;\"> ");
#nullable restore
#line 26 "C:\Users\usuario\Desktop\Vidracaria-Portal\Vidracaria_Portal\Views\Time\Index.cshtml"
                                                  Write(Html.DisplayFor(modelItem => item.Cargo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <h6 style=\"margin-top: 10px;\"> <b>Link Face: </b>");
#nullable restore
#line 27 "C:\Users\usuario\Desktop\Vidracaria-Portal\Vidracaria_Portal\Views\Time\Index.cshtml"
                                                                    Write(Html.DisplayFor(modelItem => item.LinkFacebook));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                        <h6 style=\"margin-top: 10px;\"> <b>Link Insta: </b>");
#nullable restore
#line 28 "C:\Users\usuario\Desktop\Vidracaria-Portal\Vidracaria_Portal\Views\Time\Index.cshtml"
                                                                     Write(Html.DisplayFor(modelItem => item.LinkImagem));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                        <div class=\"social\" style=\"margin-top: 15px;\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e75720715c1ced351c678f9a01d564ae73a4d129375", async() => {
                WriteLiteral("<i class=\"fa fa-edit td-icones\" style=\"color:black;\" data-toggle=\"tooltip\" data-placement=\"right\" title=\"Editar\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 30 "C:\Users\usuario\Desktop\Vidracaria-Portal\Vidracaria_Portal\Views\Time\Index.cshtml"
                                                   WriteLiteral(item.CodigoTIme);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e75720715c1ced351c678f9a01d564ae73a4d1211698", async() => {
                WriteLiteral("<i class=\"fa fa-trash-alt td-icones\" style=\"color:darkred;\" data-toggle=\"tooltip\" data-placement=\"left\" title=\"Deletar\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 31 "C:\Users\usuario\Desktop\Vidracaria-Portal\Vidracaria_Portal\Views\Time\Index.cshtml"
                                                     WriteLiteral(item.CodigoTIme);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 35 "C:\Users\usuario\Desktop\Vidracaria-Portal\Vidracaria_Portal\Views\Time\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div style=\"margin-top: 20px;\">\r\n            ");
#nullable restore
#line 38 "C:\Users\usuario\Desktop\Vidracaria-Portal\Vidracaria_Portal\Views\Time\Index.cshtml"
       Write(Html.PagedListPager(Model, pagina => Url.Action("Index", new { filtro = ViewData["Filtro"], pagina }),
                   new X.PagedList.Web.Common.PagedListRenderOptionsBase
                   {
                       DisplayLinkToFirstPage = X.PagedList.Web.Common.PagedListDisplayMode.Always,
                       DisplayLinkToLastPage = X.PagedList.Web.Common.PagedListDisplayMode.Always,
                       DisplayLinkToNextPage = X.PagedList.Web.Common.PagedListDisplayMode.Always,
                       DisplayLinkToPreviousPage = X.PagedList.Web.Common.PagedListDisplayMode.Always,
                       ContainerDivClasses = new[] { "pagination-container" },
                       UlElementClasses = new string[] { "pagination justify-content-center" },
                       LiElementClasses = new string[] { "page-item" },
                       PageClasses = new string[] { "page-link" }
                   }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<X.PagedList.IPagedList<Vidracaria_Portal.Models.Administrador.Cadastros.TimeModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
