#pragma checksum "D:\GitFolders\Programming\Twente\TestGoogle\Views\Shared\Table.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f25249707dce95b77429e979dade46506deccfe"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f25249707dce95b77429e979dade46506deccfe", @"/Views/Shared/Table.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e27fe35e2483c1a27029c80184f6beac9797c8ca", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Table : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MobileData>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 273, true);
            WriteLiteral(@"
<table class=""table table-striped"">
    <thead>
    <tr>
        <th>#</th>
        <th>Acc - X</th>
        <th>Acc - Y</th>
        <th>Acc - Z</th>
        <th>Geo - X</th>
        <th>Geo - Y</th>
        <th>Picture</th>
    </tr>
    </thead>
        
");
            EndContext();
#line 16 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Shared\Table.cshtml"
     foreach (var mobileDate in Model)
    {

#line default
#line hidden
            BeginContext(352, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(383, 13, false);
#line 19 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Shared\Table.cshtml"
           Write(mobileDate.Id);

#line default
#line hidden
            EndContext();
            BeginContext(396, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(420, 15, false);
#line 20 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Shared\Table.cshtml"
           Write(mobileDate.xAco);

#line default
#line hidden
            EndContext();
            BeginContext(435, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(459, 15, false);
#line 21 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Shared\Table.cshtml"
           Write(mobileDate.yAco);

#line default
#line hidden
            EndContext();
            BeginContext(474, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(498, 15, false);
#line 22 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Shared\Table.cshtml"
           Write(mobileDate.zAco);

#line default
#line hidden
            EndContext();
            BeginContext(513, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(537, 15, false);
#line 23 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Shared\Table.cshtml"
           Write(mobileDate.xGeo);

#line default
#line hidden
            EndContext();
            BeginContext(552, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(576, 15, false);
#line 24 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Shared\Table.cshtml"
           Write(mobileDate.yGeo);

#line default
#line hidden
            EndContext();
            BeginContext(591, 46, true);
            WriteLiteral("</td>\r\n            <td>-</td>\r\n        </tr>\r\n");
            EndContext();
#line 27 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Shared\Table.cshtml"
    }

#line default
#line hidden
            BeginContext(644, 28, true);
            WriteLiteral("        \r\n        \r\n</table>");
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
