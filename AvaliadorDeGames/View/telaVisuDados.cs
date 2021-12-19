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
using AvaliadorDeGames.Control;
using AvaliadorDeGames.Model;

namespace AvaliadorDeGames.View
{
    public partial class telaVisuDados : Form
    {
        public telaVisuDados()
        {
            InitializeComponent();

            ManipulaUsuario manipulaUsuario = new ManipulaUsuario();
            manipulaUsuario.dadosUsuario();

            labelNomeUsuario.Text = Usuario.Nome;
            labelUsuario.Text = Usuario.Nickname;
            labelEmailUsuario.Text = Usuario.Email;
            labelSenhaUsuario.Text = Usuario.Senha;
        }

        private void buttonAlterarDadosUsuario_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            telaAlterarDadosUsuario telaAlterarDadosUsuario = new telaAlterarDadosUsuario();
            telaAlterarDadosUsuario.ShowDialog();
        }
    }
}
