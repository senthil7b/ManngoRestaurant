#pragma checksum "C:\Users\senth\Microservices\ManngoRestaurant\Mango.Website\Views\Message\Subscriber.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "331f52c5a672717c732af5bf1ee7454b5e393672"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Message_Subscriber), @"mvc.1.0.view", @"/Views/Message/Subscriber.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"331f52c5a672717c732af5bf1ee7454b5e393672", @"/Views/Message/Subscriber.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b191cfe47078a7afe51a2f212b35c20a33b92863", @"/Views/_ViewImports.cshtml")]
    public class Views_Message_Subscriber : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SubscriberResponse>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Message", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral("\r\n<h2>Subscriber</h2>\r\n<br />\r\n\r\n");
#nullable restore
#line 6 "C:\Users\senth\Microservices\ManngoRestaurant\Mango.Website\Views\Message\Subscriber.cshtml"
 if (Model?.SubscriberMessages?.Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<h3>Messages to Subscriber</h3>\r\n");
            WriteLiteral("<ul>\r\n");
#nullable restore
#line 11 "C:\Users\senth\Microservices\ManngoRestaurant\Mango.Website\Views\Message\Subscriber.cshtml"
     foreach (var msg in Model.SubscriberMessages)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li>");
#nullable restore
#line 13 "C:\Users\senth\Microservices\ManngoRestaurant\Mango.Website\Views\Message\Subscriber.cshtml"
               Write(msg);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 14 "C:\Users\senth\Microservices\ManngoRestaurant\Mango.Website\Views\Message\Subscriber.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n");
#nullable restore
#line 16 "C:\Users\senth\Microservices\ManngoRestaurant\Mango.Website\Views\Message\Subscriber.cshtml"
}
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p>No messages retrieved/sent</p>\r\n");
#nullable restore
#line 20 "C:\Users\senth\Microservices\ManngoRestaurant\Mango.Website\Views\Message\Subscriber.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "331f52c5a672717c732af5bf1ee7454b5e3936725377", async() => {
                WriteLiteral("Return to Publisher");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SubscriberResponse> Html { get; private set; }
    }
}
#pragma warning restore 1591
