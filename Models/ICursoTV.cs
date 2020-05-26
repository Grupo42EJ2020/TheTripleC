using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCLaboratorio.Models
{
    public interface ICursoTemaVideo
    {
        List<CursoTemaVideo> obtenerCursosTV();
        CursoTemaVideo obtenerCursoTV(int IdCTV);
        void insertarCursoTV(CursoTemaVideo datosCursoTV);
        void eliminarCursoTV(CursoTemaVideo datosCursoTV);
        void actualizarCursoTV(CursoTemaVideo datosCursoTV);

    }
}