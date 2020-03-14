using Avaliacao.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Avaliacao.Infra
{
    public class TipoDAL
    {
        public TipoDAL()
        {

        }

        public void Cadastrar(Tipo t)
        {
            try
            {

                using (SqlConnection conn = new SqlConnection("Data Source=.\\SQLNOVO;Initial Catalog=AvaliaçãoReserveSystem;Integrated Security=SSPI"))
                {
                    conn.Open();
                    string query = "insert into Tipo(TEXTO)" + "values(@TEXTO)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@TEXTO", t.TipoEnunciado);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }



        }

    }
}
