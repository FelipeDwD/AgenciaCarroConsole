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
            #region "Variáveis"
            //Variável para gerenciar as opções do usuário no menu principal
            int opcaoUsuario = 5;

            //Variáveis para gerenciar objetos do tipo: Cliente
            List<Cliente> clientes = new List<Cliente>();
            int opcaoUsuarioCliente = 5;

            //Variáveis para gerenciar objetos do tipo: Carro
            List<Carro> carrosDisponiveis = new List<Carro>();
            int opcaoUsuarioCarro = 5;
            List<Carro> carrosComprados = new List<Carro>();
            int opcaoUsuarioVendas = 5;
            bool addCarrosVendas = false;
            double valorVenda = 0.0;

            //Variável para gerenciar objeto do tipo: Consultor
            List<Consultor> consultores = new List<Consultor>();

            //Variável para gerenciar menu, ela verificar se o usuário já passou pela sessão.
            int count = 0;
            #endregion

            #region "Menu principal: um todo"
            //Arvôre: Menu Principal
            while (opcaoUsuario != 0)
            {
                //Painel de opções Menu: Principal
                #region Painel Menu Principal
                Console.Write("Bem - vindo, (a)" +
              "\n1 - Menu Cliente" +
              "\n2 - Menu Carros" +
              "\n3 - Hall de Vendas" +
              "\n0 - Sair" +
              "\n" +
              "\n>_ ");
                #endregion

                #region Receber Opção e Limpar Console
                //Variável que gerencia a opção selecionada pelo usuário.
                opcaoUsuario = int.Parse(Console.ReadLine());

                //Limpa o console para exibir o menu da opção escolhida.
                Console.Clear();
                #endregion


                //Switch para gerenciar a opção inserida pelo usuário
                #region Área de navegação do usuário
                switch (opcaoUsuario)
                {
                    //Arvore: Menu Principal -> Menu Clliente
                    case 1:
                        count = 0;
                        do
                        {
                            //Painel de opções Menu: Cliente
                            if (count == 0)
                            {
                                Console.Write("Menu Clientes" +
                                "\n 1 - Cadastrar Clientes" +
                                "\n 2 - Listar Todos Clientes" +
                                "\n 0 - Sair" +
                                "\n >_ ");
                                count++;
                            }

                            //Variável gerenciadora nessse momento recebe o valor de opção dentro do menu cliente
                            opcaoUsuarioCliente = int.Parse(Console.ReadLine());
                            //Limpa o console para exibir o sub-menu.
                            Console.Clear();

                            //Arvore: Menu Principal -> Menu Cliente -> Cadastrar Clientes
                            #region Cadastrar Clientes
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
                            #endregion

                            //Arvore: Menu Principal -> Menu Cliente -> Consultar Clientes
                            #region Consultar Clientes
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
                                #endregion

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
                                Console.Write("Menu de carros" +
                                                      "\n 1 - Cadastrar Carro" +
                                                      "\n 2 - Listar Todos carros cadastrados" +
                                                      "\n 0 - Voltar" +
                                                      "\n >_ ");
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
                                carrosDisponiveis.Add(carro);
                                Console.Clear();
                                Console.WriteLine("Carro cadastrado!");
                                count = 0;
                                Console.ReadKey();
                                Console.Clear();
                            }
                            else if (opcaoUsuarioCarro == 2)
                            {
                                Console.Clear();
                                if (carrosDisponiveis.Count > 0)
                                {
                                    Console.WriteLine($"Total de carros cadastrados: {carrosDisponiveis.Count}");
                                    foreach (Carro carro in carrosDisponiveis)
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
                                Console.Write("Menu de vendas" +
                                    "\n 1 - Vender" +
                                    "\n 2 - Cadastrar Consultor" +
                                    "\n 3 - Listar Consultores Cadastrados" +
                                    "\n 0 - Sair" +
                                    "\n >_ ");
                                count++;
                            }

                            opcaoUsuarioVendas = int.Parse(Console.ReadLine());
                            Console.Clear();

                            if (opcaoUsuarioVendas == 1)
                            {

                                if (clientes.Count != 0 && carrosDisponiveis.Count != 0 && consultores.Count != 0)
                                {
                                    addCarrosVendas = true;
                                    Console.WriteLine("Quem efetuou a venda? ");
                                    for (int i = 0; i < consultores.Count; i++)
                                    {
                                        Console.WriteLine($"[{(i + 1)}] - {consultores[i].Nome}");
                                    }
                                    Console.WriteLine();
                                    Console.Write(">_ ");
                                    int consultorPosition = int.Parse(Console.ReadLine()) - 1;
                                    Consultor consultor = consultores[consultorPosition];

                                    Console.WriteLine($"{consultor.Nome} vendeu para qual cliente? ");

                                    Console.WriteLine("Qual cliente efeutou a compra? ");
                                    for (int i = 0; i < clientes.Count; i++)
                                    {
                                        Console.WriteLine($"[{(i + 1)}] - {clientes[i].Nome}");
                                    }
                                    Console.WriteLine();
                                    Console.Write(">_ ");

                                    int clientePosition = int.Parse(Console.ReadLine()) - 1;
                                    Cliente cliente = clientes[clientePosition];

                                    while (addCarrosVendas)
                                    {
                                        Console.Clear();
                                        Console.WriteLine($"Qual carro {cliente.Nome} comprou? ");
                                        for (int i = 0; i < carrosDisponiveis.Count; i++)
                                        {                                        
                                            Console.WriteLine($"\n[{(i + 1)}] :: " +
                                            $"{carrosDisponiveis[i]}");                                              
                                        }
                                        Console.WriteLine();
                                        Console.Write(">_ ");
                                        int carroVendidoPosicao = int.Parse(Console.ReadLine()) - 1;
                                        Carro carroVendido = carrosDisponiveis[carroVendidoPosicao];
                                        valorVenda += carroVendido.Preco;
                                        carrosComprados.Add(carroVendido);
                                        carrosDisponiveis.Remove(carroVendido);


                                        if (consultor.Cargo.ToString().Equals("Estagiario"))
                                        {
                                            Venda venda = new Venda(cliente, consultor, carrosComprados);
                                            consultor.VerificarConsultorPodeVender(venda);

                                            if (consultor.AprovadoParaVender)
                                            {
                                                addCarrosVendas = EfetuarVenda_EmitirNotaFiscal(venda, consultor, carrosComprados, carrosDisponiveis);
                                            }
                                            else
                                            {
                                                addCarrosVendas = LimiteVendaColaborador_E_LimparLista(carrosComprados, carrosDisponiveis);                                               
                                            }
                                        }
                                        else
                                        {

                                            Console.Write("Acrescentar carro na venda? " +
                                                       "\n 1 - Sim" +
                                                      "\n 0 - Não" +
                                                      "\n >_ ");

                                            int continuarRegistrandoVenda = int.Parse(Console.ReadLine());

                                            while (continuarRegistrandoVenda != 0 && continuarRegistrandoVenda != 1)
                                            {
                                                Console.Write("Opção inválida!" +
                                                    "\nTente novamente: ");
                                                continuarRegistrandoVenda = int.Parse(Console.ReadLine());
                                            }
                                            if (continuarRegistrandoVenda == 0)
                                            {
                                                valorVenda = 0.0;
                                                Venda venda = new Venda(cliente, consultor, carrosComprados);

                                                if (consultor.Cargo.ToString().Equals("Junior"))
                                                {
                                                    consultor.VerificarConsultorPodeVender(venda);
                                                    if (consultor.AprovadoParaVender)
                                                    {
                                                        addCarrosVendas = EfetuarVenda_EmitirNotaFiscal(venda, consultor, carrosComprados, carrosDisponiveis);
                                                    }
                                                    else
                                                    {
                                                        addCarrosVendas = LimiteVendaColaborador_E_LimparLista(carrosComprados, carrosDisponiveis);                                                        
                                                    }
                                                }
                                                else
                                                {
                                                    addCarrosVendas = EfetuarVenda_EmitirNotaFiscal(venda, consultor, carrosComprados, carrosDisponiveis);
                                                }
                                            }

                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Não há disponível todos recursos suficientes para efetuar uma venda!" +
                                        "\nFavor, verificar recursos: " +
                                        "\n" +
                                        $"\nCarros cadastrados: {carrosDisponiveis.Count}" +
                                        $"\nConsultores cadastrados: {consultores.Count}" +
                                        $"\nClientes cadastrados: {clientes.Count}");
                                }
                                Console.WriteLine();
                                Console.WriteLine("0 - Voltar");
                            }
                            else if (opcaoUsuarioVendas == 2)
                            {
                                Console.Write("Digite o nome do consultor: ");
                                string nome = Console.ReadLine();

                                Console.Write($"Digite o nível do {nome} (Estagiario/Junior/Pleno/Senior): ");
                                ConsultorNivel nivelConsultor = Enum.Parse<ConsultorNivel>(Console.ReadLine());

                                Consultor consultor = new Consultor(nome, nivelConsultor);
                                consultores.Add(consultor);
                                Console.Clear();
                                Console.WriteLine($"Consultor: {nome} cadastrado com sucesso!");
                                count = 0;
                                Console.ReadKey();
                                Console.Clear();

                            }
                            else if (opcaoUsuarioVendas == 3)
                            {
                                if (consultores.Count > 0)
                                {
                                    foreach (Consultor consultor in consultores)
                                    {
                                        Console.WriteLine(consultor);
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Não existe nenhum consultor cadastrado!");
                                }
                                Console.WriteLine();
                                Console.WriteLine("0 - Voltar");
                            }

                        } while (opcaoUsuarioVendas != 0);
                        break;

                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
                #endregion
            }
            #endregion

        }

        //Função para todos as operações que envolve a efetuação de uma venda
        #region Função Efetuar Venda e Emitir Nota Fiscal        
        static bool EfetuarVenda_EmitirNotaFiscal(Venda venda, Consultor consultor, List<Carro> carrosComprados, List<Carro> carrosDisponiveis)
        {
            consultor.Vender(venda);
            Console.Clear();
            Console.WriteLine("Venda efetuada com sucesso!");
            Console.ReadKey();
            Console.WriteLine(venda);
            LimparListas_CarrosDisponiveis_E_CarrosComprados(carrosComprados, carrosDisponiveis);
            return false;
        }
        #endregion

        #region Função Limite de valor colaborador
        static bool LimiteVendaColaborador_E_LimparLista(List<Carro> carrosComprados, List<Carro> carrosDisponiveis)
        {
            foreach (Carro carro in carrosComprados)
            {
                carrosDisponiveis.Add(carro);
            }
            Console.Clear();
            Console.WriteLine("Atingiu limite para Juniores");
            carrosComprados.Clear();
            return false;
        }
        #endregion

        #region Função para Limpar listas carros disponíveis e carros cadastrados
        static void LimparListas_CarrosDisponiveis_E_CarrosComprados(List<Carro> carrosComprados, List<Carro> carrosDisponiveis)
        {
            foreach (Carro carro in carrosComprados)
            {
                carrosDisponiveis.Remove(carro);
            }
            carrosComprados.Clear();
        }
        #endregion
    }
}
