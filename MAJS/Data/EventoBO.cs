using System;
using System.Collections.Generic;
using System.Data;
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
                        evento.Hora = TimeSpan.Parse(reader["Hora"].ToString());
                        evento.Data = DateTime.Parse(reader["Data"].ToString());
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

        public int CadastrarEvento(Evento evento)
        {
            try
            {
                string _conectionstring = ConexaoBanco();

                string cadastrarEventos = @"INSERT INTO Eventos (IDEventoPerfil, Titulo, Descricao, Hora, Data, Local) VALUES (@IDEventoPerfil, @Titulo, @Descricao, @Hora, @Data, @Local)";

                var resultado = 0;
                using (var sqlConn = new SqlConnection(_conectionstring))
                {
                    using (SqlCommand command = new SqlCommand(cadastrarEventos, sqlConn))
                    {
                        command.Parameters.Add("@IDEventoPerfil", SqlDbType.Int).Value = evento.IDEventoPerfil;
                        command.Parameters.Add("@Titulo", SqlDbType.VarChar, 50).Value = evento.Titulo;
                        command.Parameters.Add("@Descricao", SqlDbType.VarChar, 50).Value = evento.Descricao;
                        command.Parameters.Add("@Hora", SqlDbType.DateTime).Value = evento.Hora;
                        command.Parameters.Add("@Data", SqlDbType.DateTime).Value = evento.Data;
                        command.Parameters.Add("@Local", SqlDbType.VarChar).Value = evento.Local;

                        sqlConn.Open();
                        resultado = command.ExecuteNonQuery();
                        sqlConn.Close();
                    }
                }

                return (resultado);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<EventoPerfil> BuscarEventosPerfis()
        {
            try
            {
                string _conectionstring = ConexaoBanco();

                string buscarEventosPerfis = @"SELECT * FROM EventoPerfil";

                SqlConnection sqlConnection = new SqlConnection(_conectionstring);

                sqlConnection.Open();

                List<EventoPerfil> eventosPerfis = new List<EventoPerfil>();

                using (SqlCommand sqlCommand = new SqlCommand(buscarEventosPerfis, sqlConnection))
                {
                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        EventoPerfil eventoPerfil = new EventoPerfil();
                        eventoPerfil.ID = Convert.ToInt32(reader["ID"]);
                        eventoPerfil.IDEventoPerfil = Convert.ToInt32(reader["IDEventoPerfil"]);
                        eventoPerfil.Descricao = reader["Descricao"].ToString();
                        eventosPerfis.Add(eventoPerfil);
                    }
                }
                return (eventosPerfis);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
    }
}