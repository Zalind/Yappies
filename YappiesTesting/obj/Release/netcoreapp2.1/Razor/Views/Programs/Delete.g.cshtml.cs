#pragma checksum "G:\videos\Downloads\SorryBigB\SurprisinglyNotAMeme\YappiesTesting\Views\Programs\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "505140cbcc27e4cb86b57756259e21cdc147d72b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Programs_Delete), @"mvc.1.0.view", @"/Views/Programs/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Programs/Delete.cshtml", typeof(AspNetCore.Views_Programs_Delete))]
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
#line 1 "G:\videos\Downloads\SorryBigB\SurprisinglyNotAMeme\YappiesTesting\Views\_ViewImports.cshtml"
using YappiesTesting;

#line default
#line hidden
#line 2 "G:\videos\Downloads\SorryBigB\SurprisinglyNotAMeme\YappiesTesting\Views\_ViewImports.cshtml"
using YappiesTesting.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"505140cbcc27e4cb86b57756259e21cdc147d72b", @"/Views/Programs/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98f360a324d1731e4114c1541be2de55c36cea97", @"/Views/_ViewImports.cshtml")]
    public class Views_Programs_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<YappiesTesting.Models.Program>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(38, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "G:\videos\Downloads\SorryBigB\SurprisinglyNotAMeme\YappiesTesting\Views\Programs\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(82, 446, true);
            WriteLiteral(@"<div id=""body"">
    <h1 class=""text-center"">Delete Program</h1>
    <div class=""panel panel-default"" style=""margin-top: .5vh"">
        <div class=""panel-heading"">
            <h3 class=""panel-title"">
                Delete Program
            </h3>
        </div>
        <div class=""panel-body"" style=""margin: 0; padding:0"">
            <ul class=""list-group"">
                <li class=""list-group-item"">
                    <strong>");
            EndContext();
            BeginContext(529, 47, false);
#line 17 "G:\videos\Downloads\SorryBigB\SurprisinglyNotAMeme\YappiesTesting\Views\Programs\Delete.cshtml"
                       Write(Html.DisplayNameFor(model => model.ProgramName));

#line default
#line hidden
            EndContext();
            BeginContext(576, 37, true);
            WriteLiteral("</strong><br />\r\n                    ");
            EndContext();
            BeginContext(614, 43, false);
#line 18 "G:\videos\Downloads\SorryBigB\SurprisinglyNotAMeme\YappiesTesting\Views\Programs\Delete.cshtml"
               Write(Html.DisplayFor(model => model.ProgramName));

#line default
#line hidden
            EndContext();
            BeginContext(657, 99, true);
            WriteLiteral("\r\n                </li>\r\n                <li class=\"list-group-item\">\r\n                    <strong>");
            EndContext();
            BeginContext(757, 54, false);
#line 21 "G:\videos\Downloads\SorryBigB\SurprisinglyNotAMeme\YappiesTesting\Views\Programs\Delete.cshtml"
                       Write(Html.DisplayNameFor(model => model.ProgramDescription));

#line default
#line hidden
            EndContext();
            BeginContext(811, 37, true);
            WriteLiteral("</strong><br />\r\n                    ");
            EndContext();
            BeginContext(849, 50, false);
#line 22 "G:\videos\Downloads\SorryBigB\SurprisinglyNotAMeme\YappiesTesting\Views\Programs\Delete.cshtml"
               Write(Html.DisplayFor(model => model.ProgramDescription));

#line default
#line hidden
            EndContext();
            BeginContext(899, 99, true);
            WriteLiteral("\r\n                </li>\r\n                <li class=\"list-group-item\">\r\n                    <strong>");
            EndContext();
            BeginContext(999, 51, false);
#line 25 "G:\videos\Downloads\SorryBigB\SurprisinglyNotAMeme\YappiesTesting\Views\Programs\Delete.cshtml"
                       Write(Html.DisplayNameFor(model => model.ProgramJoinCode));

#line default
#line hidden
            EndContext();
            BeginContext(1050, 37, true);
            WriteLiteral("</strong><br />\r\n                    ");
            EndContext();
            BeginContext(1088, 47, false);
#line 26 "G:\videos\Downloads\SorryBigB\SurprisinglyNotAMeme\YappiesTesting\Views\Programs\Delete.cshtml"
               Write(Html.DisplayFor(model => model.ProgramJoinCode));

#line default
#line hidden
            EndContext();
            BeginContext(1135, 99, true);
            WriteLiteral("\r\n                </li>\r\n                <li class=\"list-group-item\">\r\n                    <strong>");
            EndContext();
            BeginContext(1235, 53, false);
#line 29 "G:\videos\Downloads\SorryBigB\SurprisinglyNotAMeme\YappiesTesting\Views\Programs\Delete.cshtml"
                       Write(Html.DisplayNameFor(model => model.ProgramSupervisor));

#line default
#line hidden
            EndContext();
            BeginContext(1288, 37, true);
            WriteLiteral("</strong><br />\r\n                    ");
            EndContext();
            BeginContext(1326, 60, false);
#line 30 "G:\videos\Downloads\SorryBigB\SurprisinglyNotAMeme\YappiesTesting\Views\Programs\Delete.cshtml"
               Write(Html.DisplayFor(model => model.ProgramSupervisor.Supervisor));

#line default
#line hidden
            EndContext();
            BeginContext(1386, 108, true);
            WriteLiteral("\r\n                </li>\r\n            </ul>\r\n        </div>\r\n        <div class=\"panel-footer\">\r\n            ");
            EndContext();
            BeginContext(1494, 180, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8689d565a9754bb59e2c00f3207fe535", async() => {
                BeginContext(1520, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(1538, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7a0c3b7416664dcdb56be20fc541ca0b", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 36 "G:\videos\Downloads\SorryBigB\SurprisinglyNotAMeme\YappiesTesting\Views\Programs\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ID);

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
                BeginContext(1574, 93, true);
                WriteLiteral("\r\n                <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" />\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1674, 34, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    ");
            EndContext();
            BeginContext(1708, 102, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b4ac9bb112247b69a86bf6805f36567", async() => {
                BeginContext(1754, 52, true);
                WriteLiteral("<span class=\"glyphicon glyphicon-arrow-left\"></span>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
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
            EndContext();
            BeginContext(1810, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<YappiesTesting.Models.Program> Html { get; private set; }
    }
}
#pragma warning restore 1591
