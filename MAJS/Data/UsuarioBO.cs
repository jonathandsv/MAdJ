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
    public class UsuarioBO
    {
        private string ConexaoBanco()
        {
            return (WebConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        }

        public Usuario GetUsuario(string nome)
        {
            try
            {
                string _conectionstring = ConexaoBanco();

                string buscarUsuario = @"SELECT * FROM Usuarios WHERE Nome = @Nome";

                SqlConnection sqlConnection = new SqlConnection(_conectionstring);

                sqlConnection.Open();

                Usuario usuario = new Usuario();

                using (SqlCommand sqlCommand = new SqlCommand(buscarUsuario, sqlConnection))
                {
                    sqlCommand.Parameters.Add("@Nome", SqlDbType.VarChar, 50).Value = nome; 
                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        usuario.IDUsuario = Convert.ToInt32(reader["IDUsuario"]);
                        usuario.Nome = reader["Nome"].ToString();
                        usuario.Sobrenome = reader["Sobrenome"].ToString();
                        usuario.IDPerfilUsuario = Convert.ToInt32(reader["IDPerfilUsuario"]);
                        //usuario.IDPerfilMembro = Convert.ToInt32(reader["IDPerfilMembro"]);
                        usuario.Senha = reader["Senha"].ToString();
                        usuario.Email = reader["Email"].ToString();
                        usuario.Sexo = reader["Sexo"].ToString();
                        usuario.Idade = Convert.ToInt32(reader["Idade"]);
                    }
                }
                return (usuario);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}