#pragma checksum "C:\Users\senth\Microservices\ManngoRestaurant\Mango.Website\Views\Product\ProductIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "297adba26f6cd876003f0497a1b3c9f4c4a33378"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_ProductIndex), @"mvc.1.0.view", @"/Views/Product/ProductIndex.cshtml")]
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
#line 1 "C:\Users\senth\Microservices\ManngoRestaurant\Mango.Website\Views\_ViewImports.cshtml"
using Mango.Website;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\senth\Microservices\ManngoRestaurant\Mango.Website\Views\_ViewImports.cshtml"
using Mango.Website.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"297adba26f6cd876003f0497a1b3c9f4c4a33378", @"/Views/Product/ProductIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b191cfe47078a7afe51a2f212b35c20a33b92863", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_ProductIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Mango.Website.Models.ProductDTO>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h1>Product Mango</h1>\r\n\r\n<table>\r\n    <thead>\r\n        <tr>\r\n            <th>Name</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 18 "C:\Users\senth\Microservices\ManngoRestaurant\Mango.Website\Views\Product\ProductIndex.cshtml"
         foreach(var i in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 21 "C:\Users\senth\Microservices\ManngoRestaurant\Mango.Website\Views\Product\ProductIndex.cshtml"
                   Write(i.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 23 "C:\Users\senth\Microservices\ManngoRestaurant\Mango.Website\Views\Product\ProductIndex.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Mango.Website.Models.ProductDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591