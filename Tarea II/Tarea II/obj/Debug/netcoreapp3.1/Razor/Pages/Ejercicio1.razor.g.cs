#pragma checksum "C:\Users\rody castro cuello\Documents\PROGRAMACION\Programacion III\Tarea2\Tarea II\Tarea II\Pages\Ejercicio1.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5cd44dbdccf9d710376ccf98dca8d8f3cc77dd7b"
// <auto-generated/>
#pragma warning disable 1591
namespace Tarea_II.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\rody castro cuello\Documents\PROGRAMACION\Programacion III\Tarea2\Tarea II\Tarea II\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rody castro cuello\Documents\PROGRAMACION\Programacion III\Tarea2\Tarea II\Tarea II\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\rody castro cuello\Documents\PROGRAMACION\Programacion III\Tarea2\Tarea II\Tarea II\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\rody castro cuello\Documents\PROGRAMACION\Programacion III\Tarea2\Tarea II\Tarea II\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\rody castro cuello\Documents\PROGRAMACION\Programacion III\Tarea2\Tarea II\Tarea II\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\rody castro cuello\Documents\PROGRAMACION\Programacion III\Tarea2\Tarea II\Tarea II\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\rody castro cuello\Documents\PROGRAMACION\Programacion III\Tarea2\Tarea II\Tarea II\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\rody castro cuello\Documents\PROGRAMACION\Programacion III\Tarea2\Tarea II\Tarea II\_Imports.razor"
using Tarea_II;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\rody castro cuello\Documents\PROGRAMACION\Programacion III\Tarea2\Tarea II\Tarea II\_Imports.razor"
using Tarea_II.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Ejercicio1")]
    public partial class Ejercicio1 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Ejercicio 1</h3>\r\n<br>\r\n");
            __builder.AddMarkupContent(1, "<h6>Programa que acepte una frase u oración, luego muestre la cantidad de vocales, espacios y consonantes que tiene la misma.</h6>\r\n<br>\r\n\r\n");
            __builder.OpenElement(2, "input");
            __builder.AddAttribute(3, "class", "form-control form-control-lg");
            __builder.AddAttribute(4, "type", "text");
            __builder.AddAttribute(5, "placeholder", "Inserte una frase");
            __builder.AddAttribute(6, "aria-label", ".form-control-lg example");
            __builder.AddAttribute(7, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 8 "C:\Users\rody castro cuello\Documents\PROGRAMACION\Programacion III\Tarea2\Tarea II\Tarea II\Pages\Ejercicio1.razor"
                                                                      frase

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => frase = __value, frase));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n<br>\r\n");
            __builder.OpenElement(10, "button");
            __builder.AddAttribute(11, "class", "btn btn-success form-control form-control-lg");
            __builder.AddAttribute(12, "type", "button");
            __builder.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\rody castro cuello\Documents\PROGRAMACION\Programacion III\Tarea2\Tarea II\Tarea II\Pages\Ejercicio1.razor"
                                                                                      ejercicioo1

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(14, "Hacer calculo");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n<br>\r\n<br>\r\n");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "container");
            __builder.AddMarkupContent(18, "\r\n    ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "row");
            __builder.AddMarkupContent(21, "\r\n        ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "col-sm");
            __builder.AddMarkupContent(24, "\r\n            Vocales: ");
            __builder.AddContent(25, 
#nullable restore
#line 16 "C:\Users\rody castro cuello\Documents\PROGRAMACION\Programacion III\Tarea2\Tarea II\Tarea II\Pages\Ejercicio1.razor"
                      vocal

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n        ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "col-sm");
            __builder.AddMarkupContent(30, "\r\n            Consonantes: ");
            __builder.AddContent(31, 
#nullable restore
#line 19 "C:\Users\rody castro cuello\Documents\PROGRAMACION\Programacion III\Tarea2\Tarea II\Tarea II\Pages\Ejercicio1.razor"
                          consonante

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(32, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n        ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "col-sm");
            __builder.AddMarkupContent(36, "\r\n            Otros:");
            __builder.AddContent(37, 
#nullable restore
#line 22 "C:\Users\rody castro cuello\Documents\PROGRAMACION\Programacion III\Tarea2\Tarea II\Tarea II\Pages\Ejercicio1.razor"
                   espacio

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(38, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\Users\rody castro cuello\Documents\PROGRAMACION\Programacion III\Tarea2\Tarea II\Tarea II\Pages\Ejercicio1.razor"
       
    int vocal = 0;
    int consonante = 0;
    int espacio = 0;
    string frase = "";

    void ejercicioo1()
    {

        for (int i = 0; i < frase.Length; i++)
        {
            if ((frase[i] == ' '))
            {
                espacio++;
            }
            else if ((frase[i] == 'a') || (frase[i] == 'e') || (frase[i] == 'i') || (frase[i] == 'o') || (frase[i] == 'u'))
            {
                vocal++;
            }
            else { consonante++; }
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
