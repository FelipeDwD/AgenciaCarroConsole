using System;
using System.Collections.Generic;
using System.Text;

namespace CarAgency.Entities
{
    class Venda
    {
        private int _quantidaDeCarros;

        private double _valorTotal;

        private DateTime _date;

        public Cliente Cliente { get; private set; }

        public List<Carro> Carros { get; private set; } = new List<Carro>();
 
        public Venda() { }       

        public Venda(Cliente cli, List<Carro> carrosVendidos)
        {
            Cliente = cli;
            Carros = carrosVendidos;
            QuantidadeDeCarros = carrosVendidos.Count;
            Date = DateTime.Now;
            foreach(Carro carro in carrosVendidos)
            {
                ValorTotal += carro.Preco;
            }
        }

        public int QuantidadeDeCarros
        {
            get { return _quantidaDeCarros; }
            set
            {
                _quantidaDeCarros = value;
            }
        }

        public double ValorTotal
        {
            get { return _valorTotal; }
            set
            {
                _valorTotal = 0.0;
            }
        }

        public DateTime Date
        {
            get { return _date; }
            set
            {
                _date = value;
            }
        }


        
    }
}
