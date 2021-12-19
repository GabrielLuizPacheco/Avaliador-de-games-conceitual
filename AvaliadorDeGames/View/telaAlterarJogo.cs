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
    public partial class telaAlterarJogo : Form
    {
        public telaAlterarJogo()
        {
            InitializeComponent();
        }

        private void buttonBuscarJogoAlterar_Click(object sender, EventArgs e)
        {
            Jogo.NomejogoBox = textBoxBuscarJogoAlterar.Text;

            ManipulaJogo manipulaJogo = new ManipulaJogo();
            manipulaJogo.visuJogo();

            //textBoxNomeJogoAlterar.Text = Jogo.NomeJogo;
            textBoxCategoriaJogoAlterar.Text = Jogo.Categoria;
            textBoxDesenvolvedoraJogoAlterar.Text = Jogo.DesenvJogo;
            textBoxPlataformaJogoAlterar.Text = Jogo.Plataforma;
            textBoxSinopseJogoAlterar.Text = Jogo.Sinopse;
            dateTimePickerDataLancamentoJogoAlterar.Value = Convert.ToDateTime(Jogo.DataLancMostrar);

           /* MemoryStream memoryStream = new MemoryStream(Jogo.CapaJogo);

            Image imagem = Image.FromStream(memoryStream);

            pictureBoxImagemJogoAlterar.Image = imagem;*/
        }

        private void buttonAlterarJogo_Click(object sender, EventArgs e)
        {
           /* byte[] imagem_byte = null;


            FileStream fileStream = new FileStream(this.textBoxImagemAltera.Text, FileMode.Open, FileAccess.Read);

            BinaryReader binaryReader = new BinaryReader(fileStream);

            imagem_byte = binaryReader.ReadBytes((int)fileStream.Length);*/

            
            //Jogo.NomeJogo = textBoxNomeJogoAlterar.Text;
            Jogo.Categoria = textBoxCategoriaJogoAlterar.Text;
            Jogo.DesenvJogo = textBoxDesenvolvedoraJogoAlterar.Text;
            Jogo.Plataforma = textBoxPlataformaJogoAlterar.Text;
            Jogo.Sinopse = textBoxSinopseJogoAlterar.Text;
            Jogo.DataLanc = dateTimePickerDataLancamentoJogoAlterar.Value;
            //Jogo.CapaJogo = imagem_byte;

             ManipulaJogo manipulaJogo = new ManipulaJogo();
                manipulaJogo.alterarJogo();

            
        }

        private void buttonInserirFotoAlterar_Click(object sender, EventArgs e)
        {
            /* OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JPG Files(*.jpg)|*.jpg|Png File(*.png)|*.png|AllFiles(*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string foto = dialog.FileName.ToString();
                textBoxImagemAltera.Text = foto;
                pictureBoxImagemJogoAlterar.ImageLocation = foto;
            }*/
        }
    }
}
