using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stepper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            teste();
        }

        public void teste()
        {
            /*
            Docente d = new Docente();
            d.Nome = "Ricardo";
            d.Usuario = "Ric";
            d.Senha = "123";

            Participante p = new Participante();
            p.Nome = "Jão";

            Dinamica din = new Dinamica();
            din.AdicionarDocente(d);
            din.AdicionarParticipante(p);
            */

            // TESTE DO METODO DIVISORES
            List<Byte> div;

            Dinamica d = new Dinamica();
            div = d.Divisores(13);

            String resultado = "";
            foreach (Byte aux in div)
            {
                resultado += aux + "  ";
            }

            lblDivisores.Text = resultado;
        }
    }
}
