namespace SAGA.Formularios.Professores
{
    partial class frmJustificarFalta
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
            this.lsvAlunos = new System.Windows.Forms.ListView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblData = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblJustificativa = new System.Windows.Forms.Label();
            this.btnJustificar = new System.Windows.Forms.Button();
            this.lblSair = new System.Windows.Forms.Label();
            this.lblPaginaInicial = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lsvAlunos
            // 
            this.lsvAlunos.Location = new System.Drawing.Point(12, 44);
            this.lsvAlunos.Name = "lsvAlunos";
            this.lsvAlunos.Size = new System.Drawing.Size(172, 334);
            this.lsvAlunos.TabIndex = 0;
            this.lsvAlunos.UseCompatibleStateImageBehavior = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(267, 54);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(190, 60);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(71, 13);
            this.lblData.TabIndex = 2;
            this.lblData.Text = "Data da Falta";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(193, 107);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(274, 221);
            this.textBox1.TabIndex = 3;
            // 
            // lblJustificativa
            // 
            this.lblJustificativa.AutoSize = true;
            this.lblJustificativa.Location = new System.Drawing.Point(190, 91);
            this.lblJustificativa.Name = "lblJustificativa";
            this.lblJustificativa.Size = new System.Drawing.Size(62, 13);
            this.lblJustificativa.TabIndex = 4;
            this.lblJustificativa.Text = "Justificativa";
            // 
            // btnJustificar
            // 
            this.btnJustificar.Location = new System.Drawing.Point(392, 355);
            this.btnJustificar.Name = "btnJustificar";
            this.btnJustificar.Size = new System.Drawing.Size(75, 23);
            this.btnJustificar.TabIndex = 5;
            this.btnJustificar.Text = "Justificar";
            this.btnJustificar.UseVisualStyleBackColor = true;
            // 
            // lblSair
            // 
            this.lblSair.AutoSize = true;
            this.lblSair.Location = new System.Drawing.Point(443, 9);
            this.lblSair.Name = "lblSair";
            this.lblSair.Size = new System.Drawing.Size(25, 13);
            this.lblSair.TabIndex = 42;
            this.lblSair.Text = "Sair";
            this.lblSair.Click += new System.EventHandler(this.lblSair_Click);
            // 
            // lblPaginaInicial
            // 
            this.lblPaginaInicial.AutoSize = true;
            this.lblPaginaInicial.Location = new System.Drawing.Point(367, 9);
            this.lblPaginaInicial.Name = "lblPaginaInicial";
            this.lblPaginaInicial.Size = new System.Drawing.Size(70, 13);
            this.lblPaginaInicial.TabIndex = 45;
            this.lblPaginaInicial.Text = "Página Inicial";
            this.lblPaginaInicial.Click += new System.EventHandler(this.lblPaginaInicial_Click);
            // 
            // frmJustificarFalta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 387);
            this.Controls.Add(this.lblPaginaInicial);
            this.Controls.Add(this.lblSair);
            this.Controls.Add(this.btnJustificar);
            this.Controls.Add(this.lblJustificativa);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lsvAlunos);
            this.Name = "frmJustificarFalta";
            this.Text = "frmJustificarFalta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvAlunos;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblJustificativa;
        private System.Windows.Forms.Button btnJustificar;
        private System.Windows.Forms.Label lblSair;
        private System.Windows.Forms.Label lblPaginaInicial;
    }
}