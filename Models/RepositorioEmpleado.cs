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
    public class RepositorioEmpleado : IEmpleado
    {
        public List<Empleado> obtenerEmpleados()
        {
            //OBTENER LA INFORMACION DE LOS EMPLEADOS DE LA BD
            DataTable dtEmpleados;
            dtEmpleados = BaseHelper.ejecutarConsulta("sp_Empleado_ConsultarTodo", CommandType.StoredProcedure);

            List<Empleado> lstEmpleados = new List<Empleado>();
            //Convertir el data table a una lista de Empleados  List<Empleado>
            foreach (DataRow item in dtEmpleados.Rows)
            {
                Empleado EmpleadoAux = new Empleado();

                EmpleadoAux.IdEmpleado = int.Parse(item["idEmpleado"].ToString());
                EmpleadoAux.Nombre = item["Nombre"].ToString();
                EmpleadoAux.Direccion = item["Direccion"].ToString();

                lstEmpleados.Add(EmpleadoAux);
            }

            return lstEmpleados;
        }

        public Empleado obtenerEmpleado(int idEmpleado)
        {
            DataTable dtEmpleado;
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdEmpleado", idEmpleado));

            dtEmpleado = BaseHelper.ejecutarConsulta("sp_Empleado_ConsultarPorID", CommandType.StoredProcedure, parametros);

            //convertir el dtVideo a un objeto Video
            Empleado datosEmpleado = new Empleado();

            if (dtEmpleado.Rows.Count > 0) //si lo encontro
            {
                datosEmpleado.IdEmpleado = int.Parse(dtEmpleado.Rows[0]["IdEmpleado"].ToString());
                datosEmpleado.Nombre = dtEmpleado.Rows[0]["Nombre"].ToString();
                datosEmpleado.Direccion = dtEmpleado.Rows[0]["Direccion"].ToString();

                return datosEmpleado;
            }
            else
            { //no lo encontro 
                return null;
            }
        }

        public void insertarEmpleado(Empleado datosEmpleado)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@Nombre", datosEmpleado.Nombre));
            parametros.Add(new SqlParameter("@Direccion", datosEmpleado.Direccion));
 

            BaseHelper.ejecutarConsulta("sp_Empleado_Agregar", CommandType.StoredProcedure, parametros);
        }

        public void eliminarEmpleado(int idEmpleado)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdEmpleado", idEmpleado));

            BaseHelper.ejecutarSentencia("sp_Empleado_Borrar", CommandType.StoredProcedure, parametros);
        }

        public void actualizarEmpleado(Empleado datosEmpleado)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdEmpleado", datosEmpleado.IdEmpleado));
            parametros.Add(new SqlParameter("@Nombre", datosEmpleado.Nombre));
            parametros.Add(new SqlParameter("@Direccion", datosEmpleado.Direccion));
   

            BaseHelper.ejecutarConsulta("sp_Empleado_Modificar", CommandType.StoredProcedure, parametros);
        }
    }
}