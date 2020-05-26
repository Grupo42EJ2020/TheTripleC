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
    background: #1E1E1E;
    font-family: Helvetica; 
}       
a:link, a:visited{
    padding: 20px;
    font-family: Helvetica;
    text-transform: uppercase;
    padding-left: 10px;
    padding-right: 10px;

    font-size: 15px;
    color: black;

    text-align:center;
    display: inline-block;
    margin: 20px 10px 0 20px;
    background-color: #d3dde0;
  }
    </style>
</head>
<body>
    <h1>
    BIENVENIDOS A LA PAGINA DE NUESTRO PIA 👍
    </h1>
    <h3>Menu de opciones</h3>
    

    <a href="/Empleado/VerEmpleados">Ver Tabla Empleado</a>
    <%--<br />--%>
    <a href="/Curso/watchCursos">Ver Tabla Curso</a>
    <%--<br />--%>
    <a href="/Tema/Index">Ver Tabla Tema</a>
    <%--<br />--%>
    <a href="/Video/Index">Ver Tabla Video</a>
    <%--<br />--%>
    <a href="/Curso_Tema/VerCurso_Tema">Ver Tabla Curso_Tema</a>
    <%--<br />--%>
    <a href="/Curso_Tema_Video/obtenerTodosCurso_Tema_Video">Ver Tabla Curso_Tema_Video</a>
    <%--<br />--%>


</body>
</html>
