#pragma checksum "C:\Users\tigge\Downloads\OnlineShop-main-master (1)\OnlineShop-main-master\OnlineShopCMS-main\OnlineShopCMS\OnlineShopCMS\Views\Shared\_AdminLayout.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "a0a35c47d1a81cba5db8ef50fa43a38425a5624659bec1ce2102e3c200cd4a78"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__AdminLayout), @"mvc.1.0.view", @"/Views/Shared/_AdminLayout.cshtml")]
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
#nullable restore
#line 1 "C:\Users\tigge\Downloads\OnlineShop-main-master (1)\OnlineShop-main-master\OnlineShopCMS-main\OnlineShopCMS\OnlineShopCMS\Views\Shared\_AdminLayout.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tigge\Downloads\OnlineShop-main-master (1)\OnlineShop-main-master\OnlineShopCMS-main\OnlineShopCMS\OnlineShopCMS\Views\Shared\_AdminLayout.cshtml"
using OnlineShopCMS.Areas.Identity.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"a0a35c47d1a81cba5db8ef50fa43a38425a5624659bec1ce2102e3c200cd4a78", @"/Views/Shared/_AdminLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"889ed1f8af1561721a181c3e6cf1b65a271e913231d74deb9ee0431e7118d1c4", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__AdminLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline me-auto d-none d-lg-block me-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_LoginPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline me-auto w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-fixed"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\tigge\Downloads\OnlineShop-main-master (1)\OnlineShop-main-master\OnlineShopCMS-main\OnlineShopCMS\OnlineShopCMS\Views\Shared\_AdminLayout.cshtml"
  
    var userName = User.Identity.Name;
    ViewData["UserName"] = userName;   

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<!DOCTYPE html>\n<html lang=\"en\">\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0a35c47d1a81cba5db8ef50fa43a38425a5624659bec1ce2102e3c200cd4a786358", async() => {
                WriteLiteral("\n    <meta charset=\"utf-8\" />\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\" />\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\" />\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 513, "\"", 523, 0);
                EndWriteAttribute();
                WriteLiteral(" />\n    <meta name=\"author\"");
                BeginWriteAttribute("content", " content=\"", 551, "\"", 561, 0);
                EndWriteAttribute();
                WriteLiteral(" />\n    <title>Dashboard - SB Admin Pro</title>\n    <link href=\"https://cdn.jsdelivr.net/npm/simple-datatables@7.1.2/dist/style.min.css\" rel=\"stylesheet\" />\n    <link");
                BeginWriteAttribute("href", " href=\"", 728, "\"", 767, 1);
#nullable restore
#line 20 "C:\Users\tigge\Downloads\OnlineShop-main-master (1)\OnlineShop-main-master\OnlineShopCMS-main\OnlineShopCMS\OnlineShopCMS\Views\Shared\_AdminLayout.cshtml"
WriteAttributeValue("", 735, Url.Content("~/css/styles.css"), 735, 32, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\" />\n    <link rel=\"icon\" type=\"image/x-icon\"");
                BeginWriteAttribute("href", " href=\"", 829, "\"", 876, 1);
#nullable restore
#line 21 "C:\Users\tigge\Downloads\OnlineShop-main-master (1)\OnlineShop-main-master\OnlineShopCMS-main\OnlineShopCMS\OnlineShopCMS\Views\Shared\_AdminLayout.cshtml"
WriteAttributeValue("", 836, Url.Content("~/assets/img/favicon.png"), 836, 40, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
    <script data-search-pseudo-elements defer src=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.3.0/js/all.min.js"" crossorigin=""anonymous""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/feather-icons/4.29.0/feather.min.js"" crossorigin=""anonymous""></script>
    <link");
                BeginWriteAttribute("href", " href=\"", 1175, "\"", 1213, 1);
#nullable restore
#line 24 "C:\Users\tigge\Downloads\OnlineShop-main-master (1)\OnlineShop-main-master\OnlineShopCMS-main\OnlineShopCMS\OnlineShopCMS\Views\Shared\_AdminLayout.cshtml"
WriteAttributeValue("", 1182, Url.Content("~/css/admin.css"), 1182, 31, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\" />\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0a35c47d1a81cba5db8ef50fa43a38425a5624659bec1ce2102e3c200cd4a789892", async() => {
                WriteLiteral(@"
    <nav class=""navbar-items-container topnav navbar navbar-expand shadow justify-content-between justify-content-sm-start navbar-light bg-white"" id=""sidenavAccordion"">
        <style>
            /* site.css */
            .navbar-items-container {
                margin-right: 1rem; /* Or any other appropriate value */
            }

        </style>
        <!-- Sidenav Toggle Button-->
        <button class=""btn btn-icon btn-transparent-dark order-1 order-lg-0 me-2 ms-lg-2 me-lg-0"" id=""sidebarToggle""><i data-feather=""menu""></i></button>
        <!-- Navbar Brand-->
        <!-- * * Tip * * You can use text or an image for your navbar brand.-->
        <!-- * * * * * * When using an image, we recommend the SVG format.-->
        <!-- * * * * * * Dimensions: Maximum height: 32px, maximum width: 240px-->
        <a class=""navbar-brand"" href=""Index"">
            <img");
                BeginWriteAttribute("src", " src=\"", 2147, "\"", 2191, 1);
#nullable restore
#line 42 "C:\Users\tigge\Downloads\OnlineShop-main-master (1)\OnlineShop-main-master\OnlineShopCMS-main\OnlineShopCMS\OnlineShopCMS\Views\Shared\_AdminLayout.cshtml"
WriteAttributeValue("", 2153, Url.Content("~/assets/img/logo5.jpg"), 2153, 38, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"SB Admin Pro Logo\" style=\"width:160px; height:60px;\">\n        </a>\n\n        <!-- Navbar Search Input-->\n        <!-- * * Note: * * Visible only on and above the lg breakpoint-->\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0a35c47d1a81cba5db8ef50fa43a38425a5624659bec1ce2102e3c200cd4a7811740", async() => {
                    WriteLiteral(@"
            <div class=""input-group input-group-joined input-group-solid"">
                <input class=""form-control pe-0"" type=""search"" placeholder=""Search"" aria-label=""Search"" />
                <div class=""input-group-text""><i data-feather=""search""></i></div>
            </div>
        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n        <!-- Navbar Items-->\n\n        <div class=\"navbar-items-container\" style=\"margin-right: 1rem;\">\n            <!-- Adjust the margin as needed -->\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a0a35c47d1a81cba5db8ef50fa43a38425a5624659bec1ce2102e3c200cd4a7813620", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
        </div>
        <li class=""nav-item dropdown no-caret me-3 d-lg-none"">
            <a class=""btn btn-icon btn-transparent-dark dropdown"" id=""navbarSearch"" data-bs-toggle=""dropdown"" aria-label=""Search""><i data-feather=""search""></i></a>
            <!-- Dropdown - Search-->
            <div class=""dropdown-menu dropdown-menu-end p-3"">
                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0a35c47d1a81cba5db8ef50fa43a38425a5624659bec1ce2102e3c200cd4a7815191", async() => {
                    WriteLiteral(@"
                    <div class=""input-group input-group-joined input-group-solid"">
                        <input class=""form-control pe-0"" type=""search"" placeholder=""Search"" aria-label=""Search"" />
                        <div class=""input-group-text""><i data-feather=""search""></i></div>
                    </div>
                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
            </div>


        </li>
    </nav>


    <div id=""layoutSidenav"">
        <div id=""layoutSidenav_nav"">
            <nav class=""sidenav shadow-right sidenav-light"">
                <div class=""sidenav-menu"">
                    <script>

                    </script>
                    <div class=""nav accordion"" id=""accordionSidenav"">
                        <!-- Sidenav Menu Heading (Core)-->
                        <div class=""sidenav-menu-heading"">核心</div>
                        <!-- Sidenav Link (Dashboard)-->

                        <a class=""nav-link""");
                BeginWriteAttribute("href", " href=\"", 4252, "\"", 4295, 1);
#nullable restore
#line 88 "C:\Users\tigge\Downloads\OnlineShop-main-master (1)\OnlineShop-main-master\OnlineShopCMS-main\OnlineShopCMS\OnlineShopCMS\Views\Shared\_AdminLayout.cshtml"
WriteAttributeValue("", 4259, Url.ActionLink("Dashboard", "Home"), 4259, 36, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                            <div class=""nav-link-icon""><i data-feather=""activity""></i></div>
                            儀表板
                        </a>

                        <!-- Sidenav Menu Heading (Management)-->
                        <div class=""sidenav-menu-heading"">訂單管理</div>
                        <!-- Sidenav Link (Orders)-->
                        <!-- Sidenav Dropdown (Orders) -->

                        <li><a");
                BeginWriteAttribute("href", " href=\"", 4732, "\"", 4787, 1);
#nullable restore
#line 98 "C:\Users\tigge\Downloads\OnlineShop-main-master (1)\OnlineShop-main-master\OnlineShopCMS-main\OnlineShopCMS\OnlineShopCMS\Views\Shared\_AdminLayout.cshtml"
WriteAttributeValue("", 4739, Url.Action("Index", "Order", new { area = "" }), 4739, 48, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"nav-link\"><i class=\"fas fa-list\"></i> 訂單列表</a></li>\n                        <li><a");
                BeginWriteAttribute("href", " href=\"", 4878, "\"", 4933, 1);
#nullable restore
#line 99 "C:\Users\tigge\Downloads\OnlineShop-main-master (1)\OnlineShop-main-master\OnlineShopCMS-main\OnlineShopCMS\OnlineShopCMS\Views\Shared\_AdminLayout.cshtml"
WriteAttributeValue("", 4885, Url.Action("Index", "Order", new { area = "" }), 4885, 48, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"nav-link\"><i class=\"fas fa-chart-line\"></i> 我的銷售</a></li>\n                        <li><a");
                BeginWriteAttribute("href", " href=\"", 5030, "\"", 5085, 1);
#nullable restore
#line 100 "C:\Users\tigge\Downloads\OnlineShop-main-master (1)\OnlineShop-main-master\OnlineShopCMS-main\OnlineShopCMS\OnlineShopCMS\Views\Shared\_AdminLayout.cshtml"
WriteAttributeValue("", 5037, Url.Action("Index", "Order", new { area = "" }), 5037, 48, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"nav-link\"><i class=\"fas fa-truck\"></i> 批次出貨</a></li>\n                        <li><a");
                BeginWriteAttribute("href", " href=\"", 5177, "\"", 5232, 1);
#nullable restore
#line 101 "C:\Users\tigge\Downloads\OnlineShop-main-master (1)\OnlineShop-main-master\OnlineShopCMS-main\OnlineShopCMS\OnlineShopCMS\Views\Shared\_AdminLayout.cshtml"
WriteAttributeValue("", 5184, Url.Action("Index", "Order", new { area = "" }), 5184, 48, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"nav-link\"><i class=\"fas fa-times\"></i> 不成立</a></li>\n                        <li><a");
                BeginWriteAttribute("href", " href=\"", 5323, "\"", 5378, 1);
#nullable restore
#line 102 "C:\Users\tigge\Downloads\OnlineShop-main-master (1)\OnlineShop-main-master\OnlineShopCMS-main\OnlineShopCMS\OnlineShopCMS\Views\Shared\_AdminLayout.cshtml"
WriteAttributeValue("", 5330, Url.Action("Index", "Order", new { area = "" }), 5330, 48, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"nav-link\"><i class=\"fas fa-undo\"></i> 退貨/退款</a></li>\n                        <li><a");
                BeginWriteAttribute("href", " href=\"", 5470, "\"", 5525, 1);
#nullable restore
#line 103 "C:\Users\tigge\Downloads\OnlineShop-main-master (1)\OnlineShop-main-master\OnlineShopCMS-main\OnlineShopCMS\OnlineShopCMS\Views\Shared\_AdminLayout.cshtml"
WriteAttributeValue("", 5477, Url.Action("Index", "Order", new { area = "" }), 5477, 48, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"nav-link\"><i class=\"fas fa-truck\"></i> 物流設定</a></li>\n\n                        <!-- Sidenav Menu Heading (Management)-->\n                        <div class=\"sidenav-menu-heading\">產品管理</div>\n\n                        <li><a");
                BeginWriteAttribute("href", " href=\"", 5754, "\"", 5812, 1);
#nullable restore
#line 108 "C:\Users\tigge\Downloads\OnlineShop-main-master (1)\OnlineShop-main-master\OnlineShopCMS-main\OnlineShopCMS\OnlineShopCMS\Views\Shared\_AdminLayout.cshtml"
WriteAttributeValue("", 5761, Url.Action("Index", "Products", new { area = "" }), 5761, 51, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"nav-link\"><i class=\"fas fa-list\"></i> 產品列表</a></li>\n                        <li><a");
                BeginWriteAttribute("href", " href=\"", 5903, "\"", 5962, 1);
#nullable restore
#line 109 "C:\Users\tigge\Downloads\OnlineShop-main-master (1)\OnlineShop-main-master\OnlineShopCMS-main\OnlineShopCMS\OnlineShopCMS\Views\Shared\_AdminLayout.cshtml"
WriteAttributeValue("", 5910, Url.Action("Create", "Products", new { area = "" }), 5910, 52, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"nav-link\"><i class=\"fas fa-plus\"></i> 產品上架</a></li>\n                        <li><a");
                BeginWriteAttribute("href", " href=\"", 6053, "\"", 6120, 1);
#nullable restore
#line 110 "C:\Users\tigge\Downloads\OnlineShop-main-master (1)\OnlineShop-main-master\OnlineShopCMS-main\OnlineShopCMS\OnlineShopCMS\Views\Shared\_AdminLayout.cshtml"
WriteAttributeValue("", 6060, Url.Action("ListCategories", "Products", new { area = "" }), 6060, 60, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"nav-link\"><i class=\"fas fa-tags\"></i> 產品類別</a></li>\n                        <li><a");
                BeginWriteAttribute("href", " href=\"", 6211, "\"", 6278, 1);
#nullable restore
#line 111 "C:\Users\tigge\Downloads\OnlineShop-main-master (1)\OnlineShop-main-master\OnlineShopCMS-main\OnlineShopCMS\OnlineShopCMS\Views\Shared\_AdminLayout.cshtml"
WriteAttributeValue("", 6218, Url.Action("CreateCategory", "Products", new { area = "" }), 6218, 60, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"nav-link\"><i class=\"fas fa-tag\"></i> 新增產品類別</a></li>\n\n                        <!-- Sidenav Menu Heading (Management)-->\n                        <div class=\"sidenav-menu-heading\">使用者管理</div>\n\n                        <li><a");
                BeginWriteAttribute("href", " href=\"", 6508, "\"", 6567, 1);
#nullable restore
#line 116 "C:\Users\tigge\Downloads\OnlineShop-main-master (1)\OnlineShop-main-master\OnlineShopCMS-main\OnlineShopCMS\OnlineShopCMS\Views\Shared\_AdminLayout.cshtml"
WriteAttributeValue("", 6515, Url.Action("ListUsers", "Users", new { area = "" }), 6515, 52, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"nav-link\"><i class=\"fas fa-users\"></i> 帳戶列表</a></li>\n                        <li><a");
                BeginWriteAttribute("href", " href=\"", 6659, "\"", 6726, 1);
#nullable restore
#line 117 "C:\Users\tigge\Downloads\OnlineShop-main-master (1)\OnlineShop-main-master\OnlineShopCMS-main\OnlineShopCMS\OnlineShopCMS\Views\Shared\_AdminLayout.cshtml"
WriteAttributeValue("", 6666, Url.Action("ListAdministrator", "Users", new { area = "" }), 6666, 60, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"nav-link\"><i class=\"fas fa-users\"></i> 管理人員列表</a></li>\n                        <li><a");
                BeginWriteAttribute("href", " href=\"", 6820, "\"", 6876, 1);
#nullable restore
#line 118 "C:\Users\tigge\Downloads\OnlineShop-main-master (1)\OnlineShop-main-master\OnlineShopCMS-main\OnlineShopCMS\OnlineShopCMS\Views\Shared\_AdminLayout.cshtml"
WriteAttributeValue("", 6827, Url.Action("Create", "Users", new { area = "" }), 6827, 49, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"nav-link\"><i class=\"fas fa-user-plus\"></i>新增管理人員</a></li>\n\n                        <!-- Sidenav Menu Heading (Management)-->\n                        <div class=\"sidenav-menu-heading\">權限管理</div>\n\n                        <li><a");
                BeginWriteAttribute("href", " href=\"", 7110, "\"", 7169, 1);
#nullable restore
#line 123 "C:\Users\tigge\Downloads\OnlineShop-main-master (1)\OnlineShop-main-master\OnlineShopCMS-main\OnlineShopCMS\OnlineShopCMS\Views\Shared\_AdminLayout.cshtml"
WriteAttributeValue("", 7117, Url.Action("ListRoles", "Users", new { area = "" }), 7117, 52, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"nav-link\"><i class=\"fas fa-user-cog\"></i> 角色/權限列表</a></li>\n                        <li><a");
                BeginWriteAttribute("href", " href=\"", 7267, "\"", 7327, 1);
#nullable restore
#line 124 "C:\Users\tigge\Downloads\OnlineShop-main-master (1)\OnlineShop-main-master\OnlineShopCMS-main\OnlineShopCMS\OnlineShopCMS\Views\Shared\_AdminLayout.cshtml"
WriteAttributeValue("", 7274, Url.Action("CreateRole", "Users", new { area = "" }), 7274, 53, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"nav-link\"><i class=\"fas fa-cogs\"></i> 新增角色及權限</a></li>\n\n                        <li><a");
                BeginWriteAttribute("href", " href=\"", 7422, "\"", 7479, 1);
#nullable restore
#line 126 "C:\Users\tigge\Downloads\OnlineShop-main-master (1)\OnlineShop-main-master\OnlineShopCMS-main\OnlineShopCMS\OnlineShopCMS\Views\Shared\_AdminLayout.cshtml"
WriteAttributeValue("", 7429, Url.Action("Settings", "Home", new { area = "" }), 7429, 50, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""nav-link""><i class=""fas fa-cog""></i> 設定</a></li>









                        <!-- Sidenav Link (Settings)-->
                        <a class=""nav-link"" href=""settings.html"">
                            <div class=""nav-link-icon""><i data-feather=""settings""></i></div>
                            系統設置
                        </a>
                    </div>
                </div>                <!-- Sidenav Footer-->
                <div class=""sidenav-footer"">
                    <div class=""sidenav-footer-content"">
                        <div class=""sidenav-footer-subtitle"">Logged in as: </div>
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a0a35c47d1a81cba5db8ef50fa43a38425a5624659bec1ce2102e3c200cd4a7828842", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        <div class=""sidenav-footer-title"">Valerie Luna</div>
                    </div>
                </div>
            </nav>
        </div>
        <div id=""layoutSidenav_content"">
            <main>
                <header class=""page-header page-header-dark bg-gradient-primary-to-secondary pb-10"">
                    <div class=""container-xl px-4"">
                        <div class=""page-header-content pt-4"">
                            <div class=""row align-items-center justify-content-between"">
                                <div class=""col-auto mt-4"">
                                    <h1 class=""page-header-title"">
                                        <div class=""page-header-icon""><i data-feather=""activity""></i></div>
                                        Hello ");
#nullable restore
#line 161 "C:\Users\tigge\Downloads\OnlineShop-main-master (1)\OnlineShop-main-master\OnlineShopCMS-main\OnlineShopCMS\OnlineShopCMS\Views\Shared\_AdminLayout.cshtml"
                                         Write(UserManager.GetUserAsync(User).Result.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"!歡迎進入後台儀表板!

                                    </h1>
                                    <div class=""page-header-subtitle"">Example dashboard overview and content summary</div>
                                </div>
                            </div>
                        </div>
                    </div>
                </header>
                <!-- Main page content-->
                ");
#nullable restore
#line 171 "C:\Users\tigge\Downloads\OnlineShop-main-master (1)\OnlineShop-main-master\OnlineShopCMS-main\OnlineShopCMS\OnlineShopCMS\Views\Shared\_AdminLayout.cshtml"
           Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
            </main>
            <footer class=""footer-admin mt-auto footer-light"">
                <div class=""container-xl px-4"">
                    <div class=""row"">
                        <div class=""col-md-6 small"">Copyright &copy; Your Website 2024</div>
                        <div class=""col-md-6 text-md-end small"">
                            <a href=""#!"">Privacy Policy</a>
                            &middot;
                            <a href=""#!"">Terms &amp; Conditions</a>
                        </div>
                    </div>
                </div>
            </footer>
        </div>
    </div>
    ");
#nullable restore
#line 187 "C:\Users\tigge\Downloads\OnlineShop-main-master (1)\OnlineShop-main-master\OnlineShopCMS-main\OnlineShopCMS\OnlineShopCMS\Views\Shared\_AdminLayout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n    ");
#nullable restore
#line 188 "C:\Users\tigge\Downloads\OnlineShop-main-master (1)\OnlineShop-main-master\OnlineShopCMS-main\OnlineShopCMS\OnlineShopCMS\Views\Shared\_AdminLayout.cshtml"
Write(RenderSection("editScripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n    <script src=\"https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/js/bootstrap.bundle.min.js\" crossorigin=\"anonymous\"></script>\n    <script");
                BeginWriteAttribute("src", " src=\"", 10269, "\"", 10328, 1);
#nullable restore
#line 190 "C:\Users\tigge\Downloads\OnlineShop-main-master (1)\OnlineShop-main-master\OnlineShopCMS-main\OnlineShopCMS\OnlineShopCMS\Views\Shared\_AdminLayout.cshtml"
WriteAttributeValue("", 10275, Url.Content("~/lib/ckeditor5/build/ckeditor.js.map"), 10275, 53, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\n\n    <script");
                BeginWriteAttribute("src", " src=\"", 10352, "\"", 10407, 1);
#nullable restore
#line 192 "C:\Users\tigge\Downloads\OnlineShop-main-master (1)\OnlineShop-main-master\OnlineShopCMS-main\OnlineShopCMS\OnlineShopCMS\Views\Shared\_AdminLayout.cshtml"
WriteAttributeValue("", 10358, Url.Content("~/lib/ckeditor5/build/ckeditor.js"), 10358, 49, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\n    <script");
                BeginWriteAttribute("src", " src=\"", 10430, "\"", 10467, 1);
#nullable restore
#line 193 "C:\Users\tigge\Downloads\OnlineShop-main-master (1)\OnlineShop-main-master\OnlineShopCMS-main\OnlineShopCMS\OnlineShopCMS\Views\Shared\_AdminLayout.cshtml"
WriteAttributeValue("", 10436, Url.Content("~/js/scripts.js"), 10436, 31, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\n    <script src=\"https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.9.4/Chart.min.js\" crossorigin=\"anonymous\"></script>\n\n    <script");
                BeginWriteAttribute("src", " src=\"", 10610, "\"", 10664, 1);
#nullable restore
#line 196 "C:\Users\tigge\Downloads\OnlineShop-main-master (1)\OnlineShop-main-master\OnlineShopCMS-main\OnlineShopCMS\OnlineShopCMS\Views\Shared\_AdminLayout.cshtml"
WriteAttributeValue("", 10616, Url.Content("~/assets/demo/chart-area-demo.js"), 10616, 48, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\n    <script");
                BeginWriteAttribute("src", " src=\"", 10687, "\"", 10740, 1);
#nullable restore
#line 197 "C:\Users\tigge\Downloads\OnlineShop-main-master (1)\OnlineShop-main-master\OnlineShopCMS-main\OnlineShopCMS\OnlineShopCMS\Views\Shared\_AdminLayout.cshtml"
WriteAttributeValue("", 10693, Url.Content("~/assets/demo/chart-pie-demo.js"), 10693, 47, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\n    <script src=\"https://cdn.jsdelivr.net/npm/simple-datatables@7.1.2/dist/umd/simple-datatables.min.js\" crossorigin=\"anonymous\"></script>\n    <script");
                BeginWriteAttribute("src", " src=\"", 10902, "\"", 10965, 1);
#nullable restore
#line 199 "C:\Users\tigge\Downloads\OnlineShop-main-master (1)\OnlineShop-main-master\OnlineShopCMS-main\OnlineShopCMS\OnlineShopCMS\Views\Shared\_AdminLayout.cshtml"
WriteAttributeValue("", 10908, Url.Content("~/js/datatables/datatables-simple-demo.js"), 10908, 57, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n</html>\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<OnlineShopUser> UserManager { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<OnlineShopUser> SignInManager { get; private set; } = default!;
        #nullable disable
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
