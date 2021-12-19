using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using AvaliadorDeGames.Model;
using AvaliadorDeGames.Control;
using AvaliadorDeGames.View;


namespace AvaliadorDeGames.View
{
    public partial class telaCadastrarJogo : Form
    {
        public telaCadastrarJogo()
        {
            InitializeComponent();
        }

        private void buttonInserirFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JPG Files(*.jpg)|*.jpg|Png File(*.png)|*.png|AllFiles(*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string foto = dialog.FileName.ToString();
                textBoxImagem.Text = foto;
                pictureBoxImagemJogo.ImageLocation = foto;
            }
        }

        private void buttonCadastrarJogo_Click(object sender, EventArgs e)
        {
            byte[] imagem_byte = null;

            FileStream fileStream = new FileStream(this.textBoxImagem.Text, FileMode.Open, FileAccess.Read);

            BinaryReader binaryReader = new BinaryReader(fileStream);

            imagem_byte = binaryReader.ReadBytes((int)fileStream.Length);

            Jogo.NomeJogo = textBoxNomeJogo.Text;
            Jogo.DesenvJogo = textBoxDesenvolvedoraJogo.Text;
            Jogo.DataLanc = Convert.ToDateTime(dateTimePickerDataLancamentoJogo.Text);
            Jogo.Categoria = textBoxCategoriaJogo.Text;
            Jogo.Sinopse = textBoxSinopseJogo.Text;
            Jogo.Plataforma = textBoxPlataformaJogo.Text;
            Jogo.CapaJogo = imagem_byte;

            ManipulaJogo manipulaJogo = new ManipulaJogo();
            manipulaJogo.cadastrarJogo();


        }
    }
}
