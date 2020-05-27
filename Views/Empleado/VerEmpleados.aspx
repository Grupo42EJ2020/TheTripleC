<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<IEnumerable<MVCLaboratorio.Models.Empleado>>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>VerEmpleados</title>
    <link href="../../Content/styleTable.css" rel="stylesheet" type="text/css" />

</head>
<body>
    <h1 style= color:#9B00B6 >Tabla de Empleados</h1>
    <table>
        <tr>
        
            <th><ul class="nav">Opciones</ul></th>
            <th>
               <ul class="nav"> IdEmpleado</ul>
            </th>
            <th>
                <ul class="nav">Nombre</ul>
            </th>
            
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <%: Html.ActionLink("Editar", "EditarEmpleado", new { id=item.IdEmpleado }) %> |
                <%: Html.ActionLink("Detalles", "DetallesEmpleado", new { id = item.IdEmpleado })%> |
                <%: Html.ActionLink("Eliminar", "BorrarEmpleado", new { id = item.IdEmpleado })%>
            </td>
            <td>
                <%: item.IdEmpleado %>
            </td>
            <td>
                <%: item.Nombre %>
            </td>
          
        </tr>
    
    <% } %>

    </table>

    <p>
     
        <%:  Html.ActionLink("Agregar Empleado", "AgregarEmpleado") %>
    </p>
    <p>
        <a href="../Home/Index">Regresar</a>
        </p>
</body>
</html>

