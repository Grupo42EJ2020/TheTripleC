<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<IEnumerable<MVCLaboratorio.Models.Curso_Tema>>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>VerCurso_Tema</title>
    <link href="../../Content/styleTable.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <table>
        <tr>
            <th></th>
            <th>
                IdCT
            </th>

        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <%: Html.ActionLink("Editar", "EditarCurso_Tema", new { id = item.IdCT })%> |
                <%: Html.ActionLink("Detalles", "DetallesCurso_Tema", new { id = item.IdCT })%> |
                <%: Html.ActionLink("Borrar", "BorrarCurso_Tema", new { id = item.IdCT })%>
            </td>
            <td>
                <%: item.IdCT %>
            </td>

        </tr>
    
    <% } %>

    </table>

    <p>
        <%: Html.ActionLink("Agregar", "AgregarCurso_Tema") %>
    </p>

</body>
</html>

