#pragma checksum "C:\Users\tigge\OneDrive\桌面\新增資料夾\OnlineShopCMS\OnlineShopCMS\OnlineShopCMS\OnlineShopCMS\Views\Order\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1f99c64160d9f06a1e5458c973e6eaa20daf28bf541d5f84a087bf820d674672"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Index), @"mvc.1.0.view", @"/Views/Order/Index.cshtml")]
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
#line 1 "C:\Users\tigge\OneDrive\桌面\新增資料夾\OnlineShopCMS\OnlineShopCMS\OnlineShopCMS\OnlineShopCMS\Views\Order\_ViewImports.cshtml"
using OnlineShopCMS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tigge\OneDrive\桌面\新增資料夾\OnlineShopCMS\OnlineShopCMS\OnlineShopCMS\OnlineShopCMS\Views\Order\_ViewImports.cshtml"
using OnlineShopCMS.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\tigge\OneDrive\桌面\新增資料夾\OnlineShopCMS\OnlineShopCMS\OnlineShopCMS\OnlineShopCMS\Views\Order\_ViewImports.cshtml"
using OnlineShopCMS.Controllers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"1f99c64160d9f06a1e5458c973e6eaa20daf28bf541d5f84a087bf820d674672", @"/Views/Order/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"889ed1f8af1561721a181c3e6cf1b65a271e913231d74deb9ee0431e7118d1c4", @"/Views/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"9440b02e89f773e8b5502fc101d61cdecd8b1948bb9f442c8a9abe543c1708b2", @"/Views/Order/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Order_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OnlineShopCMS.Models.Order>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ShipOrder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\tigge\OneDrive\桌面\新增資料夾\OnlineShopCMS\OnlineShopCMS\OnlineShopCMS\OnlineShopCMS\Views\Order\Index.cshtml"
  
    Layout = "_OrderManagLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-xl px-4 mt-n10 position-relative"">
    <div class=""card"" style=""border-radius: 20px"">
        <div class=""card-header"" style=""margin:10px"">
            <div class=""text-center"" style=""margin:20px"">
                <h2 class=""display-6"" style=""border-radius:15px; color:white;background-color:darkblue;padding:20px""> <i class=""fas fa-list-alt""></i> 訂單列表 | Order List</h2>
            </div>
        </div>

        <div class=""card-body"">
            <div class=""table-responsive"">
                <table class=""table table-striped table-hover"">
                    <thead class=""thead-dark"">
                        <tr>
                            <th>訂單日期</th>
                            <th style=""display:none"">User ID</th>
                            <th>User Name</th>
                            <th>Total</th>
                            <th>收件人</th>
                            <th>收件地址</th>
                            <th>收件人聯絡電話</th>
                            <th>付");
            WriteLiteral(@"款狀態</th>
                            <th>發貨狀態</th>
                            <th>訂單詳細資訊</th>
                            <th>訂單狀態</th>
                            <th>操作</th> <!-- 新增 Action 欄位 -->
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 34 "C:\Users\tigge\OneDrive\桌面\新增資料夾\OnlineShopCMS\OnlineShopCMS\OnlineShopCMS\OnlineShopCMS\Views\Order\Index.cshtml"
                         foreach (var order in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 37 "C:\Users\tigge\OneDrive\桌面\新增資料夾\OnlineShopCMS\OnlineShopCMS\OnlineShopCMS\OnlineShopCMS\Views\Order\Index.cshtml"
                                Write(order.OrderDate.HasValue ? order.OrderDate.Value.ToString("yyyy-MM-dd") : "N/A");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td style=\"display:none\">");
#nullable restore
#line 38 "C:\Users\tigge\OneDrive\桌面\新增資料夾\OnlineShopCMS\OnlineShopCMS\OnlineShopCMS\OnlineShopCMS\Views\Order\Index.cshtml"
                                                    Write(order.UserId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 39 "C:\Users\tigge\OneDrive\桌面\新增資料夾\OnlineShopCMS\OnlineShopCMS\OnlineShopCMS\OnlineShopCMS\Views\Order\Index.cshtml"
                               Write(order.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 40 "C:\Users\tigge\OneDrive\桌面\新增資料夾\OnlineShopCMS\OnlineShopCMS\OnlineShopCMS\OnlineShopCMS\Views\Order\Index.cshtml"
                               Write(order.Total.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 41 "C:\Users\tigge\OneDrive\桌面\新增資料夾\OnlineShopCMS\OnlineShopCMS\OnlineShopCMS\OnlineShopCMS\Views\Order\Index.cshtml"
                               Write(order.ReceiverName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 42 "C:\Users\tigge\OneDrive\桌面\新增資料夾\OnlineShopCMS\OnlineShopCMS\OnlineShopCMS\OnlineShopCMS\Views\Order\Index.cshtml"
                               Write(order.ReceiverAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 43 "C:\Users\tigge\OneDrive\桌面\新增資料夾\OnlineShopCMS\OnlineShopCMS\OnlineShopCMS\OnlineShopCMS\Views\Order\Index.cshtml"
                               Write(order.ReceiverPhone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 44 "C:\Users\tigge\OneDrive\桌面\新增資料夾\OnlineShopCMS\OnlineShopCMS\OnlineShopCMS\OnlineShopCMS\Views\Order\Index.cshtml"
                                Write(order.IsPaid ? "Yes" : "No");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 45 "C:\Users\tigge\OneDrive\桌面\新增資料夾\OnlineShopCMS\OnlineShopCMS\OnlineShopCMS\OnlineShopCMS\Views\Order\Index.cshtml"
                                Write(order.IsShipped ? "Yes" : "No");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 2268, "\"", 2329, 1);
#nullable restore
#line 47 "C:\Users\tigge\OneDrive\桌面\新增資料夾\OnlineShopCMS\OnlineShopCMS\OnlineShopCMS\OnlineShopCMS\Views\Order\Index.cshtml"
WriteAttributeValue("", 2275, Url.Action("Details", "Order", new { id = order.Id }), 2275, 54, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info btn-sm\">Details</a>\r\n                                </td>\r\n                                <td>");
#nullable restore
#line 49 "C:\Users\tigge\OneDrive\桌面\新增資料夾\OnlineShopCMS\OnlineShopCMS\OnlineShopCMS\OnlineShopCMS\Views\Order\Index.cshtml"
                               Write(order.OrderStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>\r\n");
#nullable restore
#line 51 "C:\Users\tigge\OneDrive\桌面\新增資料夾\OnlineShopCMS\OnlineShopCMS\OnlineShopCMS\OnlineShopCMS\Views\Order\Index.cshtml"
                                     if (!order.IsShipped) // 檢查訂單是否已出貨
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f99c64160d9f06a1e5458c973e6eaa20daf28bf541d5f84a087bf820d67467211288", async() => {
                WriteLiteral("\r\n                                            <input type=\"hidden\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 2828, "\"", 2845, 1);
#nullable restore
#line 54 "C:\Users\tigge\OneDrive\桌面\新增資料夾\OnlineShopCMS\OnlineShopCMS\OnlineShopCMS\OnlineShopCMS\Views\Order\Index.cshtml"
WriteAttributeValue("", 2836, order.Id, 2836, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /> \r\n\r\n                                            <button type=\"submit\" formmethod=\"post\" class=\"btn btn-success btn-sm\"");
                BeginWriteAttribute("onclick", " onclick=\"", 2968, "\"", 3023, 4);
                WriteAttributeValue("", 2978, "ShowConfirmation(event,", 2978, 23, true);
                WriteAttributeValue(" ", 3001, "\'shipForm-", 3002, 11, true);
#nullable restore
#line 56 "C:\Users\tigge\OneDrive\桌面\新增資料夾\OnlineShopCMS\OnlineShopCMS\OnlineShopCMS\OnlineShopCMS\Views\Order\Index.cshtml"
WriteAttributeValue("", 3012, order.Id, 3012, 9, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3021, "\')", 3021, 2, true);
                EndWriteAttribute();
                WriteLiteral(">Ship</button>\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2672, "shipForm-", 2672, 9, true);
#nullable restore
#line 53 "C:\Users\tigge\OneDrive\桌面\新增資料夾\OnlineShopCMS\OnlineShopCMS\OnlineShopCMS\OnlineShopCMS\Views\Order\Index.cshtml"
AddHtmlAttributeValue("", 2681, order.Id, 2681, 9, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 58 "C:\Users\tigge\OneDrive\桌面\新增資料夾\OnlineShopCMS\OnlineShopCMS\OnlineShopCMS\OnlineShopCMS\Views\Order\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <button type=\"button\" class=\"btn btn-secondary btn-sm\" onclick=\"ShowMessage()\">Shipped</button>\r\n");
#nullable restore
#line 62 "C:\Users\tigge\OneDrive\桌面\新增資料夾\OnlineShopCMS\OnlineShopCMS\OnlineShopCMS\OnlineShopCMS\Views\Order\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 65 "C:\Users\tigge\OneDrive\桌面\新增資料夾\OnlineShopCMS\OnlineShopCMS\OnlineShopCMS\OnlineShopCMS\Views\Order\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        function ShowConfirmation(event, formId) {
            // 阻止表單的默認提交行為
            event.preventDefault();

            Swal.fire({
                title: ""確認出貨"",
                text: ""請確認已完成訂單核對，送出即無法修改，確認執行出貨程序?"",
                icon: ""warning"",
                showCancelButton: true,
                confirmButtonText: ""確認"",
                cancelButtonText: ""取消""
            }).then((result) => {
                if (result.isConfirmed) {
                    // 如果使用者確認出貨，則提交表單
                    $.ajax({
                        type: 'POST',
                        url: $('#' + formId).attr('action'),
                        data: $('#' + formId).serialize(),
                        success: function () {
                            Swal.fire({
                                title: ""出貨成功"",
                                text: ""訂單已出貨"",
                                icon: ""success"",
                                timer: 5000
                            }).");
                WriteLiteral(@"then(() => {
                                location.reload(); // 重新載入頁面
                            });
                        }
                    });
                }
            });
        }
    </script>

  
    <script src=""https://cdn.jsdelivr.net/npm/sweetalert2@10""></script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OnlineShopCMS.Models.Order>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591