using System;
using System.Collections.Generic;
using CarAgency.Entities;

namespace CarAgency
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcaoUsuario = 5;
            //Lista de Clientes
            List<Cliente> clientes = new List<Cliente>();

           

            while (opcaoUsuario != 0)
            {
                Console.Write("Bem - vindo, (a)" +
              "\n1 - Menu Cliente" +
              "\n2 - Menu Carros" +
              "\n3 - Hall de Vendas" +
              "\n0 - Sair" +
              "\n" +
              "\n>_ ");

                opcaoUsuario = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcaoUsuario)
                {
                    case 1:

                        do
                        {
                            Console.WriteLine("Menu Clientes" +
                           "\n 1 - Cadastrar Clientes" +
                           "\n 2 - Listar Todos Clientes" +
                           "\n 0 - Sair");

                            opcaoUsuario = int.Parse(Console.ReadLine());
                            Console.Clear();

                            if (opcaoUsuario == 1)
                            {                                
                                Console.Write("Digite o nome do cliente: ");
                                string nome = Console.ReadLine();

                                Console.Write("Digite a idade do cliente: ");
                                int idade = int.Parse(Console.ReadLine());

                                Cliente cliente = new Cliente(nome, idade);
                                clientes.Add(cliente);
                                Console.Clear();
                            }
                            else if (opcaoUsuario == 2)
                            {
                                Console.Clear();
                                foreach (Cliente cliente in clientes)
                                {
                                    Console.WriteLine(cliente);
                                }
                            }

                        } while (opcaoUsuario != 0);                       
                       
                        break;

                    case 2:
                        Console.WriteLine("Carros");
                        break;

                    case 3:
                        Console.WriteLine("Hall de vendas");
                        break;

                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }

        }
    }
}
