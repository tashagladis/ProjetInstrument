#pragma checksum "C:\Users\GladisNGUIMATIEU\source\repos\PriseEnMain\PriseEnMain\Views\Instruments\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6235b2366a158efcb6a19dd45a23a55aa169a823"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Instruments_Create), @"mvc.1.0.view", @"/Views/Instruments/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6235b2366a158efcb6a19dd45a23a55aa169a823", @"/Views/Instruments/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4b6fff0a53089259ad6bcbddf148e33f6765bc8", @"/Views/_ViewImports.cshtml")]
    public class Views_Instruments_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PriseEnMain.ViewModels.CreateInstrumentVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\GladisNGUIMATIEU\source\repos\PriseEnMain\PriseEnMain\Views\Instruments\Create.cshtml"
  
    ViewData["Title"] = "Create";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Recapitulatif</h1>\r\n<hr />\r\n<br />\r\n<p>Type d\'instrument : ");
#nullable restore
#line 11 "C:\Users\GladisNGUIMATIEU\source\repos\PriseEnMain\PriseEnMain\Views\Instruments\Create.cshtml"
                  Write(Model.TypeInstrumentName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<br />\r\n<p>Personne : ");
#nullable restore
#line 13 "C:\Users\GladisNGUIMATIEU\source\repos\PriseEnMain\PriseEnMain\Views\Instruments\Create.cshtml"
         Write(Model.EmetteurName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<br />\r\n<p>Instrument Sous-jacent: ");
#nullable restore
#line 15 "C:\Users\GladisNGUIMATIEU\source\repos\PriseEnMain\PriseEnMain\Views\Instruments\Create.cshtml"
                      Write(Model.InstrumentName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<br />\r\n<p>Nom du Contrat : ");
#nullable restore
#line 17 "C:\Users\GladisNGUIMATIEU\source\repos\PriseEnMain\PriseEnMain\Views\Instruments\Create.cshtml"
               Write(Model.ContratName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<br />\r\n");
#nullable restore
#line 19 "C:\Users\GladisNGUIMATIEU\source\repos\PriseEnMain\PriseEnMain\Views\Instruments\Create.cshtml"
 for (int i = 0; i < Model.Attributs.Count; i++)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>");
#nullable restore
#line 21 "C:\Users\GladisNGUIMATIEU\source\repos\PriseEnMain\PriseEnMain\Views\Instruments\Create.cshtml"
Write(Model.Attributs[i].AttributeTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("  :  ");
#nullable restore
#line 21 "C:\Users\GladisNGUIMATIEU\source\repos\PriseEnMain\PriseEnMain\Views\Instruments\Create.cshtml"
                                        Write(Model.Attributs[i].Value);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n<br />\r\n");
#nullable restore
#line 23 "C:\Users\GladisNGUIMATIEU\source\repos\PriseEnMain\PriseEnMain\Views\Instruments\Create.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    <div class=\"btn-container\">\r\n        <div class=\"btn-container\">\r\n            ");
#nullable restore
#line 28 "C:\Users\GladisNGUIMATIEU\source\repos\PriseEnMain\PriseEnMain\Views\Instruments\Create.cshtml"
       Write(Html.ActionLink("Back", "CreateChooseContrat", "Instruments", new { typeId = Model.TypeInstrumentId, emetteurId = Model.EmetteurId, instrumentId = Model.InstrumentSousJacentId, contratId = Model.ContratId }, new { @class = "btn btn-outline-success rounded-0" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 29 "C:\Users\GladisNGUIMATIEU\source\repos\PriseEnMain\PriseEnMain\Views\Instruments\Create.cshtml"
       Write(Html.ActionLink("Register", "Save", "Instruments", new { typeId = Model.TypeInstrumentId, emetteurId = Model.EmetteurId, instrumentId = Model.InstrumentSousJacentId, contratId = Model.ContratId }, new { @class = "btn btn-outline-success rounded-0" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 34 "C:\Users\GladisNGUIMATIEU\source\repos\PriseEnMain\PriseEnMain\Views\Instruments\Create.cshtml"
          await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
                WriteLiteral("    ");
            }
            );
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
