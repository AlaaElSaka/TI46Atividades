using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Ti46Console_projeto
{
    internal class Lista1
    {
        public static void lista1()
        {
            //exercicio1();
            //Escreva um programa que mostre na tela a mensagem "Olá, Mundo!"
            //exercicio2();
            //Faça um programa que leia o nome de uma pessoa e mostre uma mensagem de boasvindas para ela
            //exercicio3();
            //Crie um programa que leia o nome e o salário de um funcionário, mostrando no final uma mensagem
            //exercicio4();
            //Desenvolva um algoritmo que leia dois números inteiros e mostre o somatório entre eles.
            //exercicio5();
            //Faça um programa que leia as duas notas de um aluno em uma matéria e mostre na tela a sua média na disciplina.
            //exercicio6();
            //Faça um programa que leia um número inteiro e mostre o seu antecessor e seu sucessor.
            //exercicio7();
            //Crie um algoritmo que leia um número real e mostre na tela o seu dobro e a sua terça parte.
            //exercicio8();
            //Desenvolva um programa que leia uma distância em metros e mostre os valores relativos em outras medidas.
            //exercicio9();
            //Faça um algoritmo que leia quanto dinheiro uma pessoa tem na carteira (em R$) e mostre quantos dólares ela pode comprar. Considere US$1,00 = R$3,45.
            //exercicio10();
            //Faça um algoritmo que leia a largura e altura de uma parede, calcule e mostre a área a ser pintada e a quantidade de tinta necessária para o serviço,sabendo que cada litro de tinta pinta uma área de 2metros quadrados.

            Console.Clear();
            Console.WriteLine("============= Lista 1 =============\n\n");
            Console.WriteLine("1 - Exercício 1 : Escreva um programa que mostre na tela a mensagem Olá, Mundo!");
            Console.WriteLine("2 - Exercício 2 : Faça um programa que leia o nome de uma pessoa e mostre uma mensagem de boasvindas para ela");
            Console.WriteLine("3 - Exercício 3 : Crie um programa que leia o nome e o salário de um funcionário, mostrando no final uma mensagem");
            Console.WriteLine("4 - Exercício 4 : Desenvolva um algoritmo que leia dois números inteiros e mostre o somatório entre eles");
            Console.WriteLine("5 - Exercício 5 : Faça um programa que leia as duas notas de um aluno em uma matéria e mostre na tela a sua média na disciplina");
            Console.WriteLine("6 - Exercício 6 : Faça um programa que leia um número inteiro e mostre o seu antecessor e seu sucessor");
            Console.WriteLine("7 - Exercício 7 : Crie um algoritmo que leia um número real e mostre na tela o seu dobro e a sua terça parte");
            Console.WriteLine("8 - Exercício 8 : Desenvolva um programa que leia uma distância em metros e mostre os valores relativos em outras medidas");
            Console.WriteLine("9 - Exercício 9 : Faça um algoritmo que leia quanto dinheiro uma pessoa tem na carteira (em R$) e mostre quantos dólares ela pode comprar. Considere US$1,00 = R$3,45");
            Console.WriteLine("10 - Exercício 10 : Faça um algoritmo que leia a largura e altura de uma parede, calcule e mostre a área a ser pintada e a quantidade de tinta necessária para o serviço,sabendo que cada litro de tinta pinta uma área de 2metros quadrados\n\n");
           
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
            double x, y;
            Console.WriteLine("Digite a largura de parede");
            x= double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a altura de parede");
            y= double.Parse(Console.ReadLine());
            Console.WriteLine($"A área da parede com largura {x} e altura {y} = {x * y} e precisa de {(y * x) / 2} baldes de tinta");
        }

        private static void exercicio9()
        {
            double x;
            Console.WriteLine("Quanto dinheiro vocé tem na carteira (em R$)\n");
            x= double.Parse(Console.ReadLine());
            Console.WriteLine($" o valor {x} R$ equal {x / 3.45} US$");

        }

        private static void exercicio8()
        {
            double x;
            Console.WriteLine("Digite uma distância em metros ");
            x= double.Parse(Console.ReadLine());
            Console.WriteLine($"A distância de {x}m corresponde a:\n {x / 1000}Km\n{x / 100}Hm\n{x / 10}Dam\n{x * 10}dm\n{x * 100}cm\n{x * 1000}mm\n");

        }

        private static void exercicio7()
        {
            double x;
            Console.WriteLine("Digite seu numero\n");
            x= double.Parse(Console.ReadLine());
            Console.WriteLine($"O dobro de {x} é {x*2}\n A terça parte de {x} é {x/3}");
        }

        private static void exercicio6()
        {
            float x;
            Console.WriteLine("Digite sue numero\n");
            x= float.Parse(Console.ReadLine());
            Console.WriteLine($"O antecessor de {x} é {(x - 1)} \n O sucessor de {x} é {(x - 1)}");
        }

        private static void exercicio5()
        {
            double x, y;
            Console.WriteLine("Digite a Nota 1\n");
            x=double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a Nota 2\n");
            y=double.Parse(Console.ReadLine());
            Console.WriteLine($"A média entre {x} e {y} é igual a {(x+y)/2}");
        }

        private static void exercicio4()
        {
            float x,y;
            Console.WriteLine("Digite um valor");
            x=float.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro valor");
            y=float.Parse(Console.ReadLine());
            Console.WriteLine($"A soma entre {x} e {y} é igual a {(x + y)}");
        }

        private static void exercicio3()
        {
            string nome;
            double salario;
            Console.WriteLine("Escreva nome de Funcionário\n");
            nome = Console.ReadLine();
            Console.WriteLine("Escreva salário de funcionário \n");
            salario=double.Parse(Console.ReadLine());
            Console.WriteLine($"O funcionário {nome} tem um salário de {salario} em Junho.");

        }

        private static void exercicio2()
        {
            string nome;
            Console.WriteLine("Qual é o seu nome? ");
            nome = Console.ReadLine();
            Console.WriteLine($"Olá {nome} , é um prazer te conhecer!");

        }

        private static void exercicio1()
        {
            Console.WriteLine("Olá, Mundo!");
        }

    }
}
