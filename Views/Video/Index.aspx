﻿<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<IEnumerable<MVCLaboratorio.Models.Video>>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Index</title>
    <link href="../../Content/styleTable.css" rel="stylesheet" type="text/css" />
</head>
<body>
<h1 style= color:#9B00B6 >Tabla de Videos</h1>
    <table>
        <tr>
            <th><ul class="nav">Opciones</ul></th>
            <th>
               <ul class="nav">IdVideo</ul> 
            </th>
            <th>
                <ul class="nav">Nombre</ul>
            </th>
           
    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <%: Html.ActionLink("Editar", "EditarVideo", new {  id=item.IdVideo  }) %> |
                <%: Html.ActionLink("Detalles", "DetallesVideo", new {  id=item.IdVideo  })%> |
                <%: Html.ActionLink("Eliminar", "BorrarVideo", new {  id=item.IdVideo  })%>
            </td>
            <td>
                <%: item.IdVideo %>
            </td>
            <td>
                <%: item.Nombre %>
            </td>
            
        </tr>
    
    <% } %>

    </table>

    <p>
        <%: Html.ActionLink("Agregar Video ", "AgregarVideo") %>
    </p>
    <p>
        <a href="../Home/Index">Regresar</a>
        </p>

</body>
</html>

