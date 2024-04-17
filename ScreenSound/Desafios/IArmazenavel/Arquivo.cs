using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Desafios.IArmazenavel
{
    internal class Arquivo : IArmazenavel
    {
        public string Recuperar()
        {
            return "Recuperando arquivos";
        }

        public string Salvar()
        {
            return "Salvando arquivos";
        }
    }
}
