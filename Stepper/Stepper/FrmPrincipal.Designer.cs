namespace Stepper
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemMenuArquivoNovaDinamica = new System.Windows.Forms.ToolStripMenuItem();
            this.itemMenuArquivoConsultarDinamica = new System.Windows.Forms.ToolStripMenuItem();
            this.itemMenuArquivoSair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(597, 24);
            this.menuPrincipal.TabIndex = 0;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemMenuArquivoNovaDinamica,
            this.itemMenuArquivoConsultarDinamica,
            this.itemMenuArquivoSair});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "&Arquivo";
            // 
            // itemMenuArquivoNovaDinamica
            // 
            this.itemMenuArquivoNovaDinamica.Name = "itemMenuArquivoNovaDinamica";
            this.itemMenuArquivoNovaDinamica.Size = new System.Drawing.Size(187, 22);
            this.itemMenuArquivoNovaDinamica.Text = "&Nova Dinâmica...";
            this.itemMenuArquivoNovaDinamica.Click += new System.EventHandler(this.itemMenuArquivoNovaDinamica_Click);
            // 
            // itemMenuArquivoConsultarDinamica
            // 
            this.itemMenuArquivoConsultarDinamica.Name = "itemMenuArquivoConsultarDinamica";
            this.itemMenuArquivoConsultarDinamica.Size = new System.Drawing.Size(187, 22);
            this.itemMenuArquivoConsultarDinamica.Text = "&Consultar Dinâmica...";
            // 
            // itemMenuArquivoSair
            // 
            this.itemMenuArquivoSair.Name = "itemMenuArquivoSair";
            this.itemMenuArquivoSair.Size = new System.Drawing.Size(187, 22);
            this.itemMenuArquivoSair.Text = "&Sair";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 450);
            this.Controls.Add(this.menuPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "FrmPrincipal";
            this.Text = "Stepper - Rodada de Negócios";
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemMenuArquivoNovaDinamica;
        private System.Windows.Forms.ToolStripMenuItem itemMenuArquivoConsultarDinamica;
        private System.Windows.Forms.ToolStripMenuItem itemMenuArquivoSair;
    }
}

