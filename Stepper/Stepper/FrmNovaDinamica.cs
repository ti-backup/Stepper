using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;

namespace Stepper
{
    public partial class FrmNovaDinamica : Form
    {
        List<Participante> Participantes;
        NumeroChave nc;

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
                AtualizaViewParticipantes();
            }
        }

        private void LeArquivo(String caminhoArquivo)
        {
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(caminhoArquivo);
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Excel.Range xlRange = xlWorksheet.UsedRange;

            Byte numColunas = 1;
            Byte numLinhas = 14;

            for (Byte i = 1; i <= numColunas; i++)
            {
                for (Byte j = 2; j <= numLinhas; j++)
                {
                    if (xlRange.Cells[j, i] != null && xlRange.Cells[j, i].Value2 != null)
                    {
                        Participante p = new Participante();
                        p.Nome = xlRange.Cells[j, i].Value2.ToString();

                        Participantes.Add(p);
                    }
                }
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();

            Marshal.ReleaseComObject(xlRange);
            Marshal.ReleaseComObject(xlWorksheet);

            xlWorkbook.Close();
            Marshal.ReleaseComObject(xlWorkbook);

            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);
        }

        private void btnOpcoes_Click(object sender, EventArgs e)
        {
            nc = new NumeroChave((Byte)Participantes.Count);
            String resultado = "";
            foreach (Opcao t in nc.OpcoesGrupos)
            {
                resultado += "[" + t.NumeroGrupos + ", " + t.Membros + "]";
                if (t.ComplementoGrupos != 0)
                {
                    resultado += " e [" + t.ComplementoGrupos + ", " + t.ComplementoMembros + "]";
                }
                resultado += Environment.NewLine;
            }
            txtOpcoes.Text = resultado;
        }
    }
}
