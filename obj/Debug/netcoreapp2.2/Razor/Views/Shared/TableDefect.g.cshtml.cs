#pragma checksum "D:\GitFolders\Programming\Twente\TestGoogle\Views\Shared\TableDefect.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5120fbf1b54563deff0de5457306905f4ab7708a"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5120fbf1b54563deff0de5457306905f4ab7708a", @"/Views/Shared/TableDefect.cshtml")]
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
            BeginContext(86, 121, true);
            WriteLiteral("    <h4 class=\"text-center\" style=\"color:red\">No holes or bumps yet! - Turn on GROUP-4\'s app and ride your bike ..</h4>\r\n");
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
            BeginContext(319, 486, true);
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
            BeginContext(806, 1, false);
#line 32 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Shared\TableDefect.cshtml"
                                             Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(807, 37, true);
            WriteLiteral("</div></td>\r\n                    <td>");
            EndContext();
            BeginContext(845, 14, false);
#line 33 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Shared\TableDefect.cshtml"
                   Write(defect.DefType);

#line default
#line hidden
            EndContext();
            BeginContext(859, 34, true);
            WriteLiteral("</td>\r\n                    <td>X: ");
            EndContext();
            BeginContext(894, 40, false);
#line 34 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Shared\TableDefect.cshtml"
                      Write(Math.Round(double.Parse(defect.xAco), 3));

#line default
#line hidden
            EndContext();
            BeginContext(934, 6, true);
            WriteLiteral(" - Y: ");
            EndContext();
            BeginContext(941, 40, false);
#line 34 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Shared\TableDefect.cshtml"
                                                                     Write(Math.Round(double.Parse(defect.yAco), 3));

#line default
#line hidden
            EndContext();
            BeginContext(981, 6, true);
            WriteLiteral(" - Z: ");
            EndContext();
            BeginContext(988, 40, false);
#line 34 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Shared\TableDefect.cshtml"
                                                                                                                    Write(Math.Round(double.Parse(defect.zAco), 3));

#line default
#line hidden
            EndContext();
            BeginContext(1028, 41, true);
            WriteLiteral("</td>\r\n                    <td>Latitude: ");
            EndContext();
            BeginContext(1070, 11, false);
#line 35 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Shared\TableDefect.cshtml"
                             Write(defect.xGeo);

#line default
#line hidden
            EndContext();
            BeginContext(1081, 13, true);
            WriteLiteral(", Longitude: ");
            EndContext();
            BeginContext(1095, 11, false);
#line 35 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Shared\TableDefect.cshtml"
                                                      Write(defect.yGeo);

#line default
#line hidden
            EndContext();
            BeginContext(1106, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1138, 47, false);
#line 36 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Shared\TableDefect.cshtml"
                   Write(defect.Time.AddHours(2).ToString(@"hh\:mm\:ss"));

#line default
#line hidden
            EndContext();
            BeginContext(1185, 29, true);
            WriteLiteral("</td>\r\n                    \r\n");
            EndContext();
#line 38 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Shared\TableDefect.cshtml"
                     if (defect.DefType == DefType.Bump)
                    {

#line default
#line hidden
            BeginContext(1295, 32, true);
            WriteLiteral("                        <td><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1327, "\"", 1570, 10);
            WriteAttributeValue("", 1333, "https://maps.googleapis.com/maps/api/staticmap?", 1333, 47, true);
            WriteAttributeValue("\r\n         ", 1380, "center=", 1391, 18, true);
#line 41 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Shared\TableDefect.cshtml"
WriteAttributeValue("", 1398, defect.xGeo, 1398, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 1410, ",", 1410, 1, true);
#line 41 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Shared\TableDefect.cshtml"
WriteAttributeValue("", 1411, defect.yGeo, 1411, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 1423, "&zoom=18&size=200x200&scale=1&maptype=roadmap\\&markers=color:red%7Clabel:B%7C", 1423, 77, true);
#line 41 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Shared\TableDefect.cshtml"
WriteAttributeValue(" ", 1500, defect.xGeo, 1501, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 1513, ",", 1513, 1, true);
#line 41 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Shared\TableDefect.cshtml"
WriteAttributeValue("", 1514, defect.yGeo, 1514, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 1526, "&key=AIzaSyC0mLIcD6TdgT0xuRJ3BxU9eD86nWf7Da4", 1526, 44, true);
            EndWriteAttribute();
            BeginContext(1571, 9, true);
            WriteLiteral("/></td>\r\n");
            EndContext();
#line 42 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Shared\TableDefect.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(1652, 32, true);
            WriteLiteral("                        <td><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1684, "\"", 1929, 10);
            WriteAttributeValue("", 1690, "https://maps.googleapis.com/maps/api/staticmap?", 1690, 47, true);
            WriteAttributeValue("\r\n         ", 1737, "center=", 1748, 18, true);
#line 46 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Shared\TableDefect.cshtml"
WriteAttributeValue("", 1755, defect.xGeo, 1755, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 1767, ",", 1767, 1, true);
#line 46 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Shared\TableDefect.cshtml"
WriteAttributeValue("", 1768, defect.yGeo, 1768, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 1780, "&zoom=18&size=200x200&scale=1&maptype=roadmap\\&markers=color:green%7Clabel:H%7C", 1780, 79, true);
#line 46 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Shared\TableDefect.cshtml"
WriteAttributeValue(" ", 1859, defect.xGeo, 1860, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 1872, ",", 1872, 1, true);
#line 46 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Shared\TableDefect.cshtml"
WriteAttributeValue("", 1873, defect.yGeo, 1873, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 1885, "&key=AIzaSyC0mLIcD6TdgT0xuRJ3BxU9eD86nWf7Da4", 1885, 44, true);
            EndWriteAttribute();
            BeginContext(1930, 9, true);
            WriteLiteral("/></td>\r\n");
            EndContext();
#line 47 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Shared\TableDefect.cshtml"
                    }

#line default
#line hidden
            BeginContext(1962, 161, true);
            WriteLiteral("         \r\n                    \r\n                </tr>\r\n            </table>\r\n            <span class=\"small defect-date\"></span>\r\n            \r\n        </div>\r\n");
            EndContext();
#line 55 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Shared\TableDefect.cshtml"
        
        
        
        
        
        
        
        
        
        
        i--;
    }
}

#line default
#line hidden
            BeginContext(2247, 14, true);
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
