#pragma checksum "C:\Users\Zalind\Desktop\FinalPresentationAzureBuild_1\FinalPresentationAzureBuild\SurprisinglyNotAMeme\YappiesTesting\Views\Activities\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69e9332b9d204453909906f8661e231d82ea328e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Activities_Delete), @"mvc.1.0.view", @"/Views/Activities/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Activities/Delete.cshtml", typeof(AspNetCore.Views_Activities_Delete))]
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
#line 1 "C:\Users\Zalind\Desktop\FinalPresentationAzureBuild_1\FinalPresentationAzureBuild\SurprisinglyNotAMeme\YappiesTesting\Views\_ViewImports.cshtml"
using YappiesTesting;

#line default
#line hidden
#line 2 "C:\Users\Zalind\Desktop\FinalPresentationAzureBuild_1\FinalPresentationAzureBuild\SurprisinglyNotAMeme\YappiesTesting\Views\_ViewImports.cshtml"
using YappiesTesting.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69e9332b9d204453909906f8661e231d82ea328e", @"/Views/Activities/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98f360a324d1731e4114c1541be2de55c36cea97", @"/Views/_ViewImports.cshtml")]
    public class Views_Activities_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<YappiesTesting.Models.Activity>
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
            BeginContext(39, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Zalind\Desktop\FinalPresentationAzureBuild_1\FinalPresentationAzureBuild\SurprisinglyNotAMeme\YappiesTesting\Views\Activities\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(83, 448, true);
            WriteLiteral(@"<div id=""body"">
    <h1 class=""text-center"">Delete Activity</h1>
    <div class=""panel panel-default"" style=""margin-top: .5vh"">
        <div class=""panel-heading"">
            <h3 class=""panel-title"">
                Delete Activity
            </h3>
        </div>
        <div class=""panel-body"" style=""margin: 0; padding:0"">
            <ul class=""list-group"">
                <li class=""list-group-item"">
                    <strong>");
            EndContext();
            BeginContext(532, 41, false);
#line 17 "C:\Users\Zalind\Desktop\FinalPresentationAzureBuild_1\FinalPresentationAzureBuild\SurprisinglyNotAMeme\YappiesTesting\Views\Activities\Delete.cshtml"
                       Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(573, 37, true);
            WriteLiteral("</strong><br />\r\n                    ");
            EndContext();
            BeginContext(611, 37, false);
#line 18 "C:\Users\Zalind\Desktop\FinalPresentationAzureBuild_1\FinalPresentationAzureBuild\SurprisinglyNotAMeme\YappiesTesting\Views\Activities\Delete.cshtml"
               Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(648, 99, true);
            WriteLiteral("\r\n                </li>\r\n                <li class=\"list-group-item\">\r\n                    <strong>");
            EndContext();
            BeginContext(748, 47, false);
#line 21 "C:\Users\Zalind\Desktop\FinalPresentationAzureBuild_1\FinalPresentationAzureBuild\SurprisinglyNotAMeme\YappiesTesting\Views\Activities\Delete.cshtml"
                       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(795, 37, true);
            WriteLiteral("</strong><br />\r\n                    ");
            EndContext();
            BeginContext(833, 43, false);
#line 22 "C:\Users\Zalind\Desktop\FinalPresentationAzureBuild_1\FinalPresentationAzureBuild\SurprisinglyNotAMeme\YappiesTesting\Views\Activities\Delete.cshtml"
               Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(876, 99, true);
            WriteLiteral("\r\n                </li>\r\n                <li class=\"list-group-item\">\r\n                    <strong>");
            EndContext();
            BeginContext(976, 40, false);
#line 25 "C:\Users\Zalind\Desktop\FinalPresentationAzureBuild_1\FinalPresentationAzureBuild\SurprisinglyNotAMeme\YappiesTesting\Views\Activities\Delete.cshtml"
                       Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
            EndContext();
            BeginContext(1016, 37, true);
            WriteLiteral("</strong><br />\r\n                    ");
            EndContext();
            BeginContext(1054, 36, false);
#line 26 "C:\Users\Zalind\Desktop\FinalPresentationAzureBuild_1\FinalPresentationAzureBuild\SurprisinglyNotAMeme\YappiesTesting\Views\Activities\Delete.cshtml"
               Write(Html.DisplayFor(model => model.Date));

#line default
#line hidden
            EndContext();
            BeginContext(1090, 99, true);
            WriteLiteral("\r\n                </li>\r\n                <li class=\"list-group-item\">\r\n                    <strong>");
            EndContext();
            BeginContext(1190, 43, false);
#line 29 "C:\Users\Zalind\Desktop\FinalPresentationAzureBuild_1\FinalPresentationAzureBuild\SurprisinglyNotAMeme\YappiesTesting\Views\Activities\Delete.cshtml"
                       Write(Html.DisplayNameFor(model => model.Program));

#line default
#line hidden
            EndContext();
            BeginContext(1233, 37, true);
            WriteLiteral("</strong><br />\r\n                    ");
            EndContext();
            BeginContext(1271, 51, false);
#line 30 "C:\Users\Zalind\Desktop\FinalPresentationAzureBuild_1\FinalPresentationAzureBuild\SurprisinglyNotAMeme\YappiesTesting\Views\Activities\Delete.cshtml"
               Write(Html.DisplayFor(model => model.Program.ProgramName));

#line default
#line hidden
            EndContext();
            BeginContext(1322, 108, true);
            WriteLiteral("\r\n                </li>\r\n            </ul>\r\n        </div>\r\n        <div class=\"panel-footer\">\r\n            ");
            EndContext();
            BeginContext(1430, 180, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "332f918b7665423e9bca5acecd6a064e", async() => {
                BeginContext(1456, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(1474, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d5174decb78d4af887ca6e9e54dc073e", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 36 "C:\Users\Zalind\Desktop\FinalPresentationAzureBuild_1\FinalPresentationAzureBuild\SurprisinglyNotAMeme\YappiesTesting\Views\Activities\Delete.cshtml"
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
                BeginContext(1510, 93, true);
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
            BeginContext(1610, 34, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    ");
            EndContext();
            BeginContext(1644, 102, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6838d40c49824e5e81dc6d9d52b8c464", async() => {
                BeginContext(1690, 52, true);
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
            BeginContext(1746, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<YappiesTesting.Models.Activity> Html { get; private set; }
    }
}
#pragma warning restore 1591
