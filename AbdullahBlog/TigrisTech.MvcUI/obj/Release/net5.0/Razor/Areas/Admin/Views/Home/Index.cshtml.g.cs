#pragma checksum "D:\TigrisTechSiteler\Sun\Sun\TigrisTech.MvcUI\Areas\Admin\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "831b78c84bb39bbfc6a0856586b2b7fd4dae7197"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Home/Index.cshtml")]
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
#line 1 "D:\TigrisTechSiteler\Sun\Sun\TigrisTech.MvcUI\Areas\Admin\Views\_ViewImports.cshtml"
using TigrisTech.Entities.Concrete.Blog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\TigrisTechSiteler\Sun\Sun\TigrisTech.MvcUI\Areas\Admin\Views\_ViewImports.cshtml"
using TigrisTech.Entities.Concrete.Editor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\TigrisTechSiteler\Sun\Sun\TigrisTech.MvcUI\Areas\Admin\Views\_ViewImports.cshtml"
using TigrisTech.Entities.Concrete.JsonTable;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\TigrisTechSiteler\Sun\Sun\TigrisTech.MvcUI\Areas\Admin\Views\_ViewImports.cshtml"
using TigrisTech.Entities.Concrete.UserTable;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\TigrisTechSiteler\Sun\Sun\TigrisTech.MvcUI\Areas\Admin\Views\_ViewImports.cshtml"
using TigrisTech.Entities.Dtos.Users;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\TigrisTechSiteler\Sun\Sun\TigrisTech.MvcUI\Areas\Admin\Views\_ViewImports.cshtml"
using TigrisTech.Entities.Dtos.Editor.Emails;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\TigrisTechSiteler\Sun\Sun\TigrisTech.MvcUI\Areas\Admin\Views\_ViewImports.cshtml"
using TigrisTech.Entities.Dtos.Editor.Galeries;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\TigrisTechSiteler\Sun\Sun\TigrisTech.MvcUI\Areas\Admin\Views\_ViewImports.cshtml"
using TigrisTech.Entities.Dtos.Editor.Images;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\TigrisTechSiteler\Sun\Sun\TigrisTech.MvcUI\Areas\Admin\Views\_ViewImports.cshtml"
using TigrisTech.Entities.Dtos.Editor.Profils;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\TigrisTechSiteler\Sun\Sun\TigrisTech.MvcUI\Areas\Admin\Views\_ViewImports.cshtml"
using TigrisTech.Entities.Dtos.Editor.Sliders;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\TigrisTechSiteler\Sun\Sun\TigrisTech.MvcUI\Areas\Admin\Views\_ViewImports.cshtml"
using TigrisTech.Entities.Dtos.Blog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\TigrisTechSiteler\Sun\Sun\TigrisTech.MvcUI\Areas\Admin\Views\_ViewImports.cshtml"
using TigrisTech.Shared.Utilities.Results.ComplexTypes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\TigrisTechSiteler\Sun\Sun\TigrisTech.MvcUI\Areas\Admin\Views\_ViewImports.cshtml"
using TigrisTech.Entities.ComplexTypes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\TigrisTechSiteler\Sun\Sun\TigrisTech.MvcUI\Areas\Admin\Views\_ViewImports.cshtml"
using TigrisTech.MvcUI.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\TigrisTechSiteler\Sun\Sun\TigrisTech.MvcUI\Areas\Admin\Views\_ViewImports.cshtml"
using TigrisTech.MvcUI.Areas.Admin.Models.Blogs;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"831b78c84bb39bbfc6a0856586b2b7fd4dae7197", @"/Areas/Admin/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dcdd8594aa3149898ad0675ce80110de6df89611", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DashboardViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Category", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("small-box-footer"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Articles", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Comment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("my-image-table"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/AdminLTE/js/homeIndex.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("application/ecmascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\TigrisTechSiteler\Sun\Sun\TigrisTech.MvcUI\Areas\Admin\Views\Home\Index.cshtml"
  
    Layout = "_Layout";
    ViewBag.Title = "Yönetim Paneli";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<ol class=\"breadcrumb mb-3 mt-3\">\n    <li class=\"breadcrumb-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "831b78c84bb39bbfc6a0856586b2b7fd4dae71979985", async() => {
                WriteLiteral("Admin");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\n    <li class=\"breadcrumb-item active\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "831b78c84bb39bbfc6a0856586b2b7fd4dae719711589", async() => {
                WriteLiteral("Yönetim Paneli");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\n</ol>\n\n<!-- Small boxes (Stat box) -->\n<div class=\"row\">\n    <div class=\"col-lg-3 col-6\">\n        <!-- small box -->\n        <div class=\"small-box bg-info\">\n            <div class=\"inner\">\n                <h3>(");
#nullable restore
#line 18 "D:\TigrisTechSiteler\Sun\Sun\TigrisTech.MvcUI\Areas\Admin\Views\Home\Index.cshtml"
                Write(Model.CategoriesCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</h3>\n\n                <p>Kategoriler</p>\n            </div>\n            <div class=\"icon\">\n                <i class=\"ion ion-bag\"></i>\n            </div>\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "831b78c84bb39bbfc6a0856586b2b7fd4dae719713808", async() => {
                WriteLiteral("Detayları incele <i class=\"fas fa-arrow-circle-right\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        </div>\n    </div>\n    <!-- ./col -->\n    <div class=\"col-lg-3 col-6\">\n        <!-- small box -->\n        <div class=\"small-box bg-success\">\n            <div class=\"inner\">\n                <h3>(");
#nullable restore
#line 33 "D:\TigrisTechSiteler\Sun\Sun\TigrisTech.MvcUI\Areas\Admin\Views\Home\Index.cshtml"
                Write(Model.ArticlesCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(")<sup style=\"font-size: 20px\">%</sup></h3>\n\n                <p>Makaleler</p>\n            </div>\n            <div class=\"icon\">\n                <i class=\"ion ion-stats-bars\"></i>\n            </div>\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "831b78c84bb39bbfc6a0856586b2b7fd4dae719716180", async() => {
                WriteLiteral("Detayları incele <i class=\"fas fa-arrow-circle-right\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        </div>\n    </div>\n    <!-- ./col -->\n    <div class=\"col-lg-3 col-6\">\n        <!-- small box -->\n        <div class=\"small-box bg-warning\">\n            <div class=\"inner\">\n                <h3>(");
#nullable restore
#line 48 "D:\TigrisTechSiteler\Sun\Sun\TigrisTech.MvcUI\Areas\Admin\Views\Home\Index.cshtml"
                Write(Model.UserCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</h3>\n\n                <p>Kullanıcılar</p>\n            </div>\n            <div class=\"icon\">\n                <i class=\"ion ion-person-add\"></i>\n            </div>\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "831b78c84bb39bbfc6a0856586b2b7fd4dae719718513", async() => {
                WriteLiteral("Detayları incele <i class=\"fas fa-arrow-circle-right\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        </div>\n    </div>\n    <!-- ./col -->\n    <div class=\"col-lg-3 col-6\">\n        <!-- small box -->\n        <div class=\"small-box bg-danger\">\n            <div class=\"inner\">\n                <h3>(");
#nullable restore
#line 63 "D:\TigrisTechSiteler\Sun\Sun\TigrisTech.MvcUI\Areas\Admin\Views\Home\Index.cshtml"
                Write(Model.CommentCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</h3>\n\n                <p>Yorumlar</p>\n            </div>\n            <div class=\"icon\">\n                <i class=\"ion ion-pie-graph\"></i>\n            </div>\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "831b78c84bb39bbfc6a0856586b2b7fd4dae719720843", async() => {
                WriteLiteral("Detayları incele <i class=\"fas fa-arrow-circle-right\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
    </div>
    <!-- ./col -->
</div>
<!-- /.row -->
<div class=""row"">
    <div class=""col-xl-12"">
        <div class=""card mb-4"">
            <div class=""card-header"">
                <i class=""fas fa-chart-area me-1""></i>
                En Çok Okunan Makaleler Grafiği
            </div>
            <div class=""card-body""><canvas id=""viewCountChart"" width=""100%"" height=""30""></canvas></div>
        </div>
    </div>
");
            WriteLiteral(@"</div>
<div class=""card mb-4"">
    <div class=""card-header"">
        <i class=""fas fa-table me-1""></i>
        Son Paylaşılan Makaleler
    </div>
    <div class=""card-body"">
        <table class=""table table-hover  table-sm mt-3"" id=""articlesTable"" width=""100%"" cellpadding=""0"">
            <thead>
                <tr>
                    <th>#</th>
                    <th>Kategori</th>
                    <th>Başlık</th>
                    <th>Küçük Resim</th>
                    <th>Tarih</th>
                    <th>Okuma Sayısı</th>
                    <th>Yorum Sayısı</th>
                    <th>Aktif Mi?</th>
                    <th>Silinmiş Mi?</th>
                </tr>
            </thead>          
            <tbody>
");
#nullable restore
#line 117 "D:\TigrisTechSiteler\Sun\Sun\TigrisTech.MvcUI\Areas\Admin\Views\Home\Index.cshtml"
                 foreach (var article in Model.Articles.Articles)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\n                        <td>");
#nullable restore
#line 120 "D:\TigrisTechSiteler\Sun\Sun\TigrisTech.MvcUI\Areas\Admin\Views\Home\Index.cshtml"
                       Write(article.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 121 "D:\TigrisTechSiteler\Sun\Sun\TigrisTech.MvcUI\Areas\Admin\Views\Home\Index.cshtml"
                       Write(article.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 122 "D:\TigrisTechSiteler\Sun\Sun\TigrisTech.MvcUI\Areas\Admin\Views\Home\Index.cshtml"
                       Write(article.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "831b78c84bb39bbfc6a0856586b2b7fd4dae719724947", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4360, "~/img/", 4360, 6, true);
#nullable restore
#line 123 "D:\TigrisTechSiteler\Sun\Sun\TigrisTech.MvcUI\Areas\Admin\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 4366, article.Thumbnail, 4366, 18, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 124 "D:\TigrisTechSiteler\Sun\Sun\TigrisTech.MvcUI\Areas\Admin\Views\Home\Index.cshtml"
                       Write(article.Date.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 125 "D:\TigrisTechSiteler\Sun\Sun\TigrisTech.MvcUI\Areas\Admin\Views\Home\Index.cshtml"
                       Write(article.ViewsCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 126 "D:\TigrisTechSiteler\Sun\Sun\TigrisTech.MvcUI\Areas\Admin\Views\Home\Index.cshtml"
                       Write(article.CommentCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 127 "D:\TigrisTechSiteler\Sun\Sun\TigrisTech.MvcUI\Areas\Admin\Views\Home\Index.cshtml"
                        Write(article.IsActive ? "Evet" : "Hayır");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 128 "D:\TigrisTechSiteler\Sun\Sun\TigrisTech.MvcUI\Areas\Admin\Views\Home\Index.cshtml"
                        Write(article.IsDeleted ? "Evet" : "Hayır");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    </tr>\n");
#nullable restore
#line 130 "D:\TigrisTechSiteler\Sun\Sun\TigrisTech.MvcUI\Areas\Admin\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\n        </table>\n    </div>\n</div>\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "831b78c84bb39bbfc6a0856586b2b7fd4dae719728372", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DashboardViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591