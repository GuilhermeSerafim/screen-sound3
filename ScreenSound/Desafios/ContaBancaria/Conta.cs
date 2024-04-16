using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Desafios.ContaBancaria;

internal class Conta
{
    public double Saldo { get; set; }
    public virtual void Sacar()
    {
        if (Saldo > 0)
        {
            Console.WriteLine("Saque realizado");
            Console.WriteLine($"Seu saldo é {Saldo}");
        } else
        {
            Console.WriteLine("Saldo deve ser maior que 0 para sacar");
        }
    }
}
