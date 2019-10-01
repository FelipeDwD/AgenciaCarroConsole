using System;
using System.Collections.Generic;
using System.Text;

namespace CarAgency.Entities
{
    class Cliente
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public int QuantidadeComprasAgencia { get; set; }

        public Cliente() { }

        public Cliente(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;            
        }

        public void AddCompra()
        {
            QuantidadeComprasAgencia++;
        }

        public int QuantidadeCompras()
        {
            return QuantidadeComprasAgencia;
        }

        public override string ToString()
        {
            return $"\nNome: {Nome}" +
                $"\nIdade: {Idade}" +
                $"\nQuantidade Compras: {QuantidadeComprasAgencia}";
        }
    }
}
