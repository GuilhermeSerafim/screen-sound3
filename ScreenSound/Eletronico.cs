using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound
{
    internal class Eletronico
    {
        public string Nome { get; set; }
        public string Cor { get; set; }
        public virtual void ExibirInformacoes()
        {
            Console.WriteLine(Nome + " " + Cor);
        }
    }
}
