﻿<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<MVCLaboratorio.Models.Empleado>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>BorrarEmpleado</title>
</head>
<body>
    <h3>Are you sure you want to delete this?</h3>
    <fieldset>
        <legend>Fields</legend>
        
        <div class="display-label">IdEmpleado</div>
        <div class="display-field"><%: Model.IdEmpleado %></div>
        
        <div class="display-label">Nombre</div>
        <div class="display-field"><%: Model.Nombre %></div>
        
        <div class="display-label">Direccion</div>
        <div class="display-field"><%: Model.Direccion %></div>
        
    </fieldset>
    <% using (Html.BeginForm()) { %>
        <p>
		    <input type="submit" value="Delete" /> |
		    <%: Html.ActionLink("Back to List", "VerEmpleados") %>
        </p>
    <% } %>

</body>
</html>

