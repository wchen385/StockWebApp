#pragma checksum "/Users/ryanchen1/Documents/GitHub/StocksWebApp/StocksWebApp/Views/HistoricalStock/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f4dd5e61393b63b715df8e150b751156cc92757"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HistoricalStock_Index), @"mvc.1.0.view", @"/Views/HistoricalStock/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/HistoricalStock/Index.cshtml", typeof(AspNetCore.Views_HistoricalStock_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f4dd5e61393b63b715df8e150b751156cc92757", @"/Views/HistoricalStock/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"741b55e56a7b9efbd5b4d3491821d6aa44d7b70e", @"/Views/_ViewImports.cshtml")]
    public class Views_HistoricalStock_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HistoricalStockViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/chartist-plugin-tooltip.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/chartist.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/chartist.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/chartist-plugin-tooltip.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 82, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "495e64fa82854a35883a77835572bae9", async() => {
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
            BeginContext(114, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(115, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "050d532384964bbfa57e37018ff6564f", async() => {
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
            BeginContext(170, 280, true);
            WriteLiteral(@"
<link rel=""stylesheet"" href=""//code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css"">
<link rel=""stylesheet"" href=""/resources/demos/style.css"">
<script src=""https://code.jquery.com/jquery-1.12.4.js""></script>
<script src=""https://code.jquery.com/ui/1.12.1/jquery-ui.js""></script>
");
            EndContext();
            BeginContext(450, 44, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d8609fbc21784150b4dec53c0afe4ba8", async() => {
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
            BeginContext(494, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(495, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45fbbfae420b451c9bc77d2c91e7adff", async() => {
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
            BeginContext(550, 6, true);
            WriteLiteral("\n\n\n\n\n\n");
            EndContext();
            BeginContext(590, 38, true);
            WriteLiteral("<div>\n    <select id=\"companySelect\">\n");
            EndContext();
#line 18 "/Users/ryanchen1/Documents/GitHub/StocksWebApp/StocksWebApp/Views/HistoricalStock/Index.cshtml"
         foreach (var companyKey in Model.CompanyDict.Keys)
        {

#line default
#line hidden
            BeginContext(698, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(710, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a66c93e62a554a73a1b31343e6052933", async() => {
                BeginContext(739, 29, false);
#line 20 "/Users/ryanchen1/Documents/GitHub/StocksWebApp/StocksWebApp/Views/HistoricalStock/Index.cshtml"
                                   Write(Model.CompanyDict[companyKey]);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 20 "/Users/ryanchen1/Documents/GitHub/StocksWebApp/StocksWebApp/Views/HistoricalStock/Index.cshtml"
               WriteLiteral(companyKey);

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
            BeginContext(777, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 21 "/Users/ryanchen1/Documents/GitHub/StocksWebApp/StocksWebApp/Views/HistoricalStock/Index.cshtml"
        }

#line default
#line hidden
            BeginContext(788, 22, true);
            WriteLiteral("    </select>\n</div>\n\n");
            EndContext();
            BeginContext(846, 370, true);
            WriteLiteral(@"<div>
    <button type=""button"" class=""date-button"" value=""0"">1 Day</button>
    <button type=""button"" class=""date-button"" value=""1"">1 Month</button>
    <button type=""button"" class=""date-button"" value=""2"">3 Months</button>
    <button type=""button"" class=""date-button"" value=""3"">6 Months</button>
    <button type=""button"" class=""date-button"" value=""4"">1 Year</button>
");
            EndContext();
            BeginContext(1246, 226, true);
            WriteLiteral("    <span>Custom Range</span>\n    <input type=\"text\" class=\"date-pick\" id=\"startDate\" />\n    <input type=\"text\" class=\"date-pick\" id=\"endDate\" />\n    <button type=\"button\" class=\"date-button\" value=\"5\">Submit</button>\n</div>\n\n");
            EndContext();
            BeginContext(1504, 4037, true);
            WriteLiteral(@"<div class=""ct-chart"" style=""position:relative;""></div>

<script>
    //Updates the chart with the new data
    function refreshTable(company, startDate, endDate) {
        var reqData = { Company: company, StartDate: dateString(startDate), EndDate: dateString(endDate) }
        //Make POST request to controller to get new data
        $.ajax({
        type: ""POST"",
            url: ""/HistoricalStock/Update"",
            data: reqData,
            success: function (response) {
                var dates = response.dates;
                var prices = response.prices;
                var newData = { labels: dates, series: [prices] };
                var newoptions = {
                    width: '100%',
                    height: 400,
                    axisX: {
                        labelInterpolationFnc: function skipLabels(value, index) {
                        return index % 2 === 0 ? value : null;
                        }
                    }
                };

                //Empty chart and crea");
            WriteLiteral(@"te new one
                $('.ct-chart').empty();
                new Chartist.Line('.ct-chart', newData, newoptions);

        }
    });
    }

    //Format Date object as string
    function dateString(date) {
        var day = date.getDate().toString().padStart(2,'0');       // yields date
        var month = date.getMonth() + 1;
        month = month.toString().padStart(2, '0');// yields month (add one as '.getMonth()' is zero indexed)
        var year = date.getFullYear();  // yields year
        var hour = date.getHours().toString().padStart(2,'0');     // yields hours
        var minute = date.getMinutes().toString().padStart(2,'0'); // yields minutes
        var second = date.getSeconds().toString().padStart(2,'0'); // yields seconds

        // After this construct a string with the above results as below
        var time = day + ""/"" + month + ""/"" + year + "" "" + hour + ':' + minute + ':' + second;
        return time;
    }

    //Initialize datepicker listener
    $('.date-pick').datepicker({ chang");
            WriteLiteral(@"eMonth: true, changeYear: true });

    //Initialize company select listener
    $(""#companySelect"").change(function () {
        //After changing company, update chart with 1 day range for that company
        var startDate = new Date(2011, 0, 13);
        var endDate = new Date(2011, 0, 13, 23, 59, 59);
        var company = $('#companySelect').val();
        refreshTable(company, startDate, endDate);
    });

    //Initialize daterange button listener
    $('.date-button').on(""click"", function ()
    {
        //Default start date except for custom date range
        var startDate = new Date(2011, 0, 13);
        var endDate;

        var valu = parseInt($(this).val());
        switch (valu)
        {
            //1 day range
            case 0:
                endDate = new Date(2011, 0, 13, 23, 59, 59);
                break;
            //1 month range
            case 1:
                endDate = new Date(2011, 1, 13, 23, 59, 59);
                break;
            //3 month range
            case 2:
");
            WriteLiteral(@"                endDate = new Date(2011, 3, 13, 23, 59, 59);
                break;
            //6 month range
            case 3:
                endDate = new Date(2011, 6, 13, 23, 59, 59);
                break;
            //1 year range
            case 4:
                endDate = new Date(2011, 11, 13, 23, 59, 59);
                break;
            //Custom range
            case 5:
                var startDateNums = $('#startDate').val().split('/');
                startDate = new Date(startDateNums[2], startDateNums[0]-1, startDateNums[1], 0, 0, 0);
                var endDateNums = $('#endDate').val().split('/');
                endDate = new Date(endDateNums[2], endDateNums[0]-1, endDateNums[1], 23, 59, 59);
                break;

        };
        var company = $('#companySelect').val();
        refreshTable(company, startDate, endDate);
    });

    //Create table on initial page load
    var labelData = [];
    var seriesData = [];
");
            EndContext();
#line 146 "/Users/ryanchen1/Documents/GitHub/StocksWebApp/StocksWebApp/Views/HistoricalStock/Index.cshtml"
     foreach (var label in Model.Dates)
    {

#line default
#line hidden
            BeginContext(5587, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(5597, 16, true);
            WriteLiteral("labelData.push(\"");
            EndContext();
            BeginContext(5614, 5, false);
#line 148 "/Users/ryanchen1/Documents/GitHub/StocksWebApp/StocksWebApp/Views/HistoricalStock/Index.cshtml"
                     Write(label);

#line default
#line hidden
            EndContext();
            BeginContext(5619, 4, true);
            WriteLiteral("\");\n");
            EndContext();
#line 149 "/Users/ryanchen1/Documents/GitHub/StocksWebApp/StocksWebApp/Views/HistoricalStock/Index.cshtml"
    }

#line default
#line hidden
            BeginContext(5629, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 150 "/Users/ryanchen1/Documents/GitHub/StocksWebApp/StocksWebApp/Views/HistoricalStock/Index.cshtml"
     foreach (var price in Model.Prices)
    {

#line default
#line hidden
            BeginContext(5676, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(5686, 17, true);
            WriteLiteral("seriesData.push(\"");
            EndContext();
            BeginContext(5704, 5, false);
#line 152 "/Users/ryanchen1/Documents/GitHub/StocksWebApp/StocksWebApp/Views/HistoricalStock/Index.cshtml"
                      Write(price);

#line default
#line hidden
            EndContext();
            BeginContext(5709, 4, true);
            WriteLiteral("\");\n");
            EndContext();
#line 153 "/Users/ryanchen1/Documents/GitHub/StocksWebApp/StocksWebApp/Views/HistoricalStock/Index.cshtml"
    }

#line default
#line hidden
            BeginContext(5719, 490, true);
            WriteLiteral(@"    console.log(labelData);
    var data = {
        labels: labelData,

        series: [
            seriesData
        ]
    };

    //Show an x axis gridline every n points
    var n = 2;
    var options = {
        width: '100%',
        height: 400,
        axisX: {
            labelInterpolationFnc: function skipLabels(value, index) {
                return index % n === 0 ? value : null;
            }
        }
    };
    new Chartist.Line('.ct-chart', data, options);
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HistoricalStockViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591