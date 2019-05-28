using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stepper
{
    class NumeroChave
    {
        public Byte Numero { set; get; }
        public Boolean Primo { private set; get; }
        private List<Trio> DivisoresExatos { set; get; }
        private List<Trio> DivisoresNExatos { set; get; }

        public NumeroChave(Byte numero)
        {
            this.Numero = numero;
        }

        public void Divisores()
        {
            Byte resto = 0;
            for (Byte i = 1; i <= Numero; i++)
            {
                resto = Convert.ToByte(Numero % i);
                if (resto == 0)
                {
                    Trio t = new Trio();
                    t.Divisor = i;
                    t.Resultado = Convert.ToByte(Numero / i);
                    t.Resto = resto;
                    DivisoresExatos.Add(t);
                }
            }
        }
    }
}
