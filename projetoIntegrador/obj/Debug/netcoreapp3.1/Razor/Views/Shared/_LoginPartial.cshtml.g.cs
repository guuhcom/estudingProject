#pragma checksum "C:\Users\gusta\source\repos\AgroX\projetoIntegrador\Views\Shared\_LoginPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5191572b04d6e32e097ef5059d068fb37499a551"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__LoginPartial), @"mvc.1.0.view", @"/Views/Shared/_LoginPartial.cshtml")]
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
#line 1 "C:\Users\gusta\source\repos\AgroX\projetoIntegrador\Views\_ViewImports.cshtml"
using projetoIntegrador;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gusta\source\repos\AgroX\projetoIntegrador\Views\_ViewImports.cshtml"
using projetoIntegrador.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\gusta\source\repos\AgroX\projetoIntegrador\Views\Shared\_LoginPartial.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5191572b04d6e32e097ef5059d068fb37499a551", @"/Views/Shared/_LoginPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48476a4d7b80b4da8d8010a34d30a863ed835503", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__LoginPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<ul class=\"navbar-nav\">\r\n");
#nullable restore
#line 7 "C:\Users\gusta\source\repos\AgroX\projetoIntegrador\Views\Shared\_LoginPartial.cshtml"
     if (!User.Identity.IsAuthenticated)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""header"">
    <div class=""container"">
        <div class=""navbar"">
            <div class=""logo"">
                <img src=""images/logo.png"" alt=""logo.png"" width=""125px"">
            </div>
            <nav>
                <ul>
                    <li><a href=""/front/Home/index.html"">Home</a></li>
                    <li><a href=""/front/Projeto/projeto.html"">Projetos</a></li>
                    <li><a href=""/front/Sobre/about.html"">Sobre</a></li>
                    <li><a href=""/front/Login/login.html"">Conta</a></li>
                </ul>
            </nav>
        </div>
    </div>
</div>
");
#nullable restore
#line 26 "C:\Users\gusta\source\repos\AgroX\projetoIntegrador\Views\Shared\_LoginPartial.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<IdentityUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> SignInManager { get; private set; }
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
