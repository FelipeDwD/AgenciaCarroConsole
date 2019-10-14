using System;
using System.Collections.Generic;
using System.Text;

namespace CarAgency.Entities
{
    class Cliente
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public int QuantidadeComprasAgencia { get; private set; }

        public List<Venda> Compras { get; set; } = new List<Venda>();

        public Cliente() { }

        public Cliente(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;            
        }

        public void AddCompra_AtualizarQuantidadeCompras(Venda venda)
        {
            QuantidadeComprasAgencia++;
            Compras.Add(venda);
        }
       
        public string HistoricoCompras()
        {
            string comprasCliente = "";

            if (Compras.Count != 0)
            {
                foreach (Venda venda in Compras)
                {
                    comprasCliente += venda.ToString();
                }
            }
            else
            {
                comprasCliente = "Cliente não efetuou nenhum compra ainda";
            }
            return comprasCliente;
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();          

            sb.Append("Nome: ");
            sb.Append(Nome);
            sb.AppendLine("Idade: ");
            sb.Append(Idade);
            sb.AppendLine("Quantidade de compras: ");
            sb.Append(QuantidadeComprasAgencia);
            sb.AppendLine("Compras: ");
            sb.AppendLine(HistoricoCompras());

            return sb.ToString();

        }
    }
}
