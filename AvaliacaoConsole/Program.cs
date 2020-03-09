using System;
using System.Collections.Generic;

namespace AvaliacaoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
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
