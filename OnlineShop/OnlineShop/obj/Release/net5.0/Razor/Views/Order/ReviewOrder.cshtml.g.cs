#pragma checksum "C:\Users\tigge\Downloads\OnlineShop\OnlineShop\OnlineShop\Views\Order\ReviewOrder.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "11b38202915cf8ee1c0db01d0f562c632b3ae4ce6d64b951a8dffc2f2617abd9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_ReviewOrder), @"mvc.1.0.view", @"/Views/Order/ReviewOrder.cshtml")]
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
#line 1 "C:\Users\tigge\Downloads\OnlineShop\OnlineShop\OnlineShop\Views\_ViewImports.cshtml"
using OnlineShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tigge\Downloads\OnlineShop\OnlineShop\OnlineShop\Views\_ViewImports.cshtml"
using OnlineShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"11b38202915cf8ee1c0db01d0f562c632b3ae4ce6d64b951a8dffc2f2617abd9", @"/Views/Order/ReviewOrder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"a874db409d8a73e2ac1fdbeb6779cdf1c4c62cc22f2012edef9e5226e66e5e66", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Order_ReviewOrder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OnlineShop.Models.Order>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\tigge\Downloads\OnlineShop\OnlineShop\OnlineShop\Views\Order\ReviewOrder.cshtml"
  
    ViewData["Title"] = "ReviewOrder";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div>
    <p>　</p>
    <ul class=""progressbar"">
        <li class=""active"">購物車</li>
        <li class=""active"">訂單資料</li>
        <li class=""active"">建立訂單</li>
        <li>付款</li>
    </ul>
    <p>　</p>
    <p>　</p>
</div>

<div class=""text-center"">
    <p></p>
    <h4>訂單建立成功</h4>
    <p></p>
</div>

<div class=""card shadow-sm rounded"">
    <div class=""card-body"">

        <h5>訂單編號：");
#nullable restore
#line 29 "C:\Users\tigge\Downloads\OnlineShop\OnlineShop\OnlineShop\Views\Order\ReviewOrder.cshtml"
            Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n        <div class=\"row\">\n            <div class=\"col\"><p class=\"text-muted\">");
