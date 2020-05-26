using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using MVCLaboratorio.Utilerias;

namespace MVCLaboratorio.Models
{
    public class RepositorioCursoTemaVideo : ICursoTemaVideo
    {

        List<CursoTemaVideo> ICursoTemaVideo.obtenerCursosTV()
        {
            DataTable dtCursoTV;
            dtCursoTV = BaseHelper.ejecutarConsulta("sp_Curso_Tema_Video_ConsultarTodo", CommandType.StoredProcedure);

            //convertir el dataTableen una lista de Cursos

            List<CursoTemaVideo> lstCursoTV = new List<CursoTemaVideo>();
            foreach (DataRow item in dtCursoTV.Rows)
            {
                CursoTemaVideo CursoTVAux = new CursoTemaVideo();

                CursoTVAux.IdCTV = int.Parse(item["IdCTV"].ToString());
                CursoTVAux.IdCT = int.Parse(item["IdCT"].ToString());
                CursoTVAux.IdVideo = int.Parse(item["IdVideo"].ToString());

                lstCursoTV.Add(CursoTVAux);

            }

            return lstCursoTV;
        }

        CursoTemaVideo ICursoTemaVideo.obtenerCursoTV(int IdCTV)
        {
            throw new NotImplementedException();
        }

        void ICursoTemaVideo.insertarCursoTV(CursoTemaVideo datosCursoTV)
        {
            throw new NotImplementedException();
        }

        void ICursoTemaVideo.eliminarCursoTV(CursoTemaVideo datosCursoTV)
        {
            throw new NotImplementedException();
        }

        void ICursoTemaVideo.actualizarCursoTV(CursoTemaVideo datosCursoTV)
        {
            throw new NotImplementedException();
        }
    }
}