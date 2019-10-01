using System;
using System.Collections.Generic;
using CarAgency.Entities;
using System.Globalization;
using CarAgency.Entities.Enums;

namespace CarAgency
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcaoUsuario = 5;
            //Clientes
            List<Cliente> clientes = new List<Cliente>();
            int opcaoUsuarioCliente = 5;

            //Carros
            List<Carro> carros = new List<Carro>();
            int opcaoUsuarioCarro = 5;

            //Vendas
            List<Consultor> consultores = new List<Consultor>();
            int opcaoUsuarioVendas = 5;

            int count = 0;


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
                        count = 0;
                        do
                        {
                            if (count == 0)
                            {
                                Console.WriteLine("Menu Clientes" +
                                "\n 1 - Cadastrar Clientes" +
                                "\n 2 - Listar Todos Clientes" +
                                "\n 0 - Sair");
                                count++;
                            }

                            opcaoUsuarioCliente = int.Parse(Console.ReadLine());
                            Console.Clear();

                            if (opcaoUsuarioCliente == 1)
                            {
                                Console.Write("Digite o nome do cliente: ");
                                string nome = Console.ReadLine();

                                Console.Write("Digite a idade do cliente: ");
                                int idade = int.Parse(Console.ReadLine());

                                Cliente cliente = new Cliente(nome, idade);
                                clientes.Add(cliente);
                                Console.Clear();
                                Console.WriteLine("Cliente cadastrado");
                                count = 0;
                                Console.ReadKey();
                                Console.Clear();
                            }
                            else if (opcaoUsuarioCliente == 2)
                            {
                                Console.Clear();
                                if (clientes.Count > 0)
                                {
                                    Console.WriteLine($"Total de clientes: {clientes.Count}");
                                    Console.WriteLine();
                                    foreach (Cliente cliente in clientes)
                                    {
                                        Console.WriteLine(cliente);
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Não existe nenhum cliente cadastrado!");
                                }
                                Console.WriteLine();
                                Console.WriteLine("0 - voltar");
                            }
                        } while (opcaoUsuarioCliente != 0);

                        break;

                    case 2:
                        count = 0;
                        do
                        {
                            if (count == 0)
                            {
                                Console.WriteLine("Menu de carros" +
                                                      "\n 1 - Cadastrar Carro" +
                                                      "\n 2 - Listar Todos carros cadastrados" +
                                                      "\n 0 - Voltar");
                                count++;
                            }


                            opcaoUsuarioCarro = int.Parse(Console.ReadLine());
                            Console.Clear();

                            if (opcaoUsuarioCarro == 1)
                            {
                                Console.Write("Digite a marca do carro: ");
                                string marca = Console.ReadLine();

                                Console.Write("Digite o modelo do carro: ");
                                string modelo = Console.ReadLine();

                                Console.Write("Digite a cor do carro: ");
                                string cor = Console.ReadLine();

                                Console.Write("Digite a placa do carro: ");
                                string placa = Console.ReadLine();

                                Console.Write("Digite o preço do carro: ");
                                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                                Carro carro = new Carro(marca, modelo, cor, placa, preco);
                                carros.Add(carro);
                                Console.Clear();
                                Console.WriteLine("Carro cadastrado!");
                                count = 0;
                                Console.ReadKey();
                                Console.Clear();
                            }
                            else if (opcaoUsuarioCarro == 2)
                            {
                                Console.Clear();
                                if (carros.Count > 0)
                                {
                                    Console.WriteLine($"Total de carros cadastrados: {carros.Count}");
                                    foreach (Carro carro in carros)
                                    {
                                        Console.WriteLine(carro);
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Não existe nenhum carro cadastrado!");
                                }
                                Console.WriteLine();
                                Console.WriteLine("0 - Voltar");
                            }

                        } while (opcaoUsuarioCarro != 0);

                        break;

                    case 3:
                        count = 0;
                        do
                        {
                            if (count == 0)
                            {
                                Console.WriteLine("\n 1 - Vender" +
                                    "\n 2 - Cadastrar Consultor" +
                                    "\n 3 - Listar Consultores Cadastrados");
                                count++;
                            }
                            opcaoUsuarioVendas = int.Parse(Console.ReadLine());
                            Console.Clear();

                            if (opcaoUsuarioVendas == 2)
                            {
                                Console.Write("Digite o nome do consultor: ");
                                string nome = Console.ReadLine();

                                Console.Write($"Digite o nível do {nome} (Estagiario/Junior/Pleno/Senior): ");
                                ConsultorNivel nivelConsultor = Enum.Parse<ConsultorNivel>(Console.ReadLine());

                                Consultor consultor = new Consultor(nome, nivelConsultor);
                                
                            }

                        } while (opcaoUsuarioVendas != 0);
                        break;

                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }

        }
    }
}
