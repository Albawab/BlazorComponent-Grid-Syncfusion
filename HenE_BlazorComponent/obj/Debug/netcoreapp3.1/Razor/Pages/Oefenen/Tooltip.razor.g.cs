#pragma checksum "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Oefenen\Tooltip.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8710cd7d80d55581e053608ed7e9dac451c868df"
// <auto-generated/>
#pragma warning disable 1591
namespace HenE_BlazorComponent.Pages.Oefenen
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/tooltip")]
    public partial class Tooltip : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Tooltip</h3>\n\n");
            __builder.OpenElement(1, "div");
            __builder.AddMarkupContent(2, "\n    ");
            __builder.AddMarkupContent(3, "<h2 style=\"color:red\">Tooltip</h2>\n    ");
            __builder.OpenComponent<Syncfusion.Blazor.Popups.SfTooltip>(4);
            __builder.AddAttribute(5, "ID", "Tooltip");
            __builder.AddAttribute(6, "Content", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 6 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Oefenen\Tooltip.razor"
                                      Content

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "Target", "#btn");
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(9, "\n        ");
                __builder2.OpenComponent<Syncfusion.Blazor.Buttons.SfButton>(10);
                __builder2.AddAttribute(11, "ID", "btn");
                __builder2.AddAttribute(12, "Content", "Show Tooltip");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(14, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\n\n<br>\n<hr>\n");
            __builder.OpenElement(16, "div");
            __builder.AddMarkupContent(17, "\n    ");
            __builder.AddMarkupContent(18, "<h2 style=\"color:red\">Scroll mode</h2>\n    ");
            __builder.OpenComponent<Syncfusion.Blazor.Popups.SfTooltip>(19);
            __builder.AddAttribute(20, "ID", "tooltip");
            __builder.AddAttribute(21, "Height", "60px");
            __builder.AddAttribute(22, "Width", "200px");
            __builder.AddAttribute(23, "IsSticky", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 15 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Oefenen\Tooltip.razor"
                                                                  true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "Target", "#target");
            __builder.AddAttribute(25, "Content", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 15 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Oefenen\Tooltip.razor"
                                                                                                   ContentScroll

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(27, "\n        ");
                __builder2.AddMarkupContent(28, @"<div id=""container"">
            <p>
                A green home is a type of house designed to be
                <a id=""target"">
                    <u>environmentally friendly</u>
                </a> and sustainable. And also focuses on the efficient use of ""energy, water, and building materials."" As green homes
                have become more prevalent we have also seen the emergence of green affordable housing.
            </p>
        </div>
    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(29, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\n\n\n<br>\n<hr>\n");
            __builder.OpenElement(31, "div");
            __builder.AddMarkupContent(32, "\n    ");
            __builder.AddMarkupContent(33, "<h2 style=\"color:red\">Position Right</h2>\n\n    ");
            __builder.OpenComponent<Syncfusion.Blazor.Popups.SfTooltip>(34);
            __builder.AddAttribute(35, "Target", "#target");
            __builder.AddAttribute(36, "Content", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 34 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Oefenen\Tooltip.razor"
                                          Content

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(37, "Position", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Popups.Position>(
#nullable restore
#line 34 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Oefenen\Tooltip.razor"
                                                              Syncfusion.Blazor.Popups.Position.RightCenter

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(38, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(39, "\n        ");
                __builder2.OpenComponent<Syncfusion.Blazor.Buttons.SfButton>(40);
                __builder2.AddAttribute(41, "ID", "target");
                __builder2.AddAttribute(42, "Content", "Show Tooltip");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(43, "\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(44, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\n\n<br>\n<hr>\n");
            __builder.OpenElement(46, "div");
            __builder.AddMarkupContent(47, "\n    ");
            __builder.AddMarkupContent(48, "<h2 style=\"color:red\">Mouse trailing</h2>\n    ");
            __builder.OpenComponent<Syncfusion.Blazor.Popups.SfTooltip>(49);
            __builder.AddAttribute(50, "MouseTrail", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 43 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Oefenen\Tooltip.razor"
                          true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(51, "Content", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 43 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Oefenen\Tooltip.razor"
                                         Content

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(52, "Target", "#target");
            __builder.AddAttribute(53, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(54, "\n     ");
                __builder2.OpenComponent<Syncfusion.Blazor.Buttons.SfButton>(55);
                __builder2.AddAttribute(56, "ID", "target");
                __builder2.AddAttribute(57, "Content", "Show Tooltip");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(58, "\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(59, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\n\n<br>\n<hr>\n");
            __builder.OpenElement(61, "div");
            __builder.AddMarkupContent(62, "\n    ");
            __builder.AddMarkupContent(63, "<h2 style=\"color:red\">Focus</h2>\n    ");
            __builder.OpenComponent<Syncfusion.Blazor.Popups.SfTooltip>(64);
            __builder.AddAttribute(65, "ID", "tooltipfocus");
            __builder.AddAttribute(66, "Target", ".e-info");
            __builder.AddAttribute(67, "Content", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 52 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Oefenen\Tooltip.razor"
                                                            Content

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(68, "OpensOn", "Focus");
            __builder.AddAttribute(69, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(70, "\n        ");
                __builder2.AddMarkupContent(71, "<e-content-template>\n            <div class=\"blocks\"><span><input class=\"e-info\" type=\"text\" placeholder=\"Focus and blur\"></span></div>\n        </e-content-template>\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(72, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\n\n<br>\n<hr>\n");
            __builder.OpenElement(74, "div");
            __builder.AddMarkupContent(75, "\n    ");
            __builder.AddMarkupContent(76, "<h2 style=\"color:red\">Open or Close tooltip with delay</h2>\n    ");
            __builder.OpenComponent<Syncfusion.Blazor.Popups.SfTooltip>(77);
            __builder.AddAttribute(78, "Target", "#target");
            __builder.AddAttribute(79, "Content", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 63 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Oefenen\Tooltip.razor"
                                          Content

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(80, "OpenDelay", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 63 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Oefenen\Tooltip.razor"
                                                              1000

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(81, "CloseDelay", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 63 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Oefenen\Tooltip.razor"
                                                                                1000

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(82, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(83, "\n        ");
                __builder2.OpenComponent<Syncfusion.Blazor.Buttons.SfButton>(84);
                __builder2.AddAttribute(85, "ID", "target");
                __builder2.AddAttribute(86, "Content", "Show Tooltip");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(87, "\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(88, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\n\n\n");
            __builder.AddMarkupContent(90, @"<style>
    #tooltip {
        left: calc( 50% - 60px);
        top: 38%;
    }
    #target{
       background-color: #ececec;
        border: 1px solid #c8c8c8;
        box-sizing: border-box;
        margin: 80px auto;
        padding: 20px;
        width: 200px;
}
</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 68 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Oefenen\Tooltip.razor"
       
    object Content = "Lets go green & Save Earth !!";
      object ContentScroll = "<div><b>Environmentally friendly</b> or environment-friendly, (also referred to as eco-friendly, nature-friendly, and green) are marketing and sustainability terms referring to goods and services, laws, guidelines and policies that inflict reduced, minimal, or no harm upon ecosystems or the environment.</div>";

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
