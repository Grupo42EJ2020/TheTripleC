<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<IEnumerable<MVCLaboratorio.Models.Tema>>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Index</title>
</head>
<body>
    <h1>TABLA DE TEMAS</h1>
    <table>
        <tr>
            <th></th>
            <th>
                IdTema
            </th>
            <th>
                Nombre
            </th>
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <%: Html.ActionLink("Editar", "EditarTema", new {  id=item.IdTema }) %> |
                <%: Html.ActionLink("Detalles", "DetallesTema", new {  id=item.IdTema  })%> |
                <%: Html.ActionLink("Eliminar", "BorrarTema", new {  id=item.IdTema  })%>
            </td>
            <td>
                <%: item.IdTema %>
            </td>
            <td>
                <%: item.Nombre %>
            </td>
        </tr>
    
    <% } %>

    </table>

    <p>
        <%: Html.ActionLink("Agregar un nuevo Tema", "AgregarTema") %>
    </p>
<<<<<<< HEAD

    <a href="../Curso_Tema/AgregarCurso_Tema">Añadir un Tema a Curso</a>
=======
    <p>
        <a href="../Home/Index">Regresar</a>
    </p>

>>>>>>> 1ab7773a89853388ed120a3a0d450df3c4f53756
</body>
</html>

