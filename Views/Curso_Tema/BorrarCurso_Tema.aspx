<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<MVCLaboratorio.Models.Curso_Tema>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>BorrarCurso_Tema</title>
    <link href="../../Content/ParaLegends.css" rel="stylesheet" type="text/css" />
    <link href="../../Content/ParaTxBx.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <h3>¿Esta seguro de eliminar los datos?</h3>
    <fieldset>
        <legend>Borrar un Tema dentro del Curso</legend>
        
        <div class="display-label">IdCT</div>
        <div class="display-field"><%: Model.IdCT %></div>
        
        <div class="display-label">IdCurso</div>
        <div class="display-field"><%: Model.IdCurso %></div>
        
        <div class="display-label">IdTema</div>
        <div class="display-field"><%: Model.IdTema %></div>
        
    </fieldset>
    <% using (Html.BeginForm()) { %>
        <p>
		    <input type="submit" value="Eliminar" /> |
		    <%: Html.ActionLink("Regresar", "VerCurso_Tema") %>
        </p>
    <% } %>

</body>
</html>

