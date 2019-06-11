using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stepper
{
    class NumeroChave
    {
        public Byte Numero { private set; get; }
        public Boolean Primo { private set; get; }
        public List<Opcao> OpcoesGrupos { set; get; }

        public NumeroChave(Byte numero)
        {
            this.Numero = numero;
            OpcoesGrupos = new List<Opcao>();
            Divisores(this.Numero, true);
            if (VerificaPrimo())
                Divisores((Byte)(this.Numero - 1), false);
        }

        private Boolean VerificaPrimo()
        {
            if (OpcoesGrupos.Count == 0)
                Divisores(this.Numero, true);

            if (this.Numero == 1) this.Primo = false;
            else
            {
                if (OpcoesGrupos.Count == 2)
                {
                    this.Primo = true;
                }
                else
                {
                    this.Primo = false;
                }
            }
            return this.Primo;
        }

        private void Divisores(Byte numero, Boolean exato)
        {
            Byte resto = 0;
            Byte numGrupos;
            Byte numMembros;
            for (Byte i = 1; i <= numero; i++)
            {
                resto = Convert.ToByte(numero % i);
                if (resto == 0)
                {
                    if (exato)
                    {
                        Opcao op1 = new Opcao();
                        op1.NumeroGrupos = i;
                        op1.Membros = Convert.ToByte(numero / i);
                        OpcoesGrupos.Add(op1);
                    }
                    else
                    {
                        // TRATAMENTO PARA EVITAR OPCAO COM ZERO GRUPOS
                        if (i == 1) continue;

                        numGrupos = (Byte)(i - 1);
                        numMembros = Convert.ToByte(numero / i);

                        Opcao op1 = new Opcao();
                        op1.NumeroGrupos = numGrupos;
                        op1.Membros = numMembros;
                        op1.ComplementoGrupos = 1;
                        op1.ComplementoMembros = (Byte)(numMembros + 1);
                        OpcoesGrupos.Add(op1);
                    }
                }
            }
        }
    }
}
