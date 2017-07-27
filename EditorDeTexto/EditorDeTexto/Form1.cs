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
    }
}
