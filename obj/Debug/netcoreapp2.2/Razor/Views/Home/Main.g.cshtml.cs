#pragma checksum "C:\Users\j.napieralski\source\repos\SohbiRoomManager\SohbiRoomManager\Views\Home\Main.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f19b493b86541521c22ea700e6bd8504cdfd0b2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Main), @"mvc.1.0.view", @"/Views/Home/Main.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Main.cshtml", typeof(AspNetCore.Views_Home_Main))]
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
#line 1 "C:\Users\j.napieralski\source\repos\SohbiRoomManager\SohbiRoomManager\Views\_ViewImports.cshtml"
using RoomManagement1;

#line default
#line hidden
#line 2 "C:\Users\j.napieralski\source\repos\SohbiRoomManager\SohbiRoomManager\Views\_ViewImports.cshtml"
using RoomManagement1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f19b493b86541521c22ea700e6bd8504cdfd0b2", @"/Views/Home/Main.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac5d3ebbdcc3d2f1f17f1ba6f58ba5c8c142afaf", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Main : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Mystyles.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\j.napieralski\source\repos\SohbiRoomManager\SohbiRoomManager\Views\Home\Main.cshtml"
  
    ViewData["Title"] = "Home Page";
    Layout = "_Layout"; 
    

#line default
#line hidden
            BeginContext(75, 31, true);
            WriteLiteral("\r\n<!Doctype html>\r\n<html>\r\n    ");
            EndContext();
            BeginContext(106, 122, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f19b493b86541521c22ea700e6bd8504cdfd0b24473", async() => {
                BeginContext(112, 17, true);
                WriteLiteral("\r\n        <title>");
                EndContext();
                BeginContext(130, 17, false);
#line 9 "C:\Users\j.napieralski\source\repos\SohbiRoomManager\SohbiRoomManager\Views\Home\Main.cshtml"
          Write(ViewData["Title"]);

#line default
#line hidden
                EndContext();
                BeginContext(147, 18, true);
                WriteLiteral("</title>\r\n        ");
                EndContext();
                BeginContext(165, 50, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3f19b493b86541521c22ea700e6bd8504cdfd0b25252", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(215, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
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
            EndContext();
            BeginContext(228, 8, true);
            WriteLiteral("\r\n\r\n    ");
            EndContext();
            BeginContext(236, 557, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f19b493b86541521c22ea700e6bd8504cdfd0b27392", async() => {
                BeginContext(242, 262, true);
                WriteLiteral(@"
        <div id=""Welcome"">
            <h1 style=""font-size:50px;"">Witaj</h1>
            <p style=""margin-top:5%;font-size:20px;"">Oto prosta aplikacja do zarządzania salami. Co chcesz zrobić?</p>
        </div>

        <div id=""options"">
            <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 504, "\"", 537, 1);
#line 20 "C:\Users\j.napieralski\source\repos\SohbiRoomManager\SohbiRoomManager\Views\Home\Main.cshtml"
WriteAttributeValue("", 511, Url.Action("All", "Home"), 511, 26, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(538, 42, true);
                WriteLiteral(">Zobacz wszystkie sale</a>\r\n            <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 580, "\"", 616, 1);
#line 21 "C:\Users\j.napieralski\source\repos\SohbiRoomManager\SohbiRoomManager\Views\Home\Main.cshtml"
WriteAttributeValue("", 587, Url.Action("Choose", "Home"), 587, 29, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(617, 62, true);
                WriteLiteral(" style=\"margin-left:12%;\">Zarządzaj salami</a>\r\n            <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 679, "\"", 718, 1);
#line 22 "C:\Users\j.napieralski\source\repos\SohbiRoomManager\SohbiRoomManager\Views\Home\Main.cshtml"
WriteAttributeValue("", 686, Url.Action("Rezerwacja","Home"), 686, 32, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(719, 67, true);
                WriteLiteral(" style=\"margin-left:17%;\">Zarezerwuj sale</a>\r\n        </div>\r\n    ");
                EndContext();
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
            EndContext();
            BeginContext(793, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591