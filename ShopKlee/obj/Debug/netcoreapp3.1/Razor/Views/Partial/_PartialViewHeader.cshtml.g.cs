#pragma checksum "D:\RepoVS2019\ShopKlee\ShopKlee\Views\Partial\_PartialViewHeader.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc894f51e2ef74c1172a14d5163f862d4d684d62"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Partial__PartialViewHeader), @"mvc.1.0.view", @"/Views/Partial/_PartialViewHeader.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc894f51e2ef74c1172a14d5163f862d4d684d62", @"/Views/Partial/_PartialViewHeader.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"832e5c7893fcd0103be81ae99bfbe6d22474562f", @"/Views/_ViewImports.cshtml")]
    public class Views_Partial__PartialViewHeader : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"col-md-4\">\r\n    <div class=\"row\">\r\n        <div class=\"card card-user\">\r\n            <div class=\"title text-center\">Có ");
#nullable restore
#line 4 "D:\RepoVS2019\ShopKlee\ShopKlee\Views\Partial\_PartialViewHeader.cshtml"
                                         Write(ViewBag.Data.totalResults);

#line default
#line hidden
#nullable disable
            WriteLiteral(" kết quả, 10/");
#nullable restore
#line 4 "D:\RepoVS2019\ShopKlee\ShopKlee\Views\Partial\_PartialViewHeader.cshtml"
                                                                                Write(ViewBag.Data.totalResults);

#line default
#line hidden
#nullable disable
            WriteLiteral(" kết quả:</div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 7 "D:\RepoVS2019\ShopKlee\ShopKlee\Views\Partial\_PartialViewHeader.cshtml"
     foreach (var items in ViewBag.Data.articles){

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n        <a");
            BeginWriteAttribute("href", " href =\"", 326, "\"", 344, 1);
#nullable restore
#line 9 "D:\RepoVS2019\ShopKlee\ShopKlee\Views\Partial\_PartialViewHeader.cshtml"
WriteAttributeValue("", 334, items.url, 334, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <div class=\"card card-user\">\r\n                <div class=\"image\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 451, "\"", 474, 1);
#nullable restore
#line 12 "D:\RepoVS2019\ShopKlee\ShopKlee\Views\Partial\_PartialViewHeader.cshtml"
WriteAttributeValue("", 457, items.urlToImage, 457, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"...\">\r\n                </div>\r\n                <div class=\"card-body\">\r\n                    <p class=\"description text-center\">\r\n                        ");
#nullable restore
#line 16 "D:\RepoVS2019\ShopKlee\ShopKlee\Views\Partial\_PartialViewHeader.cshtml"
                   Write(items.description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                </div>\r\n            </div>\r\n        </a>\r\n    </div>\r\n");
#nullable restore
#line 22 "D:\RepoVS2019\ShopKlee\ShopKlee\Views\Partial\_PartialViewHeader.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
