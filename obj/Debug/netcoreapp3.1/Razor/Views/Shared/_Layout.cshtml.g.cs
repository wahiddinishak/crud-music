#pragma checksum "D:\Users\wahidin.ishak\source\repos\crud_music\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef4530dd02dce926abb62049caeff22893d7c78f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "D:\Users\wahidin.ishak\source\repos\crud_music\Views\_ViewImports.cshtml"
using crud_music;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Users\wahidin.ishak\source\repos\crud_music\Views\_ViewImports.cshtml"
using crud_music.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef4530dd02dce926abb62049caeff22893d7c78f", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3552185432278683b99609619d4ec4cf8e2d8c04", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-brand"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef4530dd02dce926abb62049caeff22893d7c78f4625", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n    <title>");
#nullable restore
#line 6 "D:\Users\wahidin.ishak\source\repos\crud_music\Views\Shared\_Layout.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</title>\r\n\r\n    <link");
                BeginWriteAttribute("href", " href=\"", 201, "\"", 266, 1);
#nullable restore
#line 8 "D:\Users\wahidin.ishak\source\repos\crud_music\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 208, Url.Content("~/lib/bootstrap/dist/css/bootstrap.min.css"), 208, 58, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\" />\r\n    <link");
                BeginWriteAttribute("href", " href=\"", 298, "\"", 335, 1);
#nullable restore
#line 9 "D:\Users\wahidin.ishak\source\repos\crud_music\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 305, Url.Content("~/css/site.css"), 305, 30, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\" />\r\n\r\n    <link");
                BeginWriteAttribute("href", " href=\"", 369, "\"", 437, 1);
#nullable restore
#line 11 "D:\Users\wahidin.ishak\source\repos\crud_music\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 376, Url.Content("~/lib/datatable/dataTables.bootstrap4.min.css"), 376, 61, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\" />\r\n    <link");
                BeginWriteAttribute("href", " href=\"", 469, "\"", 534, 1);
#nullable restore
#line 12 "D:\Users\wahidin.ishak\source\repos\crud_music\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 476, Url.Content("~/lib/datatable/buttons.bootstrap4.min.css"), 476, 58, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\" />\r\n    <link");
                BeginWriteAttribute("href", " href=\"", 566, "\"", 630, 1);
#nullable restore
#line 13 "D:\Users\wahidin.ishak\source\repos\crud_music\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 573, Url.Content("~/lib/datatable/select.dataTables.min.css"), 573, 57, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\" />\r\n\r\n    <link");
                BeginWriteAttribute("href", " href=\"", 664, "\"", 719, 1);
#nullable restore
#line 15 "D:\Users\wahidin.ishak\source\repos\crud_music\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 671, Url.Content("~/lib/sweetalert/sweetalert2.css"), 671, 48, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\" />\r\n\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef4530dd02dce926abb62049caeff22893d7c78f8615", async() => {
                WriteLiteral("\r\n    <header>\r\n        <nav class=\"navbar navbar-expand-sm navbar-toggleable-sm navbar-light bg-white border-bottom box-shadow mb-3\">\r\n            <div class=\"container\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef4530dd02dce926abb62049caeff22893d7c78f9070", async() => {
                    WriteLiteral("CRUD Music");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target="".navbar-collapse"" aria-controls=""navbarSupportedContent""
                        aria-expanded=""false"" aria-label=""Toggle navigation"">
                    <span class=""navbar-toggler-icon""></span>
                </button>
            </div>
        </nav>
    </header>
    <div class=""container"">
        <main role=""main"" class=""pb-3"">
            ");
#nullable restore
#line 32 "D:\Users\wahidin.ishak\source\repos\crud_music\Views\Shared\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </main>\r\n    </div>\r\n\r\n    <footer class=\"border-top footer text-muted\">\r\n        <div class=\"container\">\r\n            &copy; 2020 - Wahiddin Ishak\r\n        </div>\r\n    </footer>\r\n\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 1714, "\"", 1767, 1);
#nullable restore
#line 42 "D:\Users\wahidin.ishak\source\repos\crud_music\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1720, Url.Content("~/lib/jquery/dist/jquery.min.js"), 1720, 47, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 1793, "\"", 1862, 1);
#nullable restore
#line 44 "D:\Users\wahidin.ishak\source\repos\crud_music\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1799, Url.Content("~/lib/jquery-validation/dist/jquery.validate.js"), 1799, 63, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 1886, "\"", 1974, 1);
#nullable restore
#line 45 "D:\Users\wahidin.ishak\source\repos\crud_music\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1892, Url.Content("~/lib/jquery-validation-unobtrusive/jquery.validate.unobtrusive.js"), 1892, 82, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 2000, "\"", 2069, 1);
#nullable restore
#line 47 "D:\Users\wahidin.ishak\source\repos\crud_music\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2006, Url.Content("~/lib/bootstrap/dist/js/bootstrap.bundle.min.js"), 2006, 63, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 2095, "\"", 2157, 1);
#nullable restore
#line 49 "D:\Users\wahidin.ishak\source\repos\crud_music\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2101, Url.Content("~/lib/datatable/jquery.dataTables.min.js"), 2101, 56, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 2181, "\"", 2247, 1);
#nullable restore
#line 50 "D:\Users\wahidin.ishak\source\repos\crud_music\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2187, Url.Content("~/lib/datatable/dataTables.bootstrap4.min.js"), 2187, 60, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 2273, "\"", 2326, 1);
#nullable restore
#line 52 "D:\Users\wahidin.ishak\source\repos\crud_music\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2279, Url.Content("~/lib/sweetalert/sweetalert2.js"), 2279, 47, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 2352, "\"", 2400, 1);
#nullable restore
#line 54 "D:\Users\wahidin.ishak\source\repos\crud_music\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2358, Url.Content("~/lib/moment/moment.min.js"), 2358, 42, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 2426, "\"", 2460, 1);
#nullable restore
#line 56 "D:\Users\wahidin.ishak\source\repos\crud_music\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2432, Url.Content("~/js/site.js"), 2432, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n\r\n    ");
#nullable restore
#line 58 "D:\Users\wahidin.ishak\source\repos\crud_music\Views\Shared\_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
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
            WriteLiteral("\r\n</html>\r\n");
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
