#pragma checksum "C:\Users\fatih\source\repos\Restaurantly\Restaurantly.MVC\Views\Shared\_NavbarPartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b11d8d3660684a191c0a0ce0bb1f9db4e81851f2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__NavbarPartialView), @"mvc.1.0.view", @"/Views/Shared/_NavbarPartialView.cshtml")]
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
#line 2 "C:\Users\fatih\source\repos\Restaurantly\Restaurantly.MVC\Views\_ViewImports.cshtml"
using Restaurantly.Entity.Dtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\fatih\source\repos\Restaurantly\Restaurantly.MVC\Views\_ViewImports.cshtml"
using Restaurantly.MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b11d8d3660684a191c0a0ce0bb1f9db4e81851f2", @"/Views/Shared/_NavbarPartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba43e6f6360cdf2a37bda59ca975e0a5d4819879", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__NavbarPartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<header id=""header"" class=""fixed-top d-flex align-items-cente"">
    <div class=""container-fluid container-xl d-flex align-items-center justify-content-lg-between"">

        <h1 class=""logo me-auto me-lg-0""><a href=""index.html"">Restaruantly</a></h1>
        <!-- Uncomment below if you prefer to use an image logo -->
        <!-- <a href=""index.html"" class=""logo me-auto me-lg-0""><img src=""assets/img/logo.png"" alt="""" class=""img-fluid""></a>-->

        <nav id=""navbar"" class=""navbar order-last order-lg-0"">
            <ul>
                <li><a class=""nav-link scrollto active"" href=""#hero"">Anasayfa</a></li>
                <li><a class=""nav-link scrollto"" href=""#about"">Hakkımızda</a></li>
                <li><a class=""nav-link scrollto"" href=""#menu"">Menu</a></li>
                <li><a class=""nav-link scrollto"" href=""#specials"">Özel Menüler</a></li>
                <li><a class=""nav-link scrollto"" href=""#chefs"">Şeflerimiz</a></li>
                <li><a class=""nav-link scrollto"" href=""#gallery"">G");
            WriteLiteral("aleri</a></li>\r\n                <li><a class=\"nav-link scrollto\" href=\"#contact\">İletişim</a></li>\r\n            </ul>\r\n            <i class=\"bi bi-list mobile-nav-toggle\"></i>\r\n        </nav><!-- .navbar -->\r\n");
#nullable restore
#line 21 "C:\Users\fatih\source\repos\Restaurantly\Restaurantly.MVC\Views\Shared\_NavbarPartialView.cshtml"
         if (User.Identity.IsAuthenticated)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a href=\"#book-a-table\" class=\"book-a-table-btn scrollto d-none d-lg-flex\">Rezervasyon Yap</a>\r\n            <a href=\"/Login/SignOut\" class=\"book-a-table-btn scrollto d-none d-lg-flex\">Çıkış Yap</a>\r\n");
#nullable restore
#line 25 "C:\Users\fatih\source\repos\Restaurantly\Restaurantly.MVC\Views\Shared\_NavbarPartialView.cshtml"
        }
        else
        {
                    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <a href=""#book-a-table"" class=""book-a-table-btn scrollto d-none d-lg-flex"">Rezervasyon Yap</a>
            <a href=""/Login/SignIn"" class=""book-a-table-btn scrollto d-none d-lg-flex"">Giriş Yap</a>
            <a href=""/Login/SignUp"" class=""book-a-table-btn scrollto d-none d-lg-flex"">Kayıt Ol</a>
");
#nullable restore
#line 32 "C:\Users\fatih\source\repos\Restaurantly\Restaurantly.MVC\Views\Shared\_NavbarPartialView.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    \r\n  \r\n\r\n    </div>\r\n</header><!-- End Header -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
