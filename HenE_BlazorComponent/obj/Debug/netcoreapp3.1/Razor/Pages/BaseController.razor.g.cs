#pragma checksum "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\BaseController.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae458c2359a9cb875ee1d7c7b5e928f369c35f2a"
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
#line 16 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.Blazor.Calendars;

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
#line 2 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\BaseController.razor"
using HenE_BlazorComponent.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\BaseController.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/base")]
    public partial class BaseController : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container-fluid");
            __builder.AddMarkupContent(2, "\n");
#nullable restore
#line 6 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\BaseController.razor"
     foreach (var cardElements in CardElentsGrouping)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "        ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "row");
            __builder.AddMarkupContent(6, "\n");
#nullable restore
#line 9 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\BaseController.razor"
             foreach (CardElement cardElement in cardElements)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\BaseController.razor"
                 switch (cardElement.Soort)
                {
                    case SoortCardElementen.CircularGauge:

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "                        ");
            __builder.OpenComponent<HenE_BlazorComponent.Pages.CircularGaugeElement>(8);
            __builder.AddAttribute(9, "CardCircularGaugeElement", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<HenE_BlazorComponent.Data.CardCircularGaugeElement>(
#nullable restore
#line 14 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\BaseController.razor"
                                                                       (CardCircularGaugeElement)cardElement

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(10, "\n");
#nullable restore
#line 15 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\BaseController.razor"
                        break;
                    case SoortCardElementen.Chart:

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "                        ");
            __builder.OpenComponent<HenE_BlazorComponent.Pages.ChartElement>(12);
            __builder.AddAttribute(13, "CardChartElement", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<HenE_BlazorComponent.Data.CardChartElement>(
#nullable restore
#line 17 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\BaseController.razor"
                                                       (CardChartElement)cardElement

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(14, "\n");
#nullable restore
#line 18 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\BaseController.razor"
                        break;
                    case SoortCardElementen.Label:

#line default
#line hidden
#nullable disable
            __builder.AddContent(15, "                        ");
            __builder.OpenComponent<HenE_BlazorComponent.Pages.LabelCardElement>(16);
            __builder.AddAttribute(17, "CardElement", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<HenE_BlazorComponent.Data.CardLabelElement>(
#nullable restore
#line 20 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\BaseController.razor"
                                                      (CardLabelElement)cardElement

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(18, "\n");
#nullable restore
#line 21 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\BaseController.razor"
                        break;
                    case SoortCardElementen.Text:

#line default
#line hidden
#nullable disable
            __builder.AddContent(19, "                        ");
            __builder.OpenComponent<HenE_BlazorComponent.Pages.TextCardElement>(20);
            __builder.AddAttribute(21, "CardElement", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<HenE_BlazorComponent.Data.CardTextElement>(
#nullable restore
#line 23 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\BaseController.razor"
                                                     (CardTextElement)cardElement

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(22, "\n");
#nullable restore
#line 24 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\BaseController.razor"
                        break;
                    case SoortCardElementen.Date:

#line default
#line hidden
#nullable disable
            __builder.AddContent(23, "                        ");
            __builder.OpenComponent<HenE_BlazorComponent.Pages.DateCardElement>(24);
            __builder.AddAttribute(25, "dateCardElement", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<HenE_BlazorComponent.Data.CardDateElement>(
#nullable restore
#line 26 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\BaseController.razor"
                                                         (CardDateElement)cardElement

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(26, "\n");
#nullable restore
#line 27 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\BaseController.razor"
                        break;
                    case SoortCardElementen.Button:

#line default
#line hidden
#nullable disable
            __builder.AddContent(27, "                        ");
            __builder.OpenComponent<HenE_BlazorComponent.Pages.ButtonCardElementen>(28);
            __builder.AddAttribute(29, "cardButtonElement", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<HenE_BlazorComponent.Data.CardButtonElement>(
#nullable restore
#line 29 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\BaseController.razor"
                                                               (CardButtonElement)cardElement

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "MouseClicked", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\BaseController.razor"
                                                                                                             ChangeValue

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(31, "\n");
#nullable restore
#line 30 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\BaseController.razor"
                        break;
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\BaseController.razor"
                 
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(32, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\n");
#nullable restore
#line 34 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\BaseController.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\BaseController.razor"
      
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
                 Value = CircularGauge,
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
                 Value = CircularGauge,
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