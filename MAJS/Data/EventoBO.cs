using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using MAJS.Models;

namespace MAJS.Data
{
    public class EventoBO
    {
        private string ConexaoBanco()
        {
            return (WebConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        }
        public Evento GetEvento(int id)
        {
            return (null);
        }

        public List<Evento> GetEventos()
        {
            try
            {
                string _conectionstring = ConexaoBanco();

                string buscarEventos = @"SELECT * FROM Eventos";

                SqlConnection sqlConnection = new SqlConnection(_conectionstring);

                sqlConnection.Open();

                List<Evento> eventos = new List<Evento>();

                using (SqlCommand sqlCommand = new SqlCommand(buscarEventos, sqlConnection))
                {
                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        Evento evento = new Evento();
                        evento.IDEvento = Convert.ToInt32(reader["IDEvento"]);
                        evento.IDEventoPerfil = Convert.ToInt32(reader["IDEventoPerfil"]);
                        evento.Titulo = reader["Titulo"].ToString();
                        evento.Descricao = reader["Descricao"].ToString();
                        evento.Hora = Convert.ToDateTime(reader["Hora"]);
                        evento.Data = Convert.ToDateTime(reader["Data"]);
                        evento.Local = reader["Local"].ToString();
                        eventos.Add(evento);
                    }
                }
                return (eventos);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}