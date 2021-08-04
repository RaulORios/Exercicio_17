using System;

namespace Exercicio_17
{
    class Program
    {
        static void Main(string[] args)
        {

            //ToDo - Alterar variavel Int para decimal.

            Console.WriteLine("****************************************");
            Console.WriteLine("*********     Exercicio 17     *********");
            Console.WriteLine("****************************************");

            Console.WriteLine("");

            int Nota1;
            int Nota2;
            int media;

            Console.Write("Digite a 1º Nota: ");
            Nota1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a 2º Nota: ");
            Nota2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");

            media = (Nota1 + Nota2) / 2;

            if (media >= 6)
            {
                Console.WriteLine($"A media do aluno é {media} - Aluno APROVADO.");
            }
            else
            {
                Console.WriteLine($"A media do aluno é {media} - Aluno REPROVADO.");
            }
            
            Console.ReadKey();

        }
    }
}