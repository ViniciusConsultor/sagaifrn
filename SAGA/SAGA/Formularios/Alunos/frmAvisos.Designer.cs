namespace SAGA.Formularios.Alunos
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
            this.txtAviso = new System.Windows.Forms.TextBox();
            this.lsvAviso = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // txtAviso
            // 
            this.txtAviso.Enabled = false;
            this.txtAviso.Location = new System.Drawing.Point(242, 12);
            this.txtAviso.Multiline = true;
            this.txtAviso.Name = "txtAviso";
            this.txtAviso.Size = new System.Drawing.Size(494, 419);
            this.txtAviso.TabIndex = 1;
            // 
            // lsvAviso
            // 
            this.lsvAviso.Location = new System.Drawing.Point(12, 12);
            this.lsvAviso.Name = "lsvAviso";
            this.lsvAviso.Size = new System.Drawing.Size(224, 419);
            this.lsvAviso.TabIndex = 2;
            this.lsvAviso.UseCompatibleStateImageBehavior = false;
            // 
            // frmAvisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 443);
            this.Controls.Add(this.lsvAviso);
            this.Controls.Add(this.txtAviso);
            this.Name = "frmAvisos";
            this.Text = "Avisos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAviso;
        private System.Windows.Forms.ListView lsvAviso;
    }
}