#pragma checksum "E:\TB.AspNetCore.Quarzt\TB.AspNetCore.Quarzt\Views\ScheduleInfoes\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31f3f247730dd1d92a7c3e6c21c9b86835abd345"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ScheduleInfoes_Delete), @"mvc.1.0.view", @"/Views/ScheduleInfoes/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ScheduleInfoes/Delete.cshtml", typeof(AspNetCore.Views_ScheduleInfoes_Delete))]
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
#line 1 "E:\TB.AspNetCore.Quarzt\TB.AspNetCore.Quarzt\Views\_ViewImports.cshtml"
using TB.AspNetCore.Quarzt;

#line default
#line hidden
#line 2 "E:\TB.AspNetCore.Quarzt\TB.AspNetCore.Quarzt\Views\_ViewImports.cshtml"
using TB.AspNetCore.Quarzt.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31f3f247730dd1d92a7c3e6c21c9b86835abd345", @"/Views/ScheduleInfoes/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89f5d02c1b892577f6701c4aed08e935c9cf262c", @"/Views/_ViewImports.cshtml")]
    public class Views_ScheduleInfoes_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TB.AspNetCore.Data.Entity.ScheduleInfo>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\TB.AspNetCore.Quarzt\TB.AspNetCore.Quarzt\Views\ScheduleInfoes\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(91, 173, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>ScheduleInfo</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(265, 44, false);
#line 15 "E:\TB.AspNetCore.Quarzt\TB.AspNetCore.Quarzt\Views\ScheduleInfoes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.JobGroup));

#line default
#line hidden
            EndContext();
            BeginContext(309, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(353, 40, false);
#line 18 "E:\TB.AspNetCore.Quarzt\TB.AspNetCore.Quarzt\Views\ScheduleInfoes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.JobGroup));

#line default
#line hidden
            EndContext();
            BeginContext(393, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(437, 43, false);
#line 21 "E:\TB.AspNetCore.Quarzt\TB.AspNetCore.Quarzt\Views\ScheduleInfoes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.JobName));

#line default
#line hidden
            EndContext();
            BeginContext(480, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(524, 39, false);
#line 24 "E:\TB.AspNetCore.Quarzt\TB.AspNetCore.Quarzt\Views\ScheduleInfoes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.JobName));

#line default
#line hidden
            EndContext();
            BeginContext(563, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(607, 45, false);
#line 27 "E:\TB.AspNetCore.Quarzt\TB.AspNetCore.Quarzt\Views\ScheduleInfoes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.RunStatus));

#line default
#line hidden
            EndContext();
            BeginContext(652, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(696, 41, false);
#line 30 "E:\TB.AspNetCore.Quarzt\TB.AspNetCore.Quarzt\Views\ScheduleInfoes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.RunStatus));

#line default
#line hidden
            EndContext();
            BeginContext(737, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(781, 47, false);
#line 33 "E:\TB.AspNetCore.Quarzt\TB.AspNetCore.Quarzt\Views\ScheduleInfoes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CromExpress));

#line default
#line hidden
            EndContext();
            BeginContext(828, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(872, 43, false);
#line 36 "E:\TB.AspNetCore.Quarzt\TB.AspNetCore.Quarzt\Views\ScheduleInfoes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CromExpress));

#line default
#line hidden
            EndContext();
            BeginContext(915, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(959, 47, false);
#line 39 "E:\TB.AspNetCore.Quarzt\TB.AspNetCore.Quarzt\Views\ScheduleInfoes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.StarRunTime));

#line default
#line hidden
            EndContext();
            BeginContext(1006, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1050, 43, false);
#line 42 "E:\TB.AspNetCore.Quarzt\TB.AspNetCore.Quarzt\Views\ScheduleInfoes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.StarRunTime));

#line default
#line hidden
            EndContext();
            BeginContext(1093, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1137, 46, false);
#line 45 "E:\TB.AspNetCore.Quarzt\TB.AspNetCore.Quarzt\Views\ScheduleInfoes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.EndRunTime));

#line default
#line hidden
            EndContext();
            BeginContext(1183, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1227, 42, false);
#line 48 "E:\TB.AspNetCore.Quarzt\TB.AspNetCore.Quarzt\Views\ScheduleInfoes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.EndRunTime));

#line default
#line hidden
            EndContext();
            BeginContext(1269, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1313, 47, false);
#line 51 "E:\TB.AspNetCore.Quarzt\TB.AspNetCore.Quarzt\Views\ScheduleInfoes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.NextRunTime));

#line default
#line hidden
            EndContext();
            BeginContext(1360, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1404, 43, false);
#line 54 "E:\TB.AspNetCore.Quarzt\TB.AspNetCore.Quarzt\Views\ScheduleInfoes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.NextRunTime));

#line default
#line hidden
            EndContext();
            BeginContext(1447, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1491, 41, false);
#line 57 "E:\TB.AspNetCore.Quarzt\TB.AspNetCore.Quarzt\Views\ScheduleInfoes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Token));

#line default
#line hidden
            EndContext();
            BeginContext(1532, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1576, 37, false);
#line 60 "E:\TB.AspNetCore.Quarzt\TB.AspNetCore.Quarzt\Views\ScheduleInfoes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Token));

#line default
#line hidden
            EndContext();
            BeginContext(1613, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1657, 41, false);
#line 63 "E:\TB.AspNetCore.Quarzt\TB.AspNetCore.Quarzt\Views\ScheduleInfoes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.AppId));

#line default
#line hidden
            EndContext();
            BeginContext(1698, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1742, 37, false);
#line 66 "E:\TB.AspNetCore.Quarzt\TB.AspNetCore.Quarzt\Views\ScheduleInfoes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.AppId));

#line default
#line hidden
            EndContext();
            BeginContext(1779, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1823, 47, false);
#line 69 "E:\TB.AspNetCore.Quarzt\TB.AspNetCore.Quarzt\Views\ScheduleInfoes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ServiceCode));

#line default
#line hidden
            EndContext();
            BeginContext(1870, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1914, 43, false);
#line 72 "E:\TB.AspNetCore.Quarzt\TB.AspNetCore.Quarzt\Views\ScheduleInfoes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ServiceCode));

#line default
#line hidden
            EndContext();
            BeginContext(1957, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2001, 49, false);
#line 75 "E:\TB.AspNetCore.Quarzt\TB.AspNetCore.Quarzt\Views\ScheduleInfoes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.InterfaceCode));

#line default
#line hidden
            EndContext();
            BeginContext(2050, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2094, 45, false);
#line 78 "E:\TB.AspNetCore.Quarzt\TB.AspNetCore.Quarzt\Views\ScheduleInfoes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.InterfaceCode));

#line default
#line hidden
            EndContext();
            BeginContext(2139, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2183, 51, false);
#line 81 "E:\TB.AspNetCore.Quarzt\TB.AspNetCore.Quarzt\Views\ScheduleInfoes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TaskDescription));

#line default
#line hidden
            EndContext();
            BeginContext(2234, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2278, 47, false);
#line 84 "E:\TB.AspNetCore.Quarzt\TB.AspNetCore.Quarzt\Views\ScheduleInfoes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TaskDescription));

#line default
#line hidden
            EndContext();
            BeginContext(2325, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2369, 46, false);
#line 87 "E:\TB.AspNetCore.Quarzt\TB.AspNetCore.Quarzt\Views\ScheduleInfoes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DataStatus));

#line default
#line hidden
            EndContext();
            BeginContext(2415, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2459, 42, false);
#line 90 "E:\TB.AspNetCore.Quarzt\TB.AspNetCore.Quarzt\Views\ScheduleInfoes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DataStatus));

#line default
#line hidden
            EndContext();
            BeginContext(2501, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2545, 47, false);
#line 93 "E:\TB.AspNetCore.Quarzt\TB.AspNetCore.Quarzt\Views\ScheduleInfoes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CreateAuthr));

#line default
#line hidden
            EndContext();
            BeginContext(2592, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2636, 43, false);
#line 96 "E:\TB.AspNetCore.Quarzt\TB.AspNetCore.Quarzt\Views\ScheduleInfoes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CreateAuthr));

#line default
#line hidden
            EndContext();
            BeginContext(2679, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2723, 46, false);
#line 99 "E:\TB.AspNetCore.Quarzt\TB.AspNetCore.Quarzt\Views\ScheduleInfoes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CreateTime));

#line default
#line hidden
            EndContext();
            BeginContext(2769, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2813, 42, false);
#line 102 "E:\TB.AspNetCore.Quarzt\TB.AspNetCore.Quarzt\Views\ScheduleInfoes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CreateTime));

#line default
#line hidden
            EndContext();
            BeginContext(2855, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(2893, 207, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f443a4f2e4d241cf8f0a0fe4b5afa65d", async() => {
                BeginContext(2919, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(2929, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fd02b01458ec43b7b8d44849b99f8ad1", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 107 "E:\TB.AspNetCore.Quarzt\TB.AspNetCore.Quarzt\Views\ScheduleInfoes\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2965, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(3049, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd2107de8c7447ce893a90045ac8eeac", async() => {
                    BeginContext(3071, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3087, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3100, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TB.AspNetCore.Data.Entity.ScheduleInfo> Html { get; private set; }
    }
}
#pragma warning restore 1591
