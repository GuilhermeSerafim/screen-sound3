using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Desafios.IPagavel
{
    internal class Produto : IPagavel
    {
        public double CalcularPagamento()
        {
            Console.WriteLine("Digite quantidade de produtos");
            int qtdProdutos = int.Parse(Console.ReadLine()!);
            return qtdProdutos * 12.50; // Preço por produto
        }
    }
}
