using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCLaboratorio.Models
{
    public interface ICurso_Tema
    {
        List<Curso_Tema> obtenerTodosCurso_Tema();
        Curso_Tema obtenerUnCurso_Tema(int IdCT);
        void insertarCurso_Tema(Curso_Tema datosCurso_Tema);
        void eliminarCurso_Tema(int IdCT);
        void actualizarCurso_Tema(Curso_Tema datosCurso_Tema);
    }
}