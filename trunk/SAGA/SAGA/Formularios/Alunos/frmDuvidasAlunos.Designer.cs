﻿namespace SAGA.Formularios.Alunos
{
    partial class frmDuvidasAlunos
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabRespostas = new System.Windows.Forms.TabPage();
            this.lsvDuvida = new System.Windows.Forms.ListView();
            this.txtResposta = new System.Windows.Forms.TextBox();
            this.tabDuvidas = new System.Windows.Forms.TabPage();
            this.lblProfessor = new System.Windows.Forms.Label();
            this.lblDuvida = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabRespostas.SuspendLayout();
            this.tabDuvidas.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabRespostas);
            this.tabControl1.Controls.Add(this.tabDuvidas);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(768, 472);
            this.tabControl1.TabIndex = 0;
            // 
            // tabRespostas
            // 
            this.tabRespostas.Controls.Add(this.lsvDuvida);
            this.tabRespostas.Controls.Add(this.txtResposta);
            this.tabRespostas.Location = new System.Drawing.Point(4, 22);
            this.tabRespostas.Name = "tabRespostas";
            this.tabRespostas.Padding = new System.Windows.Forms.Padding(3);
            this.tabRespostas.Size = new System.Drawing.Size(760, 446);
            this.tabRespostas.TabIndex = 0;
            this.tabRespostas.Text = "Respostas";
            this.tabRespostas.UseVisualStyleBackColor = true;
            // 
            // lsvDuvida
            // 
            this.lsvDuvida.Location = new System.Drawing.Point(6, 6);
            this.lsvDuvida.Name = "lsvDuvida";
            this.lsvDuvida.Size = new System.Drawing.Size(206, 434);
            this.lsvDuvida.TabIndex = 3;
            this.lsvDuvida.UseCompatibleStateImageBehavior = false;
            // 
            // txtResposta
            // 
            this.txtResposta.Enabled = false;
            this.txtResposta.Location = new System.Drawing.Point(218, 6);
            this.txtResposta.Multiline = true;
            this.txtResposta.Name = "txtResposta";
            this.txtResposta.Size = new System.Drawing.Size(536, 434);
            this.txtResposta.TabIndex = 2;
            // 
            // tabDuvidas
            // 
            this.tabDuvidas.Controls.Add(this.lblProfessor);
            this.tabDuvidas.Controls.Add(this.lblDuvida);
            this.tabDuvidas.Controls.Add(this.btnEnviar);
            this.tabDuvidas.Controls.Add(this.comboBox1);
            this.tabDuvidas.Controls.Add(this.textBox1);
            this.tabDuvidas.Location = new System.Drawing.Point(4, 22);
            this.tabDuvidas.Name = "tabDuvidas";
            this.tabDuvidas.Padding = new System.Windows.Forms.Padding(3);
            this.tabDuvidas.Size = new System.Drawing.Size(760, 446);
            this.tabDuvidas.TabIndex = 1;
            this.tabDuvidas.Text = "Dúvidas";
            this.tabDuvidas.UseVisualStyleBackColor = true;
            // 
            // lblProfessor
            // 
            this.lblProfessor.AutoSize = true;
            this.lblProfessor.Location = new System.Drawing.Point(6, 270);
            this.lblProfessor.Name = "lblProfessor";
            this.lblProfessor.Size = new System.Drawing.Size(51, 13);
            this.lblProfessor.TabIndex = 4;
            this.lblProfessor.Text = "Professor";
            // 
            // lblDuvida
            // 
            this.lblDuvida.AutoSize = true;
            this.lblDuvida.Location = new System.Drawing.Point(6, 15);
            this.lblDuvida.Name = "lblDuvida";
            this.lblDuvida.Size = new System.Drawing.Size(41, 13);
            this.lblDuvida.TabIndex = 3;
            this.lblDuvida.Text = "Dúvida";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(379, 265);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 2;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(63, 267);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(63, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(391, 231);
            this.textBox1.TabIndex = 0;
            // 
            // frmDuvidasAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 506);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmDuvidasAlunos";
            this.Text = "Dúvidas";
            this.tabControl1.ResumeLayout(false);
            this.tabRespostas.ResumeLayout(false);
            this.tabRespostas.PerformLayout();
            this.tabDuvidas.ResumeLayout(false);
            this.tabDuvidas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabRespostas;
        private System.Windows.Forms.ListView lsvDuvida;
        private System.Windows.Forms.TextBox txtResposta;
        private System.Windows.Forms.TabPage tabDuvidas;
        private System.Windows.Forms.Label lblProfessor;
        private System.Windows.Forms.Label lblDuvida;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}