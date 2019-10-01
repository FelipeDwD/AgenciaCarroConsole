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

        public Cliente cliente { get; private set; }

        public List<Carro> carros { get; private set; } = new List<Carro>();
 
        public Venda() { }       

        public int QuantidadeDeCarros
        {
            get { return _quantidaDeCarros; }
            set
            {
                _quantidaDeCarros = 0;
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
                _date = DateTime.Now;
            }
        }

        public void AddCliente(Cliente cli)
        {
            cliente = cli;
        }

        public void AddCarros(Carro carro)
        {
            ValorTotal += carro.Preco;
            QuantidadeDeCarros++;
            carros.Add(carro);
        }
    }
}
