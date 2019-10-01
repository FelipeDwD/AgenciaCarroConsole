using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace CarAgency.Entities
{
    class Carro
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public string Placa { get; set; }

        public double Preco { get; set; }

        public Carro() { }

        public Carro(string marca, string modelo, string cor, string placa, double preco)
        {
            Marca = marca;
            Modelo = modelo;
            Cor = cor;
            Placa = placa;
            Preco = preco;
        }

        public override string ToString()
        {
            return $"\nMarca: {Marca}" +
                $"\nModelo: {Modelo}" +
                $"\nCor: {Cor}" +
                $"\nPlaca: {Placa}" +
                $"\nPreço: {Preco.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
