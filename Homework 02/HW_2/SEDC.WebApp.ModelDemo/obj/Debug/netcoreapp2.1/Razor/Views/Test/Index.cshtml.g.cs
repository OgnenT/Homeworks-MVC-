#pragma checksum "D:\Ognen\SEDC\MVC\Homeworks-MVC\proba vrz Goce\HW_2\SEDC.WebApp.ModelDemo\Views\Test\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8853c9f012ccb638b4a2562cab8acbeef9406cfc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Test_Index), @"mvc.1.0.view", @"/Views/Test/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Test/Index.cshtml", typeof(AspNetCore.Views_Test_Index))]
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
#line 1 "D:\Ognen\SEDC\MVC\Homeworks-MVC\proba vrz Goce\HW_2\SEDC.WebApp.ModelDemo\Views\_ViewImports.cshtml"
using SEDC.WebApp.ModelDemo;

#line default
#line hidden
#line 2 "D:\Ognen\SEDC\MVC\Homeworks-MVC\proba vrz Goce\HW_2\SEDC.WebApp.ModelDemo\Views\_ViewImports.cshtml"
using SEDC.WebApp.ModelDemo.Models;

#line default
#line hidden
#line 3 "D:\Ognen\SEDC\MVC\Homeworks-MVC\proba vrz Goce\HW_2\SEDC.WebApp.ModelDemo\Views\_ViewImports.cshtml"
using SEDC.WebApp.ModelDemo.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8853c9f012ccb638b4a2562cab8acbeef9406cfc", @"/Views/Test/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f442609473137e12d773eb7eebf639bb1cc9d6b", @"/Views/_ViewImports.cshtml")]
    public class Views_Test_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PizzaVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(16, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Ognen\SEDC\MVC\Homeworks-MVC\proba vrz Goce\HW_2\SEDC.WebApp.ModelDemo\Views\Test\Index.cshtml"
  
    string delivered = "Not delivered yet!";
    if (ViewBag.Show == true)
    {
        delivered = "Order is delivered!";
    }

#line default
#line hidden
            BeginContext(160, 37, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n\r\n<div>\r\n    <h4>");
            EndContext();
            BeginContext(198, 9, false);
#line 15 "D:\Ognen\SEDC\MVC\Homeworks-MVC\proba vrz Goce\HW_2\SEDC.WebApp.ModelDemo\Views\Test\Index.cshtml"
   Write(delivered);

#line default
#line hidden
            EndContext();
            BeginContext(207, 37, true);
            WriteLiteral("</h4>\r\n    <hr />\r\n    <h2>\r\n        ");
            EndContext();
            BeginContext(245, 10, false);
#line 18 "D:\Ognen\SEDC\MVC\Homeworks-MVC\proba vrz Goce\HW_2\SEDC.WebApp.ModelDemo\Views\Test\Index.cshtml"
   Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(255, 38, true);
            WriteLiteral("\r\n    </h2>\r\n    <h3>\r\n        Price: ");
            EndContext();
            BeginContext(294, 11, false);
#line 21 "D:\Ognen\SEDC\MVC\Homeworks-MVC\proba vrz Goce\HW_2\SEDC.WebApp.ModelDemo\Views\Test\Index.cshtml"
          Write(Model.Price);

#line default
#line hidden
            EndContext();
            BeginContext(305, 15, true);
            WriteLiteral("\r\n    </h3>\r\n\r\n");
            EndContext();
#line 24 "D:\Ognen\SEDC\MVC\Homeworks-MVC\proba vrz Goce\HW_2\SEDC.WebApp.ModelDemo\Views\Test\Index.cshtml"
     if (ViewBag.Show == true)
    {

#line default
#line hidden
            BeginContext(359, 53, true);
            WriteLiteral("        <div> Order is delivered</div>\r\n        <div>");
            EndContext();
            BeginContext(413, 12, false);
#line 27 "D:\Ognen\SEDC\MVC\Homeworks-MVC\proba vrz Goce\HW_2\SEDC.WebApp.ModelDemo\Views\Test\Index.cshtml"
        Write(DateTime.Now);

#line default
#line hidden
            EndContext();
            BeginContext(425, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 28 "D:\Ognen\SEDC\MVC\Homeworks-MVC\proba vrz Goce\HW_2\SEDC.WebApp.ModelDemo\Views\Test\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(440, 6, true);
            WriteLiteral("<ul>\r\n");
            EndContext();
#line 30 "D:\Ognen\SEDC\MVC\Homeworks-MVC\proba vrz Goce\HW_2\SEDC.WebApp.ModelDemo\Views\Test\Index.cshtml"
     foreach (var pizza in ViewBag.Pizzas)
    {

#line default
#line hidden
            BeginContext(497, 18, true);
            WriteLiteral("        <li>Name: ");
            EndContext();
            BeginContext(516, 10, false);
#line 32 "D:\Ognen\SEDC\MVC\Homeworks-MVC\proba vrz Goce\HW_2\SEDC.WebApp.ModelDemo\Views\Test\Index.cshtml"
             Write(pizza.Name);

#line default
#line hidden
            EndContext();
            BeginContext(526, 9, true);
            WriteLiteral(" , Size: ");
            EndContext();
            BeginContext(536, 10, false);
#line 32 "D:\Ognen\SEDC\MVC\Homeworks-MVC\proba vrz Goce\HW_2\SEDC.WebApp.ModelDemo\Views\Test\Index.cshtml"
                                 Write(pizza.Size);

#line default
#line hidden
            EndContext();
            BeginContext(546, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 33 "D:\Ognen\SEDC\MVC\Homeworks-MVC\proba vrz Goce\HW_2\SEDC.WebApp.ModelDemo\Views\Test\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(560, 24, true);
            WriteLiteral("</ul>\r\n   \r\n\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PizzaVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
