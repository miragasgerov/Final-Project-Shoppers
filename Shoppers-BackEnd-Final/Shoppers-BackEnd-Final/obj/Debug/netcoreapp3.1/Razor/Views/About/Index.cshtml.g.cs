#pragma checksum "C:\Users\sfarh\Desktop\Shoppers-BackEnd-Final\Shoppers-BackEnd-Final\Views\About\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ddf675c0c18e1b24539dc00367d2ff8b6737cb05"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_About_Index), @"mvc.1.0.view", @"/Views/About/Index.cshtml")]
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
#line 1 "C:\Users\sfarh\Desktop\Shoppers-BackEnd-Final\Shoppers-BackEnd-Final\Views\_ViewImports.cshtml"
using Shoppers_BackEnd_Final;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sfarh\Desktop\Shoppers-BackEnd-Final\Shoppers-BackEnd-Final\Views\_ViewImports.cshtml"
using Shoppers_BackEnd_Final.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\sfarh\Desktop\Shoppers-BackEnd-Final\Shoppers-BackEnd-Final\Views\_ViewImports.cshtml"
using Shoppers_BackEnd_Final.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ddf675c0c18e1b24539dc00367d2ff8b6737cb05", @"/Views/About/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62053d88b14f909c0512b8e58fbdbaafa14708bf", @"/Views/_ViewImports.cshtml")]
    public class Views_About_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\sfarh\Desktop\Shoppers-BackEnd-Final\Shoppers-BackEnd-Final\Views\About\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main>
    <section class=""breadCrumb"">
        <div class=""container"">
            <div class=""row"">
                <nav aria-label=""breadcrumb"">
                    <ol class=""breadcrumb mt-3"">
                        <li class=""breadcrumb-item active""><a href=""#"">Home</a></li>
                        <li class=""breadcrumb-item"" aria-current=""page"">About</li>
                    </ol>
                </nav>
            </div>
        </div>
    </section>

    <section class=""weStarter"">
        <div class=""container"">
            <div class=""row mt-5"">
                <div class=""col-lg-6"">
                    <div class=""weStarterImg d-flex justify-content-end "">
                        <img src=""./img/sale.jpg"" class=""img-fluid"">
                    </div>
                </div>

                <div class=""col-lg-6  mt-lg-5"">
                    <div class=""weStarterText"">
                        <h3>How We Started</h3>
                        <p class=""mt-4"">Lorem ipsum dol");
            WriteLiteral(@"or sit amet, consectetur adipisicing elit. Eius repellat, dicta at laboriosam, nemo exercitationem itaque eveniet architecto cumque, deleniti commodi molestias repellendus quos sequi hic fugiat asperiores illum. Atque, in, fuga excepturi corrupti error corporis aliquam unde nostrum quas.</p>
                        <p class=""mt-3"">Accusantium dolor ratione maiores est deleniti nihil? Dignissimos est, sunt nulla illum autem in, quibusdam cumque recusandae, laudantium minima repellendus.</p>
                    </div>
                </div>

            </div>
        </div>
    </section>

    <hr>

    <section class=""team"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-12 text-center"">
                    <h3>The Team</h3>
                </div>
            </div>
            <div class=""row mt-5"">

");
#nullable restore
#line 52 "C:\Users\sfarh\Desktop\Shoppers-BackEnd-Final\Shoppers-BackEnd-Final\Views\About\Index.cshtml"
                 foreach (var item in Model.Teams)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"teamCard mt-5 col-lg-3\">\r\n                        <div class=\"teamImg\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ddf675c0c18e1b24539dc00367d2ff8b6737cb056000", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2185, "~/uploads/teams/", 2185, 16, true);
#nullable restore
#line 56 "C:\Users\sfarh\Desktop\Shoppers-BackEnd-Final\Shoppers-BackEnd-Final\Views\About\Index.cshtml"
AddHtmlAttributeValue("", 2201, item.Image, 2201, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"teamText text-center\">\r\n                            <h5 class=\"mt-3\">");
#nullable restore
#line 59 "C:\Users\sfarh\Desktop\Shoppers-BackEnd-Final\Shoppers-BackEnd-Final\Views\About\Index.cshtml"
                                        Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            <h6>");
#nullable restore
#line 60 "C:\Users\sfarh\Desktop\Shoppers-BackEnd-Final\Shoppers-BackEnd-Final\Views\About\Index.cshtml"
                           Write(item.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                            <p>");
#nullable restore
#line 61 "C:\Users\sfarh\Desktop\Shoppers-BackEnd-Final\Shoppers-BackEnd-Final\Views\About\Index.cshtml"
                          Write(item.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 64 "C:\Users\sfarh\Desktop\Shoppers-BackEnd-Final\Shoppers-BackEnd-Final\Views\About\Index.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
        </div>
    </section>

    <hr>

    <section class=""service"">
        <div class=""container"">
            <div class=""row"">
                <div class=""serviceCard col-lg-4 mt-3 d-flex justify-content-center"">
                    <div class=""serviceIcon"">
                        <i class=""fa-solid fa-truck firstIcon""></i>
                    </div>

                    <div class=""serviceText"">
                        <h6>Free Shipping</h6>
                        <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus at iaculis quam. Integer accumsan tincidunt fringilla.</p>
                    </div>
                </div>

                <div class=""serviceCard  col-lg-4 mt-3 d-flex justify-content-center"">
                    <div class=""serviceIcon"">
                        <i class=""fa-solid fa-rotate-right""></i>
                    </div>

                    <div class=""serviceText"">
                        <h6>Free Returns</h6>
");
            WriteLiteral(@"                        <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus at iaculis quam. Integer accumsan tincidunt fringilla.</p>
                    </div>
                </div>


                <div class=""serviceCard  col-lg-4 mt-3 d-flex justify-content-center"">
                    <div class=""serviceIcon"">
                        <i class=""fa-solid fa-circle-question""></i>
                    </div>

                    <div class=""serviceText"">
                        <h6>Customer Support</h6>
                        <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus at iaculis quam. Integer accumsan tincidunt fringilla.</p>
                    </div>
                </div>
            </div>
        </div>
    </section>

    <hr>

</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
