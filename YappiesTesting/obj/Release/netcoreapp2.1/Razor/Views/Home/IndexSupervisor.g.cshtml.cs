#pragma checksum "G:\videos\Downloads\SorryBigB\SurprisinglyNotAMeme\YappiesTesting\Views\Home\IndexSupervisor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "348b6b1e95d399a43aa99edd253c332b689322d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_IndexSupervisor), @"mvc.1.0.view", @"/Views/Home/IndexSupervisor.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/IndexSupervisor.cshtml", typeof(AspNetCore.Views_Home_IndexSupervisor))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"348b6b1e95d399a43aa99edd253c332b689322d3", @"/Views/Home/IndexSupervisor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98f360a324d1731e4114c1541be2de55c36cea97", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_IndexSupervisor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<YappiesTesting.Models.ProgramSupervisor>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Programs", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("text-decoration:none; color:black; cursor:auto; margin-top:0px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Conversations", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "IndexPS", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-id", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "G:\videos\Downloads\SorryBigB\SurprisinglyNotAMeme\YappiesTesting\Views\Home\IndexSupervisor.cshtml"
  
    ViewData["Title"] = "Home Page";
    int programCount = Model.Programs.Count();
    int announcementCount = 1;

#line default
#line hidden
            BeginContext(173, 683, true);
            WriteLiteral(@"

<div style=""padding:0.5vh; background-color:#e0e0e0"">
<div class=""container"" id=""body"" style=""padding:0px;"">
    <div class=""panel panel-default"" style=""margin: 0px"">
        <div class=""panel-heading"">
            <h3 class=""text-center"" style=""padding:0; margin:0;"">Dashboard</h3>
        </div>
        <div style=""overflow-y:scroll; max-height:35vh;"">

        </div>
    </div>
    <div class=""panel panel-default"" style=""width: 100%; margin-bottom:0.5vh;"">
        <div class=""panel-heading"">
            <h3 class=""panel-title"">Announcements</h3>
        </div>
        <div style=""overflow-y:scroll; max-height:35vh;"">
            <ul class=""list-group"">
");
            EndContext();
#line 25 "G:\videos\Downloads\SorryBigB\SurprisinglyNotAMeme\YappiesTesting\Views\Home\IndexSupervisor.cshtml"
                 foreach (var item in Model.Programs)
                {
                    

#line default
#line hidden
#line 27 "G:\videos\Downloads\SorryBigB\SurprisinglyNotAMeme\YappiesTesting\Views\Home\IndexSupervisor.cshtml"
                     foreach (var announcement in item.Announcements)
                    {

#line default
#line hidden
            BeginContext(1024, 86, true);
            WriteLiteral("                        <li class=\"list-group-item\">\r\n                            <h4>");
            EndContext();
            BeginContext(1111, 48, false);
#line 30 "G:\videos\Downloads\SorryBigB\SurprisinglyNotAMeme\YappiesTesting\Views\Home\IndexSupervisor.cshtml"
                           Write(Html.DisplayFor(modelItem => announcement.Title));

#line default
#line hidden
            EndContext();
            BeginContext(1159, 27, true);
            WriteLiteral("<span class=\" pull-right\">#");
            EndContext();
            BeginContext(1187, 17, false);
#line 30 "G:\videos\Downloads\SorryBigB\SurprisinglyNotAMeme\YappiesTesting\Views\Home\IndexSupervisor.cshtml"
                                                                                                       Write(announcementCount);

#line default
#line hidden
            EndContext();
            BeginContext(1204, 45, true);
            WriteLiteral("</span></h4>\r\n                            <p>");
            EndContext();
            BeginContext(1250, 47, false);
#line 31 "G:\videos\Downloads\SorryBigB\SurprisinglyNotAMeme\YappiesTesting\Views\Home\IndexSupervisor.cshtml"
                          Write(Html.DisplayFor(modelItem => announcement.Body));

#line default
#line hidden
            EndContext();
            BeginContext(1297, 37, true);
            WriteLiteral("</p>\r\n                        </li>\r\n");
            EndContext();
#line 33 "G:\videos\Downloads\SorryBigB\SurprisinglyNotAMeme\YappiesTesting\Views\Home\IndexSupervisor.cshtml"
                        announcementCount++;
                    }

#line default
#line hidden
#line 34 "G:\videos\Downloads\SorryBigB\SurprisinglyNotAMeme\YappiesTesting\Views\Home\IndexSupervisor.cshtml"
                     
                }

#line default
#line hidden
            BeginContext(1422, 16, true);
            WriteLiteral("                ");
            EndContext();
#line 36 "G:\videos\Downloads\SorryBigB\SurprisinglyNotAMeme\YappiesTesting\Views\Home\IndexSupervisor.cshtml"
                 foreach (var item in ViewBag.Announcements)
                {

#line default
#line hidden
            BeginContext(1503, 78, true);
            WriteLiteral("                    <li class=\"list-group-item\">\r\n                        <h4>");
            EndContext();
            BeginContext(1582, 10, false);
#line 39 "G:\videos\Downloads\SorryBigB\SurprisinglyNotAMeme\YappiesTesting\Views\Home\IndexSupervisor.cshtml"
                       Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1592, 27, true);
            WriteLiteral("<span class=\" pull-right\">#");
            EndContext();
            BeginContext(1620, 17, false);
#line 39 "G:\videos\Downloads\SorryBigB\SurprisinglyNotAMeme\YappiesTesting\Views\Home\IndexSupervisor.cshtml"
                                                             Write(announcementCount);

#line default
#line hidden
            EndContext();
            BeginContext(1637, 41, true);
            WriteLiteral("</span></h4>\r\n                        <p>");
            EndContext();
            BeginContext(1679, 9, false);
#line 40 "G:\videos\Downloads\SorryBigB\SurprisinglyNotAMeme\YappiesTesting\Views\Home\IndexSupervisor.cshtml"
                      Write(item.Body);

#line default
#line hidden
            EndContext();
            BeginContext(1688, 33, true);
            WriteLiteral("</p>\r\n                    </li>\r\n");
            EndContext();
#line 42 "G:\videos\Downloads\SorryBigB\SurprisinglyNotAMeme\YappiesTesting\Views\Home\IndexSupervisor.cshtml"
                    announcementCount++;
                }

