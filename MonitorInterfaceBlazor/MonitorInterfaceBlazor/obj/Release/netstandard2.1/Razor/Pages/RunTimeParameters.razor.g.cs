#pragma checksum "C:\Users\q1440767\source\repos\MonitorInterfaceBlazor\MonitorInterfaceBlazor\Pages\RunTimeParameters.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4278b14d6260420cba6d96d5dd6d274bec7c5073"
// <auto-generated/>
#pragma warning disable 1591
namespace MonitorInterfaceBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\q1440767\source\repos\MonitorInterfaceBlazor\MonitorInterfaceBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\q1440767\source\repos\MonitorInterfaceBlazor\MonitorInterfaceBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\q1440767\source\repos\MonitorInterfaceBlazor\MonitorInterfaceBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\q1440767\source\repos\MonitorInterfaceBlazor\MonitorInterfaceBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\q1440767\source\repos\MonitorInterfaceBlazor\MonitorInterfaceBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\q1440767\source\repos\MonitorInterfaceBlazor\MonitorInterfaceBlazor\_Imports.razor"
using MonitorInterfaceBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\q1440767\source\repos\MonitorInterfaceBlazor\MonitorInterfaceBlazor\_Imports.razor"
using MonitorInterfaceBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\q1440767\source\repos\MonitorInterfaceBlazor\MonitorInterfaceBlazor\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\q1440767\source\repos\MonitorInterfaceBlazor\MonitorInterfaceBlazor\_Imports.razor"
using MonitorInterfaceBlazor.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/RuntimeParameters")]
    public partial class RunTimeParameters : RunTimeParametersBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 4 "C:\Users\q1440767\source\repos\MonitorInterfaceBlazor\MonitorInterfaceBlazor\Pages\RunTimeParameters.razor"
 if (results != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 6 "C:\Users\q1440767\source\repos\MonitorInterfaceBlazor\MonitorInterfaceBlazor\Pages\RunTimeParameters.razor"
                      results

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnInvalidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 6 "C:\Users\q1440767\source\repos\MonitorInterfaceBlazor\MonitorInterfaceBlazor\Pages\RunTimeParameters.razor"
                                                 HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n");
#nullable restore
#line 7 "C:\Users\q1440767\source\repos\MonitorInterfaceBlazor\MonitorInterfaceBlazor\Pages\RunTimeParameters.razor"
         foreach (var item in results.Where(i => i.JOB_NAME == jobSelected))
        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(6, "            ");
                __builder2.AddMarkupContent(7, "<label><strong>Edit Run Time Parameters for Current Job:</strong></label>\r\n            ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "currentJob");
                __builder2.AddMarkupContent(10, "\r\n                ");
                __builder2.OpenElement(11, "p");
                __builder2.AddAttribute(12, "class", "jobNameTitle");
                __builder2.OpenElement(13, "strong");
                __builder2.AddContent(14, 
#nullable restore
#line 11 "C:\Users\q1440767\source\repos\MonitorInterfaceBlazor\MonitorInterfaceBlazor\Pages\RunTimeParameters.razor"
                                                 item.JOB_NAME

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(15, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(16, "\r\n            ");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "runTimeParametersButtons");
                __builder2.AddMarkupContent(19, "\r\n                ");
                __builder2.OpenElement(20, "button");
                __builder2.AddAttribute(21, "type", "button");
                __builder2.AddAttribute(22, "class", "btn btn-danger");
                __builder2.AddAttribute(23, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\q1440767\source\repos\MonitorInterfaceBlazor\MonitorInterfaceBlazor\Pages\RunTimeParameters.razor"
                                                                       SaveChanges

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(24, "Save Changes");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n                ");
                __builder2.OpenElement(26, "button");
                __builder2.AddAttribute(27, "type", "button");
                __builder2.AddAttribute(28, "class", "btn btn-primary");
                __builder2.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\q1440767\source\repos\MonitorInterfaceBlazor\MonitorInterfaceBlazor\Pages\RunTimeParameters.razor"
                                                                        ResetParams

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(30, "Reset Parameters");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n                ");
                __builder2.OpenElement(32, "button");
                __builder2.AddAttribute(33, "type", "button");
                __builder2.AddAttribute(34, "class", "btn btn-primary");
                __builder2.AddAttribute(35, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\q1440767\source\repos\MonitorInterfaceBlazor\MonitorInterfaceBlazor\Pages\RunTimeParameters.razor"
                                                                        Cancel

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(36, "Exit");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n            ");
                __builder2.AddMarkupContent(39, "<label><strong>Run Time Parameters</strong></label>\r\n            ");
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "newRunTimeParametersForm");
                __builder2.AddMarkupContent(42, "\r\n                ");
                __builder2.OpenElement(43, "div");
                __builder2.AddAttribute(44, "class", "month");
                __builder2.AddMarkupContent(45, "\r\n                    ");
                __builder2.OpenElement(46, "div");
                __builder2.AddAttribute(47, "class", "monthCheckboxes");
                __builder2.AddMarkupContent(48, "\r\n                        ");
                __builder2.AddMarkupContent(49, "<label id=\"runTimeLabel\"><strong>Month</strong></label>\r\n                        ");
                __builder2.OpenElement(50, "ul");
                __builder2.AddMarkupContent(51, "\r\n                            ");
                __builder2.OpenElement(52, "li");
                __builder2.AddMarkupContent(53, "\r\n                                ");
                __builder2.OpenElement(54, "label");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(55);
                __builder2.AddAttribute(56, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "C:\Users\q1440767\source\repos\MonitorInterfaceBlazor\MonitorInterfaceBlazor\Pages\RunTimeParameters.razor"
                                                                                                                      () => init.CheckAllMonths(InitializeData.Months[0])

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(57, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 25 "C:\Users\q1440767\source\repos\MonitorInterfaceBlazor\MonitorInterfaceBlazor\Pages\RunTimeParameters.razor"
                                                                   InitializeData.Months[0].IsMonthChecked

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(58, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => InitializeData.Months[0].IsMonthChecked = __value, InitializeData.Months[0].IsMonthChecked))));
                __builder2.AddAttribute(59, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => InitializeData.Months[0].IsMonthChecked));
                __builder2.CloseComponent();
                __builder2.AddContent(60, 
#nullable restore
#line 25 "C:\Users\q1440767\source\repos\MonitorInterfaceBlazor\MonitorInterfaceBlazor\Pages\RunTimeParameters.razor"
                                                                                                                                                                              InitializeData.Months[0].MonthName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\r\n\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(62, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(63, "\r\n");
#nullable restore
#line 29 "C:\Users\q1440767\source\repos\MonitorInterfaceBlazor\MonitorInterfaceBlazor\Pages\RunTimeParameters.razor"
                          
                            for (var i = 1; i < InitializeData.Months.Count(); i++)
                            {
                                var j = i;

#line default
#line hidden
#nullable disable
                __builder2.AddContent(64, "                                ");
                __builder2.OpenElement(65, "ul");
                __builder2.AddAttribute(66, "class", "checkbox-grid");
                __builder2.AddMarkupContent(67, "\r\n                                    ");
                __builder2.OpenElement(68, "li");
                __builder2.AddMarkupContent(69, "\r\n                                        ");
                __builder2.OpenElement(70, "label");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(71);
                __builder2.AddAttribute(72, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "C:\Users\q1440767\source\repos\MonitorInterfaceBlazor\MonitorInterfaceBlazor\Pages\RunTimeParameters.razor"
                                                                                                                              () => init.CheckManualMonth(InitializeData.Months[j])

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(73, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 35 "C:\Users\q1440767\source\repos\MonitorInterfaceBlazor\MonitorInterfaceBlazor\Pages\RunTimeParameters.razor"
                                                                           InitializeData.Months[j].IsMonthChecked

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(74, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => InitializeData.Months[j].IsMonthChecked = __value, InitializeData.Months[j].IsMonthChecked))));
                __builder2.AddAttribute(75, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => InitializeData.Months[j].IsMonthChecked));
                __builder2.CloseComponent();
                __builder2.AddContent(76, 
#nullable restore
#line 35 "C:\Users\q1440767\source\repos\MonitorInterfaceBlazor\MonitorInterfaceBlazor\Pages\RunTimeParameters.razor"
                                                                                                                                                                                        InitializeData.Months[j].MonthName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(77, "\r\n                                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(78, "\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(79, "\r\n");
#nullable restore
#line 38 "C:\Users\q1440767\source\repos\MonitorInterfaceBlazor\MonitorInterfaceBlazor\Pages\RunTimeParameters.razor"
                            }
                        

#line default
#line hidden
#nullable disable
                __builder2.AddContent(80, "                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(81, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(82, "\r\n                ");
                __builder2.OpenElement(83, "div");
                __builder2.AddAttribute(84, "class", "day");
                __builder2.AddMarkupContent(85, "\r\n                    ");
                __builder2.OpenElement(86, "div");
                __builder2.AddAttribute(87, "class", "dayCheckboxes");
                __builder2.AddMarkupContent(88, "\r\n                        ");
                __builder2.AddMarkupContent(89, "<label id=\"runTimeLabel\"><strong>Day</strong></label>\r\n                        ");
                __builder2.OpenElement(90, "ul");
                __builder2.AddMarkupContent(91, "\r\n                            ");
                __builder2.OpenElement(92, "li");
                __builder2.AddMarkupContent(93, "\r\n                                ");
                __builder2.OpenElement(94, "label");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(95);
                __builder2.AddAttribute(96, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "C:\Users\q1440767\source\repos\MonitorInterfaceBlazor\MonitorInterfaceBlazor\Pages\RunTimeParameters.razor"
                                                                                                                  () => init.CheckAllDays(InitializeData.Days[0])

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(97, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 47 "C:\Users\q1440767\source\repos\MonitorInterfaceBlazor\MonitorInterfaceBlazor\Pages\RunTimeParameters.razor"
                                                                   InitializeData.Days[0].IsDayChecked

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(98, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => InitializeData.Days[0].IsDayChecked = __value, InitializeData.Days[0].IsDayChecked))));
                __builder2.AddAttribute(99, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => InitializeData.Days[0].IsDayChecked));
                __builder2.CloseComponent();
                __builder2.AddContent(100, 
#nullable restore
#line 47 "C:\Users\q1440767\source\repos\MonitorInterfaceBlazor\MonitorInterfaceBlazor\Pages\RunTimeParameters.razor"
                                                                                                                                                                      InitializeData.Days[0].DayName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(101, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(102, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(103, "\r\n");
#nullable restore
#line 50 "C:\Users\q1440767\source\repos\MonitorInterfaceBlazor\MonitorInterfaceBlazor\Pages\RunTimeParameters.razor"
                          
                            for (int i = 1; i < InitializeData.Days.Count(); i++)
                            {
                                int j = i;

#line default
#line hidden
#nullable disable
                __builder2.AddContent(104, "                                ");
                __builder2.OpenElement(105, "ul");
                __builder2.AddAttribute(106, "class", "checkbox-grid2");
                __builder2.AddMarkupContent(107, "\r\n                                    ");
                __builder2.OpenElement(108, "li");
                __builder2.AddMarkupContent(109, "\r\n                                        ");
                __builder2.OpenElement(110, "label");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(111);
                __builder2.AddAttribute(112, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 56 "C:\Users\q1440767\source\repos\MonitorInterfaceBlazor\MonitorInterfaceBlazor\Pages\RunTimeParameters.razor"
                                                                                                                           () => init.CheckManualDay(InitializeData.Days[j])

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(113, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 56 "C:\Users\q1440767\source\repos\MonitorInterfaceBlazor\MonitorInterfaceBlazor\Pages\RunTimeParameters.razor"
                                                                            InitializeData.Days[j].IsDayChecked

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(114, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => InitializeData.Days[j].IsDayChecked = __value, InitializeData.Days[j].IsDayChecked))));
                __builder2.AddAttribute(115, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => InitializeData.Days[j].IsDayChecked));
                __builder2.CloseComponent();
                __builder2.AddContent(116, 
#nullable restore
#line 56 "C:\Users\q1440767\source\repos\MonitorInterfaceBlazor\MonitorInterfaceBlazor\Pages\RunTimeParameters.razor"
                                                                                                                                                                                 InitializeData.Days[j].DayName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(117, "\r\n                                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(118, "\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(119, "\r\n");
#nullable restore
#line 59 "C:\Users\q1440767\source\repos\MonitorInterfaceBlazor\MonitorInterfaceBlazor\Pages\RunTimeParameters.razor"
                            }
                        

#line default
#line hidden
#nullable disable
                __builder2.AddContent(120, "                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(121, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(122, "\r\n                ");
                __builder2.OpenElement(123, "div");
                __builder2.AddAttribute(124, "class", "hour");
                __builder2.AddMarkupContent(125, "\r\n                    ");
                __builder2.OpenElement(126, "div");
                __builder2.AddAttribute(127, "class", "hourCheckboxes");
                __builder2.AddMarkupContent(128, "\r\n                        ");
                __builder2.AddMarkupContent(129, "<label id=\"runTimeLabel\"><strong>Hour</strong></label>\r\n                        ");
                __builder2.OpenElement(130, "ul");
                __builder2.AddMarkupContent(131, "\r\n                            ");
                __builder2.OpenElement(132, "li");
                __builder2.AddMarkupContent(133, "\r\n                                ");
                __builder2.OpenElement(134, "label");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(135);
                __builder2.AddAttribute(136, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 68 "C:\Users\q1440767\source\repos\MonitorInterfaceBlazor\MonitorInterfaceBlazor\Pages\RunTimeParameters.razor"
                                                                                                                      () => init.CheckAllHours(InitializeData.Hours[24])

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(137, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 68 "C:\Users\q1440767\source\repos\MonitorInterfaceBlazor\MonitorInterfaceBlazor\Pages\RunTimeParameters.razor"
                                                                    InitializeData.Hours[24].IsHourChecked

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(138, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => InitializeData.Hours[24].IsHourChecked = __value, InitializeData.Hours[24].IsHourChecked))));
                __builder2.AddAttribute(139, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => InitializeData.Hours[24].IsHourChecked));
                __builder2.CloseComponent();
                __builder2.AddContent(140, 
#nullable restore
#line 68 "C:\Users\q1440767\source\repos\MonitorInterfaceBlazor\MonitorInterfaceBlazor\Pages\RunTimeParameters.razor"
                                                                                                                                                                             InitializeData.Hours[24].HourName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(141, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(142, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(143, "\r\n");
#nullable restore
#line 71 "C:\Users\q1440767\source\repos\MonitorInterfaceBlazor\MonitorInterfaceBlazor\Pages\RunTimeParameters.razor"
                          
                            for (int i = 0; i < 24; i++)
                            {
                                int j = i;

#line default
#line hidden
#nullable disable
                __builder2.AddContent(144, "                                ");
                __builder2.OpenElement(145, "ul");
                __builder2.AddAttribute(146, "class", "checkbox-grid3");
                __builder2.AddMarkupContent(147, "\r\n                                    ");
                __builder2.OpenElement(148, "li");
                __builder2.AddMarkupContent(149, "\r\n                                        ");
                __builder2.OpenElement(150, "label");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(151);
                __builder2.AddAttribute(152, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 77 "C:\Users\q1440767\source\repos\MonitorInterfaceBlazor\MonitorInterfaceBlazor\Pages\RunTimeParameters.razor"
                                                                                                                             () => init.CheckManualHour(InitializeData.Hours[j])

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(153, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 77 "C:\Users\q1440767\source\repos\MonitorInterfaceBlazor\MonitorInterfaceBlazor\Pages\RunTimeParameters.razor"
                                                                            InitializeData.Hours[j].IsHourChecked

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(154, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => InitializeData.Hours[j].IsHourChecked = __value, InitializeData.Hours[j].IsHourChecked))));
                __builder2.AddAttribute(155, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => InitializeData.Hours[j].IsHourChecked));
                __builder2.CloseComponent();
                __builder2.AddContent(156, 
#nullable restore
#line 77 "C:\Users\q1440767\source\repos\MonitorInterfaceBlazor\MonitorInterfaceBlazor\Pages\RunTimeParameters.razor"
                                                                                                                                                                                     InitializeData.Hours[j].HourName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(157, "\r\n                                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(158, "\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(159, "\r\n");
#nullable restore
#line 80 "C:\Users\q1440767\source\repos\MonitorInterfaceBlazor\MonitorInterfaceBlazor\Pages\RunTimeParameters.razor"
                            }
                        

#line default
#line hidden
#nullable disable
                __builder2.AddContent(160, "                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(161, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(162, "\r\n                ");
                __builder2.OpenElement(163, "div");
                __builder2.AddAttribute(164, "class", "minute");
                __builder2.AddMarkupContent(165, "\r\n                    ");
                __builder2.AddMarkupContent(166, "<label id=\"runTimeLabel\"><strong>Minute</strong></label>\r\n                    ");
                __builder2.OpenElement(167, "ul");
                __builder2.AddMarkupContent(168, "\r\n                        ");
                __builder2.OpenElement(169, "li");
                __builder2.AddMarkupContent(170, "\r\n                            ");
                __builder2.OpenElement(171, "label");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(172);
                __builder2.AddAttribute(173, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 88 "C:\Users\q1440767\source\repos\MonitorInterfaceBlazor\MonitorInterfaceBlazor\Pages\RunTimeParameters.razor"
                                                                                                                      () => init.CheckAllMinutes(InitializeData.Minutes[60])

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(174, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 88 "C:\Users\q1440767\source\repos\MonitorInterfaceBlazor\MonitorInterfaceBlazor\Pages\RunTimeParameters.razor"
                                                                InitializeData.Minutes[60].IsMinuteChecked

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(175, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => InitializeData.Minutes[60].IsMinuteChecked = __value, InitializeData.Minutes[60].IsMinuteChecked))));
                __builder2.AddAttribute(176, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => InitializeData.Minutes[60].IsMinuteChecked));
                __builder2.CloseComponent();
                __builder2.AddContent(177, 
#nullable restore
#line 88 "C:\Users\q1440767\source\repos\MonitorInterfaceBlazor\MonitorInterfaceBlazor\Pages\RunTimeParameters.razor"
                                                                                                                                                                                 InitializeData.Minutes[60].MinuteName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(178, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(179, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(180, "\r\n");
#nullable restore
#line 91 "C:\Users\q1440767\source\repos\MonitorInterfaceBlazor\MonitorInterfaceBlazor\Pages\RunTimeParameters.razor"
                      
                        for (int i = 0; i < 60; i++)
                        {
                            int j = i;

#line default
#line hidden
#nullable disable
                __builder2.AddContent(181, "                            ");
                __builder2.OpenElement(182, "ul");
                __builder2.AddAttribute(183, "class", "checkbox-grid4");
                __builder2.AddMarkupContent(184, "\r\n                                ");
                __builder2.OpenElement(185, "li");
                __builder2.AddMarkupContent(186, "\r\n                                    ");
                __builder2.OpenElement(187, "label");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(188);
                __builder2.AddAttribute(189, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 97 "C:\Users\q1440767\source\repos\MonitorInterfaceBlazor\MonitorInterfaceBlazor\Pages\RunTimeParameters.razor"
                                                                                                                             () => init.CheckManualMinute(InitializeData.Minutes[j])

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(190, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 97 "C:\Users\q1440767\source\repos\MonitorInterfaceBlazor\MonitorInterfaceBlazor\Pages\RunTimeParameters.razor"
                                                                        InitializeData.Minutes[j].IsMinuteChecked

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(191, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => InitializeData.Minutes[j].IsMinuteChecked = __value, InitializeData.Minutes[j].IsMinuteChecked))));
                __builder2.AddAttribute(192, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => InitializeData.Minutes[j].IsMinuteChecked));
                __builder2.CloseComponent();
                __builder2.AddContent(193, 
#nullable restore
#line 97 "C:\Users\q1440767\source\repos\MonitorInterfaceBlazor\MonitorInterfaceBlazor\Pages\RunTimeParameters.razor"
                                                                                                                                                                                         InitializeData.Minutes[j].MinuteName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(194, "\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(195, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(196, "\r\n");
#nullable restore
#line 100 "C:\Users\q1440767\source\repos\MonitorInterfaceBlazor\MonitorInterfaceBlazor\Pages\RunTimeParameters.razor"
                        }
                    

#line default
#line hidden
#nullable disable
                __builder2.AddContent(197, "                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(198, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(199, "\r\n");
#nullable restore
#line 104 "C:\Users\q1440767\source\repos\MonitorInterfaceBlazor\MonitorInterfaceBlazor\Pages\RunTimeParameters.razor"
        }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(200, "    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(201, "\r\n");
#nullable restore
#line 106 "C:\Users\q1440767\source\repos\MonitorInterfaceBlazor\MonitorInterfaceBlazor\Pages\RunTimeParameters.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 108 "C:\Users\q1440767\source\repos\MonitorInterfaceBlazor\MonitorInterfaceBlazor\Pages\RunTimeParameters.razor"
       
    void HandleValidSubmit()
    {
        Console.WriteLine("OnValidSubmit");
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591