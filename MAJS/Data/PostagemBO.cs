using MAJS.Models;
using MAJS.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace MAJS.Data
{
    public class PostagemBO
    {
        private string ConexaoBanco()
        {
            return (WebConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        }

        public List<Postagem> GetPostagens()
        {
            try
            {
                string _conectionstring = ConexaoBanco();

                string buscarPostagem = @"SELECT * FROM Postagens";

                SqlConnection sqlConnection = new SqlConnection(_conectionstring);

                sqlConnection.Open();

                List<Postagem> postagens = new List<Postagem>(); 

                using (SqlCommand sqlCommand = new SqlCommand(buscarPostagem, sqlConnection))
                {
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        Postagem postagem = new Postagem();

                        postagem.IDPostagem = Convert.ToInt32(reader["IDPostagem"]);
                        postagem.IDUsuario = Convert.ToInt32(reader["IDUsuario"]);
                        postagem.IDEnsaio = Convert.ToInt32(reader["IDEnsaio"]);
                        postagem.IDEvento = Convert.ToInt32(reader["IDEvento"]);    
                        postagem.Titulo = reader["Titulo"].ToString();
                        postagem.Descricao = reader["Descricao"].ToString();
                        postagem.Hora = TimeSpan.Parse(reader["Hora"].ToString());
                        postagem.Data = DateTime.Parse(reader["Data"].ToString());

                        postagens.Add(postagem);
                    }
                }
                return (postagens);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}