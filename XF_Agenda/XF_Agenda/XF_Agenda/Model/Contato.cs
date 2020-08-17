using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace XF_Agenda.Model
{
    public class Contato : NotifyBase
    {
        //Para criar, usei o snippet "propfull", que cria
        //automaticamente o "property" e o "backing field"
        private string nome;
        public string Nome
        {
            get { return nome; }
            set {
                nome = value;
                //Para informar aos clientes desta classe 
                //que essa propriedade "nome" foi alterada
                Notificar();
            }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set { 
                email = value;
                Notificar();
            }
        }

    }
}

    

