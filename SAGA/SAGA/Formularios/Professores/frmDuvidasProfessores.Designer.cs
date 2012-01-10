namespace SAGA.Formularios.Professores
{
    partial class frmDuvidasProfessores
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
            this.btnPergunta = new System.Windows.Forms.Label();
            this.btnResponder = new System.Windows.Forms.Button();
            this.txtResposta = new System.Windows.Forms.TextBox();
            this.lblResposta = new System.Windows.Forms.Label();
            this.lsvDuvida = new System.Windows.Forms.ListView();
            this.txtPergunta = new System.Windows.Forms.TextBox();
            this.lblSair = new System.Windows.Forms.Label();
            this.lblPaginaInicial = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPergunta
            // 
            this.btnPergunta.AutoSize = true;
            this.btnPergunta.Location = new System.Drawing.Point(460, 44);
            this.btnPergunta.Name = "btnPergunta";
            this.btnPergunta.Size = new System.Drawing.Size(50, 13);
            this.btnPergunta.TabIndex = 19;
            this.btnPergunta.Text = "Pergunta";
            // 
            // btnResponder
            // 
            this.btnResponder.Location = new System.Drawing.Point(685, 455);
            this.btnResponder.Name = "btnResponder";
            this.btnResponder.Size = new System.Drawing.Size(75, 23);
            this.btnResponder.TabIndex = 18;
            this.btnResponder.Text = "Responder";
            this.btnResponder.UseVisualStyleBackColor = true;
            // 
            // txtResposta
            // 
            this.txtResposta.Location = new System.Drawing.Point(224, 221);
            this.txtResposta.Multiline = true;
            this.txtResposta.Name = "txtResposta";
            this.txtResposta.Size = new System.Drawing.Size(536, 228);
            this.txtResposta.TabIndex = 17;
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.Location = new System.Drawing.Point(460, 205);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(52, 13);
            this.lblResposta.TabIndex = 16;
            this.lblResposta.Text = "Resposta";
            // 
            // lsvDuvida
            // 
            this.lsvDuvida.Location = new System.Drawing.Point(12, 44);
            this.lsvDuvida.Name = "lsvDuvida";
            this.lsvDuvida.Size = new System.Drawing.Size(206, 434);
            this.lsvDuvida.TabIndex = 15;
            this.lsvDuvida.UseCompatibleStateImageBehavior = false;
            // 
            // txtPergunta
            // 
            this.txtPergunta.Enabled = false;
            this.txtPergunta.Location = new System.Drawing.Point(224, 60);
            this.txtPergunta.Multiline = true;
            this.txtPergunta.Name = "txtPergunta";
            this.txtPergunta.Size = new System.Drawing.Size(536, 142);
            this.txtPergunta.TabIndex = 14;
            // 
            // lblSair
            // 
            this.lblSair.AutoSize = true;
            this.lblSair.Location = new System.Drawing.Point(738, 9);
            this.lblSair.Name = "lblSair";
            this.lblSair.Size = new System.Drawing.Size(25, 13);
            this.lblSair.TabIndex = 42;
            this.lblSair.Text = "Sair";
            this.lblSair.Click += new System.EventHandler(this.lblSair_Click);
            // 
            // lblPaginaInicial
            // 
            this.lblPaginaInicial.AutoSize = true;
            this.lblPaginaInicial.Location = new System.Drawing.Point(662, 9);
            this.lblPaginaInicial.Name = "lblPaginaInicial";
            this.lblPaginaInicial.Size = new System.Drawing.Size(70, 13);
            this.lblPaginaInicial.TabIndex = 45;
            this.lblPaginaInicial.Text = "Página Inicial";
            this.lblPaginaInicial.Click += new System.EventHandler(this.lblPaginaInicial_Click);
            // 
            // frmDuvidasProfessores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 489);
            this.Controls.Add(this.lblPaginaInicial);
            this.Controls.Add(this.lblSair);
            this.Controls.Add(this.btnPergunta);
            this.Controls.Add(this.btnResponder);
            this.Controls.Add(this.txtResposta);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.lsvDuvida);
            this.Controls.Add(this.txtPergunta);
            this.Name = "frmDuvidasProfessores";
            this.Text = "frmDuvidasProfessores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label btnPergunta;
        private System.Windows.Forms.Button btnResponder;
        private System.Windows.Forms.TextBox txtResposta;
        private System.Windows.Forms.Label lblResposta;
        private System.Windows.Forms.ListView lsvDuvida;
        private System.Windows.Forms.TextBox txtPergunta;
        private System.Windows.Forms.Label lblSair;
        private System.Windows.Forms.Label lblPaginaInicial;
    }
}