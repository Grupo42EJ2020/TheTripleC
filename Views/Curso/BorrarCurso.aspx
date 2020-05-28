<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<MVCLaboratorio.Models.Curso>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>BorrarCurso</title>
    <link href="../../Content/ParaLegends.css" rel="stylesheet" type="text/css" />
    <link href="../../Content/ParaTxBx.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <h3>¿Esta seguro de eliminar los datos?</h3>
    <fieldset>
        <legend>Datos del Curso a Eliminar</legend>
        
        <div class="display-label">IdCurso</div>
        <div class="display-field"><%: Model.IdCurso %></div>
        
        <div class="display-label">Descripcion</div>
        <div class="display-field"><%: Model.Descripcion %></div>
        
        <div class="display-label">IdEmpleado</div>
        <div class="display-field"><%: Model.IdEmpleado %></div>
        
    </fieldset>
    <% using (Html.BeginForm()) { %>
        <p>
		    <input type="submit" value="Eliminar" /> |
<%: Html.ActionLink("Regresar", "watchCursos") %>
        </p>
    <% } %>
        <div>
        
    </div>
</body>
</html>

