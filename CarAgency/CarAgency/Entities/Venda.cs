using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace CarAgency.Entities
{
    class Venda
    {            
        

        public int QuantidadeDeCarros { get; private set; }        

        public DateTime DataVenda { get; set; }
        public double ValorTotal { get; set; }

        public double Desconto { get; private set; }

        public Consultor Consultor { get; set; }

        public Cliente Cliente { get; private set; }

        public List<Carro> Carros { get; private set; } = new List<Carro>();

        public string Descricao { get; private set; }

        public Venda() { }     
        
       
        public Venda(Cliente cli, Consultor cons ,List<Carro> carrosVendidos)
        {
            Cliente = cli;
            Consultor = cons;
            Carros = carrosVendidos;
            QuantidadeDeCarros = carrosVendidos.Count;
            DataVenda = DateTime.Now;
            AddCarrosListaDescricao_e_SetValorTotal(carrosVendidos);
        }

       

        public void AddCarrosListaDescricao_e_SetValorTotal(List<Carro> carrosVendidos)
        {
            foreach (Carro carro in carrosVendidos)
            {
                ValorTotal += carro.Preco;
                Descricao += $"\n{carro}";
            }
        }       

        public void AddDesconto(double valor)
        {
            ValorTotal -= valor;
            Desconto = valor;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("::: NOTA EMITIDA :::");
            sb.AppendLine("Valor total: ");
            sb.Append(ValorTotal.ToString("F2", CultureInfo.InvariantCulture));
            sb.AppendLine("Desconto: ");
            sb.Append(Desconto.ToString("F2", CultureInfo.InvariantCulture));
            sb.AppendLine("Quantidade de carros: ");
            sb.Append(QuantidadeDeCarros);
            sb.AppendLine("Data venda: ");
            sb.Append(DataVenda);
            sb.AppendLine("Carros comprados");
            sb.Append(Descricao);
            sb.AppendLine(":::::::::::::::::::::::::::::");

            return sb.ToString();

        }



    }
}
