#pragma checksum "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Formulier\FormulierElement.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3051e8ebae1e7bf234932bac490f0412efac94b"
// <auto-generated/>
#pragma warning disable 1591
namespace HenE_BlazorComponent.Pages.Formulier
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
    public partial class FormulierElement : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "section");
            __builder.AddAttribute(1, "class", "row");
            __builder.AddMarkupContent(2, "\r\n\r\n");
#nullable restore
#line 3 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Formulier\FormulierElement.razor"
     if (SectionKinderenGroup != null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "        ");
            __builder.OpenElement(4, "label");
            __builder.AddAttribute(5, "class", "row" + " col-" + (
#nullable restore
#line 5 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Formulier\FormulierElement.razor"
                               Section.Columns

#line default
#line hidden
#nullable disable
            ) + " offset-" + (
#nullable restore
#line 5 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Formulier\FormulierElement.razor"
                                                       Section.Column

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "id", 
#nullable restore
#line 5 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Formulier\FormulierElement.razor"
                                                                            Section.SectionNumber

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(7, "\r\n            ");
            __builder.OpenElement(8, "label");
            __builder.AddAttribute(9, "class", "border border-dark bg-dark text-light m-1 col-1");
            __builder.AddAttribute(10, "style", "height:30px");
            __builder.AddContent(11, 
#nullable restore
#line 6 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Formulier\FormulierElement.razor"
                                                                                                Section.SectionNumber

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n            ");
            __builder.OpenElement(13, "label");
            __builder.AddAttribute(14, "class", "border border-dark bg-dark text-light m-1 col-10");
            __builder.AddAttribute(15, "style", "height:30px");
            __builder.AddContent(16, 
#nullable restore
#line 7 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Formulier\FormulierElement.razor"
                                                                                                 Section.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n");
#nullable restore
#line 10 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Formulier\FormulierElement.razor"
         foreach (dynamic elementGroup in SectionKinderenGroup)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(19, "            ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "row col-12 m-2");
            __builder.AddMarkupContent(22, "\r\n");
#nullable restore
#line 13 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Formulier\FormulierElement.razor"
                 foreach (dynamic element in elementGroup)
                {

                    if (element.GetType() == typeof(FormulierVraag))
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(23, "                    ");
            __builder.OpenComponent<HenE_BlazorComponent.Pages.Formulier.FormulierElementVraag>(24);
            __builder.AddAttribute(25, "ElementVraag", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<HenE_BlazorComponent.Data.FormulierVraag>(
#nullable restore
#line 18 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Formulier\FormulierElement.razor"
                                                        (FormulierVraag)element

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(26, "\r\n");
#nullable restore
#line 19 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Formulier\FormulierElement.razor"
                    }
                    else if (element.GetType() == typeof(FormulierAntwoord))
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(27, "                    ");
            __builder.OpenComponent<HenE_BlazorComponent.Pages.Formulier.FormulierElementAntwoord>(28);
            __builder.AddAttribute(29, "formulierAntwoord", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<HenE_BlazorComponent.Data.FormulierAntwoord>(
#nullable restore
#line 22 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Formulier\FormulierElement.razor"
                                                                  element

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(30, "\r\n");
#nullable restore
#line 23 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Formulier\FormulierElement.razor"
                    }
                    else if (element.GetType() == typeof(FormulierSpecificatie))
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(31, "                    ");
            __builder.OpenComponent<HenE_BlazorComponent.Pages.Formulier.FormulierElementSpicifecatie>(32);
            __builder.AddAttribute(33, "Specificatie", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<HenE_BlazorComponent.Data.FormulierSpecificatie>(
#nullable restore
#line 26 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Formulier\FormulierElement.razor"
                                                                 element

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(34, "\r\n");
#nullable restore
#line 27 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Formulier\FormulierElement.razor"
                    }
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(35, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n");
#nullable restore
#line 30 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Formulier\FormulierElement.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Formulier\FormulierElement.razor"
         
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Formulier\FormulierElement.razor"
       
    [Parameter]
    public FormulierSectie Section { get; set; }

    dynamic SectionKinderenGroup;

    protected override void OnInitialized()
    {
        if (Section.SectionKinderen != null)
        {
            SectionKinderenGroup = Section.SectionKinderen.GroupBy(G => G.Row);
        }

    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
