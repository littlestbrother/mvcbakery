#pragma checksum "/home/aaron/Documents/epicodus/epicodus-fullstack/code-review/MVCBakery/MVCBakery/Views/Vendors/Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ace0034bd69483cf892277841bf35530e5a60dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vendors_Show), @"mvc.1.0.view", @"/Views/Vendors/Show.cshtml")]
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
#line 1 "/home/aaron/Documents/epicodus/epicodus-fullstack/code-review/MVCBakery/MVCBakery/Views/Vendors/Show.cshtml"
using MVCBakery.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ace0034bd69483cf892277841bf35530e5a60dd", @"/Views/Vendors/Show.cshtml")]
    public class Views_Vendors_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/home/aaron/Documents/epicodus/epicodus-fullstack/code-review/MVCBakery/MVCBakery/Views/Vendors/Show.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h3>Here are all the orders in this vendor:</h3>\n\n<ol>\n");
#nullable restore
#line 8 "/home/aaron/Documents/epicodus/epicodus-fullstack/code-review/MVCBakery/MVCBakery/Views/Vendors/Show.cshtml"
 foreach (Order order in @Model["Orders"])
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <li><a");
            BeginWriteAttribute("href", " href=\'", 160, "\'", 212, 4);
            WriteAttributeValue("", 167, "/vendors/", 167, 9, true);
#nullable restore
#line 10 "/home/aaron/Documents/epicodus/epicodus-fullstack/code-review/MVCBakery/MVCBakery/Views/Vendors/Show.cshtml"
WriteAttributeValue("", 176, Model["Vendor"].Id, 176, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 195, "/orders/", 195, 8, true);
#nullable restore
#line 10 "/home/aaron/Documents/epicodus/epicodus-fullstack/code-review/MVCBakery/MVCBakery/Views/Vendors/Show.cshtml"
WriteAttributeValue("", 203, order.Id, 203, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 10 "/home/aaron/Documents/epicodus/epicodus-fullstack/code-review/MVCBakery/MVCBakery/Views/Vendors/Show.cshtml"
                                                         Write(order.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\n  <p><a");
            BeginWriteAttribute("href", " href=\'", 243, "\'", 289, 3);
            WriteAttributeValue("", 250, "/vendors/", 250, 9, true);
#nullable restore
#line 11 "/home/aaron/Documents/epicodus/epicodus-fullstack/code-review/MVCBakery/MVCBakery/Views/Vendors/Show.cshtml"
WriteAttributeValue("", 259, Model["Vendor"].Id, 259, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 278, "/orders/new", 278, 11, true);
            EndWriteAttribute();
            WriteLiteral(">Add a new order</a></p>\n");
#nullable restore
#line 12 "/home/aaron/Documents/epicodus/epicodus-fullstack/code-review/MVCBakery/MVCBakery/Views/Vendors/Show.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</ol>\n\n<p><a");
            BeginWriteAttribute("href", " href=\'", 329, "\'", 375, 3);
            WriteAttributeValue("", 336, "/vendors/", 336, 9, true);
#nullable restore
#line 15 "/home/aaron/Documents/epicodus/epicodus-fullstack/code-review/MVCBakery/MVCBakery/Views/Vendors/Show.cshtml"
WriteAttributeValue("", 345, Model["Vendor"].Id, 345, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 364, "/orders/new", 364, 11, true);
            EndWriteAttribute();
            WriteLiteral(">Add a new order</a></p>\n<p><a href=\'/vendors\'>Return to vendor list</a></p>\n<p><a href=\'/\'>Return to Main Page</a></p>");
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