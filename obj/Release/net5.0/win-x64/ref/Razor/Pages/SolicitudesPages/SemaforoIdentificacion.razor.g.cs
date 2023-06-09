#pragma checksum "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\SolicitudesPages\SemaforoIdentificacion.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51be3b93a84f98ecad200a999fe04a1fa3a3dc0e"
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
    public partial class SemaforoIdentificacion : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "id", "idSemaforoIdentificacion");
            __builder.AddAttribute(2, "style", "padding: 20px;");
            __builder.AddMarkupContent(3, "<div class=\"pt-2 pb-2\"><span class=\"mbz-font-STextOffice-B-16 mbz-text-dark\">Capturas de identificación</span></div>\r\n\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "mbz-card-ficha-carnet mb-4");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "d-flex");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "mbz-w-50p");
            __builder.OpenElement(10, "p");
            __builder.AddAttribute(11, "class", "text-center");
#nullable restore
#line 11 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\SolicitudesPages\SemaforoIdentificacion.razor"
                     if (Model.Identificaciones != null)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\SolicitudesPages\SemaforoIdentificacion.razor"
                         foreach (var item in @Model.Identificaciones)
                        {
                            if (item.CapturaNombreId == 1)
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(12, "img");
            __builder.AddAttribute(13, "src", "data:image/jpg;base64," + (
#nullable restore
#line 17 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\SolicitudesPages\SemaforoIdentificacion.razor"
                                                                 Convert.ToBase64String(item.Imagen)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "style", "max-width: 430px; max-height: 272px;");
            __builder.CloseElement();
#nullable restore
#line 18 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\SolicitudesPages\SemaforoIdentificacion.razor"
                            }
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\SolicitudesPages\SemaforoIdentificacion.razor"
                         
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n            ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "mbz-w-50p");
            __builder.OpenElement(18, "p");
            __builder.AddAttribute(19, "class", "text-center");
#nullable restore
#line 25 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\SolicitudesPages\SemaforoIdentificacion.razor"
                     if (Model.Identificaciones != null)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\SolicitudesPages\SemaforoIdentificacion.razor"
                         foreach (var item in @Model.Identificaciones)
                        {
                            if (item.CapturaNombreId == 4)
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(20, "img");
            __builder.AddAttribute(21, "src", "data:image/jpg;base64," + (
#nullable restore
#line 31 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\SolicitudesPages\SemaforoIdentificacion.razor"
                                                                 Convert.ToBase64String(item.Imagen)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "style", "max-width: 430px; max-height: 272px;");
            __builder.CloseElement();
#nullable restore
#line 32 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\SolicitudesPages\SemaforoIdentificacion.razor"
                            }
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\SolicitudesPages\SemaforoIdentificacion.razor"
                         
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 39 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\SolicitudesPages\SemaforoIdentificacion.razor"
     if (@Model.DocumentoPdf != null)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "d-flex");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "pb-3");
            __builder.OpenElement(27, "button");
            __builder.AddAttribute(28, "type", "button");
            __builder.AddAttribute(29, "class", "btn mbz-btn-primary mbz-btn-h-28 mbz-font-STextOffice-B-14");
            __builder.AddAttribute(30, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\SolicitudesPages\SemaforoIdentificacion.razor"
                                                                                                                   e => mostrarPdf = !mostrarPdf

#line default
#line hidden
#nullable disable
            ));
#nullable restore
#line 44 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\SolicitudesPages\SemaforoIdentificacion.razor"
                     if (mostrarPdf)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(31, "<span>Ocultar Pdf</span>");
#nullable restore
#line 47 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\SolicitudesPages\SemaforoIdentificacion.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(32, "<span>Mostrar Pdf</span>");
#nullable restore
#line 51 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\SolicitudesPages\SemaforoIdentificacion.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n        ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "d-flex");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "mbz-w-100p pb-2");
            __builder.OpenElement(38, "iframe");
            __builder.AddAttribute(39, "src", "data:application/pdf;base64," + (
#nullable restore
#line 57 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\SolicitudesPages\SemaforoIdentificacion.razor"
                                                          Convert.ToBase64String(@Model.DocumentoPdf)

#line default
#line hidden
#nullable disable
            ) + "#zoom=FitH");
            __builder.AddAttribute(40, "typeof", "application/pdf");
            __builder.AddAttribute(41, "style", "width:" + " 100%;" + " height:" + " 340px;" + " border:" + " 1px" + " solid" + " #707070;" + " " + (
#nullable restore
#line 57 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\SolicitudesPages\SemaforoIdentificacion.razor"
                                                                                                                                                                                                          mostrarPdf ? string.Empty: "display: none"

#line default
#line hidden
#nullable disable
            ) + " ");
            __builder.AddAttribute(42, "frameborder", "0");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 60 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\SolicitudesPages\SemaforoIdentificacion.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 63 "D:\Proyectos\Net\MercedesBenzWeb\MercedesBenzServerWeb\Pages\SolicitudesPages\SemaforoIdentificacion.razor"
       
    [Parameter] public SolicitudIdentificacion Model { get; set; }
    private bool mostrarPdf = false;


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
