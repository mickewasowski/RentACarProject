#pragma checksum "C:\Users\R. Yorgova\Desktop\RentACar\Web\RentACar.Web\Views\Shared\_ImageSliderPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c7dbf5541c488377c9ee619ef38ad6f89cb6bbd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ImageSliderPartial), @"mvc.1.0.view", @"/Views/Shared/_ImageSliderPartial.cshtml")]
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
#line 1 "C:\Users\R. Yorgova\Desktop\RentACar\Web\RentACar.Web\Views\_ViewImports.cshtml"
using RentACar.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\R. Yorgova\Desktop\RentACar\Web\RentACar.Web\Views\_ViewImports.cshtml"
using RentACar.Web.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c7dbf5541c488377c9ee619ef38ad6f89cb6bbd", @"/Views/Shared/_ImageSliderPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fcad96cd89de2d4039e6e66ea08c0e831e54fbf2", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ImageSliderPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RentACar.Web.ViewModels.Vehicle.VehicleDetailsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\R. Yorgova\Desktop\RentACar\Web\RentACar.Web\Views\Shared\_ImageSliderPartial.cshtml"
   
    var images = Model.Images.Select(x => new SelectListItem(x.URL, x.Id.ToString()));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div id=\"carouselExampleControls\" class=\"carousel slide\" data-ride=\"carousel\">\r\n    <div class=\"carousel-inner\">\r\n");
#nullable restore
#line 10 "C:\Users\R. Yorgova\Desktop\RentACar\Web\RentACar.Web\Views\Shared\_ImageSliderPartial.cshtml"
         foreach (var pic in @Model.Images)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"carousel-item\"");
            BeginWriteAttribute("id", " id=\"", 374, "\"", 386, 1);
#nullable restore
#line 12 "C:\Users\R. Yorgova\Desktop\RentACar\Web\RentACar.Web\Views\Shared\_ImageSliderPartial.cshtml"
WriteAttributeValue("", 379, pic.Id, 379, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <img class=\"d-block w-100\"");
            BeginWriteAttribute("src", " src=\"", 432, "\"", 446, 1);
#nullable restore
#line 13 "C:\Users\R. Yorgova\Desktop\RentACar\Web\RentACar.Web\Views\Shared\_ImageSliderPartial.cshtml"
WriteAttributeValue("", 438, pic.URL, 438, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 447, "\"", 459, 1);
#nullable restore
#line 13 "C:\Users\R. Yorgova\Desktop\RentACar\Web\RentACar.Web\Views\Shared\_ImageSliderPartial.cshtml"
WriteAttributeValue("", 452, pic.Id, 452, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            </div>\r\n");
#nullable restore
#line 15 "C:\Users\R. Yorgova\Desktop\RentACar\Web\RentACar.Web\Views\Shared\_ImageSliderPartial.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RentACar.Web.ViewModels.Vehicle.VehicleDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591