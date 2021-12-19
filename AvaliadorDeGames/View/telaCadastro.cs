using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AvaliadorDeGames.Model;
using AvaliadorDeGames.Control;
using AvaliadorDeGames.View;

namespace AvaliadorDeGames
{
    public partial class telaCadastro : Form
    {
        public telaCadastro()
        {
            InitializeComponent();
        }

        private void buttonCadastrarUsuario_Click(object sender, EventArgs e)
        {
            Usuario.Nome = textBoxNomeUsuarioCadastro.Text;
            Usuario.Nickname = textBoxUsuarioCadastro.Text;
            Usuario.Email = textBoxEmailUsuarioCadastro.Text;
            Usuario.Senha = textBoxConfirmarSenhaUsuarioCadastro.Text;

            ManipulaUsuario manipulaUsuario = new ManipulaUsuario();
            manipulaUsuario.cadastrarUsuario();

            this.Visible = false;
        }

        private void labelVoltarLogin_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            telaLogin telaLogin = new telaLogin();
            telaLogin.ShowDialog();
        }
    }
}
