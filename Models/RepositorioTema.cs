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
           DataTable dtTema;
           dtTema = BaseHelper.ejecutarConsulta("sp_Tema_ConsultarTodo", CommandType.StoredProcedure);

            List<Tema> lstTema = new List<Tema>();

            foreach (DataRow item in dtTema.Rows)
            {
                Tema temaAux = new Tema();
                temaAux.IdTema = int.Parse(item["IdTema"].ToString());
                temaAux.Nombre = item["Nombre"].ToString();
          
                lstTema.Add(temaAux);
            }
            return lstTema;
        }

        public Tema obtenerTema(int IdTema)
        {
            DataTable dtTema;
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdTema", IdTema));

            dtTema = BaseHelper.ejecutarConsulta("sp_Tema_ConsultarPorID", CommandType.StoredProcedure,parametros);

            Tema datosTema = new Tema();

            if (dtTema.Rows.Count > 0) //si lo encontro
            {
                datosTema.IdTema = int.Parse(dtTema.Rows[0]["IdTema"].ToString());
                datosTema.Nombre = dtTema.Rows[0]["Nombre"].ToString();
                
                return datosTema;
            }
            else { //no lo encontro 
                return null;
            }
        }

        public void insertarTema(Tema datosTema)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@Nombre", datosTema.Nombre));
           
            BaseHelper.ejecutarConsulta("sp_Tema_Agregar", CommandType.StoredProcedure, parametros);

        }
    
        public void eliminarTema(int IdTema)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdTema",IdTema));

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