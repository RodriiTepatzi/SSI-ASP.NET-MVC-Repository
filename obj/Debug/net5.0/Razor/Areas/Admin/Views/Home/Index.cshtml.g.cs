#pragma checksum "C:\Users\sprno\source\repos\SSI-WebApp\Areas\Admin\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5a130a2400252e9576406db23275c214d7fd66e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Home/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\sprno\source\repos\SSI-WebApp\Areas\Admin\Views\_ViewImports.cshtml"
using SSI_WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sprno\source\repos\SSI-WebApp\Areas\Admin\Views\_ViewImports.cshtml"
using SSI_WebApp.Data.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\sprno\source\repos\SSI-WebApp\Areas\Admin\Views\_ViewImports.cshtml"
using SSI_WebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\sprno\source\repos\SSI-WebApp\Areas\Admin\Views\_ViewImports.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\sprno\source\repos\SSI-WebApp\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5a130a2400252e9576406db23275c214d7fd66e", @"/Areas/Admin/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f032d3d38221fd62629c0bad1f4d1365c928ecaf", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ApplicationUser>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\sprno\source\repos\SSI-WebApp\Areas\Admin\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Admin Login";

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\sprno\source\repos\SSI-WebApp\Areas\Admin\Views\Home\Index.cshtml"
 if (User.Identity.IsAuthenticated && User.IsInRole("Admin"))
{
    
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <script>\r\n        window.location.href = \"");
#nullable restore
#line 12 "C:\Users\sprno\source\repos\SSI-WebApp\Areas\Admin\Views\Home\Index.cshtml"
                           Write(Url.Action("Login"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n    </script>\r\n");
#nullable restore
#line 14 "C:\Users\sprno\source\repos\SSI-WebApp\Areas\Admin\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> _userManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ApplicationUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
