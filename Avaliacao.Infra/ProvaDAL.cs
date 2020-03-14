using Avaliacao.Domain;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Avaliacao.Infra.Tests
{
    public class ProvaDAL
    {

        public ProvaDAL()
        {
        }

        public void Cadastrar(Prova p)
        {
            try
            {

                using (SqlConnection conn = new SqlConnection("Data Source=.\\SQLNOVO;Initial Catalog=AvaliaçãoReserveSystem;Integrated Security=SSPI"))
                {
                    conn.Open();
                    string query = "insert into Prova(Titulo)" + "values(@Titulo)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Titulo", p.Titulo);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }



        }

        public void Atualizar(int IdProva, string Titulo)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=.\\SQLNOVO;Initial Catalog=AvaliaçãoReserveSystem;Integrated Security=SSPI"))
                {
                    conn.Open();
                    string query = "update Prova set Titulo = @Titulo" + " where IdProva = @IdProva"; 
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Titulo", Titulo);
                    cmd.Parameters.AddWithValue("@IdProva", IdProva);

                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        
        public Prova ConsultarPorId(int IdProva)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=.\\SQLNOVO;Initial Catalog=AvaliaçãoReserveSystem;Integrated Security=SSPI"))
                {
                    conn.Open();
                    string query = "select * from Prova" + " where IDPROVA = @IDPROVA";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@IDPROVA", IdProva);
                    var resultado = cmd.ExecuteReader();
                    Prova p = null;
                    if (resultado.Read())
                    {
                        p = new Prova((int)resultado["idProva"], (string)resultado["Titulo"]);
                  
                    }

                    return p;
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }


    }

}