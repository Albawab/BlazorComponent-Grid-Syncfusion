#pragma checksum "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\BaseController.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87f772e716a41296ec36bfd3c008492cdb1bc637"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
using HenE_BlazorComponent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using HenE_BlazorComponent.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.EJ2.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.EJ2.Blazor.InPlaceEditor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.EJ2.Blazor.Inputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.EJ2.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.EJ2.Blazor.Calendars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.EJ2.Blazor.RichTextEditor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.EJ2.Blazor.SplitButtons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.EJ2.Blazor.CircularGauge;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.EJ2.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.EJ2.Blazor.Navigations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.EJ2.Blazor.Schedule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\BaseController.razor"
using HenE_BlazorComponent.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\BaseController.razor"
using HenE_BlazorComponent.Enumeration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\BaseController.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class BaseController : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\BaseController.razor"
      
    private List<CardElement> cardElements;
    private List<CardElement> cardElementsOrderBy;
    int CircularGauge { get; set; }

    dynamic CardElentsGrouping;

    protected override void OnInitialized()
    {
        cardElements = new List<CardElement>()
{
            new CardLabelElement {
                Row = 3,
                Column = 1,
                Rows = 1,
                Columns = 2,
                Title = "Hallo",
                Type = CardLabelSoorten.Nadruk,
                HorizontalAlign = HorizontalAlign.Right,
                VerticalAlign = VerticalAlign.Bottom,
            },
              new CardLabelElement {
                Row = 4,
                Column = 1,
                Rows = 1,
                Columns = 2,
                Title = "Dag",
                Type = CardLabelSoorten.Kop,

            },
              new CardLabelElement {
                Row = 3,
                Column = 1,
                Rows = 5,
                Columns = 2,
                Title = "Abdul",
            },
              new CardTextElement
              {
                  Row = 5,
                  Column = 2,
                  Columns = 4,
                  Rows = 4,
                  MaxLength = 20,
                  Type = TextBoxTypes.Password,
                  Placeholder = "Password",
                  Soort = SoortCardElementen.Text,
                  HorizontalAlign = HorizontalAlign.Left,
                  VerticalAlign = VerticalAlign.Center,
             },
             new CardTextElement
              {
                  Row = 6,
                  Column = 2,
                  Columns = 4,
                  Rows = 4,
                  MaxLength = 20,
                  Type = TextBoxTypes.Email,
                  Placeholder = "Email",
                  Soort = SoortCardElementen.Text,
                  HorizontalAlign = HorizontalAlign.Left,
                  VerticalAlign = VerticalAlign.Center,
        },
             new CardDateElement
             {
                 Row =7,
                 Column =2,
                 Columns= 4,
                 Rows=5,
                 Soort = SoortCardElementen.Date,
                 HorizontalAlign = HorizontalAlign.Right,
                 VerticalAlign = VerticalAlign.Bottom,
                 MinDate = new DateTime(2000, 01, 01,00,00,00),
                 MaxDate = new DateTime(DateTime.Now.Year + 10, 12, 31,23,59,59),
                 Date = DateTime.Now
             },
             new CardButtonElement
             {
                 Row =8,
                 Column =2,
                 Columns= 12,
                 Rows=5,
                 Soort = SoortCardElementen.Button,
                 ButtonSpinPosition = ButtonSpinPosition.Top,
                 ButtonAnimationEffect = ButtonAnimationEffect.SlideLeft,
             },
             new CardCircularGaugeElement
             {
                 Row =0,
                 Column=0,
                 Columns = 6,
                 Rows =4,
                 StartAngle = 230,
                 EndAngle = 130,
                 Soort = SoortCardElementen.CircularGauge,
                 HorizontalAlign = HorizontalAlign.Center,
                 VerticalAlign = VerticalAlign.Center,
                 value = CircularGauge,
             },
             new CardCircularGaugeElement
             {
                 Row =0,
                 Column=0,
                 Columns = 6,
                 Rows =4,
                 StartAngle = 230,
                 EndAngle = 130,
                 Soort = SoortCardElementen.CircularGauge,
                 HorizontalAlign = HorizontalAlign.Center,
                 VerticalAlign = VerticalAlign.Center,
                 value = CircularGauge,
             },
            new CardButtonElement
             {
                 Row =1,
                 Column =2,
                 Columns= 12,
                 Rows=5,
                 HorizontalAlign = HorizontalAlign.Center,
                 VerticalAlign = VerticalAlign.Center,
                 Soort = SoortCardElementen.Button,
                 ButtonSpinPosition = ButtonSpinPosition.Top,
                 ButtonAnimationEffect = ButtonAnimationEffect.SlideLeft,
             },
             new CardChartElement
             {
                 Row = 2,
                 Column = 0,
                 Columns=12,
                 Rows = 1,
                 Soort = SoortCardElementen.Chart,
        }
    };
        cardElementsOrderBy = cardElements.OrderBy(O => O.Row).ToList();

        CardElentsGrouping = cardElementsOrderBy.GroupBy(G => G.Row);


    }


    private void ChangeValue()
    {
        Thread.Sleep(2000);
        Random random = new Random();
        CircularGauge = random.Next(0, 100);
        OnInitialized();
        cardElementsOrderBy = cardElements.OrderBy(O => O.Row).ToList();
        CardElentsGrouping = cardElementsOrderBy.GroupBy(G => G.Row);

    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
