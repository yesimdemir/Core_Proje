#pragma checksum "D:\Core_Proje\Core_Proje\Areas\Writer\Views\Message\ReceiverMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40552e83ecee4cc3f973c4128c74d8c9f72649e7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Writer_Views_Message_ReceiverMessage), @"mvc.1.0.view", @"/Areas/Writer/Views/Message/ReceiverMessage.cshtml")]
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
#line 1 "D:\Core_Proje\Core_Proje\Areas\Writer\Views\Message\ReceiverMessage.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40552e83ecee4cc3f973c4128c74d8c9f72649e7", @"/Areas/Writer/Views/Message/ReceiverMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Areas/Writer/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Writer_Views_Message_ReceiverMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WriterMessage>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\Core_Proje\Core_Proje\Areas\Writer\Views\Message\ReceiverMessage.cshtml"
  
    ViewData["Title"] = "ReceiverMessage";
    Layout = "~/Views/Shared/_WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-lg-12 grid-margin stretch-card"">
    <div class=""card"">
        <div class=""card-body"">
            <h4 class=""card-title"">Gelen Kutusu</h4>
            <div class=""table-responsive"">
                <table class=""table"">
                    <thead>
                        <tr>
                            <th>#</th>
                            <th>Konu</th>
                            <th>Gönderen</th>
                            <th>Tarih</th>
                            <th>Detaylar</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 25 "D:\Core_Proje\Core_Proje\Areas\Writer\Views\Message\ReceiverMessage.cshtml"
                         foreach (var item in Model)
                        {
                         

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <th>");
#nullable restore
#line 29 "D:\Core_Proje\Core_Proje\Areas\Writer\Views\Message\ReceiverMessage.cshtml"
                               Write(item.WriterMessageID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <td>");
#nullable restore
#line 30 "D:\Core_Proje\Core_Proje\Areas\Writer\Views\Message\ReceiverMessage.cshtml"
                               Write(item.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 31 "D:\Core_Proje\Core_Proje\Areas\Writer\Views\Message\ReceiverMessage.cshtml"
                               Write(item.SenderName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 32 "D:\Core_Proje\Core_Proje\Areas\Writer\Views\Message\ReceiverMessage.cshtml"
                                Write(((DateTime)item.Date).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td><a");
            BeginWriteAttribute("href", " href=\"", 1229, "\"", 1288, 2);
            WriteAttributeValue("", 1236, "/Writer/Message/MessageDetails/", 1236, 31, true);
#nullable restore
#line 33 "D:\Core_Proje\Core_Proje\Areas\Writer\Views\Message\ReceiverMessage.cshtml"
WriteAttributeValue("", 1267, item.WriterMessageID, 1267, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-primary\">Mesajı Gör</a></td>\r\n                            </tr>\r\n");
#nullable restore
#line 35 "D:\Core_Proje\Core_Proje\Areas\Writer\Views\Message\ReceiverMessage.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<WriterMessage>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
