#pragma checksum "C:\Users\kamilcan\Desktop\BT-Software\egitim-3\asd\egitim\Views\Home\iletisim.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cfb62794ccbb0cf9a28fdf001c9e1a34a4f22159"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_iletisim), @"mvc.1.0.view", @"/Views/Home/iletisim.cshtml")]
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
#line 1 "C:\Users\kamilcan\Desktop\BT-Software\egitim-3\asd\egitim\Views\_ViewImports.cshtml"
using egitim;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kamilcan\Desktop\BT-Software\egitim-3\asd\egitim\Views\_ViewImports.cshtml"
using egitim.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cfb62794ccbb0cf9a28fdf001c9e1a34a4f22159", @"/Views/Home/iletisim.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c14c9264dec13091842345b9e8ccbfc556c30d2", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_iletisim : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("flex flex-col gap-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\kamilcan\Desktop\BT-Software\egitim-3\asd\egitim\Views\Home\iletisim.cshtml"
  
    ViewData["Title"] = "İletişim";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
  <!-- ----------------------------------------------- -->
<!-- Page Head Start -->
<section id=""pageHead"" class=""w-full  bg-zinc-900 text-white"">
  <div class=""container mx-auto py-10 h-64 flex flex-col justify-center"">
    <h1 class=""text-3xl font-bold pl-10"">İletişim & Ulaşım</h1>
<ul class=""flex flex-row py-2 pl-10 gap-4"">
  <li class=""text-zinc-400""><a href=""#"">Anasayfa</a></li>
  <span>></span>
  <li><a href=""#"">İletişim</a></li>
</ul>

  </div>
</section>
<!-- Page Head End -->


  <!-- Contact Start -->
  <section class=""w-full"">
    <div class=""container mx-auto grid grid-cols-12 min-h-screen"">
      <div class=""col-span-12 md:col-span-7 px-4 md:px-0 py-8"">
          <div>
            <iframe src=""https://www.google.com/maps/embed?pb=!1m14!1m12!1m3!1d12683.585764701476!2d27.262976!3d37.368627200000006!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!5e0!3m2!1sen!2str!4v1688423065719!5m2!1sen!2str"" style=""border:0;"" class=""w-full h-44 md:h-80 rounded-xl""");
            BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 1083, "\"", 1101, 0);
            EndWriteAttribute();
            WriteLiteral(@" loading=""lazy"" referrerpolicy=""no-referrer-when-downgrade""></iframe>
          </div>

          <div class=""flex flex-col my-4"">
          <h2 class=""font-medium text-xl"">Telefon</h2>
            <a href=""tel:+"" class=""text-lg text-red-600"">0000000000</a>
            <a href=""tel:+"" class=""text-lg text-red-600"">0000000000</a>
          </div>
          <div class=""flex flex-col my-4"">
          <h2 class=""font-medium text-xl"">Adres</h2>
            <p>Adres bilgisi buraya gelecek</p>
          </div>
          <div class=""flex flex-col my-4"">
          <h2 class=""font-medium text-xl"">Web & E-posta</h2>
            <a href=""mailto:""></a>
            <a href=""mailto:"" class=""text-lg text-red-600"">webadress.com</a>
            <a href=""mailto:"" class=""text-lg text-red-600"">mailadres@mail.com</a>
          </div>
      </div>
      <div class=""col-span-12 md:col-span-5 md:relative "">
          <div class=""bg-white px-4 md:p-6 rounded-xl h-max relative md:absolute w-full md:w-[400px] md:-top-");
            WriteLiteral(@"32 md:right-0 drop-shadow-xl"">
            <div class=""gap-2 grid mb-2"">
              <h1 class=""text-xl font-medium"">Bize mesaj gönderin</h1>
              <p class=""text-md font-thin"">Görüşleriniz bizim için değerlidir. Her türlü öneri ve şikayet bildirimleriniz için bize mesaj yolu ile de ulaşabilirsiniz.</p>
            </div>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cfb62794ccbb0cf9a28fdf001c9e1a34a4f221596893", async() => {
                WriteLiteral(@"
                <input type=""text"" name=""fullname"" placeholder=""Ad & Soyad"" class=""border-2 border-zinc-300 p-2 rounded-md"" required>
                <input type=""text"" name=""phone"" placeholder=""Telefon"" class=""border-2 border-zinc-300 p-2 rounded-md"" required>
                <input type=""text"" name=""mail"" placeholder=""E-Posta"" class=""border-2 border-zinc-300 p-2 rounded-md"" required>
                <textarea name=""message""");
                BeginWriteAttribute("id", " id=\"", 2955, "\"", 2960, 0);
                EndWriteAttribute();
                WriteLiteral(@" cols=""30"" rows=""10"" placeholder=""Mesaj"" class=""border-2 border-zinc-300 p-2 rounded-md"" required></textarea>
                <div class="" border-2 border-zinc-300 p-2 rounded-md"">
                  <input type=""checkbox"" name=""accept"" id=""accept"" class=""border-2 border-zinc-300 p-2 rounded-md"" required>
                  <label for=""accept"" class=""text-sm w-full text-zinc-800""><a class=""underline"" href=""http://"">Form gönderme koşullarını</a> ve <a class=""underline"" href=""http://"">KVKK kanunu</a> hakkındaki aydınlatma metnini okudum, onaylıyorum.</label>
                </div>
                <button type=""submit"" class=""bg-red-600 mt-4 hover:bg-zinc-800 transition-all text-white p-2 rounded-md"">Gönder</button>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            <p class=""text-sm text-zinc-500 mt-2"">Yapacağınız form gönderme işleminin herhangi bir resmi bağlayıcılığı yoktur.
              Form aracılığıyla tarafımıza gönderdiğiniz, kişisel bilgiler ve iletişim bilgileriniz sayesinde size talebiniz ile ilgili dönüş sağlanması amaçlanmaktadır.
              Kişisel bilgileriniz kesinlikle üçüncü kişilerle paylaşılmamaktadır.</p>
          </div>
      </div>
    </div>
  </section>
  <!-- Contact End -->
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
