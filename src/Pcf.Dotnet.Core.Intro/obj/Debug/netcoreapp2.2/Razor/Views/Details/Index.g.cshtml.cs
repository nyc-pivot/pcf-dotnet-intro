#pragma checksum "C:\Projects\pcf-dotnet-intro\src\Pcf.Dotnet.Core.Intro\Views\Details\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40f98668858b631b25cbdc29f75e9befb2cacd28"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Details_Index), @"mvc.1.0.view", @"/Views/Details/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Details/Index.cshtml", typeof(AspNetCore.Views_Details_Index))]
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
#line 1 "C:\Projects\pcf-dotnet-intro\src\Pcf.Dotnet.Core.Intro\Views\_ViewImports.cshtml"
using Pcf.Dotnet.Core.Intro;

#line default
#line hidden
#line 2 "C:\Projects\pcf-dotnet-intro\src\Pcf.Dotnet.Core.Intro\Views\_ViewImports.cshtml"
using Pcf.Dotnet.Core.Intro.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40f98668858b631b25cbdc29f75e9befb2cacd28", @"/Views/Details/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb34503273746465439c9c1d14e45aa164d0b9f7", @"/Views/_ViewImports.cshtml")]
    public class Views_Details_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Application>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(20, 174, true);
            WriteLiteral("\r\n<h2>Environment Variables</h2>\r\n\r\n<hr />\r\n\r\n<h3>VCAP_APPLICATION</h3>\r\n<p></p>\r\n<table class=\"table table-striped\">\r\n    <tr>\r\n        <td>Application Id</td>\r\n        <td>");
            EndContext();
            BeginContext(195, 20, false);
#line 12 "C:\Projects\pcf-dotnet-intro\src\Pcf.Dotnet.Core.Intro\Views\Details\Index.cshtml"
       Write(Model.application_id);

#line default
#line hidden
            EndContext();
            BeginContext(215, 75, true);
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>Application Name</td>\r\n        <td>");
            EndContext();
            BeginContext(291, 22, false);
#line 16 "C:\Projects\pcf-dotnet-intro\src\Pcf.Dotnet.Core.Intro\Views\Details\Index.cshtml"
       Write(Model.application_name);

#line default
#line hidden
            EndContext();
            BeginContext(313, 78, true);
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>Application Version</td>\r\n        <td>");
            EndContext();
            BeginContext(392, 25, false);
#line 20 "C:\Projects\pcf-dotnet-intro\src\Pcf.Dotnet.Core.Intro\Views\Details\Index.cshtml"
       Write(Model.application_version);

#line default
#line hidden
            EndContext();
            BeginContext(417, 67, true);
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>Space Id</td>\r\n        <td>");
            EndContext();
            BeginContext(485, 14, false);
#line 24 "C:\Projects\pcf-dotnet-intro\src\Pcf.Dotnet.Core.Intro\Views\Details\Index.cshtml"
       Write(Model.space_id);

#line default
#line hidden
            EndContext();
            BeginContext(499, 69, true);
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>Space Name</td>\r\n        <td>");
            EndContext();
            BeginContext(569, 16, false);
#line 28 "C:\Projects\pcf-dotnet-intro\src\Pcf.Dotnet.Core.Intro\Views\Details\Index.cshtml"
       Write(Model.space_name);

#line default
#line hidden
            EndContext();
            BeginContext(585, 63, true);
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>URIs</td>\r\n        <td>");
            EndContext();
            BeginContext(649, 12, false);
#line 32 "C:\Projects\pcf-dotnet-intro\src\Pcf.Dotnet.Core.Intro\Views\Details\Index.cshtml"
       Write(ViewBag.Uris);

#line default
#line hidden
            EndContext();
            BeginContext(661, 62, true);
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>API</td>\r\n        <td>");
            EndContext();
            BeginContext(724, 12, false);
#line 36 "C:\Projects\pcf-dotnet-intro\src\Pcf.Dotnet.Core.Intro\Views\Details\Index.cshtml"
       Write(Model.cf_api);

#line default
#line hidden
            EndContext();
            BeginContext(736, 69, true);
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>Disk Limit</td>\r\n        <td>");
            EndContext();
            BeginContext(806, 17, false);
#line 40 "C:\Projects\pcf-dotnet-intro\src\Pcf.Dotnet.Core.Intro\Views\Details\Index.cshtml"
       Write(Model.limits.disk);

#line default
#line hidden
            EndContext();
            BeginContext(823, 65, true);
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>Memory</td>\r\n        <td>");
            EndContext();
            BeginContext(889, 16, false);
#line 44 "C:\Projects\pcf-dotnet-intro\src\Pcf.Dotnet.Core.Intro\Views\Details\Index.cshtml"
       Write(Model.limits.mem);

#line default
#line hidden
            EndContext();
            BeginContext(905, 70, true);
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>Instance Id</td>\r\n        <td>");
            EndContext();
            BeginContext(976, 17, false);
#line 48 "C:\Projects\pcf-dotnet-intro\src\Pcf.Dotnet.Core.Intro\Views\Details\Index.cshtml"
       Write(Model.instance_id);

#line default
#line hidden
            EndContext();
            BeginContext(993, 73, true);
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>Instance Index</td>\r\n        <td>");
            EndContext();
            BeginContext(1067, 20, false);
#line 52 "C:\Projects\pcf-dotnet-intro\src\Pcf.Dotnet.Core.Intro\Views\Details\Index.cshtml"
       Write(Model.instance_index);

#line default
#line hidden
            EndContext();
            BeginContext(1087, 63, true);
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>Port</td>\r\n        <td>");
            EndContext();
            BeginContext(1151, 10, false);
#line 56 "C:\Projects\pcf-dotnet-intro\src\Pcf.Dotnet.Core.Intro\Views\Details\Index.cshtml"
       Write(Model.port);

#line default
#line hidden
            EndContext();
            BeginContext(1161, 147, true);
            WriteLiteral("</td>\r\n    </tr>\r\n</table>\r\n\r\n<hr />\r\n\r\n<h3>Host</h3>\r\n<p></p>\r\n<table class=\"table table-striped\">\r\n    <tr>\r\n        <td>Stack</td>\r\n        <td>");
            EndContext();
            BeginContext(1309, 21, false);
#line 67 "C:\Projects\pcf-dotnet-intro\src\Pcf.Dotnet.Core.Intro\Views\Details\Index.cshtml"
       Write(ViewBag.OSDescription);

#line default
#line hidden
            EndContext();
            BeginContext(1330, 68, true);
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>Host Name</td>\r\n        <td>");
            EndContext();
            BeginContext(1399, 16, false);
#line 71 "C:\Projects\pcf-dotnet-intro\src\Pcf.Dotnet.Core.Intro\Views\Details\Index.cshtml"
       Write(ViewBag.HostName);

#line default
#line hidden
            EndContext();
            BeginContext(1415, 71, true);
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>Host Address</td>\r\n        <td>");
            EndContext();
            BeginContext(1487, 19, false);
#line 75 "C:\Projects\pcf-dotnet-intro\src\Pcf.Dotnet.Core.Intro\Views\Details\Index.cshtml"
       Write(ViewBag.HostAddress);

#line default
#line hidden
            EndContext();
            BeginContext(1506, 26, true);
            WriteLiteral("</td>\r\n    </tr>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Application> Html { get; private set; }
    }
}
#pragma warning restore 1591
