<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<IEnumerable<MVCLaboratorio.Models.Curso>>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>watchCursos</title>
    <link href="../../Content/styleTable.css" rel="stylesheet" type="text/css" />
</head>
<body>
<h1 style= color:#9B00B6 >Tabla de Cursos</h1>
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
        <%: Html.ActionLink("Agregar Curso", "InsertarCurso") %>
        
    </p>
       <p>
        <a href="../Home/Index">Regresar</a>
        </p>
</body>
</html>

