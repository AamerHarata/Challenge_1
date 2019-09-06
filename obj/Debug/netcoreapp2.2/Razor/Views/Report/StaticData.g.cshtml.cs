#pragma checksum "D:\GitFolders\Programming\Twente\TestGoogle\Views\Report\StaticData.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1147b6aece6b3f3152d58dc8cd3ee30ac2d4536c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Report_StaticData), @"mvc.1.0.view", @"/Views/Report/StaticData.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Report/StaticData.cshtml", typeof(AspNetCore.Views_Report_StaticData))]
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
#line 1 "D:\GitFolders\Programming\Twente\TestGoogle\Views\_ViewImports.cshtml"
using TestGoogle;

#line default
#line hidden
#line 2 "D:\GitFolders\Programming\Twente\TestGoogle\Views\_ViewImports.cshtml"
using TestGoogle.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1147b6aece6b3f3152d58dc8cd3ee30ac2d4536c", @"/Views/Report/StaticData.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e27fe35e2483c1a27029c80184f6beac9797c8ca", @"/Views/_ViewImports.cshtml")]
    public class Views_Report_StaticData : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MobileData>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Report\StaticData.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(79, 207, true);
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <div><h4>University of Twente</h4></div>\r\n    <div><h6>Challenge_1 Group_4</h6></div>\r\n    <hr/>\r\n    <h1 class=\"display-4\" style=\"font-size: 2.5rem;\">Static Data from Test: ");
            EndContext();
            BeginContext(287, 18, false);
#line 11 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Report\StaticData.cshtml"
                                                                       Write(ViewBag.testNumber);

#line default
#line hidden
            EndContext();
            BeginContext(305, 76, true);
            WriteLiteral("</h1>\r\n    <h1 class=\"display-4\" style=\"font-size: 1.5rem;\">Data Collected: ");
            EndContext();
            BeginContext(382, 13, false);
#line 12 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Report\StaticData.cshtml"
                                                                Write(Model.Count());

#line default
#line hidden
            EndContext();
            BeginContext(395, 21, true);
            WriteLiteral("</h1>\r\n</div>\r\n    \r\n");
            EndContext();
#line 15 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Report\StaticData.cshtml"
     if (!Model.Any())
    {

#line default
#line hidden
            BeginContext(447, 35, true);
            WriteLiteral("        <div>No Test Found!</div>\r\n");
            EndContext();
#line 18 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Report\StaticData.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(506, 401, true);
            WriteLiteral(@"        <table id=""table-container"" class=""table table-hover text-center"">
            <thead>
            <tr>
                <th>#</th>
                <th>Acc - X</th>
                <th>Acc - Y</th>
                <th>Acc - Z</th>
                <th>Geo - X</th>
                <th>Geo - Y</th>
                <th>Test Nr.</th>
            </tr>
            </thead>
    
    
");
            EndContext();
#line 35 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Report\StaticData.cshtml"
               var i = 1;

#line default
#line hidden
            BeginContext(935, 12, true);
            WriteLiteral("            ");
            EndContext();
#line 36 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Report\StaticData.cshtml"
             foreach (var mobileDate in Model)
            {

#line default
#line hidden
            BeginContext(998, 38, true);
            WriteLiteral("                <tr class=\"testNumber\"");
            EndContext();
            BeginWriteAttribute("testNr", " testNr=\"", 1036, "\"", 1067, 1);
#line 38 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Report\StaticData.cshtml"
WriteAttributeValue("", 1045, mobileDate.TestNumber, 1045, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1068, 27, true);
            WriteLiteral(">\r\n                    <td>");
            EndContext();
            BeginContext(1096, 1, false);
#line 39 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Report\StaticData.cshtml"
                   Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(1097, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1129, 15, false);
#line 40 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Report\StaticData.cshtml"
                   Write(mobileDate.xAco);

#line default
#line hidden
            EndContext();
            BeginContext(1144, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1176, 15, false);
#line 41 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Report\StaticData.cshtml"
                   Write(mobileDate.yAco);

#line default
#line hidden
            EndContext();
            BeginContext(1191, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1223, 15, false);
#line 42 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Report\StaticData.cshtml"
                   Write(mobileDate.zAco);

#line default
#line hidden
            EndContext();
            BeginContext(1238, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1270, 15, false);
#line 43 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Report\StaticData.cshtml"
                   Write(mobileDate.xGeo);

#line default
#line hidden
            EndContext();
            BeginContext(1285, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1317, 15, false);
#line 44 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Report\StaticData.cshtml"
                   Write(mobileDate.yGeo);

#line default
#line hidden
            EndContext();
            BeginContext(1332, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1364, 21, false);
#line 45 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Report\StaticData.cshtml"
                   Write(mobileDate.TestNumber);

#line default
#line hidden
            EndContext();
            BeginContext(1385, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 47 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Report\StaticData.cshtml"
                i++;
            }

#line default
#line hidden
            BeginContext(1452, 18, true);
            WriteLiteral("        </table>\r\n");
            EndContext();
#line 50 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Report\StaticData.cshtml"
    }

#line default
#line hidden
            BeginContext(1477, 24, true);
            WriteLiteral("    \r\n    \r\n    \r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MobileData>> Html { get; private set; }
    }
}
#pragma warning restore 1591
