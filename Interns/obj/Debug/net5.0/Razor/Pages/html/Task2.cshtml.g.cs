#pragma checksum "C:\Users\hasmi\source\repos\Interns\Interns\Pages\html\Task2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4399a73b8fcbff08fbc1653632f79f0b25a85d78"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Interns.Pages.html.Pages_html_Task2), @"mvc.1.0.razor-page", @"/Pages/html/Task2.cshtml")]
namespace Interns.Pages.html
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
#line 1 "C:\Users\hasmi\source\repos\Interns\Interns\Pages\_ViewImports.cshtml"
using Interns;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4399a73b8fcbff08fbc1653632f79f0b25a85d78", @"/Pages/html/Task2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bffb267c2f5c61a1502137fe5758be03c6f9c81b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_html_Task2 : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
            WriteLiteral("    <!DOCTYPE html>\r\n    <html lang=\"en\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4399a73b8fcbff08fbc1653632f79f0b25a85d783062", async() => {
                WriteLiteral("\r\n\r\n        <title>Html</title>\r\n\r\n    ");
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
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4399a73b8fcbff08fbc1653632f79f0b25a85d784075", async() => {
                WriteLiteral(@"
        <h1>My First Web Page</h1>
        <h2> Headings </h2>
        <p> This is my first paragraph in my new webpage. This is going to be great. I am so excited I ca:n hardly contain myself. Don't you just love parag,aphs? I find them very useful.</p>
        <p>
            Web Pages Are Exciting Too<br />
            Yes, that's right - web pages can be a lot of fun. Le.arning how to create web pages is easy and entertaining. This is my second paragraph. I hope you like it.
        </p>

        <p>
            <a href=""https://www.google.com/"" target=""_blank"">
                Link to Google
            </a>
        </p>

        <ul>
            <li>Apples</li>
            <li>Bananas</li>
            <li>Pears</li>
            <li>Oranges</li>
            <li>Grapes</li>
        </ul>
        <br />
        <p>Simple table with header</p>
        <table>
            <tr>
                <th>First name</th>
                <th>Last name</th>
            </tr>
            <t");
                WriteLiteral(@"r>
                <td>John</td>
                <td>Doe</td>
            </tr>
            <tr>
                <td>Jane</td>
                <td>Doe</td>
            </tr>
        </table>

        <p>Table with thead, tfoot, and tbody</p>
        <table>
            <thead>
                <tr>
                    <th>Header content 1</th>
                    <th>Header content 2</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>Body content 1</td>
                    <td>Body content 2</td>
                </tr>
            </tbody>
            <tfoot>
                <tr>
                    <td>Footer content 1</td>
                    <td>Footer content 2</td>
                </tr>
            </tfoot>
        </table>

        <p>Table with colgroup</p>
        <table>
            <colgroup span=""4""></colgroup>
            <tr>
                <th>Countries</th>
                <th>Capitals</th>
      ");
                WriteLiteral(@"          <th>Population</th>
                <th>Language</th>
            </tr>
            <tr>
                <td>USA</td>
                <td>Washington, D.C.</td>
                <td>309 million</td>
                <td>English</td>
            </tr>
            <tr>
                <td>Sweden</td>
                <td>Stockholm</td>
                <td>9 million</td>
                <td>Swedish</td>
            </tr>
        </table>

        <p>Table with colgroup and col</p>
        <table>
            <colgroup>
                <col style=""background-color: #0f0"">
                <col span=""2"">
            </colgroup>
            <tr>
                <th>Lime</th>
                <th>Lemon</th>
                <th>Orange</th>
            </tr>
            <tr>
                <td>Green</td>
                <td>Yellow</td>
                <td>Orange</td>
            </tr>
        </table>

        <p>Simple table with caption</p>
        <table>
            <capti");
                WriteLiteral(@"on>Awesome caption</caption>
            <tr>
                <td>Awesome data</td>
            </tr>
        </table>
        <hr />
        <footer>
            &copy; 2022 - Interns - <a href=""7smarts.com"" target=""_blank"">7smarts.com</a>
        </footer>
    ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_html_Task2> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_html_Task2> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_html_Task2>)PageContext?.ViewData;
        public Pages_html_Task2 Model => ViewData.Model;
    }
}
#pragma warning restore 1591