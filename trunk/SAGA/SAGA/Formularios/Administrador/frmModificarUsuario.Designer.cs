namespace SAGA.Formularios.Administrador
{
    partial class frmModificarUsuario
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
            this.txtSenha2 = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.cbbTipo = new System.Windows.Forms.ComboBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblComparacao = new System.Windows.Forms.Label();
            this.lblSair = new System.Windows.Forms.Label();
            this.lblPaginaInicial = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSenha2
            // 
            this.txtSenha2.Location = new System.Drawing.Point(114, 175);
            this.txtSenha2.Name = "txtSenha2";
            this.txtSenha2.Size = new System.Drawing.Size(121, 20);
            this.txtSenha2.TabIndex = 15;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(114, 138);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(121, 20);
            this.txtSenha.TabIndex = 14;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(114, 95);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(154, 20);
            this.txtNome.TabIndex = 13;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(114, 220);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 12;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // cbbTipo
            // 
            this.cbbTipo.FormattingEnabled = true;
            this.cbbTipo.Location = new System.Drawing.Point(114, 50);
            this.cbbTipo.Name = "cbbTipo";
            this.cbbTipo.Size = new System.Drawing.Size(121, 21);
            this.cbbTipo.TabIndex = 11;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(16, 138);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(38, 13);
            this.lblSenha.TabIndex = 10;
            this.lblSenha.Text = "Senha";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(16, 95);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 9;
            this.lblNome.Text = "Nome";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(16, 53);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(82, 13);
            this.lblTipo.TabIndex = 8;
            this.lblTipo.Text = "Tipo de Usuário";
            // 
            // lblComparacao
            // 
            this.lblComparacao.AutoSize = true;
            this.lblComparacao.Location = new System.Drawing.Point(111, 161);
            this.lblComparacao.Name = "lblComparacao";
            this.lblComparacao.Size = new System.Drawing.Size(0, 13);
            this.lblComparacao.TabIndex = 16;
            // 
            // lblSair
            // 
            this.lblSair.AutoSize = true;
            this.lblSair.Location = new System.Drawing.Point(247, 9);
            this.lblSair.Name = "lblSair";
            this.lblSair.Size = new System.Drawing.Size(25, 13);
            this.lblSair.TabIndex = 40;
            this.lblSair.Text = "Sair";
            this.lblSair.Click += new System.EventHandler(this.lblSair_Click);
            // 
            // lblPaginaInicial
            // 
            this.lblPaginaInicial.AutoSize = true;
            this.lblPaginaInicial.Location = new System.Drawing.Point(171, 9);
            this.lblPaginaInicial.Name = "lblPaginaInicial";
            this.lblPaginaInicial.Size = new System.Drawing.Size(70, 13);
            this.lblPaginaInicial.TabIndex = 41;
            this.lblPaginaInicial.Text = "Página Inicial";
            this.lblPaginaInicial.Click += new System.EventHandler(this.lblPaginaInicial_Click);
            // 
            // frmModificarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblPaginaInicial);
            this.Controls.Add(this.lblSair);
            this.Controls.Add(this.lblComparacao);
            this.Controls.Add(this.txtSenha2);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.cbbTipo);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblTipo);
            this.Name = "frmModificarUsuario";
            this.Text = "Modificar Usuário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSenha2;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.ComboBox cbbTipo;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblComparacao;
        private System.Windows.Forms.Label lblSair;
        private System.Windows.Forms.Label lblPaginaInicial;

    }
}