#nullable restore
#line 31 "C:\Users\tigge\Downloads\OnlineShop\OnlineShop\OnlineShop\Views\Order\ReviewOrder.cshtml"
                                              Write(Html.DisplayFor(model => model.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></div>\n            <div class=\"col text-right\"><p class=\"text-muted\">");
#nullable restore
#line 32 "C:\Users\tigge\Downloads\OnlineShop\OnlineShop\OnlineShop\Views\Order\ReviewOrder.cshtml"
                                                         Write(Html.DisplayFor(model => model.OrderDate));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p></div>
        </div>
        
        <div>
            <table class=""table"">
                <thead>
                    <tr>
                        <th>商品名稱</th>
                        <th>數量</th>
                        <th>小計</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 45 "C:\Users\tigge\Downloads\OnlineShop\OnlineShop\OnlineShop\Views\Order\ReviewOrder.cshtml"
                     foreach (var item in ViewBag.orderItems)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\n                            <td>");
#nullable restore
#line 48 "C:\Users\tigge\Downloads\OnlineShop\OnlineShop\OnlineShop\Views\Order\ReviewOrder.cshtml"
                           Write(item.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 49 "C:\Users\tigge\Downloads\OnlineShop\OnlineShop\OnlineShop\Views\Order\ReviewOrder.cshtml"
                           Write(item.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 50 "C:\Users\tigge\Downloads\OnlineShop\OnlineShop\OnlineShop\Views\Order\ReviewOrder.cshtml"
                           Write(item.SubTotal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        </tr>\n");
#nullable restore
#line 52 "C:\Users\tigge\Downloads\OnlineShop\OnlineShop\OnlineShop\Views\Order\ReviewOrder.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\n            </table>\n            <div class=\"text-right pr-5\">\n                <p style=\"padding-right:12px\">總計： $");
#nullable restore
#line 56 "C:\Users\tigge\Downloads\OnlineShop\OnlineShop\OnlineShop\Views\Order\ReviewOrder.cshtml"
                                              Write(Html.DisplayFor(model => model.Total));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n            </div>\n        </div>\n        <hr />\n        <div class=\"row\">\n            <div class=\"col-7\">\n                <p>收貨人姓名：");
#nullable restore
#line 62 "C:\Users\tigge\Downloads\OnlineShop\OnlineShop\OnlineShop\Views\Order\ReviewOrder.cshtml"
                    Write(Html.DisplayFor(model => model.ReceiverName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                <p>收貨人電話：");
#nullable restore
#line 63 "C:\Users\tigge\Downloads\OnlineShop\OnlineShop\OnlineShop\Views\Order\ReviewOrder.cshtml"
                    Write(Html.DisplayFor(model => model.ReceiverPhone));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                <p>收貨人地址：");
#nullable restore
#line 64 "C:\Users\tigge\Downloads\OnlineShop\OnlineShop\OnlineShop\Views\Order\ReviewOrder.cshtml"
                    Write(Html.DisplayFor(model => model.ReceiverAdress));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n            </div>\n            <div class=\"col-5\">\n                <p>\n                    訂單狀態：\n");
#nullable restore
#line 69 "C:\Users\tigge\Downloads\OnlineShop\OnlineShop\OnlineShop\Views\Order\ReviewOrder.cshtml"
                     if (@Model.isPaid)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span>已付款</span>\n");
#nullable restore
#line 72 "C:\Users\tigge\Downloads\OnlineShop\OnlineShop\OnlineShop\Views\Order\ReviewOrder.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span>未付款</span>\n");
#nullable restore
#line 76 "C:\Users\tigge\Downloads\OnlineShop\OnlineShop\OnlineShop\Views\Order\ReviewOrder.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </p>
                <div class=""row"">
                    <p class=""col-3"">立即付款：</p>
                    <div class=""col-9"">
                        <div class=""w-75"" id=""payment-button""></div>
                    </div>
                </div>
            </div>
        </div>

    </div>
</div>
<p></p>

<script src=""https://www.paypal.com/sdk/js?client-id=AROOEAjq-CEdjN74SU6zEGiQIc-1CKe_Cloaeuudb9ZCZZeAF3dVdqkeqO4fhFOM035egHsnUlK86pk1&currency=TWD""></script>
<script>
    paypal.Buttons({
        style: {
            shape: 'rect',
            size: 'small',
        },
        createOrder: function (data, actions) {
            return actions.order.create({
                purchase_units: [{
                    amount: {
                        value: ");
#nullable restore
#line 102 "C:\Users\tigge\Downloads\OnlineShop\OnlineShop\OnlineShop\Views\Order\ReviewOrder.cshtml"
                          Write(Model.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral(",\n                        currency_code: \'TWD\',\n                        breakdown: {\n                            item_total: { value: ");
#nullable restore
#line 105 "C:\Users\tigge\Downloads\OnlineShop\OnlineShop\OnlineShop\Views\Order\ReviewOrder.cshtml"
                                            Write(Model.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral(", currency_code: \'TWD\' }\n                        }\n                    },\n                    items: [\n");
#nullable restore
#line 109 "C:\Users\tigge\Downloads\OnlineShop\OnlineShop\OnlineShop\Views\Order\ReviewOrder.cshtml"
                         foreach (var item in ViewBag.orderItems)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            WriteLiteral("{ name:\'");
#nullable restore
#line 111 "C:\Users\tigge\Downloads\OnlineShop\OnlineShop\OnlineShop\Views\Order\ReviewOrder.cshtml"
                                 Write(item.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\', unit_amount: { value:\'");
#nullable restore
#line 111 "C:\Users\tigge\Downloads\OnlineShop\OnlineShop\OnlineShop\Views\Order\ReviewOrder.cshtml"
                                                                            Write(item.SubTotal);

#line default
#line hidden
#nullable disable
            WriteLiteral("\', currency_code: \'TWD\' }, quantity:\'");
#nullable restore
#line 111 "C:\Users\tigge\Downloads\OnlineShop\OnlineShop\OnlineShop\Views\Order\ReviewOrder.cshtml"
                                                                                                                               Write(item.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\' },\n");
#nullable restore
#line 112 "C:\Users\tigge\Downloads\OnlineShop\OnlineShop\OnlineShop\Views\Order\ReviewOrder.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    ]
                }]
            });
        },
        onApprove: function (data, actions) {
            return actions.order.capture().then(function (details) {
                console.log(details),
                window.location.replace(""/order/payment/?Id=");
#nullable restore
#line 120 "C:\Users\tigge\Downloads\OnlineShop\OnlineShop\OnlineShop\Views\Order\ReviewOrder.cshtml"
                                                       Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("&isSuccess=true\");\n            })\n        },\n        onCancel: function (data) {\n            window.location.replace(\"/order/payment/?Id=");
#nullable restore
#line 124 "C:\Users\tigge\Downloads\OnlineShop\OnlineShop\OnlineShop\Views\Order\ReviewOrder.cshtml"
                                                   Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"&isSussess=false"");
        }
    }).render('#payment-button')
</script>


<style>

    .progressbar {
        counter-reset: step;
    }

        .progressbar li {
            list-style-type: none;
            width: 25%;
            float: left;
            font-size: 12px;
            position: relative;
            text-align: center;
            text-transform: uppercase;
            color: #7d7d7d;
        }

            .progressbar li:before {
                width: 30px;
                height: 30px;
                content: counter(step);
                counter-increment: step;
                line-height: 30px;
                border: 2px solid #7d7d7d;
                display: block;
                text-align: center;
                margin: 0 auto 10px auto;
                border-radius: 50%;
                background-color: white;
            }

            .progressbar li:after {
                width: 100%;
                height: 2px;
                content: '';
                position");
            WriteLiteral(@": absolute;
                background-color: #7d7d7d;
                top: 15px;
                left: -50%;
                z-index: -1;
            }

            .progressbar li:first-child:after {
                content: none;
            }

            .progressbar li.active {
                color: green;
            }

                .progressbar li.active:before {
                    border-color: #55b776;
                }

                .progressbar li.active + li:after {
                    background-color: #55b776;
                }
</style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OnlineShop.Models.Order> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591