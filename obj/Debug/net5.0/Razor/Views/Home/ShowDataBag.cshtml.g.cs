#pragma checksum "/home/tecspace/ASPproject/ems/Views/Home/ShowDataBag.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ed6d88dd96b561c3c5d4221a7629fc0d299a94f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ShowDataBag), @"mvc.1.0.view", @"/Views/Home/ShowDataBag.cshtml")]
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
#line 1 "/home/tecspace/ASPproject/ems/Views/_ViewImports.cshtml"
using ems;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/tecspace/ASPproject/ems/Views/_ViewImports.cshtml"
using ems.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/tecspace/ASPproject/ems/Views/_ViewImports.cshtml"
using ems.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/tecspace/ASPproject/ems/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ed6d88dd96b561c3c5d4221a7629fc0d299a94f", @"/Views/Home/ShowDataBag.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8378af557991d2b15ff1aa24503e9edc0066eb4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ShowDataBag : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"en\">\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ed6d88dd96b561c3c5d4221a7629fc0d299a94f3447", async() => {
                WriteLiteral("\n    <meta charset=\"UTF-8\">\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\n    <title>Asp.net Core by techspace</title>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ed6d88dd96b561c3c5d4221a7629fc0d299a94f4614", async() => {
                WriteLiteral("\n    <h1><u>");
#nullable restore
#line 10 "/home/tecspace/ASPproject/ems/Views/Home/ShowDataBag.cshtml"
      Write(ViewBag.PageTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral("</u></h1>\n    <table class=\"table\">\n    <thead>\n    <tr>\n     <th>Name</th>\n     <th>Email</th>\n     <th>Department</th>\n     </tr>\n     </thead>\n     <tbody>\n     \n        <tr>\n        <td>\n        \n        ");
#nullable restore
#line 24 "/home/tecspace/ASPproject/ems/Views/Home/ShowDataBag.cshtml"
   Write(ViewBag.Staff.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        </td>\n         <td>\n        ");
#nullable restore
#line 27 "/home/tecspace/ASPproject/ems/Views/Home/ShowDataBag.cshtml"
   Write(ViewBag.Staff.Email);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        </td>\n         <td>\n        ");
#nullable restore
#line 30 "/home/tecspace/ASPproject/ems/Views/Home/ShowDataBag.cshtml"
   Write(ViewBag.Staff.Department);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        </td>\n        </tr>\n\n\n     </tbody>\n\n    </table>\n\n    \n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</html>");
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
