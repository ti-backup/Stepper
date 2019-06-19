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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
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
            /*
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
            */
        }

        private void itemMenuArquivoNovaDinamica_Click(object sender, EventArgs e)
        {
            FrmNovaDinamica novaDin = new FrmNovaDinamica();
            novaDin.MdiParent = this;
            novaDin.WindowState = FormWindowState.Maximized;
            novaDin.Show();
        }

        private void itemMenuArquivoConsultarDinamica_Click(object sender, EventArgs e)
        {
            FrmConsultaDinamica consulta = new FrmConsultaDinamica();
            consulta.MdiParent = this;
            consulta.WindowState = FormWindowState.Maximized;
            consulta.Show();
        }
    }
}
