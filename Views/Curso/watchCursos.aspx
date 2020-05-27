<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<IEnumerable<MVCLaboratorio.Models.Curso>>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>watchCursos</title>
    <link href="../../Content/styleTable.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <table>
     <tr>
            <th><ul class="nav">Opciones</ul></th>
            <th><ul class="nav">IdCurso</ul></th>
            <th><ul class="nav">Descripcion</ul></th>
            
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

        </tr>
    
    <% } %>

    </table>

    <p>
        <%: Html.ActionLink("Agregar Cursos", "InsertarCurso") %>
        <%: Html.ActionLink("regresar al menu", "Index") %>
    </p>
    <a href="../Curso_Tema/AgregarCurso_Tema">Añadir un Tema a Curso</a>
</body>
</html>

