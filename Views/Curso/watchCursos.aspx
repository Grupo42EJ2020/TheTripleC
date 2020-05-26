﻿<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<IEnumerable<MVCLaboratorio.Models.Curso>>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>watchCursos</title>
</head>
<body>
    <table>
        <tr>
            <th></th>
            <th>
                IdCurso
            </th>
            <th>
                Descripcion
            </th>
            <th>
                IdEmpleado
            </th>
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <%: Html.ActionLink("Editar", "actualizarCurso", new { id = item.IdCurso })%> |
                <%: Html.ActionLink("Detalles", "DetallesCurso", new { id = item.IdCurso })%> |
                <%: Html.ActionLink("Eliminar", "BorrarCurso", new {  id=item.IdCurso  })%>
            </td>
            <td>
                <%: item.IdCurso %>
            </td>
            <td>
                <%: item.Descripcion %>
            </td>
            <td>
                <%: item.IdEmpleado %>
            </td>
        </tr>
    
    <% } %>

    </table>

    <p>
        <%: Html.ActionLink("Agregar Cursos", "InsertarCurso") %>
        <%: Html.ActionLink("regresar al menu", "Index") %>
    </p>

</body>
</html>
