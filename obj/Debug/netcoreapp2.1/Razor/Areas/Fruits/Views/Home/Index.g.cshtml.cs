#pragma checksum "C:\Users\Катя\source\repos\DonutsShopApp\DonutsShopApp\Areas\Fruits\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41d6649d933fb2c5ad865d1e6e0d8c1002aa93c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Fruits_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Fruits/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Fruits/Views/Home/Index.cshtml", typeof(AspNetCore.Areas_Fruits_Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41d6649d933fb2c5ad865d1e6e0d8c1002aa93c9", @"/Areas/Fruits/Views/Home/Index.cshtml")]
    public class Areas_Fruits_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/explosion.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Катя\source\repos\DonutsShopApp\DonutsShopApp\Areas\Fruits\Views\Home\Index.cshtml"
  
    ViewBag.Title = "Game Play";

#line default
#line hidden
            BeginContext(41, 24, true);
            WriteLiteral("\r\n<h2>Game Play</h2>\r\n\r\n");
            EndContext();
#line 7 "C:\Users\Катя\source\repos\DonutsShopApp\DonutsShopApp\Areas\Fruits\Views\Home\Index.cshtml"
 if (!ViewBag.gameOver)
{

#line default
#line hidden
            BeginContext(93, 423, true);
            WriteLiteral(@"    <form asp-area=""Fruits"" asp-controller=""Home"" asp-action=""FireTop"">
        Top: <input type=""range"" name=""position"" min=""0"" max=""100"" />
        <input type=""submit"" value=""Fire Top"" />
    </form>
    <form asp-area=""Fruits"" asp-controller=""Home"" asp-action=""FireBottom"">
        Bottom: <input type=""range"" name=""position"" min=""0"" max=""100"" />
        <input type=""submit"" value=""Fire Bottom"" />
    </form>
");
            EndContext();
#line 17 "C:\Users\Катя\source\repos\DonutsShopApp\DonutsShopApp\Areas\Fruits\Views\Home\Index.cshtml"
}

#line default
#line hidden
            BeginContext(519, 129, true);
            WriteLiteral("\r\n<form  asp-area=\"Fruits\" asp-controller=\"Home\" asp-action=\"Reset\">\r\n    <input type=\"submit\" value=\"New Game\" />\r\n</form>\r\n\r\n\r\n");
            EndContext();
#line 24 "C:\Users\Катя\source\repos\DonutsShopApp\DonutsShopApp\Areas\Fruits\Views\Home\Index.cshtml"
 if (ViewBag.gameOver)
{

#line default
#line hidden
            BeginContext(675, 29, true);
            WriteLiteral("    <h2>Game Over!</h2>\r\n    ");
            EndContext();
            BeginContext(704, 36, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c0f91685a5dc4746883dc54561c6523b", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(740, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 28 "C:\Users\Катя\source\repos\DonutsShopApp\DonutsShopApp\Areas\Fruits\Views\Home\Index.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(754, 27, true);
            WriteLiteral("    <h2>Battle Field</h2>\r\n");
            EndContext();
#line 32 "C:\Users\Катя\source\repos\DonutsShopApp\DonutsShopApp\Areas\Fruits\Views\Home\Index.cshtml"
    for (var row = 0; row < ViewBag.rowsCount; row++)
    {
        for (int col = 0; col < ViewBag.colsCount; col++)
        {

#line default
#line hidden
            BeginContext(913, 16, true);
            WriteLiteral("            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\'", 929, "\'", 974, 3);
            WriteAttributeValue("", 935, "/images/", 935, 8, true);
#line 36 "C:\Users\Катя\source\repos\DonutsShopApp\DonutsShopApp\Areas\Fruits\Views\Home\Index.cshtml"
WriteAttributeValue("", 943, ViewBag.fruits[row, col], 943, 27, false);

#line default
#line hidden
            WriteAttributeValue("", 970, ".png", 970, 4, true);
            EndWriteAttribute();
            BeginContext(975, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
#line 37 "C:\Users\Катя\source\repos\DonutsShopApp\DonutsShopApp\Areas\Fruits\Views\Home\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(991, 16, true);
            WriteLiteral("        <br />\r\n");
            EndContext();
#line 39 "C:\Users\Катя\source\repos\DonutsShopApp\DonutsShopApp\Areas\Fruits\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1014, 18, true);
            WriteLiteral("    <h2>Score: <b>");
            EndContext();
            BeginContext(1033, 13, false);
#line 40 "C:\Users\Катя\source\repos\DonutsShopApp\DonutsShopApp\Areas\Fruits\Views\Home\Index.cshtml"
             Write(ViewBag.score);

#line default
#line hidden
            EndContext();
            BeginContext(1046, 11, true);
            WriteLiteral("</b></h2>\r\n");
            EndContext();
#line 41 "C:\Users\Катя\source\repos\DonutsShopApp\DonutsShopApp\Areas\Fruits\Views\Home\Index.cshtml"
}

#line default
#line hidden
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