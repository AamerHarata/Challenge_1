#pragma checksum "D:\GitFolders\Programming\Twente\TestGoogle\Views\Shared\TableDefect.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22c7f4ebf14589c0e779adb5389e81741c235c79"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_TableDefect), @"mvc.1.0.view", @"/Views/Shared/TableDefect.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/TableDefect.cshtml", typeof(AspNetCore.Views_Shared_TableDefect))]
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
#line 1 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Shared\TableDefect.cshtml"
using TestGoogle.Services;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22c7f4ebf14589c0e779adb5389e81741c235c79", @"/Views/Shared/TableDefect.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e27fe35e2483c1a27029c80184f6beac9797c8ca", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_TableDefect : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Defect>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(56, 7, true);
            WriteLiteral("\r\n   \r\n");
            EndContext();
#line 5 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Shared\TableDefect.cshtml"
 if (!Model.Any())
{

#line default
#line hidden
            BeginContext(86, 103, true);
            WriteLiteral("    <h4 class=\"text-center\">No holes or bumps yet! - Turn on GROUP-4\'s app and ride your bike ..</h4>\r\n");
            EndContext();
#line 8 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Shared\TableDefect.cshtml"
}
else
{
    var i = Model.Count();
    foreach (var defect in Model)
    {
        
        
        

#line default
#line hidden
            BeginContext(301, 486, true);
            WriteLiteral(@"        <div class=""defect-div"">
            
            <table class=""table defect-table"">
                
                <tr>
                    <th>#</th>
                    <th>Type</th>
                    <th>Accelerometer</th>
                    <th>Location</th>
                    <th>Time</th>
                    <th>Map</th>
                </tr>
                
                
                <tr>
                    <td><div style=""margin: auto"">");
            EndContext();
            BeginContext(788, 1, false);
#line 32 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Shared\TableDefect.cshtml"
                                             Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(789, 37, true);
            WriteLiteral("</div></td>\r\n                    <td>");
            EndContext();
            BeginContext(827, 14, false);
#line 33 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Shared\TableDefect.cshtml"
                   Write(defect.DefType);

#line default
#line hidden
            EndContext();
            BeginContext(841, 34, true);
            WriteLiteral("</td>\r\n                    <td>X: ");
            EndContext();
            BeginContext(876, 40, false);
#line 34 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Shared\TableDefect.cshtml"
                      Write(Math.Round(double.Parse(defect.xAco), 3));

#line default
#line hidden
            EndContext();
            BeginContext(916, 6, true);
            WriteLiteral(" - Y: ");
            EndContext();
            BeginContext(923, 40, false);
#line 34 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Shared\TableDefect.cshtml"
                                                                     Write(Math.Round(double.Parse(defect.yAco), 3));

#line default
#line hidden
            EndContext();
            BeginContext(963, 6, true);
            WriteLiteral(" - Z: ");
            EndContext();
            BeginContext(970, 40, false);
#line 34 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Shared\TableDefect.cshtml"
                                                                                                                    Write(Math.Round(double.Parse(defect.zAco), 3));

#line default
#line hidden
            EndContext();
            BeginContext(1010, 41, true);
            WriteLiteral("</td>\r\n                    <td>Latitude: ");
            EndContext();
            BeginContext(1052, 11, false);
#line 35 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Shared\TableDefect.cshtml"
                             Write(defect.xGeo);

#line default
#line hidden
            EndContext();
            BeginContext(1063, 13, true);
            WriteLiteral(", Longitude: ");
            EndContext();
            BeginContext(1077, 11, false);
#line 35 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Shared\TableDefect.cshtml"
                                                      Write(defect.yGeo);

#line default
#line hidden
            EndContext();
            BeginContext(1088, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1120, 47, false);
#line 36 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Shared\TableDefect.cshtml"
                   Write(defect.Time.AddHours(2).ToString(@"hh\:mm\:ss"));

#line default
#line hidden
            EndContext();
            BeginContext(1167, 29, true);
            WriteLiteral("</td>\r\n                    \r\n");
            EndContext();
#line 38 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Shared\TableDefect.cshtml"
                     if (defect.DefType == DefType.Bump)
                    {

#line default
#line hidden
            BeginContext(1277, 32, true);
            WriteLiteral("                        <td><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1309, "\"", 1552, 10);
            WriteAttributeValue("", 1315, "https://maps.googleapis.com/maps/api/staticmap?", 1315, 47, true);
            WriteAttributeValue("\r\n         ", 1362, "center=", 1373, 18, true);
#line 41 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Shared\TableDefect.cshtml"
WriteAttributeValue("", 1380, defect.xGeo, 1380, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 1392, ",", 1392, 1, true);
#line 41 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Shared\TableDefect.cshtml"
WriteAttributeValue("", 1393, defect.yGeo, 1393, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 1405, "&zoom=18&size=200x200&scale=1&maptype=roadmap\\&markers=color:red%7Clabel:B%7C", 1405, 77, true);
#line 41 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Shared\TableDefect.cshtml"
WriteAttributeValue(" ", 1482, defect.xGeo, 1483, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 1495, ",", 1495, 1, true);
#line 41 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Shared\TableDefect.cshtml"
WriteAttributeValue("", 1496, defect.yGeo, 1496, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 1508, "&key=AIzaSyC0mLIcD6TdgT0xuRJ3BxU9eD86nWf7Da4", 1508, 44, true);
            EndWriteAttribute();
            BeginContext(1553, 9, true);
            WriteLiteral("/></td>\r\n");
            EndContext();
#line 42 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Shared\TableDefect.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(1634, 32, true);
            WriteLiteral("                        <td><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1666, "\"", 1911, 10);
            WriteAttributeValue("", 1672, "https://maps.googleapis.com/maps/api/staticmap?", 1672, 47, true);
            WriteAttributeValue("\r\n         ", 1719, "center=", 1730, 18, true);
#line 46 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Shared\TableDefect.cshtml"
WriteAttributeValue("", 1737, defect.xGeo, 1737, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 1749, ",", 1749, 1, true);
#line 46 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Shared\TableDefect.cshtml"
WriteAttributeValue("", 1750, defect.yGeo, 1750, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 1762, "&zoom=18&size=200x200&scale=1&maptype=roadmap\\&markers=color:green%7Clabel:H%7C", 1762, 79, true);
#line 46 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Shared\TableDefect.cshtml"
WriteAttributeValue(" ", 1841, defect.xGeo, 1842, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 1854, ",", 1854, 1, true);
#line 46 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Shared\TableDefect.cshtml"
WriteAttributeValue("", 1855, defect.yGeo, 1855, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 1867, "&key=AIzaSyC0mLIcD6TdgT0xuRJ3BxU9eD86nWf7Da4", 1867, 44, true);
            EndWriteAttribute();
            BeginContext(1912, 9, true);
            WriteLiteral("/></td>\r\n");
            EndContext();
#line 47 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Shared\TableDefect.cshtml"
                    }

#line default
#line hidden
            BeginContext(1944, 161, true);
            WriteLiteral("         \r\n                    \r\n                </tr>\r\n            </table>\r\n            <span class=\"small defect-date\"></span>\r\n            \r\n        </div>\r\n");
            EndContext();
#line 55 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Shared\TableDefect.cshtml"
        
        
        
        
        
        
        
        
        
        
        i--;
    }
}

#line default
#line hidden
            BeginContext(2229, 14, true);
            WriteLiteral("\r\n\r\n        \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Defect>> Html { get; private set; }
    }
}
#pragma warning restore 1591