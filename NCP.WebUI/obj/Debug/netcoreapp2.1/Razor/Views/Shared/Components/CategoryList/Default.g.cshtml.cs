#pragma checksum "C:\Users\elif.karayel\source\repos\NetCoreProject\NCP.WebUI\Views\Shared\Components\CategoryList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e190760f79e6c518711c3048ca9951addbfad1f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CategoryList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CategoryList/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/CategoryList/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_CategoryList_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e190760f79e6c518711c3048ca9951addbfad1f", @"/Views/Shared/Components/CategoryList/Default.cshtml")]
    public class Views_Shared_Components_CategoryList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NCP.WebUI.Model.CategoryListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\elif.karayel\source\repos\NetCoreProject\NCP.WebUI\Views\Shared\Components\CategoryList\Default.cshtml"
  
    Layout = null;

#line default
#line hidden
#line 5 "C:\Users\elif.karayel\source\repos\NetCoreProject\NCP.WebUI\Views\Shared\Components\CategoryList\Default.cshtml"
 foreach (var item in Model.Categories)
{
    var css = "list-group-item";
    if (item.ID == Model.CurrentCategory)
    {
        css += " active";
    }

#line default
#line hidden
            BeginContext(235, 6, true);
            WriteLiteral("    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 241, "\"", 278, 3);
            WriteAttributeValue("", 248, "/Home/Index?category=", 248, 21, true);
#line 12 "C:\Users\elif.karayel\source\repos\NetCoreProject\NCP.WebUI\Views\Shared\Components\CategoryList\Default.cshtml"
WriteAttributeValue("", 269, item.ID, 269, 8, false);

#line default
#line hidden
            WriteAttributeValue(" ", 277, "", 278, 1, true);
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 279, "\"", 291, 1);
#line 12 "C:\Users\elif.karayel\source\repos\NetCoreProject\NCP.WebUI\Views\Shared\Components\CategoryList\Default.cshtml"
WriteAttributeValue("", 287, css, 287, 4, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(292, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(294, 9, false);
#line 12 "C:\Users\elif.karayel\source\repos\NetCoreProject\NCP.WebUI\Views\Shared\Components\CategoryList\Default.cshtml"
                                                     Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(303, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 13 "C:\Users\elif.karayel\source\repos\NetCoreProject\NCP.WebUI\Views\Shared\Components\CategoryList\Default.cshtml"
}

#line default
#line hidden
            BeginContext(312, 58, true);
            WriteLiteral("<a href=\"/Home/Index\" class=\"list-group-item\">Tümü</a>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NCP.WebUI.Model.CategoryListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
