#pragma checksum "C:\Users\R. Yorgova\Desktop\RentACar\Web\RentACar.Web\Views\Vehicle\AllVehicles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bbf0f1b86cd7e6539ac36f82c4438fecfe2997a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vehicle_AllVehicles), @"mvc.1.0.view", @"/Views/Vehicle/AllVehicles.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bbf0f1b86cd7e6539ac36f82c4438fecfe2997a6", @"/Views/Vehicle/AllVehicles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fcad96cd89de2d4039e6e66ea08c0e831e54fbf2", @"/Views/_ViewImports.cshtml")]
    public class Views_Vehicle_AllVehicles : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RentACar.Web.ViewModels.Vehicle.AllVehiclesViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("border-bottom: solid 1px lightgrey;margin-bottom: 7px;margin-top: -2px;text-align: center;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-bottom: 7px;margin-top: -2px;text-align: center;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\R. Yorgova\Desktop\RentACar\Web\RentACar.Web\Views\Vehicle\AllVehicles.cshtml"
  
    this.ViewData["Title"] = "All vehicles";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("<div class=\"container row col-md-8\" style=\"padding: 10px;opacity:0.95;\">\r\n");
#nullable restore
#line 9 "C:\Users\R. Yorgova\Desktop\RentACar\Web\RentACar.Web\Views\Vehicle\AllVehicles.cshtml"
     foreach (var vehicle in this.Model.Vehicles)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card col-sm\" style=\"width: 18rem;margin-right: 10px;margin-left: 10px;\">\r\n            <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 400, "\"", 422, 1);
#nullable restore
#line 12 "C:\Users\R. Yorgova\Desktop\RentACar\Web\RentACar.Web\Views\Vehicle\AllVehicles.cshtml"
WriteAttributeValue("", 406, vehicle.Picture, 406, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\" style=\"width: 170px;height: 120px;\">\r\n            <div class=\"card-body\" style=\"padding: 5px;\">\r\n                <h5 class=\"card-title\" style=\"margin-bottom: 2px;text-align:center;\">");
#nullable restore
#line 14 "C:\Users\R. Yorgova\Desktop\RentACar\Web\RentACar.Web\Views\Vehicle\AllVehicles.cshtml"
                                                                                Write(vehicle.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <h6 class=\"card-title\" style=\"margin-bottom: 2px;text-align:center;\">");
