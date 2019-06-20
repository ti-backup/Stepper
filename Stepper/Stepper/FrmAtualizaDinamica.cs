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
    public partial class FrmAtualizaDinamica : Form
    {
        Form origem;
        Int32 idCliente;

        public FrmAtualizaDinamica(Form origem, Int32 idCliente)
        {
            InitializeComponent();
            this.origem = origem;
            this.idCliente = idCliente;
        }

        private void FrmAtualizaDinamica_Load(object sender, EventArgs e)
        {
            DinamicaDao dinDao = new DinamicaDao();
            PreencheCampos(dinDao.BuscaPorId(idCliente));
        }

        private void PreencheCampos(Dinamica din)
        {
            txtId.Text = din.Id.ToString();
            txtNomeDocente.Text = din.Professor.Nome;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Dinamica din = new Dinamica();
            din.Id = idCliente;
            din.Professor = new Docente();
            din.Professor.Nome = txtNomeDocente.Text;

            DinamicaDao dinDao = new DinamicaDao();
            if (dinDao.Atualiza(din))
            {
                MessageBox.Show(
                    "Dinâmica atualizada com sucesso!",
                    "Atualização de Dinâmicas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
                FrmConsultaDinamica consulta = (FrmConsultaDinamica) origem;
                consulta.ExibeTodosRegistros();
                consulta.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show(
                    "Falha ao atualizar os dados da Dinâmica. Tente novamente.",
                    "Atualização de Dinâmicas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
        }
    }
}
