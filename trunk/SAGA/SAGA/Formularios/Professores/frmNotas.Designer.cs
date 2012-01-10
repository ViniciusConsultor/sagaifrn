namespace SAGA.Formularios.Professores
{
    partial class frmNotas
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.grdNotas = new System.Windows.Forms.DataGridView();
            this.Aluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSair = new System.Windows.Forms.Label();
            this.lblPaginaInicial = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdNotas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(313, 399);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // grdNotas
            // 
            this.grdNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdNotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Aluno,
            this.Nota});
            this.grdNotas.Location = new System.Drawing.Point(12, 55);
            this.grdNotas.Name = "grdNotas";
            this.grdNotas.Size = new System.Drawing.Size(376, 338);
            this.grdNotas.TabIndex = 1;
            // 
            // Aluno
            // 
            this.Aluno.HeaderText = "Aluno";
            this.Aluno.Name = "Aluno";
            // 
            // Nota
            // 
            this.Nota.HeaderText = "Nota";
            this.Nota.Name = "Nota";
            // 
            // lblSair
            // 
            this.lblSair.AutoSize = true;
            this.lblSair.Location = new System.Drawing.Point(377, 9);
            this.lblSair.Name = "lblSair";
            this.lblSair.Size = new System.Drawing.Size(25, 13);
            this.lblSair.TabIndex = 42;
            this.lblSair.Text = "Sair";
            this.lblSair.Click += new System.EventHandler(this.lblSair_Click);
            // 
            // lblPaginaInicial
            // 
            this.lblPaginaInicial.AutoSize = true;
            this.lblPaginaInicial.Location = new System.Drawing.Point(301, 9);
            this.lblPaginaInicial.Name = "lblPaginaInicial";
            this.lblPaginaInicial.Size = new System.Drawing.Size(70, 13);
            this.lblPaginaInicial.TabIndex = 45;
            this.lblPaginaInicial.Text = "Página Inicial";
            this.lblPaginaInicial.Click += new System.EventHandler(this.lblPaginaInicial_Click);
            // 
            // frmNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 436);
            this.Controls.Add(this.lblPaginaInicial);
            this.Controls.Add(this.lblSair);
            this.Controls.Add(this.grdNotas);
            this.Controls.Add(this.btnSalvar);
            this.Name = "frmNotas";
            this.Text = "frmNotas";
            ((System.ComponentModel.ISupportInitialize)(this.grdNotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView grdNotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota;
        private System.Windows.Forms.Label lblSair;
        private System.Windows.Forms.Label lblPaginaInicial;
    }
}