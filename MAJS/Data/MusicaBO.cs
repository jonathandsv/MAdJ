using MAJS.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace MAJS.Data
{
    public class MusicaBO
    {
        private string ConexaoBanco()
        {
            return (WebConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        }

        public List<Musica> GetMusicas()
        {
            try
            {
                string _conectionstring = ConexaoBanco();

                string buscarMusica = @"SELECT * FROM Musicas";

                SqlConnection sqlConnection = new SqlConnection(_conectionstring);

                sqlConnection.Open();

                List<Musica> musicas = new List<Musica>();

                using (SqlCommand sqlCommand = new SqlCommand(buscarMusica, sqlConnection))
                {
                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        Musica musica = new Musica();
                        musica.ID = Convert.ToInt32(reader["ID"]);
                        musica.Nome = reader["Nome"].ToString();
                        musica.Letra = reader["Letra"].ToString();
                        musica.AtivoNaoAtivo = reader["AtivoNaoAtivo"].ToString();
                        musica.DLetra = reader["DLetra"].ToString();
                        musica.DNotas = reader["DNotas"].ToString();
                        musica.CVideo = reader["CVideo"].ToString();
                        musicas.Add(musica);
                    }
                }
                return (musicas);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int CadastrarMusica(Musica musica)
        {
            try
            {
                musica.AtivoNaoAtivo = "Ativo";
                string _conectionstring = ConexaoBanco();

                string cadastrarMusica = @"INSERT INTO Musicas (Nome, Letra, AtivoNaoAtivo, DNotas, CVideo) VALUES (@Nome, @Letra, @AtivoNaoAtivo, @DNotas, @CVideo)";

                var resultado = 0;
                using (var sqlConn = new SqlConnection(_conectionstring))
                {
                    using (SqlCommand command = new SqlCommand(cadastrarMusica, sqlConn))
                    {
                        command.Parameters.Add("@Nome", SqlDbType.VarChar).Value = musica.Nome;
                        command.Parameters.Add("@Letra", SqlDbType.VarChar).Value = musica.Letra;
                        command.Parameters.Add("@AtivoNaoAtivo", SqlDbType.VarChar).Value = musica.AtivoNaoAtivo;
                        //command.Parameters.Add("@DLetra", SqlDbType.VarChar).Value = musica.DLetra;
                        command.Parameters.Add("@DNotas", SqlDbType.VarChar).Value = musica.DNotas;
                        command.Parameters.Add("@CVideo", SqlDbType.VarChar).Value = musica.CVideo;

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
    }
}