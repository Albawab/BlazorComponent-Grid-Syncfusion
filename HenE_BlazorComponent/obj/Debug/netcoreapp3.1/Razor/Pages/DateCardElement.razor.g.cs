#pragma checksum "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\DateCardElement.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7cc01ad3fdc9d4f34c506626694153fea594bcf"
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
#line 12 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.EJ2.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.EJ2.Blazor.InPlaceEditor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.EJ2.Blazor.Inputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.EJ2.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.EJ2.Blazor.Calendars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.EJ2.Blazor.RichTextEditor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.EJ2.Blazor.SplitButtons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.EJ2.Blazor.CircularGauge;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.EJ2.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.EJ2.Blazor.Navigations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.EJ2.Blazor.Schedule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.EJ2.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.EJ2.Blazor.Popups;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.EJ2.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.EJ2.Blazor.Data;

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
using Syncfusion.EJ2.Blazor.Notifications;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.EJ2.Blazor.Lists;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\DateCardElement.razor"
using HenE_BlazorComponent.Data;

#line default
#line hidden
#nullable disable
    public partial class DateCardElement : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "span");
            __builder.AddAttribute(1, "class", "d-flex" + " col-" + (
#nullable restore
#line 3 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\DateCardElement.razor"
                             dateCardElement.Columns

#line default
#line hidden
#nullable disable
            ) + " " + (
#nullable restore
#line 3 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\DateCardElement.razor"
                                                      HAlign

#line default
#line hidden
#nullable disable
            ) + " " + (
#nullable restore
#line 3 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\DateCardElement.razor"
                                                              VAlign

#line default
#line hidden
#nullable disable
            ) + " ");
            __builder.AddMarkupContent(2, "\r\n        ");
            __Blazor.HenE_BlazorComponent.Pages.DateCardElement.TypeInference.CreateEjsDateTimePicker_0(__builder, 3, 4, "col-6", 5, 
#nullable restore
#line 4 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\DateCardElement.razor"
                                                    DateTime.Now

#line default
#line hidden
#nullable disable
            , 6, 
#nullable restore
#line 4 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\DateCardElement.razor"
                                                                        dateCardElement.MinDate

#line default
#line hidden
#nullable disable
            , 7, 
#nullable restore
#line 4 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\DateCardElement.razor"
                                                                                                       dateCardElement.MaxDate

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 7 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\DateCardElement.razor"
       
    [Parameter]
    public CardDateElement dateCardElement { get; set; }
    
    [Inject]
    protected IJSRuntime JsRuntime {get;set;}

    public string HAlign
    {
        get
        {
            return $"justify-content-{@dateCardElement.HorizontalAlign.ToBootstrap()}";
        }
    }
    public string VAlign
    {
        get
        {
            return $"align-items-{dateCardElement.VerticalAlign.ToBootstrap()}";
        }
    }
        protected override void OnAfterRender(bool firstRender)
    {
        this.JsRuntime.Ejs().LoadLocaleData("wwwroot/ej2-locale/src/nl.json").SetCulture("nl").LoadCldrData(new string[] { "wwwroot/cldr-data/main/nl/ca-gregorian.json", "wwwroot/cldr-data/main/nl/timeZoneNames.json", "wwwroot/cldr-data/main/nl/numbers.json" });
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.HenE_BlazorComponent.Pages.DateCardElement
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateEjsDateTimePicker_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1, int __seq2, global::System.DateTime __arg2, int __seq3, global::System.DateTime __arg3)
        {
        __builder.OpenComponent<global::Syncfusion.EJ2.Blazor.Calendars.EjsDateTimePicker<TValue>>(seq);
        __builder.AddAttribute(__seq0, "CssClass", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "Min", __arg2);
        __builder.AddAttribute(__seq3, "Max", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
