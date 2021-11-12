using System;

namespace mediaFrequencia
{
    class Program
    {
        static void Main(string[] args)
        {
			int aulasDadas, aulasAssistidas;
			double nota1, nota2, media, frequencia;

			Console.WriteLine("Quantidade de aulas dadas");
			aulasDadas = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Quantidade de aulas assistidas");
			aulasAssistidas = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Digite a nota 1");
			nota1 = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Digite a nota 2");
			nota2 = Convert.ToDouble(Console.ReadLine());

			frequencia = ((Double)aulasAssistidas / (Double)aulasDadas) * 100;


			media = (nota1 + nota2) / 2;


			if (media >= 7 && frequencia >= 0.75)
			{
				Console.WriteLine("Aluno Aprovado com a média {0} e frequencia {1}", media.ToString(), frequencia.ToString());
			}
			else
			{
				Console.WriteLine("Aluno Reprovado com a média {0} e frequencia {1}", media.ToString(), frequencia.ToString());
			}
		}
    }
}
