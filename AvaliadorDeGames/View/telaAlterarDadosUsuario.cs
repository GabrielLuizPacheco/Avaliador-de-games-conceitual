using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AvaliadorDeGames.Control;
using AvaliadorDeGames.Model;

namespace AvaliadorDeGames.View
{
    public partial class telaAlterarDadosUsuario : Form
    {
        public telaAlterarDadosUsuario()
        {
            InitializeComponent();
        }

        private void buttonConfirmarAlterarDados_Click(object sender, EventArgs e)
        {
            Usuario.Nome = textBoxNomeUsuarioAlterar.Text;
            Usuario.Nickname = textBoxUsuarioAlterar.Text;
            Usuario.Senha = textBoxSenhaUsuarioAlterar.Text;
            Usuario.Email = textBoxEmailUsuarioAlterar.Text;

            ManipulaUsuario manipulaUsuario = new ManipulaUsuario();
            manipulaUsuario.alterarDadosUsuario();

            textBoxNomeUsuarioAlterar.Text = "";
            textBoxUsuarioAlterar.Text = "";
            textBoxSenhaUsuarioAlterar.Text = "";
            textBoxEmailUsuarioAlterar.Text = "";
        }
    }
}
