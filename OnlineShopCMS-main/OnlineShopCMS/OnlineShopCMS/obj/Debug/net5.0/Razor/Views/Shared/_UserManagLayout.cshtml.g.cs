#pragma checksum "C:\Users\tigge\Downloads\OnlineShop-main-master (1)\OnlineShop-main-master\OnlineShopCMS-main\OnlineShopCMS\OnlineShopCMS\Views\Shared\_UserManagLayout.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "363d5129801814004c2fd412ff9c88faaec141ddf83e44a6af9d3c0cde96c307"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__UserManagLayout), @"mvc.1.0.view", @"/Views/Shared/_UserManagLayout.cshtml")]
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
#line 1 "C:\Users\tigge\Downloads\OnlineShop-main-master (1)\OnlineShop-main-master\OnlineShopCMS-main\OnlineShopCMS\OnlineShopCMS\Views\Shared\_UserManagLayout.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tigge\Downloads\OnlineShop-main-master (1)\OnlineShop-main-master\OnlineShopCMS-main\OnlineShopCMS\OnlineShopCMS\Views\Shared\_UserManagLayout.cshtml"
using OnlineShopCMS.Areas.Identity.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"363d5129801814004c2fd412ff9c88faaec141ddf83e44a6af9d3c0cde96c307", @"/Views/Shared/_UserManagLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"889ed1f8af1561721a181c3e6cf1b65a271e913231d74deb9ee0431e7118d1c4", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__UserManagLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline me-auto d-none d-lg-block me-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_LoginPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline me-auto w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Privacy", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-fixed"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<!DOCTYPE html>\n<html lang=\"en\">\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "363d5129801814004c2fd412ff9c88faaec141ddf83e44a6af9d3c0cde96c3077099", async() => {
                WriteLiteral("\n    <meta charset=\"utf-8\" />\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\" />\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\" />\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 429, "\"", 439, 0);
                EndWriteAttribute();
                WriteLiteral(" />\n    <meta name=\"author\"");
                BeginWriteAttribute("content", " content=\"", 467, "\"", 477, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
    
    <link href=""https://cdn.jsdelivr.net/npm/simple-datatables@7.1.2/dist/style.min.css"" rel=""stylesheet"" />
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.4/css/all.min.css"" integrity=""sha512-XXX"" crossorigin=""anonymous"" />

    <link");
                BeginWriteAttribute("href", " href=\"", 765, "\"", 804, 1);
#nullable restore
#line 18 "C:\Users\tigge\Downloads\OnlineShop-main-master (1)\OnlineShop-main-master\OnlineShopCMS-main\OnlineShopCMS\OnlineShopCMS\Views\Shared\_UserManagLayout.cshtml"
WriteAttributeValue("", 772, Url.Content("~/css/styles.css"), 772, 32, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\" />\n    <link rel=\"icon\" type=\"image/x-icon\"");
                BeginWriteAttribute("href", " href=\"", 866, "\"", 913, 1);
#nullable restore
#line 19 "C:\Users\tigge\Downloads\OnlineShop-main-master (1)\OnlineShop-main-master\OnlineShopCMS-main\OnlineShopCMS\OnlineShopCMS\Views\Shared\_UserManagLayout.cshtml"
WriteAttributeValue("", 873, Url.Content("~/assets/img/favicon.png"), 873, 40, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
    <script data-search-pseudo-elements defer src=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.3.0/js/all.min.js"" crossorigin=""anonymous""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/feather-icons/4.29.0/feather.min.js"" crossorigin=""anonymous""></script>
    <link");
                BeginWriteAttribute("href", " href=\"", 1212, "\"", 1250, 1);
#nullable restore
#line 22 "C:\Users\tigge\Downloads\OnlineShop-main-master (1)\OnlineShop-main-master\OnlineShopCMS-main\OnlineShopCMS\OnlineShopCMS\Views\Shared\_UserManagLayout.cshtml"
WriteAttributeValue("", 1219, Url.Content("~/css/admin.css"), 1219, 31, false);

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "363d5129801814004c2fd412ff9c88faaec141ddf83e44a6af9d3c0cde96c30710772", async() => {
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
                BeginWriteAttribute("src", " src=\"", 2184, "\"", 2228, 1);
#nullable restore
#line 40 "C:\Users\tigge\Downloads\OnlineShop-main-master (1)\OnlineShop-main-master\OnlineShopCMS-main\OnlineShopCMS\OnlineShopCMS\Views\Shared\_UserManagLayout.cshtml"
WriteAttributeValue("", 2190, Url.Content("~/assets/img/logo5.jpg"), 2190, 38, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"SB Admin Pro Logo\" style=\"width:160px; height:60px;\">\n        </a>\n\n        <!-- Navbar Search Input-->\n        <!-- * * Note: * * Visible only on and above the lg breakpoint-->\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "363d5129801814004c2fd412ff9c88faaec141ddf83e44a6af9d3c0cde96c30712625", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "363d5129801814004c2fd412ff9c88faaec141ddf83e44a6af9d3c0cde96c30714505", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "363d5129801814004c2fd412ff9c88faaec141ddf83e44a6af9d3c0cde96c30716076", async() => {
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
                BeginWriteAttribute("href", " href=\"", 4289, "\"", 4332, 1);
#nullable restore
#line 86 "C:\Users\tigge\Downloads\OnlineShop-main-master (1)\OnlineShop-main-master\OnlineShopCMS-main\OnlineShopCMS\OnlineShopCMS\Views\Shared\_UserManagLayout.cshtml"
WriteAttributeValue("", 4296, Url.ActionLink("Dashboard", "Home"), 4296, 36, false);

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
                BeginWriteAttribute("href", " href=\"", 4769, "\"", 4824, 1);
#nullable restore
#line 96 "C:\Users\tigge\Downloads\OnlineShop-main-master (1)\OnlineShop-main-master\OnlineShopCMS-main\OnlineShopCMS\OnlineShopCMS\Views\Shared\_UserManagLayout.cshtml"
WriteAttributeValue("", 4776, Url.Action("Index", "Order", new { area = "" }), 4776, 48, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"nav-link\"><i class=\"fas fa-list\"></i> 訂單列表</a></li>\n                        <li><a");
                BeginWriteAttribute("href", " href=\"", 4915, "\"", 4970, 1);
#nullable restore
#line 97 "C:\Users\tigge\Downloads\OnlineShop-main-master (1)\OnlineShop-main-master\OnlineShopCMS-main\OnlineShopCMS\OnlineShopCMS\Views\Shared\_UserManagLayout.cshtml"
WriteAttributeValue("", 4922, Url.Action("Index", "Order", new { area = "" }), 4922, 48, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"nav-link\"><i class=\"fas fa-chart-line\"></i> 我的銷售</a></li>\n                        <li><a");
                BeginWriteAttribute("href", " href=\"", 5067, "\"", 5122, 1);
#nullable restore
#line 98 "C:\Users\tigge\Downloads\OnlineShop-main-master (1)\OnlineShop-main-master\OnlineShopCMS-main\OnlineShopCMS\OnlineShopCMS\Views\Shared\_UserManagLayout.cshtml"
WriteAttributeValue("", 5074, Url.Action("Index", "Order", new { area = "" }), 5074, 48, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"nav-link\"><i class=\"fas fa-truck\"></i> 批次出貨</a></li>\n                        <li><a");
                BeginWriteAttribute("href", " href=\"", 5214, "\"", 5269, 1);
#nullable restore
#line 99 "C:\Users\tigge\Downloads\OnlineShop-main-master (1)\OnlineShop-main-master\OnlineShopCMS-main\OnlineShopCMS\OnlineShopCMS\Views\Shared\_UserManagLayout.cshtml"
WriteAttributeValue("", 5221, Url.Action("Index", "Order", new { area = "" }), 5221, 48, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"nav-link\"><i class=\"fas fa-times\"></i>未成立訂單</a></li>\n                        <li><a");
                BeginWriteAttribute("href", " href=\"", 5361, "\"", 5416, 1);
#nullable restore
#line 100 "C:\Users\tigge\Downloads\OnlineShop-main-master (1)\OnlineShop-main-master\OnlineShopCMS-main\OnlineShopCMS\OnlineShopCMS\Views\Shared\_UserManagLayout.cshtml"
WriteAttributeValue("", 5368, Url.Action("Index", "Order", new { area = "" }), 5368, 48, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"nav-link\"><i class=\"fas fa-undo\"></i> 退貨/退款</a></li>\n                        <li><a");
                BeginWriteAttribute("href", " href=\"", 5508, "\"", 5563, 1);
#nullable restore
#line 101 "C:\Users\tigge\Downloads\OnlineShop-main-master (1)\OnlineShop-main-master\OnlineShopCMS-main\OnlineShopCMS\OnlineShopCMS\Views\Shared\_UserManagLayout.cshtml"
WriteAttributeValue("", 5515, Url.Action("Index", "Order", new { area = "" }), 5515, 48, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"nav-link\"><i class=\"fas fa-truck\"></i> 物流設定</a></li>\n\n                        <!-- Sidenav Menu Heading (Management)-->\n                        <div class=\"sidenav-menu-heading\">產品管理</div>\n\n                        <li><a");
                BeginWriteAttribute("href", " href=\"", 5792, "\"", 5850, 1);
#nullable restore
#line 106 "C:\Users\tigge\Downloads\OnlineShop-main-master (1)\OnlineShop-main-master\OnlineShopCMS-main\OnlineShopCMS\OnlineShopCMS\Views\Shared\_UserManagLayout.cshtml"
WriteAttributeValue("", 5799, Url.Action("Index", "Products", new { area = "" }), 5799, 51, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"nav-link\"><i class=\"fas fa-list\"></i> 產品列表</a></li>\n                        <li><a");
                BeginWriteAttribute("href", " href=\"", 5941, "\"", 6000, 1);
#nullable restore
#line 107 "C:\Users\tigge\Downloads\OnlineShop-main-master (1)\OnlineShop-main-master\OnlineShopCMS-main\OnlineShopCMS\OnlineShopCMS\Views\Shared\_UserManagLayout.cshtml"
WriteAttributeValue("", 5948, Url.Action("Create", "Products", new { area = "" }), 5948, 52, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"nav-link\"><i class=\"fas fa-plus\"></i> 產品上架</a></li>\n                        <li><a");
                BeginWriteAttribute("href", " href=\"", 6091, "\"", 6158, 1);
#nullable restore
#line 108 "C:\Users\tigge\Downloads\OnlineShop-main-master (1)\OnlineShop-main-master\OnlineShopCMS-main\OnlineShopCMS\OnlineShopCMS\Views\Shared\_UserManagLayout.cshtml"
WriteAttributeValue("", 6098, Url.Action("ListCategories", "Products", new { area = "" }), 6098, 60, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"nav-link\"><i class=\"fas fa-tags\"></i> 產品類別</a></li>\n                        <li><a");
                BeginWriteAttribute("href", " href=\"", 6249, "\"", 6316, 1);
#nullable restore
#line 109 "C:\Users\tigge\Downloads\OnlineShop-main-master (1)\OnlineShop-main-master\OnlineShopCMS-main\OnlineShopCMS\OnlineShopCMS\Views\Shared\_UserManagLayout.cshtml"
WriteAttributeValue("", 6256, Url.Action("CreateCategory", "Products", new { area = "" }), 6256, 60, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"nav-link\"><i class=\"fas fa-tag\"></i> 新增產品類別</a></li>\n\n                        <!-- Sidenav Menu Heading (Management)-->\n                        <div class=\"sidenav-menu-heading\">使用者管理</div>\n\n                        <li><a");
                BeginWriteAttribute("href", " href=\"", 6546, "\"", 6605, 1);
#nullable restore
#line 114 "C:\Users\tigge\Downloads\OnlineShop-main-master (1)\OnlineShop-main-master\OnlineShopCMS-main\OnlineShopCMS\OnlineShopCMS\Views\Shared\_UserManagLayout.cshtml"
WriteAttributeValue("", 6553, Url.Action("ListUsers", "Users", new { area = "" }), 6553, 52, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"nav-link\"><i class=\"fas fa-users\"></i> 帳戶列表</a></li>\n                        <li><a");
                BeginWriteAttribute("href", " href=\"", 6697, "\"", 6764, 1);
#nullable restore
#line 115 "C:\Users\tigge\Downloads\OnlineShop-main-master (1)\OnlineShop-main-master\OnlineShopCMS-main\OnlineShopCMS\OnlineShopCMS\Views\Shared\_UserManagLayout.cshtml"
WriteAttributeValue("", 6704, Url.Action("ListAdministrator", "Users", new { area = "" }), 6704, 60, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"nav-link\"><i class=\"fas fa-users\"></i> 管理人員列表</a></li>\n                        <li><a");
                BeginWriteAttribute("href", " href=\"", 6858, "\"", 6914, 1);
#nullable restore
#line 116 "C:\Users\tigge\Downloads\OnlineShop-main-master (1)\OnlineShop-main-master\OnlineShopCMS-main\OnlineShopCMS\OnlineShopCMS\Views\Shared\_UserManagLayout.cshtml"
WriteAttributeValue("", 6865, Url.Action("Create", "Users", new { area = "" }), 6865, 49, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"nav-link\"><i class=\"fas fa-user-plus\"></i>新增管理人員</a></li>\n\n                        <!-- Sidenav Menu Heading (Management)-->\n                        <div class=\"sidenav-menu-heading\">權限管理</div>\n\n                        <li><a");
                BeginWriteAttribute("href", " href=\"", 7148, "\"", 7207, 1);
#nullable restore
#line 121 "C:\Users\tigge\Downloads\OnlineShop-main-master (1)\OnlineShop-main-master\OnlineShopCMS-main\OnlineShopCMS\OnlineShopCMS\Views\Shared\_UserManagLayout.cshtml"
WriteAttributeValue("", 7155, Url.Action("ListRoles", "Users", new { area = "" }), 7155, 52, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"nav-link\"><i class=\"fas fa-user-cog\"></i> 角色/權限列表</a></li>\n                        <li><a");
                BeginWriteAttribute("href", " href=\"", 7305, "\"", 7365, 1);
#nullable restore
#line 122 "C:\Users\tigge\Downloads\OnlineShop-main-master (1)\OnlineShop-main-master\OnlineShopCMS-main\OnlineShopCMS\OnlineShopCMS\Views\Shared\_UserManagLayout.cshtml"
WriteAttributeValue("", 7312, Url.Action("CreateRole", "Users", new { area = "" }), 7312, 53, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"nav-link\"><i class=\"fas fa-cogs\"></i> 新增角色及權限</a></li>\n\n                        <li><a");
                BeginWriteAttribute("href", " href=\"", 7460, "\"", 7517, 1);
#nullable restore
#line 124 "C:\Users\tigge\Downloads\OnlineShop-main-master (1)\OnlineShop-main-master\OnlineShopCMS-main\OnlineShopCMS\OnlineShopCMS\Views\Shared\_UserManagLayout.cshtml"
WriteAttributeValue("", 7467, Url.Action("Settings", "Home", new { area = "" }), 7467, 50, false);

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
                </div>
                <!-- Sidenav Footer-->
                <div class=""sidenav-footer"">
                    <div class=""sidenav-footer-content"">
                        <div class=""sidenav-footer-subtitle"">Logged in as:</div>
                        <div class=""sidenav-footer-title"">Valerie Luna</div>
                    </div>
                </div>
            </nav>
        </div>
        <div id=""layoutSidenav_content"">
            <main>
                <header class=""page-header page-header-dark bg-gradient-primary-to-secondary pb-10"">
                    <div class=""container-xl px-4"">
                        <div class=");
                WriteLiteral(@"""page-header-content pt-4"">
                            <div class=""row align-items-center justify-content-between"">
                                <div class=""col-auto mt-4"">
                                    <h1 class=""page-header-title"">
                                        <div class=""page-header-icon""><i data-feather=""activity""></i></div>
                                        Hello ");
#nullable restore
#line 159 "C:\Users\tigge\Downloads\OnlineShop-main-master (1)\OnlineShop-main-master\OnlineShopCMS-main\OnlineShopCMS\OnlineShopCMS\Views\Shared\_UserManagLayout.cshtml"
                                         Write(UserManager.GetUserAsync(User).Result.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"!歡迎來到使用者及權限管理中心
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
#line 168 "C:\Users\tigge\Downloads\OnlineShop-main-master (1)\OnlineShop-main-master\OnlineShopCMS-main\OnlineShopCMS\OnlineShopCMS\Views\Shared\_UserManagLayout.cshtml"
           Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </main>\n            <footer class=\"footer-admin mt-auto footer-light\">\n                <div class=\"container-xl px-4\">\n                    <div class=\"container\">\n                        &copy; 2024 - OnlineShop - ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "363d5129801814004c2fd412ff9c88faaec141ddf83e44a6af9d3c0cde96c30731949", async() => {
                    WriteLiteral("Privacy");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                    </div>\n                </div>\n            </footer>\n        </div>\n    </div>\n    ");
#nullable restore
#line 179 "C:\Users\tigge\Downloads\OnlineShop-main-master (1)\OnlineShop-main-master\OnlineShopCMS-main\OnlineShopCMS\OnlineShopCMS\Views\Shared\_UserManagLayout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n    ");
#nullable restore
#line 180 "C:\Users\tigge\Downloads\OnlineShop-main-master (1)\OnlineShop-main-master\OnlineShopCMS-main\OnlineShopCMS\OnlineShopCMS\Views\Shared\_UserManagLayout.cshtml"
Write(RenderSection("editScripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n    <script src=\"https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/js/bootstrap.bundle.min.js\" crossorigin=\"anonymous\"></script>\n    <script");
                BeginWriteAttribute("src", " src=\"", 10026, "\"", 10085, 1);
#nullable restore
#line 182 "C:\Users\tigge\Downloads\OnlineShop-main-master (1)\OnlineShop-main-master\OnlineShopCMS-main\OnlineShopCMS\OnlineShopCMS\Views\Shared\_UserManagLayout.cshtml"
WriteAttributeValue("", 10032, Url.Content("~/lib/ckeditor5/build/ckeditor.js.map"), 10032, 53, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\n\n    <script");
                BeginWriteAttribute("src", " src=\"", 10109, "\"", 10164, 1);
#nullable restore
#line 184 "C:\Users\tigge\Downloads\OnlineShop-main-master (1)\OnlineShop-main-master\OnlineShopCMS-main\OnlineShopCMS\OnlineShopCMS\Views\Shared\_UserManagLayout.cshtml"
WriteAttributeValue("", 10115, Url.Content("~/lib/ckeditor5/build/ckeditor.js"), 10115, 49, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\n    <script");
                BeginWriteAttribute("src", " src=\"", 10187, "\"", 10224, 1);
#nullable restore
#line 185 "C:\Users\tigge\Downloads\OnlineShop-main-master (1)\OnlineShop-main-master\OnlineShopCMS-main\OnlineShopCMS\OnlineShopCMS\Views\Shared\_UserManagLayout.cshtml"
WriteAttributeValue("", 10193, Url.Content("~/js/scripts.js"), 10193, 31, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\n    <script src=\"https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.9.4/Chart.min.js\" crossorigin=\"anonymous\"></script>\n\n    <script");
                BeginWriteAttribute("src", " src=\"", 10367, "\"", 10421, 1);
#nullable restore
#line 188 "C:\Users\tigge\Downloads\OnlineShop-main-master (1)\OnlineShop-main-master\OnlineShopCMS-main\OnlineShopCMS\OnlineShopCMS\Views\Shared\_UserManagLayout.cshtml"
WriteAttributeValue("", 10373, Url.Content("~/assets/demo/chart-area-demo.js"), 10373, 48, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\n    <script");
                BeginWriteAttribute("src", " src=\"", 10444, "\"", 10497, 1);
#nullable restore
#line 189 "C:\Users\tigge\Downloads\OnlineShop-main-master (1)\OnlineShop-main-master\OnlineShopCMS-main\OnlineShopCMS\OnlineShopCMS\Views\Shared\_UserManagLayout.cshtml"
WriteAttributeValue("", 10450, Url.Content("~/assets/demo/chart-pie-demo.js"), 10450, 47, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\n    <script src=\"https://cdn.jsdelivr.net/npm/simple-datatables@7.1.2/dist/umd/simple-datatables.min.js\" crossorigin=\"anonymous\"></script>\n    <script");
                BeginWriteAttribute("src", " src=\"", 10659, "\"", 10722, 1);
#nullable restore
#line 191 "C:\Users\tigge\Downloads\OnlineShop-main-master (1)\OnlineShop-main-master\OnlineShopCMS-main\OnlineShopCMS\OnlineShopCMS\Views\Shared\_UserManagLayout.cshtml"
WriteAttributeValue("", 10665, Url.Content("~/js/datatables/datatables-simple-demo.js"), 10665, 57, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
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
