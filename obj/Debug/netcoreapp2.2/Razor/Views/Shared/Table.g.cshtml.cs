#pragma checksum "D:\GitFolders\Programming\Twente\TestGoogle\Views\Shared\Table.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6cf0d8fbce647b7f5daab7981432dbc5e1617a64"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Table), @"mvc.1.0.view", @"/Views/Shared/Table.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Table.cshtml", typeof(AspNetCore.Views_Shared_Table))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6cf0d8fbce647b7f5daab7981432dbc5e1617a64", @"/Views/Shared/Table.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e27fe35e2483c1a27029c80184f6beac9797c8ca", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Table : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MobileData>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Shared\Table.cshtml"
 if (!Model.Any())
{

#line default
#line hidden
            BeginContext(59, 120, true);
            WriteLiteral("    <h4 class=\"text-center\" style=\"color:red\">No data received yet! - Turn on GROUP-4\'s app and ride your bike ..</h4>\r\n");
            EndContext();
#line 7 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Shared\Table.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(191, 335, true);
            WriteLiteral(@"    <table id=""table-container"" class=""table table-hover text-center"">
        <thead>
        <tr>
            <th>#</th>
            <th>Time</th>
            <th>Acc - X</th>
            <th>Acc - Y</th>
            <th>Acc - Z</th>
            <th>Geo - X</th>
            <th>Geo - Y</th>
            <th>Test Nr.</th>
");
            EndContext();
            BeginContext(562, 45, true);
            WriteLiteral("        </tr>\r\n        </thead>\r\n    \r\n    \r\n");
            EndContext();
#line 26 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Shared\Table.cshtml"
           var i = Model.Count();

#line default
#line hidden
            BeginContext(643, 8, true);
            WriteLiteral("        ");
            EndContext();
#line 27 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Shared\Table.cshtml"
         foreach (var mobileDate in Model)
        {

#line default
#line hidden
            BeginContext(698, 34, true);
            WriteLiteral("            <tr class=\"testNumber\"");
            EndContext();
            BeginWriteAttribute("testNr", " testNr=\"", 732, "\"", 763, 1);
#line 29 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Shared\Table.cshtml"
WriteAttributeValue("", 741, mobileDate.TestNumber, 741, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(764, 23, true);
            WriteLiteral(">\r\n                <td>");
            EndContext();
            BeginContext(788, 1, false);
#line 30 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Shared\Table.cshtml"
               Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(789, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(817, 74, false);
#line 31 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Shared\Table.cshtml"
               Write(mobileDate.DateTime.TimeOfDay.Add(new TimeSpan(2,0,0)).ToString(@"hh\:mm"));

#line default
#line hidden
            EndContext();
            BeginContext(891, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(919, 15, false);
#line 32 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Shared\Table.cshtml"
               Write(mobileDate.xAco);

#line default
#line hidden
            EndContext();
            BeginContext(934, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(962, 15, false);
#line 33 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Shared\Table.cshtml"
               Write(mobileDate.yAco);

#line default
#line hidden
            EndContext();
            BeginContext(977, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1005, 15, false);
#line 34 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Shared\Table.cshtml"
               Write(mobileDate.zAco);

#line default
#line hidden
            EndContext();
            BeginContext(1020, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1048, 15, false);
#line 35 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Shared\Table.cshtml"
               Write(mobileDate.xGeo);

#line default
#line hidden
            EndContext();
            BeginContext(1063, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1091, 15, false);
#line 36 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Shared\Table.cshtml"
               Write(mobileDate.yGeo);

#line default
#line hidden
            EndContext();
            BeginContext(1106, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1134, 21, false);
#line 37 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Shared\Table.cshtml"
               Write(mobileDate.TestNumber);

#line default
#line hidden
            EndContext();
            BeginContext(1155, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
            BeginContext(1633, 19, true);
            WriteLiteral("            </tr>\r\n");
            EndContext();
#line 43 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Shared\Table.cshtml"
            i--;
        }

#line default
#line hidden
            BeginContext(1681, 14, true);
            WriteLiteral("    </table>\r\n");
            EndContext();
#line 46 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Shared\Table.cshtml"
}

#line default
#line hidden
            BeginContext(1698, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1760, 10, true);
            WriteLiteral("        \r\n");
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
