﻿namespace ModuloAluno
{
    partial class frmIncluirAluno
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.lblCurso = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblDataDeMatricula = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.btnIncluirAluno = new System.Windows.Forms.Button();
            this.mskDataDeMatricula = new System.Windows.Forms.MaskedTextBox();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.cbxCurso = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(26, 22);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(26, 50);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(37, 13);
            this.lblIdade.TabIndex = 1;
            this.lblIdade.Text = "Idade:";
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(26, 76);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(37, 13);
            this.lblCurso.TabIndex = 2;
            this.lblCurso.Text = "Curso:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(26, 108);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email:";
            // 
            // lblDataDeMatricula
            // 
            this.lblDataDeMatricula.AutoSize = true;
            this.lblDataDeMatricula.Location = new System.Drawing.Point(26, 134);
            this.lblDataDeMatricula.Name = "lblDataDeMatricula";
            this.lblDataDeMatricula.Size = new System.Drawing.Size(96, 13);
            this.lblDataDeMatricula.TabIndex = 4;
            this.lblDataDeMatricula.Text = "Data de Matrícula:";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(26, 160);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(56, 13);
            this.lblEndereco.TabIndex = 5;
            this.lblEndereco.Text = "Endereço:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(26, 186);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(52, 13);
            this.lblTelefone.TabIndex = 6;
            this.lblTelefone.Text = "Telefone:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(129, 22);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(290, 20);
            this.txtNome.TabIndex = 1;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(129, 50);
            this.txtIdade.MaxLength = 3;
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(25, 20);
            this.txtIdade.TabIndex = 2;
            this.txtIdade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdade_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(129, 101);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(290, 20);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(129, 153);
            this.txtEndereco.MaxLength = 50;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(290, 20);
            this.txtEndereco.TabIndex = 6;
            // 
            // btnIncluirAluno
            // 
            this.btnIncluirAluno.Location = new System.Drawing.Point(29, 232);
            this.btnIncluirAluno.Name = "btnIncluirAluno";
            this.btnIncluirAluno.Size = new System.Drawing.Size(106, 23);
            this.btnIncluirAluno.TabIndex = 8;
            this.btnIncluirAluno.Text = "Incluir Aluno";
            this.btnIncluirAluno.UseVisualStyleBackColor = true;
            this.btnIncluirAluno.Click += new System.EventHandler(this.btnIncluirAluno_Click);
            // 
            // mskDataDeMatricula
            // 
            this.mskDataDeMatricula.Location = new System.Drawing.Point(129, 128);
            this.mskDataDeMatricula.Mask = "00/00/0000";
            this.mskDataDeMatricula.Name = "mskDataDeMatricula";
            this.mskDataDeMatricula.Size = new System.Drawing.Size(65, 20);
            this.mskDataDeMatricula.TabIndex = 5;
            this.mskDataDeMatricula.ValidatingType = typeof(System.DateTime);
            // 
            // mskTelefone
            // 
            this.mskTelefone.Location = new System.Drawing.Point(129, 186);
            this.mskTelefone.Mask = "(99)9999-9999";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(75, 20);
            this.mskTelefone.TabIndex = 7;
            // 
            // cbxCurso
            // 
            this.cbxCurso.FormattingEnabled = true;
            this.cbxCurso.Items.AddRange(new object[] {
            "SELECIONE",
            "ANÁLISE E DESENVOLVIMENTO DE SISTEMAS",
            "GESTÃO DE TI",
            "REDES"});
            this.cbxCurso.Location = new System.Drawing.Point(129, 76);
            this.cbxCurso.Name = "cbxCurso";
            this.cbxCurso.Size = new System.Drawing.Size(290, 21);
            this.cbxCurso.TabIndex = 3;
            // 
            // frmIncluirAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 300);
            this.Controls.Add(this.cbxCurso);
            this.Controls.Add(this.mskTelefone);
            this.Controls.Add(this.mskDataDeMatricula);
            this.Controls.Add(this.btnIncluirAluno);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblDataDeMatricula);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblCurso);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.lblNome);
            this.Name = "frmIncluirAluno";
            this.Text = "frmIncluirAluno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDataDeMatricula;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Button btnIncluirAluno;
        private System.Windows.Forms.MaskedTextBox mskDataDeMatricula;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.ComboBox cbxCurso;
    }
}

