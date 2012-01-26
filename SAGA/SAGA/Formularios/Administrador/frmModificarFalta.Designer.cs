namespace SAGA.Formularios.Administrador
{
    partial class frmModificarFalta
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
            this.lblAluno = new System.Windows.Forms.Label();
            this.lblFalta = new System.Windows.Forms.Label();
            this.lblDisciplina = new System.Windows.Forms.Label();
            this.cbbDisciplina = new System.Windows.Forms.ComboBox();
            this.txtAluno = new System.Windows.Forms.TextBox();
            this.dgvFalta = new System.Windows.Forms.DataGridView();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblSair = new System.Windows.Forms.Label();
            this.lblPaginaInicial = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtdFalta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFalta)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAluno
            // 
            this.lblAluno.AutoSize = true;
            this.lblAluno.Location = new System.Drawing.Point(12, 40);
            this.lblAluno.Name = "lblAluno";
            this.lblAluno.Size = new System.Drawing.Size(34, 13);
            this.lblAluno.TabIndex = 0;
            this.lblAluno.Text = "Aluno";
            // 
            // lblFalta
            // 
            this.lblFalta.AutoSize = true;
            this.lblFalta.Location = new System.Drawing.Point(12, 122);
            this.lblFalta.Name = "lblFalta";
            this.lblFalta.Size = new System.Drawing.Size(30, 13);
            this.lblFalta.TabIndex = 1;
            this.lblFalta.Text = "Falta";
            // 
            // lblDisciplina
            // 
            this.lblDisciplina.AutoSize = true;
            this.lblDisciplina.Location = new System.Drawing.Point(12, 81);
            this.lblDisciplina.Name = "lblDisciplina";
            this.lblDisciplina.Size = new System.Drawing.Size(52, 13);
            this.lblDisciplina.TabIndex = 2;
            this.lblDisciplina.Text = "Disciplina";
            // 
            // cbbDisciplina
            // 
            this.cbbDisciplina.FormattingEnabled = true;
            this.cbbDisciplina.Location = new System.Drawing.Point(83, 78);
            this.cbbDisciplina.Name = "cbbDisciplina";
            this.cbbDisciplina.Size = new System.Drawing.Size(121, 21);
            this.cbbDisciplina.TabIndex = 5;
            this.cbbDisciplina.SelectedIndexChanged += new System.EventHandler(this.cbbDisciplina_SelectedIndexChanged);
            // 
            // txtAluno
            // 
            this.txtAluno.Location = new System.Drawing.Point(83, 37);
            this.txtAluno.Name = "txtAluno";
            this.txtAluno.Size = new System.Drawing.Size(177, 20);
            this.txtAluno.TabIndex = 6;
            this.txtAluno.TextChanged += new System.EventHandler(this.txtAluno_TextChanged);
            // 
            // dgvFalta
            // 
            this.dgvFalta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFalta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.data,
            this.qtdFalta});
            this.dgvFalta.Location = new System.Drawing.Point(15, 148);
            this.dgvFalta.Name = "dgvFalta";
            this.dgvFalta.Size = new System.Drawing.Size(276, 75);
            this.dgvFalta.TabIndex = 7;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(216, 112);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 8;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lblSair
            // 
            this.lblSair.AutoSize = true;
            this.lblSair.Location = new System.Drawing.Point(291, 9);
            this.lblSair.Name = "lblSair";
            this.lblSair.Size = new System.Drawing.Size(25, 13);
            this.lblSair.TabIndex = 41;
            this.lblSair.Text = "Sair";
            this.lblSair.Click += new System.EventHandler(this.lblSair_Click);
            // 
            // lblPaginaInicial
            // 
            this.lblPaginaInicial.AutoSize = true;
            this.lblPaginaInicial.Location = new System.Drawing.Point(215, 9);
            this.lblPaginaInicial.Name = "lblPaginaInicial";
            this.lblPaginaInicial.Size = new System.Drawing.Size(70, 13);
            this.lblPaginaInicial.TabIndex = 42;
            this.lblPaginaInicial.Text = "Página Inicial";
            this.lblPaginaInicial.Click += new System.EventHandler(this.lblPaginaInicial_Click);
            // 
            // data
            // 
            this.data.HeaderText = "Data";
            this.data.Name = "data";
            // 
            // qtdFalta
            // 
            this.qtdFalta.HeaderText = "Quantidade de Faltas";
            this.qtdFalta.Name = "qtdFalta";
            this.qtdFalta.Width = 131;
            // 
            // frmModificarFalta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 261);
            this.Controls.Add(this.lblPaginaInicial);
            this.Controls.Add(this.lblSair);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.dgvFalta);
            this.Controls.Add(this.txtAluno);
            this.Controls.Add(this.cbbDisciplina);
            this.Controls.Add(this.lblDisciplina);
            this.Controls.Add(this.lblFalta);
            this.Controls.Add(this.lblAluno);
            this.Name = "frmModificarFalta";
            this.Text = "Modificar Falta";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFalta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAluno;
        private System.Windows.Forms.Label lblFalta;
        private System.Windows.Forms.Label lblDisciplina;
        private System.Windows.Forms.ComboBox cbbDisciplina;
        private System.Windows.Forms.TextBox txtAluno;
        private System.Windows.Forms.DataGridView dgvFalta;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lblSair;
        private System.Windows.Forms.Label lblPaginaInicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdFalta;
    }
}