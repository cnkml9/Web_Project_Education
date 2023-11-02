#pragma checksum "C:\Users\ekind\OneDrive\Masaüstü\egitim\egitim\Areas\Ogrenci\Views\Home\startExam.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79bffef7692479882703ba56ad7b05167629b45b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Ogrenci_Views_Home_startExam), @"mvc.1.0.view", @"/Areas/Ogrenci/Views/Home/startExam.cshtml")]
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
#line 1 "C:\Users\ekind\OneDrive\Masaüstü\egitim\egitim\Areas\Ogrenci\Views\_ViewImports.cshtml"
using egitim;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ekind\OneDrive\Masaüstü\egitim\egitim\Areas\Ogrenci\Views\_ViewImports.cshtml"
using egitim.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79bffef7692479882703ba56ad7b05167629b45b", @"/Areas/Ogrenci/Views/Home/startExam.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c14c9264dec13091842345b9e8ccbfc556c30d2", @"/Areas/Ogrenci/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Ogrenci_Views_Home_startExam : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""auto-container"">
    <!-- Sec Title -->
    <div class=""sec-title"">
        <h4>Sınav Başlat</h4>
    </div>
    <div class=""inner-container"">
        <div class=""col-3"">
            <div class=""form-group"">
                <label>Test Seçiniz</label>
                <select id=""testsec"" class=""custom-select"">
                </select>
            </div>
        </div>
        <button id=""detayKaydet"" class=""btn btn-outline-danger"">Sınavı Başlat</button>
        <!-- Upper Box -->
        <div class=""upper-box"">
            <!-- Question Box -->
            <div class=""question-box"">
                <div id=""row"" class=""row clearfix"">




                </div>
            </div>
        </div>
        <!-- Lower Box -->

    </div>
</div>

<script src=""https://code.jquery.com/jquery-3.6.0.min.js""></script>
<script>
    $(document).ready(function () {
        // Sayfa yüklendiğinde sınavları doldur
        $.ajax({
            url: '/Ogrenci/Home/getTest',
    ");
            WriteLiteral(@"        type: 'GET',
            dataType: 'json',
            success: function (response) {
                // Testleri doldur
                $('#testsec').empty();
                $('#testsec').append('<option value="""">Test Seçiniz</option>'); // Boş seçenek ekle
                $.each(response, function (key, item) {
                    $('#testsec').append('<option value=""' + item.id + '"">' + item.ad + '</option>');
                });
            }
        });
    });
</script>
<script>
    $(document).ready(function () {
        // detayKaydet düğmesine tıklandığında işlemleri gerçekleştir
        $('#detayKaydet').click(function () {
            var testId = $('#testsec').val();

            if (testId === '') {
                alert('Lütfen bir test seçin.');
                return;
            }

            // AJAX isteğini gönder
            $.ajax({
                url: '/Ogrenci/Home/startExamPartial',
                type: 'GET',
                data: { testId: test");
            WriteLiteral(@"Id },
                dataType: 'html',
                success: function (response) {
                    // Dönen kısmi görünümü sayfaya ekle
                    $('#row').html(response);
                },
                error: function (xhr, status, error) {
                    console.log(error);
                }
            });
        });
    });
</script>");
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