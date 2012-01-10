namespace SAGA.Formularios.Alunos
{
    partial class frmHorarios
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Horario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.segundaFeira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tercaFeira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quartaFeira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quintaFeira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sextaFeira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSair = new System.Windows.Forms.Label();
            this.lblPaginaInicial = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Horario,
            this.segundaFeira,
            this.tercaFeira,
            this.quartaFeira,
            this.quintaFeira,
            this.sextaFeira});
            this.dataGridView1.Location = new System.Drawing.Point(12, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(644, 323);
            this.dataGridView1.TabIndex = 0;
            // 
            // Horario
            // 
            this.Horario.HeaderText = "Horário";
            this.Horario.Name = "Horario";
            this.Horario.ReadOnly = true;
            // 
            // segundaFeira
            // 
            this.segundaFeira.HeaderText = "2ª Feira";
            this.segundaFeira.Name = "segundaFeira";
            this.segundaFeira.ReadOnly = true;
            // 
            // tercaFeira
            // 
            this.tercaFeira.HeaderText = "3ª Feira";
            this.tercaFeira.Name = "tercaFeira";
            this.tercaFeira.ReadOnly = true;
            // 
            // quartaFeira
            // 
            this.quartaFeira.HeaderText = "4ª Feira";
            this.quartaFeira.Name = "quartaFeira";
            this.quartaFeira.ReadOnly = true;
            // 
            // quintaFeira
            // 
            this.quintaFeira.HeaderText = "5ª Feira";
            this.quintaFeira.Name = "quintaFeira";
            this.quintaFeira.ReadOnly = true;
            // 
            // sextaFeira
            // 
            this.sextaFeira.HeaderText = "6ª Feira";
            this.sextaFeira.Name = "sextaFeira";
            this.sextaFeira.ReadOnly = true;
            // 
            // lblSair
            // 
            this.lblSair.AutoSize = true;
            this.lblSair.Location = new System.Drawing.Point(634, 9);
            this.lblSair.Name = "lblSair";
            this.lblSair.Size = new System.Drawing.Size(25, 13);
            this.lblSair.TabIndex = 40;
            this.lblSair.Text = "Sair";
            this.lblSair.Click += new System.EventHandler(this.lblSair_Click);
            // 
            // lblPaginaInicial
            // 
            this.lblPaginaInicial.AutoSize = true;
            this.lblPaginaInicial.Location = new System.Drawing.Point(558, 9);
            this.lblPaginaInicial.Name = "lblPaginaInicial";
            this.lblPaginaInicial.Size = new System.Drawing.Size(70, 13);
            this.lblPaginaInicial.TabIndex = 44;
            this.lblPaginaInicial.Text = "Página Inicial";
            this.lblPaginaInicial.Click += new System.EventHandler(this.lblPaginaInicial_Click);
            // 
            // frmHorarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 384);
            this.Controls.Add(this.lblPaginaInicial);
            this.Controls.Add(this.lblSair);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmHorarios";
            this.Text = "Horarios de Aula";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horario;
        private System.Windows.Forms.DataGridViewTextBoxColumn segundaFeira;
        private System.Windows.Forms.DataGridViewTextBoxColumn tercaFeira;
        private System.Windows.Forms.DataGridViewTextBoxColumn quartaFeira;
        private System.Windows.Forms.DataGridViewTextBoxColumn quintaFeira;
        private System.Windows.Forms.DataGridViewTextBoxColumn sextaFeira;
        private System.Windows.Forms.Label lblSair;
        private System.Windows.Forms.Label lblPaginaInicial;
    }
}