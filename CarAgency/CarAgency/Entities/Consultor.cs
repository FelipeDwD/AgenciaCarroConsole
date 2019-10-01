using CarAgency.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarAgency.Entities
{
    class Consultor
    {
        private int _quantidaDeVendas;
        public string Nome { get; set; }
        public ConsultorNivel Cargo { get; set; }

        public Consultor() { }

        public Consultor(string nome, ConsultorNivel cargo)
        {
            Nome = nome;
            Cargo = cargo;
        }

        public int QuantidadeDeVendas
        {
            get { return _quantidaDeVendas; }
            set
            {
                _quantidaDeVendas = 0;
            }
        }

        public void Vender(Venda venda)
        {
            QuantidadeDeVendas++;
            venda.cliente.AddCompra();
        }
    }
}
