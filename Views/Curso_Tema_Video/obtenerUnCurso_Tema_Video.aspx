﻿<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<MVCLaboratorio.Models.Curso_Tema_Video>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>obtenerUnCurso_Tema_Video</title>
</head>
<body>
    <fieldset>
        <legend>Fields</legend>
        
        <div class="display-label">IdCTV</div>
        <div class="display-field"><%: Model.IdCTV %></div>
        
        <div class="display-label">IdCT</div>
        <div class="display-field"><%: Model.IdCT %></div>
        
        <div class="display-label">IdVideo</div>
        <div class="display-field"><%: Model.IdVideo %></div>
        
    </fieldset>
    <p>
        <%: Html.ActionLink("Edit", "actualizarCurso_Tema_Video", new { /* id=Model.PrimaryKey */ })%> |
        <a href="/Home/Index">Regresar al menu</a>
    </p>

</body>
</html>

