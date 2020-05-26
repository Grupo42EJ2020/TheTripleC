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
            //OBTENER LA INFORMACION DE LOS EMPLEADOS DE LA BD
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

        public Curso_Tema_Video obtenerUnCurso_Tema_Video(int IdCTV)
        {
            throw new NotImplementedException();
        }

        public void insertarCurso_Tema_Video(Curso_Tema_Video datosCurso_Tema_Video)
        {
            throw new NotImplementedException();
        }

        public void eliminarCurso_Tema_Video(int IdCTV)
        {
            throw new NotImplementedException();
        }

        public void actualizarCurso_Tema_Video(Curso_Tema_Video datosCurso_Tema_Video)
        {
            throw new NotImplementedException();
        }
    }
}