#pragma checksum "C:\Users\sfarh\Desktop\Shoppers-BackEnd-Final\Shoppers-BackEnd-Final\Views\Shop\shopdetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b28f40542bb791eb52d34e05bb3d1e3824da13d8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_shopdetail), @"mvc.1.0.view", @"/Views/Shop/shopdetail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b28f40542bb791eb52d34e05bb3d1e3824da13d8", @"/Views/Shop/shopdetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62053d88b14f909c0512b8e58fbdbaafa14708bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_shopdetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShopViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "shopdetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "shop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/profile.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("feedback-input"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Name"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Email"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mt-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "comment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<main>
    <section class=""breadCrumb"">
        <div class=""container"">
            <div class=""row"">
                <nav aria-label=""breadcrumb"">
                    <ol class=""breadcrumb mt-3"">
                        <li class=""breadcrumb-item active""><a href=""#"">Home</a></li>
                        <li class=""breadcrumb-item"" aria-current=""page"">Tank Top T-Shirt</li>
                    </ol>
                </nav>
            </div>
        </div>
    </section>


    <section class=""detail"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-5 "">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b28f40542bb791eb52d34e05bb3d1e3824da13d89233", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 686, "~/uploads/product/", 686, 18, true);
#nullable restore
#line 23 "C:\Users\sfarh\Desktop\Shoppers-BackEnd-Final\Shoppers-BackEnd-Final\Views\Shop\shopdetail.cshtml"
AddHtmlAttributeValue("", 704, Model.Product.ProductImages.FirstOrDefault(x => x.IsPoster == false)?.Image, 704, 76, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n\r\n                <div class=\"detailText col-lg-7\">\r\n\r\n                        <h1>");
#nullable restore
#line 28 "C:\Users\sfarh\Desktop\Shoppers-BackEnd-Final\Shoppers-BackEnd-Final\Views\Shop\shopdetail.cshtml"
                       Write(Model.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
                        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Pariatur, vitae, explicabo? Incidunt facere, natus soluta dolores iusto! Molestiae expedita veritatis nesciunt doloremque sint asperiores fuga voluptas, distinctio, aperiam, ratione dolore.</p>
                        <p>Ex numquam veritatis debitis minima quo error quam eos dolorum quidem perferendis. Quos repellat dignissimos minus, eveniet nam voluptatibus molestias omnis reiciendis perspiciatis illum hic magni iste, velit aperiam quis.</p>
                        <h4>");
#nullable restore
#line 31 "C:\Users\sfarh\Desktop\Shoppers-BackEnd-Final\Shoppers-BackEnd-Final\Views\Shop\shopdetail.cshtml"
                        Write(Model.Product.SalePrice.ToString("#.##"));

#line default
#line hidden
#nullable disable
            WriteLiteral("₼</h4>\r\n                    <div class=\"detailInput mt-4\">\r\n                        <span class=\"me-4\"> <input class=\"form-check-input detailCheck\" type=\"checkbox\"");
            BeginWriteAttribute("value", " value=\"", 1704, "\"", 1712, 0);
            EndWriteAttribute();
            WriteLiteral(" id=\"flexCheckDefault\">Small</span>\r\n                        <span class=\"me-4\"> <input class=\"form-check-input detailCheck\" type=\"checkbox\"");
            BeginWriteAttribute("value", " value=\"", 1853, "\"", 1861, 0);
            EndWriteAttribute();
            WriteLiteral(" id=\"flexCheckDefault\">Medium</span>\r\n                        <span class=\"me-4\"> <input class=\"form-check-input detailCheck\" type=\"checkbox\"");
            BeginWriteAttribute("value", " value=\"", 2003, "\"", 2011, 0);
            EndWriteAttribute();
            WriteLiteral(" id=\"flexCheckDefault\">Large</span>\r\n                        <span class=\"me-4\"> <input class=\"form-check-input detailCheck\" type=\"checkbox\"");
            BeginWriteAttribute("value", " value=\"", 2152, "\"", 2160, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""flexCheckDefault"">Extra Large</span>

                    </div>

                    <div class=""number"">
                        <span class=""minus"">-</span>
                        <input type=""text"" value=""1"" />
                        <span class=""plus"">+</span>
                    </div>


                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b28f40542bb791eb52d34e05bb3d1e3824da13d813658", async() => {
                WriteLiteral("\r\n                        <button type=\"button\" class=\"heroBtn\" style=\"width:10rem;\">Add To Cart</button>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"


                </div>
            </div>
        </div>
    </section>

    <section class=""featured"">
        <div class=""container"">

            <div class=""row"">
                <div class=""featuredText col-lg-12"">
                    <h3 class=""text-center"">Featured Products</h3>
                </div>
            </div>
            <div class=""row  d-flex justify-content-center"">
                <div class=""owl-carousel owl-theme  mt-5"">
");
#nullable restore
#line 67 "C:\Users\sfarh\Desktop\Shoppers-BackEnd-Final\Shoppers-BackEnd-Final\Views\Shop\shopdetail.cshtml"
                     foreach (var Product in Model.NewProducts)
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b28f40542bb791eb52d34e05bb3d1e3824da13d816330", async() => {
                WriteLiteral("\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b28f40542bb791eb52d34e05bb3d1e3824da13d816630", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 3750, "~/uploads/product/", 3750, 18, true);
#nullable restore
#line 75 "C:\Users\sfarh\Desktop\Shoppers-BackEnd-Final\Shoppers-BackEnd-Final\Views\Shop\shopdetail.cshtml"
AddHtmlAttributeValue("", 3768, Product.ProductImages.FirstOrDefault(x=>x.IsPoster==true)?.Image, 3768, 65, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 74 "C:\Users\sfarh\Desktop\Shoppers-BackEnd-Final\Shoppers-BackEnd-Final\Views\Shop\shopdetail.cshtml"
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
#line 79 "C:\Users\sfarh\Desktop\Shoppers-BackEnd-Final\Shoppers-BackEnd-Final\Views\Shop\shopdetail.cshtml"
                                                              Write(Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                            <p class=\"card-text\">");
#nullable restore
#line 80 "C:\Users\sfarh\Desktop\Shoppers-BackEnd-Final\Shoppers-BackEnd-Final\Views\Shop\shopdetail.cshtml"
                                                            Write(Product.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                            <h5 class=\"card-title\">");
#nullable restore
#line 81 "C:\Users\sfarh\Desktop\Shoppers-BackEnd-Final\Shoppers-BackEnd-Final\Views\Shop\shopdetail.cshtml"
                                                               Write(Product.SalePrice.ToString("#.##"));

#line default
#line hidden
#nullable disable
            WriteLiteral("₼</h5>\r\n                                        </div>\r\n                                    </div>\r\n\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 87 "C:\Users\sfarh\Desktop\Shoppers-BackEnd-Final\Shoppers-BackEnd-Final\Views\Shop\shopdetail.cshtml"

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

    <section class=""detailComment"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-12"">
                    <h3>3 Comments</h3>

                    <div class=""row"">
                        <div class=""col-lg-6"">
");
#nullable restore
#line 105 "C:\Users\sfarh\Desktop\Shoppers-BackEnd-Final\Shoppers-BackEnd-Final\Views\Shop\shopdetail.cshtml"
                             foreach (var item in Model.Product.ProductComments.Where(x => x.Status))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"commentSec d-flex\">\r\n                                    <div class=\"profileImgDetail mt-5\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b28f40542bb791eb52d34e05bb3d1e3824da13d823203", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </div>\r\n                                    <div class=\"commentText mt-5 ms-3\">\r\n                                        <h5>");
#nullable restore
#line 112 "C:\Users\sfarh\Desktop\Shoppers-BackEnd-Final\Shoppers-BackEnd-Final\Views\Shop\shopdetail.cshtml"
                                       Write(item.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n\r\n                                        <h6>");
#nullable restore
#line 114 "C:\Users\sfarh\Desktop\Shoppers-BackEnd-Final\Shoppers-BackEnd-Final\Views\Shop\shopdetail.cshtml"
                                       Write(item.CreatedAt.ToString("MMMM dd, yyyy HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                        <p>");
#nullable restore
#line 115 "C:\Users\sfarh\Desktop\Shoppers-BackEnd-Final\Shoppers-BackEnd-Final\Views\Shop\shopdetail.cshtml"
                                      Write(item.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 118 "C:\Users\sfarh\Desktop\Shoppers-BackEnd-Final\Shoppers-BackEnd-Final\Views\Shop\shopdetail.cshtml"

                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


                        </div>
                        <div class=""col-lg-6""></div>
                    </div>

                    <div class=""row mt-5"">
                        <div class=""leaveComment col-lg-6"">  
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b28f40542bb791eb52d34e05bb3d1e3824da13d825962", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 130 "C:\Users\sfarh\Desktop\Shoppers-BackEnd-Final\Shoppers-BackEnd-Final\Views\Shop\shopdetail.cshtml"
                                 if (User.Identity.IsAuthenticated)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b28f40542bb791eb52d34e05bb3d1e3824da13d826576", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 132 "C:\Users\sfarh\Desktop\Shoppers-BackEnd-Final\Shoppers-BackEnd-Final\Views\Shop\shopdetail.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.ProductComment.AppUser.Fullname);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b28f40542bb791eb52d34e05bb3d1e3824da13d828314", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 133 "C:\Users\sfarh\Desktop\Shoppers-BackEnd-Final\Shoppers-BackEnd-Final\Views\Shop\shopdetail.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.ProductComment.AppUser.Email);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                    <textarea name=""text"" class=""feedback-input"" placeholder=""Comment""></textarea>
                                    <button type=""submit"" class=""btn btn-black"">Post Comment</button>
                                    <input type=""hidden"" name=""productId""");
                BeginWriteAttribute("value", " value=\"", 6637, "\"", 6662, 1);
#nullable restore
#line 136 "C:\Users\sfarh\Desktop\Shoppers-BackEnd-Final\Shoppers-BackEnd-Final\Views\Shop\shopdetail.cshtml"
WriteAttributeValue("", 6645, Model.Product.Id, 6645, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
#nullable restore
#line 137 "C:\Users\sfarh\Desktop\Shoppers-BackEnd-Final\Shoppers-BackEnd-Final\Views\Shop\shopdetail.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                    <input name=""fullname"" class=""feedback-input"" placeholder=""Name"" />
                                    <input name=""email"" class=""feedback-input"" placeholder=""Email"" />
                                    <textarea name=""text"" class=""feedback-input"" placeholder=""Comment""></textarea>
                                    <button type=""submit"" class=""btn btn-black"">Post Comment</button>
                                    <input type=""hidden"" name=""productId""");
                BeginWriteAttribute("value", " value=\"", 7276, "\"", 7301, 1);
#nullable restore
#line 144 "C:\Users\sfarh\Desktop\Shoppers-BackEnd-Final\Shoppers-BackEnd-Final\Views\Shop\shopdetail.cshtml"
WriteAttributeValue("", 7284, Model.Product.Id, 7284, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
#nullable restore
#line 145 "C:\Users\sfarh\Desktop\Shoppers-BackEnd-Final\Shoppers-BackEnd-Final\Views\Shop\shopdetail.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_12.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_13.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_13);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                        </div>\r\n                        <div class=\"col-lg-6\"></div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n\r\n\r\n\r\n\r\n</main>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShopViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
