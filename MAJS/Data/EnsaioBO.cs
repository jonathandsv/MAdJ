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
    public class EnsaioBO
    {
        private string ConexaoBanco()
        {
            return (WebConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        }
        public Ensaio GetEnsaio(int id)
        {
            try
            {
                string _connectionstring = ConexaoBanco();

                string select = @"SELECT * FROM Ensaios WHERE IDEnsaios = @IDEnsaio";

                Ensaio ensaio = new Ensaio();

                using (var sqlConnection = new SqlConnection(_connectionstring))
                {
                    sqlConnection.Open();
                    using (var sqlCommand = new SqlCommand(select, sqlConnection))
                    {
                        sqlCommand.Parameters.Add("@IDEnsaio", SqlDbType.Int).Value = id;

                        SqlDataReader reader = sqlCommand.ExecuteReader();

                        while (reader.Read())
                        {
                            ensaio.IDEnsaios = Convert.ToInt32(reader["IDEnsaios"]);
                            ensaio.Titulo = reader["Titulo"].ToString();
                            ensaio.Descricao = reader["Descricao"].ToString();
                            ensaio.Hora = TimeSpan.Parse(reader["Hora"].ToString());
                            ensaio.Data = DateTime.Parse(reader["Data"].ToString());
                            ensaio.Local = reader["Local"].ToString();
                        }
                        sqlConnection.Close();
                    }
                }
                return (ensaio);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Ensaio> GetEnsaios()
        {
            try
            {
                string _conectionstring = ConexaoBanco();

                string buscarEnsaios = @"SELECT * FROM Ensaios";

                SqlConnection sqlConnection = new SqlConnection(_conectionstring);

                sqlConnection.Open();

                List<Ensaio> ensaios = new List<Ensaio>();

                using (SqlCommand sqlCommand = new SqlCommand(buscarEnsaios, sqlConnection))
                {
                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        Ensaio ensaio = new Ensaio();
                        ensaio.IDEnsaios = Convert.ToInt32(reader["IDEnsaios"]);
                        ensaio.Titulo = reader["Titulo"].ToString();
                        ensaio.Descricao = reader["Descricao"].ToString();
                        ensaio.Hora = TimeSpan.Parse(reader["Hora"].ToString());
                        ensaio.Data = DateTime.Parse(reader["Data"].ToString());
                        ensaio.Local = reader["Local"].ToString();
                        ensaios.Add(ensaio);
                    }
                }
                return (ensaios);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int CadastrarEnsaio(Ensaio ensaio)
        {
            try
            {
                string _conectionstring = ConexaoBanco();

                string cadastrarEnsaios = @"INSERT INTO Ensaios (Titulo, Descricao, Hora, Data, Local) VALUES (@Titulo, @Descricao, @Hora, @Data, @Local)";

                var resultado = 0;
                using (var sqlConn = new SqlConnection(_conectionstring))
                {
                    using (SqlCommand command = new SqlCommand(cadastrarEnsaios, sqlConn))
                    {
                        command.Parameters.Add("@Titulo", SqlDbType.VarChar, 50).Value = ensaio.Titulo;
                        command.Parameters.Add("@Descricao", SqlDbType.VarChar, 50).Value = ensaio.Descricao;
                        command.Parameters.Add("@Hora", SqlDbType.Time).Value = ensaio.Hora;
                        command.Parameters.Add("@Data", SqlDbType.DateTime).Value = ensaio.Data;
                        command.Parameters.Add("@Local", SqlDbType.VarChar).Value = ensaio.Local;

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