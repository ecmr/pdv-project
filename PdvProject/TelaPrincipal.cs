using System;
using System.Windows.Forms;

namespace PdvProject
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Text = "PDV - Sistema de Caixa";
            this.Width = 500;
            this.Height = 300;
            this.StartPosition = FormStartPosition.CenterScreen;

            Label lblTitulo = new Label();
            lblTitulo.Text = "MENU PRINCIPAL - PDV";
            lblTitulo.Top = 30;
            lblTitulo.Left = 120;
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14, System.Drawing.FontStyle.Bold);

            Button btnCaixa = new Button();
            btnCaixa.Text = "Abrir Caixa";
            btnCaixa.Top = 100;
            btnCaixa.Left = 150;
            btnCaixa.Width = 200;
            btnCaixa.Height = 40;
            btnCaixa.Click += BtnCaixa_Click;

            Button btnCadastroProduto = new Button();
            btnCadastroProduto.Text = "Cadastrar Produto";
            btnCadastroProduto.Top = 150;
            btnCadastroProduto.Left = 150;
            btnCadastroProduto.Width = 200;
            btnCadastroProduto.Height = 40;
            btnCadastroProduto.Click += BtnCadastroProduto_Click;

            Button btnSair = new Button();
            btnSair.Text = "Sair";
            btnSair.Top = 200;
            btnSair.Left = 150;
            btnSair.Width = 200;
            btnSair.Height = 40;
            btnSair.Click += (s, e) => this.Close();

            this.Controls.Add(lblTitulo);
            this.Controls.Add(btnCaixa);
            this.Controls.Add(btnCadastroProduto);
            this.Controls.Add(btnSair);
        }

        private void BtnCaixa_Click(object? sender, EventArgs e)
        {
            CaixaForm caixaForm = new CaixaForm();
            caixaForm.ShowDialog();
        }

        private void BtnCadastroProduto_Click(object? sender, EventArgs e)
        {
            CadastroProdutoForm cadastroProdutoForm = new CadastroProdutoForm();
            cadastroProdutoForm.ShowDialog();
        }
    }
}