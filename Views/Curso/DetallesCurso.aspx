﻿<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<MVCLaboratorio.Models.Curso>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>DetallesCurso</title>
    <link href="../../Content/ParaLegends.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <fieldset>
        <legend>Datos</legend>
        
        <div class="display-label">IdCurso</div>
        <div class="display-field"><%: Model.IdCurso %></div>
        
        <div class="display-label">Descripcion</div>
        <div class="display-field"><%: Model.Descripcion %></div>
        
        <div class="display-label">IdEmpleado</div>
        <div class="display-field"><%: Model.IdEmpleado %></div>
        
    </fieldset>
    <p>
        <%: Html.ActionLink("Editar", "actualizarCurso", new {  id=Model.IdCurso  }) %> |
        <%: Html.ActionLink("Regresar a la lista de cursos", "watchCursos") %>
    </p>

</body>
</html>

