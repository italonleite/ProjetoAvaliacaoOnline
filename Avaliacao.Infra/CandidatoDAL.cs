using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Avaliacao.Domain;

namespace Avaliacao.Infra
{
    public class CandidatoDAL
    {
		public CandidatoDAL()
		{

		}
		public void Cadastrar(Candidato c) {
			try
			{
				using (SqlConnection conn = new SqlConnection("Data Source=.\\SQLNOVO;Initial Catalog=AvaliaçãoReserveSystem;Integrated Security=SSPI"))
				{
					conn.Open();
					string query = "insert into candidato(NOME, EMAIL, ID_PROVA)" + "values(@NOME, @EMAIL, @ID_PROVA)";
					SqlCommand cmd = new SqlCommand(query, conn);
					cmd.Parameters.AddWithValue("@Nome", c.Nome);
					cmd.Parameters.AddWithValue("@Email", c.Email);
					cmd.Parameters.AddWithValue("@ID_PROVA", c.Prova.IdProva);

					cmd.CommandType = CommandType.Text;
					cmd.ExecuteNonQuery();
				}
			}
			catch (Exception)
			{

				throw;
			}
        }
    }
}
