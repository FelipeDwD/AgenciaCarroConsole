using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace CarAgency.Entities
{
    class Venda
    {            

        public int QuantidadeDeCarros { get; private set; }

        public double ValorTotal { get; private set; }

        public DateTime DataVenda { get; set; }

        public Cliente Cliente { get; private set; }

        public List<Carro> Carros { get; private set; } = new List<Carro>();

        public string Descricao { get; private set; }

        public Venda() { }     
        
       
        public Venda(Cliente cli, List<Carro> carrosVendidos)
        {
            Cliente = cli;
            Carros = carrosVendidos;
            QuantidadeDeCarros = carrosVendidos.Count;
            DataVenda = DateTime.Now;
            addCarrosListaDescricao_IncrementarValorTotal(carrosVendidos);
        }

        public void addCarrosListaDescricao_IncrementarValorTotal(List<Carro> carrosVendidos)
        {            
            foreach (Carro carro in carrosVendidos)
            {
                ValorTotal += carro.Preco;
                Descricao += $"\n{carro}";
            }
        }

        public override string ToString()
        {
            return $"\n::: NOTA EMITIDA :::" +
                $"\n Valor Total: {ValorTotal.ToString("F2", CultureInfo.InvariantCulture)}" +
                $"\n Quantidade de Carros: {QuantidadeDeCarros}" +
                $"\n Data da Venda: {DataVenda}" +
                $"\n\n Carro(s) comprados: {Descricao}";
        }



    }
}
