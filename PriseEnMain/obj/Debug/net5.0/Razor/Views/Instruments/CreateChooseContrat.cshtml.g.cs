<<<<<<< HEAD
#pragma checksum "C:\Users\GladisNGUIMATIEU\source\repos\PriseEnMain\PriseEnMain\Views\Instruments\CreateChooseContrat.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66ee9f1e44dda6e7ade584f9d75e3b74a2923c05"
=======
#pragma checksum "C:\Users\GladisNGUIMATIEU\source\repos\PriseEnMain\PriseEnMain\Views\Instruments\CreateChooseContrat.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb25b800c64f1a5bbd2e7b8657c98f4763152509"
>>>>>>> e3accd7050a85c28ae57251593eeaa2ce74cd1d4
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Instruments_CreateChooseContrat), @"mvc.1.0.view", @"/Views/Instruments/CreateChooseContrat.cshtml")]
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
#line 1 "C:\Users\GladisNGUIMATIEU\source\repos\PriseEnMain\PriseEnMain\Views\_ViewImports.cshtml"
using PriseEnMain;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\GladisNGUIMATIEU\source\repos\PriseEnMain\PriseEnMain\Views\_ViewImports.cshtml"
using PriseEnMain.Models;

#line default
#line hidden
#nullable disable
<<<<<<< HEAD
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66ee9f1e44dda6e7ade584f9d75e3b74a2923c05", @"/Views/Instruments/CreateChooseContrat.cshtml")]
=======
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb25b800c64f1a5bbd2e7b8657c98f4763152509", @"/Views/Instruments/CreateChooseContrat.cshtml")]
>>>>>>> e3accd7050a85c28ae57251593eeaa2ce74cd1d4
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4b6fff0a53089259ad6bcbddf148e33f6765bc8", @"/Views/_ViewImports.cshtml")]
    public class Views_Instruments_CreateChooseContrat : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PriseEnMain.ViewModels.CreateInstrumentVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Instruments", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateChooseContrat", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\GladisNGUIMATIEU\source\repos\PriseEnMain\PriseEnMain\Views\Instruments\CreateChooseContrat.cshtml"
  
    ViewData["Title"] = "Contrats";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>Contrats</div>\r\n<hr />\r\n<br />\r\n<p>\r\n    ");
#nullable restore
#line 11 "C:\Users\GladisNGUIMATIEU\source\repos\PriseEnMain\PriseEnMain\Views\Instruments\CreateChooseContrat.cshtml"
Write(Html.ActionLink("+ Create New One", "Create", "Contrats", new { typeId = Model.TypeInstrumentId, emetteurId = Model.EmetteurId, instrumentId = Model.InstrumentSousJacentId }, new { @class = "btn btn-outline-success rounded-0" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n");
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66ee9f1e44dda6e7ade584f9d75e3b74a2923c055597", async() => {
                WriteLiteral("\r\n    <p>\r\n        <input type=\"text\" name=\"SearchString\" />\r\n        <input type=\"submit\" value=\"Filter\" />\r\n    </p>\r\n");
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb25b800c64f1a5bbd2e7b8657c98f47631525095597", async() => {
                WriteLiteral("\r\n    <p>\r\n        <input type=\"text\" name=\"SearchString\"/>\r\n        <input type=\"submit\" value=\"Filter\"/>\r\n    </p>\r\n");
>>>>>>> e3accd7050a85c28ae57251593eeaa2ce74cd1d4
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
<<<<<<< HEAD
#nullable restore
#line 20 "C:\Users\GladisNGUIMATIEU\source\repos\PriseEnMain\PriseEnMain\Views\Instruments\CreateChooseContrat.cshtml"
 for (int i = 0; i < Model.Attributs.Count; i++)
{
    if (Model.Attributs[i].AttributeTypeValueType == "Contrat")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66ee9f1e44dda6e7ade584f9d75e3b74a2923c057723", async() => {
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66ee9f1e44dda6e7ade584f9d75e3b74a2923c057993", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb25b800c64f1a5bbd2e7b8657c98f47631525097368", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb25b800c64f1a5bbd2e7b8657c98f47631525097630", async() => {
>>>>>>> e3accd7050a85c28ae57251593eeaa2ce74cd1d4
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 25 "C:\Users\GladisNGUIMATIEU\source\repos\PriseEnMain\PriseEnMain\Views\Instruments\CreateChooseContrat.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n");
#nullable restore
#line 27 "C:\Users\GladisNGUIMATIEU\source\repos\PriseEnMain\PriseEnMain\Views\Instruments\CreateChooseContrat.cshtml"
                 foreach (var item in Model.Contrats)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 29 "C:\Users\GladisNGUIMATIEU\source\repos\PriseEnMain\PriseEnMain\Views\Instruments\CreateChooseContrat.cshtml"
               Write(Html.ActionLink(item.Name, "CreateChooseAttribut", "Instruments", new { typeId = Model.TypeInstrumentId, emetteurId = Model.EmetteurId, instrumentId = Model.InstrumentSousJacentId, contratId = item.Id }, new { @class = "list-group-item list-group-item-action text-primary" }));
=======
#line 25 "C:\Users\GladisNGUIMATIEU\source\repos\PriseEnMain\PriseEnMain\Views\Instruments\CreateChooseContrat.cshtml"
       Write(Html.ActionLink(item.Name, "CreateChooseAttribut", "Instruments", new { typeId = Model.TypeInstrumentId, emetteurId = Model.EmetteurId, instrumentId = Model.InstrumentSousJacentId, contratId = item.Id }, new { @class = "list-group-item list-group-item-action text-primary" }));
>>>>>>> e3accd7050a85c28ae57251593eeaa2ce74cd1d4

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 29 "C:\Users\GladisNGUIMATIEU\source\repos\PriseEnMain\PriseEnMain\Views\Instruments\CreateChooseContrat.cshtml"
                                                                                                                                                                                                                                                                                                        
                }
=======
#line 25 "C:\Users\GladisNGUIMATIEU\source\repos\PriseEnMain\PriseEnMain\Views\Instruments\CreateChooseContrat.cshtml"
                                                                                                                                                                                                                                                                                                
        }
>>>>>>> e3accd7050a85c28ae57251593eeaa2ce74cd1d4

#line default
#line hidden
#nullable disable
                WriteLiteral("            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
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
#line 33 "C:\Users\GladisNGUIMATIEU\source\repos\PriseEnMain\PriseEnMain\Views\Instruments\CreateChooseContrat.cshtml"

    }
}

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n        <div class=\"btn-container\">\r\n            <div class=\"btn-container\">\r\n                ");
#nullable restore
#line 39 "C:\Users\GladisNGUIMATIEU\source\repos\PriseEnMain\PriseEnMain\Views\Instruments\CreateChooseContrat.cshtml"
           Write(Html.ActionLink("Back", "CreateChooseInstrumentSousjacent", "Instruments", new { typeId = Model.TypeInstrumentId, emetteurId = Model.EmetteurId, instrumentId = Model.InstrumentSousJacentId }, new { @class = "btn btn-outline-success rounded-0" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n\r\n        </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PriseEnMain.ViewModels.CreateInstrumentVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
