#pragma checksum "D:\GitFolders\Programming\Twente\TestGoogle\Views\Home\AllData.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65c2c950e93b52c56b825a8f6f1da3e703c7ae5c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AllData), @"mvc.1.0.view", @"/Views/Home/AllData.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/AllData.cshtml", typeof(AspNetCore.Views_Home_AllData))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65c2c950e93b52c56b825a8f6f1da3e703c7ae5c", @"/Views/Home/AllData.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e27fe35e2483c1a27029c80184f6beac9797c8ca", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AllData : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Home\AllData.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 252, true);
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <div><h4>University of Twente</h4></div>\r\n    <div><h6>Challenge_1 Group_4</h6></div>\r\n    <hr/>\r\n    \r\n    <h1 class=\"display-4\">Data test from phone</h1>\r\n    <button style=\"margin-bottom: 1rem\" class=\"btn btn-danger\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 297, "\"", 347, 3);
            WriteAttributeValue("", 307, "location.href=\'", 307, 15, true);
#line 11 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Home\AllData.cshtml"
WriteAttributeValue("", 322, Url.Action("DeleteAll"), 322, 24, false);

#line default
#line hidden
            WriteAttributeValue("", 346, "\'", 346, 1, true);
            EndWriteAttribute();
            BeginContext(348, 113, true);
            WriteLiteral(">Delete All (Everything)</button>\r\n    \r\n    <div id=\"table-container\">\r\n        \r\n    </div>\r\n    \r\n\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(480, 538, true);
                WriteLiteral(@"
    
    <script>
        
        $(document).ready(function() {

            setInterval(function() { getDbData(); }, 3000);

            


            function getDbData() {
                $.get(""/ReceiveData"",
                    function(response) {

                        
                            $(""#table-container"").html($(response));
                        
                        
                        
                    });
            }

            


        });

    </script>
");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591