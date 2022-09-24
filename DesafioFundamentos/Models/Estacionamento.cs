using System;
using System.Collections.Generic;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();
        string[] placa = new string[] { };

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");

            placa = Console.ReadLine().Split(' ');
            veiculos.AddRange(placa);

            foreach (string car in placa)
            {
                Console.WriteLine($"Os veículos {car} foi adicionado:  ");
            }
        }

        public void RemoverVeiculo()
        {
            if (veiculos.Any()) //x => x.ToUpper() == placa.ToUpperr()))
            {
                Console.WriteLine("Digite a placa do veículo para remover:");
                placa = Console.ReadLine().Split(' ');


                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                int horas = Convert.ToInt32(Console.ReadLine());

                decimal valorTotal = precoInicial + precoPorHora * horas;

                foreach (string car in placa)
                {

                    Console.WriteLine($"O veículo {car} foi removido e o preço total foi de: R$ {valorTotal}");
                    veiculos.Remove(car);
                }

            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine($"Percorrendo o Array com o foreach");
                foreach (string car in veiculos)
                {
                    Console.WriteLine($"Os veículos estacionados são:  {car}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}





