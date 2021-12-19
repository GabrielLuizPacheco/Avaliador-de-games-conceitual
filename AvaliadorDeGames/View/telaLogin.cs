using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AvaliadorDeGames.View;
using AvaliadorDeGames.Model;
using AvaliadorDeGames.Control;

namespace AvaliadorDeGames.View
{
    public partial class telaLogin : Form
    {
        public telaLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Usuario.Nickname = textBoxUsuarioLogin.Text;
            Usuario.Senha = textBoxSenhaLogin.Text;

            this.Visible = false;

            ManipulaUsuario manipulaUsuario = new ManipulaUsuario();
            manipulaUsuario.loginUsuario();
        }

        private void labelCadastro_Click(object sender, EventArgs e)
        {
            telaCadastro cadastro = new telaCadastro();
            cadastro.ShowDialog();
        }

        private void labelEsqueciSenha_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Consulte a caixa de entrada do seu e-mail, enviaremos um link de confirmação para alteração de senha.");
        }
    }
}
