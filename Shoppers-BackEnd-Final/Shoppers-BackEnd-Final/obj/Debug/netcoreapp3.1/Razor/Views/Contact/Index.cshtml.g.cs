#pragma checksum "C:\Users\sfarh\Desktop\Shoppers-BackEnd-Final\Shoppers-BackEnd-Final\Views\Contact\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ef18917de8df208761e13608020ac65db9ce411"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Index), @"mvc.1.0.view", @"/Views/Contact/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ef18917de8df208761e13608020ac65db9ce411", @"/Views/Contact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62053d88b14f909c0512b8e58fbdbaafa14708bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<main>
    <section class=""breadCrumb"">
        <div class=""container"">
            <div class=""row"">
                <nav aria-label=""breadcrumb"">
                    <ol class=""breadcrumb mt-3"">
                        <li class=""breadcrumb-item active""><a href=""#"">Home</a></li>
                        <li class=""breadcrumb-item"" aria-current=""page"">Contact</li>
                    </ol>
                </nav>
            </div>
        </div>
    </section>

    <section class=""contact"">
        <div class=""container"">
            <div class=""row"">
                <h3>Get In Touch</h3>
                <div class=""col-lg-6 border p-4"">
                    <div class=""contactForm"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ef18917de8df208761e13608020ac65db9ce4114273", async() => {
                WriteLiteral(@"
                            <div class=""contactName d-flex"">
                                <div class=""mb-3"">
                                    <label for=""exampleInputName1"" class=""form-label"">First Name</label>
                                    <input type=""text"" class=""form-control"" id=""exampleInputName1"" aria-describedby=""nameHelp"">
                                </div>

                                <div class=""mb-3 ms-auto"">
                                    <label for=""exampleInputLastName1"" class=""form-label"">Last Name</label>
                                    <input type=""text"" class=""form-control"" id=""exampleInputLastName1"" aria-describedby=""LastNameHelp"">
                                </div>
                            </div>

                            <div class=""mb-3"">
                                <label for=""exampleInputEmail1"" class=""form-label"">Email address</label>
                                <input type=""email"" class=""form-control"" id=""exampleInputEmai");
                WriteLiteral(@"l1"" aria-describedby=""emailHelp"">
                            </div>

                            <div class=""mb-3"">
                                <label for=""exampleInputSubject1"" class=""form-label"">Subject</label>
                                <input type=""text"" class=""form-control"" id=""exampleInputSubject1"" aria-describedby=""subjectHelp"">
                            </div>

                            <div class=""form-floating"">
                                <label for=""floatingTextarea"" class=""form-label"">Message</label>
                                <textarea class=""form-control"" placeholder=""Leave a comment here"" id=""floatingTextarea""></textarea>
                            </div>
                            <button type=""button"" class=""contactBtn heroBtn mt-5"" style=""width: 100%;"">Send</button>


                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
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

                <div class=""contactSecond col-lg-5 mt-lg-0 mt-5 ms-lg-5 ms-0"">
                    <div class=""contactCard border p-4"">
                        <h6 class=""mt-2"">New York</h6>
                        <p class=""mt-2"">203 Fake St. Mountain View, San Francisco, California, USA</p>

                    </div>

                    <div class=""contactCard border p-4 mt-4"">
                        <h6 class=""mt-2"">London</h6>
                        <p class=""mt-2"">203 Fake St. Mountain View, San Francisco, California, USA</p>

                    </div>

                    <div class=""contactCard border p-4 mt-4"">
                        <h6 class=""mt-2"">Canada</h6>
                        <p class=""mt-2"">203 Fake St. Mountain View, San Francisco, California, USA</p>

                    </div>
                </div>

                <div class=""col-lg-1""></div>

            </div>
        </div>

    </section>

</ma");
            WriteLiteral("in>");
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
