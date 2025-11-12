using System.Data.SQLite;

namespace PdvProject
{
    public partial class CadastroProdutoForm : Form
    {
        private TextBox txtCodigoBarras;
        private TextBox txtNome;
        private TextBox txtPreco;
        private Button btnSalvar;
        private string dbPath = "dbPdv.db";

        public CadastroProdutoForm()
        {
            InitializeComponent();
            CriarTabelaSeNaoExistir();
        }

        private void InitializeComponent()
        {
            this.Text = "Cadastro de Produto";
            this.Width = 420;
            this.Height = 300;
            this.StartPosition = FormStartPosition.CenterParent;

            Label lblCodigoBarras = new Label();
            lblCodigoBarras.Text = "Código de Barras:";
            lblCodigoBarras.Top = 30;
            lblCodigoBarras.Left = 30;
            lblCodigoBarras.Width = 120;

            txtCodigoBarras = new TextBox();
            txtCodigoBarras.Top = lblCodigoBarras.Top;
            txtCodigoBarras.Left = 160;
            txtCodigoBarras.Width = 180;

            Label lblNome = new Label();
            lblNome.Text = "Nome do Produto:";
            lblNome.Top = 70;
            lblNome.Left = 30;
            lblNome.Width = 120;

            txtNome = new TextBox();
            txtNome.Top = lblNome.Top;
            txtNome.Left = 160;
            txtNome.Width = 180;

            Label lblPreco = new Label();
            lblPreco.Text = "Preço (R$):";
            lblPreco.Top = 110;
            lblPreco.Left = 30;
            lblPreco.Width = 120;

            txtPreco = new TextBox();
            txtPreco.Top = lblPreco.Top;
            txtPreco.Left = 160;
            txtPreco.Width = 100;
            txtPreco.Text = "0,00";
            txtPreco.TextAlign = HorizontalAlignment.Right;
            txtPreco.KeyPress += txtPreco_KeyPress;

            btnSalvar = new Button();
            btnSalvar.Text = "Salvar";
            btnSalvar.Top = 160;
            btnSalvar.Left = 160;
            btnSalvar.Width = 100;
            btnSalvar.Click += BtnSalvar_Click;

            this.Controls.Add(lblCodigoBarras);
            this.Controls.Add(txtCodigoBarras);
            this.Controls.Add(lblNome);
            this.Controls.Add(txtNome);
            this.Controls.Add(lblPreco);
            this.Controls.Add(txtPreco);
            this.Controls.Add(btnSalvar);
        }

        private void txtPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir apenas números e Backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                return;
            }

            string apenasNumeros = new string(txtPreco.Text.Where(char.IsDigit).ToArray());

            if (e.KeyChar == (char)Keys.Back)
            {
                // Remove último dígito
                if (apenasNumeros.Length > 0)
                    apenasNumeros = apenasNumeros.Substring(0, apenasNumeros.Length - 1);
            }
            else
            {
                // Adiciona novo dígito
                apenasNumeros += e.KeyChar;
            }

            // Converte para decimal e formata como moeda
            if (decimal.TryParse(apenasNumeros, out decimal valor))
            {
                valor /= 100; // move duas casas decimais
                txtPreco.Text = valor.ToString("N2");
            }
            else
            {
                txtPreco.Text = "0,00";
            }

            // Mantém cursor no final
            txtPreco.SelectionStart = txtPreco.Text.Length;

            e.Handled = true; // impede digitação padrão
        }

        private void CriarTabelaSeNaoExistir()
        {
            if (!File.Exists(dbPath))
            {
                SQLiteConnection.CreateFile(dbPath);
            }

            using (var conexao = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
            {
                conexao.Open();
                string sql = @"CREATE TABLE IF NOT EXISTS produtos (
                                id INTEGER PRIMARY KEY AUTOINCREMENT,
                                codigo_barras TEXT NOT NULL,
                                nome TEXT NOT NULL,
                                preco REAL NOT NULL
                              );";
                using (var cmd = new SQLiteCommand(sql, conexao))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void BtnSalvar_Click(object? sender, EventArgs e)
        {
            string codigoBarras = txtCodigoBarras.Text.Trim();
            string nome = txtNome.Text.Trim();
            string precoTexto = txtPreco.Text.Trim();

            if (string.IsNullOrWhiteSpace(codigoBarras) ||
                string.IsNullOrWhiteSpace(nome) ||
                string.IsNullOrWhiteSpace(precoTexto))
            {
                MessageBox.Show("Preencha todos os campos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conexao = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
                {
                    conexao.Open();
                    string sql = "INSERT INTO produtos (codigo_barras, nome, preco) VALUES (@codigo, @nome, @preco)";
                    using (var cmd = new SQLiteCommand(sql, conexao))
                    {
                        cmd.Parameters.AddWithValue("@codigo", codigoBarras);
                        cmd.Parameters.AddWithValue("@nome", nome);
                        cmd.Parameters.AddWithValue("@preco", Convert.ToDecimal(precoTexto));
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Produto salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtCodigoBarras.Clear();
                txtNome.Clear();
                txtPreco.Clear();
                txtCodigoBarras.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar no banco: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}