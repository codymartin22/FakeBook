#pragma checksum "D:\RepoVS2019\ShopKlee\ShopKlee\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83731cc570ba3e95a34c21bc2fab9885d1a46b62"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\RepoVS2019\ShopKlee\ShopKlee\Views\_ViewImports.cshtml"
using ShopKlee;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\RepoVS2019\ShopKlee\ShopKlee\Views\_ViewImports.cshtml"
using ShopKlee.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83731cc570ba3e95a34c21bc2fab9885d1a46b62", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"832e5c7893fcd0103be81ae99bfbe6d22474562f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShopKlee.Models.ViewModel.HomeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\RepoVS2019\ShopKlee\ShopKlee\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "FakeBook";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"panel-header panel-header-sm\">\r\n    <!--null-->\r\n</div>\r\n<div class=\"content content-center\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-8\">\r\n            <div class=\"card\">\r\n");
#nullable restore
#line 12 "D:\RepoVS2019\ShopKlee\ShopKlee\Views\Home\Index.cshtml"
 if (!User.Identity.IsAuthenticated)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83731cc570ba3e95a34c21bc2fab9885d1a46b624245", async() => {
                WriteLiteral("\r\n                    <i class=\"now-ui-icons arrows-1_cloud-upload-94\"></i>\r\n                    Login\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 18 "D:\RepoVS2019\ShopKlee\ShopKlee\Views\Home\Index.cshtml"
}else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""card  card-tasks"">
                <div class=""card-header "">
                    <h5 class=""card-category"">Backend development</h5>
                    <h4 class=""card-title"">Tasks</h4>
                </div>
                <div class=""card-body "">
                    <div class=""table-full-width table-responsive"">
                        <table class=""table"">
                            <tbody>
                                <tr>
                                    <td>
                                        <div class=""form-check"">
                                            <label class=""form-check-label"">
                                                <input class=""form-check-input"" type=""checkbox"" checked>
                                                <span class=""form-check-sign""></span>
                                            </label>
                                        </div>
                                    </td>
                            ");
            WriteLiteral("        <td class=\"text-left\">Sign contract for \"What are conference organizers afraid of?\"</td>\r\n                                    <td class=\"td-actions text-right\">\r\n                                        <button type=\"button\" rel=\"tooltip\"");
            BeginWriteAttribute("title", " title=\"", 1795, "\"", 1803, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-info btn-round btn-icon btn-icon-mini btn-neutral"" data-original-title=""Edit Task"">
                                            <i class=""now-ui-icons ui-2_settings-90""></i>
                                        </button>
                                        <button type=""button"" rel=""tooltip""");
            BeginWriteAttribute("title", " title=\"", 2122, "\"", 2130, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-danger btn-round btn-icon btn-icon-mini btn-neutral"" data-original-title=""Remove"">
                                            <i class=""now-ui-icons ui-1_simple-remove""></i>
                                        </button>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <div class=""form-check"">
                                            <label class=""form-check-label"">
                                                <input class=""form-check-input"" type=""checkbox"">
                                                <span class=""form-check-sign""></span>
                                            </label>
                                        </div>
                                    </td>
                                    <td class=""text-left"">Lines From Great Russian Literature? Or E-mails From My Boss?</td>
                  ");
            WriteLiteral("                  <td class=\"td-actions text-right\">\r\n                                        <button type=\"button\" rel=\"tooltip\"");
            BeginWriteAttribute("title", " title=\"", 3284, "\"", 3292, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-info btn-round btn-icon btn-icon-mini btn-neutral"" data-original-title=""Edit Task"">
                                            <i class=""now-ui-icons ui-2_settings-90""></i>
                                        </button>
                                        <button type=""button"" rel=""tooltip""");
            BeginWriteAttribute("title", " title=\"", 3611, "\"", 3619, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-danger btn-round btn-icon btn-icon-mini btn-neutral"" data-original-title=""Remove"">
                                            <i class=""now-ui-icons ui-1_simple-remove""></i>
                                        </button>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <div class=""form-check"">
                                            <label class=""form-check-label"">
                                                <input class=""form-check-input"" type=""checkbox"" checked>
                                                <span class=""form-check-sign""></span>
                                            </label>
                                        </div>
                                    </td>
                                    <td class=""text-left"">
                                        Flooded: One year later, assessing w");
            WriteLiteral(@"hat was lost and what was found when a ravaging rain swept through metro Detroit
                                    </td>
                                    <td class=""td-actions text-right"">
                                        <button type=""button"" rel=""tooltip""");
            BeginWriteAttribute("title", " title=\"", 4916, "\"", 4924, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-info btn-round btn-icon btn-icon-mini btn-neutral"" data-original-title=""Edit Task"">
                                            <i class=""now-ui-icons ui-2_settings-90""></i>
                                        </button>
                                        <button type=""button"" rel=""tooltip""");
            BeginWriteAttribute("title", " title=\"", 5243, "\"", 5251, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-danger btn-round btn-icon btn-icon-mini btn-neutral"" data-original-title=""Remove"">
                                            <i class=""now-ui-icons ui-1_simple-remove""></i>
                                        </button>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
                <div class=""card-footer "">
                    <hr>
                    <div class=""stats"">
                        <i class=""now-ui-icons loader_refresh spin""></i> Updated 3 minutes ago
                    </div>
                </div>
            </div>
");
#nullable restore
#line 99 "D:\RepoVS2019\ShopKlee\ShopKlee\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShopKlee.Models.ViewModel.HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
