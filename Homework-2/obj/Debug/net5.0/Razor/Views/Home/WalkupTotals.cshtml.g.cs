#pragma checksum "C:\Users\cryst\OneDrive\Documents\MIS 333K\Le_Crystal_HW2\Le_Crystal_HW2\Views\Home\WalkupTotals.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8591360aad263eb0b5edef42e773dbc9f1605365"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Le_Crystal_HW2.Views.Home.Views_Home_WalkupTotals), @"mvc.1.0.view", @"/Views/Home/WalkupTotals.cshtml")]
namespace Le_Crystal_HW2.Views.Home
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
#line 13 "C:\Users\cryst\OneDrive\Documents\MIS 333K\Le_Crystal_HW2\Le_Crystal_HW2\Views\_ViewImports.cshtml"
using Le_Crystal_HW2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8591360aad263eb0b5edef42e773dbc9f1605365", @"/Views/Home/WalkupTotals.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31ce1f0aa07b981ba269a27861d6199aa3decdd2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_WalkupTotals : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Le_Crystal_HW2.Models.WalkupOrder>
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
#line 3 "C:\Users\cryst\OneDrive\Documents\MIS 333K\Le_Crystal_HW2\Le_Crystal_HW2\Views\Home\WalkupTotals.cshtml"
  
    ViewData["Title"] = "WalkupTotals";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Walkup Totals</h1>\r\n\r\n<!---");
            WriteLiteral("--->\r\n<div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\cryst\OneDrive\Documents\MIS 333K\Le_Crystal_HW2\Le_Crystal_HW2\Views\Home\WalkupTotals.cshtml"
       Write(Html.DisplayNameFor(model => model.CustomerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\cryst\OneDrive\Documents\MIS 333K\Le_Crystal_HW2\Le_Crystal_HW2\Views\Home\WalkupTotals.cshtml"
       Write(Html.DisplayFor(model => model.CustomerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\cryst\OneDrive\Documents\MIS 333K\Le_Crystal_HW2\Le_Crystal_HW2\Views\Home\WalkupTotals.cshtml"
       Write(Html.DisplayNameFor(model => model.CustomerType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\cryst\OneDrive\Documents\MIS 333K\Le_Crystal_HW2\Le_Crystal_HW2\Views\Home\WalkupTotals.cshtml"
       Write(Html.DisplayFor(model => model.CustomerType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n         <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\cryst\OneDrive\Documents\MIS 333K\Le_Crystal_HW2\Le_Crystal_HW2\Views\Home\WalkupTotals.cshtml"
       Write(Html.DisplayNameFor(model => model.NumberOfBurgers));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\cryst\OneDrive\Documents\MIS 333K\Le_Crystal_HW2\Le_Crystal_HW2\Views\Home\WalkupTotals.cshtml"
       Write(Html.DisplayFor(model => model.NumberOfBurgers));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Users\cryst\OneDrive\Documents\MIS 333K\Le_Crystal_HW2\Le_Crystal_HW2\Views\Home\WalkupTotals.cshtml"
       Write(Html.DisplayNameFor(model => model.NumberOfTacos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\cryst\OneDrive\Documents\MIS 333K\Le_Crystal_HW2\Le_Crystal_HW2\Views\Home\WalkupTotals.cshtml"
       Write(Html.DisplayFor(model => model.NumberOfTacos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\Users\cryst\OneDrive\Documents\MIS 333K\Le_Crystal_HW2\Le_Crystal_HW2\Views\Home\WalkupTotals.cshtml"
       Write(Html.DisplayNameFor(model => model.TotalItems));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\Users\cryst\OneDrive\Documents\MIS 333K\Le_Crystal_HW2\Le_Crystal_HW2\Views\Home\WalkupTotals.cshtml"
       Write(Html.DisplayFor(model => model.TotalItems));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "C:\Users\cryst\OneDrive\Documents\MIS 333K\Le_Crystal_HW2\Le_Crystal_HW2\Views\Home\WalkupTotals.cshtml"
       Write(Html.DisplayNameFor(model => model.BurgerSubtotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "C:\Users\cryst\OneDrive\Documents\MIS 333K\Le_Crystal_HW2\Le_Crystal_HW2\Views\Home\WalkupTotals.cshtml"
       Write(Html.DisplayFor(model => model.BurgerSubtotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n         <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "C:\Users\cryst\OneDrive\Documents\MIS 333K\Le_Crystal_HW2\Le_Crystal_HW2\Views\Home\WalkupTotals.cshtml"
       Write(Html.DisplayNameFor(model => model.TacoSubtotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "C:\Users\cryst\OneDrive\Documents\MIS 333K\Le_Crystal_HW2\Le_Crystal_HW2\Views\Home\WalkupTotals.cshtml"
       Write(Html.DisplayFor(model => model.TacoSubtotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n         \r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 57 "C:\Users\cryst\OneDrive\Documents\MIS 333K\Le_Crystal_HW2\Le_Crystal_HW2\Views\Home\WalkupTotals.cshtml"
       Write(Html.DisplayNameFor(model => model.Subtotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 60 "C:\Users\cryst\OneDrive\Documents\MIS 333K\Le_Crystal_HW2\Le_Crystal_HW2\Views\Home\WalkupTotals.cshtml"
       Write(Html.DisplayFor(model => model.Subtotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n       <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 63 "C:\Users\cryst\OneDrive\Documents\MIS 333K\Le_Crystal_HW2\Le_Crystal_HW2\Views\Home\WalkupTotals.cshtml"
       Write(Html.DisplayNameFor(model => model.SalesTax));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 66 "C:\Users\cryst\OneDrive\Documents\MIS 333K\Le_Crystal_HW2\Le_Crystal_HW2\Views\Home\WalkupTotals.cshtml"
       Write(Html.DisplayFor(model => model.SalesTax));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 69 "C:\Users\cryst\OneDrive\Documents\MIS 333K\Le_Crystal_HW2\Le_Crystal_HW2\Views\Home\WalkupTotals.cshtml"
       Write(Html.DisplayNameFor(model => model.Total));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 72 "C:\Users\cryst\OneDrive\Documents\MIS 333K\Le_Crystal_HW2\Le_Crystal_HW2\Views\Home\WalkupTotals.cshtml"
       Write(Html.DisplayFor(model => model.Total));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        \r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8591360aad263eb0b5edef42e773dbc9f160536510733", async() => {
                WriteLiteral("Home");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Le_Crystal_HW2.Models.WalkupOrder> Html { get; private set; }
    }
}
#pragma warning restore 1591