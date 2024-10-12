using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ti46Console_projeto
{
    internal class Lista2
    {
        public static void lista2()
        {
            //exercicio1();
            //Escreva um algoritmo que leia um número e o imprima caso ele seja maior que 20.
            //exercicio2();
            //Ler um valor e escrever a mensagem É MAIOR QUE 10! se o valor lido for maior que 10, caso contrário escrever NÃO É MAIOR QUE 10!
            //exercicio3();
            //Faça um algoritmo que leia os valores A, B, C e imprima na tela se a soma de A + B é menor que C. 
            //exercicio4();
            //Construa um algoritmo que leia dois valores numéricos inteiros e efetue a adição; caso o resultado seja maior que 10, apresentá-lo.
            //exercicio5();
            //Faça um algoritmo que leia o nome, o sexo e o estado civil de uma pessoa. Caso sexo seja “F” e estado civil seja “CASADA”, solicitar o tempo de casada (anos). 
            //exercicio6();
            //Faça um algoritmo para receber um número qualquer e informar na tela se é par ou ímpar. 
            //exercicio7();
            //Faça um algoritmo que leia dois valores inteiros A e B se os valores forem iguais deverá se somar os dois, caso contrário multiplique A por B. Ao final de qualquer um dos cálculos deve-se atribuir o resultado para uma variável C e mostrar seu conteúdo na tela. 
            //exercicio8();
            //Encontrar o dobro de um número caso ele seja positivo e o seu triplo caso seja negativo, imprimindo o resultado.
            //exercicio9();
            //Faça um algoritmo que leia 3 valores retorno do maior para o menor ordenados.
            //exercicio10();
            //Faça um algoritmo que leia 3 valores retorne do menor para o maior ordenados.


            //Ler a hora de início e a hora de fim de um jogo de Xadrez (considere apenas horas inteiras, sem os minutos) e calcule a duração do jogo em horas, sabendo-se que o tempo máximo de duração do jogo é de 24 horas e que o jogo pode iniciar em um dia e terminar no dia seguinte retornar quantas horas estão jogando e quantidade de horas restante ou quantidade de horas excedente.

            Console.Clear();
            Console.WriteLine("Escolha uma operação:\n");
            Console.WriteLine("1 - Exercício 1 da lista 2");
            Console.WriteLine("2 - Exercício 2 da lista 2");
            Console.WriteLine("3 - Exercício 3 da lista 2");
            Console.WriteLine("4 - Exercício 4 da lista 2");
            Console.WriteLine("5 - Exercício 5 da lista 2");
            Console.WriteLine("6 - Exercício 6 da lista 2");
            Console.WriteLine("7 - Exercício 7 da lista 2");
            Console.WriteLine("8 - Exercício 8 da lista 2");
            Console.WriteLine("9 - Exercício 9 da lista 2");
            Console.WriteLine("10 - Exercício 10 da lista 2");

            string escolha=Console.ReadLine(); 
            switch(escolha)
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

                case "7":
                    exercicio7();
                    break;

                case "8":
                    exercicio8();
                    break;

                case "9":
                    exercicio9();
                    break;

                case "10":
                    exercicio10();
                    break;

                default:
                    Console.WriteLine("Operação inválida.");
                    break;


            }

            Console.ReadKey();




    }


        private static void exercicio10()
        {
            double num1, num2, num3;
            Console.WriteLine("Digie 1 valor");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digie 2 valor");
            num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digie 3 valor");
            num3 = double.Parse(Console.ReadLine());

            double[] group = { num1, num2, num3 };
            Array.Sort(group);
            

            Console.WriteLine("menor para o maior ordenados \n");
            foreach (double num in group)
            {
                Console.WriteLine(num);
            }
        }

        private static void exercicio9()
        {
            double num1, num2, num3;
            Console.WriteLine("Digie 1 valor");
            num1= double.Parse(Console.ReadLine());
            Console.WriteLine("Digie 2 valor");
            num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digie 3 valor");
            num3 = double.Parse(Console.ReadLine());

            double[] group = { num1, num2, num3 };
            Array.Sort(group);
            Array.Reverse(group);

            Console.WriteLine("maior para o menor ordenados \n");
            foreach (double num in group)
            {
                Console.WriteLine(num);
            }



        }

        private static void exercicio8()
        {
            int x,y;
            Console.WriteLine("Digite seu numero ");
            x= int.Parse(Console.ReadLine());
            if (x > 0)
            {
                y = x * 2;
                Console.WriteLine($"{x} é positivo e {x} x 2 = {y}");
            }
            else if (x< 0)
            {
                y = x * 3;
                Console.WriteLine($"{x} é negativo e {x} x 3 = {y}");
            }
            else
            {
                Console.WriteLine("Numero é Zero");
            }
        }

        private static void exercicio7()
        {
            int A, B, C;
            Console.WriteLine("Digite seu 1 numero ");
            A= int.Parse(Console.ReadLine());
            Console.WriteLine("Digite seu 2 numero ");
            B= int.Parse(Console.ReadLine());

            if (A==B)
            {
                C = A + B;
                Console.WriteLine($"{A} + {B} = {C}");
            }
            else
            {
                C = A * B;
                Console.WriteLine($"{A} * {B} = {C}");
            }
        }

        private static void exercicio6()
        {
            int x;
            Console.WriteLine("Digite seu numero ");
            x= int.Parse(Console.ReadLine());
            if  (x % 2 ==0)
            {
                Console.WriteLine($"{x} é par ");
            }
            else
            {
                Console.WriteLine($"{x} é ímpar");
            }

        }

        private static void exercicio5()
        {
            int x, y;
            string nome, sexo, estadocivil;
            Console.WriteLine("Escreva seu nome\n");
            nome = Console.ReadLine();
            Console.WriteLine("Sexo (M/F) ? \n");
            sexo = Console.ReadLine().ToUpper();
            Console.WriteLine("Estado Civil ( CASSADO/A - SOLTEIRO/A) \n");
            estadocivil = Console.ReadLine().ToUpper();
            if (sexo =="F")
            {
                if (estadocivil=="CASSADA")
                {
                    Console.WriteLine("Quantos anos de cassamento ");
                    x=int.Parse(Console.ReadLine());
                    Console.WriteLine($"{nome} é cassada há {x} anos");

                }

            }
            else
            {
                Console.WriteLine("Obrigado ");
            }

        }

        private static void exercicio4()
        {
            int x, y;
            Console.WriteLine("Digite 1 numero ");
            x= int.Parse(Console.ReadLine());
            Console.WriteLine("Digite 2 numero ");
            y= int.Parse(Console.ReadLine());
             if ((x+y)>10)
            {
                Console.WriteLine($"{x} + {y} > 10");
            }
        }

        private static void exercicio3()
        {
           double A, B, C;
            Console.WriteLine("Digite valor de A\n");
            A= double.Parse(Console.ReadLine());
            Console.WriteLine("Digite valor de B\n");
            B= double.Parse(Console.ReadLine());
            Console.WriteLine("Digite valor de C\n");
            C= double.Parse(Console.ReadLine());
            
            if ((A+B)<C)
            {
                Console.WriteLine($"{A} + {B} é menor que {C}");
            }

        }

        private static void exercicio2()
        {
            double x;
            Console.WriteLine("Digite seu numero ");
            x= double.Parse(Console.ReadLine());
            if (x > 10)
            {
                Console.WriteLine($"{x} é maior 10");
            }
            else
            {
                Console.WriteLine($"{x} NÃO É MAIOR QUE 10! ");
            }
        }

        private static void exercicio1()
        {
            double x;
            Console.WriteLine("Digite seu numero ");
            x= double.Parse(Console.ReadLine());
            if (x > 20)
            {
                Console.WriteLine($"{x} é maior de 20 ");
            }

        }
    }
}
