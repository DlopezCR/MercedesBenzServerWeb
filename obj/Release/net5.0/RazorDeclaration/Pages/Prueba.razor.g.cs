// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace MercedesBenzServerWeb.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\MERCEDES\MercedesBenzWeb\MercedesBenzServerWeb\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\MERCEDES\MercedesBenzWeb\MercedesBenzServerWeb\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\MERCEDES\MercedesBenzWeb\MercedesBenzServerWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\MERCEDES\MercedesBenzWeb\MercedesBenzServerWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\MERCEDES\MercedesBenzWeb\MercedesBenzServerWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\MERCEDES\MercedesBenzWeb\MercedesBenzServerWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\MERCEDES\MercedesBenzWeb\MercedesBenzServerWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\MERCEDES\MercedesBenzWeb\MercedesBenzServerWeb\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\MERCEDES\MercedesBenzWeb\MercedesBenzServerWeb\_Imports.razor"
using MercedesBenzServerWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\MERCEDES\MercedesBenzWeb\MercedesBenzServerWeb\_Imports.razor"
using MercedesBenzServerWeb.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\MERCEDES\MercedesBenzWeb\MercedesBenzServerWeb\_Imports.razor"
using MercedesBenzModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\MERCEDES\MercedesBenzWeb\MercedesBenzServerWeb\_Imports.razor"
using Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\MERCEDES\MercedesBenzWeb\MercedesBenzServerWeb\_Imports.razor"
using MercedesBenzServerWeb.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "E:\MERCEDES\MercedesBenzWeb\MercedesBenzServerWeb\_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "E:\MERCEDES\MercedesBenzWeb\MercedesBenzServerWeb\_Imports.razor"
using BlazorPro.Spinkit;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "E:\MERCEDES\MercedesBenzWeb\MercedesBenzServerWeb\Pages\Prueba.razor"
using BlazorDateRangePicker;

#line default
#line hidden
#nullable disable
    public partial class Prueba : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "E:\MERCEDES\MercedesBenzWeb\MercedesBenzServerWeb\Pages\Prueba.razor"
      

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
