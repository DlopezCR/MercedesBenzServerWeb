#pragma checksum "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\SolicitudesPages\SolicitudesEstatusTarjeta.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90cdc56a2a914580d4cc07cbda47413f593f2468"
// <auto-generated/>
#pragma warning disable 1591
namespace MercedesBenzServerWeb.Pages.SolicitudesPages
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
    public partial class SolicitudesEstatusTarjeta : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "d-flex");
#nullable restore
#line 2 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\SolicitudesPages\SolicitudesEstatusTarjeta.razor"
     foreach (var item in Solicitantes)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "mbz-card-solicitud-tarjeta");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "mbz-card-solicitud-tarjeta-item");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "d-flex pl-2 pr-2");
            __builder.AddAttribute(8, "style", "border-bottom: 1px solid #707070;");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "mbz-w-55p");
            __builder.OpenElement(11, "span");
            __builder.AddAttribute(12, "class");
            __builder.AddContent(13, 
#nullable restore
#line 7 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\SolicitudesPages\SolicitudesEstatusTarjeta.razor"
                                                           item.TipoCliente

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n                    ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "mbz-w-45p" + " " + (
#nullable restore
#line 8 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\SolicitudesPages\SolicitudesEstatusTarjeta.razor"
                                           colorEstatus

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(17, "span");
            __builder.AddAttribute(18, "class");
            __builder.AddContent(19, 
#nullable restore
#line 8 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\SolicitudesPages\SolicitudesEstatusTarjeta.razor"
                                                                         item.Estatus

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "d-flex pl-2 pr-2");
            __builder.AddAttribute(23, "style", "border-bottom: 1px solid #707070;");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "mbz-w-55p");
            __builder.AddMarkupContent(26, "<span class>Fecha de solicitud:</span>\r\n                        ");
            __builder.OpenElement(27, "span");
            __builder.AddAttribute(28, "class");
            __builder.AddContent(29, 
#nullable restore
#line 13 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\SolicitudesPages\SolicitudesEstatusTarjeta.razor"
                                        item.FechaEnvio.ToString("dd/MM/yyyy")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                    ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "mbz-w-45p");
            __builder.AddMarkupContent(33, "<span class>Folio:</span>\r\n                        ");
            __builder.OpenElement(34, "span");
            __builder.AddAttribute(35, "class");
            __builder.AddContent(36, 
#nullable restore
#line 17 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\SolicitudesPages\SolicitudesEstatusTarjeta.razor"
                                        item.Folio

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                ");
            __builder.OpenElement(38, "table");
            __builder.OpenElement(39, "tbody");
            __builder.OpenElement(40, "tr");
            __builder.AddAttribute(41, "style", "vertical-align: top;");
            __builder.OpenElement(42, "td");
            __builder.AddAttribute(43, "class");
            __builder.AddAttribute(44, "style", "width: 162px; padding: 18px 0px;text-align:center");
            __builder.AddAttribute(45, "rowspan", "4");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "style");
#nullable restore
#line 25 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\SolicitudesPages\SolicitudesEstatusTarjeta.razor"
                                     if (item.Imagen == null)
                                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(48, "<img src=\"../image/nofoto.png\" style=\"width: 110px;\">");
#nullable restore
#line 28 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\SolicitudesPages\SolicitudesEstatusTarjeta.razor"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(49, "img");
            __builder.AddAttribute(50, "src", "data:image/jpg;base64," + (
#nullable restore
#line 31 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\SolicitudesPages\SolicitudesEstatusTarjeta.razor"
                                                                         Convert.ToBase64String(item.Imagen)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(51, "style", "max-width:150px; max-height:190px;");
            __builder.CloseElement();
#nullable restore
#line 32 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\SolicitudesPages\SolicitudesEstatusTarjeta.razor"
                                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n                            <td class style=\"width: 326px;\"></td>");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                        ");
            __builder.AddMarkupContent(54, "<tr><td style=\"height:40px\"></td></tr>\r\n                        ");
            __builder.OpenElement(55, "tr");
            __builder.AddAttribute(56, "style", "vertical-align: bottom;");
            __builder.OpenElement(57, "td");
            __builder.AddAttribute(58, "style", "padding-right:20px;");
            __builder.OpenElement(59, "span");
            __builder.AddAttribute(60, "class", "mbz-font-STextOffice-B-24");
            __builder.AddContent(61, 
#nullable restore
#line 43 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\SolicitudesPages\SolicitudesEstatusTarjeta.razor"
                                                                         item.SolicitanteNombre

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n                                <br>\r\n                                ");
            __builder.OpenElement(63, "span");
            __builder.AddAttribute(64, "class", "mbz-font-STextOffice-B-24");
            __builder.AddContent(65, 
#nullable restore
#line 45 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\SolicitudesPages\SolicitudesEstatusTarjeta.razor"
                                                                         item.SolicitanteApellidoPaterno

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(66, " ");
            __builder.AddContent(67, 
#nullable restore
#line 45 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\SolicitudesPages\SolicitudesEstatusTarjeta.razor"
                                                                                                          item.SolicitanteApellidoMaterno

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n                                <br>\r\n                                ");
            __builder.AddMarkupContent(69, "<span class>Fecha de nacimiento:</span>\r\n                                ");
            __builder.OpenElement(70, "span");
            __builder.AddAttribute(71, "class");
            __builder.AddContent(72, 
#nullable restore
#line 48 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\SolicitudesPages\SolicitudesEstatusTarjeta.razor"
                                                item.FechaNacimiento?.ToString("dd/MM/yyyy")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n                        ");
            __builder.OpenElement(74, "tr");
            __builder.OpenElement(75, "td");
            __builder.AddAttribute(76, "style", "padding-right: 20px; padding-bottom: 10px;");
            __builder.OpenElement(77, "button");
            __builder.AddAttribute(78, "type", "button");
            __builder.AddAttribute(79, "class", "btn mbz-btn-primary mbz-font-STextOffice-18");
            __builder.AddAttribute(80, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 53 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\SolicitudesPages\SolicitudesEstatusTarjeta.razor"
                                                                                                                    (() => OnAccion(item.SolicitanteId))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(81, "Ver");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 60 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\SolicitudesPages\SolicitudesEstatusTarjeta.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 63 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\SolicitudesPages\SolicitudesEstatusTarjeta.razor"
       
    [Parameter] public List<SolicitanteEstatus> Solicitantes { get; set; }
    [Parameter] public SolicitudEstatus Estatus { get; set; }

    private string colorEstatus { get; set; }

    protected override void OnParametersSet()
    {
        switch (Estatus)
        {
            case SolicitudEstatus.Nuevas:
                colorEstatus = "mbz-text-green";
                break;
            case SolicitudEstatus.Proceso:
                colorEstatus = "mbz-text-green";
                break;
            case SolicitudEstatus.Finalizadas:
                colorEstatus = "mbz-text-green";
                break;
        }
    }

    private void OnAccion(int id)
    {
        string urlOrigen = $"solicitudes/{(int)Estatus}";
        NavigationManager.NavigateTo($"/solicitudDetalle/{id}/{urlOrigen}");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BusquedaRequest Busqueda { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserCredential Credential { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AppState AppState { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
