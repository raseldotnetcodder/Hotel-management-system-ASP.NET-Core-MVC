#pragma checksum "D:\1270237\GitHub\Hotel-Management-System\Views\RoomImages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f371b0acbb77ebc3ca1c156c3a85941d03d8b4fa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RoomImages_Index), @"mvc.1.0.view", @"/Views/RoomImages/Index.cshtml")]
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
#line 1 "D:\1270237\GitHub\Hotel-Management-System\Views\_ViewImports.cshtml"
using HotelApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\1270237\GitHub\Hotel-Management-System\Views\_ViewImports.cshtml"
using HotelApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f371b0acbb77ebc3ca1c156c3a85941d03d8b4fa", @"/Views/RoomImages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a233b9cca9704942898401d0bf47e554f69be65", @"/Views/_ViewImports.cshtml")]
    public class Views_RoomImages_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HotelApp.Database.RoomImages>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\1270237\GitHub\Hotel-Management-System\Views\RoomImages\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"text-center\"> Room Images</h1>\r\n\r\n<div id=\"view-all\">\r\n    ");
#nullable restore
#line 11 "D:\1270237\GitHub\Hotel-Management-System\Views\RoomImages\Index.cshtml"
Write(await Html.PartialAsync("_RoomImagesPartial", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HotelApp.Database.RoomImages>> Html { get; private set; }
    }
}
#pragma warning restore 1591