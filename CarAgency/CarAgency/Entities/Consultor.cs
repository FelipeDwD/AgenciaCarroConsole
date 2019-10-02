using CarAgency.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarAgency.Entities
{
    class Consultor
    {
        public int QuantidadeDeVendas { get; set; }
        public string Nome { get; set; }
        public ConsultorNivel Cargo { get; set; }

        public Consultor() { }

        public Consultor(string nome, ConsultorNivel cargo)
        {
            Nome = nome;
            Cargo = cargo;
        }       

        public void Vender(Venda venda)
        {
            QuantidadeDeVendas++;
            venda.Cliente.AddCompra();
        }

        public override string ToString()
        {
            return $"Nome: {Nome}" +
                $"\nCargo: {Cargo}" +
                $"\nQuantidade de vendas: {QuantidadeDeVendas}";
        }
    }
}
