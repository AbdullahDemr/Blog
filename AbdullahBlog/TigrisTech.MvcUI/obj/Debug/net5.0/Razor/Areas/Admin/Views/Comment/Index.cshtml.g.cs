#pragma checksum "C:\Users\Abdul\OneDrive\Masaüstü\AbdullahBlog\TigrisTech.MvcUI\Areas\Admin\Views\Comment\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "eb29a02c7a7aa04dba5eb5db45a16e99b983036918d15a3ee59072b050ea1ab3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Comment_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Comment/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"eb29a02c7a7aa04dba5eb5db45a16e99b983036918d15a3ee59072b050ea1ab3", @"/Areas/Admin/Views/Comment/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"bd2b9581a650e246d44afdd6e415fbc078ffc6f05d3829ca3adebf6dc1ada283", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Comment_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CommentListDto>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Comment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/AdminLTE/js/commentIndex.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("application/ecmascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Abdul\OneDrive\Masaüstü\AbdullahBlog\TigrisTech.MvcUI\Areas\Admin\Views\Comment\Index.cshtml"
  
    Layout = "_Layout";
    ViewBag.Title = "Yorumlar";

#line default
#line hidden
#nullable disable
            WriteLiteral("<ol class=\"breadcrumb mb-3 mt-2\">\n    <li class=\"breadcrumb-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eb29a02c7a7aa04dba5eb5db45a16e99b983036918d15a3ee59072b050ea1ab38787", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eb29a02c7a7aa04dba5eb5db45a16e99b983036918d15a3ee59072b050ea1ab310415", async() => {
                WriteLiteral("Yorumlar");
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
            WriteLiteral(@"</li>
</ol>
<div id=""modalPlaceHolder"" aria-hidden=""true""></div>
<div class=""card mb-4"">

    <div class=""card-body"">
        <div class=""table-responsive"">
            <table class=""table table-hover  table-sm mt-3"" id=""commentsTable"" width=""100%"" cellspacing=""0"">
                <thead>
                <tr>
                    <th>#</th>
                    <th>Makale</th>
                    <th>Yorum İçeriği</th>
                    <th>Aktif Mi?</th>
                    <th>Silinmiş Mi?</th>
                    <th>Oluşturulma Tarihi</th>
                    <th>Oluşturan Kullanıcı Adı</th>
                    <th>Son Düzenlenme Tarihi</th>
                    <th>Son Düzenleyen Kullanıcı Adı</th>
                    <th>İşlemler</th>
                </tr>
                </thead>
              
                <tbody>
");
#nullable restore
#line 32 "C:\Users\Abdul\OneDrive\Masaüstü\AbdullahBlog\TigrisTech.MvcUI\Areas\Admin\Views\Comment\Index.cshtml"
                 foreach (var comment in Model.Comments)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr");
            BeginWriteAttribute("name", " name=\"", 1274, "\"", 1292, 1);
#nullable restore
#line 34 "C:\Users\Abdul\OneDrive\Masaüstü\AbdullahBlog\TigrisTech.MvcUI\Areas\Admin\Views\Comment\Index.cshtml"
WriteAttributeValue("", 1281, comment.Id, 1281, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                        <td>");
#nullable restore
#line 35 "C:\Users\Abdul\OneDrive\Masaüstü\AbdullahBlog\TigrisTech.MvcUI\Areas\Admin\Views\Comment\Index.cshtml"
                       Write(comment.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 36 "C:\Users\Abdul\OneDrive\Masaüstü\AbdullahBlog\TigrisTech.MvcUI\Areas\Admin\Views\Comment\Index.cshtml"
                       Write(comment.Article.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 37 "C:\Users\Abdul\OneDrive\Masaüstü\AbdullahBlog\TigrisTech.MvcUI\Areas\Admin\Views\Comment\Index.cshtml"
                        Write(comment.Text.Length>75 ? comment.Text.Substring(0, 75):comment.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 38 "C:\Users\Abdul\OneDrive\Masaüstü\AbdullahBlog\TigrisTech.MvcUI\Areas\Admin\Views\Comment\Index.cshtml"
                        Write(comment.IsActive ? "Evet" : "Hayır");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 39 "C:\Users\Abdul\OneDrive\Masaüstü\AbdullahBlog\TigrisTech.MvcUI\Areas\Admin\Views\Comment\Index.cshtml"
                        Write(comment.IsDeleted ? "Evet" : "Hayır");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 40 "C:\Users\Abdul\OneDrive\Masaüstü\AbdullahBlog\TigrisTech.MvcUI\Areas\Admin\Views\Comment\Index.cshtml"
                       Write(comment.CreateDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 41 "C:\Users\Abdul\OneDrive\Masaüstü\AbdullahBlog\TigrisTech.MvcUI\Areas\Admin\Views\Comment\Index.cshtml"
                       Write(comment.CreateByName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 42 "C:\Users\Abdul\OneDrive\Masaüstü\AbdullahBlog\TigrisTech.MvcUI\Areas\Admin\Views\Comment\Index.cshtml"
                       Write(comment.ModifiedDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 43 "C:\Users\Abdul\OneDrive\Masaüstü\AbdullahBlog\TigrisTech.MvcUI\Areas\Admin\Views\Comment\Index.cshtml"
                       Write(comment.ModifiedByName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>\n");
#nullable restore
#line 45 "C:\Users\Abdul\OneDrive\Masaüstü\AbdullahBlog\TigrisTech.MvcUI\Areas\Admin\Views\Comment\Index.cshtml"
                             if (!comment.IsActive)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <button class=\"btn btn-warning btn-sm btn-approve\" data-id=\"");
#nullable restore
#line 47 "C:\Users\Abdul\OneDrive\Masaüstü\AbdullahBlog\TigrisTech.MvcUI\Areas\Admin\Views\Comment\Index.cshtml"
                                                                                       Write(comment.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"><span class=\"fas fa-thumbs-up\"></span></button>\n");
#nullable restore
#line 48 "C:\Users\Abdul\OneDrive\Masaüstü\AbdullahBlog\TigrisTech.MvcUI\Areas\Admin\Views\Comment\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <button class=\"btn btn-info btn-sm btn-detail\" data-id=\"");
#nullable restore
#line 49 "C:\Users\Abdul\OneDrive\Masaüstü\AbdullahBlog\TigrisTech.MvcUI\Areas\Admin\Views\Comment\Index.cshtml"
                                                                               Write(comment.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"><span class=\"fas fa-newspaper\"></span></button>\n                            <button class=\"btn btn-primary btn-sm mt-1 btn-update\" data-id=\"");
#nullable restore
#line 50 "C:\Users\Abdul\OneDrive\Masaüstü\AbdullahBlog\TigrisTech.MvcUI\Areas\Admin\Views\Comment\Index.cshtml"
                                                                                       Write(comment.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"><span class=\"fas fa-edit\"></span></button>\n                            <button class=\"btn btn-danger btn-sm mt-1 btn-delete\" data-id=\"");
#nullable restore
#line 51 "C:\Users\Abdul\OneDrive\Masaüstü\AbdullahBlog\TigrisTech.MvcUI\Areas\Admin\Views\Comment\Index.cshtml"
                                                                                      Write(comment.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"><span class=\"fas fa-minus-circle\"></span></button>\n                        </td>\n                    </tr>\n");
#nullable restore
#line 54 "C:\Users\Abdul\OneDrive\Masaüstü\AbdullahBlog\TigrisTech.MvcUI\Areas\Admin\Views\Comment\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </tbody>\n            </table>\n        </div>\n    </div>\n</div>\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eb29a02c7a7aa04dba5eb5db45a16e99b983036918d15a3ee59072b050ea1ab319285", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
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
            DefineSection("Styles", async() => {
                WriteLiteral("\n    \n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CommentListDto> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
