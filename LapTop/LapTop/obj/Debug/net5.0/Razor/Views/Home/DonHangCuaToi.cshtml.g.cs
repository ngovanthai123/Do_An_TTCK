#pragma checksum "E:\DO_AN_TTCK\Do_An_TTCK\LapTop\LapTop\Views\Home\DonHangCuaToi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "193a382554999a1cdcdf071c9a428051a95fb71e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_DonHangCuaToi), @"mvc.1.0.view", @"/Views/Home/DonHangCuaToi.cshtml")]
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
#line 1 "E:\DO_AN_TTCK\Do_An_TTCK\LapTop\LapTop\Views\Home\DonHangCuaToi.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"193a382554999a1cdcdf071c9a428051a95fb71e", @"/Views/Home/DonHangCuaToi.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a53b268c9cb016cea4365a2cfa183cf5e714c88", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_DonHangCuaToi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LapTop.Models.DonHangCuaToi>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("text-align:center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CancelOrder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "OrderDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "E:\DO_AN_TTCK\Do_An_TTCK\LapTop\LapTop\Views\Home\DonHangCuaToi.cshtml"
  
    ViewBag.Title = "Đơn hàng của tôi";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<div class=\"card mt-3 border-warning\">\r\n    <h5 class=\"card-header\" style=\"color:black; text-align:center\">\r\n        Đơn hàng của ");
#nullable restore
#line 12 "E:\DO_AN_TTCK\Do_An_TTCK\LapTop\LapTop\Views\Home\DonHangCuaToi.cshtml"
                Write(Context.Session.GetString("_HoVaTen").ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </h5>     <div class=\"card-body\">\r\n        <div class=\"row\">\r\n            <a class=\"bg-primary ml-2 text-white\">\r\n                Đơn hàng mới <span class=\"badge badge-light\">");
#nullable restore
#line 16 "E:\DO_AN_TTCK\Do_An_TTCK\LapTop\LapTop\Views\Home\DonHangCuaToi.cshtml"
                                                        Write(Model.Where(m => m.TinhTrang == 1).ToList().Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </a>\r\n\r\n            <a class=\"bg-danger ml-2 text-white\" >\r\n                Đơn hàng đã hủy <span class=\"badge badge-light\">");
#nullable restore
#line 20 "E:\DO_AN_TTCK\Do_An_TTCK\LapTop\LapTop\Views\Home\DonHangCuaToi.cshtml"
                                                           Write(Model.Where(m => m.TinhTrang == 2).ToList().Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </a>\r\n\r\n            <a class=\"bg-success ml-2 text-white\" >\r\n                Đã đóng gói <span class=\"badge badge-light\">");
#nullable restore
#line 24 "E:\DO_AN_TTCK\Do_An_TTCK\LapTop\LapTop\Views\Home\DonHangCuaToi.cshtml"
                                                       Write(Model.Where(m => m.TinhTrang == 3).ToList().Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </a>\r\n\r\n            <a class=\"bg-info ml-2 text-white\" >\r\n                Đơn hàng đã nhận <span class=\"badge badge-light\">");
#nullable restore
#line 28 "E:\DO_AN_TTCK\Do_An_TTCK\LapTop\LapTop\Views\Home\DonHangCuaToi.cshtml"
                                                            Write(Model.Where(m => m.TinhTrang == 9).ToList().Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </a>\r\n        </div>\r\n        <div class=\"row mt-3\">\r\n");
#nullable restore
#line 32 "E:\DO_AN_TTCK\Do_An_TTCK\LapTop\LapTop\Views\Home\DonHangCuaToi.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-3\">\r\n                    <div class=\"card\">\r\n                        <div class=\"card-body\" style=\"min-height: 808px; }\">\r\n                            <!---->\r\n\r\n                            <p>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "193a382554999a1cdcdf071c9a428051a95fb71e8501", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1505, "~/images/", 1505, 9, true);
#nullable restore
#line 39 "E:\DO_AN_TTCK\Do_An_TTCK\LapTop\LapTop\Views\Home\DonHangCuaToi.cshtml"
AddHtmlAttributeValue("", 1514, item.AnhSanPham, 1514, 16, false);

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
            WriteLiteral("</p>\r\n                            <p class=\"card-text\">Tên sách :");
#nullable restore
#line 40 "E:\DO_AN_TTCK\Do_An_TTCK\LapTop\LapTop\Views\Home\DonHangCuaToi.cshtml"
                                                      Write(item.TenSanPham);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p class=\"card-text\" style=\"font-weight:bold; font-family:\'Times New Roman\'\">Ngày đặt hàng :<b>");
#nullable restore
#line 41 "E:\DO_AN_TTCK\Do_An_TTCK\LapTop\LapTop\Views\Home\DonHangCuaToi.cshtml"
                                                                                                                      Write(item.NgayLap);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></p>\r\n                            <p class=\"card-text\" style=\"color:red; font-weight:bold\">Đơn giá:");
#nullable restore
#line 42 "E:\DO_AN_TTCK\Do_An_TTCK\LapTop\LapTop\Views\Home\DonHangCuaToi.cshtml"
                                                                                        Write(String.Format("{0:N0}", item.GiaBan));

#line default
#line hidden
#nullable disable
            WriteLiteral("VNĐ</p>\r\n                            <p class=\"text-right\" style=\"color:red; font-weight:bold\">Tổng tiền:");
