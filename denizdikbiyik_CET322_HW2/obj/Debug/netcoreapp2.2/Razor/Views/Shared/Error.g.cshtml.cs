#pragma checksum "C:\Users\Deniz\Desktop\HW4\denizdikbiyik_CET322_HW2\Views\Shared\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79a25abf2741b0e63e788886b559927a5e8ecbf9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Error), @"mvc.1.0.view", @"/Views/Shared/Error.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Error.cshtml", typeof(AspNetCore.Views_Shared_Error))]
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
#line 1 "C:\Users\Deniz\Desktop\HW4\denizdikbiyik_CET322_HW2\Views\_ViewImports.cshtml"
using denizdikbiyik_CET322_HW2;

#line default
#line hidden
#line 2 "C:\Users\Deniz\Desktop\HW4\denizdikbiyik_CET322_HW2\Views\_ViewImports.cshtml"
using denizdikbiyik_CET322_HW2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79a25abf2741b0e63e788886b559927a5e8ecbf9", @"/Views/Shared/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a424e2aadde9a2992fa45b537eff4607f6189bb", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ErrorViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Deniz\Desktop\HW4\denizdikbiyik_CET322_HW2\Views\Shared\Error.cshtml"
  
    ViewData["Title"] = "Error";

#line default
#line hidden
            BeginContext(64, 388, true);
            WriteLiteral(@"<link rel=""stylesheet"" href=""//cdnjs.cloudflare.com/ajax/libs/jodit/3.1.92/jodit.min.css"">
<script src=""//cdnjs.cloudflare.com/ajax/libs/jodit/3.1.92/jodit.min.js""></script>

<section class=""ab-info-main py-md-5"">
    <div class=""container py-md-3"">

        <h1 class=""text-danger"">Hata.</h1>
        <h2 class=""text-danger"">İsteğiniz gerçekleştirilirken bir hata oluştu.</h2>

");
            EndContext();
#line 14 "C:\Users\Deniz\Desktop\HW4\denizdikbiyik_CET322_HW2\Views\Shared\Error.cshtml"
         if (Model.ShowRequestId)
        {

#line default
#line hidden
            BeginContext(498, 66, true);
            WriteLiteral("            <p>\r\n                <strong>İstek No:</strong> <code>");
            EndContext();
            BeginContext(565, 15, false);
#line 17 "C:\Users\Deniz\Desktop\HW4\denizdikbiyik_CET322_HW2\Views\Shared\Error.cshtml"
                                            Write(Model.RequestId);

#line default
#line hidden
            EndContext();
            BeginContext(580, 27, true);
            WriteLiteral("</code>\r\n            </p>\r\n");
            EndContext();
#line 19 "C:\Users\Deniz\Desktop\HW4\denizdikbiyik_CET322_HW2\Views\Shared\Error.cshtml"
        }

#line default
#line hidden
            BeginContext(618, 680, true);
            WriteLiteral(@"
        <h3>Geliştirme Modu</h3>
        <p>
            Swapping to <strong>Development</strong> environment will display more detailed information about the error that occurred.
        </p>
        <p>
            <strong>The Development environment shouldn't be enabled for deployed applications.</strong>
            It can result in displaying sensitive information from exceptions to end users.
            For local debugging, enable the <strong>Development</strong> environment by setting the <strong>ASPNETCORE_ENVIRONMENT</strong> environment variable to <strong>Development</strong>
            and restarting the app.
        </p>
    </div>
</section>
");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1316, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 34 "C:\Users\Deniz\Desktop\HW4\denizdikbiyik_CET322_HW2\Views\Shared\Error.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
                BeginContext(1386, 74, true);
                WriteLiteral("    <script>\r\n        var editor = new Jodit(\'#Content\');\r\n    </script>\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ErrorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
