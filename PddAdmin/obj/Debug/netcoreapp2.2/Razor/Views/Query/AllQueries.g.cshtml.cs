#pragma checksum "C:\My Program Files\Sources\PddAdmin\PddAdmin\Views\Query\AllQueries.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c455c63afb1f349de627eab3b72e7c773d350a90"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Query_AllQueries), @"mvc.1.0.view", @"/Views/Query/AllQueries.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Query/AllQueries.cshtml", typeof(AspNetCore.Views_Query_AllQueries))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c455c63afb1f349de627eab3b72e7c773d350a90", @"/Views/Query/AllQueries.cshtml")]
    public class Views_Query_AllQueries : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PddAdmin.Models.QueryItem>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\My Program Files\Sources\PddAdmin\PddAdmin\Views\Query\AllQueries.cshtml"
  
    ViewData["Title"] = "AllQueries";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(142, 1329, true);
            WriteLiteral(@"<style>
    .row {
        display: -ms-flexbox;
        display: flex;
        -ms-flex-wrap: wrap;
        flex-wrap: wrap;
        margin-right: 0px !important;
        margin-left: 0px !important;
    }

    .collapsible {
        border-style: solid;
        border-width: 2px;
        background-color: #777;
        color: white;
        cursor: pointer;
        /*padding: 18px;*/
        width: 100%;
        text-align: left;
        outline: none;
        font-size: 15px;
        font-weight: bolder;
        border-color: #f1f1f1;
    }

        .active, .collapsible:hover {
            background-color: #555;
        }

    /*.collapsible:after {
            content: '\002B';
            color: white;
            font-weight: bold;
            float: right;
            margin-left: 5px;
        }*/

    /*.active:after {
        content: ""\2212"";
    }*/

    .content {
        padding: 0 18px;
        /*max-height: 0;*/
        overflow: hidden;
        tr");
            WriteLiteral(@"ansition: max-height 0.2s ease-out;
        background-color: #f1f1f1;
    }
</style>

<h1>AllQueries</h1>

<p>
    <a href=""/Query/CreateQuery"">Create New</a>
</p>


<div class=""row"" style=""background-color:#cdcdcd; min-height:60px; font-weight:bolder;"">
    <div class=""col-md-3"">
        ");
            EndContext();
            BeginContext(1472, 41, false);
#line 66 "C:\My Program Files\Sources\PddAdmin\PddAdmin\Views\Query\AllQueries.cshtml"
   Write(Html.DisplayNameFor(model => model.Query));

#line default
#line hidden
            EndContext();
            BeginContext(1513, 50, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col-md-2\">\r\n        ");
            EndContext();
            BeginContext(1564, 44, false);
#line 69 "C:\My Program Files\Sources\PddAdmin\PddAdmin\Views\Query\AllQueries.cshtml"
   Write(Html.DisplayNameFor(model => model.ImageUri));

#line default
#line hidden
            EndContext();
            BeginContext(1608, 50, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col-md-2\">\r\n        ");
            EndContext();
            BeginContext(1659, 41, false);
#line 72 "C:\My Program Files\Sources\PddAdmin\PddAdmin\Views\Query\AllQueries.cshtml"
   Write(Html.DisplayNameFor(model => model.Thema));

#line default
#line hidden
            EndContext();
            BeginContext(1700, 50, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col-md-3\">\r\n        ");
            EndContext();
            BeginContext(1751, 43, false);
#line 75 "C:\My Program Files\Sources\PddAdmin\PddAdmin\Views\Query\AllQueries.cshtml"
   Write(Html.DisplayNameFor(model => model.Comment));

#line default
#line hidden
            EndContext();
            BeginContext(1794, 81, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col-md-2\">\r\n        Actions\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
#line 82 "C:\My Program Files\Sources\PddAdmin\PddAdmin\Views\Query\AllQueries.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
            BeginContext(1908, 104, true);
            WriteLiteral("    <div class=\"row collapsible\" style=\"min-height:60px;\">\r\n        <div class=\"col-md-3\">\r\n            ");
            EndContext();
            BeginContext(2013, 40, false);
#line 86 "C:\My Program Files\Sources\PddAdmin\PddAdmin\Views\Query\AllQueries.cshtml"
       Write(Html.DisplayFor(modelItem => item.Query));

#line default
#line hidden
            EndContext();
            BeginContext(2053, 66, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-md-2\">\r\n            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2119, "\"", 2149, 1);
#line 89 "C:\My Program Files\Sources\PddAdmin\PddAdmin\Views\Query\AllQueries.cshtml"
WriteAttributeValue("", 2125, "/img"+@item.ImageUri, 2125, 24, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2150, 100, true);
            WriteLiteral(" style=\"height:50px;max-width:70px;\"/>\r\n        </div>\r\n        <div class=\"col-md-2\">\r\n            ");
            EndContext();
            BeginContext(2251, 40, false);
#line 92 "C:\My Program Files\Sources\PddAdmin\PddAdmin\Views\Query\AllQueries.cshtml"
       Write(Html.DisplayFor(modelItem => item.Thema));

#line default
#line hidden
            EndContext();
            BeginContext(2291, 62, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-md-3\">\r\n            ");
            EndContext();
            BeginContext(2354, 42, false);
#line 95 "C:\My Program Files\Sources\PddAdmin\PddAdmin\Views\Query\AllQueries.cshtml"
       Write(Html.DisplayFor(modelItem => item.Comment));

#line default
#line hidden
            EndContext();
            BeginContext(2396, 64, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-md-2\">\r\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2460, "\"", 2495, 2);
            WriteAttributeValue("", 2467, "/Query/ViewQuery?Id=", 2467, 20, true);
#line 98 "C:\My Program Files\Sources\PddAdmin\PddAdmin\Views\Query\AllQueries.cshtml"
WriteAttributeValue("", 2487, item.Id, 2487, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2496, 29, true);
            WriteLiteral(">Details</a> \r\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2525, "\"", 2557, 2);
            WriteAttributeValue("", 2532, "/Query/Delete?Id=", 2532, 17, true);
#line 99 "C:\My Program Files\Sources\PddAdmin\PddAdmin\Views\Query\AllQueries.cshtml"
WriteAttributeValue("", 2549, item.Id, 2549, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2558, 91, true);
            WriteLiteral(">Delete</a>\r\n        </div>\r\n    </div>\r\n    <div class=\"content\" style=\"display: none;\">\r\n");
            EndContext();
#line 103 "C:\My Program Files\Sources\PddAdmin\PddAdmin\Views\Query\AllQueries.cshtml"
         foreach (var elm in item.Responses)
        {

#line default
#line hidden
            BeginContext(2706, 91, true);
            WriteLiteral("            <div class=\"row\">\r\n                <div class=\"col-md-9\">\r\n                    ");
            EndContext();
            BeginContext(2798, 12, false);
#line 107 "C:\My Program Files\Sources\PddAdmin\PddAdmin\Views\Query\AllQueries.cshtml"
               Write(elm.Response);

#line default
#line hidden
            EndContext();
            BeginContext(2810, 86, true);
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-md-3\">\r\n                    ");
            EndContext();
            BeginContext(2898, 35, false);
#line 110 "C:\My Program Files\Sources\PddAdmin\PddAdmin\Views\Query\AllQueries.cshtml"
                Write(elm.IsRight ? "Adevarata" : "Falsa");

#line default
#line hidden
            EndContext();
            BeginContext(2934, 46, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 113 "C:\My Program Files\Sources\PddAdmin\PddAdmin\Views\Query\AllQueries.cshtml"
        }

#line default
#line hidden
            BeginContext(2991, 12, true);
            WriteLiteral("    </div>\r\n");
            EndContext();
#line 115 "C:\My Program Files\Sources\PddAdmin\PddAdmin\Views\Query\AllQueries.cshtml"
}

#line default
#line hidden
            BeginContext(3006, 513, true);
            WriteLiteral(@"
<script>
    var coll = document.getElementsByClassName(""collapsible"");
    var i;

    for (i = 0; i < coll.length; i++) {
        coll[i].addEventListener(""click"", function () {
            this.classList.toggle(""active"");
            var content = this.nextElementSibling;
            if (content.style.display === ""block"") {
                content.style.display = ""none"";
            } else {
                content.style.display = ""block"";
            }
        });
    }
</script>



");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PddAdmin.Models.QueryItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
