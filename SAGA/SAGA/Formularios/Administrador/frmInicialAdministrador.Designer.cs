namespace SAGA.Formularios.Administrador
{
    partial class frmInicialAdministrador
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
            this.lblAddUsuario = new System.Windows.Forms.Label();
            this.lblAvisos = new System.Windows.Forms.Label();
            this.lblModificarUsuario = new System.Windows.Forms.Label();
            this.lblModificarNota = new System.Windows.Forms.Label();
            this.lblEditarFalta = new System.Windows.Forms.Label();
            this.lblModificarSenha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAddUsuario
            // 
            this.lblAddUsuario.AutoSize = true;
            this.lblAddUsuario.Location = new System.Drawing.Point(12, 21);
            this.lblAddUsuario.Name = "lblAddUsuario";
            this.lblAddUsuario.Size = new System.Drawing.Size(90, 13);
            this.lblAddUsuario.TabIndex = 0;
            this.lblAddUsuario.Text = "Adicionar Usuário";
            // 
            // lblAvisos
            // 
            this.lblAvisos.AutoSize = true;
            this.lblAvisos.Location = new System.Drawing.Point(12, 153);
            this.lblAvisos.Name = "lblAvisos";
            this.lblAvisos.Size = new System.Drawing.Size(38, 13);
            this.lblAvisos.TabIndex = 1;
            this.lblAvisos.Text = "Avisos";
            // 
            // lblModificarUsuario
            // 
            this.lblModificarUsuario.AutoSize = true;
            this.lblModificarUsuario.Location = new System.Drawing.Point(12, 54);
            this.lblModificarUsuario.Name = "lblModificarUsuario";
            this.lblModificarUsuario.Size = new System.Drawing.Size(89, 13);
            this.lblModificarUsuario.TabIndex = 2;
            this.lblModificarUsuario.Text = "Modificar Usuário";
            // 
            // lblModificarNota
            // 
            this.lblModificarNota.AutoSize = true;
            this.lblModificarNota.Location = new System.Drawing.Point(12, 87);
            this.lblModificarNota.Name = "lblModificarNota";
            this.lblModificarNota.Size = new System.Drawing.Size(76, 13);
            this.lblModificarNota.TabIndex = 3;
            this.lblModificarNota.Text = "Modificar Nota";
            // 
            // lblEditarFalta
            // 
            this.lblEditarFalta.AutoSize = true;
            this.lblEditarFalta.Location = new System.Drawing.Point(12, 120);
            this.lblEditarFalta.Name = "lblEditarFalta";
            this.lblEditarFalta.Size = new System.Drawing.Size(60, 13);
            this.lblEditarFalta.TabIndex = 5;
            this.lblEditarFalta.Text = "Editar Falta";
            // 
            // lblModificarSenha
            // 
            this.lblModificarSenha.AutoSize = true;
            this.lblModificarSenha.Location = new System.Drawing.Point(12, 184);
            this.lblModificarSenha.Name = "lblModificarSenha";
            this.lblModificarSenha.Size = new System.Drawing.Size(84, 13);
            this.lblModificarSenha.TabIndex = 6;
            this.lblModificarSenha.Text = "Modificar Senha";
            // 
            // frmInicialAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(116, 205);
            this.Controls.Add(this.lblModificarSenha);
            this.Controls.Add(this.lblEditarFalta);
            this.Controls.Add(this.lblModificarNota);
            this.Controls.Add(this.lblModificarUsuario);
            this.Controls.Add(this.lblAvisos);
            this.Controls.Add(this.lblAddUsuario);
            this.Name = "frmInicialAdministrador";
            this.Text = "início";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddUsuario;
        private System.Windows.Forms.Label lblAvisos;
        private System.Windows.Forms.Label lblModificarUsuario;
        private System.Windows.Forms.Label lblModificarNota;
        private System.Windows.Forms.Label lblEditarFalta;
        private System.Windows.Forms.Label lblModificarSenha;
    }
}