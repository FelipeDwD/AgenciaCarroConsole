using CarAgency.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarAgency.Entities
{
    class Consultor
    {
        private bool _aprovadoParaVender;
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
            double desconto = 0.0;           
            int comprasCliente = venda.Cliente.QuantidadeComprasAgencia;
            bool jaEfetuouCompra = comprasCliente != 0;

            QuantidadeDeVendas++;
            venda.Cliente.AddCompra();

            if (jaEfetuouCompra)
            {
                double valorDesconto = 0.0;
                if (comprasCliente == 1)
                {
                    desconto = 0.05;
                }
                else if (comprasCliente == 3)
                {
                    desconto = 0.08;
                }
                valorDesconto = venda.ValorTotal * desconto;
                venda.AddDesconto(valorDesconto);
            }            
        }

        public bool AprovadoParaVender
        {
            get { return _aprovadoParaVender; }
            private set
            {
                _aprovadoParaVender = value;
            }
        }

        public void VerificarConsultorPodeVender(Venda venda)
        {
            if (Cargo.ToString().Equals("Estagiario"))
            {
                if (venda.ValorTotal <= 25000.00)
                {
                    AprovadoParaVender = true;
                }
                else
                {
                    AprovadoParaVender = false;
                }                
               
            }
            else if (Cargo.ToString().Equals("Junior"))
            {
                if (venda.ValorTotal <= 110000.00)
                {
                    AprovadoParaVender = true;
                }
                else
                {
                    AprovadoParaVender = false;
                }               
            }                     
        }

        public override string ToString()
        {
            return $"Nome: {Nome}" +
                $"\nCargo: {Cargo}" +
                $"\nQuantidade de vendas: {QuantidadeDeVendas}";
        }
    }
}
