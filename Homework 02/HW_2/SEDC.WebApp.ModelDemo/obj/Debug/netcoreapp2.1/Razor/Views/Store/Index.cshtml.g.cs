#pragma checksum "D:\Ognen\SEDC\MVC\Homeworks-MVC\proba vrz Goce\HW_2\SEDC.WebApp.ModelDemo\Views\Store\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d26d5d22cf1b2659a1fbf131fb6e09169256e798"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Store_Index), @"mvc.1.0.view", @"/Views/Store/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Store/Index.cshtml", typeof(AspNetCore.Views_Store_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d26d5d22cf1b2659a1fbf131fb6e09169256e798", @"/Views/Store/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f442609473137e12d773eb7eebf639bb1cc9d6b", @"/Views/_ViewImports.cshtml")]
    public class Views_Store_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SEDC.WebApp.ModelDemo.Models.ViewModels.StoreVM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(69, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Ognen\SEDC\MVC\Homeworks-MVC\proba vrz Goce\HW_2\SEDC.WebApp.ModelDemo\Views\Store\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(112, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(141, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "444b9152653242df93f5aad011378d84", async() => {
                BeginContext(164, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(178, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(271, 40, false);
#line 16 "D:\Ognen\SEDC\MVC\Homeworks-MVC\proba vrz Goce\HW_2\SEDC.WebApp.ModelDemo\Views\Store\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(311, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(367, 40, false);
#line 19 "D:\Ognen\SEDC\MVC\Homeworks-MVC\proba vrz Goce\HW_2\SEDC.WebApp.ModelDemo\Views\Store\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
            EndContext();
            BeginContext(407, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(463, 40, false);
#line 22 "D:\Ognen\SEDC\MVC\Homeworks-MVC\proba vrz Goce\HW_2\SEDC.WebApp.ModelDemo\Views\Store\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Menu));

#line default
#line hidden
            EndContext();
            BeginContext(503, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 28 "D:\Ognen\SEDC\MVC\Homeworks-MVC\proba vrz Goce\HW_2\SEDC.WebApp.ModelDemo\Views\Store\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(638, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(699, 39, false);
#line 32 "D:\Ognen\SEDC\MVC\Homeworks-MVC\proba vrz Goce\HW_2\SEDC.WebApp.ModelDemo\Views\Store\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(738, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(806, 39, false);
#line 35 "D:\Ognen\SEDC\MVC\Homeworks-MVC\proba vrz Goce\HW_2\SEDC.WebApp.ModelDemo\Views\Store\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.City));

#line default
#line hidden
            EndContext();
            BeginContext(845, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(913, 45, false);
#line 38 "D:\Ognen\SEDC\MVC\Homeworks-MVC\proba vrz Goce\HW_2\SEDC.WebApp.ModelDemo\Views\Store\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Menu.Count));

#line default
#line hidden
            EndContext();
            BeginContext(958, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1026, 65, false);
#line 41 "D:\Ognen\SEDC\MVC\Homeworks-MVC\proba vrz Goce\HW_2\SEDC.WebApp.ModelDemo\Views\Store\Index.cshtml"
               Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1091, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(1116, 64, false);
#line 42 "D:\Ognen\SEDC\MVC\Homeworks-MVC\proba vrz Goce\HW_2\SEDC.WebApp.ModelDemo\Views\Store\Index.cshtml"
               Write(Html.ActionLink("Details", "StoreDetails", new {  id=item.Id  }));

#line default
#line hidden
            EndContext();
            BeginContext(1180, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(1205, 61, false);
#line 43 "D:\Ognen\SEDC\MVC\Homeworks-MVC\proba vrz Goce\HW_2\SEDC.WebApp.ModelDemo\Views\Store\Index.cshtml"
               Write(Html.ActionLink("Delete", "DeleteStore", new {  id=item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1266, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 46 "D:\Ognen\SEDC\MVC\Homeworks-MVC\proba vrz Goce\HW_2\SEDC.WebApp.ModelDemo\Views\Store\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1321, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SEDC.WebApp.ModelDemo.Models.ViewModels.StoreVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
