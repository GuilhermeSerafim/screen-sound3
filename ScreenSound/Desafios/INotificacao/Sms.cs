using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Desafios.INotificacao
{
    internal class Sms : INotificavel
    {
        public string EnviarNotificao()
        {
            return "Enviando notificação de SMS";
        }
    }
}
