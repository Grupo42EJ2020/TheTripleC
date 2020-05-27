﻿<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<IEnumerable<MVCLaboratorio.Models.Curso_Tema_Video>>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>obtenerTodosCurso_Tema_Video</title>
</head>
<body>
    <table>
        <tr>
            <th></th>
            <th>
                IdCTV
            </th>
            <th>
                IdCT
            </th>
            <th>
                IdVideo
            </th>
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <%: Html.ActionLink("Editar", "actualizarCurso_Tema_Video", new { id = item.IdCTV })%> |
                <%: Html.ActionLink("Detalles", "obtenerUnCurso_Tema_Video", new { id = item.IdCTV })%> |
                <%: Html.ActionLink("Eliminar", "eliminarCurso_Tema_Video", new { id = item.IdCTV })%>
            </td>
            <td>
                <%: item.IdCTV %>
            </td>
            <td>
                <%: item.IdCT %>
            </td>
            <td>
                <%: item.IdVideo %>
            </td>
        </tr>
    
    <% } %>

    </table>

    <p>
        <%: Html.ActionLink("Agregar un Curso", "insertarCurso_Tema_Video")%>
        <a href="/Home/Index">Regresar al menu</a>
    </p>

</body>
</html>

