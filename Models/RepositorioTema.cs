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
    public class RepositorioTema : ITema
    {
        public List<Tema> obtenerTemas()
        {
            DataTable dtTemas;
            dtTemas = BaseHelper.ejecutarConsulta("sp_Tema_ConsultarTodo", CommandType.StoredProcedure);

            List<Tema> lstTemas = new List<Tema>();

            foreach (DataRow item in dtTemas.Rows)
            {
                Tema TemaAux = new Tema();

                TemaAux.IdTema = int.Parse(item["idTema"].ToString());
                TemaAux.Nombre = item["Nombre"].ToString();
               
                lstTemas.Add(TemaAux);
            }

            return lstTemas;
        }

        public Tema obtenerTema(int idTema)
        {
            DataTable dtTema;
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdTema", idTema));

            dtTema = BaseHelper.ejecutarConsulta("sp_Tema_ConsultarPorID", CommandType.StoredProcedure, parametros);

            Tema datosTema = new Tema();

            if (dtTema.Rows.Count > 0) //si lo encontro
            {
                datosTema.IdTema = int.Parse(dtTema.Rows[0]["IdTema"].ToString());
                datosTema.Nombre = dtTema.Rows[0]["Nombre"].ToString();
                

                return datosTema;
            }
            else
            { //no lo encontro 
                return null;
            }
        }

        public void insertarTema(Tema datosTema)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@Nombre", datosTema.Nombre));
           
            BaseHelper.ejecutarConsulta("sp_Tema_Agregar", CommandType.StoredProcedure, parametros);
        }

        public void eliminarTema(int idTema)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdTema", idTema));

            BaseHelper.ejecutarSentencia("sp_Tema_Borrar", CommandType.StoredProcedure, parametros);
        }

        public void actualizarTema(Tema datosTema)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdTema", datosTema.IdTema));
            parametros.Add(new SqlParameter("@Nombre", datosTema.Nombre));

            BaseHelper.ejecutarConsulta("sp_Tema_Modificar", CommandType.StoredProcedure, parametros);
        }
    }
}