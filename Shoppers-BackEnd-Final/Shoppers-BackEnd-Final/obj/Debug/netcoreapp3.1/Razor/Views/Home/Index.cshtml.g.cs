#pragma checksum "C:\Users\sfarh\Desktop\Shoppers-BackEnd-Final\Shoppers-BackEnd-Final\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9dc9733da1092464217c104200da3478f19a425"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9dc9733da1092464217c104200da3478f19a425", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62053d88b14f909c0512b8e58fbdbaafa14708bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "shopdetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "shop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\sfarh\Desktop\Shoppers-BackEnd-Final\Shoppers-BackEnd-Final\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<main>\r\n    <section class=\"hero\">\r\n        <div class=\"row\">\r\n            <div class=\" heroImg col-lg-12 d-flex\">\r\n\r\n                <div class=\"col-lg-7 \">\r\n\r\n                </div>\r\n\r\n");
#nullable restore
#line 16 "C:\Users\sfarh\Desktop\Shoppers-BackEnd-Final\Shoppers-BackEnd-Final\Views\Home\Index.cshtml"
                 foreach (var item in Model.Heroes)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"heroText col-lg-4  d-flex flex-column justify-content-center \">\r\n                        <h1>\r\n                            ");
#nullable restore
#line 20 "C:\Users\sfarh\Desktop\Shoppers-BackEnd-Final\Shoppers-BackEnd-Final\Views\Home\Index.cshtml"
                       Write(item.Title1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br>\r\n                            ");
#nullable restore
#line 21 "C:\Users\sfarh\Desktop\Shoppers-BackEnd-Final\Shoppers-BackEnd-Final\Views\Home\Index.cshtml"
                       Write(item.Title2);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </h1>\r\n                        <p>");
#nullable restore
#line 23 "C:\Users\sfarh\Desktop\Shoppers-BackEnd-Final\Shoppers-BackEnd-Final\Views\Home\Index.cshtml"
                      Write(item.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <button type=\"button\" class=\"heroBtn\">Shop Now</button>\r\n\r\n                    </div>\r\n");
#nullable restore
#line 27 "C:\Users\sfarh\Desktop\Shoppers-BackEnd-Final\Shoppers-BackEnd-Final\Views\Home\Index.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n            </div>\r\n\r\n        </div>\r\n    </section>\r\n\r\n    <section class=\"service\">\r\n        <div class=\"container\">\r\n            <div class=\"row\">\r\n");
#nullable restore
#line 40 "C:\Users\sfarh\Desktop\Shoppers-BackEnd-Final\Shoppers-BackEnd-Final\Views\Home\Index.cshtml"
                 foreach (var item in Model.Services)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"serviceCard col-lg-4 mt-3 d-flex justify-content-center\">\r\n                        <div class=\"serviceIcon\">\r\n                            ");
#nullable restore
#line 44 "C:\Users\sfarh\Desktop\Shoppers-BackEnd-Final\Shoppers-BackEnd-Final\Views\Home\Index.cshtml"
                       Write(Html.Raw(item.Icon));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n\r\n                        <div class=\"serviceText\">\r\n                            <h6>");
#nullable restore
#line 48 "C:\Users\sfarh\Desktop\Shoppers-BackEnd-Final\Shoppers-BackEnd-Final\Views\Home\Index.cshtml"
                           Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                            <p>");
