#pragma checksum "C:\Users\gurhan\source\repos\Blogget\Blogget.WebUI\Views\Shared\Components\AbilityMenu\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3bf7d20752e73c33539616f9e71cb30bcdd8b6ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_AbilityMenu_Default), @"mvc.1.0.view", @"/Views/Shared/Components/AbilityMenu/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/AbilityMenu/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_AbilityMenu_Default))]
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
#line 1 "C:\Users\gurhan\source\repos\Blogget\Blogget.WebUI\Views\_ViewImports.cshtml"
using Blogget.WebUI;

#line default
#line hidden
#line 2 "C:\Users\gurhan\source\repos\Blogget\Blogget.WebUI\Views\_ViewImports.cshtml"
using Blogget.WebUI.Models;

#line default
#line hidden
#line 3 "C:\Users\gurhan\source\repos\Blogget\Blogget.WebUI\Views\_ViewImports.cshtml"
using Blogget.Entity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bf7d20752e73c33539616f9e71cb30bcdd8b6ea", @"/Views/Shared/Components/AbilityMenu/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0603717a276f07361707e998290d2ab28da898e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_AbilityMenu_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Ability>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 209, true);
            WriteLiteral("\r\n\r\n<li class=\"dropdown\">\r\n    <a href=\"#\" class=\"dropdown-toggle  nav-link\" data-toggle=\"dropdown\" role=\"button\"\r\n       aria-expanded=\"false\">YETENEKLERİM</a>\r\n    <ul class=\"dropdown-menu \" role=\"menu\">\r\n\r\n");
            EndContext();
#line 9 "C:\Users\gurhan\source\repos\Blogget\Blogget.WebUI\Views\Shared\Components\AbilityMenu\Default.cshtml"
         foreach (var item in Model)
        {


#line default
#line hidden
            BeginContext(289, 50, true);
            WriteLiteral("            <li><a href=\"#\" class=\"nav-link ml-3\">");
            EndContext();
            BeginContext(340, 16, false);
#line 12 "C:\Users\gurhan\source\repos\Blogget\Blogget.WebUI\Views\Shared\Components\AbilityMenu\Default.cshtml"
                                             Write(item.AbilityName);

#line default
#line hidden
            EndContext();
            BeginContext(356, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 13 "C:\Users\gurhan\source\repos\Blogget\Blogget.WebUI\Views\Shared\Components\AbilityMenu\Default.cshtml"

        }

#line default
#line hidden
            BeginContext(380, 18, true);
            WriteLiteral("    </ul>\r\n\r\n</li>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Ability>> Html { get; private set; }
    }
}
#pragma warning restore 1591
