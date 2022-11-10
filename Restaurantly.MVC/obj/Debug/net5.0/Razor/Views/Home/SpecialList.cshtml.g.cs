#pragma checksum "C:\Users\fatih\source\repos\Restaurantly\Restaurantly.MVC\Views\Home\SpecialList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "764744465882146e29e8f38f25adb472064ad38f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_SpecialList), @"mvc.1.0.view", @"/Views/Home/SpecialList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"764744465882146e29e8f38f25adb472064ad38f", @"/Views/Home/SpecialList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbd93b4fffa333bbb845009b7606c5665a64fe33", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_SpecialList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SpecialListDto>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\fatih\source\repos\Restaurantly\Restaurantly.MVC\Views\Home\SpecialList.cshtml"
  
    ViewData["Title"] = "SpecialList";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section id=""specials"" class=""specials"">
    <div class=""container"" data-aos=""fade-up"">

        <div class=""section-title"">
            <h2>Özel</h2>
            <p>Özel Ürünlerimizi Kontrol Edin</p>
        </div>

        <div class=""row"" data-aos=""fade-up"" data-aos-delay=""100"">
");
#nullable restore
#line 18 "C:\Users\fatih\source\repos\Restaurantly\Restaurantly.MVC\Views\Home\SpecialList.cshtml"
             foreach (var special in Model.Specials)
            {
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-lg-3\">\r\n                <ul class=\"nav nav-tabs flex-column\">\r\n                  \r\n                    <li class=\"nav-item\">\r\n                        <a class=\"nav-link active show\" data-bs-toggle=\"tab\"");
            BeginWriteAttribute("href", " href=\"", 729, "\"", 752, 2);
            WriteAttributeValue("", 736, "#tab-", 736, 5, true);
#nullable restore
#line 25 "C:\Users\fatih\source\repos\Restaurantly\Restaurantly.MVC\Views\Home\SpecialList.cshtml"
WriteAttributeValue("", 741, special.Id, 741, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 25 "C:\Users\fatih\source\repos\Restaurantly\Restaurantly.MVC\Views\Home\SpecialList.cshtml"
                                                                                                Write(special.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                    </li>\r\n                </ul>\r\n            </div>\r\n            <div class=\"col-lg-9 mt-4 mt-lg-0\">\r\n                <div class=\"tab-content\">\r\n               \r\n                        <div class=\"tab-pane active show\"");
            BeginWriteAttribute("id", " id=\"", 1009, "\"", 1029, 2);
            WriteAttributeValue("", 1014, "tab-", 1014, 4, true);
#nullable restore
#line 32 "C:\Users\fatih\source\repos\Restaurantly\Restaurantly.MVC\Views\Home\SpecialList.cshtml"
WriteAttributeValue("", 1018, special.Id, 1018, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <div class=\"row\">\r\n                                <div class=\"col-lg-8 details order-2 order-lg-1\">\r\n                                    <h3>");
#nullable restore
#line 35 "C:\Users\fatih\source\repos\Restaurantly\Restaurantly.MVC\Views\Home\SpecialList.cshtml"
                                   Write(special.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                    <p>");
#nullable restore
#line 36 "C:\Users\fatih\source\repos\Restaurantly\Restaurantly.MVC\Views\Home\SpecialList.cshtml"
                                  Write(special.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                </div>\r\n                                <div class=\"col-lg-4 text-center order-1 order-lg-2\">\r\n                                    <img");
            BeginWriteAttribute("src", " src=\"", 1456, "\"", 1478, 1);
#nullable restore
#line 39 "C:\Users\fatih\source\repos\Restaurantly\Restaurantly.MVC\Views\Home\SpecialList.cshtml"
WriteAttributeValue("", 1462, special.Picture, 1462, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1479, "\"", 1485, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\">\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n \r\n              \r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 47 "C:\Users\fatih\source\repos\Restaurantly\Restaurantly.MVC\Views\Home\SpecialList.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n\r\n    </div>\r\n</section><!-- End Specials Section -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SpecialListDto> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
