namespace Stepper
{
    partial class FrmConsultaDinamica
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvDinamicas = new System.Windows.Forms.DataGridView();
            this.btnRemover = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDinamicas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDinamicas
            // 
            this.dgvDinamicas.AllowUserToAddRows = false;
            this.dgvDinamicas.AllowUserToDeleteRows = false;
            this.dgvDinamicas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDinamicas.Location = new System.Drawing.Point(12, 43);
            this.dgvDinamicas.Name = "dgvDinamicas";
            this.dgvDinamicas.ReadOnly = true;
            this.dgvDinamicas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDinamicas.Size = new System.Drawing.Size(322, 254);
            this.dgvDinamicas.TabIndex = 0;
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(259, 303);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 1;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // FrmConsultaDinamica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 360);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.dgvDinamicas);
            this.Name = "FrmConsultaDinamica";
            this.Text = "Consulta de Dinâmicas";
            this.Load += new System.EventHandler(this.FrmConsultaDinamica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDinamicas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDinamicas;
        private System.Windows.Forms.Button btnRemover;
    }
}