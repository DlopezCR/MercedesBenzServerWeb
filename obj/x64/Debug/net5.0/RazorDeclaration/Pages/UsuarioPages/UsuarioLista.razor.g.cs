// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace MercedesBenzServerWeb.Pages.UsuarioPages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/usuarioLista")]
    public partial class UsuarioLista : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 92 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\UsuarioPages\UsuarioLista.razor"
       
    [CascadingParameter(Name = "RegistrosPagina")]
    protected int registrosPagina { get; set; }

    PaginacionRequest paginacion = new();
    RespuestaPaginada respuesta = null;
    private string mensaje = String.Empty;

    private bool isLoadingData = true;

    private int id = 0;
    private string nombreUsuario = "";
    private bool activarUsuario = false;
    private TipoAccion tipoAccion { get; set; }

    private int totalRegistros = 0;
    private int paginaActual = 1;
    private int paginasTotal = 0;

    private bool popupOpen { get; set; } = false;
    private string mensajePopup = "";

    private bool popupOpenComent { get; set; } = false;
    private string mensajePopupComent = "";

    protected override void OnInitialized()
    {
        paginacion.Pagina = paginaActual;
        paginacion.RegistrosPagina = registrosPagina;
    }

    protected async override Task OnAfterRenderAsync(bool firstRender)
    {
        if(firstRender)
        {
            await Task.Run(async () =>
            {
                await ConsultarDatos();
                isLoadingData = false;
                await InvokeAsync(StateHasChanged);
            });
        }
    }

    private async Task PaginaSeleccionada(int Pagina)
    {
        paginaActual = Pagina;
        isLoadingData = true;
        this.StateHasChanged();
        await ConsultarDatos(paginaActual);
        isLoadingData = false;
        this.StateHasChanged();
    }

    private async Task ConsultarDatos(int Pagina = 1)
    {
        paginacion.Pagina = Pagina;
        (string mensajeResponse, RespuestaPaginada respuestaResponse) = await Service.GetAllAsync(paginacion);
        if (respuestaResponse == null)
        {
            if (string.IsNullOrEmpty(mensajeResponse))
                mensaje = "No se encontraron registros";
            else
                mensaje = mensajeResponse;
        }
        else
        {
            respuesta = respuestaResponse;
            totalRegistros = respuesta.TotalRegistros;
            paginasTotal = respuesta.TotalPaginas;
            mensaje = "";
        }
    }

    private void OnEditar(int Id, string Nombre, string ApellidoPaterno, string ApellidoMaterno)
    {
        id = Id;
        nombreUsuario = Nombre + " " + ApellidoPaterno + " " + ApellidoMaterno;
        mensajePopup = $"¿Estas seguro de editar al usuario {nombreUsuario}?";
        tipoAccion = TipoAccion.Editar;
        popupOpen = true;
    }

    private void OnCambiarEstatus(bool NuevoEstatus, int Id, string Nombre, string ApellidoPaterno, string ApellidoMaterno)
    {
        activarUsuario = NuevoEstatus;
        id = Id;
        nombreUsuario = Nombre + " " + ApellidoPaterno + " " + ApellidoMaterno;
        string mensajeEstatus = "desactivar";
        if (activarUsuario)
            mensajeEstatus = "activar";
        mensajePopup = $"¿Estas seguro de {mensajeEstatus} al usuario {nombreUsuario}?";
        tipoAccion = TipoAccion.Eliminar;
        popupOpen = true;
    }

    private void OnPopupClose(bool Respuesta)
    {
        popupOpen = false;
        if (Respuesta)
        {
            if (tipoAccion == TipoAccion.Editar)
            {
                NavigationManager.NavigateTo($"usuarioEditar/{id}");
            }
            else
            {
                mensajePopupComent = "Agregar comentario";
                popupOpenComent = true;
            }
        }
    }

    private async Task OnPopupComentClose(string Respuesta)
    {
        popupOpenComent = false;
        if (!string.IsNullOrEmpty(Respuesta))
        {
            mensaje = "";
            UsuarioEstatusRequest request = new()
            {
                Activar = activarUsuario,
                UsuarioId = id,
                Motivo = Respuesta,
                UsuarioIdEjecuto = Credencial.UsuarioId,
            };
            (string mensajeResponse, bool resultado) = await Service.CambiarEstatuAsync(request);
            if (resultado)
                await PaginaSeleccionada(paginaActual);
            else
                mensaje = mensajeResponse;
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Services.IUsuarioService Service { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BusquedaRequest Busqueda { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UsuarioCredencial Credencial { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AppState AppState { get; set; }
    }
}
#pragma warning restore 1591