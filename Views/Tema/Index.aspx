<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<IEnumerable<MVCLaboratorio.Models.Tema>>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Index</title>
</head>
<body>
   <h1>TABLA DE TEMAS </h1> <table>
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
                <%: Html.ActionLink("Editar", "EditTema", new {  id=item.IdTema  }) %> |
                <%: Html.ActionLink("Detalles", "DetailsTema", new {  id=item.IdTema  })%> |
                <%: Html.ActionLink("Eliminar", "DeleteTema", new {  id=item.IdTema  })%>
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
        <%: Html.ActionLink("Agregar Tema Nuevo", "CreateTema") %>
        <br />
        <a href="Home/Index">Regresar</a>
    </p>
  
</body>
</html>

