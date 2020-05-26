<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<IEnumerable<MVCLaboratorio.Models.Empleado>>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>VerEmpleados</title>
</head>
<body>
    <table>
        <tr>
            <th></th>
            <th>
                IdEmpleado
            </th>
            <th>
                Nombre
            </th>

        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <%: Html.ActionLink("Editar", "EditarEmpleado", new { id=item.IdEmpleado }) %> |
                <%: Html.ActionLink("Detalles", "DetallesEmpleado", new { id = item.IdEmpleado })%> |
                <%: Html.ActionLink("Borrar", "BorrarEmpleado", new { id = item.IdEmpleado })%>
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
        <%: Html.ActionLink("Agregar Empleado", "AgregarEmpleado") %>
    </p>
    <a href="../Home/Index">Ir a la lista de tablas</a>
</body>
</html>

