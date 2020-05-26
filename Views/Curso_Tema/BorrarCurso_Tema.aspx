<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<MVCLaboratorio.Models.Curso_Tema>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>BorrarCurso_Tema</title>
</head>
<body>
    <h3>Are you sure you want to delete this?</h3>
    <fieldset>
        <legend>Fields</legend>
        
        <div class="display-label">IdCT</div>
        <div class="display-field"><%: Model.IdCT %></div>
        
        <div class="display-label">IdCurso</div>
        <div class="display-field"><%: Model.IdCurso %></div>
        
        <div class="display-label">IdTema</div>
        <div class="display-field"><%: Model.IdTema %></div>
        
    </fieldset>
    <% using (Html.BeginForm()) { %>
        <p>
		    <input type="submit" value="Borrar" /> |
		    <%: Html.ActionLink("Regresar a las lista", "VerCurso_Tema") %>
        </p>
    <% } %>

</body>
</html>

