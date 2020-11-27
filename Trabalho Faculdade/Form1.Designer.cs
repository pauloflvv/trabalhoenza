
namespace Trabalho_Faculdade
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtUsuarioCad = new System.Windows.Forms.TextBox();
            this.lbCadastro = new System.Windows.Forms.Label();
            this.lbUsuarioCad = new System.Windows.Forms.Label();
            this.lbSenhaCad = new System.Windows.Forms.Label();
            this.txtSenhaCad = new System.Windows.Forms.TextBox();
            this.lbSenhaLogin = new System.Windows.Forms.Label();
            this.txtSenhaLogin = new System.Windows.Forms.TextBox();
            this.lbUsuarioLogin = new System.Windows.Forms.Label();
            this.lbLogin = new System.Windows.Forms.Label();
            this.txtUsuarioLogin = new System.Windows.Forms.TextBox();
            this.btnCad = new System.Windows.Forms.Button();
            this.btnLogar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUsuarioCad
            // 
            this.txtUsuarioCad.Location = new System.Drawing.Point(64, 32);
            this.txtUsuarioCad.Name = "txtUsuarioCad";
            this.txtUsuarioCad.Size = new System.Drawing.Size(167, 20);
            this.txtUsuarioCad.TabIndex = 0;
            // 
            // lbCadastro
            // 
            this.lbCadastro.AutoSize = true;
            this.lbCadastro.Location = new System.Drawing.Point(12, 9);
            this.lbCadastro.Name = "lbCadastro";
            this.lbCadastro.Size = new System.Drawing.Size(91, 13);
            this.lbCadastro.TabIndex = 1;
            this.lbCadastro.Text = "Cadastrar Usuário";
            // 
            // lbUsuarioCad
            // 
            this.lbUsuarioCad.AutoSize = true;
            this.lbUsuarioCad.Location = new System.Drawing.Point(12, 35);
            this.lbUsuarioCad.Name = "lbUsuarioCad";
            this.lbUsuarioCad.Size = new System.Drawing.Size(46, 13);
            this.lbUsuarioCad.TabIndex = 2;
            this.lbUsuarioCad.Text = "Usuário:";
            // 
            // lbSenhaCad
            // 
            this.lbSenhaCad.AutoSize = true;
            this.lbSenhaCad.Location = new System.Drawing.Point(12, 61);
            this.lbSenhaCad.Name = "lbSenhaCad";
            this.lbSenhaCad.Size = new System.Drawing.Size(41, 13);
            this.lbSenhaCad.TabIndex = 4;
            this.lbSenhaCad.Text = "Senha:";
            // 
            // txtSenhaCad
            // 
            this.txtSenhaCad.Location = new System.Drawing.Point(64, 58);
            this.txtSenhaCad.Name = "txtSenhaCad";
            this.txtSenhaCad.Size = new System.Drawing.Size(167, 20);
            this.txtSenhaCad.TabIndex = 3;
            // 
            // lbSenhaLogin
            // 
            this.lbSenhaLogin.AutoSize = true;
            this.lbSenhaLogin.Location = new System.Drawing.Point(426, 64);
            this.lbSenhaLogin.Name = "lbSenhaLogin";
            this.lbSenhaLogin.Size = new System.Drawing.Size(41, 13);
            this.lbSenhaLogin.TabIndex = 9;
            this.lbSenhaLogin.Text = "Senha:";
            // 
            // txtSenhaLogin
            // 
            this.txtSenhaLogin.Location = new System.Drawing.Point(478, 61);
            this.txtSenhaLogin.Name = "txtSenhaLogin";
            this.txtSenhaLogin.Size = new System.Drawing.Size(167, 20);
            this.txtSenhaLogin.TabIndex = 8;
            // 
            // lbUsuarioLogin
            // 
            this.lbUsuarioLogin.AutoSize = true;
            this.lbUsuarioLogin.Location = new System.Drawing.Point(426, 38);
            this.lbUsuarioLogin.Name = "lbUsuarioLogin";
            this.lbUsuarioLogin.Size = new System.Drawing.Size(46, 13);
            this.lbUsuarioLogin.TabIndex = 7;
            this.lbUsuarioLogin.Text = "Usuário:";
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Location = new System.Drawing.Point(426, 12);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(91, 13);
            this.lbLogin.TabIndex = 6;
            this.lbLogin.Text = "Cadastrar Usuário";
            // 
            // txtUsuarioLogin
            // 
            this.txtUsuarioLogin.Location = new System.Drawing.Point(478, 35);
            this.txtUsuarioLogin.Name = "txtUsuarioLogin";
            this.txtUsuarioLogin.Size = new System.Drawing.Size(167, 20);
            this.txtUsuarioLogin.TabIndex = 5;
            // 
            // btnCad
            // 
            this.btnCad.Location = new System.Drawing.Point(15, 84);
            this.btnCad.Name = "btnCad";
            this.btnCad.Size = new System.Drawing.Size(216, 23);
            this.btnCad.TabIndex = 10;
            this.btnCad.Text = "Cadastrar";
            this.btnCad.UseVisualStyleBackColor = true;
            this.btnCad.Click += new System.EventHandler(this.btnCad_Click);
            // 
            // btnLogar
            // 
            this.btnLogar.Location = new System.Drawing.Point(429, 87);
            this.btnLogar.Name = "btnLogar";
            this.btnLogar.Size = new System.Drawing.Size(216, 23);
            this.btnLogar.TabIndex = 11;
            this.btnLogar.Text = "Logar";
            this.btnLogar.UseVisualStyleBackColor = true;
            this.btnLogar.Click += new System.EventHandler(this.btnLogar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 154);
            this.Controls.Add(this.btnLogar);
            this.Controls.Add(this.btnCad);
            this.Controls.Add(this.lbSenhaLogin);
            this.Controls.Add(this.txtSenhaLogin);
            this.Controls.Add(this.lbUsuarioLogin);
            this.Controls.Add(this.lbLogin);
            this.Controls.Add(this.txtUsuarioLogin);
            this.Controls.Add(this.lbSenhaCad);
            this.Controls.Add(this.txtSenhaCad);
            this.Controls.Add(this.lbUsuarioCad);
            this.Controls.Add(this.lbCadastro);
            this.Controls.Add(this.txtUsuarioCad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuarioCad;
        private System.Windows.Forms.Label lbCadastro;
        private System.Windows.Forms.Label lbUsuarioCad;
        private System.Windows.Forms.Label lbSenhaCad;
        private System.Windows.Forms.TextBox txtSenhaCad;
        private System.Windows.Forms.Label lbSenhaLogin;
        private System.Windows.Forms.TextBox txtSenhaLogin;
        private System.Windows.Forms.Label lbUsuarioLogin;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.TextBox txtUsuarioLogin;
        private System.Windows.Forms.Button btnCad;
        private System.Windows.Forms.Button btnLogar;
    }
}

