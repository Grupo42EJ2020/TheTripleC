﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCLaboratorio.Models
{
    public interface ICurso_Tema_Video
    {
        List<Curso_Tema_Video> obtenerTodosCurso_Tema_Video();
        Curso_Tema_Video obtenerUnCurso_Tema_Video(int IdCTV);
        void insertarCurso_Tema_Video(Curso_Tema_Video datosCurso_Tema_Video);
        void eliminarCurso_Tema_Video(int IdCTV);
        void actualizarCurso_Tema_Video(Curso_Tema_Video datosCurso_Tema_Video);
    }
}