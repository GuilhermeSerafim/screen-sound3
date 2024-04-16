using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Desafios.Eletronicos
{
    internal class Tablet : Eletronico
    {
        public override void ExibirInformacoes()
        {
            Console.WriteLine("Tablet: ");
            base.ExibirInformacoes();
        }
    }
}
