#pragma checksum "C:\Users\Venkatsai_Jeevanagar\source\repos\CoreDIDemo\Views\Home\Display.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2df7b77ca38bed2a8ac1097e9eb1a8cb15da5289"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Display), @"mvc.1.0.view", @"/Views/Home/Display.cshtml")]
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
#line 1 "C:\Users\Venkatsai_Jeevanagar\source\repos\CoreDIDemo\Views\_ViewImports.cshtml"
using CoreDIDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Venkatsai_Jeevanagar\source\repos\CoreDIDemo\Views\_ViewImports.cshtml"
using CoreDIDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2df7b77ca38bed2a8ac1097e9eb1a8cb15da5289", @"/Views/Home/Display.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84be4cd9bae91a0106e2968e29d600f914eda190", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Display : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Employee>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Venkatsai_Jeevanagar\source\repos\CoreDIDemo\Views\Home\Display.cshtml"
  
    ViewData["Title"] = "Display Employee Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome To Epam</h1>\r\n    <p><h2>");
#nullable restore
#line 9 "C:\Users\Venkatsai_Jeevanagar\source\repos\CoreDIDemo\Views\Home\Display.cshtml"
      Write(empRepository.GetAllEmployees().Last().Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2></p>\r\n    <p>This is our recent recruit</p>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IEmployeeRepository empRepository { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Employee> Html { get; private set; }
    }
}
#pragma warning restore 1591
