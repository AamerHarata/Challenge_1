#pragma checksum "D:\GitFolders\Programming\Twente\TestGoogle\Views\Report\StaticMap.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f5ad816e1033d00acee98e6a631c72faf5b45e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Report_StaticMap), @"mvc.1.0.view", @"/Views/Report/StaticMap.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Report/StaticMap.cshtml", typeof(AspNetCore.Views_Report_StaticMap))]
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
#line 1 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Report\StaticMap.cshtml"
using TestGoogle.Services;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f5ad816e1033d00acee98e6a631c72faf5b45e5", @"/Views/Report/StaticMap.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e27fe35e2483c1a27029c80184f6beac9797c8ca", @"/Views/_ViewImports.cshtml")]
    public class Views_Report_StaticMap : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Defect>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(90, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Report\StaticMap.cshtml"
  
    ViewBag.Title = "Static Map - Result";
    Layout = "_Layout";
    var testNumber = ViewBag.testNumber;

#line default
#line hidden
            BeginContext(210, 105, true);
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\" style=\"font-size: 2.5rem;\">Defects Map from Test: ");
            EndContext();
            BeginContext(316, 18, false);
#line 12 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Report\StaticMap.cshtml"
                                                                       Write(ViewBag.testNumber);

#line default
#line hidden
            EndContext();
            BeginContext(334, 81, true);
            WriteLiteral("</h1>\r\n    <h1 class=\"display-4\" style=\"font-size: 1.5rem;\">Bumps / Holes Found: ");
            EndContext();
            BeginContext(417, 72, false);
#line 13 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Report\StaticMap.cshtml"
                                                                      Write(TestService.CountHoles(testNumber) + TestService.CountBumps(testNumber) );

#line default
#line hidden
            EndContext();
            BeginContext(490, 17, true);
            WriteLiteral("</h1>\r\n</div>\r\n\r\n");
            EndContext();
#line 16 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Report\StaticMap.cshtml"
 if (!Model.Any())
{

#line default
#line hidden
            BeginContext(530, 73, true);
            WriteLiteral("    <div class=\"text-center\">No Defects Found! Therefore, No Map!</div>\r\n");
            EndContext();
#line 19 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Report\StaticMap.cshtml"
}
else
{
    var markers = "";
    var center = "";
    foreach (var defect in Model)
    {
        if (defect.DefType == DefType.Bump)
        {
            markers += "&markers=color:red%7Clabel:B%7C "+defect.xGeo+","+defect.yGeo;
        }
        else
        {
            markers += "&markers=color:green%7Clabel:H%7C "+defect.xGeo+","+defect.yGeo;
        }

        center = defect.xGeo + "," + defect.yGeo;

    }
    

#line default
#line hidden
            BeginContext(1051, 33, true);
            WriteLiteral("    <div class=\"text-center\"><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1084, "\"", 1405, 8);
            WriteAttributeValue("", 1090, "https://maps.googleapis.com/maps/api/staticmap?&style=visibility:on", 1090, 67, true);
            WriteAttributeValue("\r\n", 1157, "&style=feature:water%7Celement:geometry%7Cvisibility:on", 1159, 57, true);
            WriteAttributeValue("\r\n", 1214, "&style=feature:landscape%7Celement:geometry%7Cvisibility:on&", 1216, 62, true);
            WriteAttributeValue("\r\n         ", 1276, "center=", 1287, 18, true);
#line 42 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Report\StaticMap.cshtml"
WriteAttributeValue("", 1294, center, 1294, 7, false);

#line default
#line hidden
            WriteAttributeValue("", 1301, "&zoom=auto&size=900x900&scale=1&maptype=roadmap\\", 1301, 48, true);
#line 42 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Report\StaticMap.cshtml"
WriteAttributeValue("\r\n", 1349, markers, 1351, 8, false);

#line default
#line hidden
            WriteAttributeValue("\r\n", 1359, "&key=AIzaSyC0mLIcD6TdgT0xuRJ3BxU9eD86nWf7Da4", 1361, 46, true);
            EndWriteAttribute();
            BeginContext(1406, 16, true);
            WriteLiteral("/>\r\n    </div>\r\n");
            EndContext();
#line 46 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Report\StaticMap.cshtml"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ITestService TestService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Defect>> Html { get; private set; }
    }
}
#pragma warning restore 1591
