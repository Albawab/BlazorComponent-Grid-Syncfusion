#pragma checksum "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98a37ca07dbedddf0a2b5b191d8f9773033bab0c"
// <auto-generated/>
#pragma warning disable 1591
namespace HenE_BlazorComponent.Shared
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
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-row pl-4 navbar");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<a class=\"navbar-brand\" href>BlazorComponent</a>\r\n    ");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "navbar-toggler");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 4 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Shared\NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(7, "\r\n        <span class=\"navbar-toggler-icon\"></span>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", (
#nullable restore
#line 9 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Shared\NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
#nullable disable
            ) + " list-group" + " collapse");
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Shared\NavMenu.razor"
                                                            ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.OpenElement(14, "ol");
            __builder.AddAttribute(15, "class", "nav");
            __builder.AddAttribute(16, "style", "overflow:visible");
            __builder.AddMarkupContent(17, "\r\n        ");
            __builder.OpenElement(18, "li");
            __builder.AddAttribute(19, "class", "nav-item");
            __builder.AddMarkupContent(20, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(21);
            __builder.AddAttribute(22, "class", "nav-link");
            __builder.AddAttribute(23, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Shared\NavMenu.razor"
                                                ToggleDataList

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "style", "font-size:18px");
            __builder.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(26, "\r\n\r\n                <span aria-hidden=\"true\"></span>");
                __builder2.AddContent(27, 
#nullable restore
#line 14 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Shared\NavMenu.razor"
                                                 formulier.Titel

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(28, "\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(29, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n");
#nullable restore
#line 17 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Shared\NavMenu.razor"
         if (formulierElementenGroup != null)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Shared\NavMenu.razor"
             foreach (var sections in formulierElementenGroup)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Shared\NavMenu.razor"
                 foreach (FormulierSectie section in sections)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(31, "                    ");
            __builder.OpenElement(32, "li");
            __builder.AddAttribute(33, "class", "custom active pl-3 border-bottom list-unstyled");
            __builder.AddAttribute(34, "style", "font-size:medium");
            __builder.AddAttribute(35, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Shared\NavMenu.razor"
                                                                                                                    ()=>GetHashTagName(section)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(36, "\r\n");
#nullable restore
#line 24 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Shared\NavMenu.razor"
                         if (section is FormulierSectie)
                        {
                            FormulierSectie sectie = (FormulierSectie)section;

#line default
#line hidden
#nullable disable
            __builder.AddContent(37, "                            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(38);
            __builder.AddAttribute(39, "class", "nav-link");
            __builder.AddAttribute(40, "href", 
#nullable restore
#line 27 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Shared\NavMenu.razor"
                                                             GetUrl(section)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(41, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 27 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Shared\NavMenu.razor"
                                                                                     NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(42, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(43, "\r\n                                ");
                __builder2.OpenElement(44, "span");
                __builder2.AddAttribute(45, "class", "text-light");
                __builder2.AddAttribute(46, "aria-hidden", "true");
                __builder2.AddAttribute(47, "style", "font-size:13px");
                __builder2.AddMarkupContent(48, "\r\n                                    ");
                __builder2.AddContent(49, 
#nullable restore
#line 29 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Shared\NavMenu.razor"
                                      sectie.Title

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(50, "\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n                            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(52, "\r\n");
#nullable restore
#line 32 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Shared\NavMenu.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(53, "                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n");
#nullable restore
#line 34 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Shared\NavMenu.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Shared\NavMenu.razor"
                 
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Shared\NavMenu.razor"
             
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(55, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n\r\n\r\n");
            __builder.AddMarkupContent(58, "<style>\r\n\r\n    .custom {\r\n        width: 100%;\r\n        opacity:0.7;\r\n    }\r\n</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 125 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;
    FormulierController controller = new FormulierController();
    Formulier formulier;
    dynamic formulierElementenGroup { get; set; }
    public ExpandOnSettings Expand = ExpandOnSettings.Click;
    string HashTagName = "#0";

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    protected override void OnInitialized()
    {
        FormulierController controller = new FormulierController();
        formulier = controller.GetData(1);
    }


    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
        StateHasChanged();

    }

    private void ToggleDataList()
    {
        if (formulierElementenGroup == null)
        {

            formulierElementenGroup = formulier.Kinderen.GroupBy(G => G.Row).OrderBy(O => O.Key).ToArray();
        }
        else
        {
            formulierElementenGroup = null;
        }

        StateHasChanged();

    }

    private void GetHashTagName(FormulierSectie item)
    {
        if (item is FormulierSectie)
        {
            FormulierSectie sectie = (FormulierSectie)item;
            HashTagName = "#" + sectie.SectionNumber.ToString();
        }
        StateHasChanged();
    }

    private string GetUrl(FormulierSectie item)
    {
        if (item is FormulierSectie)
        {
            FormulierSectie sectie = (FormulierSectie)item;
            HashTagName = "#" + sectie.SectionNumber.ToString();
        }
        return HashTagName;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
