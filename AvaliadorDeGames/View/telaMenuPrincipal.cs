using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AvaliadorDeGames.Control;
using AvaliadorDeGames.Model;


namespace AvaliadorDeGames.View
{
    public partial class telaMenuPrincipal : Form
    {
        public telaMenuPrincipal()
        {
            InitializeComponent();

            if (Jogo.IdJogo == 0)
            {
                Jogo.IdJogo = 6;
            }

            ManipulaJogo manipulaJogo = new ManipulaJogo();
            manipulaJogo.visuJogoAleatorio();

            labelTituloJogo.Text = Jogo.NomeJogo;
            labelDesenvJogo.Text = Jogo.DesenvJogo;            
            labelDataLanJogo.Text = Jogo.DataLancMostrar;
            labelCategoriaJogo.Text = Jogo.Categoria;
            labelPlataJogo.Text = Jogo.Plataforma;
            textBoxMostrarSinopse.Text = Jogo.Sinopse;

            MemoryStream memoryStream = new MemoryStream(Jogo.CapaJogo);

            Image imagem = Image.FromStream(memoryStream);

            pictureBoxCapaJogoMenu.Image = imagem;

            labelNotaPessoasMuitoBom.Text = ManipulaJogo.contadorNotas5();

            labelNotaPessoasBom.Text = ManipulaJogo.contadorNotas4();

            labelNotaPessoasRazoavel.Text = ManipulaJogo.contadorNotas3();

            labelNotaPessoasRuim.Text = ManipulaJogo.contadorNotas2();
            
            labelNotaPessoasPessimo.Text = ManipulaJogo.contadorNotas1();

                
        }

        private void cadastreUmJogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            telaCadastrarJogo cadastrarJogo = new telaCadastrarJogo();
            cadastrarJogo.ShowDialog();
        }

        private void meusDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            telaVisuDados visuDados = new telaVisuDados();
            visuDados.ShowDialog();
        }

        private void buttonConfirmarNota_Click(object sender, EventArgs e)
        {
            if (Jogo.IdJogo == 0)
            {
                Jogo.IdJogo = 6;
            }

            if (radioButtonMuitoBom.Checked == true)
            {
               Jogo.DarNotaJogo = 5;
               ManipulaJogo manipulaJogo = new ManipulaJogo();
               manipulaJogo.votarJogo();
            }
            else if (radioButtonBom.Checked == true)
            {
                Jogo.DarNotaJogo = 4;
                ManipulaJogo manipulaJogo = new ManipulaJogo();
                manipulaJogo.votarJogo();
            }
            else if (radioButtonRazoavel.Checked == true)
            {
                Jogo.DarNotaJogo = 3;
                ManipulaJogo manipulaJogo = new ManipulaJogo();
                manipulaJogo.votarJogo();
            }
            else if (radioButtonRuim.Checked == true)
            {
                Jogo.DarNotaJogo = 2;
                ManipulaJogo manipulaJogo = new ManipulaJogo();
                manipulaJogo.votarJogo();
            }
            else if (radioButtonPessimo.Checked == true)
            {
                Jogo.DarNotaJogo = 1;
                ManipulaJogo manipulaJogo = new ManipulaJogo();
                manipulaJogo.votarJogo();
            }
        }

        private void buttonPesquisarJogos_Click(object sender, EventArgs e)
        {
            Jogo.NomejogoBox = textBoxPesquisarJogos.Text;
            
            ManipulaJogo manipulaJogo = new ManipulaJogo();
            manipulaJogo.visuJogo();

            labelTituloJogo.Text = Jogo.NomeJogo;
            labelDesenvJogo.Text = Jogo.DesenvJogo;
            labelDataLanJogo.Text = Jogo.DataLancMostrar;
            labelCategoriaJogo.Text = Jogo.Categoria;
            labelPlataJogo.Text = Jogo.Plataforma;
            textBoxMostrarSinopse.Text = Jogo.Sinopse;
            
            MemoryStream memoryStream = new MemoryStream(Jogo.CapaJogo);

            Image imagem = Image.FromStream(memoryStream);

            pictureBoxCapaJogoMenu.Image = imagem;

            labelNotaPessoasMuitoBom.Text = ManipulaJogo.contadorNotas5();

            labelNotaPessoasBom.Text = ManipulaJogo.contadorNotas4();

            labelNotaPessoasRazoavel.Text = ManipulaJogo.contadorNotas3();

            labelNotaPessoasRuim.Text = ManipulaJogo.contadorNotas2();

            labelNotaPessoasPessimo.Text = ManipulaJogo.contadorNotas1();
        }

        private void modifiqueSeuJogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            telaAlterarJogo alterarJogo = new telaAlterarJogo();
            alterarJogo.ShowDialog();
        }
    }
}
