using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ti46Console_projeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string escolha;
            do
            {

                Console.Clear();
                
                Console.WriteLine("Escolha uma Lista de operação:\n");
                Console.WriteLine("1 - Exercícios da lista 1\n");
                Console.WriteLine("2 - Exercícios da lista 2\n");
                Console.WriteLine("3 - Exercícios da lista 3\n");
                Console.WriteLine("4 - Exercícios da lista 4\n\n");
                Console.WriteLine(" Escola 0 para Sair ");










                escolha = Console.ReadLine();

                switch (escolha)
                {
                    case "1":
                        Lista1.lista1();
                        break;

                    case "2":
                        Lista2.lista2();
                        break;

                    case "3":
                        Lista3.lista3();
                        break;

                    case "4":
                        Lista4.lista4(); 
                        break;
                }

            }
            while (escolha != "0");
        }
    }
}
