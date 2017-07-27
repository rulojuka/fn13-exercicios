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

namespace EditorDeTexto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("texto.txt"))
            {
                // Lê de .\EditorDeTexto\bin\Debug\texto.txt quando em modo Debug
                using (Stream entrada = File.Open("texto.txt", FileMode.Open))
                using (StreamReader leitor = new StreamReader(entrada))
                {
                    textoConteudo.Text = leitor.ReadToEnd();
                    /*
                    string linha = leitor.ReadLine();
                    while (linha != null)
                    {
                        textoConteudo.Text += linha;
                        linha = leitor.ReadLine();
                    }
                    */
                    //leitor.Close();
                    //entrada.Close();
                }
            }
        }

        private void botaoGrava_Click(object sender, EventArgs e)
        {
            // Salva em .\EditorDeTexto\bin\Debug\texto.txt quando em modo Debug
            using (Stream saida = File.Open("texto.txt", FileMode.Create))
            using (StreamWriter escritor = new StreamWriter(saida))
            {
                escritor.Write(textoConteudo.Text);
                //escritor.Close();
                //saida.Close();
            }
        }

        private void botaoBusca_Click(object sender, EventArgs e)
        {
            string busca = textoBusca.Text;
            string textoDoEditor = textoConteudo.Text;
            int resultado = textoDoEditor.IndexOf(busca);
            if(resultado >= 0)
            {
                MessageBox.Show("achei o texto " + busca);
            }
            else
            {
                MessageBox.Show("Não achei");
            }
        }

        private void botaoReplace_Click(object sender, EventArgs e)
        {
            string busca = textoBusca.Text;
            string replace = textoReplace.Text;
            string textoDoEditor = textoConteudo.Text;
            textoConteudo.Text = textoConteudo.Text.Replace(busca, replace);
        }

        private void botaoMaiuscula_Click(object sender, EventArgs e)
        {
            textoConteudo.Text = textoConteudo.Text.ToUpper();
        }

        private void botaoMinuscula_Click(object sender, EventArgs e)
        {
            textoConteudo.Text = textoConteudo.Text.ToLower();
        }

        private void botaoMaiusculaSelecionado_Click(object sender, EventArgs e)
        {
            int inicioSelecao = textoConteudo.SelectionStart;
            int tamanhoSelecao = textoConteudo.SelectionLength;

            string textoSelecionado = textoConteudo.Text.Substring(inicioSelecao, tamanhoSelecao);

            string antes = textoConteudo.Text.Substring(0, inicioSelecao);
            string depois = textoConteudo.Text.Substring(inicioSelecao + tamanhoSelecao);

            textoConteudo.Text = antes + textoSelecionado.ToUpper() + depois;
        }

        private void botaoMinusculaSelecao_Click(object sender, EventArgs e)
        {
            int inicioSelecao = textoConteudo.SelectionStart;
            int tamanhoSelecao = textoConteudo.SelectionLength;

            string textoSelecionado = textoConteudo.Text.Substring(inicioSelecao, tamanhoSelecao);

            string antes = textoConteudo.Text.Substring(0, inicioSelecao);
            string depois = textoConteudo.Text.Substring(inicioSelecao + tamanhoSelecao);

            textoConteudo.Text = antes + textoSelecionado.ToLower() + depois;
        }
    }
}
