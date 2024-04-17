using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Desafios.IPagavel
{
    internal class Servico : IPagavel
    {
        public double CalcularPagamento()
        {
            Console.WriteLine("Digite as horas trabalhadas");
            int hrsTrabalhadas = int.Parse(Console.ReadLine()!);
            return hrsTrabalhadas * 43.08; // Preço por hora
        }
    }
}
