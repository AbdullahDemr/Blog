#pragma checksum "C:\Users\Abdul\OneDrive\Masaüstü\AbdullahBlog\TigrisTech.MvcUI\Areas\Admin\Views\Comment\_CommentDetailPartial.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4eb555708d0635db1c42649482f5e89cc4d9ece75b7246980353b9c60c441bb8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Comment__CommentDetailPartial), @"mvc.1.0.view", @"/Areas/Admin/Views/Comment/_CommentDetailPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"4eb555708d0635db1c42649482f5e89cc4d9ece75b7246980353b9c60c441bb8", @"/Areas/Admin/Views/Comment/_CommentDetailPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"bd2b9581a650e246d44afdd6e415fbc078ffc6f05d3829ca3adebf6dc1ada283", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Comment__CommentDetailPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CommentDto>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""modal fade"" tabindex=""-1"" role=""dialog"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title""><span class=""fas fa-newspaper""></span> ");
#nullable restore
#line 6 "C:\Users\Abdul\OneDrive\Masaüstü\AbdullahBlog\TigrisTech.MvcUI\Areas\Admin\Views\Comment\_CommentDetailPartial.cshtml"
                                                                          Write(Model.Comment.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" Numaralı Yorum Görüntüleniyor...</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""İptal"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
              ");
#nullable restore
#line 12 "C:\Users\Abdul\OneDrive\Masaüstü\AbdullahBlog\TigrisTech.MvcUI\Areas\Admin\Views\Comment\_CommentDetailPartial.cshtml"
         Write(Model.Comment.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-danger btn-block"" data-dismiss=""modal""><span class=""fas fa-times""></span> Kapat</button>
                
            </div>
        </div>
    </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CommentDto> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
