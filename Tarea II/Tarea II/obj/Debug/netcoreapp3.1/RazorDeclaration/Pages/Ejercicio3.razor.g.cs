// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Ejercicio3")]
    public partial class Ejercicio3 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "C:\Users\rody castro cuello\Documents\PROGRAMACION\Programacion III\Tarea2\Tarea II\Tarea II\Pages\Ejercicio3.razor"
       
    //Declaración de variables a nivel de método o función.
    string cedula;
    int verificador;
    int digito;
    int digitoVerificador;
    int digitoImpar;
    int sumaPar;
    int sumaImpar;
    int longitud;

    string cedulaverdadera;


    string ErrorCantidad = "";
    string ValidoError = "";


    void ValidaCedula()
    {

        try
        {
            if (longitud == 11)
            {

            }
            else
            {
                ErrorCantidad = "La cédula debe contener once(11) digitos";
            }
        }
        catch
        {
            ValidoError = "Sintasis incorrecta";
        }

    }

    

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
