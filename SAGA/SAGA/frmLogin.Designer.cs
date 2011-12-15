namespace SAGA
{
    partial class frmLogin
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
            this.lblLogIn = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.lblAvisos = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblLogIn
            // 
            this.lblLogIn.AutoSize = true;
            this.lblLogIn.Location = new System.Drawing.Point(31, 34);
            this.lblLogIn.Name = "lblLogIn";
            this.lblLogIn.Size = new System.Drawing.Size(34, 13);
            this.lblLogIn.TabIndex = 0;
            this.lblLogIn.Text = "LogIn";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(85, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 20);
            this.textBox1.TabIndex = 1;
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(155, 116);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(75, 23);
            this.btnEntrar.TabIndex = 2;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // lblAvisos
            // 
            this.lblAvisos.AutoSize = true;
            this.lblAvisos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvisos.ForeColor = System.Drawing.Color.Red;
            this.lblAvisos.Location = new System.Drawing.Point(191, 15);
            this.lblAvisos.Name = "lblAvisos";
            this.lblAvisos.Size = new System.Drawing.Size(0, 13);
            this.lblAvisos.TabIndex = 3;
            this.lblAvisos.Visible = false;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(31, 70);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(38, 13);
            this.lblSenha.TabIndex = 4;
            this.lblSenha.Text = "Senha";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(85, 67);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '●';
            this.textBox2.Size = new System.Drawing.Size(250, 20);
            this.textBox2.TabIndex = 5;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 200);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblAvisos);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblLogIn);
            this.Name = "frmLogin";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogIn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Label lblAvisos;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox textBox2;
    }
}

