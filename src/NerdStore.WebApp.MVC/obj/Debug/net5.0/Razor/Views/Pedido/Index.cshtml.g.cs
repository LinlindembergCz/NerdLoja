#pragma checksum "C:\Users\lcaraujo1\Downloads\04 - FULL Projeto NerdStore Completo\04 - FULL Projeto NerdStore Completo\src\NerdStore.WebApp.MVC\Views\Pedido\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4777a47367f2d5f99b8e99824005d147b1fbdaf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pedido_Index), @"mvc.1.0.view", @"/Views/Pedido/Index.cshtml")]
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
#line 1 "C:\Users\lcaraujo1\Downloads\04 - FULL Projeto NerdStore Completo\04 - FULL Projeto NerdStore Completo\src\NerdStore.WebApp.MVC\Views\_ViewImports.cshtml"
using NerdStore.WebApp.MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lcaraujo1\Downloads\04 - FULL Projeto NerdStore Completo\04 - FULL Projeto NerdStore Completo\src\NerdStore.WebApp.MVC\Views\_ViewImports.cshtml"
using NerdStore.WebApp.MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4777a47367f2d5f99b8e99824005d147b1fbdaf", @"/Views/Pedido/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"246ad970dd91c7456f8d33f4d8e9926f7afca0fc", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Pedido_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<NerdStore.Vendas.Application.Queries.ViewModels.PedidoViewModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Eventos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\lcaraujo1\Downloads\04 - FULL Projeto NerdStore Completo\04 - FULL Projeto NerdStore Completo\src\NerdStore.WebApp.MVC\Views\Pedido\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n\r\n        <div class=\"col-md-12\">\r\n\r\n            <h4>Meus Pedidos</h4>\r\n            <hr>\r\n            <h5>Confira o status do seu pedido</h5>\r\n\r\n");
#nullable restore
#line 15 "C:\Users\lcaraujo1\Downloads\04 - FULL Projeto NerdStore Completo\04 - FULL Projeto NerdStore Completo\src\NerdStore.WebApp.MVC\Views\Pedido\Index.cshtml"
              
                if (Model.Any())
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <br><br>
                    <div class=""table-responsive-sm"">
                        <table class=""table table-bordered"">
                            <thead class=""thead-light"">
                                <tr>
                                    <th scope=""col"">Pedido</th>
                                    <th scope=""col"">Data Pedido</th>
                                    <th scope=""col"">Status Pedido</th>
                                    <th scope=""col"">Valor</th>
                                    <th scope=""col"">Historia</th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 31 "C:\Users\lcaraujo1\Downloads\04 - FULL Projeto NerdStore Completo\04 - FULL Projeto NerdStore Completo\src\NerdStore.WebApp.MVC\Views\Pedido\Index.cshtml"
                                  
                                    foreach (var pedido in Model)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n                                            <td>");
#nullable restore
#line 35 "C:\Users\lcaraujo1\Downloads\04 - FULL Projeto NerdStore Completo\04 - FULL Projeto NerdStore Completo\src\NerdStore.WebApp.MVC\Views\Pedido\Index.cshtml"
                                           Write(pedido.Codigo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 36 "C:\Users\lcaraujo1\Downloads\04 - FULL Projeto NerdStore Completo\04 - FULL Projeto NerdStore Completo\src\NerdStore.WebApp.MVC\Views\Pedido\Index.cshtml"
                                           Write(pedido.DataCadastro.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>\r\n                                                <h4>\r\n\r\n");
#nullable restore
#line 40 "C:\Users\lcaraujo1\Downloads\04 - FULL Projeto NerdStore Completo\04 - FULL Projeto NerdStore Completo\src\NerdStore.WebApp.MVC\Views\Pedido\Index.cshtml"
                                                      
                                                        if (pedido.PedidoStatus == 4)
                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            <span class=\"badge badge-success\">\r\n                                                                Pago\r\n                                                            </span>\r\n");
#nullable restore
#line 46 "C:\Users\lcaraujo1\Downloads\04 - FULL Projeto NerdStore Completo\04 - FULL Projeto NerdStore Completo\src\NerdStore.WebApp.MVC\Views\Pedido\Index.cshtml"
                                                        }
                                                        else if (pedido.PedidoStatus == 6)
                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            <span class=\"badge badge-danger\">\r\n                                                                Cancelado\r\n                                                            </span>\r\n");
#nullable restore
#line 52 "C:\Users\lcaraujo1\Downloads\04 - FULL Projeto NerdStore Completo\04 - FULL Projeto NerdStore Completo\src\NerdStore.WebApp.MVC\Views\Pedido\Index.cshtml"
                                                        }
                                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </h4>\r\n                                            </td>\r\n                                            <td>");
#nullable restore
#line 57 "C:\Users\lcaraujo1\Downloads\04 - FULL Projeto NerdStore Completo\04 - FULL Projeto NerdStore Completo\src\NerdStore.WebApp.MVC\Views\Pedido\Index.cshtml"
                                           Write(pedido.ValorTotal.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4777a47367f2d5f99b8e99824005d147b1fbdaf9675", async() => {
                WriteLiteral("<span class=\"far fa-clock\"></span>");
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 58 "C:\Users\lcaraujo1\Downloads\04 - FULL Projeto NerdStore Completo\04 - FULL Projeto NerdStore Completo\src\NerdStore.WebApp.MVC\Views\Pedido\Index.cshtml"
                                                                                                                      WriteLiteral(pedido.Id);

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
            WriteLiteral("</td>\r\n                                        </tr>\r\n");
#nullable restore
#line 60 "C:\Users\lcaraujo1\Downloads\04 - FULL Projeto NerdStore Completo\04 - FULL Projeto NerdStore Completo\src\NerdStore.WebApp.MVC\Views\Pedido\Index.cshtml"
                                    }
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </tbody>\r\n                        </table>\r\n                    </div>\r\n");
#nullable restore
#line 66 "C:\Users\lcaraujo1\Downloads\04 - FULL Projeto NerdStore Completo\04 - FULL Projeto NerdStore Completo\src\NerdStore.WebApp.MVC\Views\Pedido\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p>Nenhum pedido</p>\r\n");
#nullable restore
#line 70 "C:\Users\lcaraujo1\Downloads\04 - FULL Projeto NerdStore Completo\04 - FULL Projeto NerdStore Completo\src\NerdStore.WebApp.MVC\Views\Pedido\Index.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<NerdStore.Vendas.Application.Queries.ViewModels.PedidoViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
