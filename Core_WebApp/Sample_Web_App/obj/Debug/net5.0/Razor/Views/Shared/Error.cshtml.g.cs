#pragma checksum "C:\Users\Coditas\source\repos\Core_WebApp\Sample_Web_App\Views\Shared\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "953e3fcdbc82fb0b9cf8802a0cf7d4f222a303f9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Error), @"mvc.1.0.view", @"/Views/Shared/Error.cshtml")]
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
#line 1 "C:\Users\Coditas\source\repos\Core_WebApp\Sample_Web_App\Views\_ViewImports.cshtml"
using Sample_Web_App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Coditas\source\repos\Core_WebApp\Sample_Web_App\Views\_ViewImports.cshtml"
using Sample_Web_App.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"953e3fcdbc82fb0b9cf8802a0cf7d4f222a303f9", @"/Views/Shared/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7e88a48094aa80a632d570465c7b69d0a38495d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ErrorViewModel>
    {
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
#nullable restore
#line 2 "C:\Users\Coditas\source\repos\Core_WebApp\Sample_Web_App\Views\Shared\Error.cshtml"
  
    ViewData["Title"] = "Error";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"text-danger\">Error.</h1>\r\n<h2 class=\"text-danger\">An error occurred while processing your request.</h2>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\Coditas\source\repos\Core_WebApp\Sample_Web_App\Views\Shared\Error.cshtml"
 if(Model!=null)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Coditas\source\repos\Core_WebApp\Sample_Web_App\Views\Shared\Error.cshtml"
 if (Model.ShowRequestId)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n        <strong>Request ID:</strong> <code>");
#nullable restore
#line 15 "C:\Users\Coditas\source\repos\Core_WebApp\Sample_Web_App\Views\Shared\Error.cshtml"
                                      Write(Model.RequestId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</code>\r\n    </p>\r\n");
#nullable restore
#line 17 "C:\Users\Coditas\source\repos\Core_WebApp\Sample_Web_App\Views\Shared\Error.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h3>Development Mode</h3>
<p>
    Swapping to <strong>Development</strong> environment will display more detailed information about the error that occurred.
</p>
<p>
    <strong>The Development environment shouldn't be enabled for deployed applications.</strong>
    It can result in displaying sensitive information from exceptions to end users.
    For local debugging, enable the <strong>Development</strong> environment by setting the <strong>ASPNETCORE_ENVIRONMENT</strong> environment variable to <strong>Development</strong>
    and restarting the app.
</p>
<h3>Hay MVC !!! These are Custom Errors</h3>
<p>
    <strong>
        Error Ocured in ");
#nullable restore
#line 32 "C:\Users\Coditas\source\repos\Core_WebApp\Sample_Web_App\Views\Shared\Error.cshtml"
                   Write(Model.ControllerName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" in ");
#nullable restore
#line 32 "C:\Users\Coditas\source\repos\Core_WebApp\Sample_Web_App\Views\Shared\Error.cshtml"
                                            Write(Model.ActionName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" method and <br/>\r\n        Error Message is ");
#nullable restore
#line 33 "C:\Users\Coditas\source\repos\Core_WebApp\Sample_Web_App\Views\Shared\Error.cshtml"
                    Write(Model.ErrorMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </strong>\r\n</p>\r\n<hr/>\r\n<!--Link to GO BAck-->\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "953e3fcdbc82fb0b9cf8802a0cf7d4f222a303f95903", async() => {
                WriteLiteral("GO Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 39 "C:\Users\Coditas\source\repos\Core_WebApp\Sample_Web_App\Views\Shared\Error.cshtml"
   WriteLiteral(Model.ActionName);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-action", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 39 "C:\Users\Coditas\source\repos\Core_WebApp\Sample_Web_App\Views\Shared\Error.cshtml"
                                      WriteLiteral(Model.ControllerName);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-controller", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 40 "C:\Users\Coditas\source\repos\Core_WebApp\Sample_Web_App\Views\Shared\Error.cshtml"

}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<h3>Hay MVC !!! These are Custom Errors From Cusom Exception Filter</h3>\r\n<p>\r\n    <strong>\r\n        Error Ocured in ");
#nullable restore
#line 47 "C:\Users\Coditas\source\repos\Core_WebApp\Sample_Web_App\Views\Shared\Error.cshtml"
                   Write(ViewData["ControllerName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" in ");
#nullable restore
#line 47 "C:\Users\Coditas\source\repos\Core_WebApp\Sample_Web_App\Views\Shared\Error.cshtml"
                                                  Write(ViewData["ActionName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" method and <br/>\r\n        Error Message is ");
#nullable restore
#line 48 "C:\Users\Coditas\source\repos\Core_WebApp\Sample_Web_App\Views\Shared\Error.cshtml"
                    Write(ViewData["Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </strong>\r\n</p>\r\n<hr/>\r\n<!--Link to GO BAck-->\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "953e3fcdbc82fb0b9cf8802a0cf7d4f222a303f99423", async() => {
                WriteLiteral("GO Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 54 "C:\Users\Coditas\source\repos\Core_WebApp\Sample_Web_App\Views\Shared\Error.cshtml"
   WriteLiteral(ViewData["ActionName"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-action", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 54 "C:\Users\Coditas\source\repos\Core_WebApp\Sample_Web_App\Views\Shared\Error.cshtml"
                                            WriteLiteral(ViewData["ControllerName"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-controller", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("    \r\n");
#nullable restore
#line 55 "C:\Users\Coditas\source\repos\Core_WebApp\Sample_Web_App\Views\Shared\Error.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ErrorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
