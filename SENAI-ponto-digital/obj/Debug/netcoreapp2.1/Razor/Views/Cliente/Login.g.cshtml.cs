#pragma checksum "C:\Users\38850490828\Documents\Projetos SENAI\senai\projetos\PontoDigitaFinal\SENAI-ponto-digital\Views\Cliente\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c1b1ac1395fe5248aec981cb0ea44b58101c800"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cliente_Login), @"mvc.1.0.view", @"/Views/Cliente/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cliente/Login.cshtml", typeof(AspNetCore.Views_Cliente_Login))]
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
#line 1 "C:\Users\38850490828\Documents\Projetos SENAI\senai\projetos\PontoDigitaFinal\SENAI-ponto-digital\Views\_ViewImports.cshtml"
using SENAI_ponto_digital;

#line default
#line hidden
#line 2 "C:\Users\38850490828\Documents\Projetos SENAI\senai\projetos\PontoDigitaFinal\SENAI-ponto-digital\Views\_ViewImports.cshtml"
using SENAI_ponto_digital.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c1b1ac1395fe5248aec981cb0ea44b58101c800", @"/Views/Cliente/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c151f02c7981a822c9ded3eeda28f24f5ac5989b", @"/Views/_ViewImports.cshtml")]
    public class Views_Cliente_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\38850490828\Documents\Projetos SENAI\senai\projetos\PontoDigitaFinal\SENAI-ponto-digital\Views\Cliente\Login.cshtml"
  
    ViewData["Title"] = "Login - Agora Vai";
    ViewData["H2"] = "Login";

#line default
#line hidden
            BeginContext(84, 32, true);
            WriteLiteral("<header class=\"menuNavegacao\">\r\n");
            EndContext();
#line 6 "C:\Users\38850490828\Documents\Projetos SENAI\senai\projetos\PontoDigitaFinal\SENAI-ponto-digital\Views\Cliente\Login.cshtml"
      
        Html.RenderPartial("_HeaderNavBar");
    

#line default
#line hidden
            BeginContext(177, 46, true);
            WriteLiteral("</header>\r\n\r\n<main>\r\n    <h2 class=\"h2_login\">");
            EndContext();
            BeginContext(224, 14, false);
#line 12 "C:\Users\38850490828\Documents\Projetos SENAI\senai\projetos\PontoDigitaFinal\SENAI-ponto-digital\Views\Cliente\Login.cshtml"
                    Write(ViewData["H2"]);

#line default
#line hidden
            EndContext();
            BeginContext(238, 35, true);
            WriteLiteral("</h2>\r\n    <div class=\"form\">\r\n    ");
            EndContext();
            BeginContext(273, 935, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1afae7b8f33d4410900650c97be3e23a", async() => {
                BeginContext(334, 713, true);
                WriteLiteral(@"
        <div class=""login"">
            <div class=""email_senha"">
                <div class=""email"">
                    <label for=""email"">E-mail</label>
                    <br />
                    <input id=""email"" type=""email"" name=""email"" />
                </div>

                <div class=""senha"">
                    <label for=""senha"">Senha</label>
                    <br />
                    <input id=""senha"" type=""password"" maxlength=""20"" minlength=""4"" name=""senha"">
                </div>
            </div>
            <div class=""bt_login"">
            <input type=""submit"" value=""Iniciar Sessão"" />
            </div>
        <div id=""link-cadastro"">
                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\'", 1047, "\'", 1086, 1);
#line 33 "C:\Users\38850490828\Documents\Projetos SENAI\senai\projetos\PontoDigitaFinal\SENAI-ponto-digital\Views\Cliente\Login.cshtml"
WriteAttributeValue("", 1054, Url.Action("Index", "Cadastro"), 1054, 32, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1087, 114, true);
                WriteLiteral(">Ainda não possui cadastro?<br>Cadastre-se aqui!</a>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 14 "C:\Users\38850490828\Documents\Projetos SENAI\senai\projetos\PontoDigitaFinal\SENAI-ponto-digital\Views\Cliente\Login.cshtml"
AddHtmlAttributeValue("", 301, Url.Action("Login", "Cliente"), 301, 31, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1208, 15, true);
            WriteLiteral("\r\n    \r\n</main>");
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
