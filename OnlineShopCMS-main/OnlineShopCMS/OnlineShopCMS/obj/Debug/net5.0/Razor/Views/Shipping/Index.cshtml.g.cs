#pragma checksum "C:\Users\tigge\OneDrive\桌面\新增資料夾\OnlineShopCMS\OnlineShopCMS\OnlineShopCMS\OnlineShopCMS\Views\Shipping\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "07af757bc0fd2db978a002c1a47b1ec67d31fa7f972c8f24f3be5b7978f0b9d8"
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
#line 1 "C:\Users\tigge\OneDrive\桌面\新增資料夾\OnlineShopCMS\OnlineShopCMS\OnlineShopCMS\OnlineShopCMS\Views\_ViewImports.cshtml"
using OnlineShopCMS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tigge\OneDrive\桌面\新增資料夾\OnlineShopCMS\OnlineShopCMS\OnlineShopCMS\OnlineShopCMS\Views\_ViewImports.cshtml"
using OnlineShopCMS.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"07af757bc0fd2db978a002c1a47b1ec67d31fa7f972c8f24f3be5b7978f0b9d8", @"/Views/Shipping/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"889ed1f8af1561721a181c3e6cf1b65a271e913231d74deb9ee0431e7118d1c4", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shipping_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OnlineShopCMS.Models.ShippingMethods>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>物流管理</h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>名稱</th>\r\n            <th>描述</th>\r\n            <!-- 添加其他需要顯示的欄位 -->\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 14 "C:\Users\tigge\OneDrive\桌面\新增資料夾\OnlineShopCMS\OnlineShopCMS\OnlineShopCMS\OnlineShopCMS\Views\Shipping\Index.cshtml"
         foreach (var shippingMethod in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 17 "C:\Users\tigge\OneDrive\桌面\新增資料夾\OnlineShopCMS\OnlineShopCMS\OnlineShopCMS\OnlineShopCMS\Views\Shipping\Index.cshtml"
               Write(shippingMethod.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 18 "C:\Users\tigge\OneDrive\桌面\新增資料夾\OnlineShopCMS\OnlineShopCMS\OnlineShopCMS\OnlineShopCMS\Views\Shipping\Index.cshtml"
               Write(shippingMethod.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <!-- 添加其他需要顯示的欄位 -->\r\n            </tr>\r\n");
#nullable restore
#line 21 "C:\Users\tigge\OneDrive\桌面\新增資料夾\OnlineShopCMS\OnlineShopCMS\OnlineShopCMS\OnlineShopCMS\Views\Shipping\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n</table>\r\n");
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