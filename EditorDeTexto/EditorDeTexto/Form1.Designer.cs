namespace EditorDeTexto
{
    partial class Form1
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
            this.textoConteudo = new System.Windows.Forms.TextBox();
            this.botaoGrava = new System.Windows.Forms.Button();
            this.textoBusca = new System.Windows.Forms.TextBox();
            this.botaoBusca = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textoReplace = new System.Windows.Forms.TextBox();
            this.botaoReplace = new System.Windows.Forms.Button();
            this.botaoMaiuscula = new System.Windows.Forms.Button();
            this.botaoMinuscula = new System.Windows.Forms.Button();
            this.botaoMaiusculaSelecionado = new System.Windows.Forms.Button();
            this.botaoMinusculaSelecao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textoConteudo
            // 
            this.textoConteudo.Location = new System.Drawing.Point(13, 13);
            this.textoConteudo.Multiline = true;
            this.textoConteudo.Name = "textoConteudo";
            this.textoConteudo.Size = new System.Drawing.Size(259, 189);
            this.textoConteudo.TabIndex = 0;
            // 
            // botaoGrava
            // 
            this.botaoGrava.Location = new System.Drawing.Point(13, 227);
            this.botaoGrava.Name = "botaoGrava";
            this.botaoGrava.Size = new System.Drawing.Size(75, 23);
            this.botaoGrava.TabIndex = 1;
            this.botaoGrava.Text = "Gravar";
            this.botaoGrava.UseVisualStyleBackColor = true;
            this.botaoGrava.Click += new System.EventHandler(this.botaoGrava_Click);
            // 
            // textoBusca
            // 
            this.textoBusca.Location = new System.Drawing.Point(154, 227);
            this.textoBusca.Name = "textoBusca";
            this.textoBusca.Size = new System.Drawing.Size(100, 20);
            this.textoBusca.TabIndex = 2;
            // 
            // botaoBusca
            // 
            this.botaoBusca.Location = new System.Drawing.Point(260, 227);
            this.botaoBusca.Name = "botaoBusca";
            this.botaoBusca.Size = new System.Drawing.Size(75, 23);
            this.botaoBusca.TabIndex = 3;
            this.botaoBusca.Text = "Find";
            this.botaoBusca.UseVisualStyleBackColor = true;
            this.botaoBusca.Click += new System.EventHandler(this.botaoBusca_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Find";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Replace";
            // 
            // textoReplace
            // 
            this.textoReplace.Location = new System.Drawing.Point(154, 254);
            this.textoReplace.Name = "textoReplace";
            this.textoReplace.Size = new System.Drawing.Size(100, 20);
            this.textoReplace.TabIndex = 6;
            // 
            // botaoReplace
            // 
            this.botaoReplace.Location = new System.Drawing.Point(261, 254);
            this.botaoReplace.Name = "botaoReplace";
            this.botaoReplace.Size = new System.Drawing.Size(75, 23);
            this.botaoReplace.TabIndex = 7;
            this.botaoReplace.Text = "Replace";
            this.botaoReplace.UseVisualStyleBackColor = true;
            this.botaoReplace.Click += new System.EventHandler(this.botaoReplace_Click);
            // 
            // botaoMaiuscula
            // 
            this.botaoMaiuscula.Location = new System.Drawing.Point(104, 284);
            this.botaoMaiuscula.Name = "botaoMaiuscula";
            this.botaoMaiuscula.Size = new System.Drawing.Size(105, 23);
            this.botaoMaiuscula.TabIndex = 8;
            this.botaoMaiuscula.Text = "Tudo MAIUSCULA";
            this.botaoMaiuscula.UseVisualStyleBackColor = true;
            this.botaoMaiuscula.Click += new System.EventHandler(this.botaoMaiuscula_Click);
            // 
            // botaoMinuscula
            // 
            this.botaoMinuscula.Location = new System.Drawing.Point(215, 284);
            this.botaoMinuscula.Name = "botaoMinuscula";
            this.botaoMinuscula.Size = new System.Drawing.Size(116, 23);
            this.botaoMinuscula.TabIndex = 9;
            this.botaoMinuscula.Text = "Tudo minuscula";
            this.botaoMinuscula.UseVisualStyleBackColor = true;
            this.botaoMinuscula.Click += new System.EventHandler(this.botaoMinuscula_Click);
            // 
            // botaoMaiusculaSelecionado
            // 
            this.botaoMaiusculaSelecionado.Location = new System.Drawing.Point(30, 313);
            this.botaoMaiusculaSelecionado.Name = "botaoMaiusculaSelecionado";
            this.botaoMaiusculaSelecionado.Size = new System.Drawing.Size(134, 23);
            this.botaoMaiusculaSelecionado.TabIndex = 10;
            this.botaoMaiusculaSelecionado.Text = "Seleção pra maiúsculo";
            this.botaoMaiusculaSelecionado.UseVisualStyleBackColor = true;
            this.botaoMaiusculaSelecionado.Click += new System.EventHandler(this.botaoMaiusculaSelecionado_Click);
            // 
            // botaoMinusculaSelecao
            // 
            this.botaoMinusculaSelecao.Location = new System.Drawing.Point(170, 313);
            this.botaoMinusculaSelecao.Name = "botaoMinusculaSelecao";
            this.botaoMinusculaSelecao.Size = new System.Drawing.Size(161, 23);
            this.botaoMinusculaSelecao.TabIndex = 11;
            this.botaoMinusculaSelecao.Text = "Seleção pra minúsculo";
            this.botaoMinusculaSelecao.UseVisualStyleBackColor = true;
            this.botaoMinusculaSelecao.Click += new System.EventHandler(this.botaoMinusculaSelecao_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 369);
            this.Controls.Add(this.botaoMinusculaSelecao);
            this.Controls.Add(this.botaoMaiusculaSelecionado);
            this.Controls.Add(this.botaoMinuscula);
            this.Controls.Add(this.botaoMaiuscula);
            this.Controls.Add(this.botaoReplace);
            this.Controls.Add(this.textoReplace);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botaoBusca);
            this.Controls.Add(this.textoBusca);
            this.Controls.Add(this.botaoGrava);
            this.Controls.Add(this.textoConteudo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textoConteudo;
        private System.Windows.Forms.Button botaoGrava;
        private System.Windows.Forms.TextBox textoBusca;
        private System.Windows.Forms.Button botaoBusca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textoReplace;
        private System.Windows.Forms.Button botaoReplace;
        private System.Windows.Forms.Button botaoMaiuscula;
        private System.Windows.Forms.Button botaoMinuscula;
        private System.Windows.Forms.Button botaoMaiusculaSelecionado;
        private System.Windows.Forms.Button botaoMinusculaSelecao;
    }
}

