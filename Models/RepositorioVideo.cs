﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using MVCLaboratorio.Utilerias;
using System.Data.SqlClient;
using MVCLaboratorio.Models;


namespace MVCLaboratorio.Models
{
    public class RepositorioVideo : IVideo 
    {
        public List<Video> obtenerVideos()
        {
            DataTable dtVideos;
            dtVideos = BaseHelper.ejecutarConsulta("sp_Video_ConsultarTodo", CommandType.StoredProcedure);

            List<Video> lstVideos = new List<Video>();

            //convertir el DataTable a una lista de videos List<Video>
            foreach (DataRow item in dtVideos.Rows)
            {
                Video videoAux = new Video();
                videoAux.IdVideo = int.Parse(item["IdVideo"].ToString());
                videoAux.Nombre = item["Nombre"].ToString();
                videoAux.Url = item["Url"].ToString();
                videoAux.FechaPublicacion = DateTime.Parse(item["FechaPublicacion"].ToString());

                lstVideos.Add(videoAux);
            }

            return lstVideos;
        }

        public Video obtenerVideo(int idVideo)
        {
            DataTable dtVideo;
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", idVideo));

            dtVideo = BaseHelper.ejecutarConsulta("sp_Video_ConsultarPorID", CommandType.StoredProcedure, parametros);

            //convertir el dtVideo a un objeto Video
            Video datosVideo = new Video();

            if (dtVideo.Rows.Count > 0) //si lo encontro
            {
                datosVideo.IdVideo = int.Parse(dtVideo.Rows[0]["IdVideo"].ToString());
                datosVideo.Nombre = dtVideo.Rows[0]["Nombre"].ToString();
                datosVideo.Url = dtVideo.Rows[0]["Url"].ToString();
                datosVideo.FechaPublicacion = DateTime.Parse(dtVideo.Rows[0]["FechaPublicacion"].ToString());

                return datosVideo;
            }
            else
            { //no lo encontro 
                return null;
            }
        }

        public void insertarVideo(Video datosVideo)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@Nombre", datosVideo.Nombre));
            parametros.Add(new SqlParameter("@Url", datosVideo.Url));
            parametros.Add(new SqlParameter("@FechaPublicacion", datosVideo.FechaPublicacion));

            BaseHelper.ejecutarConsulta("sp_Video_Agregar", CommandType.StoredProcedure, parametros);
        }

        public void eliminarVideo(int idVideo)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", idVideo));

            BaseHelper.ejecutarSentencia("sp_Video_Borrar", CommandType.StoredProcedure, parametros);
        }

        public void actualizarVideo(Video datosVideo)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", datosVideo.IdVideo));
            parametros.Add(new SqlParameter("@Nombre", datosVideo.Nombre));
            parametros.Add(new SqlParameter("@Url", datosVideo.Url));
            parametros.Add(new SqlParameter("@FechaPublicacion", datosVideo.FechaPublicacion));

            BaseHelper.ejecutarConsulta("sp_Video_Modificar", CommandType.StoredProcedure, parametros);


        }
    }
}