namespace SAGA.Formularios.Professores
{
    partial class frmChamada
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.lblTurma = new System.Windows.Forms.Label();
            this.grdChamada = new System.Windows.Forms.DataGridView();
            this.lblData = new System.Windows.Forms.Label();
            this.Alunos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Faltas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.grdChamada)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(69, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(504, 33);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 1;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            // 
            // lblTurma
            // 
            this.lblTurma.AutoSize = true;
            this.lblTurma.Location = new System.Drawing.Point(12, 38);
            this.lblTurma.Name = "lblTurma";
            this.lblTurma.Size = new System.Drawing.Size(37, 13);
            this.lblTurma.TabIndex = 2;
            this.lblTurma.Text = "Turma";
            // 
            // grdChamada
            // 
            this.grdChamada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdChamada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Alunos,
            this.Faltas});
            this.grdChamada.Location = new System.Drawing.Point(15, 78);
            this.grdChamada.Name = "grdChamada";
            this.grdChamada.Size = new System.Drawing.Size(564, 326);
            this.grdChamada.TabIndex = 4;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(229, 41);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(30, 13);
            this.lblData.TabIndex = 5;
            this.lblData.Text = "Data";
            // 
            // Alunos
            // 
            this.Alunos.HeaderText = "Alunos";
            this.Alunos.Name = "Alunos";
            // 
            // Faltas
            // 
            this.Faltas.HeaderText = "Faltas";
            this.Faltas.Name = "Faltas";
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(265, 35);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(200, 20);
            this.dtpData.TabIndex = 6;
            // 
            // frmChamada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 424);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.grdChamada);
            this.Controls.Add(this.lblTurma);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.comboBox1);
            this.Name = "frmChamada";
            this.Text = "frmChamada";
            ((System.ComponentModel.ISupportInitialize)(this.grdChamada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label lblTurma;
        private System.Windows.Forms.DataGridView grdChamada;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alunos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Faltas;
        private System.Windows.Forms.DateTimePicker dtpData;
    }
}