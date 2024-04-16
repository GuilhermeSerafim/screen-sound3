using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Desafios.ContaBancaria
{
    internal class ContaPoupanca : Conta
    {
        public int TempoDeSaldoTrancadoEmDias { get; set; }
        public override void Sacar()
        {
            if (TempoDeSaldoTrancadoEmDias == 0)
            {
                base.Sacar();
            } else if(TempoDeSaldoTrancadoEmDias > 10 && TempoDeSaldoTrancadoEmDias < 30)
            {
                Saldo += 10;
                base.Sacar();
            } else if(TempoDeSaldoTrancadoEmDias > 30)
            {
                Saldo += 50;
                Console.WriteLine("Limite de rendimento atingido");
                base.Sacar();
            }
        }
    }
}
