namespace SAGA.Formularios.Alunos
{
    partial class frmInicialAlunos
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
            this.lblAvisos = new System.Windows.Forms.Label();
            this.lblDuvidas = new System.Windows.Forms.Label();
            this.lblBoletim = new System.Windows.Forms.Label();
            this.lblModificarSenha = new System.Windows.Forms.Label();
            this.lblHorarios = new System.Windows.Forms.Label();
            this.lblSair = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAvisos
            // 
            this.lblAvisos.AutoSize = true;
            this.lblAvisos.Location = new System.Drawing.Point(12, 153);
            this.lblAvisos.Name = "lblAvisos";
            this.lblAvisos.Size = new System.Drawing.Size(38, 13);
            this.lblAvisos.TabIndex = 5;
            this.lblAvisos.Text = "Avisos";
            this.lblAvisos.Click += new System.EventHandler(this.lblAvisos_Click);
            // 
            // lblDuvidas
            // 
            this.lblDuvidas.AutoSize = true;
            this.lblDuvidas.Location = new System.Drawing.Point(12, 114);
            this.lblDuvidas.Name = "lblDuvidas";
            this.lblDuvidas.Size = new System.Drawing.Size(46, 13);
            this.lblDuvidas.TabIndex = 4;
            this.lblDuvidas.Text = "Dúvidas";
            this.lblDuvidas.Click += new System.EventHandler(this.lblDuvidas_Click);
            // 
            // lblBoletim
            // 
            this.lblBoletim.AutoSize = true;
            this.lblBoletim.Location = new System.Drawing.Point(12, 45);
            this.lblBoletim.Name = "lblBoletim";
            this.lblBoletim.Size = new System.Drawing.Size(41, 13);
            this.lblBoletim.TabIndex = 3;
            this.lblBoletim.Text = "Boletim";
            this.lblBoletim.Click += new System.EventHandler(this.lblBoletim_Click);
            // 
            // lblModificarSenha
            // 
            this.lblModificarSenha.AutoSize = true;
            this.lblModificarSenha.Location = new System.Drawing.Point(12, 191);
            this.lblModificarSenha.Name = "lblModificarSenha";
            this.lblModificarSenha.Size = new System.Drawing.Size(84, 13);
            this.lblModificarSenha.TabIndex = 6;
            this.lblModificarSenha.Text = "Modificar Senha";
            this.lblModificarSenha.Click += new System.EventHandler(this.lblModificarSenha_Click);
            // 
            // lblHorarios
            // 
            this.lblHorarios.AutoSize = true;
            this.lblHorarios.Location = new System.Drawing.Point(12, 82);
            this.lblHorarios.Name = "lblHorarios";
            this.lblHorarios.Size = new System.Drawing.Size(85, 13);
            this.lblHorarios.TabIndex = 7;
            this.lblHorarios.Text = "Horarios de Aula";
            this.lblHorarios.Click += new System.EventHandler(this.lblHorarios_Click);
            // 
            // lblSair
            // 
            this.lblSair.AutoSize = true;
            this.lblSair.Location = new System.Drawing.Point(79, 9);
            this.lblSair.Name = "lblSair";
            this.lblSair.Size = new System.Drawing.Size(25, 13);
            this.lblSair.TabIndex = 40;
            this.lblSair.Text = "Sair";
            this.lblSair.Click += new System.EventHandler(this.lblSair_Click);
            // 
            // frmInicialAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(116, 212);
            this.Controls.Add(this.lblSair);
            this.Controls.Add(this.lblHorarios);
            this.Controls.Add(this.lblModificarSenha);
            this.Controls.Add(this.lblAvisos);
            this.Controls.Add(this.lblDuvidas);
            this.Controls.Add(this.lblBoletim);
            this.Name = "frmInicialAlunos";
            this.Text = "frmInicialAlunos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAvisos;
        private System.Windows.Forms.Label lblDuvidas;
        private System.Windows.Forms.Label lblBoletim;
        private System.Windows.Forms.Label lblModificarSenha;
        private System.Windows.Forms.Label lblHorarios;
        private System.Windows.Forms.Label lblSair;
    }
}