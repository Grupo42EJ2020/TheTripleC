using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using MVCLaboratorio.Utilerias;
using System.Data.SqlClient;
using MVCLaboratorio.Models;
namespace MVCLaboratorio.Models
{
    public class RepositorioCurso_Tema_Video : ICurso_Tema_Video
    {

        public List<Curso_Tema_Video> obtenerTodosCurso_Tema_Video()
        {
            //OBTENER LA INFORMACION DE LOS EMPLEADOS DE LA BD------
            DataTable dtCurso_Tema_Video;
            dtCurso_Tema_Video = BaseHelper.ejecutarConsulta("sp_Curso_Tema_Video_ConsultarTodo", CommandType.StoredProcedure);

            List<Curso_Tema_Video> lstCurso_Tema_Video = new List<Curso_Tema_Video>();
            //Convertir el data table a una lista de Curso_Tema_Video  List<Curso_Tema_Video>
            foreach (DataRow item in dtCurso_Tema_Video.Rows)
            {
                Curso_Tema_Video Curso_Tema_VideoAux = new Curso_Tema_Video();

                Curso_Tema_VideoAux.IdCTV = int.Parse(item["IdCTV"].ToString());
                Curso_Tema_VideoAux.IdCT = int.Parse(item["IdCT"].ToString());
                Curso_Tema_VideoAux.IdVideo = int.Parse(item["IdVideo"].ToString());

                lstCurso_Tema_Video.Add(Curso_Tema_VideoAux);
            }

            return lstCurso_Tema_Video;
        }
        //yap_________________________________________________________

        public Curso_Tema_Video obtenerUnCurso_Tema_Video(int IdCTV)
        {
            //obteneruncurso-----------------------------------------
            DataTable dtCursoTV;
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdCTV", IdCTV));

            dtCursoTV = BaseHelper.ejecutarConsulta("sp_Curso_Tema_Video_ConsultarPorID", CommandType.StoredProcedure, parametros);
            //Convertir el dtCurso a un  onjeto Curso

            Curso_Tema_Video datosCurso_Tema_Video = new Curso_Tema_Video();

            if (dtCursoTV.Rows.Count > 0) // si lo encontro
            {
                datosCurso_Tema_Video.IdCTV = int.Parse(dtCursoTV.Rows[0]["IdCTV"].ToString());
                datosCurso_Tema_Video.IdCT = int.Parse(dtCursoTV.Rows[0]["IdCT"].ToString());
                datosCurso_Tema_Video.IdVideo = int.Parse(dtCursoTV.Rows[0]["IdVideo"].ToString());

                return datosCurso_Tema_Video;
            }
            else //no lo encontro
            {
                return null;
            }
        }
        //yap________________________________________________________
        public void insertarCurso_Tema_Video(Curso_Tema_Video datosCurso_Tema_Video)
        {
            //Realizar el update-------------------------------------
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdCT", datosCurso_Tema_Video.IdCT));
            parametros.Add(new SqlParameter("IdVideo", datosCurso_Tema_Video.IdVideo));

            BaseHelper.ejecutarConsulta("sp_Curso_Tema_Video_Agregar", CommandType.StoredProcedure, parametros);

        }
        //yap_________________________________________________________

        public void eliminarCurso_Tema_Video(int IdCTV)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdCTV", IdCTV));
            BaseHelper.ejecutarSentencia("sp_Curso_Tema_Video_Borrar", CommandType.StoredProcedure, parametros);

        }
        //yap_________________________________________________________

        public void actualizarCurso_Tema_Video(Curso_Tema_Video datosCurso_Tema_Video)
        {
            //update---------------------------------------------------
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdCTV", datosCurso_Tema_Video.IdCTV));
            parametros.Add(new SqlParameter("@IdCT", datosCurso_Tema_Video.IdCT));
            parametros.Add(new SqlParameter("@IdVideo", datosCurso_Tema_Video.IdVideo));

            BaseHelper.ejecutarConsulta("sp_Curso_Tema_Video_Modificar", CommandType.StoredProcedure, parametros);
        }
       //yap____________________________________________________________
    }
}