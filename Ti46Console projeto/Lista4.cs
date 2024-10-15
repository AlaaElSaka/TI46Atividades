using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ti46Console_projeto
{
    internal class Lista4
    {
        public static void lista4()
        {
            //exercicio1();
            //Escreva um programa que solicite um número ao usuário e verifique se ele é par ou ímpar.
            //exercicio2();
            //Peça ao usuário para inserir sua idade e classifique-o como "Criança" (0-12), "Adolescente" (13-17), "Adulto" (18-64), ou "Idoso" (65+).
            //exercicio3();
            //Crie um programa que receba uma nota (0 a 10) e exiba se o aluno foi "Aprovado" (nota maior ou igual a 6), "Recuperação" (nota entre 4 e 5.9) ou "Reprovado" (nota menor que 4).
            //exercicio4();
            //Peça ao usuário para informar seu peso e altura e, em seguida, calcule o Índice de Massa Corporal (IMC) e determine sua categoria: "Abaixo do peso", "Peso normal", "Sobrepeso" ou "Obesidade".
            //exercicio5();
            //Escreva um programa que receba dois números do usuário e exiba qual é o maior, ou informe se os números são iguais.
            //exercicio6();
            //Peça ao usuário sua idade e informe se ele é obrigado a votar (18-70 anos), voto facultativo (16-17 ou acima de 70), ou se não pode votar (abaixo de 16 anos).
            //exercicio7();
            //Crie um programa que receba o valor de uma compra e aplique um desconto de 10% caso o valor seja superior a R$100.
            //exercicio8();
            //Peça ao usuário para informar a temperatura em graus Celsius e classifique se está "Frio" (abaixo de 15°C), "Agradável" (15-25°C), ou "Quente" (acima de 25°C).
            //exercicio9();
            //Solicite três números ao usuário e calcule a média. Caso a média seja maior que 7, exiba "Aprovado", senão exiba "Reprovado".
            //exercicio10();
            //Peça ao usuário que insira um ano e verifique se ele é bissexto (divisível por 4 e não divisível por 100, exceto se for divisível por 400).




            Console.Clear();
            Console.WriteLine("============= Lista 4 =============\n\n");
            Console.WriteLine("1 - Exercício 1: Escreva um programa que solicite um número ao usuário e verifique se ele é par ou ímpar");
            Console.WriteLine("2 - Exercício 2: Peça ao usuário para inserir sua idade e classifique-o como Criança (0-12), Adolescente (13-17), Adulto (18-64), ou Idoso (65+)");
            Console.WriteLine("3 - Exercício 3: Crie um programa que receba uma nota (0 a 10) e exiba se o aluno foi Aprovado(nota maior ou igual a 6), Recuperação (nota entre 4 e 5.9) ou Reprovado (nota menor que 4)");
            Console.WriteLine("4 - Exercício 4: Peça ao usuário para informar seu peso e altura e, em seguida, calcule o Índice de Massa Corporal (IMC) e determine sua categoria: Abaixo do peso, Peso normal, Sobrepeso ou Obesidade");
            Console.WriteLine("5 - Exercício 5: Escreva um programa que receba dois números do usuário e exiba qual é o maior, ou informe se os números são iguais");
            Console.WriteLine("6 - Exercício 6: Peça ao usuário sua idade e informe se ele é obrigado a votar (18-70 anos), voto facultativo (16-17 ou acima de 70), ou se não pode votar (abaixo de 16 anos)");
            Console.WriteLine("7 - Exercício 7: Crie um programa que receba o valor de uma compra e aplique um desconto de 10% caso o valor seja superior a R$100");
            Console.WriteLine("8 - Exercício 8: Peça ao usuário para informar a temperatura em graus Celsius e classifique se está Frio (abaixo de 15°C), Agradável (15-25°C), ou Quente (acima de 25°C)");
            Console.WriteLine("9 - Exercício 9: Solicite três números ao usuário e calcule a média. Caso a média seja maior que 7, exiba Aprovado, senão exiba Reprovado");
            Console.WriteLine("10 - Exercício 10: Peça ao usuário que insira um ano e verifique se ele é bissexto (divisível por 4 e não divisível por 100, exceto se for divisível por 400)\n\n");

            string escolha = Console.ReadLine();
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
            int ano;
            Console.Write("Digite um ano: ");
            ano = int.Parse(Console.ReadLine());

            
            if ((ano % 4 == 0 && ano % 100 != 0) || (ano % 400 == 0))
            {
                Console.WriteLine($"{ano} é um ano bissexto.");
            }
            else
            {
                Console.WriteLine($"{ano} não é um ano bissexto.");
            }
        }

        private static void exercicio9()
        {
            double a, b, c , média;
            Console.WriteLine(" Digite 1 numero ");
            a= double.Parse(Console.ReadLine());
            Console.WriteLine(" Digite 2 numero ");
            b= double.Parse(Console.ReadLine());
            Console.WriteLine(" Digite 3 numero ");
            c= double.Parse(Console.ReadLine());

            média=(a+b+c)/3;

            if (média>7)
            {
                Console.WriteLine("Aprovado \n");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }

        }

        private static void exercicio8()
        {
            int temp;
            Console.WriteLine(" Informa a temperatura em graus Celsius ");
            temp = int.Parse(Console.ReadLine());

            if (temp >= 15 && temp <= 25)
            {
                Console.WriteLine($" Agradável \n");
            }
            else if (temp < 15)
            {
                Console.WriteLine($" Frio \n");

            }
            else
            {
                Console.WriteLine(" Quente \n");
            }
        }

        private static void exercicio7()
        {
            double compra;
            Console.WriteLine("Digite o valor de sua compra ");
            compra = double.Parse(Console.ReadLine());

            if (compra >100 )
            {
                compra = compra - (compra * 0.10);

                Console.WriteLine($" O Valor de compra depois um desconto de 10% é : {compra}");
            }
            else {
                Console.WriteLine(" Nâo tem desconto ");
                    }
        }

        private static void exercicio6()
        {
            int idade;
            Console.WriteLine("Digite seu idade ");
            idade =int.Parse(Console.ReadLine());

            if (idade>=18 && idade<=70)
            {
                Console.WriteLine($" Obrigado a Votar \n");
            }
            else if (idade <16)
            {
                Console.WriteLine($" não pode votar \n");

            }
            else
            {
                Console.WriteLine(" voto facultativo \n");
            }

        }

        private static void exercicio5()
        {
            double x, y;
            Console.WriteLine(" Digite 1 numero ");
            x=double.Parse(Console.ReadLine());
            Console.WriteLine(" Digite 2 numero ");
            y=double.Parse(Console.ReadLine());

            if (x > y)
            {
                Console.WriteLine($" Numero maior é {x} \n");
            }
            else if (y > x)
            {
                Console.WriteLine($" Numero maior é {y} \n");

            }
            else
            {
                Console.WriteLine(" Os números são iguais \n");
            }


        }

        private static void exercicio4()
        {
            double peso, altura,IMC;
            Console.WriteLine("Digite seu peso em KG ");
            peso= double.Parse(Console.ReadLine());
            Console.WriteLine("Digite sua altura em m ");
            altura= double.Parse(Console.ReadLine());
            IMC=peso/(altura*altura);

            if (IMC < 18.5 )
            {
                Console.WriteLine("\nAbaixo do peso");
            }
            else if (IMC >=18.5 && IMC<25)
            {
                Console.WriteLine("\nPeso normal");
            }
            else if(IMC >= 25 && IMC <30)
            {
                Console.WriteLine("\nSobrepeso");

            }
            else
            {
                Console.WriteLine("\nObesidade \n");
            }
        }

        private static void exercicio3()
        {
            double x;
            do
            {


                Console.WriteLine(" Escreva sua Nota 0-10 \n");
                x = double.Parse(Console.ReadLine());

                if (x < 0 || x > 10)
                {
                    Console.WriteLine(" Nota inválida\n");

                }
            }
            while (x < 0 || x > 10);
           

                if (x >= 6)
                {
                    Console.WriteLine(" Aprovado \n");
                }
                else if (x >= 4 && x <= 5.9)
                {
                    Console.WriteLine("Recuperação\n");
                }

                else
                {
                    Console.WriteLine("Reprovado\n");
                }
            

        }
            
        

        private static void exercicio2()
        {
            int x;
            Console.WriteLine(" Escreva seu idade ");
            x=int .Parse(Console.ReadLine());
            if (x <= 12)
            {
                Console.WriteLine(" Criança \n");
            }
            else if (x>12 && x<=17)
            {
                Console.WriteLine("Adolescente\n");
            }
            else if (x > 17 && x <= 64)
            {
                Console.WriteLine("Adulto\n");
            }
            else
            {
                Console.WriteLine("Idoso\n");
            }
        }

        private static void exercicio1()
        {
            int x;
            Console.WriteLine("Digite seu numero ");
            x =int.Parse(Console.ReadLine());
            if (x%2 == 0)
            {
                Console.WriteLine("Número é par\n");
            }
            else
            {
                Console.WriteLine("Numero é impar\n");
            }
        }
    }
}
