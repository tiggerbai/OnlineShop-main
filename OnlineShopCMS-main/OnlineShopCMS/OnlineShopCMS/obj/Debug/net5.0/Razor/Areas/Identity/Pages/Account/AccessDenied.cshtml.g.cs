#pragma checksum "C:\Users\tigge\Downloads\OnlineShopCMS-Demo-main\OnlineShopCMS-Demo-main\OnlineShopCMS\Areas\Identity\Pages\Account\AccessDenied.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "359bcc5e95dbfe4f823c373bade50460dffec16fbe83f9728bf3e8640ca2ee27"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_AccessDenied), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/AccessDenied.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\tigge\Downloads\OnlineShopCMS-Demo-main\OnlineShopCMS-Demo-main\OnlineShopCMS\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tigge\Downloads\OnlineShopCMS-Demo-main\OnlineShopCMS-Demo-main\OnlineShopCMS\Areas\Identity\Pages\_ViewImports.cshtml"
using OnlineShopCMS.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\tigge\Downloads\OnlineShopCMS-Demo-main\OnlineShopCMS-Demo-main\OnlineShopCMS\Areas\Identity\Pages\_ViewImports.cshtml"
using OnlineShopCMS.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\tigge\Downloads\OnlineShopCMS-Demo-main\OnlineShopCMS-Demo-main\OnlineShopCMS\Areas\Identity\Pages\_ViewImports.cshtml"
using OnlineShopCMS.Areas.Identity.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\tigge\Downloads\OnlineShopCMS-Demo-main\OnlineShopCMS-Demo-main\OnlineShopCMS\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using OnlineShopCMS.Areas.Identity.Pages.Account;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"359bcc5e95dbfe4f823c373bade50460dffec16fbe83f9728bf3e8640ca2ee27", @"/Areas/Identity/Pages/Account/AccessDenied.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"451bfcc06ae17b2ad9759a804c86308917991413be0ea93f1b4cf092b1844571", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"d2a21e0cc152e7046486d3aa124c87773eb4f2d5e4192a8a7558c0c6f2580973", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Identity_Pages_Account_AccessDenied : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\tigge\Downloads\OnlineShopCMS-Demo-main\OnlineShopCMS-Demo-main\OnlineShopCMS\Areas\Identity\Pages\Account\AccessDenied.cshtml"
  
    ViewData["Title"] = "Access denied";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<header>\n    <h1 class=\"text-danger\">");
#nullable restore
#line 8 "C:\Users\tigge\Downloads\OnlineShopCMS-Demo-main\OnlineShopCMS-Demo-main\OnlineShopCMS\Areas\Identity\Pages\Account\AccessDenied.cshtml"
                       Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n    <p class=\"text-danger\">You do not have access to this resource.</p>\n</header>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AccessDeniedModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AccessDeniedModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AccessDeniedModel>)PageContext?.ViewData;
        public AccessDeniedModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591