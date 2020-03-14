using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Avaliacao.Domain
{
    public class Prova
    {
        public int IdProva { get; set; }
        public string Titulo { get; set; }

     
        public Prova(int idProva, string titulo)
        {
            if (String.IsNullOrEmpty(titulo))
                throw new Exception("Titulo Invalido");
                    IdProva = idProva;
                    Titulo = titulo;
        }

        public void AdicionarProva(Prova p)
        {
            // SqlConnection conn = new SqlConnection("Data Source=.\\SQLNOVO;Initial Catalog=AvaliaçãoReserveSystem;Integrated Security=SSPI");
            //declarando os parametros da procedure..
            SqlParameter titulo = new SqlParameter("@Titulo", SqlDbType.Text);

            //passando os valores para os parametros..
            titulo.Value = p.Titulo;

            //escrever a query para executar a procedure..
            string query = "SpCadastrarProva";
            //executando..
            using (SqlConnection conn = new SqlConnection("Data Source=.\\SQLNOVO;Initial Catalog=AvaliaçãoReserveSystem;Integrated Security=SSPI"))

            {
              
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(titulo);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}
