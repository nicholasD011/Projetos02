using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int meuMenu = 0;

            do
            {
                MeuMenu();

                Console.WriteLine("Deseja continuar ?");
                Console.WriteLine("Digite 0 para continuar");
                meuMenu = int.Parse(Console.ReadLine());
                Console.Clear();

            }
            while (meuMenu == 0); 
        }

        private static void MeuMenu()
        {
            Lista1 lista1 = new Lista1();
            Lista2 lista2 = new Lista2();
            Lista3 lista3 = new Lista3();
            Lista4 lista4 = new Lista4();
            Lista5 lista5 = new Lista5();

            int escolha = 0;

            Console.WriteLine("Menu");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("1 - Lista1");
            Console.WriteLine("2 - Lista2");
            Console.WriteLine("3 - Lista3");
            Console.WriteLine("4 - Lista4");
            Console.WriteLine("5 - Lista5");

            escolha = int.Parse(Console.ReadLine());

            switch (escolha) 
            {
                case 1:
                    int escolhaLista1 = 0;

                    Console.Clear();
                    Console.WriteLine("digite o exercício desejado: \n");
                    Console.WriteLine("1. Média Aritmética: Crie um programa que leia um vetor de 10 números reais e calcule a média aritmética.\n");
                    Console.WriteLine("2. Ordenação Alfabética: Faça um programa que leia um vetor de 5 nomes e os imprima em ordem alfabética.\n");
                    Console.WriteLine("3. Números Repetidos: Crie um programa que leia um vetor de 10 números inteiros e verifique se existe algum número repetido.\n");
                    Console.WriteLine("4. Anagrama: Faça um programa que leia um vetor de 5 caracteres e verifique se ele é um anagrama de outra palavra.\n");
                    Console.WriteLine("5. Inversão: Crie um programa que leia um vetor de 10 números inteiros e inverta a ordem dos elementos.\n");
                    Console.WriteLine("6. Números Pares: Faça um programa que leia um vetor de 5 números inteiros e crie um novo vetor com os números pares.\n");
                    Console.WriteLine("7. Positivos, Negativos e Zeros: Crie um programa que leia um vetor de 10 números inteiros e conte quantos números são positivos, negativos e zeros.\n");
                    Console.WriteLine("8. Maior e Menor Valor: Crie um programa que leia um vetor de 10 números inteiros e encontre o maior e o menor valor.\n");
                    Console.WriteLine("9. Palíndromo: Faça um programa que leia um vetor de 5 caracteres e verifique se ele é um palíndromo.\n");
                    Console.WriteLine("10. Números Pares e Ímpares: Escreva um algoritmo que leia um vetor de 10 posições de números inteiros e imprima, logo após, gerar 2 vetores a partir dele, um contendo os elementos de posições ímpares do vetor e o outro os elementos de posições pares. Imprimi-los no final.\n");

                    escolhaLista1 = int.Parse(Console.ReadLine());

                    switch (escolhaLista1)
                    {
                        case 1:
                            lista1.Exercicio1();
                        break;
                        case 2:
                            lista1.Exercicio2();
                        break;
                        case 3:
                            lista1.Exercicio3();
                        break;
                        case 4:
                            lista1.Exercicio4();
                        break;
                        case 5:
                            lista1.Exercicio5();
                        break;
                        case 6:
                            lista1.Exercicio6();
                        break;
                        case 7:
                            lista1.Exercicio7();
                        break;
                        case 8:
                            lista1.Exercicio8();
                        break;
                        case 9:
                            lista1.Exercicio9();
                        break;
                        case 10:
                            lista1.Exercicio10();
                        break;
                        default:
                            Console.WriteLine("Tente novamente");
                        break;
                    }
                break;
                
            }
        }
    }
}