#nullable restore
#line 43 "E:\DO_AN_TTCK\Do_An_TTCK\LapTop\LapTop\Views\Home\DonHangCuaToi.cshtml"
                                                                                           Write(String.Format("{0:N0}", item.SoLuongMua * (item.GiaBan )));

#line default
#line hidden
#nullable disable
            WriteLiteral("VNĐ</p>\r\n                            <p style=\"text-align:right; font-weight:bold\">Số lượng:");
#nullable restore
#line 44 "E:\DO_AN_TTCK\Do_An_TTCK\LapTop\LapTop\Views\Home\DonHangCuaToi.cshtml"
                                                                              Write(item.SoLuongMua);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <hr />\r\n                            <div style=\"text-align:center\">\r\n");
#nullable restore
#line 47 "E:\DO_AN_TTCK\Do_An_TTCK\LapTop\LapTop\Views\Home\DonHangCuaToi.cshtml"
                                 if (item.TinhTrang == 0)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"badge badge-info shadow\" >Đơn hàng mới</span>\r\n");
#nullable restore
#line 50 "E:\DO_AN_TTCK\Do_An_TTCK\LapTop\LapTop\Views\Home\DonHangCuaToi.cshtml"
                                }
                                else if (item.TinhTrang == 1)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"badge badge-success shadow\" >Đang xác nhận</span>\r\n");
#nullable restore
#line 54 "E:\DO_AN_TTCK\Do_An_TTCK\LapTop\LapTop\Views\Home\DonHangCuaToi.cshtml"
                                }
                                else if (item.TinhTrang == 2)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"badge badge-danger shadow\" >Đã hủy</span>\r\n");
#nullable restore
#line 58 "E:\DO_AN_TTCK\Do_An_TTCK\LapTop\LapTop\Views\Home\DonHangCuaToi.cshtml"
                                }
                                else if (item.TinhTrang == 3)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"badge badge-warning shadow\" >Đang đóng gói</span>\r\n");
#nullable restore
#line 62 "E:\DO_AN_TTCK\Do_An_TTCK\LapTop\LapTop\Views\Home\DonHangCuaToi.cshtml"
                                }
                                else if (item.TinhTrang == 4)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"badge badge-warning shadow\" >Đang gửi vận chuyển</span>\r\n");
#nullable restore
#line 66 "E:\DO_AN_TTCK\Do_An_TTCK\LapTop\LapTop\Views\Home\DonHangCuaToi.cshtml"
                                }
                                else if (item.TinhTrang == 5)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"badge badge-primary shadow\" >Đang chuyển</span>\r\n");
#nullable restore
#line 70 "E:\DO_AN_TTCK\Do_An_TTCK\LapTop\LapTop\Views\Home\DonHangCuaToi.cshtml"
                                }
                                else if (item.TinhTrang == 6)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"badge badge-danger shadow\" >Thất bại</span>\r\n");
#nullable restore
#line 74 "E:\DO_AN_TTCK\Do_An_TTCK\LapTop\LapTop\Views\Home\DonHangCuaToi.cshtml"
                                }
                                else if (item.TinhTrang == 7)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"badge badge-warning shadow\" >Đang chuyển hoàn</span>\r\n");
#nullable restore
#line 78 "E:\DO_AN_TTCK\Do_An_TTCK\LapTop\LapTop\Views\Home\DonHangCuaToi.cshtml"
                                }
                                else if (item.TinhTrang == 8)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"badge badge-success shadow\" >Đã chuyển hoàn</span>\r\n");
#nullable restore
#line 82 "E:\DO_AN_TTCK\Do_An_TTCK\LapTop\LapTop\Views\Home\DonHangCuaToi.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"badge badge-primary shadow\" >Thành công</span>\r\n");
#nullable restore
#line 86 "E:\DO_AN_TTCK\Do_An_TTCK\LapTop\LapTop\Views\Home\DonHangCuaToi.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n                            <hr />\r\n");
#nullable restore
#line 89 "E:\DO_AN_TTCK\Do_An_TTCK\LapTop\LapTop\Views\Home\DonHangCuaToi.cshtml"
                             if (item.TinhTrang == 0)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "193a382554999a1cdcdf071c9a428051a95fb71e16852", async() => {
                WriteLiteral("Hủy");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 91 "E:\DO_AN_TTCK\Do_An_TTCK\LapTop\LapTop\Views\Home\DonHangCuaToi.cshtml"
                                                                                                                       WriteLiteral(item.IdDH);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 92 "E:\DO_AN_TTCK\Do_An_TTCK\LapTop\LapTop\Views\Home\DonHangCuaToi.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "193a382554999a1cdcdf071c9a428051a95fb71e19686", async() => {
                WriteLiteral("Chi tiết");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 93 "E:\DO_AN_TTCK\Do_An_TTCK\LapTop\LapTop\Views\Home\DonHangCuaToi.cshtml"
                                                                                              WriteLiteral(item.IdDH);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 98 "E:\DO_AN_TTCK\Do_An_TTCK\LapTop\LapTop\Views\Home\DonHangCuaToi.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LapTop.Models.DonHangCuaToi>> Html { get; private set; }
    }
}
#pragma warning restore 1591
