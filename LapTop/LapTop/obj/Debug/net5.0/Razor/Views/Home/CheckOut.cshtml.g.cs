#pragma checksum "E:\DO_AN_TTCK\Do_An_TTCK\LapTop\LapTop\Views\Home\CheckOut.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b01ceb67edea4fc0e454feefe409519c9cfb3eb2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CheckOut), @"mvc.1.0.view", @"/Views/Home/CheckOut.cshtml")]
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
#line 1 "E:\DO_AN_TTCK\Do_An_TTCK\LapTop\LapTop\Views\_ViewImports.cshtml"
using LapTop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\DO_AN_TTCK\Do_An_TTCK\LapTop\LapTop\Views\_ViewImports.cshtml"
using LapTop.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "E:\DO_AN_TTCK\Do_An_TTCK\LapTop\LapTop\Views\Home\CheckOut.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b01ceb67edea4fc0e454feefe409519c9cfb3eb2", @"/Views/Home/CheckOut.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a53b268c9cb016cea4365a2cfa183cf5e714c88", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CheckOut : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<LapTop.Models.CartItem>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-thumbnail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("50"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateBill", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!-- BREADCRUMB -->
<div id=""breadcrumb"" class=""section"">
    <!-- container -->
    <div class=""container"">
        <!-- row -->
        <div class=""row"">
            <div class=""col-md-12"">
                <h3 class=""breadcrumb-header"">Checkout</h3>
                <ul class=""breadcrumb-tree"">
                    <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b01ceb67edea4fc0e454feefe409519c9cfb3eb25609", async() => {
                WriteLiteral("Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</li>
                    <li class=""active"">Checkout</li>
                </ul>
            </div>
        </div>
        <!-- /row -->
    </div>
    <!-- /container -->
</div>
<!-- /BREADCRUMB -->
<!-- SECTION -->
<div class=""section"">
    <!-- container -->
    <div class=""container"">
        <!-- row -->
        <div class=""row"">
");
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b01ceb67edea4fc0e454feefe409519c9cfb3eb27369", async() => {
                WriteLiteral(@"
                <div class=""col-md-7"">
                    <!-- Billing Details -->
                    <div class=""billing-details"">
                        <div class=""section-title"">
                            <h4 class=""title"" style=""font-weight:initial"">Địa chỉ thanh toán của:<strong style=""color:black""> ");
#nullable restore
#line 33 "E:\DO_AN_TTCK\Do_An_TTCK\LapTop\LapTop\Views\Home\CheckOut.cshtml"
                                                                                                                         Write(Context.Session.GetString("_HoVaTen").ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong></h4>\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            <input class=\"input\" type=\"text\" name=\"first-name\" placeholder=\"First Name\"");
                BeginWriteAttribute("value", " value=\"", 1428, "\"", 1474, 1);
#nullable restore
#line 36 "E:\DO_AN_TTCK\Do_An_TTCK\LapTop\LapTop\Views\Home\CheckOut.cshtml"
WriteAttributeValue("", 1436, Context.Session.GetString("_HoVaTen"), 1436, 38, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                        </div>

                       
                        <div class=""form-group"">
                            <input class=""input"" type=""text"" name=""NoiNhan"" placeholder=""Address"">
                        </div>

                        <div class=""form-group"">
                            <input class=""input"" type=""tel"" name=""SoDienThoai"" placeholder=""Telephone"">
                        </div>

                    </div>
                   

                    <!-- /Billing Details -->
                    <!-- Shiping Details -->
                    <div class=""shiping-details"">
                        <div class=""section-title"">
                            <h3 class=""title"">Địa chỉ giao hàng</h3>
                        </div>
                        <div class=""input-checkbox"">
                            <input type=""checkbox"" id=""shiping-address"">
                            <label for=""shiping-address"">
                                <span></span>
     ");
                WriteLiteral(@"                           Gửi đến một địa chỉ khác?
                            </label>
                            <div class=""caption"">

                                <div class=""form-group"">
                                    <input class=""input"" type=""text"" name=""first-name"" placeholder=""First Name""");
                BeginWriteAttribute("value", " value=\"", 2813, "\"", 2859, 1);
#nullable restore
#line 66 "E:\DO_AN_TTCK\Do_An_TTCK\LapTop\LapTop\Views\Home\CheckOut.cshtml"
WriteAttributeValue("", 2821, Context.Session.GetString("_HoVaTen"), 2821, 38, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                </div>

                                <div class=""form-group"">
                                    <input class=""input"" type=""email"" name=""email"" placeholder=""Email"">
                                </div>
                                <div class=""form-group"">
                                    <input class=""input"" type=""text"" name=""DiaChi"" placeholder=""Address"">
                                </div>

                                <div class=""form-group"">
                                    <input class=""input"" type=""tel"" name=""SoDienThoai"" placeholder=""Telephone"">
                                </div>
                            </div>
                        </div>
                    </div>

                    <!-- /Shiping Details -->
                    <!-- Order notes -->
                    <div class=""order-notes"">
                        <textarea class=""input"" placeholder=""Order Notes""></textarea>
                    </div>
         ");
                WriteLiteral(@"           <!-- /Order notes -->
                </div>


                <!-- Order Details -->
                <div class=""col-md-5 order-details"">
                    <div class=""section-title text-center"">
                        <h3 class=""title"">ĐƠN HÀNG CỦA BẠN</h3>
                    </div>
                    <div class=""order-summary"">
");
#nullable restore
#line 98 "E:\DO_AN_TTCK\Do_An_TTCK\LapTop\LapTop\Views\Home\CheckOut.cshtml"
                         if (Model.Count > 0)
                        {

                            int amount = 0;
                            int total = 0;


#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            <div class=""order-col"">
                                <div><strong>Ảnh sản phẩm</strong></div>
                                <div style=""padding-left: 30px;""><strong>SL & Tên sản phẩm </strong></div>
                                <div><strong>Thành tiền</strong></div>
                            </div>
");
#nullable restore
#line 109 "E:\DO_AN_TTCK\Do_An_TTCK\LapTop\LapTop\Views\Home\CheckOut.cshtml"
                             foreach (var i in Model)
                            {
                                amount = i.Sanpham.GiaBan * i.Quantity;
                                total += amount;

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <div class=\"order-products\">\r\n                                    <div class=\"order-col\">\r\n                                        <div>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b01ceb67edea4fc0e454feefe409519c9cfb3eb213460", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 5140, "~/images/", 5140, 9, true);
#nullable restore
#line 115 "E:\DO_AN_TTCK\Do_An_TTCK\LapTop\LapTop\Views\Home\CheckOut.cshtml"
AddHtmlAttributeValue("", 5149, i.Sanpham.AnhSanPham, 5149, 23, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</div>\r\n                                        <div style=\"padding-left: 95px;\">");
#nullable restore
#line 116 "E:\DO_AN_TTCK\Do_An_TTCK\LapTop\LapTop\Views\Home\CheckOut.cshtml"
                                                                     Write(i.Quantity);

#line default
#line hidden
#nullable disable
                WriteLiteral("x ");
#nullable restore
#line 116 "E:\DO_AN_TTCK\Do_An_TTCK\LapTop\LapTop\Views\Home\CheckOut.cshtml"
                                                                                    Write(i.Sanpham.TenSanPham);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                                        <div>");
#nullable restore
#line 117 "E:\DO_AN_TTCK\Do_An_TTCK\LapTop\LapTop\Views\Home\CheckOut.cshtml"
                                         Write((i.Sanpham.GiaBan*i.Quantity).ToString("n0"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                                    </div>\r\n\r\n                                </div>\r\n");
#nullable restore
#line 121 "E:\DO_AN_TTCK\Do_An_TTCK\LapTop\LapTop\Views\Home\CheckOut.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            <div class=""order-col"">
                                <div>Shiping</div>
                                <div><strong>FREE</strong></div>
                            </div>
                            <div class=""order-col"">
                                <div><strong>TỔNG TIỀN</strong></div>
                                <div><strong class=""order-total"">");
#nullable restore
#line 128 "E:\DO_AN_TTCK\Do_An_TTCK\LapTop\LapTop\Views\Home\CheckOut.cshtml"
                                                             Write(total.ToString("n0"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong></div>\r\n                            </div>\r\n");
                WriteLiteral("                            <input class=\"primary-btn order-submit\" type=\"submit\"style=\" float: right;\" value=\"Xác nhận đơn hàng\" />\r\n");
#nullable restore
#line 132 "E:\DO_AN_TTCK\Do_An_TTCK\LapTop\LapTop\Views\Home\CheckOut.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </div>\r\n\r\n                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            <!-- /Order Details -->\r\n        </div>\r\n        <!-- /row -->\r\n    </div>\r\n    <!-- /container -->\r\n</div>\r\n<!-- /SECTION -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<LapTop.Models.CartItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
