#pragma checksum "C:\Users\Abdul\OneDrive\Masaüstü\AbdullahBlog\TigrisTech.MvcUI\Areas\Admin\Views\Auth\ResetPassword.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "057f8a3ae4006ef44ee28716222904455dfc83860798f97b0ba138a1cfa47711"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Auth_ResetPassword), @"mvc.1.0.view", @"/Areas/Admin/Views/Auth/ResetPassword.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"057f8a3ae4006ef44ee28716222904455dfc83860798f97b0ba138a1cfa47711", @"/Areas/Admin/Views/Auth/ResetPassword.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"bd2b9581a650e246d44afdd6e415fbc078ffc6f05d3829ca3adebf6dc1ada283", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Auth_ResetPassword : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PasswordResetDto>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("h1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "email", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Email"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ResetPassword", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ProtecedPage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Abdul\OneDrive\Masaüstü\AbdullahBlog\TigrisTech.MvcUI\Areas\Admin\Views\Auth\ResetPassword.cshtml"
  
    Layout = "_ForgetLayout";
    ViewData["Title"] = "Şifre Sıfırlama";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"login-box\">\n    <div class=\"card card-outline card-primary\">\n        <div class=\"card-header text-center\">\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "057f8a3ae4006ef44ee28716222904455dfc83860798f97b0ba138a1cfa4771111209", async() => {
                WriteLiteral("<b>Tigris</b>Tech");
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        </div>\n        <div class=\"card-body\">\n");
#nullable restore
#line 14 "C:\Users\Abdul\OneDrive\Masaüstü\AbdullahBlog\TigrisTech.MvcUI\Areas\Admin\Views\Auth\ResetPassword.cshtml"
             if (ViewBag.status == "success")
            {
                

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p class=\"login-box-msg text-primary\">Şifre yenileme linki e-posta adresinize gönderilmiştir. E-postanızı kontrol ediniz</p>\n");
#nullable restore
#line 18 "C:\Users\Abdul\OneDrive\Masaüstü\AbdullahBlog\TigrisTech.MvcUI\Areas\Admin\Views\Auth\ResetPassword.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p class=\"login-box-msg\">\n                Yeni şifre belirlemek için kayıtlı e-posta adresinizi yazınız.\n                Şifre değiştirme linkini e-posta adresinize göndereceğiz.\n            </p>\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "057f8a3ae4006ef44ee28716222904455dfc83860798f97b0ba138a1cfa4771113868", async() => {
                WriteLiteral("\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "057f8a3ae4006ef44ee28716222904455dfc83860798f97b0ba138a1cfa4771114165", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 26 "C:\Users\Abdul\OneDrive\Masaüstü\AbdullahBlog\TigrisTech.MvcUI\Areas\Admin\Views\Auth\ResetPassword.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                <div class=\"input-group mb-3\">\n\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "057f8a3ae4006ef44ee28716222904455dfc83860798f97b0ba138a1cfa4771115954", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 29 "C:\Users\Abdul\OneDrive\Masaüstü\AbdullahBlog\TigrisTech.MvcUI\Areas\Admin\Views\Auth\ResetPassword.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Email);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    <div class=""input-group-append"">
                        <div class=""input-group-text"">

                            <span class=""fas fa-envelope""></span>
                        </div>
                    </div>
                </div>
                <div class=""row"">
                    <div class=""col-12"">
                        <button type=""submit"" class=""btn btn-primary btn-block""><span class=""fas fa-sign-in-alt""></span>Gönder</button>
                    </div>

                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            <p class=\"mt-3 mb-1\">\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "057f8a3ae4006ef44ee28716222904455dfc83860798f97b0ba138a1cfa4771119935", async() => {
                WriteLiteral("Giriş Yap");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </p>\n");
#nullable restore
#line 47 "C:\Users\Abdul\OneDrive\Masaüstü\AbdullahBlog\TigrisTech.MvcUI\Areas\Admin\Views\Auth\ResetPassword.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n\n    </div>\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PasswordResetDto> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591