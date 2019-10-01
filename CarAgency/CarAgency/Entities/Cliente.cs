using System;
using System.Collections.Generic;
using System.Text;

namespace CarAgency.Entities
{
    class Cliente
    {
        public string Nome { get; set; }
        public int idade { get; set; }
        public int QuantidadeComprasAgencia { get; set; }

        public Cliente() { }

        public Cliente(string Nome, int idade)
        {
            Nome = Nome;
            idade = idade;
            AddCompra();
        }

        public void AddCompra()
        {
            QuantidadeComprasAgencia++;
        }

        public int QuantidadeCompras()
        {
            return QuantidadeComprasAgencia;
        }
    }
}