#line default
#line hidden
            BeginContext(1782, 387, true);
            WriteLiteral(@"            </ul>
        </div>
    </div>
</div>
<div class=""container"" style=""padding:0px;"">
    <div class=""panel panel-default"" style=""width: 100%; margin-bottom:0.5vh;"">
        <div class=""panel-heading"">
            <h3 class=""panel-title"">Your Programs</h3>
        </div>
        <div style=""overflow-y:scroll; max-height:50vh;"">
            <ul class=""list-group"">
");
            EndContext();
#line 55 "G:\videos\Downloads\SorryBigB\SurprisinglyNotAMeme\YappiesTesting\Views\Home\IndexSupervisor.cshtml"
                 foreach (var item in Model.Programs)
                {

#line default
#line hidden
            BeginContext(2243, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(2263, 476, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3973fee9240c435f980901235bcbc9c7", async() => {
                BeginContext(2451, 88, true);
                WriteLiteral("\r\n                        <li class=\"list-group-item\">\r\n                            <h4>");
                EndContext();
                BeginContext(2540, 46, false);
#line 59 "G:\videos\Downloads\SorryBigB\SurprisinglyNotAMeme\YappiesTesting\Views\Home\IndexSupervisor.cshtml"
                           Write(Html.DisplayFor(modelItem => item.ProgramName));

#line default
#line hidden
                EndContext();
                BeginContext(2586, 38, true);
                WriteLiteral("</h4>\r\n                            <p>");
                EndContext();
                BeginContext(2625, 53, false);
#line 60 "G:\videos\Downloads\SorryBigB\SurprisinglyNotAMeme\YappiesTesting\Views\Home\IndexSupervisor.cshtml"
                          Write(Html.DisplayFor(modelItem => item.ProgramDescription));

#line default
#line hidden
                EndContext();
                BeginContext(2678, 57, true);
                WriteLiteral("</p>\r\n                        </li>\r\n                    ");
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
#line 57 "G:\videos\Downloads\SorryBigB\SurprisinglyNotAMeme\YappiesTesting\Views\Home\IndexSupervisor.cshtml"
                                              WriteLiteral(item.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            BeginWriteTagHelperAttribute();
#line 57 "G:\videos\Downloads\SorryBigB\SurprisinglyNotAMeme\YappiesTesting\Views\Home\IndexSupervisor.cshtml"
                                                                                                                 WriteLiteral(Model.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ProgramSupervisorID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-ProgramSupervisorID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ProgramSupervisorID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2739, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 63 "G:\videos\Downloads\SorryBigB\SurprisinglyNotAMeme\YappiesTesting\Views\Home\IndexSupervisor.cshtml"
                }

#line default
#line hidden
            BeginContext(2760, 261, true);
            WriteLiteral(@"            </ul>
        </div>
    </div>
</div>
</div>
<div class=""messageContainer"" style=""max-height:20vh; width: 100%;"">
    <div class=""panel-footer"">
        <h4 class=""panel-title"">
            <span class=""glyphicon glyphicon-envelope""></span>");
            EndContext();
            BeginContext(3021, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4761dd76e0674fb1a8a5980b09e8500d", async() => {
                BeginContext(3076, 9, true);
                WriteLiteral(" Messages");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3089, 107, true);
            WriteLiteral("\r\n        </h4>\r\n    </div>\r\n    <div class=\"panel-footer\">\r\n        <h4 class=\"panel-title\">\r\n            ");
            EndContext();
            BeginContext(3196, 121, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e47b36c3eaf942f1808f15356e8b2c7b", async() => {
                BeginContext(3231, 82, true);
                WriteLiteral("<span class=\"glyphicon glyphicon-exclamation-sign\"></span>   Program Join Requests");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3317, 107, true);
            WriteLiteral("\r\n        </h4>\r\n    </div>\r\n    <div class=\"panel-footer\">\r\n        <h4 class=\"panel-title\">\r\n            ");
            EndContext();
            BeginContext(3424, 114, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a96ece7ef1e49b88c1b43ef9738bf88", async() => {
                BeginContext(3475, 59, true);
                WriteLiteral("<span class=\"glyphicon glyphicon-wrench\"></span>   Settings");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3538, 37, true);
            WriteLiteral("\r\n        </h4>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<YappiesTesting.Models.ProgramSupervisor> Html { get; private set; }
    }
}
#pragma warning restore 1591
