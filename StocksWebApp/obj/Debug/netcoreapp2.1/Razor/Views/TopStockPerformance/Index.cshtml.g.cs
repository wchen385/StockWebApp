#pragma checksum "/Users/ryanchen1/Documents/GitHub/StocksWebApp/StocksWebApp/Views/TopStockPerformance/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "96404b815dd54f78a31f18dbd189689d736428fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TopStockPerformance_Index), @"mvc.1.0.view", @"/Views/TopStockPerformance/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/TopStockPerformance/Index.cshtml", typeof(AspNetCore.Views_TopStockPerformance_Index))]
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
#line 1 "/Users/ryanchen1/Documents/GitHub/StocksWebApp/StocksWebApp/Views/_ViewImports.cshtml"
using StocksWebApp;

#line default
#line hidden
#line 2 "/Users/ryanchen1/Documents/GitHub/StocksWebApp/StocksWebApp/Views/_ViewImports.cshtml"
using StocksWebApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96404b815dd54f78a31f18dbd189689d736428fb", @"/Views/TopStockPerformance/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"741b55e56a7b9efbd5b4d3491821d6aa44d7b70e", @"/Views/_ViewImports.cshtml")]
    public class Views_TopStockPerformance_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TopStockPerformanceViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/chartist-plugin-tooltip.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/chartist.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/chartist.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/chartist-plugin-tooltip.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selected", new global::Microsoft.AspNetCore.Html.HtmlString("selected"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "filter", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/ryanchen1/Documents/GitHub/StocksWebApp/StocksWebApp/Views/TopStockPerformance/Index.cshtml"
  
    ViewData["Title"] = "Top Stock Performer";

