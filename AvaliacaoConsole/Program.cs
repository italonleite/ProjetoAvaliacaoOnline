using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace AvaliacaoConsole
{
    class Program
    {
        static void Main(string[] args)
        {

           
                // 1. Instancia a conexão(objeto SqlConnection)
                SqlConnection conn = new SqlConnection("Data Source=.\\SQLNOVO;Initial Catalog=AvaliaçãoReserveSystem;Integrated Security=SSPI");
                //
                // define um SqlDataReader nulo
                SqlDataReader dr = null;
                try
                {
                    // 2. Abre a conexão
                    conn.Open();
                    // 3. Passa conexão para o objeto command
                    SqlCommand cmd = new SqlCommand("select * from prova", conn);
                    //
                    // 4. Usa conexão
                    // obtêm o resultado da consulta
                    dr = cmd.ExecuteReader();
                    // imprime o codigo do cliente para cada registro
                    while (dr.Read())
                    {
                        Console.WriteLine(dr[0]);
                    }
                }
                finally
                {
                    // fecha o reader
                    if (dr != null)
                    {
                        dr.Close();
                    }
                    // 5. Fecha a conexão
                    if (conn != null)
                    {
                        conn.Close();
                    }
                }
            

            //1º criando uma prova
            var prova = new Prova(1, "Prova Dev Junior");

            //tipoEnunciado -> precisa ser revisto
            var tipo1 = new Tipo(1, "booleano");
            var tipo2 = new Tipo(2, "discursiva");

            //Adicionando uma Questão para a prova
            var questao = new Questao(1, "pergunta true ou false", 2, prova, tipo1);

            //Adicionando uma Lista de Questão para a prova
            List<Questao> questoes = new List<Questao>();
            questoes.Add(new Questao(2, "pergunta true ou false", 2, prova, tipo1));
            questoes.Add(new Questao(3, "pergunta discursiva", 2, prova, tipo2));
            
            //adicionando uma Alternativa para Questão
            var alternativa1 = new Alternativa(1, "sim", questao, true);
            var alternativa2 = new Alternativa(2, "nao", questao, false);
           
            //Seleciando um candidato para a prova
            var candidato = new Candidato(1, "italo", "italo@gmail.com", prova);

            Console.WriteLine("Candidato :{0} - Realizando a prova :{1}", candidato.Nome, candidato.Prova.Titulo);

            Console.WriteLine("Questão :{0}", questao.Enunciado);

            Console.WriteLine("1 - Alternativa :{0}", alternativa1.Opcao);
            Console.WriteLine("2 - Alternativa :{0}", alternativa2.Opcao);

            foreach (var enunciado in questoes) {
                Console.WriteLine($"Lista de Questões : {questao.Enunciado}");
            }


            Console.ReadKey();


        }
    }
}
