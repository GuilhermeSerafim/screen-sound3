using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Desafios.Automobilistica;

internal class Veiculo(string marca, string modelo, int ano, string placa) : IVoavel, IPilotavel
{
    public string Marca { get; } = marca;
    public string Modelo { get; } = modelo;
    public int Ano { get; set; } = ano;
    public string Placa { get; } = placa;

    public void InfoVeiculo()
    {
        Console.WriteLine("Informações do mecanico:");
        Console.WriteLine($"Marca {Marca}");
        Console.WriteLine($"Modelo {Modelo}");
        Console.WriteLine($"Ano {Ano}");
        Console.WriteLine($"Placa {Placa}");
    }
}
