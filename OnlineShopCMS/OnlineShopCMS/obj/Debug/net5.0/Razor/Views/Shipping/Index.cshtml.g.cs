#pragma checksum "C:\Users\tigge\Downloads\OnlineShop-main-master (1)\OnlineShop-main-master\OnlineShopCMS-main\OnlineShopCMS\OnlineShopCMS\Views\Shipping\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2ba0c15ffe27a408d39d9c88447b8f65d07b546e0facb479ffa56277bc2ae2db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shipping_Index), @"mvc.1.0.view", @"/Views/Shipping/Index.cshtml")]
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
#line 1 "C:\Users\tigge\Downloads\OnlineShop-main-master (1)\OnlineShop-main-master\OnlineShopCMS-main\OnlineShopCMS\OnlineShopCMS\Views\_ViewImports.cshtml"
using OnlineShopCMS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tigge\Downloads\OnlineShop-main-master (1)\OnlineShop-main-master\OnlineShopCMS-main\OnlineShopCMS\OnlineShopCMS\Views\_ViewImports.cshtml"
using OnlineShopCMS.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"2ba0c15ffe27a408d39d9c88447b8f65d07b546e0facb479ffa56277bc2ae2db", @"/Views/Shipping/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"889ed1f8af1561721a181c3e6cf1b65a271e913231d74deb9ee0431e7118d1c4", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shipping_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OnlineShopCMS.Models.ShippingMethods>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<h1>物流管理</h1>\n\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>名稱</th>\n            <th>描述</th>\n            <!-- 添加其他需要顯示的欄位 -->\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 14 "C:\Users\tigge\Downloads\OnlineShop-main-master (1)\OnlineShop-main-master\OnlineShopCMS-main\OnlineShopCMS\OnlineShopCMS\Views\Shipping\Index.cshtml"
         foreach (var shippingMethod in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>");
#nullable restore
#line 17 "C:\Users\tigge\Downloads\OnlineShop-main-master (1)\OnlineShop-main-master\OnlineShopCMS-main\OnlineShopCMS\OnlineShopCMS\Views\Shipping\Index.cshtml"
               Write(shippingMethod.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 18 "C:\Users\tigge\Downloads\OnlineShop-main-master (1)\OnlineShop-main-master\OnlineShopCMS-main\OnlineShopCMS\OnlineShopCMS\Views\Shipping\Index.cshtml"
               Write(shippingMethod.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <!-- 添加其他需要顯示的欄位 -->\n            </tr>\n");
#nullable restore
#line 21 "C:\Users\tigge\Downloads\OnlineShop-main-master (1)\OnlineShop-main-master\OnlineShopCMS-main\OnlineShopCMS\OnlineShopCMS\Views\Shipping\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </tbody>\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OnlineShopCMS.Models.ShippingMethods>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
