#pragma checksum "C:\Users\sfarh\Desktop\Shoppers-BackEnd-Final\Shoppers-BackEnd-Final\Views\Order\checkout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5dc43b25ff44a78156214e03fbba4b91b6f87f27"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_checkout), @"mvc.1.0.view", @"/Views/Order/checkout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5dc43b25ff44a78156214e03fbba4b91b6f87f27", @"/Views/Order/checkout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62053d88b14f909c0512b8e58fbdbaafa14708bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_checkout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("row g-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-flex"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "finish", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\sfarh\Desktop\Shoppers-BackEnd-Final\Shoppers-BackEnd-Final\Views\Order\checkout.cshtml"
  
    ViewData["Title"] = "checkout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 7 "C:\Users\sfarh\Desktop\Shoppers-BackEnd-Final\Shoppers-BackEnd-Final\Views\Order\checkout.cshtml"
  
    ViewData["Title"] = "checkout";

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
                        <li class=""breadcrumb-item active""><a href=""#"">Cart</a></li>
                        <li class=""breadcrumb-item"" aria-current=""page"">Checkout</li>
                    </ol>
                </nav>
            </div>
        </div>
    </section>

    <section class=""checkoutLogin"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-12 border p-3"">
                    <div class=""checkLogin"">
                        <p class=""pt-3"">Returning customer? <a href=""login.html"">Click here</a> to login</p>
                    </div>
                </div>
            </div>

        </div>
    </section>


    <section class=""checkoutForm"">
