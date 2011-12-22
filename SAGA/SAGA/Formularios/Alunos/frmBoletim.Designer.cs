namespace SAGA.Formularios.Alunos
{
    partial class frmBoletim
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
            this.grdBoletim = new System.Windows.Forms.DataGridView();
            this.materias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.primeiroBimestre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faltas1ºBimestre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.segundoBimestre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faltas2ºBimestre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.terceroBimestre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faltas3ºBimestre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quartoBimestre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faltas4ºBimestre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdBoletim)).BeginInit();
            this.SuspendLayout();
            // 
            // grdBoletim
            // 
            this.grdBoletim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBoletim.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.materias,
            this.primeiroBimestre,
            this.faltas1ºBimestre,
            this.segundoBimestre,
            this.faltas2ºBimestre,
            this.terceroBimestre,
            this.faltas3ºBimestre,
            this.quartoBimestre,
            this.faltas4ºBimestre});
            this.grdBoletim.Location = new System.Drawing.Point(22, 12);
            this.grdBoletim.Name = "grdBoletim";
            this.grdBoletim.Size = new System.Drawing.Size(758, 355);
            this.grdBoletim.TabIndex = 0;
            // 
            // materias
            // 
            this.materias.HeaderText = "Matérias";
            this.materias.Name = "materias";
            // 
            // primeiroBimestre
            // 
            this.primeiroBimestre.HeaderText = "1º Bimestre";
            this.primeiroBimestre.Name = "primeiroBimestre";
            // 
            // faltas1ºBimestre
            // 
            this.faltas1ºBimestre.HeaderText = "Faltas 1º Bimestre";
            this.faltas1ºBimestre.Name = "faltas1ºBimestre";
            // 
            // segundoBimestre
            // 
            this.segundoBimestre.HeaderText = "2º Bimestre";
            this.segundoBimestre.Name = "segundoBimestre";
            // 
            // faltas2ºBimestre
            // 
            this.faltas2ºBimestre.HeaderText = "Faltas 2º Bimestre";
            this.faltas2ºBimestre.Name = "faltas2ºBimestre";
            // 
            // terceroBimestre
            // 
            this.terceroBimestre.HeaderText = "3º Bimestre";
            this.terceroBimestre.Name = "terceroBimestre";
            // 
            // faltas3ºBimestre
            // 
            this.faltas3ºBimestre.HeaderText = "Faltas 3º Bimestre";
            this.faltas3ºBimestre.Name = "faltas3ºBimestre";
            // 
            // quartoBimestre
            // 
            this.quartoBimestre.HeaderText = "4º Bimestre";
            this.quartoBimestre.Name = "quartoBimestre";
            // 
            // faltas4ºBimestre
            // 
            this.faltas4ºBimestre.HeaderText = "Faltas 4º Bimestre";
            this.faltas4ºBimestre.Name = "faltas4ºBimestre";
            // 
            // frmBoletim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 395);
            this.Controls.Add(this.grdBoletim);
            this.Name = "frmBoletim";
            this.Text = "Boletim";
            ((System.ComponentModel.ISupportInitialize)(this.grdBoletim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdBoletim;
        private System.Windows.Forms.DataGridViewTextBoxColumn materias;
        private System.Windows.Forms.DataGridViewTextBoxColumn primeiroBimestre;
        private System.Windows.Forms.DataGridViewTextBoxColumn faltas1ºBimestre;
        private System.Windows.Forms.DataGridViewTextBoxColumn segundoBimestre;
        private System.Windows.Forms.DataGridViewTextBoxColumn faltas2ºBimestre;
        private System.Windows.Forms.DataGridViewTextBoxColumn terceroBimestre;
        private System.Windows.Forms.DataGridViewTextBoxColumn faltas3ºBimestre;
        private System.Windows.Forms.DataGridViewTextBoxColumn quartoBimestre;
        private System.Windows.Forms.DataGridViewTextBoxColumn faltas4ºBimestre;
    }
}