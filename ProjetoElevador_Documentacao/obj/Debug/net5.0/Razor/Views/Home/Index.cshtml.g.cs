#pragma checksum "C:\Users\Barbara Grazioli\Documents\1_ Códigos variados\ProjetoElevador_Documentacao\ProjetoElevador_Documentacao\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "737969930b160a2898431b15704f612473323007"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Barbara Grazioli\Documents\1_ Códigos variados\ProjetoElevador_Documentacao\ProjetoElevador_Documentacao\Views\_ViewImports.cshtml"
using ProjetoElevador_Documentacao;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Barbara Grazioli\Documents\1_ Códigos variados\ProjetoElevador_Documentacao\ProjetoElevador_Documentacao\Views\_ViewImports.cshtml"
using ProjetoElevador_Documentacao.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"737969930b160a2898431b15704f612473323007", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4923143fe3bec400c1f93c72fde12f2bac68e920", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Barbara Grazioli\Documents\1_ Códigos variados\ProjetoElevador_Documentacao\ProjetoElevador_Documentacao\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Projeto Elevador - Documentação</h1>
    <p>
        Este programa possui a classe Elevador.cs, contendo os métodos ElevadorMenu, MostrarMenu, VerificaResposta, Inicializar, Entrar, Subir, Descer e Sair. Cujo método principal, ElevadorMenu, é chamado na classe Program e é responsável por chamar os outros métodos e ler as opções escolhidas pelo usuário.
        O método VerificaResposta recebe a opção indicada pelo usuário e executa a função equivalente. Entrar e Sair verificam se é possível executar estas ações de acordo com o número de usuários e a capacidade máxima do elevador. Subir e Descer verificam o andar atual e os limites superior e inferior de andares. E o método Finalizar encerra a aplicação.
    </p>
</div>
");
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
