namespace SAGA.Formularios.Operacoes_Genericas
{
    partial class frmAvisos
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
            this.ckblTurmas = new System.Windows.Forms.CheckedListBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lblDataFInal = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblDataInicial = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtAviso = new System.Windows.Forms.TextBox();
            this.lblAviso = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ckblTurmas
            // 
            this.ckblTurmas.FormattingEnabled = true;
            this.ckblTurmas.Location = new System.Drawing.Point(15, 311);
            this.ckblTurmas.Name = "ckblTurmas";
            this.ckblTurmas.Size = new System.Drawing.Size(342, 139);
            this.ckblTurmas.TabIndex = 15;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(78, 278);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 14;
            this.dateTimePicker2.Value = new System.DateTime(2011, 12, 16, 22, 5, 33, 0);
            // 
            // lblDataFInal
            // 
            this.lblDataFInal.AutoSize = true;
            this.lblDataFInal.Location = new System.Drawing.Point(12, 284);
            this.lblDataFInal.Name = "lblDataFInal";
            this.lblDataFInal.Size = new System.Drawing.Size(55, 13);
            this.lblDataFInal.TabIndex = 13;
            this.lblDataFInal.Text = "Data Final";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(78, 252);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // lblDataInicial
            // 
            this.lblDataInicial.AutoSize = true;
            this.lblDataInicial.Location = new System.Drawing.Point(12, 258);
            this.lblDataInicial.Name = "lblDataInicial";
            this.lblDataInicial.Size = new System.Drawing.Size(60, 13);
            this.lblDataInicial.TabIndex = 11;
            this.lblDataInicial.Text = "Data Inicial";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(313, 4);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 10;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            // 
            // txtAviso
            // 
            this.txtAviso.Location = new System.Drawing.Point(15, 33);
            this.txtAviso.MaxLength = 1024;
            this.txtAviso.Multiline = true;
            this.txtAviso.Name = "txtAviso";
            this.txtAviso.Size = new System.Drawing.Size(373, 199);
            this.txtAviso.TabIndex = 9;
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.Location = new System.Drawing.Point(12, 9);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(33, 13);
            this.lblAviso.TabIndex = 8;
            this.lblAviso.Text = "Aviso";
            // 
            // frmAvisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 460);
            this.Controls.Add(this.ckblTurmas);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.lblDataFInal);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblDataInicial);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtAviso);
            this.Controls.Add(this.lblAviso);
            this.Name = "frmAvisos";
            this.Text = "frmAvisos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox ckblTurmas;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label lblDataFInal;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblDataInicial;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox txtAviso;
        private System.Windows.Forms.Label lblAviso;

    }
}