#pragma checksum "D:\CNTT\Năm ba\HKI\DTDM\DO_AN_CUOI_KI\Thao-sa\CloudComputing\MVCCloud\MVCCloud\Views\Home\DetailStudent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ab280c832f5f1a90f94f88a1a80144bf581919e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_DetailStudent), @"mvc.1.0.view", @"/Views/Home/DetailStudent.cshtml")]
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
#line 1 "D:\CNTT\Năm ba\HKI\DTDM\DO_AN_CUOI_KI\Thao-sa\CloudComputing\MVCCloud\MVCCloud\Views\_ViewImports.cshtml"
using MVCCloud;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\CNTT\Năm ba\HKI\DTDM\DO_AN_CUOI_KI\Thao-sa\CloudComputing\MVCCloud\MVCCloud\Views\_ViewImports.cshtml"
using MVCCloud.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ab280c832f5f1a90f94f88a1a80144bf581919e", @"/Views/Home/DetailStudent.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"709d3fae6767dd0da3a9290917298e2affa676be", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_DetailStudent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MVCCloud.Models.Student>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\CNTT\Năm ba\HKI\DTDM\DO_AN_CUOI_KI\Thao-sa\CloudComputing\MVCCloud\MVCCloud\Views\Home\DetailStudent.cshtml"
  
    ViewData["Title"] = " Student Profile";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h4>Student Profile</h4>\r\n<h1>");
#nullable restore
#line 7 "D:\CNTT\Năm ba\HKI\DTDM\DO_AN_CUOI_KI\Thao-sa\CloudComputing\MVCCloud\MVCCloud\Views\Home\DetailStudent.cshtml"
Write(Model.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<div>\r\n    \r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "D:\CNTT\Năm ba\HKI\DTDM\DO_AN_CUOI_KI\Thao-sa\CloudComputing\MVCCloud\MVCCloud\Views\Home\DetailStudent.cshtml"
       Write(Html.DisplayNameFor(model => model.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "D:\CNTT\Năm ba\HKI\DTDM\DO_AN_CUOI_KI\Thao-sa\CloudComputing\MVCCloud\MVCCloud\Views\Home\DetailStudent.cshtml"
       Write(Html.DisplayFor(model => model.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt class=\"col-sm-2\">\r\n          Academic year\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "D:\CNTT\Năm ba\HKI\DTDM\DO_AN_CUOI_KI\Thao-sa\CloudComputing\MVCCloud\MVCCloud\Views\Home\DetailStudent.cshtml"
       Write(Html.DisplayFor(model => model.year));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n          Current address\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "D:\CNTT\Năm ba\HKI\DTDM\DO_AN_CUOI_KI\Thao-sa\CloudComputing\MVCCloud\MVCCloud\Views\Home\DetailStudent.cshtml"
       Write(Html.DisplayFor(model => model.address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Listenning scored\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "D:\CNTT\Năm ba\HKI\DTDM\DO_AN_CUOI_KI\Thao-sa\CloudComputing\MVCCloud\MVCCloud\Views\Home\DetailStudent.cshtml"
       Write(Html.DisplayFor(model => model.listenning));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Speaking scored\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "D:\CNTT\Năm ba\HKI\DTDM\DO_AN_CUOI_KI\Thao-sa\CloudComputing\MVCCloud\MVCCloud\Views\Home\DetailStudent.cshtml"
       Write(Html.DisplayFor(model => model.speaking));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Writing scored\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "D:\CNTT\Năm ba\HKI\DTDM\DO_AN_CUOI_KI\Thao-sa\CloudComputing\MVCCloud\MVCCloud\Views\Home\DetailStudent.cshtml"
       Write(Html.DisplayFor(model => model.writing));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Reading scored\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 54 "D:\CNTT\Năm ba\HKI\DTDM\DO_AN_CUOI_KI\Thao-sa\CloudComputing\MVCCloud\MVCCloud\Views\Home\DetailStudent.cshtml"
       Write(Html.DisplayFor(model => model.reading));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n    </dl>\r\n</div>\r\n<div>\r\n    <a> \r\n        ");
#nullable restore
#line 61 "D:\CNTT\Năm ba\HKI\DTDM\DO_AN_CUOI_KI\Thao-sa\CloudComputing\MVCCloud\MVCCloud\Views\Home\DetailStudent.cshtml"
   Write(Html.ActionLink("Edit ", "GetEditStudent", "Home", new { id = Model.id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </a>|\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ab280c832f5f1a90f94f88a1a80144bf581919e7763", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MVCCloud.Models.Student> Html { get; private set; }
    }
}
#pragma warning restore 1591
