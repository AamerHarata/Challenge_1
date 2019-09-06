#pragma checksum "D:\GitFolders\Programming\Twente\TestGoogle\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7f6c031e1cfba389655dd0bf654b49c6fe44192"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7f6c031e1cfba389655dd0bf654b49c6fe44192", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e27fe35e2483c1a27029c80184f6beac9797c8ca", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\GitFolders\Programming\Twente\TestGoogle\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 1110, true);
            WriteLiteral(@"

<style>
    .defect-div {
        width: 90%;
        margin: 0.5rem auto;
        background-color: whitesmoke;
        padding: 1rem;
        /* display: flex; */
        border-radius: 0.3rem;
    
    }

    .defect-pic {
        display: block;
        width: 8%;
        background-color: gray;
        padding: 0.3rem;
        float: left;
    }

    .defect-body {
        margin-left: 1rem;
        width: 92%;
    }

    .defect-date {
        float: right;
    }
    
    .defect-table {
        vertical-align: middle!important;
        text-align: center!important;
    }
    
    .defect-table td {
        
    }
</style>




<div class=""text-center"">
    <div><h4>University of Twente</h4></div>
    <div><h6>Challenge_1 Group_4</h6></div>
    <hr/>
    
    <h1 class=""display-4"" style=""font-size: 2.5rem; margin-bottom: 1rem;"">Listening for Defects</h1>
    
    <div id=""info-container"">
        
    </div>
    
    <input id=""testNumber"" hidden=""t");
            WriteLiteral("rue\"/>\r\n    \r\n    <div id=\"table-container\">\r\n        \r\n    </div>\r\n    \r\n\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1174, 1397, true);
                WriteLiteral(@"
    
    <script>
        
        $(document).ready(function() {

            setInterval(function() { getDbData(); }, 3000);
            setInterval(function() { getInfo(); }, 3000);
            setInterval(function() { testDefect(); }, 5000);
            function testDefect() {
                $.ajax({
                    type: ""GET"",
                    url: ""/TestDefect""
                });
            }

            


            function getDbData() {
                $.get(""/ReceiveDefect"",
                    function(response) {
                        $(""#table-container"").html($(response));

                        
                    });
            }
            
            function getInfo() {
                $.get(""/ReceiveData"",
                    function(response) {
                        const testNumber = $($(response).find("".testNumber"")).attr(""testNr"");
                        
                        if (testNumber !== 0 && testNumber !== undefined");
                WriteLiteral(@") {
                            $.get(""/ReceiveInfo/"" + testNumber,
                                function(resp) {
                                    $(""#info-container"").html($(resp));
                                });
                        }
                        
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
