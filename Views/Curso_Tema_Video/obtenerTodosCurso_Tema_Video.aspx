<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<IEnumerable<MVCLaboratorio.Models.Curso_Tema_Video>>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>obtenerTodosCurso_Tema_Video</title>
    <link href="../../Content/DiseñoV2.css" rel="stylesheet" type="text/css" />
</head>
<body>
<h1 style= color:#9B00B6 >Tabla de Cursos Temas y Videos</h1>
    <table>
        <tr>
            <th><ul class="nav">Opciones</ul></th>
            <th>
                <ul class="nav">IdCTV</ul>
            </th>
            <th>
                <ul class="nav">IdCT</ul>
            </th>
            <th>
                <ul class="nav">IdVideo</ul>
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
        <%: Html.ActionLink("Agregar Curso con Tema y Video", "insertarCurso_Tema_Video")%>
    
    </p>
        <p>
        <a href="../Home/Index">Regresar</a>
        </p>
</body>
</html>

