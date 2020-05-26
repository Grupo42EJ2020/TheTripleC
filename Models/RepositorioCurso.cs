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
    public class RepositorioCursos : ICurso
    {
//-------------------------------------------------------------------------------------------------------------------
        public List<Curso> obtenerCursos()
        {
            DataTable dtCurso;
            dtCurso = BaseHelper.ejecutarConsulta("sp_Curso_ConsultarTodo", CommandType.StoredProcedure);

            //convertir el dataTableen una lista de Cursos

            List<Curso> lstCurso = new List<Curso>();
            foreach (DataRow item in dtCurso.Rows)
            {
                Curso CursoAux = new Curso();

                CursoAux.IdCurso = int.Parse(item["IdCurso"].ToString());
                CursoAux.Descripcion = item["Descripcion"].ToString();
                CursoAux.IdEmpleado = int.Parse(item["IdEmpleado"].ToString());

                lstCurso.Add(CursoAux);
            
            }

            return lstCurso;
        }
        //YAP
//-------------------------------------------------------------------------------------------------------------------
        public Curso obtenerCurso(int idCurso)
           {
               DataTable dtCurso;
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdCurso", idCurso));

            dtCurso = BaseHelper.ejecutarConsulta("sp_Curso_ConsultarPorID", CommandType.StoredProcedure, parametros);
            //Convertir el dtCurso a un  onjeto Curso

            Curso datosCurso = new Curso();

            if (dtCurso.Rows.Count > 0) // si lo encontro
            {
                datosCurso.IdCurso = int.Parse(dtCurso.Rows[0]["IdCurso"].ToString());
                datosCurso.Descripcion = dtCurso.Rows[0]["Descripcion"].ToString();
                datosCurso.IdEmpleado = int.Parse(dtCurso.Rows[0]["IdEmpleado"].ToString());

                return datosCurso;
            }
            else //no lo encontro
            {
                return null;
            }
            
        }
        //YAP ESTO ES PARTE DEL DELETE

//-------------------------------------------------------------------------------------------------------------------        
        public void insertarCurso(Curso datosCurso)
        {
            // Realizacion del update
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@Descripcion", datosCurso.Descripcion));
            parametros.Add(new SqlParameter("@IdEmpleado", datosCurso.IdEmpleado));

            BaseHelper.ejecutarConsulta("sp_Curso_Agregar", CommandType.StoredProcedure, parametros);
        }
//-------------------------------------------------------------------------------------------------------------------
        public void eliminarCurso(int idCurso)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdCurso", idCurso));
            BaseHelper.ejecutarSentencia("sp_Curso_Borrar", CommandType.StoredProcedure, parametros);
        }
        //YAP
//-------------------------------------------------------------------------------------------------------------------

        //ACTUALIZAR CURSO
        public void actualizarCurso(Curso datosCurso)
        {
           // Realizacion del update
                  List<SqlParameter> parametros = new List<SqlParameter>();
                   parametros.Add(new SqlParameter("@IdCurso", datosCurso.IdCurso));
                   parametros.Add(new SqlParameter("@Descripcion", datosCurso.Descripcion));
                   parametros.Add(new SqlParameter("@IdEmpleado", datosCurso.IdEmpleado));

                   BaseHelper.ejecutarConsulta("sp_Curso_Modificar", CommandType.StoredProcedure, parametros);
                   
               }

    
//-------------------------------------------------------------------------------------------------------------------
       






        
    }
}