");
            WriteLiteral("        <div class=\"container\">\r\n            <div class=\"row\">\r\n                <div class=\"checkoutSec col-lg-12 d-flex\">\r\n                    <div class=\"col-lg-6 border p-4\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5dc43b25ff44a78156214e03fbba4b91b6f87f276898", async() => {
                WriteLiteral(@"
                            <div class=""col-md-12"">
                                <label for=""inputState"" class=""form-label"">Country</label>
                                <select id=""inputState"" class=""form-select"">
                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5dc43b25ff44a78156214e03fbba4b91b6f87f277424", async() => {
                    WriteLiteral("Azerbaijan");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5dc43b25ff44a78156214e03fbba4b91b6f87f278801", async() => {
                    WriteLiteral("Turkey");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5dc43b25ff44a78156214e03fbba4b91b6f87f279851", async() => {
                    WriteLiteral("Russian");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5dc43b25ff44a78156214e03fbba4b91b6f87f2710902", async() => {
                    WriteLiteral("England");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5dc43b25ff44a78156214e03fbba4b91b6f87f2711954", async() => {
                    WriteLiteral("France");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                </select>
                            </div>
                            <div class=""col-md-6"">
                                <label for=""inputFirstName"" class=""form-label"">First Name</label>
                                <input type=""text"" class=""form-control"" id=""inputFirstName"" aria-label=""First name"">
                            </div>
                            <div class=""col-md-6"">
                                <label for=""inputLastName"" class=""form-label"">Last Name</label>
                                <input type=""text"" class=""form-control"" id=""inputLastName"" aria-label=""Last name"">
                            </div>

                            <div class=""col-md-12"">
                                <label for=""inputCompanyName"" class=""form-label"">Company Name</label>
                                <input type=""text"" class=""form-control"" id=""inputCompanyName"" aria-label=""Company name"">
                            </div>


                 ");
                WriteLiteral(@"           <div class=""col-12"">
                                <label for=""inputAddress"" class=""form-label"">Address</label>
                                <input type=""text"" class=""form-control"" id=""inputAddress"" placeholder=""1234 Main St"">
                            </div>
                            <div class=""col-12"">
                                <label for=""inputAddress2"" class=""form-label"">Address 2</label>
                                <input type=""text"" class=""form-control"" id=""inputAddress2"" placeholder=""Apartment, studio, or floor"">
                            </div>

                            <div class=""col-md-6"">
                                <label for=""inputState"" class=""form-label"">State / Country</label>
                                <input type=""text"" class=""form-control"" id=""inputState"" aria-label=""First name"">
                            </div>
                            <div class=""col-md-6"">
                                <label for=""inputPosta"" class=""form-");
                WriteLiteral(@"label"">Posta / Zip</label>
                                <input type=""text"" class=""form-control"" id=""inputPosta"" aria-label=""Last name"">
                            </div>


                            <div class=""col-md-6"">
                                <label for=""inputEmail4"" class=""form-label"">Email</label>
                                <input type=""email"" class=""form-control"" id=""inputEmail4"">
                            </div>

                            <div class=""col-md-6"">
                                <label for=""inputNumber"" class=""form-label"">Phone</label>
                                <input type=""number"" class=""form-control"" id=""inputNumber"">
                            </div>



                            <div class=""col-12"">
                                <div class=""form-check"">
                                    <input class=""form-check-input"" type=""checkbox"" id=""gridCheck"">
                                    <label class=""form-check-label"" for=""gridCheck""");
                WriteLiteral(@">
                                        Create an account?
                                    </label>
                                </div>

                                <div class=""form-check mt-4"">
                                    <input class=""form-check-input"" type=""checkbox"" id=""gridCheck"">
                                    <label class=""form-check-label"" for=""gridCheck"">
                                        Ship To A Different Address?
                                    </label>
                                </div>
                            </div>

                            <div class=""col-12 mt-5"">
                                <label for=""inputAddress"" class=""form-label"">Order Notes</label>
                                <textarea class=""form-control"" placeholder=""Leave a comment here"" id=""floatingTextarea2"" style=""height: 100px""></textarea>
                            </div>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>


                    <div class=""checkoutOrderSec col-lg-6 ps-5"">
                        <div class=""col-lg-12 border p-5"">
                            <p>Enter your coupon code if you have one</p>
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5dc43b25ff44a78156214e03fbba4b91b6f87f2718592", async() => {
                WriteLiteral(@"
                                <div class=""col-md-5"">
                                    <input type=""text"" class=""form-control"" id=""inputCouponName"" aria-label=""First name"">
                                </div>

                                <button type=""button"" class=""heroBtn"">Apply</button>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>

                        <div class=""yourOrderSec row mt-5 ps-3"">
                            <h4>Your Order</h4>

                            <div class=""orderTable col-lg-12 border p-5"">
                                <table class=""table"">
                                    <thead>
                                    <th>Product</th>
                                    <th>Total</th>
                                    </thead>
                                    <tbody>
                                        <tr>

                                            <td data-label=""Product"">Top Up T-Shirt x 1	</td>
                                            <td data-label=""Price"">$250.00</td>
                                        </tr>

                                        <tr>

                                            <td data-label=""Product"">Polo Shirt x 1		</td>
                                            <td data-label=""Price"">$100.00</td>
     ");
            WriteLiteral(@"                                   </tr>

                                        <tr>

                                            <td data-label=""Product"" style=""font-weight: bold;"">Cart Subtotal	</td>
                                            <td data-label=""Price"">	$350.00</td>
                                        </tr>

                                        <tr>

                                            <td data-label=""Product"" style=""font-weight: bold;"">Order Total </td>
                                            <td data-label=""Price"" style=""font-weight: bold;"">	$350.00</td>
                                        </tr>




                                    </tbody>
                                </table>

                                <div class=""row mt-5 ms-auto"">
                                    <div class=""col-lg-12"">
                                        <div class=""orderBank border p-3"">
                                            <a href=""#"">
        ");
            WriteLiteral(@"                                        <h6>Direct Bank Transfer</h6>
                                            </a>
                                        </div>

                                        <div class=""orderBank border p-3 mt-3"">
                                            <a href=""#"">
                                                <h6>Cheque Payment</h6>
                                            </a>
                                        </div>

                                        <div class=""orderBank border p-3 mt-3"">
                                            <a href=""#"">
                                                <h6>Paypal</h6>
                                            </a>
                                        </div>
                                    </div>
                                </div>

                                <div class=""row ps-4 mt-5"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5dc43b25ff44a78156214e03fbba4b91b6f87f2723378", async() => {
                WriteLiteral("\r\n                                        <button type=\"button\" class=\"heroBtn\">Place Order</button>\r\n\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n\r\n\r\n                        </div>\r\n\r\n\r\n\r\n                    </div>\r\n\r\n\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n    </section>\r\n\r\n</main>\r\n\r\n");
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
