<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Pia Desarrollo de Software</title>
     <style type="text/css"> 
html, body {
    width: 100%;
    height: 110%; 
    color: white;
    text-align:center;
    
    font-family: Helvetica; 
}       
a:link, a:visited
{
    text-decoration: none;
    padding: 20px;
    font-family: Helvetica;
    text-transform: uppercase;
    padding-left: 10px;
    padding-right: 10px;
    font-size: 15px;
    color: white;
    text-align:center;
    display: inline-block;
    margin: 20px 10px 0 20px;
    background-color: #9B00B6;
   
  }
  .center {
  margin: auto;
  width: 95%;
  border: 3px solid #6A6A6A;
  padding: 10px;
}
    </style>
</head>
<body background ="../../Content/Purple-Abstract-Black-Wallpaper-28416.jpg" ;>
    <h1>
    BIENVENIDOS A LA PAGINA DE NUESTRO PIA 👍
    </h1>
    <div class="center">
    
    <h3>Menu de opciones</h3>
    
    <a href="/Empleado/VerEmpleados">Empleados</a>
    <%--<br />--%>
    <a href="/Curso/watchCursos">Cursos</a>
    <%--<br />--%>
    <a href="/Tema/Index">Temas</a>
    <%--<br />--%>
    <a href="/Video/Index">Videos</a>
    <%--<br />--%>
    <a href="/Curso_Tema/VerCurso_Tema">Cursos y sus Temas</a>
    <%--<br />--%>
    <a href="/Curso_Tema_Video/obtenerTodosCurso_Tema_Video">Cursos Temas y sus Videos</a>
    <%--<br />--%>

    </div>
</body>
</html>
