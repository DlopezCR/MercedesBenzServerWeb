#pragma checksum "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\ReportePages\ReporteSemaforoFacialDetalles.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7eccb1dae328340a151339e1f0032ad52a5a7565"
// <auto-generated/>
#pragma warning disable 1591
namespace MercedesBenzServerWeb.Pages.ReportePages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/reporteSemaforoFacialDetalles")]
    public partial class ReporteSemaforoFacialDetalles : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"mbz-row-center\"><div class=\"mbz-card-titulo-2 mbz-font-ATitleCondOffice-40 mbz-text-secondary\"><span class>Semáforo facial</span></div></div>\r\n\r\n");
            __builder.OpenComponent<MercedesBenzServerWeb.Pages.Fechas>(1);
            __builder.AddAttribute(2, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MercedesBenzModel.FechaRequest>(
#nullable restore
#line 10 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\ReportePages\ReporteSemaforoFacialDetalles.razor"
                model

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 10 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\ReportePages\ReporteSemaforoFacialDetalles.razor"
                                  OnSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "OnDownload", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 10 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\ReportePages\ReporteSemaforoFacialDetalles.razor"
                                                        OnDownload

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "Mensaje", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 10 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\ReportePages\ReporteSemaforoFacialDetalles.razor"
                                                                              mensaje

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "Descargar", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 10 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\ReportePages\ReporteSemaforoFacialDetalles.razor"
                                                                                                   descargar

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(7, "\r\n\r\n");
            __builder.OpenComponent<BlazorPro.Spinkit.SpinLoader>(8);
            __builder.AddAttribute(9, "IsLoading", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 12 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\ReportePages\ReporteSemaforoFacialDetalles.razor"
                       isLoadingData

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "LoadingTemplate", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class");
                __builder2.AddMarkupContent(13, "<br>\r\n            ");
                __builder2.OpenComponent<BlazorPro.Spinkit.CircleFade>(14);
                __builder2.AddAttribute(15, "Center", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 16 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\ReportePages\ReporteSemaforoFacialDetalles.razor"
                                true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "Size", "50px");
                __builder2.AddAttribute(17, "Color", "#232F3B");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n            <br>");
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(19, "ContentTemplate", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
#nullable restore
#line 21 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\ReportePages\ReporteSemaforoFacialDetalles.razor"
         if (respuesta != null)
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(20, "table");
                __builder2.AddAttribute(21, "class", "table table-bordered table-striped table-hover mbz-tb-buscar");
                __builder2.AddMarkupContent(22, @"<thead><tr><th style=""width:92px;"">Tipo Alerta</th>
                        <th style=""width:60px;"">Score Facial</th>
                        <th>Cliente</th>
                        <th style=""width:120px;"">Folio</th>
                        <th style=""width:70px;"">Fecha Captura</th>
                        <th style=""width:70px;"">Fecha Envío</th>
                        <th style>Agencia</th></tr></thead>
                ");
                __builder2.OpenElement(23, "tbody");
#nullable restore
#line 36 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\ReportePages\ReporteSemaforoFacialDetalles.razor"
                     foreach (var item in JsonConvert.DeserializeObject<IEnumerable<ReporteSemaforoFacialDetalleResponse>>(respuesta.Data.ToString()))
                    {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(24, "tr");
                __builder2.OpenElement(25, "td");
                __builder2.AddContent(26, 
#nullable restore
#line 39 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\ReportePages\ReporteSemaforoFacialDetalles.razor"
                                 item.TipoAlerta

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n                            ");
                __builder2.OpenElement(28, "td");
                __builder2.AddContent(29, 
#nullable restore
#line 40 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\ReportePages\ReporteSemaforoFacialDetalles.razor"
                                 item.ScoreFacial

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n                            ");
                __builder2.OpenElement(31, "td");
                __builder2.AddContent(32, 
#nullable restore
#line 41 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\ReportePages\ReporteSemaforoFacialDetalles.razor"
                                 item.ClienteNombre

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n                            ");
                __builder2.OpenElement(34, "td");
                __builder2.AddContent(35, 
#nullable restore
#line 42 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\ReportePages\ReporteSemaforoFacialDetalles.razor"
                                 item.Folio

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n                            ");
                __builder2.OpenElement(37, "td");
                __builder2.AddContent(38, 
#nullable restore
#line 43 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\ReportePages\ReporteSemaforoFacialDetalles.razor"
                                 item.FechaCaptura.ToString("dd/MM/yyyy")

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n                            ");
                __builder2.OpenElement(40, "td");
                __builder2.AddContent(41, 
#nullable restore
#line 44 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\ReportePages\ReporteSemaforoFacialDetalles.razor"
                                 item.FechaEnvio.ToString("dd/MM/yyyy")

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n                            ");
                __builder2.OpenElement(43, "td");
                __builder2.AddContent(44, 
#nullable restore
#line 45 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\ReportePages\ReporteSemaforoFacialDetalles.razor"
                                 item.NombreAgencia

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 47 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\ReportePages\ReporteSemaforoFacialDetalles.razor"
                    }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n            ");
                __builder2.OpenComponent<MercedesBenzServerWeb.Pages.Paginacion>(46);
                __builder2.AddAttribute(47, "PaginaActual", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 50 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\ReportePages\ReporteSemaforoFacialDetalles.razor"
                                      paginaActual

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(48, "PaginasTotal", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 50 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\ReportePages\ReporteSemaforoFacialDetalles.razor"
                                                                  paginasTotal

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(49, "PaginaSeleccionada", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 50 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\ReportePages\ReporteSemaforoFacialDetalles.razor"
                                                                                                    PaginaSeleccionada

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
#nullable restore
#line 51 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\ReportePages\ReporteSemaforoFacialDetalles.razor"
        }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 56 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\ReportePages\ReporteSemaforoFacialDetalles.razor"
       
    [CascadingParameter(Name = "RegistrosPagina")]
    protected int registrosPagina { get; set; }

    FechaRequest model = new();
    PaginacionRequest paginacion = new();
    RespuestaPaginada respuesta = null;
    private string mensaje = String.Empty;
    private bool isLoadingData = false;
    private bool descargar = false;

    private int totalRegistros = 0;
    private int paginaActual = 1;
    private int paginasTotal = 0;

    protected override void OnInitialized()
    {
        model.FechaInicial = DateTime.Now.AddDays(-(DateTime.Now.Day - 1));
        model.FechaFinal = DateTime.Now;
        paginacion.Pagina = paginaActual;
        paginacion.RegistrosPagina = registrosPagina;
    }

    private async Task OnSubmit()
    {
        bool IsData = false;

        if (!string.IsNullOrEmpty(model.FechaInicial.ToString()))
            IsData = true;
        if (!string.IsNullOrEmpty(model.FechaFinal.ToString()))
            IsData = true;
        if (IsData)
        {
            paginaActual = 1;
            await PaginaSeleccionada(paginaActual);
        }
        else
        {
            mensaje = "Debe ingresar la fecha inicial y la fecha final";
            respuesta = null;
        }
        return;
    }

    private async Task OnDownload()
    {
        mensaje = "Descargando reporte ...";
        model.FechaInicial = new DateTime(model.FechaInicial.Year, model.FechaInicial.Month, model.FechaInicial.Day, 00, 00, 00);
        model.FechaFinal = new DateTime(model.FechaFinal.Year, model.FechaFinal.Month, model.FechaFinal.Day, 23, 59, 59);
        (string mensajeResponse, byte[] respuestaResponse) = await Service.DownloadReporteAsync("reportes/SemaforoFacialDetalleDescargar", model);
        if (respuestaResponse == null)
        {
            mensaje = mensajeResponse;
        }
        else
        {
            var nombreArchivo = $"Reporte_SemaforoFacial_{DateTime.Now.ToString("yyyy-MM-dd")}.xlsx";
            await JS.InvokeAsync<object>("saveAsFile", nombreArchivo, Convert.ToBase64String(respuestaResponse));
            mensaje = "Descarga Finalizada";
        }
    }

    private async Task PaginaSeleccionada(int pagina)
    {
        paginaActual = pagina;
        isLoadingData = true;
        this.StateHasChanged();
        await ConsultarDatos(paginaActual);
        isLoadingData = false;
        this.StateHasChanged();
    }

    private async Task ConsultarDatos(int pagina = 1)
    {
        descargar = false;
        mensaje = "";
        model.FechaInicial = new DateTime(model.FechaInicial.Year, model.FechaInicial.Month, model.FechaInicial.Day, 00, 00, 00);
        model.FechaFinal = new DateTime(model.FechaFinal.Year, model.FechaFinal.Month, model.FechaFinal.Day, 23, 59, 59);
        paginacion.Pagina = pagina;
        (string mensajeResponse, RespuestaPaginada respuestaResponse) = await Service.GetReporteAsync("reportes/SemaforoFacialDetalle", model, paginacion);
        respuesta = respuestaResponse;
        if (respuesta == null)
        {
            if (string.IsNullOrEmpty(mensajeResponse) || mensajeResponse == "True")
                mensaje = "No se encontraron datos del período ingresado";
            else
                mensaje = mensajeResponse;
        }
        else
        {
            totalRegistros = respuesta.TotalRegistros;
            paginasTotal = respuesta.TotalPaginas;
            mensaje = "";
            descargar = true;
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Services.IReporteService Service { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BusquedaRequest Busqueda { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserCredential Credential { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AppState AppState { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
