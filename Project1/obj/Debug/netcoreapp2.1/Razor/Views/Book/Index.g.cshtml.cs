#pragma checksum "C:\Users\aidok\source\repos\Project1\Project1\Views\Book\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b5447aa02fef920375fcb128f7a6f90940b75c8e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_Index), @"mvc.1.0.view", @"/Views/Book/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Book/Index.cshtml", typeof(AspNetCore.Views_Book_Index))]
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
#line 1 "C:\Users\aidok\source\repos\Project1\Project1\Views\_ViewImports.cshtml"
using Project1;

#line default
#line hidden
#line 2 "C:\Users\aidok\source\repos\Project1\Project1\Views\_ViewImports.cshtml"
using Project1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5447aa02fef920375fcb128f7a6f90940b75c8e", @"/Views/Book/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f8a1206ad760d99a32967ca6cf008da4df4ac8e", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Project1.Models.Books.Book>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "C:\Users\aidok\source\repos\Project1\Project1\Views\Book\Index.cshtml"
      
    ViewData["Title"] = "books";
    

#line default
#line hidden
            BeginContext(101, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(107, 26, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8b076266924742128376c8939e186664", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(133, 23, true);
            WriteLiteral("\r\n\r\n    <div>\r\n        ");
            EndContext();
            BeginContext(156, 32, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d8ccc3c96274d6bb32354605b2b8c31", async() => {
                BeginContext(176, 8, true);
                WriteLiteral("Add book");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(188, 191, true);
            WriteLiteral("\r\n    </div>\r\n\r\n    <hr />\r\n    <table class=\"table is-bordered is-striped is-narrow is-hoverable is-fullwidth\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(380, 36, false);
#line 19 "C:\Users\aidok\source\repos\Project1\Project1\Views\Book\Index.cshtml"
               Write(Html.DisplayNameFor(book => book.Id));

#line default
#line hidden
            EndContext();
            BeginContext(416, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(484, 40, false);
#line 22 "C:\Users\aidok\source\repos\Project1\Project1\Views\Book\Index.cshtml"
               Write(Html.DisplayNameFor(book => book.Poster));

#line default
#line hidden
            EndContext();
            BeginContext(524, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(592, 38, false);
#line 25 "C:\Users\aidok\source\repos\Project1\Project1\Views\Book\Index.cshtml"
               Write(Html.DisplayNameFor(book => book.Name));

#line default
#line hidden
            EndContext();
            BeginContext(630, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(698, 40, false);
#line 28 "C:\Users\aidok\source\repos\Project1\Project1\Views\Book\Index.cshtml"
               Write(Html.DisplayNameFor(book => book.Author));

#line default
#line hidden
            EndContext();
            BeginContext(738, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(806, 39, false);
#line 31 "C:\Users\aidok\source\repos\Project1\Project1\Views\Book\Index.cshtml"
               Write(Html.DisplayNameFor(book => book.Genre));

#line default
#line hidden
            EndContext();
            BeginContext(845, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(913, 43, false);
#line 34 "C:\Users\aidok\source\repos\Project1\Project1\Views\Book\Index.cshtml"
               Write(Html.DisplayNameFor(book => book.CreatedAt));

#line default
#line hidden
            EndContext();
            BeginContext(956, 81, true);
            WriteLiteral("\r\n                </th>\r\n\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 40 "C:\Users\aidok\source\repos\Project1\Project1\Views\Book\Index.cshtml"
             foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1081, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1142, 36, false);
#line 43 "C:\Users\aidok\source\repos\Project1\Project1\Views\Book\Index.cshtml"
               Write(Html.DisplayFor(bookItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1178, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1245, 50, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a895020d16e5404f9a5bb9b793b4dc57", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
#line 46 "C:\Users\aidok\source\repos\Project1\Project1\Views\Book\Index.cshtml"
                  WriteLiteral(item.Poster);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 46 "C:\Users\aidok\source\repos\Project1\Project1\Views\Book\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1295, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1363, 38, false);
#line 49 "C:\Users\aidok\source\repos\Project1\Project1\Views\Book\Index.cshtml"
               Write(Html.DisplayFor(bookItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1401, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1469, 40, false);
#line 52 "C:\Users\aidok\source\repos\Project1\Project1\Views\Book\Index.cshtml"
               Write(Html.DisplayFor(bookItem => item.Author));

#line default
#line hidden
            EndContext();
            BeginContext(1509, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1577, 39, false);
#line 55 "C:\Users\aidok\source\repos\Project1\Project1\Views\Book\Index.cshtml"
               Write(Html.DisplayFor(bookItem => item.Genre));

#line default
#line hidden
            EndContext();
            BeginContext(1616, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1684, 43, false);
#line 58 "C:\Users\aidok\source\repos\Project1\Project1\Views\Book\Index.cshtml"
               Write(Html.DisplayFor(bookItem => item.CreatedAt));

#line default
#line hidden
            EndContext();
            BeginContext(1727, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 61 "C:\Users\aidok\source\repos\Project1\Project1\Views\Book\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1782, 32, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Project1.Models.Books.Book>> Html { get; private set; }
    }
}
#pragma warning restore 1591