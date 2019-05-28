using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stepper
{
    class Docente : Pessoa
    {
        public String Usuario { set; get; }
        public String Senha { set; get; }

        public Docente() { }

        public Boolean Login()
        {
            return false;
        }
    }
}
