namespace SAGA.Formularios.Professores
{
    partial class frmInicialProfessores
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
            this.lblChamada = new System.Windows.Forms.Label();
            this.lblNotas = new System.Windows.Forms.Label();
            this.lblDuvidas = new System.Windows.Forms.Label();
            this.lblAvisos = new System.Windows.Forms.Label();
            this.lblModificarSenha = new System.Windows.Forms.Label();
            this.lblJustificarFalta = new System.Windows.Forms.Label();
            this.lblSair = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblChamada
            // 
            this.lblChamada.AutoSize = true;
            this.lblChamada.Location = new System.Drawing.Point(12, 44);
            this.lblChamada.Name = "lblChamada";
            this.lblChamada.Size = new System.Drawing.Size(52, 13);
            this.lblChamada.TabIndex = 0;
            this.lblChamada.Text = "Chamada";
            this.lblChamada.Click += new System.EventHandler(this.lblChamada_Click);
            // 
            // lblNotas
            // 
            this.lblNotas.AutoSize = true;
            this.lblNotas.Location = new System.Drawing.Point(12, 80);
            this.lblNotas.Name = "lblNotas";
            this.lblNotas.Size = new System.Drawing.Size(35, 13);
            this.lblNotas.TabIndex = 1;
            this.lblNotas.Text = "Notas";
            this.lblNotas.Click += new System.EventHandler(this.lblNotas_Click);
            // 
            // lblDuvidas
            // 
            this.lblDuvidas.AutoSize = true;
            this.lblDuvidas.Location = new System.Drawing.Point(12, 120);
            this.lblDuvidas.Name = "lblDuvidas";
            this.lblDuvidas.Size = new System.Drawing.Size(46, 13);
            this.lblDuvidas.TabIndex = 2;
            this.lblDuvidas.Text = "Dúvidas";
            this.lblDuvidas.Click += new System.EventHandler(this.lblDuvidas_Click);
            // 
            // lblAvisos
            // 
            this.lblAvisos.AutoSize = true;
            this.lblAvisos.Location = new System.Drawing.Point(12, 160);
            this.lblAvisos.Name = "lblAvisos";
            this.lblAvisos.Size = new System.Drawing.Size(38, 13);
            this.lblAvisos.TabIndex = 3;
            this.lblAvisos.Text = "Avisos";
            this.lblAvisos.Click += new System.EventHandler(this.lblAvisos_Click);
            // 
            // lblModificarSenha
            // 
            this.lblModificarSenha.AutoSize = true;
            this.lblModificarSenha.Location = new System.Drawing.Point(12, 233);
            this.lblModificarSenha.Name = "lblModificarSenha";
            this.lblModificarSenha.Size = new System.Drawing.Size(84, 13);
            this.lblModificarSenha.TabIndex = 5;
            this.lblModificarSenha.Text = "Modificar Senha";
            this.lblModificarSenha.Click += new System.EventHandler(this.lblModificarSenha_Click);
            // 
            // lblJustificarFalta
            // 
            this.lblJustificarFalta.AutoSize = true;
            this.lblJustificarFalta.Location = new System.Drawing.Point(12, 196);
            this.lblJustificarFalta.Name = "lblJustificarFalta";
            this.lblJustificarFalta.Size = new System.Drawing.Size(74, 13);
            this.lblJustificarFalta.TabIndex = 4;
            this.lblJustificarFalta.Text = "Justificar Falta";
            this.lblJustificarFalta.Click += new System.EventHandler(this.lblJustificarFalta_Click);
            // 
            // lblSair
            // 
            this.lblSair.AutoSize = true;
            this.lblSair.Location = new System.Drawing.Point(79, 9);
            this.lblSair.Name = "lblSair";
            this.lblSair.Size = new System.Drawing.Size(25, 13);
            this.lblSair.TabIndex = 42;
            this.lblSair.Text = "Sair";
            this.lblSair.Click += new System.EventHandler(this.lblSair_Click);
            // 
            // frmInicialProfessores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(116, 264);
            this.Controls.Add(this.lblSair);
            this.Controls.Add(this.lblModificarSenha);
            this.Controls.Add(this.lblJustificarFalta);
            this.Controls.Add(this.lblAvisos);
            this.Controls.Add(this.lblDuvidas);
            this.Controls.Add(this.lblNotas);
            this.Controls.Add(this.lblChamada);
            this.Name = "frmInicialProfessores";
            this.Text = "Início";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChamada;
        private System.Windows.Forms.Label lblNotas;
        private System.Windows.Forms.Label lblDuvidas;
        private System.Windows.Forms.Label lblAvisos;
        private System.Windows.Forms.Label lblModificarSenha;
        private System.Windows.Forms.Label lblJustificarFalta;
        private System.Windows.Forms.Label lblSair;
    }
}