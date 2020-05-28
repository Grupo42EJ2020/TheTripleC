<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<MVCLaboratorio.Models.Curso_Tema>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>DetallesCurso_Tema</title>
    <link href="../../Content/ParaLegends.css" rel="stylesheet" type="text/css" />
    <link href="../../Content/ParaTxBx.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <fieldset>
        <legend>Detalles del Tema</legend>
        
        <div class="display-label">IdCT</div>
        <div class="display-field"><%: Model.IdCT %></div>
        
        <div class="display-label">IdCurso</div>
        <div class="display-field"><%: Model.IdCurso %></div>

   <%--   QUERIA PONER DOS MODELOS EN UNA VISTA PARA QUE AL VER LOS DTALLES SE VIERA EL NOMBRE DEL CURSO Y TEMA Y NOSOLAMENTE EL ID
     <div class="display-label">IdCurso</div>
        <div class="display-field"><%: Model.Descripcion %></div>--%>
        
        <div class="display-label">IdTema</div>
        <div class="display-field"><%: Model.IdTema %></div>
        
    </fieldset>
    <p>
        <%: Html.ActionLink("Editar", "EditarCurso_Tema", new { id = Model.IdCT })%> |
        <%: Html.ActionLink("Regresar", "VerCurso_Tema") %>
    </p>

</body>
</html>