#nullable restore
#line 15 "C:\Users\R. Yorgova\Desktop\RentACar\Web\RentACar.Web\Views\Vehicle\AllVehicles.cshtml"
                                                                                Write(vehicle.Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n            </div>\r\n            <ul class=\"list-group list-group-flush\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bbf0f1b86cd7e6539ac36f82c4438fecfe2997a66135", async() => {
                WriteLiteral("Seats: ");
#nullable restore
#line 18 "C:\Users\R. Yorgova\Desktop\RentACar\Web\RentACar.Web\Views\Vehicle\AllVehicles.cshtml"
                                                                                                                                                     Write(vehicle.Seats);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 18 "C:\Users\R. Yorgova\Desktop\RentACar\Web\RentACar.Web\Views\Vehicle\AllVehicles.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => vehicle.Seats);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bbf0f1b86cd7e6539ac36f82c4438fecfe2997a68061", async() => {
                WriteLiteral("Doors: ");
#nullable restore
#line 20 "C:\Users\R. Yorgova\Desktop\RentACar\Web\RentACar.Web\Views\Vehicle\AllVehicles.cshtml"
                                                                                                                                                     Write(vehicle.Doors);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 20 "C:\Users\R. Yorgova\Desktop\RentACar\Web\RentACar.Web\Views\Vehicle\AllVehicles.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => vehicle.Doors);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bbf0f1b86cd7e6539ac36f82c4438fecfe2997a69987", async() => {
                WriteLiteral("Fuel Type: ");
#nullable restore
#line 22 "C:\Users\R. Yorgova\Desktop\RentACar\Web\RentACar.Web\Views\Vehicle\AllVehicles.cshtml"
                                                                                                                                                            Write(vehicle.FuelType);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 22 "C:\Users\R. Yorgova\Desktop\RentACar\Web\RentACar.Web\Views\Vehicle\AllVehicles.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => vehicle.FuelType);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bbf0f1b86cd7e6539ac36f82c4438fecfe2997a611930", async() => {
                WriteLiteral("Gearbox: ");
#nullable restore
#line 24 "C:\Users\R. Yorgova\Desktop\RentACar\Web\RentACar.Web\Views\Vehicle\AllVehicles.cshtml"
                                                                                                                                                         Write(vehicle.Gearbox);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 24 "C:\Users\R. Yorgova\Desktop\RentACar\Web\RentACar.Web\Views\Vehicle\AllVehicles.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => vehicle.Gearbox);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bbf0f1b86cd7e6539ac36f82c4438fecfe2997a613867", async() => {
                WriteLiteral("Price per day: ");
#nullable restore
#line 26 "C:\Users\R. Yorgova\Desktop\RentACar\Web\RentACar.Web\Views\Vehicle\AllVehicles.cshtml"
                                                                                                                                Write(vehicle.PricePerDay);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 26 "C:\Users\R. Yorgova\Desktop\RentACar\Web\RentACar.Web\Views\Vehicle\AllVehicles.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => vehicle.PricePerDay);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </ul>\r\n            <div class=\"buttons\" style=\"display:flex;\">\r\n                <div class=\"card-body\" style=\"padding: 10px 0px;justify-content: center;align-items: center;float:left;\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1948, "\"", 1981, 2);
            WriteAttributeValue("", 1955, "VehicleDetails/", 1955, 15, true);
#nullable restore
#line 30 "C:\Users\R. Yorgova\Desktop\RentACar\Web\RentACar.Web\Views\Vehicle\AllVehicles.cshtml"
WriteAttributeValue("", 1970, vehicle.Id, 1970, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-link\" style=\"float:left;width:60px;text-align:center;border: none;background-color: rgb(22, 145, 222);border-radius: 8px;color: white;\">Details</a>\r\n                </div>\r\n\r\n                <div style=\"float:right;margin:auto;\">\r\n");
#nullable restore
#line 34 "C:\Users\R. Yorgova\Desktop\RentACar\Web\RentACar.Web\Views\Vehicle\AllVehicles.cshtml"
                     if (vehicle.IsBooked)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a style=\"width: 60px;background-color: red;color: white;border-radius: 8px;border: none;text-align: center;padding: 3px 5px;\">\r\n                            Booked\r\n                        </a>\r\n");
#nullable restore
#line 39 "C:\Users\R. Yorgova\Desktop\RentACar\Web\RentACar.Web\Views\Vehicle\AllVehicles.cshtml"
                    }
                    else
                    {
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a");
            BeginWriteAttribute("href", " href=\"", 2670, "\"", 2707, 2);
            WriteAttributeValue("", 2677, "/Offer/CreateOffer/", 2677, 19, true);
#nullable restore
#line 43 "C:\Users\R. Yorgova\Desktop\RentACar\Web\RentACar.Web\Views\Vehicle\AllVehicles.cshtml"
WriteAttributeValue("", 2696, vehicle.Id, 2696, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:80px;background-color:green;color:white;border-radius:8px;border:none;text-align:center;padding:3px 5px;\">\r\n                            Book Now\r\n                        </a>\r\n");
#nullable restore
#line 46 "C:\Users\R. Yorgova\Desktop\RentACar\Web\RentACar.Web\Views\Vehicle\AllVehicles.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 50 "C:\Users\R. Yorgova\Desktop\RentACar\Web\RentACar.Web\Views\Vehicle\AllVehicles.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RentACar.Web.ViewModels.Vehicle.AllVehiclesViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
