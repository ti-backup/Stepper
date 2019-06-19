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

        private void ExibeTodosRegistros()
        {
            DinamicaDao dinDao = new DinamicaDao();
            DataTable dt = dinDao.BuscaTodos();
            ExibeRegistros(dt);
        }

        private void ExibeRegistros(DataTable dados)
        {
            dgvDinamicas.DataSource = dados;
        }
    }
}
