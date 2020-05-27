<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<MVCLaboratorio.Models.Curso_Tema_Video>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>eliminarCurso_Tema_Video</title>
        <link href="../../Content/ParaLegends.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <h3>Estas seguro de esto¿?</h3>
    <fieldset>
        <legend>Fields</legend>
        
        
        
        <div class="display-label">IdCT</div>
        <div class="display-field"><%: Model.IdCT %></div>
        
        <div class="display-label">IdVideo</div>
        <div class="display-field"><%: Model.IdVideo %></div>
        
    </fieldset>
    <% using (Html.BeginForm()) { %>
        <p>
		    <input type="submit" value="Eliminar" /> |
		    <%: Html.ActionLink("Regresar a los cursos", "obtenerTodosCurso_Tema_Video")%>
        <a href="/Home/Index">Regresar al menu</a>
        </p>
    <% } %>

</body>
</html>

