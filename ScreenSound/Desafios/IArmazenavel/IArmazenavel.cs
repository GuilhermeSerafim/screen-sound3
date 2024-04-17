using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Desafios.IArmazenavel
{
    internal interface IArmazenavel
    {
        string Salvar();
        string Recuperar();
    }
}
