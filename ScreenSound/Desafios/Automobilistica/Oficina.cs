using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Desafios.Automobilistica
{
    internal class Oficina
    {
        private List<Veiculo> veiculosNaOficina;

        public Oficina()
        {
            veiculosNaOficina = new List<Veiculo>();
        }
        
        public void AgendarServiço(Cliente cliente, Mecanico mecanico, Veiculo veiculo, string data)
        {
            veiculosNaOficina.Add(veiculo);
            Console.WriteLine($"Serviço agendado para o cliente {cliente.Nome} em {data} com o mecânico {mecanico.Nome}. \n" +
                $"Veiculo:\n" +
                $"Modelo{veiculo.Modelo}\n" +
                $"Placa {veiculo.Placa}\n" +
                $"Marca {veiculo.Marca}");
        }
    }
}