#line default
#line hidden
            BeginContext(88, 82, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d552b9d8f2424ad3b0ee62b061c5bcde", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(170, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(171, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d9f2e243c5ef474e872f0018dcc03117", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(226, 280, true);
            WriteLiteral(@"
<link rel=""stylesheet"" href=""//code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css"">
<link rel=""stylesheet"" href=""/resources/demos/style.css"">
<script src=""https://code.jquery.com/jquery-1.12.4.js""></script>
<script src=""https://code.jquery.com/ui/1.12.1/jquery-ui.js""></script>
");
            EndContext();
            BeginContext(506, 44, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bbb522a965b446c1bdd18c08b3e4eb2d", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(550, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(551, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c24c5cdc335e4ef2b29040ea217250dc", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(606, 728, true);
            WriteLiteral(@"

<style>
    .header {
        display: inline-block;
        background-image: url('/images/banner5.jpg');
        width: 100%;
        height: 200px;
        background-size: cover;
        margin-bottom: 15px;
        box-shadow: 0px 5px 5px 0px #ccc;
    }

        .header h1 {
            background-color: rgb(255, 255, 255, 0.5);
            padding: 5px;
            padding-left: 20px;
            margin-top: 140px;
            text-shadow: 2px 2px 2px rgba(0,0,0,0.3);
        }

    #kpiSelect {
        margin-bottom: 10px;
    }
    .date-selection-section {
        margin-bottom: 10px;
    }
    .submit-button {
        margin-top: 10px;
    }
</style>

<div class=""row"">
    <div class=""header"">
        <h1>");
            EndContext();
            BeginContext(1335, 17, false);
#line 46 "/Users/ryanchen1/Documents/GitHub/StocksWebApp/StocksWebApp/Views/TopStockPerformance/Index.cshtml"
       Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(1352, 26, true);
            WriteLiteral("</h1>\n    </div>\n\n</div>\n\n");
            EndContext();
            BeginContext(1412, 54, true);
            WriteLiteral("<div class=\"row\">\n    <div class=\"jumbotron\">\n        ");
            EndContext();
            BeginContext(1466, 1665, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b950abd8a8db481c8e5ab54e5b91204e", async() => {
                BeginContext(1507, 79, true);
                WriteLiteral("\n            <select id=\"kpiSelect\" name=\"kpiSelectMenu\" class=\"form-control\">\n");
                EndContext();
#line 56 "/Users/ryanchen1/Documents/GitHub/StocksWebApp/StocksWebApp/Views/TopStockPerformance/Index.cshtml"
                 foreach (var kpiKey in Model.kpiDict.Keys)
                {
                    

#line default
#line hidden
#line 58 "/Users/ryanchen1/Documents/GitHub/StocksWebApp/StocksWebApp/Views/TopStockPerformance/Index.cshtml"
                     if (string.Compare(kpiKey, Model.kpi) == 0)
                    {

#line default
#line hidden
                BeginContext(1751, 24, true);
                WriteLiteral("                        ");
                EndContext();
                BeginContext(1775, 75, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "462a7faaaff946c0a89070bdb82d644c", async() => {
                    BeginContext(1820, 21, false);
#line 60 "/Users/ryanchen1/Documents/GitHub/StocksWebApp/StocksWebApp/Views/TopStockPerformance/Index.cshtml"
                                                               Write(Model.kpiDict[kpiKey]);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                BeginWriteTagHelperAttribute();
#line 60 "/Users/ryanchen1/Documents/GitHub/StocksWebApp/StocksWebApp/Views/TopStockPerformance/Index.cshtml"
                                               WriteLiteral(kpiKey);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1850, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 61 "/Users/ryanchen1/Documents/GitHub/StocksWebApp/StocksWebApp/Views/TopStockPerformance/Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
                BeginContext(1920, 24, true);
                WriteLiteral("                        ");
                EndContext();
                BeginContext(1944, 55, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b6914f999f344df5b8d29fc84a45b7aa", async() => {
                    BeginContext(1969, 21, false);
#line 64 "/Users/ryanchen1/Documents/GitHub/StocksWebApp/StocksWebApp/Views/TopStockPerformance/Index.cshtml"
                                           Write(Model.kpiDict[kpiKey]);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 64 "/Users/ryanchen1/Documents/GitHub/StocksWebApp/StocksWebApp/Views/TopStockPerformance/Index.cshtml"
                           WriteLiteral(kpiKey);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1999, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 65 "/Users/ryanchen1/Documents/GitHub/StocksWebApp/StocksWebApp/Views/TopStockPerformance/Index.cshtml"
                    }

#line default
#line hidden
#line 65 "/Users/ryanchen1/Documents/GitHub/StocksWebApp/StocksWebApp/Views/TopStockPerformance/Index.cshtml"
                     
                }

#line default
#line hidden
                BeginContext(2040, 98, true);
                WriteLiteral("            </select>\n            <div class=\"btn-group btn-group-toggle\" data-toggle=\"buttons\">\n\n");
                EndContext();
#line 70 "/Users/ryanchen1/Documents/GitHub/StocksWebApp/StocksWebApp/Views/TopStockPerformance/Index.cshtml"
                 foreach (var tp in Model.timePeriods)
                {
                    

#line default
#line hidden
#line 72 "/Users/ryanchen1/Documents/GitHub/StocksWebApp/StocksWebApp/Views/TopStockPerformance/Index.cshtml"
                     if (tp == Model.timePeriod)
                    {

#line default
#line hidden
                BeginContext(2282, 91, true);
                WriteLiteral("                        <label class=\"btn btn-default active\">\n                            ");
                EndContext();
                BeginContext(2374, 50, false);
#line 75 "/Users/ryanchen1/Documents/GitHub/StocksWebApp/StocksWebApp/Views/TopStockPerformance/Index.cshtml"
                       Write(Html.RadioButtonFor(Model => Model.timePeriod, tp));

#line default
#line hidden
                EndContext();
                BeginContext(2424, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(2426, 2, false);
#line 75 "/Users/ryanchen1/Documents/GitHub/StocksWebApp/StocksWebApp/Views/TopStockPerformance/Index.cshtml"
                                                                           Write(tp);

#line default
#line hidden
                EndContext();
                BeginContext(2428, 156, true);
                WriteLiteral("\n                            <!--<input type=\"radio\" name=\"inlineRadioOptions\" id=\"inlineRadio1\" value=\"option1\"> 1 Day-->\n                        </label>\n");
                EndContext();
#line 78 "/Users/ryanchen1/Documents/GitHub/StocksWebApp/StocksWebApp/Views/TopStockPerformance/Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
                BeginContext(2653, 84, true);
                WriteLiteral("                        <label class=\"btn btn-default\">\n                            ");
                EndContext();
                BeginContext(2738, 50, false);
#line 82 "/Users/ryanchen1/Documents/GitHub/StocksWebApp/StocksWebApp/Views/TopStockPerformance/Index.cshtml"
                       Write(Html.RadioButtonFor(Model => Model.timePeriod, tp));

#line default
#line hidden
                EndContext();
                BeginContext(2788, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(2790, 2, false);
#line 82 "/Users/ryanchen1/Documents/GitHub/StocksWebApp/StocksWebApp/Views/TopStockPerformance/Index.cshtml"
                                                                           Write(tp);

#line default
#line hidden
                EndContext();
                BeginContext(2792, 156, true);
                WriteLiteral("\n                            <!--<input type=\"radio\" name=\"inlineRadioOptions\" id=\"inlineRadio1\" value=\"option1\"> 1 Day-->\n                        </label>\n");
                EndContext();
#line 85 "/Users/ryanchen1/Documents/GitHub/StocksWebApp/StocksWebApp/Views/TopStockPerformance/Index.cshtml"
                    }

#line default
#line hidden
#line 85 "/Users/ryanchen1/Documents/GitHub/StocksWebApp/StocksWebApp/Views/TopStockPerformance/Index.cshtml"
                     


                }

#line default
#line hidden
                BeginContext(2990, 134, true);
                WriteLiteral("            </div>\n            <br />\n            <button type=\"submit\" class=\"btn btn-primary submit-button\">Search</button>\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3131, 21, true);
            WriteLiteral("\n    </div>\n</div>\n\n\n");
            EndContext();
            BeginContext(3188, 328, true);
            WriteLiteral(@"    <div class=""row"">
        <div class=""panel-group"" id=""accordion"">
            <div class=""panel panel-default"">
                <div class=""panel-heading"">
                    <h4 class=""panel-title"">
                        <a data-toggle=""collapse"" data-parent=""#accordion"" href=""#collapse1"">
                            ");
            EndContext();
            BeginContext(3517, 24, false);
#line 104 "/Users/ryanchen1/Documents/GitHub/StocksWebApp/StocksWebApp/Views/TopStockPerformance/Index.cshtml"
                       Write(Model.kpiDict[Model.kpi]);

#line default
#line hidden
            EndContext();
            BeginContext(3541, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(3545, 16, false);
#line 104 "/Users/ryanchen1/Documents/GitHub/StocksWebApp/StocksWebApp/Views/TopStockPerformance/Index.cshtml"
                                                   Write(Model.timePeriod);

#line default
#line hidden
            EndContext();
            BeginContext(3561, 603, true);
            WriteLiteral(@" Days
                        </a>
                    </h4>
                </div>
                <div id=""collapse1"" class=""panel-collapse collapse in"">
                    <div class=""panel-body"">
                        <table class=""table table-hover"">
                            <tbody>
                                <tr>
                                    <th scope=""row""></th>
                                    <th>Company Abbreviation</th>
                                    <th>Company Name</th>
                                    <th>Price</th>
                                </tr>
");
            EndContext();
#line 119 "/Users/ryanchen1/Documents/GitHub/StocksWebApp/StocksWebApp/Views/TopStockPerformance/Index.cshtml"
                                 foreach (var row in Model.companiesKPI)
                                {

#line default
#line hidden
            BeginContext(4319, 97, true);
            WriteLiteral("                                    <tr>\n                                        <td scope=\"row\">");
            EndContext();
            BeginContext(4417, 8, false);
#line 122 "/Users/ryanchen1/Documents/GitHub/StocksWebApp/StocksWebApp/Views/TopStockPerformance/Index.cshtml"
                                                   Write(row.rank);

#line default
#line hidden
            EndContext();
            BeginContext(4425, 50, true);
            WriteLiteral("</td>\n                                        <td>");
            EndContext();
            BeginContext(4476, 16, false);
#line 123 "/Users/ryanchen1/Documents/GitHub/StocksWebApp/StocksWebApp/Views/TopStockPerformance/Index.cshtml"
                                       Write(row.companyAbriv);

#line default
#line hidden
            EndContext();
            BeginContext(4492, 50, true);
            WriteLiteral("</td>\n                                        <td>");
            EndContext();
            BeginContext(4543, 15, false);
#line 124 "/Users/ryanchen1/Documents/GitHub/StocksWebApp/StocksWebApp/Views/TopStockPerformance/Index.cshtml"
                                       Write(row.companyName);

#line default
#line hidden
            EndContext();
            BeginContext(4558, 50, true);
            WriteLiteral("</td>\n                                        <td>");
            EndContext();
            BeginContext(4609, 9, false);
#line 125 "/Users/ryanchen1/Documents/GitHub/StocksWebApp/StocksWebApp/Views/TopStockPerformance/Index.cshtml"
                                       Write(row.value);

#line default
#line hidden
            EndContext();
            BeginContext(4618, 48, true);
            WriteLiteral("</td>\n                                    </tr>\n");
            EndContext();
#line 127 "/Users/ryanchen1/Documents/GitHub/StocksWebApp/StocksWebApp/Views/TopStockPerformance/Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(4700, 183, true);
            WriteLiteral("\n                            </tbody>\n                        </table>\n                    </div>\n                </div>\n            </div>\n        </div>\n    </div>\n\n\n\n    </script>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TopStockPerformanceViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