#nullable restore
#line 49 "C:\Users\sfarh\Desktop\Shoppers-BackEnd-Final\Shoppers-BackEnd-Final\Views\Home\Index.cshtml"
                          Write(item.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 52 "C:\Users\sfarh\Desktop\Shoppers-BackEnd-Final\Shoppers-BackEnd-Final\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </section>
    <hr>
    <section class=""categories"">
        <div class=""container"">
            <div class=""row"">

                <div class=""categoriesCard col-lg-4 d-flex justify-content-center  mt-3"">
                    <div class=""catalogueImg"">
                        <img src=""./img/cataloge3.jpg"">
                    </div>
                    <div class=""catalogueText"">
                        <h6>Collections</h6>
                        <h2>Women</h2>
                    </div>
                </div>

                <div class=""categoriesCard col-lg-4 d-flex justify-content-center  mt-3"">
                    <div class=""catalogueImg"">
                        <img src=""./img/cataloge2.jpg"">
                    </div>
                    <div class=""catalogueText"">
                        <h6>Collections</h6>
                        <h2>Children</h2>
                    </div>
                </div>

                <div class=""categ");
            WriteLiteral(@"oriesCard col-lg-4 d-flex justify-content-center  mt-3"">
                    <div class=""catalogueImg"">
                        <img src=""./img/cataloge1.jpg"">
                    </div>
                    <div class=""catalogueText"">
                        <h6>Collections</h6>
                        <h2>Men</h2>
                    </div>
                </div>


            </div>
        </div>
    </section>

    <section class=""featured"">
        <div class=""container"">

            <div class=""row"">
                <div class=""featuredText col-lg-12"">
                    <h3 class=""text-center"">New Products</h3>
                </div>
            </div>
            <div class=""row  d-flex justify-content-center"">
                <div class=""owl-carousel owl-theme  mt-5"">

");
#nullable restore
#line 107 "C:\Users\sfarh\Desktop\Shoppers-BackEnd-Final\Shoppers-BackEnd-Final\Views\Home\Index.cshtml"
                     foreach (var Product in Model.Products)
                    {
                        if (Product.IsNew == true && Product.IsDeleted == false)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""item d-flex justify-content-center"">
                                <div class=""col-lg-4 d-flex justify-content-center"" style=""width: 22rem;"">
                                    <div class=""card"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9dc9733da1092464217c104200da3478f19a42511388", async() => {
                WriteLiteral("\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d9dc9733da1092464217c104200da3478f19a42511688", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 3885, "~/uploads/product/", 3885, 18, true);
#nullable restore
#line 115 "C:\Users\sfarh\Desktop\Shoppers-BackEnd-Final\Shoppers-BackEnd-Final\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 3903, Product.ProductImages.FirstOrDefault(x=>x.IsPoster==true)?.Image, 3903, 65, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 114 "C:\Users\sfarh\Desktop\Shoppers-BackEnd-Final\Shoppers-BackEnd-Final\Views\Home\Index.cshtml"
                                                                                           WriteLiteral(Product.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                                        <div class=\"card-body text-center\">\r\n                                            <h5 class=\"card-title\">");
#nullable restore
#line 119 "C:\Users\sfarh\Desktop\Shoppers-BackEnd-Final\Shoppers-BackEnd-Final\Views\Home\Index.cshtml"
                                                              Write(Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                            <p class=\"card-text\">");
#nullable restore
#line 120 "C:\Users\sfarh\Desktop\Shoppers-BackEnd-Final\Shoppers-BackEnd-Final\Views\Home\Index.cshtml"
                                                            Write(Product.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                            <h5 class=\"card-title\">");
#nullable restore
#line 121 "C:\Users\sfarh\Desktop\Shoppers-BackEnd-Final\Shoppers-BackEnd-Final\Views\Home\Index.cshtml"
                                                               Write(Product.SalePrice.ToString("#.##"));

#line default
#line hidden
#nullable disable
            WriteLiteral("₼</h5>\r\n                                        </div>\r\n                                    </div>\r\n\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 127 "C:\Users\sfarh\Desktop\Shoppers-BackEnd-Final\Shoppers-BackEnd-Final\Views\Home\Index.cshtml"

                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
            </div>
        </div>
    </section>

    <section class=""bigSale"">
        <div class=""container"">
            <div class=""row"">
                <div class=""bigSaleText col-lg-12"">
                    <h3 class=""text-center"">Big Sale!</h3>
                </div>
            </div>
            <div class=""row mt-5"">
                <div class=""col-lg-6"">
                    <div class=""bigSaleImg d-flex justify-content-end "">
                        <img src=""./img/sale.jpg"" class=""img-fluid"">
                    </div>
                </div>

                <div class=""col-lg-6 mt-5"">
                    <div class=""bigSaleText d-flex flex-column justify-content-center align-items-center mt-5"">
                        <h3>50% less in all items</h3>
                        <p class=""postMade"">By <a href=""#""> Carl Smith </a> • September 3, 2018</p>
                        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Quisquam iste dolo");
            WriteLiteral(@"r accusantium facere corporis ipsum animi deleniti fugiat. Ex, veniam?</p>
                        <button type=""button"" class=""heroBtn"">Shop Now</button>
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
