#pragma checksum "C:\Users\Abdul\OneDrive\Masaüstü\AbdullahBlog\TigrisTech.MvcUI\Areas\Admin\Views\Category\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6c9e991f2d471eb9eb7f3e146a73969f9971fc7fde6db86c923f8b26e724f632"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Category_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Category/Index.cshtml")]
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
#line 1 "C:\Users\Abdul\OneDrive\Masaüstü\AbdullahBlog\TigrisTech.MvcUI\Areas\Admin\Views\_ViewImports.cshtml"
using TigrisTech.Entities.Concrete.Blog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Abdul\OneDrive\Masaüstü\AbdullahBlog\TigrisTech.MvcUI\Areas\Admin\Views\_ViewImports.cshtml"
using TigrisTech.Entities.Concrete.Editor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Abdul\OneDrive\Masaüstü\AbdullahBlog\TigrisTech.MvcUI\Areas\Admin\Views\_ViewImports.cshtml"
using TigrisTech.Entities.Concrete.JsonTable;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Abdul\OneDrive\Masaüstü\AbdullahBlog\TigrisTech.MvcUI\Areas\Admin\Views\_ViewImports.cshtml"
using TigrisTech.Entities.Concrete.UserTable;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Abdul\OneDrive\Masaüstü\AbdullahBlog\TigrisTech.MvcUI\Areas\Admin\Views\_ViewImports.cshtml"
using TigrisTech.Entities.Dtos.Users;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Abdul\OneDrive\Masaüstü\AbdullahBlog\TigrisTech.MvcUI\Areas\Admin\Views\_ViewImports.cshtml"
using TigrisTech.Entities.Dtos.Editor.Emails;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Abdul\OneDrive\Masaüstü\AbdullahBlog\TigrisTech.MvcUI\Areas\Admin\Views\_ViewImports.cshtml"
using TigrisTech.Entities.Dtos.Editor.Galeries;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Abdul\OneDrive\Masaüstü\AbdullahBlog\TigrisTech.MvcUI\Areas\Admin\Views\_ViewImports.cshtml"
using TigrisTech.Entities.Dtos.Editor.Images;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Abdul\OneDrive\Masaüstü\AbdullahBlog\TigrisTech.MvcUI\Areas\Admin\Views\_ViewImports.cshtml"
using TigrisTech.Entities.Dtos.Editor.Profils;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Abdul\OneDrive\Masaüstü\AbdullahBlog\TigrisTech.MvcUI\Areas\Admin\Views\_ViewImports.cshtml"
using TigrisTech.Entities.Dtos.Editor.Sliders;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Abdul\OneDrive\Masaüstü\AbdullahBlog\TigrisTech.MvcUI\Areas\Admin\Views\_ViewImports.cshtml"
using TigrisTech.Entities.Dtos.Blog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Abdul\OneDrive\Masaüstü\AbdullahBlog\TigrisTech.MvcUI\Areas\Admin\Views\_ViewImports.cshtml"
using TigrisTech.Shared.Utilities.Results.ComplexTypes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Abdul\OneDrive\Masaüstü\AbdullahBlog\TigrisTech.MvcUI\Areas\Admin\Views\_ViewImports.cshtml"
using TigrisTech.Entities.ComplexTypes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Abdul\OneDrive\Masaüstü\AbdullahBlog\TigrisTech.MvcUI\Areas\Admin\Views\_ViewImports.cshtml"
using TigrisTech.MvcUI.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Abdul\OneDrive\Masaüstü\AbdullahBlog\TigrisTech.MvcUI\Areas\Admin\Views\_ViewImports.cshtml"
using TigrisTech.MvcUI.Areas.Admin.Models.Blogs;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"6c9e991f2d471eb9eb7f3e146a73969f9971fc7fde6db86c923f8b26e724f632", @"/Areas/Admin/Views/Category/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"bd2b9581a650e246d44afdd6e415fbc078ffc6f05d3829ca3adebf6dc1ada283", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CategoryListDto>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Category", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("alert-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/AdminLTE/js/categoryIndex.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("application/ecmascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Abdul\OneDrive\Masaüstü\AbdullahBlog\TigrisTech.MvcUI\Areas\Admin\Views\Category\Index.cshtml"
  
    Layout = "_Layout";
    ViewBag.Title = "Kategoriler Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("<ol class=\"breadcrumb mb-3 mt-2\">\n    <li class=\"breadcrumb-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c9e991f2d471eb9eb7f3e146a73969f9971fc7fde6db86c923f8b26e724f6329188", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c9e991f2d471eb9eb7f3e146a73969f9971fc7fde6db86c923f8b26e724f63210816", async() => {
                WriteLiteral("Kategoriler");
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
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\n</ol>\n");
#nullable restore
#line 11 "C:\Users\Abdul\OneDrive\Masaüstü\AbdullahBlog\TigrisTech.MvcUI\Areas\Admin\Views\Category\Index.cshtml"
 if (Model.ResultStatus == ResultStatus.Success)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div id=""modalPlaceHolder"" aria-hidden=""true""></div>
    <div class=""card mb-4 mt-2"">
 
        <div class=""card-body"">
            <div class=""spinner-border"" role=""status"" style=""display: none;"">
                <span class=""sr-only"">Yükleniyor...</span>
            </div>
            <div class=""table-responsive"">
                <table class=""table table-hover  table-sm mt-3"" id=""categoriesTable"" width=""100%"" cellspacing=""0"">
                    <thead>
                    <tr >
                        <th>ID</th>
                        <th>Adı</th>
                        <th>Açıklaması</th>
                        <th>Aktif Mi?</th>
                        <th>Silinmiş Mi?</th>                    
                        <th>Oluşturulma Tarihi</th>
                        <th>Oluşturan Kullanıcı Adı</th>
                        <th>Son Düzenlenme Tarihi</th>
                        <th>Son Düzenleyen Kullanıcı Adı</th>
                        <th>İşlemler</th>
                    </tr>
            ");
            WriteLiteral("        </thead>\n                   \n                    <tbody>\n");
#nullable restore
#line 38 "C:\Users\Abdul\OneDrive\Masaüstü\AbdullahBlog\TigrisTech.MvcUI\Areas\Admin\Views\Category\Index.cshtml"
                     foreach (var category in Model.Categories)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr");
            BeginWriteAttribute("name", " name=\"", 1620, "\"", 1639, 1);
#nullable restore
#line 40 "C:\Users\Abdul\OneDrive\Masaüstü\AbdullahBlog\TigrisTech.MvcUI\Areas\Admin\Views\Category\Index.cshtml"
WriteAttributeValue("", 1627, category.Id, 1627, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                            <td>");
#nullable restore
#line 41 "C:\Users\Abdul\OneDrive\Masaüstü\AbdullahBlog\TigrisTech.MvcUI\Areas\Admin\Views\Category\Index.cshtml"
                           Write(category.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 42 "C:\Users\Abdul\OneDrive\Masaüstü\AbdullahBlog\TigrisTech.MvcUI\Areas\Admin\Views\Category\Index.cshtml"
                           Write(category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 43 "C:\Users\Abdul\OneDrive\Masaüstü\AbdullahBlog\TigrisTech.MvcUI\Areas\Admin\Views\Category\Index.cshtml"
                           Write(category.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 44 "C:\Users\Abdul\OneDrive\Masaüstü\AbdullahBlog\TigrisTech.MvcUI\Areas\Admin\Views\Category\Index.cshtml"
                            Write(category.IsActive ? "Evet" : "Hayır");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 45 "C:\Users\Abdul\OneDrive\Masaüstü\AbdullahBlog\TigrisTech.MvcUI\Areas\Admin\Views\Category\Index.cshtml"
                            Write(category.IsDeleted ? "Evet" : "Hayır");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 46 "C:\Users\Abdul\OneDrive\Masaüstü\AbdullahBlog\TigrisTech.MvcUI\Areas\Admin\Views\Category\Index.cshtml"
                           Write(category.CreateDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 47 "C:\Users\Abdul\OneDrive\Masaüstü\AbdullahBlog\TigrisTech.MvcUI\Areas\Admin\Views\Category\Index.cshtml"
                           Write(category.CreateByName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 48 "C:\Users\Abdul\OneDrive\Masaüstü\AbdullahBlog\TigrisTech.MvcUI\Areas\Admin\Views\Category\Index.cshtml"
                           Write(category.ModifiedDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 49 "C:\Users\Abdul\OneDrive\Masaüstü\AbdullahBlog\TigrisTech.MvcUI\Areas\Admin\Views\Category\Index.cshtml"
                           Write(category.ModifiedByName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>\n                                <button class=\"btn btn-primary btn-sm btn-update\" data-id=\"");
#nullable restore
#line 51 "C:\Users\Abdul\OneDrive\Masaüstü\AbdullahBlog\TigrisTech.MvcUI\Areas\Admin\Views\Category\Index.cshtml"
                                                                                      Write(category.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"><span class=\"fas fa-edit\"></span></button>\n                                <button class=\"btn btn-danger btn-sm btn-delete\" data-id=\"");
#nullable restore
#line 52 "C:\Users\Abdul\OneDrive\Masaüstü\AbdullahBlog\TigrisTech.MvcUI\Areas\Admin\Views\Category\Index.cshtml"
                                                                                     Write(category.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"><span class=\"fas fa-minus-circle\"></span></button>\n                            </td>\n                        </tr>\n");
#nullable restore
#line 55 "C:\Users\Abdul\OneDrive\Masaüstü\AbdullahBlog\TigrisTech.MvcUI\Areas\Admin\Views\Category\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\n                </table>\n            </div>\n        </div>\n     </div>\n");
#nullable restore
#line 61 "C:\Users\Abdul\OneDrive\Masaüstü\AbdullahBlog\TigrisTech.MvcUI\Areas\Admin\Views\Category\Index.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "C:\Users\Abdul\OneDrive\Masaüstü\AbdullahBlog\TigrisTech.MvcUI\Areas\Admin\Views\Category\Index.cshtml"
 if (Model.ResultStatus == ResultStatus.Error)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger mt-3\">\n        ");
#nullable restore
#line 65 "C:\Users\Abdul\OneDrive\Masaüstü\AbdullahBlog\TigrisTech.MvcUI\Areas\Admin\Views\Category\Index.cshtml"
   Write(Model.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br/>\n        Dashboard sayfasına geri dönmek için lütfen ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c9e991f2d471eb9eb7f3e146a73969f9971fc7fde6db86c923f8b26e724f63219594", async() => {
                WriteLiteral("tıklayınız.");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
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
            WriteLiteral("\n    </div>\n");
#nullable restore
#line 68 "C:\Users\Abdul\OneDrive\Masaüstü\AbdullahBlog\TigrisTech.MvcUI\Areas\Admin\Views\Category\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            DefineSection("Scripts", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c9e991f2d471eb9eb7f3e146a73969f9971fc7fde6db86c923f8b26e724f63221560", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CategoryListDto> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591