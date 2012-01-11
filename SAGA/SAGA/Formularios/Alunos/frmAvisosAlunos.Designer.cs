namespace SAGA.Formularios.Alunos
{
    partial class frmAvisosAlunos
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
            this.txtAviso = new System.Windows.Forms.TextBox();
            this.lsvAviso = new System.Windows.Forms.ListView();
            this.lblSair = new System.Windows.Forms.Label();
            this.lblPaginaInicial = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAviso
            // 
            this.txtAviso.Enabled = false;
            this.txtAviso.Location = new System.Drawing.Point(242, 35);
            this.txtAviso.Multiline = true;
            this.txtAviso.Name = "txtAviso";
            this.txtAviso.Size = new System.Drawing.Size(494, 419);
            this.txtAviso.TabIndex = 1;
            // 
            // lsvAviso
            // 
            this.lsvAviso.Location = new System.Drawing.Point(12, 35);
            this.lsvAviso.Name = "lsvAviso";
            this.lsvAviso.Size = new System.Drawing.Size(224, 419);
            this.lsvAviso.TabIndex = 2;
            this.lsvAviso.UseCompatibleStateImageBehavior = false;
            // 
            // lblSair
            // 
            this.lblSair.AutoSize = true;
            this.lblSair.Location = new System.Drawing.Point(711, 9);
            this.lblSair.Name = "lblSair";
            this.lblSair.Size = new System.Drawing.Size(25, 13);
            this.lblSair.TabIndex = 40;
            this.lblSair.Text = "Sair";
            this.lblSair.Click += new System.EventHandler(this.lblSair_Click);
            // 
            // lblPaginaInicial
            // 
            this.lblPaginaInicial.AutoSize = true;
            this.lblPaginaInicial.Location = new System.Drawing.Point(635, 9);
            this.lblPaginaInicial.Name = "lblPaginaInicial";
            this.lblPaginaInicial.Size = new System.Drawing.Size(70, 13);
            this.lblPaginaInicial.TabIndex = 44;
            this.lblPaginaInicial.Text = "Página Inicial";
            this.lblPaginaInicial.Click += new System.EventHandler(this.lblPaginaInicial_Click);
            // 
            // frmAvisosAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 467);
            this.Controls.Add(this.lblPaginaInicial);
            this.Controls.Add(this.lblSair);
            this.Controls.Add(this.lsvAviso);
            this.Controls.Add(this.txtAviso);
            this.Name = "frmAvisosAlunos";
            this.Text = "Avisos";
            this.Load += new System.EventHandler(this.frmAvisosAlunos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAviso;
        private System.Windows.Forms.ListView lsvAviso;
        private System.Windows.Forms.Label lblSair;
        private System.Windows.Forms.Label lblPaginaInicial;
    }
}