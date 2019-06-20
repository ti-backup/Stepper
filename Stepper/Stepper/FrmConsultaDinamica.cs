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
    public partial class FrmConsultaDinamica : Form
    {
        public FrmConsultaDinamica()
        {
            InitializeComponent();
        }

        private void FrmConsultaDinamica_Load(object sender, EventArgs e)
        {
            ExibeTodosRegistros();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection linhas = dgvDinamicas.SelectedRows;
            DinamicaDao dinDao = new DinamicaDao();
            Int32 id = Convert.ToInt32(linhas[0].Cells[0].Value);
            dinDao.Remove(id);

            ExibeTodosRegistros();
        }

        public void ExibeTodosRegistros()
        {
            DinamicaDao dinDao = new DinamicaDao();
            DataTable dt = dinDao.BuscaTodos();
            ExibeRegistros(dt);
        }

        private void ExibeRegistros(DataTable dados)
        {
            dgvDinamicas.DataSource = dados;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection linhas = dgvDinamicas.SelectedRows;
            if (linhas.Count != 1)
            {
                MessageBox.Show("Selecione um registro para atualizá-lo");
                return;
            }

            Int32 id = Convert.ToInt32(linhas[0].Cells[0].Value);
            FrmAtualizaDinamica atualiza = new FrmAtualizaDinamica(this, id);
            atualiza.MdiParent = this.MdiParent;
            atualiza.Show();
        }
    }
}
