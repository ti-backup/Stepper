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
    public partial class FrmNovaDinamica : Form
    {
        List<Participante> Participantes;

        public FrmNovaDinamica()
        {
            InitializeComponent();
            Participantes = new List<Participante>();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Participante p = new Participante();
            p.Nome = txtNome.Text;

            Participantes.Add(p);
            AtualizaViewParticipantes();

            txtNome.Clear();
            txtNome.Focus();
        }

        private void AtualizaViewParticipantes()
        {
            dgvParticipantes.DataSource = null;
            dgvParticipantes.DataSource = Participantes;
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            String[] caminho;
            if (ofdArquivo.ShowDialog() == DialogResult.OK)
            {
                caminho = ofdArquivo.FileName.Split('\\');
                txtArquivo.Text = caminho[caminho.Length - 1];
                LeArquivo(ofdArquivo.FileName);
            }
        }

        private void LeArquivo(String caminhoArquivo)
        {

        }
    }
}
