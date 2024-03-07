using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_final_PARTE1.Models
{
    public class Estacionamento
    {
        private decimal valorInicial = 0;
        private decimal valorHora = 0;
        public int horasEstacionado = 0;
        
        
        List<string> carrosEstacionados = new List<string>();
        
        public Estacionamento(decimal valorInicial, decimal valorHora)
        {
            this.valorInicial = valorInicial;
            this.valorHora = valorHora;
        }

        public void cadastrarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo: ");
            string placa = Console.ReadLine();
            carrosEstacionados.Add(placa);
        }

        public void removerVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo: ");

            string placa = Console.ReadLine();

            if (carrosEstacionados.Contains(placa))
            {
                Console.WriteLine("Digite a quantidade de horas que o veiculo permaneceu estacionado: ");
                horasEstacionado = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"O valor a ser pago é: {valorInicial + (valorHora * horasEstacionado)}");
                carrosEstacionados.Remove(placa);
                
            }
            else
            {
                Console.WriteLine("Veículo não encontrado!");
            }
        }

        public void listarVeiculos()
        {
            if (carrosEstacionados.Any() == false)
            {
                Console.WriteLine("Nenhum veículo estacionado!");
            }
            else
            {
                foreach (var item in carrosEstacionados)
                {
                    Console.WriteLine(item);
                }
            }
        }

    }
}