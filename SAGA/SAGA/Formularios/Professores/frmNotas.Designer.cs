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
            ((System.ComponentModel.ISupportInitialize)(this.grdNotas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(313, 372);
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
            this.grdNotas.Location = new System.Drawing.Point(12, 28);
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
            // frmNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 412);
            this.Controls.Add(this.grdNotas);
            this.Controls.Add(this.btnSalvar);
            this.Name = "frmNotas";
            this.Text = "frmNotas";
            ((System.ComponentModel.ISupportInitialize)(this.grdNotas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView grdNotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota;
    }
}