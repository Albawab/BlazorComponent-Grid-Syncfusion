#pragma checksum "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Oefenen\InPlaceEditor.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa79b6a21ec9ddc0a2c5a3b08f8bd7b7914eaf73"
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
#line 10 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using HenE_BlazorComponent.Data;

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
#line 22 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.EJ2.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.EJ2.Blazor.Popups;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.EJ2.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using Syncfusion.EJ2.Blazor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using HenE_BlazorComponent.Enumeration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\_Imports.razor"
using HenE_BlazorComponent.Controller;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/inPlaceEditor")]
    public partial class InPlaceEditor : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>InPlaceEditor</h1>\r\n\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<h2 style=\"color:red\">popup</h2>\r\n    ");
            __Blazor.HenE_BlazorComponent.Pages.Oefenen.InPlaceEditor.TypeInference.CreateEjsInPlaceEditor_0(__builder, 4, 5, 
#nullable restore
#line 7 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Oefenen\InPlaceEditor.razor"
                            RenderMode.Popup

#line default
#line hidden
#nullable disable
            , 6, 
#nullable restore
#line 7 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Oefenen\InPlaceEditor.razor"
                                                    InputType.AutoComplete

#line default
#line hidden
#nullable disable
            , 7, 
#nullable restore
#line 7 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Oefenen\InPlaceEditor.razor"
                                                                                    AutoValue

#line default
#line hidden
#nullable disable
            , 8, 
#nullable restore
#line 7 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Oefenen\InPlaceEditor.razor"
                                                                                                       AutocompleteData

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(9, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n\r\n<br>\r\n<hr>\r\n");
            __builder.OpenElement(11, "div");
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.AddMarkupContent(13, "<h2 style=\"color:red\">DropDownList</h2>\r\n    ");
            __Blazor.HenE_BlazorComponent.Pages.Oefenen.InPlaceEditor.TypeInference.CreateEjsInPlaceEditor_1(__builder, 14, 15, 
#nullable restore
#line 15 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Oefenen\InPlaceEditor.razor"
                            RenderMode.Inline

#line default
#line hidden
#nullable disable
            , 16, 
#nullable restore
#line 15 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Oefenen\InPlaceEditor.razor"
                                                     InputType.DropDownList

#line default
#line hidden
#nullable disable
            , 17, 
#nullable restore
#line 15 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Oefenen\InPlaceEditor.razor"
                                                                                     DropdownValue

#line default
#line hidden
#nullable disable
            , 18, 
#nullable restore
#line 15 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Oefenen\InPlaceEditor.razor"
                                                                                                            AutocompleteData

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(19, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n\r\n<br>\r\n<hr>\r\n");
            __builder.OpenElement(21, "div");
            __builder.AddMarkupContent(22, "\r\n    ");
            __builder.AddMarkupContent(23, "<h2 style=\"color:red\">Buttons</h2>\r\n    ");
            __Blazor.HenE_BlazorComponent.Pages.Oefenen.InPlaceEditor.TypeInference.CreateEjsInPlaceEditor_2(__builder, 24, 25, 
#nullable restore
#line 22 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Oefenen\InPlaceEditor.razor"
                            RenderMode.Inline

#line default
#line hidden
#nullable disable
            , 26, 
#nullable restore
#line 22 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Oefenen\InPlaceEditor.razor"
                                                     InputType.Text

#line default
#line hidden
#nullable disable
            , 27, 
#nullable restore
#line 22 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Oefenen\InPlaceEditor.razor"
                                                                            AutoValue

#line default
#line hidden
#nullable disable
            , 28, 
#nullable restore
#line 22 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Oefenen\InPlaceEditor.razor"
                                                                                                   SaveBtn

#line default
#line hidden
#nullable disable
            , 29, 
#nullable restore
#line 22 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Oefenen\InPlaceEditor.razor"
                                                                                                                          CancelBtn

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(30, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n\r\n<br>\r\n<hr>\r\n");
            __builder.OpenElement(32, "div");
            __builder.AddMarkupContent(33, "\r\n    ");
            __builder.AddMarkupContent(34, "<h2 style=\"color:red\">Server</h2>\r\n    ");
            __builder.OpenElement(35, "table");
            __builder.AddAttribute(36, "class", "table-section");
            __builder.AddMarkupContent(37, "\r\n        ");
            __builder.OpenElement(38, "tr");
            __builder.AddMarkupContent(39, "\r\n            ");
            __builder.AddMarkupContent(40, "<td class=\"sample-td\"> Enter your name: </td>\r\n            ");
            __builder.OpenElement(41, "td");
            __builder.AddAttribute(42, "class", "sample-td");
            __builder.AddMarkupContent(43, "\r\n                ");
            __Blazor.HenE_BlazorComponent.Pages.Oefenen.InPlaceEditor.TypeInference.CreateEjsInPlaceEditor_3(__builder, 44, 45, "Skill", 46, "https://ej2services.syncfusion.com/development/web-services/api/Editor/UpdateData", 47, "FrameWork", 48, 
#nullable restore
#line 34 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Oefenen\InPlaceEditor.razor"
                                                                                                                                                                       AdaptorType.UrlAdaptor

#line default
#line hidden
#nullable disable
            , 49, 
#nullable restore
#line 34 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Oefenen\InPlaceEditor.razor"
                                                                                                                                                                                                     RenderMode.Inline

#line default
#line hidden
#nullable disable
            , 50, 
#nullable restore
#line 34 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Oefenen\InPlaceEditor.razor"
                                                                                                                                                                                                                                        true

#line default
#line hidden
#nullable disable
            , 51, 
#nullable restore
#line 34 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Oefenen\InPlaceEditor.razor"
                                                                                                                                                                                                                                                    InputType.MultiSelect

#line default
#line hidden
#nullable disable
            , 52, 
#nullable restore
#line 34 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Oefenen\InPlaceEditor.razor"
                                                                                                                                                                                                                                                                                  MultiSelectValue

#line default
#line hidden
#nullable disable
            , 53, 
#nullable restore
#line 34 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Oefenen\InPlaceEditor.razor"
                                                                                                                                                                                                                                                                                                                   true

#line default
#line hidden
#nullable disable
            , 54, 
#nullable restore
#line 34 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Oefenen\InPlaceEditor.razor"
                                                                                                                                                                                                                                                                                                                                MultiSelectData

#line default
#line hidden
#nullable disable
            , 55, (__builder2) => {
                __builder2.AddMarkupContent(56, "\r\n                    ");
                __builder2.OpenComponent<Syncfusion.EJ2.Blazor.InPlaceEditor.InPlaceEditorEvents<string>>(57);
                __builder2.AddAttribute(58, "OnActionSuccess", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.EJ2.Blazor.InPlaceEditor.ActionEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.EJ2.Blazor.InPlaceEditor.ActionEventArgs>(this, 
#nullable restore
#line 35 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Oefenen\InPlaceEditor.razor"
                                                          OnSuccess

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(59, "\r\n                ");
            }
            );
            __builder.AddMarkupContent(60, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n\r\n<br>\r\n<hr>\r\n");
            __builder.OpenElement(65, "div");
            __builder.AddMarkupContent(66, "\r\n    ");
            __builder.AddMarkupContent(67, "<h2 style=\"color:red\">Validation</h2>\r\n    ");
            __builder.OpenElement(68, "table");
            __builder.AddAttribute(69, "class", "table-section");
            __builder.AddMarkupContent(70, "\r\n        ");
            __builder.OpenElement(71, "tr");
            __builder.AddMarkupContent(72, "\r\n            ");
            __builder.AddMarkupContent(73, "<td> Default Error Message </td>\r\n            ");
            __builder.OpenElement(74, "td");
            __builder.AddMarkupContent(75, "\r\n                ");
            __builder.OpenComponent<Syncfusion.EJ2.Blazor.InPlaceEditor.EjsInPlaceEditor<string>>(76);
            __builder.AddAttribute(77, "Mode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.EJ2.Blazor.InPlaceEditor.RenderMode>(
#nullable restore
#line 50 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Oefenen\InPlaceEditor.razor"
                                        RenderMode.Inline

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(78, "EmptyText", "dd/mm/yyyy");
            __builder.AddAttribute(79, "Name", "Today");
            __builder.AddAttribute(80, "ValidationRules", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 50 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Oefenen\InPlaceEditor.razor"
                                                                                                                Validate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(81, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.EJ2.Blazor.InPlaceEditor.InputType>(
#nullable restore
#line 50 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Oefenen\InPlaceEditor.razor"
                                                                                                                                InputType.Date

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(82, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 50 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Oefenen\InPlaceEditor.razor"
                                                                                                                                                       DateModel

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(83, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n        ");
            __builder.OpenElement(86, "tr");
            __builder.AddMarkupContent(87, "\r\n            ");
            __builder.AddMarkupContent(88, "<td> Customized Error Message </td>\r\n            ");
            __builder.OpenElement(89, "td");
            __builder.AddMarkupContent(90, "\r\n                ");
            __builder.OpenComponent<Syncfusion.EJ2.Blazor.InPlaceEditor.EjsInPlaceEditor<string>>(91);
            __builder.AddAttribute(92, "Mode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.EJ2.Blazor.InPlaceEditor.RenderMode>(
#nullable restore
#line 57 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Oefenen\InPlaceEditor.razor"
                                        RenderMode.Inline

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(93, "EmptyText", "dd/mm/yyyy");
            __builder.AddAttribute(94, "Name", "TodayCustom");
            __builder.AddAttribute(95, "ValidationRules", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 57 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Oefenen\InPlaceEditor.razor"
                                                                                                                      Validation

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(96, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.EJ2.Blazor.InPlaceEditor.InputType>(
#nullable restore
#line 57 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Oefenen\InPlaceEditor.razor"
                                                                                                                                        InputType.Date

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(97, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 57 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Oefenen\InPlaceEditor.razor"
                                                                                                                                                               DateModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(98, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(99, "\r\n                    ");
                __builder2.OpenComponent<Syncfusion.EJ2.Blazor.InPlaceEditor.InPlaceEditorEvents<string>>(100);
                __builder2.AddAttribute(101, "Validating", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.EJ2.Blazor.InPlaceEditor.ValidateEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.EJ2.Blazor.InPlaceEditor.ValidateEventArgs>(this, 
#nullable restore
#line 58 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Oefenen\InPlaceEditor.razor"
                                                     OnValidation

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(102, "\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(103, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 65 "C:\Users\AbdulAbdulbawab\Desktop\Sharp\00 Blazor\04 BlazorComponent\HenE_BlazorComponent\Pages\Oefenen\InPlaceEditor.razor"
       
    public string AutoValue = "Australia";
    public string DropdownValue = "Australia";
        public string[] MultiSelectValue = new string[] { "JavaScript", "jQuery" };

    public AutoCompleteModel<string> AutocompleteData = new AutoCompleteModel<string>()
    {
        Placeholder = "Type to search countries",
        DataSource = new string[] { "Australia", "Bermuda", "Canada", "Cameroon", "Denmark", "Finland", "Greenland", "Poland" }
    };
    public ButtonModel SaveBtn = new ButtonModel()
    {
        Content = "OK",
        CssClass = "e-outline"
    };

        public MultiSelectModel<string> MultiSelectData = new MultiSelectModel<string>()
    {
        Placeholder = "Select skill",
        Mode = VisualMode.Box,
        DataSource = new string[] { "Android", "JavaScript", "jQuery", "TypeScript", "Angular", "React", "Vue", "Ionic" }
    };
    public ButtonModel CancelBtn = new ButtonModel()
    {
        Content = "Cancel",
        CssClass = "e-outline"
    };

        public void OnSuccess(ActionEventArgs args)
    {
        Console.WriteLine("Event is triggered");
    }


        public DatePickerModel DateModel = new DatePickerModel()
    {
        Placeholder = "Select date"
    };
    public object Validate = new
    {
        Today = new { required = true }
    };
    public object Validation = new
    {
        TodayCustom = new { required = true }
    };
        private void OnValidation(ValidateEventArgs args)
    {
        args.ErrorMessage = "Field should not be empty";
    }


#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.HenE_BlazorComponent.Pages.Oefenen.InPlaceEditor
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateEjsInPlaceEditor_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::Syncfusion.EJ2.Blazor.InPlaceEditor.RenderMode __arg0, int __seq1, global::Syncfusion.EJ2.Blazor.InPlaceEditor.InputType __arg1, int __seq2, TValue __arg2, int __seq3, global::System.Object __arg3)
        {
        __builder.OpenComponent<global::Syncfusion.EJ2.Blazor.InPlaceEditor.EjsInPlaceEditor<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Mode", __arg0);
        __builder.AddAttribute(__seq1, "Type", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "Model", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateEjsInPlaceEditor_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::Syncfusion.EJ2.Blazor.InPlaceEditor.RenderMode __arg0, int __seq1, global::Syncfusion.EJ2.Blazor.InPlaceEditor.InputType __arg1, int __seq2, TValue __arg2, int __seq3, global::System.Object __arg3)
        {
        __builder.OpenComponent<global::Syncfusion.EJ2.Blazor.InPlaceEditor.EjsInPlaceEditor<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Mode", __arg0);
        __builder.AddAttribute(__seq1, "Type", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "Model", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateEjsInPlaceEditor_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::Syncfusion.EJ2.Blazor.InPlaceEditor.RenderMode __arg0, int __seq1, global::Syncfusion.EJ2.Blazor.InPlaceEditor.InputType __arg1, int __seq2, TValue __arg2, int __seq3, global::System.Object __arg3, int __seq4, global::System.Object __arg4)
        {
        __builder.OpenComponent<global::Syncfusion.EJ2.Blazor.InPlaceEditor.EjsInPlaceEditor<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Mode", __arg0);
        __builder.AddAttribute(__seq1, "Type", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "SaveButton", __arg3);
        __builder.AddAttribute(__seq4, "CancelButton", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateEjsInPlaceEditor_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::Syncfusion.EJ2.Blazor.InPlaceEditor.AdaptorType __arg3, int __seq4, global::Syncfusion.EJ2.Blazor.InPlaceEditor.RenderMode __arg4, int __seq5, global::System.Boolean __arg5, int __seq6, global::Syncfusion.EJ2.Blazor.InPlaceEditor.InputType __arg6, int __seq7, TValue __arg7, int __seq8, global::System.Boolean __arg8, int __seq9, global::System.Object __arg9, int __seq10, global::Microsoft.AspNetCore.Components.RenderFragment __arg10)
        {
        __builder.OpenComponent<global::Syncfusion.EJ2.Blazor.InPlaceEditor.EjsInPlaceEditor<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Name", __arg0);
        __builder.AddAttribute(__seq1, "Url", __arg1);
        __builder.AddAttribute(__seq2, "PrimaryKey", __arg2);
        __builder.AddAttribute(__seq3, "Adaptor", __arg3);
        __builder.AddAttribute(__seq4, "Mode", __arg4);
        __builder.AddAttribute(__seq5, "EnableEditMode", __arg5);
        __builder.AddAttribute(__seq6, "Type", __arg6);
        __builder.AddAttribute(__seq7, "Value", __arg7);
        __builder.AddAttribute(__seq8, "SubmitOnEnter", __arg8);
        __builder.AddAttribute(__seq9, "Model", __arg9);
        __builder.AddAttribute(__seq10, "ChildContent", __arg10);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591