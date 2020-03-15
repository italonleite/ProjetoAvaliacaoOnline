using Avaliacao.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Avaliacao.Infra
{
    public class QuestaoDAL
    {
        public QuestaoDAL()
        {

        }

        public void Cadastrar(Questao q, Prova p, Tipo t)
        {
            try
            {

                using (SqlConnection conn = new SqlConnection("Data Source=.\\SQLNOVO;Initial Catalog=AvaliaçãoReserveSystem;Integrated Security=SSPI"))
                {
                    conn.Open();
                    string query = "insert into Questao(ENUNCIADO, PONTOS, ID_PROVA, ID_TIPO)" + "values(@ENUNCIADO, @PONTOS, @ID_PROVA, @ID_TIPO)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ENUNCIADO", q.Enunciado);
                    cmd.Parameters.AddWithValue("@PONTOS", q.Pontos);
                    cmd.Parameters.AddWithValue("@ID_PROVA", p.IdProva);
                    cmd.Parameters.AddWithValue("@ID_TIPO", t.IdTipo);

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
