#pragma checksum "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\Prueba.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df4936003a85e4e3e03064a9bda666d459ba90ad"
// <auto-generated/>
#pragma warning disable 1591
namespace MercedesBenzServerWeb.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\_Imports.razor"
using MercedesBenzServerWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\_Imports.razor"
using MercedesBenzServerWeb.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\_Imports.razor"
using MercedesBenzModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\_Imports.razor"
using Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\_Imports.razor"
using MercedesBenzServerWeb.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\_Imports.razor"
using BlazorPro.Spinkit;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\Prueba.razor"
using BlazorDateRangePicker;

#line default
#line hidden
#nullable disable
    public partial class Prueba : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Prueba</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "col-3");
            __builder.OpenComponent<BlazorDateRangePicker.DateRangePicker>(3);
            __builder.AddAttribute(4, "Culture", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Globalization.CultureInfo>(
#nullable restore
#line 7 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\Prueba.razor"
                                              System.Globalization.CultureInfo.GetCultureInfo("es-MX")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "DateFormat", "dd MMMM yyyy");
            __builder.AddAttribute(6, "AutoApply", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean?>(
#nullable restore
#line 7 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\Prueba.razor"
                                                                                                                                              true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "OnOpened", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 8 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\Prueba.razor"
                               Opened

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(8, "OnClosed", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 9 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\Prueba.razor"
                               Closed

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(9, "MinDate", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.DateTimeOffset?>(
#nullable restore
#line 10 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\Prueba.razor"
                              MinDate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "MaxDate", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.DateTimeOffset?>(
#nullable restore
#line 10 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\Prueba.razor"
                                                MaxDate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "PickerTemplate", (Microsoft.AspNetCore.Components.RenderFragment<BlazorDateRangePicker.DateRangePicker>)((context) => (__builder2) => {
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "id", 
#nullable restore
#line 12 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\Prueba.razor"
                      context.Id

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(14, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\Prueba.razor"
                                            context.Toggle

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(15, "style", "background: #fff; cursor: pointer; padding: 5px 10px; width: 350px; border: 1px solid #ccc;");
                __builder2.AddMarkupContent(16, "<i class=\"oi oi-calendar\"></i>&nbsp;\r\n                ");
                __builder2.OpenElement(17, "input");
                __builder2.AddAttribute(18, "id", "Id0");
                __builder2.AddAttribute(19, "type", "text");
                __builder2.AddAttribute(20, "value", 
#nullable restore
#line 14 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\Prueba.razor"
                                                    context.FormattedRange

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(21, "placeholder", "Rango de fechas");
                __builder2.AddAttribute(22, "style", "border:0px;width:85%");
                __builder2.AddAttribute(23, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 15 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\Prueba.razor"
                                  ((ChangeEventArgs __e) => OnRangeChange(__e.Value.ToString().Trim()))

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n                <i class=\"oi oi-chevron-bottom float-right\"></i>");
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(25, "ButtonsTemplate", (Microsoft.AspNetCore.Components.RenderFragment<BlazorDateRangePicker.DateRangePicker>)((context) => (__builder2) => {
                __builder2.OpenElement(26, "button");
                __builder2.AddAttribute(27, "class", "cancelBtn btn btn-sm btn-default");
                __builder2.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\Prueba.razor"
                                                                        context.ClickCancel

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "type", "button");
                __builder2.AddMarkupContent(30, "\r\n                Cancel\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n            ");
                __builder2.OpenElement(32, "button");
                __builder2.AddAttribute(33, "class", "cancelBtn btn btn-sm btn-default");
                __builder2.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\Prueba.razor"
                                                                         e => ResetClick(e, context)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(35, "type", "button");
                __builder2.AddMarkupContent(36, "\r\n                Reset\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n            ");
                __builder2.OpenElement(38, "button");
                __builder2.AddAttribute(39, "class", "applyBtn btn btn-sm btn-primary");
                __builder2.AddAttribute(40, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\Prueba.razor"
                                                                       context.ClickApply

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(41, "disabled", 
#nullable restore
#line 26 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\Prueba.razor"
                                                                                                       context.TStartDate == null || context.TEndDate == null

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(42, "type", "button");
                __builder2.AddMarkupContent(43, "\r\n                Apply\r\n            ");
                __builder2.CloseElement();
            }
            ));
            __builder.AddComponentReferenceCapture(44, (__value) => {
#nullable restore
#line 7 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\Prueba.razor"
                           Picker = (BlazorDateRangePicker.DateRangePicker)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\Prueba.razor"
      

    DateRangePicker Picker;

    private bool FechaCapturada { get; set; } = false;
    private bool ValidarFecha { get; set; } = false;

    DateTime MinDate { get; set; } = new DateTime(2022, 01, 1);
    DateTime MaxDate { get; set; } = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddMonths(1).AddDays(-1);

    DateTimeOffset? StartDate { get; set; } = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
    DateTimeOffset? EndDate { get; set; } = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddMonths(1).AddDays(-1);

    protected async override Task OnInitializedAsync()
    {
        //var authentication2 = await authenticationState;

        var authentication = await AuthenticationStateProvider.GetAuthenticationStateAsync();
        //var identity = authentication.User.Identity;
        //var claims = authentication.User.Claims;

        //string nombre = identity.Name;
        //string role = "";
        //var claimRole = claims.FirstOrDefault(x => x.Type.Contains("role"));
        //if (claimRole != null)
        //    role = claimRole.Value;

    }

    public void Opened()
    {
        ValidarFecha = true;
    }

    public void Closed()
    {
        if (ValidarFecha)
        {
            if (!string.IsNullOrEmpty(Picker.FormattedRange))
                FechaCapturada = true;
        }
    }


    public void OnRangeSelect(DateRange range)
    {
        var fechaInicio = range.Start;
        var fechaFinal = range.End;
        //var calendar = Picker.RightCalendar.Calendar;
        //Picker.TEndDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddMonths(1).AddDays(-1);
    }

    void OnRangeChange(string value)
    {
        FechaCapturada = false;
        if (value == Picker.FormattedRange)
            FechaCapturada = true;
        ValidarFecha = false;
    }

    void ResetClick(MouseEventArgs e, DateRangePicker picker)
    {
        StartDate = null;
        EndDate = null;
        picker.Close();
        picker.OnRangeSelect.InvokeAsync(new DateRange());
    }

    protected override void OnInitialized()
    {
        //StartDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
        //EndDate = DateTime.Now;   @bind-EndDate="EndDate"

        //Picker.AutoApply = true;
        //Picker.DateFormat = "dd MMMM yyyy";
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BusquedaRequest Busqueda { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserCredential Credential { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AppState AppState { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
