#pragma checksum "C:\Users\kamilcan\Desktop\BT-Software\egitim-3\asd\egitim\Areas\Ogrenci\Views\Home\GetCevap.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e194a0b3d9f4779a8ca64a8abc6c21024d5dab43"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Ogrenci_Views_Home_GetCevap), @"mvc.1.0.view", @"/Areas/Ogrenci/Views/Home/GetCevap.cshtml")]
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
#line 1 "C:\Users\kamilcan\Desktop\BT-Software\egitim-3\asd\egitim\Areas\Ogrenci\Views\_ViewImports.cshtml"
using egitim;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kamilcan\Desktop\BT-Software\egitim-3\asd\egitim\Areas\Ogrenci\Views\_ViewImports.cshtml"
using egitim.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e194a0b3d9f4779a8ca64a8abc6c21024d5dab43", @"/Areas/Ogrenci/Views/Home/GetCevap.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c14c9264dec13091842345b9e8ccbfc556c30d2", @"/Areas/Ogrenci/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Ogrenci_Views_Home_GetCevap : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 3 "C:\Users\kamilcan\Desktop\BT-Software\egitim-3\asd\egitim\Areas\Ogrenci\Views\Home\GetCevap.cshtml"
 if (Model != null && Model.Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2>Cevaplar:</h2>\r\n");
            WriteLiteral("    <table>\r\n        <thead>\r\n            <tr>\r\n                <th>Soru</th>\r\n                <th>Cevap</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 15 "C:\Users\kamilcan\Desktop\BT-Software\egitim-3\asd\egitim\Areas\Ogrenci\Views\Home\GetCevap.cshtml"
             foreach (var cevap in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 18 "C:\Users\kamilcan\Desktop\BT-Software\egitim-3\asd\egitim\Areas\Ogrenci\Views\Home\GetCevap.cshtml"
                   Write(cevap);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</td>\r\n                    <td>");
#nullable restore
#line 19 "C:\Users\kamilcan\Desktop\BT-Software\egitim-3\asd\egitim\Areas\Ogrenci\Views\Home\GetCevap.cshtml"
                   Write(cevap.Cevap);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 21 "C:\Users\kamilcan\Desktop\BT-Software\egitim-3\asd\egitim\Areas\Ogrenci\Views\Home\GetCevap.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 24 "C:\Users\kamilcan\Desktop\BT-Software\egitim-3\asd\egitim\Areas\Ogrenci\Views\Home\GetCevap.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>Henüz cevap bulunmamaktadır.</p>\r\n");
#nullable restore
#line 28 "C:\Users\kamilcan\Desktop\BT-Software\egitim-3\asd\egitim\Areas\Ogrenci\Views\Home\GetCevap.cshtml"
}

#line default
#line hidden
#nullable disable
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
