#pragma checksum "C:\dev\Cursos\Desenvolvedor.io\Curso Identity Server 4\SkyCommerce\SkyCommerce.Loja\SkyCommerce.Site\Views\Shared\Produtos\_Visualizar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8335c7632c49f9ded107c72ac1245e7d6a32385"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Produtos__Visualizar), @"mvc.1.0.view", @"/Views/Shared/Produtos/_Visualizar.cshtml")]
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
#line 1 "C:\dev\Cursos\Desenvolvedor.io\Curso Identity Server 4\SkyCommerce\SkyCommerce.Loja\SkyCommerce.Site\Views\_ViewImports.cshtml"
using SkyCommerce.Site;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\dev\Cursos\Desenvolvedor.io\Curso Identity Server 4\SkyCommerce\SkyCommerce.Loja\SkyCommerce.Site\Views\_ViewImports.cshtml"
using SkyCommerce.Site.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8335c7632c49f9ded107c72ac1245e7d6a32385", @"/Views/Shared/Produtos/_Visualizar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b28dd728e3ad0af0593557eebacddfc0f3674521", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Produtos__Visualizar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SkyCommerce.Models.Produto>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("product-largeimg-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Catalogo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detalhes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Carrinho", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Adicionar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\dev\Cursos\Desenvolvedor.io\Curso Identity Server 4\SkyCommerce\SkyCommerce.Loja\SkyCommerce.Site\Views\Shared\Produtos\_Visualizar.cshtml"
  
    string currentUrl = Context.Request.Scheme + "://" + Context.Request.Host + @Url.Action("Detalhes", "Catalogo", new { produto = Model.NomeUnico });
    string enc = System.Net.WebUtility.UrlEncode(currentUrl);
    string text = System.Net.WebUtility.UrlEncode(Model.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("<button aria-hidden=\"true\" data-dismiss=\"modal\" class=\"close\" type=\"button\"> ×</button>\n<div class=\"col-lg-5 col-md-5 col-sm-5  col-xs-12\">\n\n    <!-- product Image -->\n    <div class=\"main-image  col-lg-12 no-padding style3\">\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8335c7632c49f9ded107c72ac1245e7d6a323855977", async() => {
                WriteLiteral("\n            <img");
                BeginWriteAttribute("src", " src=\"", 685, "\"", 704, 1);
#nullable restore
#line 13 "C:\dev\Cursos\Desenvolvedor.io\Curso Identity Server 4\SkyCommerce\SkyCommerce.Loja\SkyCommerce.Site\Views\Shared\Produtos\_Visualizar.cshtml"
WriteAttributeValue("", 691, Model.Imagem, 691, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("\n                 class=\"img-responsive product-largeimg\"\n                 alt=\"img\">\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-produto", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 12 "C:\dev\Cursos\Desenvolvedor.io\Curso Identity Server 4\SkyCommerce\SkyCommerce.Loja\SkyCommerce.Site\Views\Shared\Produtos\_Visualizar.cshtml"
                                                                                                WriteLiteral(Model.NomeUnico);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["produto"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-produto", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["produto"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </div>\n    <!--/.main-image-->\n\n    <div class=\"modal-product-thumb\">\n        <a class=\"thumbLink selected\">\n            <img data-large=\"");
#nullable restore
#line 22 "C:\dev\Cursos\Desenvolvedor.io\Curso Identity Server 4\SkyCommerce\SkyCommerce.Loja\SkyCommerce.Site\Views\Shared\Produtos\_Visualizar.cshtml"
                        Write(Model.Imagem);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" alt=\"img\" class=\"img-responsive\"");
            BeginWriteAttribute("src", " src=\"", 993, "\"", 1012, 1);
#nullable restore
#line 22 "C:\dev\Cursos\Desenvolvedor.io\Curso Identity Server 4\SkyCommerce\SkyCommerce.Loja\SkyCommerce.Site\Views\Shared\Produtos\_Visualizar.cshtml"
WriteAttributeValue("", 999, Model.Imagem, 999, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n        </a>\n");
#nullable restore
#line 24 "C:\dev\Cursos\Desenvolvedor.io\Curso Identity Server 4\SkyCommerce\SkyCommerce.Loja\SkyCommerce.Site\Views\Shared\Produtos\_Visualizar.cshtml"
         foreach (var imagem in Model.Imagens)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a class=\"thumbLink selected\">\n                <img data-large=\"");
#nullable restore
#line 27 "C:\dev\Cursos\Desenvolvedor.io\Curso Identity Server 4\SkyCommerce\SkyCommerce.Loja\SkyCommerce.Site\Views\Shared\Produtos\_Visualizar.cshtml"
                            Write(imagem);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" alt=\"img\" class=\"img-responsive\"");
            BeginWriteAttribute("src", " src=\"", 1202, "\"", 1215, 1);
#nullable restore
#line 27 "C:\dev\Cursos\Desenvolvedor.io\Curso Identity Server 4\SkyCommerce\SkyCommerce.Loja\SkyCommerce.Site\Views\Shared\Produtos\_Visualizar.cshtml"
WriteAttributeValue("", 1208, imagem, 1208, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n            </a>\n");
#nullable restore
#line 29 "C:\dev\Cursos\Desenvolvedor.io\Curso Identity Server 4\SkyCommerce\SkyCommerce.Loja\SkyCommerce.Site\Views\Shared\Produtos\_Visualizar.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n    <!--/.modal-product-thumb-->\n</div>\n<!--/ product Image-->\n\n\n<div class=\"col-lg-7 col-md-7 col-sm-7 col-xs-12 modal-details no-padding\">\n    <div class=\"modal-details-inner\">\n        <h1 class=\"product-title\"> ");
#nullable restore
#line 38 "C:\dev\Cursos\Desenvolvedor.io\Curso Identity Server 4\SkyCommerce\SkyCommerce.Loja\SkyCommerce.Site\Views\Shared\Produtos\_Visualizar.cshtml"
                              Write(Model.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n\n        <h3 class=\"product-code\">Codigo : ");
#nullable restore
#line 40 "C:\dev\Cursos\Desenvolvedor.io\Curso Identity Server 4\SkyCommerce\SkyCommerce.Loja\SkyCommerce.Site\Views\Shared\Produtos\_Visualizar.cshtml"
                                     Write(Model.Codigo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n\n        <div class=\"product-price\">\n            <span class=\"price-sales\"> ");
#nullable restore
#line 43 "C:\dev\Cursos\Desenvolvedor.io\Curso Identity Server 4\SkyCommerce\SkyCommerce.Loja\SkyCommerce.Site\Views\Shared\Produtos\_Visualizar.cshtml"
                                  Write(Model.Valor.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> <span class=\"price-standard\">");
#nullable restore
#line 43 "C:\dev\Cursos\Desenvolvedor.io\Curso Identity Server 4\SkyCommerce\SkyCommerce.Loja\SkyCommerce.Site\Views\Shared\Produtos\_Visualizar.cshtml"
                                                                                                 Write(Model.ValorAntigo.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n        </div>\n        <div class=\"details-description\">\n            <p>");
#nullable restore
#line 46 "C:\dev\Cursos\Desenvolvedor.io\Curso Identity Server 4\SkyCommerce\SkyCommerce.Loja\SkyCommerce.Site\Views\Shared\Produtos\_Visualizar.cshtml"
          Write(Model.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </p>
        </div>
        <div class=""color-details"">
            <span class=""selected-color""><strong>COR</strong></span>
            <ul class=""swatches Color"">
                <li class=""selected"">
                    <a style=""background-color:#f1f40e""> </a>
                </li>
                <li>
                    <a style=""background-color:#adadad""> </a>
                </li>
                <li>
                    <a style=""background-color:#4EC67F""> </a>
                </li>
            </ul>
        </div>
        <!--/.color-details-->


        <div class=""cart-actions"">
            <div class=""addto row"">
                <div class=""col-lg-6"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8335c7632c49f9ded107c72ac1245e7d6a3238514305", async() => {
                WriteLiteral("\n                        <input type=\"hidden\" name=\"NomeUnico\"");
                BeginWriteAttribute("value", " value=\"", 2627, "\"", 2651, 1);
#nullable restore
#line 69 "C:\dev\Cursos\Desenvolvedor.io\Curso Identity Server 4\SkyCommerce\SkyCommerce.Loja\SkyCommerce.Site\Views\Shared\Produtos\_Visualizar.cshtml"
WriteAttributeValue("", 2635, Model.NomeUnico, 2635, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                        <button class=""button btn-block btn-cart cart first"" title=""Adicionar ao Carrinho""
                                type=""submit"">
                            Adicionar ao Carrinho
                        </button>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n                </div>\n            </div>\n        </div>\n        <!--/.cart-actions-->\n\n        <div class=\"product-share clearfix\">\n            <p> Compartilhe </p>\n\n            <div class=\"socialIcon\">\n                <a");
            BeginWriteAttribute("href", " href=\"", 3145, "\"", 3201, 2);
            WriteAttributeValue("", 3152, "https://www.facebook.com/sharer/sharer.php?u=", 3152, 45, true);
#nullable restore
#line 85 "C:\dev\Cursos\Desenvolvedor.io\Curso Identity Server 4\SkyCommerce\SkyCommerce.Loja\SkyCommerce.Site\Views\Shared\Produtos\_Visualizar.cshtml"
WriteAttributeValue("", 3197, enc, 3197, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\" rel=\"noopener noreferrer nofollow\">\n                    <i class=\"fa fa-facebook\"></i>\n                </a>\n                <a");
            BeginWriteAttribute("href", " href=\"", 3345, "\"", 3404, 4);
            WriteAttributeValue("", 3352, "https://twitter.com/intent/tweet?url=", 3352, 37, true);
#nullable restore
#line 88 "C:\dev\Cursos\Desenvolvedor.io\Curso Identity Server 4\SkyCommerce\SkyCommerce.Loja\SkyCommerce.Site\Views\Shared\Produtos\_Visualizar.cshtml"
WriteAttributeValue("", 3389, enc, 3389, 4, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3393, "&text=", 3393, 6, true);
#nullable restore
#line 88 "C:\dev\Cursos\Desenvolvedor.io\Curso Identity Server 4\SkyCommerce\SkyCommerce.Loja\SkyCommerce.Site\Views\Shared\Produtos\_Visualizar.cshtml"
WriteAttributeValue("", 3399, text, 3399, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" target=""_blank"" rel=""noopener noreferrer nofollow"">
                    <i class=""fa fa-twitter""></i>
                </a>
            </div>
        </div>
        <!--/.product-share-->
    </div>
    <!--/.modal-details-inner-->
</div>
<!--/.modal-details-->
<div class=""clear""></div>
");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SkyCommerce.Models.Produto> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
