#pragma checksum "G:\videos\Downloads\SorryBigB\SurprisinglyNotAMeme\YappiesTesting\Views\Parents\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a178c60ed99fd4be6b86aab3c192482d7cfe53d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Parents_Details), @"mvc.1.0.view", @"/Views/Parents/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Parents/Details.cshtml", typeof(AspNetCore.Views_Parents_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a178c60ed99fd4be6b86aab3c192482d7cfe53d", @"/Views/Parents/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98f360a324d1731e4114c1541be2de55c36cea97", @"/Views/_ViewImports.cshtml")]
    public class Views_Parents_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<YappiesTesting.Models.Parent>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("float: right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "G:\videos\Downloads\SorryBigB\SurprisinglyNotAMeme\YappiesTesting\Views\Parents\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(82, 180, true);
            WriteLiteral("\r\n<div id=\"body\">\r\n    <div class=\"panel panel-default\" style=\"margin: 0px\">\r\n        <div class=\"panel-heading\">\r\n            <h3 class=\"text-center\" style=\"padding:0; margin:0;\">");
            EndContext();
            BeginContext(263, 42, false);
#line 10 "G:\videos\Downloads\SorryBigB\SurprisinglyNotAMeme\YappiesTesting\Views\Parents\Details.cshtml"
                                                            Write(Html.DisplayFor(model => model.ParentName));

#line default
#line hidden
            EndContext();
            BeginContext(305, 597, true);
            WriteLiteral(@"</h3>
        </div>
        <div style=""overflow-y:scroll; max-height:35vh;"">

        </div>
    </div>
    <div class=""panel panel-default"">
        <div class=""panel-heading"">
            <h3 class=""panel-title"">Parent Details</h3>
        </div>
        <div class=""panel-body"" style=""padding: 0"">
            <div class=""container-fluid"" style=""margin:0; padding:0;"">
                <div class=""panel panel-default"" style=""margin:0; padding:0;"">
                    <ul class=""list-group"">
                        <li class=""list-group-item"">
                            <h4>");
            EndContext();
            BeginContext(903, 46, false);
#line 25 "G:\videos\Downloads\SorryBigB\SurprisinglyNotAMeme\YappiesTesting\Views\Parents\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.ParentName));

#line default
#line hidden
            EndContext();
            BeginContext(949, 39, true);
            WriteLiteral("</h4>\r\n                            <h5>");
            EndContext();
            BeginContext(989, 42, false);
#line 26 "G:\videos\Downloads\SorryBigB\SurprisinglyNotAMeme\YappiesTesting\Views\Parents\Details.cshtml"
                           Write(Html.DisplayFor(model => model.ParentName));

#line default
#line hidden
            EndContext();
            BeginContext(1031, 124, true);
            WriteLiteral("</h5>\r\n                        </li>\r\n                        <li class=\"list-group-item\">\r\n                            <h4>");
            EndContext();
            BeginContext(1156, 41, false);
#line 29 "G:\videos\Downloads\SorryBigB\SurprisinglyNotAMeme\YappiesTesting\Views\Parents\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1197, 39, true);
            WriteLiteral("</h4>\r\n                            <h5>");
            EndContext();
            BeginContext(1237, 37, false);
#line 30 "G:\videos\Downloads\SorryBigB\SurprisinglyNotAMeme\YappiesTesting\Views\Parents\Details.cshtml"
                           Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1274, 124, true);
            WriteLiteral("</h5>\r\n                        </li>\r\n                        <li class=\"list-group-item\">\r\n                            <h4>");
            EndContext();
            BeginContext(1399, 41, false);
#line 33 "G:\videos\Downloads\SorryBigB\SurprisinglyNotAMeme\YappiesTesting\Views\Parents\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(1440, 39, true);
            WriteLiteral("</h4>\r\n                            <h5>");
            EndContext();
            BeginContext(1480, 37, false);
#line 34 "G:\videos\Downloads\SorryBigB\SurprisinglyNotAMeme\YappiesTesting\Views\Parents\Details.cshtml"
                           Write(Html.DisplayFor(model => model.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(1517, 173, true);
            WriteLiteral("</h5>\r\n                        </li>\r\n                    </ul>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"panel-footer\">\r\n            ");
            EndContext();
            BeginContext(1690, 128, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ed55859578d4fcab9b1415f61320558", async() => {
                BeginContext(1760, 54, true);
                WriteLiteral("<span class=\"glyphicon glyphicon-pencil\"></span>  Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 41 "G:\videos\Downloads\SorryBigB\SurprisinglyNotAMeme\YappiesTesting\Views\Parents\Details.cshtml"
                                   WriteLiteral(Model.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1818, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(1832, 151, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7602b30bad6b4094a88c1ce8169254f6", async() => {
                BeginContext(1924, 55, true);
                WriteLiteral("<span class=\"glyphicon glyphicon-trash\"></span>  Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 42 "G:\videos\Downloads\SorryBigB\SurprisinglyNotAMeme\YappiesTesting\Views\Parents\Details.cshtml"
                                     WriteLiteral(Model.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1983, 552, true);
            WriteLiteral(@"
        </div>
    </div>

    <!-- Program Members Panel -->
    <div class=""panel panel-default"" style=""margin: 0px; margin-bottom: .5vh"">
        <div class=""panel-heading"">
            <h2 class=""panel-title"" style=""text-decoration: none;"">
                <a data-toggle=""collapse"" data-target=""#collapseMembers"" style=""text-decoration: none; color: #000000;"">Programs</a>
            </h2>
        </div>
        <div class=""panel-collapse collapse in"" id=""collapseMembers"">
            <ul class=""list-group"" style=""margin: 0px;"">
");
            EndContext();
#line 55 "G:\videos\Downloads\SorryBigB\SurprisinglyNotAMeme\YappiesTesting\Views\Parents\Details.cshtml"
                 foreach (var item in Model.Programs)
                {

#line default
#line hidden
            BeginContext(2609, 74, true);
            WriteLiteral("                    <li class=\"list-group-item\">\r\n                        ");
            EndContext();
            BeginContext(2684, 54, false);
#line 58 "G:\videos\Downloads\SorryBigB\SurprisinglyNotAMeme\YappiesTesting\Views\Parents\Details.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Program.ProgramName));

#line default
#line hidden
            EndContext();
            BeginContext(2738, 29, true);
            WriteLiteral("\r\n                    </li>\r\n");
            EndContext();
#line 60 "G:\videos\Downloads\SorryBigB\SurprisinglyNotAMeme\YappiesTesting\Views\Parents\Details.cshtml"
                }

#line default
#line hidden
            BeginContext(2786, 83, true);
            WriteLiteral("            </ul>\r\n        </div>\r\n        <div class=\"panel-footer\">\r\n            ");
            EndContext();
            BeginContext(2869, 102, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6054184e3b5642cfbbc2cefadfb3127d", async() => {
                BeginContext(2915, 52, true);
                WriteLiteral("<span class=\"glyphicon glyphicon-arrow-left\"></span>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2971, 44, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    \r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<YappiesTesting.Models.Parent> Html { get; private set; }
    }
}
#pragma warning restore 1591