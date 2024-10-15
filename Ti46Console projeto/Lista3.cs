using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ti46Console_projeto
{
    internal class Lista3
    {
        public static void lista3()
        {
            //exercicio1();
            //Faça um programa que receba 3 valores e retorne a soma deles.
            //exercicio2();
            //Faça um programa que receba quatro notas e retorne a média.
            //exercicio3();
            //Faça um programa que receba um nome enquanto o nome for diferente de João continuar pedindo o nome. 
            //exercicio4();
            //Faça um programa que retorne à quantidade de números pares existente entre 35 e 98111
            //exercicio5();
            //FaÇa um programa que some todos os números ímpares de 1 até 5000.
            //exercicio6();
            //Faça um programa que receba um número e usando laços de repetição calcule e mostre a tabuada desse número.


            Console.Clear();
            Console.WriteLine("============= Lista 3 =============\n\n");
            Console.WriteLine("1 - Exercício 1: Faça um programa que receba 3 valores e retorne a soma deles");
            Console.WriteLine("2 - Exercício 2: Faça um programa que receba quatro notas e retorne a média");
            Console.WriteLine("3 - Exercício 3: Faça um programa que receba um nome enquanto o nome for diferente de João continuar pedindo o nome");
            Console.WriteLine("4 - Exercício 4: Faça um programa que retorne à quantidade de números pares existente entre 35 e 98111");
            Console.WriteLine("5 - Exercício 5: FaÇa um programa que some todos os números ímpares de 1 até 5000");
            Console.WriteLine("6 - Exercício 6:Faça um programa que receba um número e usando laços de repetição calcule e mostre a tabuada desse número\n\n");

            string escolha=Console.ReadLine();
            switch (escolha)
            {
                case "1":
                    exercicio1();
                    break;

                case "2":
                    exercicio2();
                    break;

                case "3":
                    exercicio3();
                    break;

                case "4":
                    exercicio4();
                    break;

                case "5":
                    exercicio5();
                    break;

                case "6":
                    exercicio6();
                    break;

                default:
                    Console.WriteLine("Operação inválida.");
                    break;
            }
            Console.ReadKey();
        }

        private static void exercicio6()
        {
            int x,y=0;
            Console.WriteLine("Digite seu Numero ");
            x=int.Parse(Console.ReadLine());
            Console.WriteLine($"Tabuada de numero {x}\n");
            for (int i = 1;i<=10;i++)
            {
                y = x * i;
                Console.WriteLine($"{x} X {i} = {y} \n");
            }
        }

        private static void exercicio5()
        {
            int x = 0;
            for (int i = 1;i<=5000;i+=2)
            {
                x=x+i;
            }
            Console.WriteLine($"Some todos os números ímpares de 1 até 5000 é iqual = {x} \n");
        }

        private static void exercicio4()
        {
            int x=0;
            for (int i = 36; i <= 98111; i+=2)
            {
                x++;
            }
            Console.WriteLine($"Quantidade de números pares existente entre 35 e 98111 é {x} \n");


        }

        private static void exercicio3()
        {
            string nome;
            Console.WriteLine(" Escreva nome ");
            nome = Console.ReadLine();

            do
            {
                Console.WriteLine(" Escreva nome ");
                nome= Console.ReadLine();

            }
            while (nome != "João");
            
                Console.WriteLine(" obrigado João \n");
            
        }

        private static void exercicio2()
        {
            double A, B, C,D;
            Console.WriteLine("Digite 1 Nota ");
            A = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite 2 Nota ");
            B = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite 3 Nota ");
            C = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite 4 Nota ");
            D = double.Parse(Console.ReadLine());

            Console.WriteLine($" Média de Notas equal  {(A + B + C+D)/4}\n ");
        }

        private static void exercicio1()
        {
            double x, y, z;
            Console.WriteLine("Digite 1 valor ");
            x= double.Parse(Console.ReadLine());
            Console.WriteLine("Digite 2 valor ");
            y= double.Parse(Console.ReadLine());
            Console.WriteLine("Digite 3 valor ");
            z= double.Parse(Console.ReadLine());

            Console.WriteLine($" Soma de valors equal  {x+y+z}\n ");
        }
    }
}
