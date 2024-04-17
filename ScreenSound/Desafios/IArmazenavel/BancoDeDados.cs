using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Desafios.IArmazenavel
{
    internal class BancoDeDados : IArmazenavel
    {
        public string Recuperar()
        {
            return "Recuperando banco de dados";
        }

        public string Salvar()
        {
            return "Salvando banco de dados";
        }
    }
}
