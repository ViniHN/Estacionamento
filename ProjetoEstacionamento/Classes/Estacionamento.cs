using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstacionamento.Classes
{
    internal class Estacionamento
    {
        public double PrecoEstacionamento { get; set; }
        public double PrecoHora { get; set; }
        public List<string> Veiculos { get; set; } = new List<string>();

        public Estacionamento(double precoEstacionamento, double precoHora)
        {
            PrecoEstacionamento = precoEstacionamento;
            PrecoHora = precoHora;
        }


        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            Veiculos.Add(Console.ReadLine());
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remove-lo:");
            string placa = Console.ReadLine();

            if (Veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado: ");
                int hora = int.Parse(Console.ReadLine());

                double valorTotal = PrecoEstacionamento + PrecoHora * hora;

                Veiculos.Remove(placa);
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }

            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculo()
        {
            if (Veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são");
                foreach (string veiculos in Veiculos)
                {
                    Console.WriteLine(veiculos);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
