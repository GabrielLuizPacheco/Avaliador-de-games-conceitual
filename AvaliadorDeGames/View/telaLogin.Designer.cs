namespace AvaliadorDeGames.View
{
    partial class telaLogin
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
            this.labelCadastro = new System.Windows.Forms.Label();
            this.labelEsqueciSenha = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSenhaLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxUsuarioLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCadastro
            // 
            this.labelCadastro.AutoSize = true;
            this.labelCadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelCadastro.Location = new System.Drawing.Point(27, 268);
            this.labelCadastro.Name = "labelCadastro";
            this.labelCadastro.Size = new System.Drawing.Size(85, 17);
            this.labelCadastro.TabIndex = 22;
            this.labelCadastro.Text = "Cadastre-se";
            this.labelCadastro.Click += new System.EventHandler(this.labelCadastro_Click);
            // 
            // labelEsqueciSenha
            // 
            this.labelEsqueciSenha.AutoSize = true;
            this.labelEsqueciSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelEsqueciSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelEsqueciSenha.Location = new System.Drawing.Point(52, 317);
            this.labelEsqueciSenha.Name = "labelEsqueciSenha";
            this.labelEsqueciSenha.Size = new System.Drawing.Size(113, 17);
            this.labelEsqueciSenha.TabIndex = 21;
            this.labelEsqueciSenha.Text = "Esqueci a senha";
            this.labelEsqueciSenha.Click += new System.EventHandler(this.labelEsqueciSenha_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.Font = new System.Drawing.Font("BankGothic Lt BT", 11F);
            this.buttonLogin.Location = new System.Drawing.Point(146, 264);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(62, 31);
            this.buttonLogin.TabIndex = 20;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("BankGothic Lt BT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 34);
            this.label3.TabIndex = 19;
            this.label3.Text = "LOGIN";
            // 
            // textBoxSenhaLogin
            // 
            this.textBoxSenhaLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSenhaLogin.Location = new System.Drawing.Point(30, 224);
            this.textBoxSenhaLogin.Name = "textBoxSenhaLogin";
            this.textBoxSenhaLogin.PasswordChar = '*';
            this.textBoxSenhaLogin.Size = new System.Drawing.Size(178, 22);
            this.textBoxSenhaLogin.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("BankGothic Lt BT", 11F);
            this.label2.Location = new System.Drawing.Point(27, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Senha:";
            // 
            // textBoxUsuarioLogin
            // 
            this.textBoxUsuarioLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsuarioLogin.Location = new System.Drawing.Point(30, 176);
            this.textBoxUsuarioLogin.Name = "textBoxUsuarioLogin";
            this.textBoxUsuarioLogin.Size = new System.Drawing.Size(178, 22);
            this.textBoxUsuarioLogin.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("BankGothic Lt BT", 11F);
            this.label1.Location = new System.Drawing.Point(27, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Usuário:";
            // 
            // telaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 441);
            this.Controls.Add(this.labelCadastro);
            this.Controls.Add(this.labelEsqueciSenha);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSenhaLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxUsuarioLogin);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "telaLogin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Avaliador de Games";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCadastro;
        private System.Windows.Forms.Label labelEsqueciSenha;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSenhaLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxUsuarioLogin;
        private System.Windows.Forms.Label label1;
    }
}