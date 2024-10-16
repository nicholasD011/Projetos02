using System;

namespace ConsoleApp1
{
    internal class Lista1
    {
        internal void Exercicio1()
        {
            double[] numeros = new double[10];
            double soma = 0;
            double media = 0;

            Console.WriteLine("Digite 10 números reais:");

            for (int i = 0; i < 10; i++) 
            {
                Console.Write($"Número {i + 1}: ");
                numeros[i] = Convert.ToDouble(Console.ReadLine());
                soma += numeros[i];
            }
            media = soma / 10;
            Console.WriteLine($"\nA média aritimética é: {media:F2}");
            Console.ReadLine();
        }

        internal void Exercicio2()
        {
            string[] nomes = new string[5];

            Console.WriteLine("Escreva cinco nomes: ");

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Nome {i + 1}: ");
                nomes[i] = Console.ReadLine();
            }

            Array.Sort(nomes);

            Console.WriteLine("\nNomes em ordem alfaética:");
            foreach (string nome in nomes)
            {
                Console.WriteLine(nome);
            }
            Console.ReadLine();
        }

        internal void Exercicio3()
        {
            throw new NotImplementedException();
        }

        internal void Exercicio4()
        {
            throw new NotImplementedException();
        }

        internal void Exercicio5()
        {
            throw new NotImplementedException();
        }

        internal void Exercicio6()
        {
            throw new NotImplementedException();
        }

        internal void Exercicio7()
        {
            throw new NotImplementedException();
        }

        internal void Exercicio8()
        {
            throw new NotImplementedException();
        }

        internal void Exercicio9()
        {
            throw new NotImplementedException();
        }
        internal void Exercicio10()
        {

        }
    }
}