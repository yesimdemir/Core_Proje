#pragma checksum "D:\Core_Proje\Core_Proje\Views\Feature\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73576fe1b96678ab65aa2d28d0d68ea3b5d91cfc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Feature_Index), @"mvc.1.0.view", @"/Views/Feature/Index.cshtml")]
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
#line 1 "D:\Core_Proje\Core_Proje\Views\_ViewImports.cshtml"
using Core_Proje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Core_Proje\Core_Proje\Views\_ViewImports.cshtml"
using Core_Proje.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73576fe1b96678ab65aa2d28d0d68ea3b5d91cfc", @"/Views/Feature/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3916d9c95bde3173996b91a771a7fba1f38cc4f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Feature_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Feature>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Core_Proje\Core_Proje\Views\Feature\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "D:\Core_Proje\Core_Proje\Views\Feature\Index.cshtml"
 using (Html.BeginForm("Index", "Feature", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Core_Proje\Core_Proje\Views\Feature\Index.cshtml"
Write(Html.HiddenFor(x => x.FeatureID));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <label>Başlık</label>\r\n");
#nullable restore
#line 13 "D:\Core_Proje\Core_Proje\Views\Feature\Index.cshtml"
Write(Html.TextBoxFor(x => x.Header, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <label>Ad Soyad</label>\r\n");
#nullable restore
#line 16 "D:\Core_Proje\Core_Proje\Views\Feature\Index.cshtml"
Write(Html.TextBoxFor(x => x.Name, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <label>Görev</label>\r\n");
#nullable restore
#line 19 "D:\Core_Proje\Core_Proje\Views\Feature\Index.cshtml"
Write(Html.TextBoxFor(x => x.Title, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <button class=\"btn btn-success\">Güncelle</button>\r\n");
#nullable restore
#line 22 "D:\Core_Proje\Core_Proje\Views\Feature\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Feature> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
