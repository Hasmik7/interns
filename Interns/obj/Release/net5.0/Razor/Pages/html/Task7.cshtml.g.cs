#pragma checksum "C:\Users\hasmi\source\repos\Interns\Interns\Pages\html\Task7.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "999ad418227e36b874c42bbb2d7ba33cade8a4cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Interns.Pages.html.Pages_html_Task7), @"mvc.1.0.razor-page", @"/Pages/html/Task7.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"999ad418227e36b874c42bbb2d7ba33cade8a4cd", @"/Pages/html/Task7.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bffb267c2f5c61a1502137fe5758be03c6f9c81b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_html_Task7 : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
            WriteLiteral("    <!DOCTYPE html>\r\n    <html>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "999ad418227e36b874c42bbb2d7ba33cade8a4cd3050", async() => {
                WriteLiteral("\r\n\r\n    ");
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
            WriteLiteral("\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "999ad418227e36b874c42bbb2d7ba33cade8a4cd4032", async() => {
                WriteLiteral(@"
        <style>

* {
	box-sizing: border-box;
}

body {
	background-image: linear-gradient(120deg, #fdfbfb 0%, #ebedee 100%);
	display: flex;
	flex-direction: column;
	font-family: 'Muli', sans-serif;
	align-items: center;
	justify-content: center;
	min-height: 100vh;
	margin: 0 0 50px;
}

a {
	color: #3498db;
}

a:hover {
	text-decoration: underline;
}

h1 {
	margin-bottom: 20px;
	text-align: center;
}

small {
	margin-top: 10px;
}

table {
	box-shadow: 0 2px 10px rgba(0, 0, 0, 0.2);
	border-spacing: 0;
}

table tr th {
	background-color: #F1F5F8;
	border-bottom: 2px solid #ccc;
	font-size: 12px;
	padding: 10px;
	text-transform: uppercase;
	text-align: left;
}

table tr {
	border-bottom: 1px solid #ccc;
}

table tr td {
	background-color: #fff;
	border: 0;
	border-bottom: 1px solid #ccc;
	padding: 10px;
}

table tr:nth-of-type(odd) td {
	background-color: #f9f9f9;
}

table tr:last-of-type td {
	border-bottom: 0;
}

table tr td img {
	borde");
                WriteLiteral(@"r-radius: 50%;
	object-fit: cover;
	height: 35px;
	width: 35px;
}

table tr td:nth-of-type(2), table tr td:nth-of-type(3) {
	font-weight: bold;
}

table tr td:nth-of-type(3), table tr td:nth-of-type(4) {
	text-align: center;
}



/* SOCIAL PANEL CSS */
.social-panel-container {
	position: fixed;
	right: 0;
	bottom: 80px;
	transform: translateX(100%);
	transition: transform 0.4s ease-in-out;
}

.social-panel-container.visible {
	transform: translateX(-10px);
}

.social-panel {
	background-color: #fff;
	border-radius: 16px;
	box-shadow: 0 16px 31px -17px rgba(0,31,97,0.6);
	border: 5px solid #001F61;
	display: flex;
	flex-direction: column;
	justify-content: center;
	align-items: center;
	font-family: 'Muli';
	position: relative;
	height: 169px;
	width: 370px;
	max-width: calc(100% - 10px);
}

.social-panel button.close-btn {
	border: 0;
	color: #97A5CE;
	cursor: pointer;
	font-size: 20px;
	position: absolute;
	top: 5px;
	right: 5px;
}

.social-panel button");
                WriteLiteral(@".close-btn:focus {
	outline: none;
}

.social-panel p {
	background-color: #001F61;
	border-radius: 0 0 10px 10px;
	color: #fff;
	font-size: 14px;
	line-height: 18px;
	padding: 2px 17px 6px;
	position: absolute;
	top: 0;
	left: 50%;
	margin: 0;
	transform: translateX(-50%);
	text-align: center;
	width: 235px;
}

.social-panel p i {
	margin: 0 5px;
}

.social-panel p a {
	color: #FF7500;
	text-decoration: none;
}

.social-panel h4 {
	margin: 20px 0;
	color: #97A5CE;
	font-family: 'Muli';
	font-size: 14px;
	line-height: 18px;
	text-transform: uppercase;
}

.social-panel ul {
	display: flex;
	list-style-type: none;
	padding: 0;
	margin: 0;
}

.social-panel ul li {
	margin: 0 10px;
}

.social-panel ul li a {
	border: 1px solid #DCE1F2;
	border-radius: 50%;
	color: #001F61;
	font-size: 20px;
	display: flex;
	justify-content: center;
	align-items: center;
	height: 50px;
	width: 50px;
	text-decoration: none;
}

.social-panel ul li a:hover {
	border-color");
                WriteLiteral(@": #FF6A00;
	box-shadow: 0 9px 12px -9px #FF6A00;
}
        </style>
        <h1>Top 10 Billionaires in the World</h1>
        <table>
            <thead>
                <tr>
                    <th></th>
                    <th>Name</th>
                    <th>Net worth (USD)</th>
                    <th>Age</th>
                    <th>Nationality</th>
                    <th>Source(s) of wealth</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>
                        <img src=""https://upload.wikimedia.org/wikipedia/commons/thumb/6/6c/Jeff_Bezos_at_Amazon_Spheres_Grand_Opening_in_Seattle_-_2018_%2839074799225%29_%28cropped%29.jpg/220px-Jeff_Bezos_at_Amazon_Spheres_Grand_Opening_in_Seattle_-_2018_%2839074799225%29_%28cropped%29.jpg""");
                BeginWriteAttribute("alt", " alt=\"", 3994, "\"", 4000, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                    </td>
                    <td>Jeff Bezos</td>
                    <td>$131 billion</td>
                    <td>55</td>
                    <td>United States</td>
                    <td>Amazon</td>
                </tr>
                <tr>
                    <td>
                        <img src=""https://upload.wikimedia.org/wikipedia/commons/thumb/0/01/Bill_Gates_July_2014.jpg/220px-Bill_Gates_July_2014.jpg""");
                BeginWriteAttribute("alt", " alt=\"", 4448, "\"", 4454, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                    </td>
                    <td>Bill Gates</td>
                    <td>$96.5 billion</td>
                    <td>63</td>
                    <td>United States</td>
                    <td>Microsoft</td>
                </tr>
                <tr>
                    <td>
                        <img src=""https://upload.wikimedia.org/wikipedia/commons/thumb/5/51/Warren_Buffett_KU_Visit.jpg/220px-Warren_Buffett_KU_Visit.jpg""");
                BeginWriteAttribute("alt", " alt=\"", 4912, "\"", 4918, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                    </td>
                    <td>Warren Buffett</td>
                    <td>$82.5 billion</td>
                    <td>88</td>
                    <td>United States</td>
                    <td>Berkshire Hathaway</td>
                </tr>
                <tr>
                    <td>
                        <img src=""https://upload.wikimedia.org/wikipedia/commons/thumb/d/de/Bernard_Arnault_%283%29_-_2017_%28cropped%29.jpg/220px-Bernard_Arnault_%283%29_-_2017_%28cropped%29.jpg""");
                BeginWriteAttribute("alt", " alt=\"", 5431, "\"", 5437, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                    </td>
                    <td>Bernard Arnault</td>
                    <td>$76 billion</td>
                    <td>70</td>
                    <td>France</td>
                    <td>LVMH</td>
                </tr>
                <tr>
                    <td>
                        <img src=""https://upload.wikimedia.org/wikipedia/commons/thumb/f/f6/Carlos_Slim_2012.jpg/220px-Carlos_Slim_2012.jpg""");
                BeginWriteAttribute("alt", " alt=\"", 5872, "\"", 5878, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                    </td>
                    <td>Carlos Slim</td>
                    <td>$64 billion</td>
                    <td>79</td>
                    <td>Mexico</td>
                    <td>America Movil, Grupo Carso</td>
                </tr>
                <tr>
                    <td>
                        <img src=""https://media.businessinsider.com/images/5c8002432628984e74347f2d-1136-852.jpg""");
                BeginWriteAttribute("alt", " alt=\"", 6304, "\"", 6310, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                    </td>
                    <td>Amancio Ortega</td>
                    <td>$62.7 billion</td>
                    <td>82</td>
                    <td>Spain</td>
                    <td>Inditex, Zara</td>
                </tr>
                <tr>
                    <td>
                        <img src=""https://upload.wikimedia.org/wikipedia/commons/thumb/0/00/Larry_Ellison_picture.png/220px-Larry_Ellison_picture.png""");
                BeginWriteAttribute("alt", " alt=\"", 6764, "\"", 6770, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                    </td>
                    <td>Larry Ellison</td>
                    <td>$62.5 billion</td>
                    <td>75</td>
                    <td>United States</td>
                    <td>Oracle Corporation</td>
                </tr>
                <tr>
                    <td>
                        <img src=""https://upload.wikimedia.org/wikipedia/commons/thumb/1/14/Mark_Zuckerberg_F8_2018_Keynote_%28cropped_2%29.jpg/220px-Mark_Zuckerberg_F8_2018_Keynote_%28cropped_2%29.jpg""");
                BeginWriteAttribute("alt", " alt=\"", 7288, "\"", 7294, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                    </td>
                    <td>Mark Zuckerberg</td>
                    <td>$62.3 billion</td>
                    <td>34</td>
                    <td>United States</td>
                    <td>Facebook</td>
                </tr>
                <tr>
                    <td>
                        <img src=""https://upload.wikimedia.org/wikipedia/commons/thumb/1/1d/Michael_Bloomberg_%2836720142205%29.jpg/220px-Michael_Bloomberg_%2836720142205%29.jpg""");
                BeginWriteAttribute("alt", " alt=\"", 7780, "\"", 7786, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                    </td>
                    <td>Michael Bloomberg</td>
                    <td>$55.5 billion</td>
                    <td>77</td>
                    <td>United States</td>
                    <td>Bloomberg L.P.</td>
                </tr>
                <tr>
                    <td>
                        <img src=""https://upload.wikimedia.org/wikipedia/commons/thumb/e/ec/Larry_Page_in_the_European_Parliament%2C_17.06.2009_%28cropped%29.jpg/220px-Larry_Page_in_the_European_Parliament%2C_17.06.2009_%28cropped%29.jpg""");
                BeginWriteAttribute("alt", " alt=\"", 8340, "\"", 8346, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                    </td>
                    <td>Larry Page</td>
                    <td>$50.8 billion</td>
                    <td>45</td>
                    <td>United States</td>
                    <td>Alphabet Inc.</td>
                </tr>
            </tbody>
        </table>


        
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
            WriteLiteral("\r\n\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_html_Task7> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_html_Task7> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_html_Task7>)PageContext?.ViewData;
        public Pages_html_Task7 Model => ViewData.Model;
    }
}
#pragma warning restore 1591
