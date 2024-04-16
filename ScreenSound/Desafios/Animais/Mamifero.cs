using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Desafios.Animais
{
    internal class Mamifero : Animal
    {
        public override void EmitirSom()
        {
            Console.WriteLine("Emitindo som de mamifero");
        }
    }
}
