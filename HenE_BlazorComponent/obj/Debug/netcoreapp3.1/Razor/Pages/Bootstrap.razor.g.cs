#pragma checksum "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Bootstrap.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7be209ae75b2c09fa97eafbabd9739614d0975df"
// <auto-generated/>
#pragma warning disable 1591
namespace HenE_BlazorComponent.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using HenE_BlazorComponent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using HenE_BlazorComponent.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using HenE_BlazorComponent.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.Blazor.InPlaceEditor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.Blazor.Inputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.Blazor.RichTextEditor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.Blazor.SplitButtons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.Blazor.CircularGauge;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.Blazor.Navigations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.Blazor.Schedule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.Blazor.Popups;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.Blazor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using HenE_BlazorComponent.Enumeration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using HenE_BlazorComponent.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.Blazor.Notifications;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.Blazor.Lists;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Bootstrap.razor"
using Syncfusion.Blazor.Calendars;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/bootstrap")]
    public partial class Bootstrap : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 class=\"text-danger\">Bootstrap</h3>\n\n");
            __builder.OpenElement(1, "section");
            __builder.AddAttribute(2, "class", "container-fluid");
            __builder.AddMarkupContent(3, "\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "row");
            __builder.AddMarkupContent(6, "\n        ");
            __builder.AddMarkupContent(7, "<label class=\"col-2\">Naam:</label>\n        ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "col-8 offset-2");
            __builder.AddMarkupContent(10, "\n            ");
            __Blazor.HenE_BlazorComponent.Pages.Bootstrap.TypeInference.CreateSfInPlaceEditor_0(__builder, 11, 12, 
#nullable restore
#line 9 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Bootstrap.razor"
                                     Naam

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(13, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\n    <br>\n    ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "row");
            __builder.AddMarkupContent(18, "\n        ");
            __builder.OpenComponent<Syncfusion.Blazor.Buttons.SfCheckBox>(19);
            __builder.AddAttribute(20, "CssClass", "offset-4");
            __builder.AddAttribute(21, "Label", "Zou je deze box checken?");
            __builder.CloseComponent();
            __builder.AddMarkupContent(22, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\n    <br>\n    ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "row");
            __builder.AddMarkupContent(26, "\n        ");
            __builder.AddMarkupContent(27, "<label class=\"col-1\">Start:</label>\n        ");
            __Blazor.HenE_BlazorComponent.Pages.Bootstrap.TypeInference.CreateSfDateTimePicker_1(__builder, 28, 29, "col-2", 30, 
#nullable restore
#line 19 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Bootstrap.razor"
                                                  StartTime

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(31, "\n        ");
            __builder.AddMarkupContent(32, "<label class=\"col-1 offset-md-2\">End:</label>\n        ");
            __Blazor.HenE_BlazorComponent.Pages.Bootstrap.TypeInference.CreateSfDateTimePicker_2(__builder, 33, 34, "col-2", 35, 
#nullable restore
#line 21 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Bootstrap.razor"
                                                  EndTime

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(36, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\n    <br>\n    ");
            __builder.AddMarkupContent(38, "<div>Toelichting </div>\n    <br>\n    ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "row");
            __builder.AddMarkupContent(41, "\n        ");
            __builder.OpenComponent<Syncfusion.Blazor.Inputs.SfTextBox>(42);
            __builder.AddAttribute(43, "Value", "Text");
            __builder.AddAttribute(44, "FloatLabelType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Inputs.FloatLabelType>(
#nullable restore
#line 27 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Bootstrap.razor"
                                                 FloatLabelType.Auto

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(45, "Multiline", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 27 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Bootstrap.razor"
                                                                                 true

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(46, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\n    ");
            __builder.OpenElement(48, "div");
            __builder.AddMarkupContent(49, "\n        ");
            __builder.OpenComponent<Syncfusion.Blazor.RichTextEditor.SfRichTextEditor>(50);
            __builder.CloseComponent();
            __builder.AddMarkupContent(51, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\n");
            __builder.OpenElement(54, "h1");
            __builder.AddContent(55, 
#nullable restore
#line 33 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Bootstrap.razor"
     Naam

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Bootstrap.razor"
      
    [Inject]
    protected IJSRuntime JsRuntime { get; set; }
    public string Naam { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }

    protected override void OnAfterRender(bool firstRender)
    {
        //this.JsRuntime.Sf().LoadLocaleData("wwwroot/ej2-locale/src/de.json").SetCulture("de").LoadCldrData(new string[] { "wwwroot/cldr-data/main/de/ca-gregorian.json", "wwwroot/cldr-data/main/de/timeZoneNames.json", "wwwroot/cldr-data/main/de/numbers.json" });
        // this.JsRuntime.Sf().LoadLocaleData("wwwroot/ej2-locale/src/nl.json").SetCulture("nl").LoadCldrData(new string[] { "wwwroot/cldr-data/main/nl/ca-gregorian.json", "wwwroot/cldr-data/main/nl/timeZoneNames.json", "wwwroot/cldr-data/main/nl/numbers.json" });
        // this.JsRuntime.Ejs().LoadLocaleData("wwwroot/ej2-locale/src/ar.json").SetCulture("ar").LoadCldrData(new string[] { "wwwroot/cldr-data/main/ar/ca-gregorian.json", "wwwroot/cldr-data/main/ar/timeZoneNames.json", "wwwroot/cldr-data/main/ar/numbers.json" });
    }



#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.HenE_BlazorComponent.Pages.Bootstrap
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateSfInPlaceEditor_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0)
        {
        __builder.OpenComponent<global::Syncfusion.Blazor.InPlaceEditor.SfInPlaceEditor<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateSfDateTimePicker_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1)
        {
        __builder.OpenComponent<global::Syncfusion.Blazor.Calendars.SfDateTimePicker<TValue>>(seq);
        __builder.AddAttribute(__seq0, "CssClass", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateSfDateTimePicker_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1)
        {
        __builder.OpenComponent<global::Syncfusion.Blazor.Calendars.SfDateTimePicker<TValue>>(seq);
        __builder.AddAttribute(__seq0, "CssClass", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591