using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace PdvProject
{
    public partial class CaixaForm : Form
    {
        private TextBox txtCodigoBarras;
        private TextBox txtNomeProduto;
        private TextBox txtPreco;
        private DataGridView dgvItens;
        private Label lblTotal;
        private Button btnFinalizar;
        private decimal totalVenda = 0m;

        public CaixaForm()
        {
            InitializeComponent();
            CriarInterface();
        }

        private void InitializeComponent()
        {
            // vazio, mantido para compatibilidade
        }

        private void CriarInterface()
        {
            // Configurações gerais da tela
            this.Text = "Caixa - PDV";
            this.Size = new Size(1024, 860);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.WhiteSmoke;

            // --- Label Código de Barras ---
            Label lblCodigo = new Label();
            lblCodigo.Text = "Código de Barras:";
            lblCodigo.Location = new Point(30, 30);
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            Controls.Add(lblCodigo);

            // --- Campo Código de Barras ---
            txtCodigoBarras = new TextBox();
            txtCodigoBarras.Name = "txtCodigoBarras";
            txtCodigoBarras.PlaceholderText = "Escaneie ou digite o código...";
            txtCodigoBarras.Width = 300;
            txtCodigoBarras.Font = new Font("Segoe UI", 10);
            txtCodigoBarras.Location = new Point(180, 28);
            txtCodigoBarras.KeyDown += TxtCodigoBarras_KeyDown;
            Controls.Add(txtCodigoBarras);

            // --- Label Nome ---
            Label lblNome = new Label();
            lblNome.Text = "Produto:";
            lblNome.Location = new Point(30, 80);
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            Controls.Add(lblNome);

            // --- Campo Nome ---
            txtNomeProduto = new TextBox();
            txtNomeProduto.ReadOnly = true;
            txtNomeProduto.Width = 400;
            txtNomeProduto.Font = new Font("Segoe UI", 10);
            txtNomeProduto.Location = new Point(180, 78);
            Controls.Add(txtNomeProduto);

            // --- Label Preço ---
            Label lblPreco = new Label();
            lblPreco.Text = "Preço (R$):";
            lblPreco.Location = new Point(30, 120);
            lblPreco.AutoSize = true;
            lblPreco.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            Controls.Add(lblPreco);

            // --- Campo Preço ---
            txtPreco = new TextBox();
            txtPreco.ReadOnly = true;
            txtPreco.Width = 120;
            txtPreco.Font = new Font("Segoe UI", 10);
            txtPreco.Location = new Point(180, 118);
            Controls.Add(txtPreco);

            // --- Label Total ---
            lblTotal = new Label();
            lblTotal.Text = "Total: R$ 0,00";
            lblTotal.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            lblTotal.ForeColor = Color.DarkGreen;
            lblTotal.Location = new Point(this.Width-230, 600);
            lblTotal.AutoSize = true;
            Controls.Add(lblTotal);

            // --- Botão Finalizar Venda ---
            btnFinalizar = new Button();
            btnFinalizar.Text = "Finalizar Venda";
            btnFinalizar.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnFinalizar.BackColor = Color.ForestGreen;
            btnFinalizar.ForeColor = Color.White;
            btnFinalizar.FlatStyle = FlatStyle.Flat;
            btnFinalizar.Location = new Point(180, 600);
            btnFinalizar.Size = new Size(190, 50);
            btnFinalizar.Click += BtnFinalizar_Click;
            Controls.Add(btnFinalizar);    

            // --- Campo Preço Total ---
            txtPreco = new TextBox();
            txtPreco.ReadOnly = true;
            txtPreco.Width = 120;
            txtPreco.Font = new Font("Segoe UI", 10);
            txtPreco.Location = new Point(180, 118);
            Controls.Add(txtPreco);





            // --- DataGridView (lista de itens) ---
            dgvItens = new DataGridView();
            dgvItens.Location = new Point(30, 180);
            dgvItens.Size = new Size(940, 400);
            dgvItens.Font = new Font("Segoe UI", 10);
            dgvItens.BackgroundColor = Color.White;
            dgvItens.AllowUserToAddRows = false;
            dgvItens.ReadOnly = true;
            dgvItens.RowHeadersVisible = false;
            dgvItens.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvItens.Columns.Add("Codigo", "Código");
            dgvItens.Columns.Add("Nome", "Produto");
            dgvItens.Columns.Add("Preco", "Preço (R$)");
            dgvItens.Columns.Add("Qtd", "Qtd");
            dgvItens.Columns.Add("Total", "Total (R$)");

            Controls.Add(dgvItens);

            // Impede redimensionamento automático
            dgvItens.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvItens.AllowUserToResizeColumns = false;

            // Define o tamanho fixo de cada coluna
            dgvItens.Columns["Codigo"].Width = 150; // Código de barras (14 dígitos)
            dgvItens.Columns["Nome"].Width = 450;
            dgvItens.Columns["Qtd"].Width = 80;
            dgvItens.Columns["Preco"].Width = 120;
            dgvItens.Columns["Total"].Width = 135;

            // Impede redimensionamento automático individual
            foreach (DataGridViewColumn col in dgvItens.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            }

            // Alinha à direita e formata colunas de preço e total como moeda
            dgvItens.Columns["Preco"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvItens.Columns["Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvItens.Columns["Preco"].DefaultCellStyle.Format = "C2"; // Formato moeda (ex: R$ 12,50)
            dgvItens.Columns["Total"].DefaultCellStyle.Format = "C2";

            // Deixa os cabeçalhos centralizados
            dgvItens.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Deixa o grid visualmente mais limpo
            dgvItens.RowHeadersVisible = false;
            dgvItens.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItens.MultiSelect = false;
            dgvItens.ReadOnly = true;

            //dgvItens.Visible = false;    


            // Foco inicial
            this.Shown += (s, e) => txtCodigoBarras.Focus();
        }

        private void TxtCodigoBarras_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string codigo = txtCodigoBarras.Text.Trim();
                if (!string.IsNullOrEmpty(codigo))
                {
                    BuscarProdutoPorCodigo(codigo);
                    txtCodigoBarras.Clear();
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
            }
        }

        private void BuscarProdutoPorCodigo(string codigo)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection("Data Source=dbPdv.db;Version=3;"))
                {
                    conn.Open();
                    string query = "SELECT nome, preco FROM produtos WHERE codigo_barras = @codigo";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@codigo", codigo);
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string nome = reader["nome"].ToString();
                                decimal preco = Convert.ToDecimal(reader["preco"]);

                                txtNomeProduto.Text = nome;
                                txtPreco.Text = preco.ToString("F2");

                                AdicionarItem(codigo, nome, preco);
                            }
                            else
                            {
                                MessageBox.Show("Produto não encontrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                txtNomeProduto.Clear();
                                txtPreco.Clear();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar produto: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AdicionarItem(string codigo, string nome, decimal preco)
        {
            int qtd = 1;
            bool itemExistente = false;

            // Verifica se o produto já está na lista
            foreach (DataGridViewRow row in dgvItens.Rows)
            {
                if (row.Cells["Codigo"].Value.ToString() == codigo)
                {
                    qtd = Convert.ToInt32(row.Cells["Qtd"].Value) + 1;
                    row.Cells["Qtd"].Value = qtd;
                    row.Cells["Total"].Value = (preco * qtd).ToString("F2");
                    itemExistente = true;
                    break;
                }
            }

            // Se não existe, adiciona um novo
            if (!itemExistente)
            {
                dgvItens.Rows.Add(codigo, nome, preco.ToString("F2"), qtd, preco.ToString("F2"));
            }

            AtualizarTotal();
        }

        private void AtualizarTotal()
        {
            totalVenda = 0m;
            foreach (DataGridViewRow row in dgvItens.Rows)
            {
                totalVenda += Convert.ToDecimal(row.Cells["Total"].Value);
            }

            lblTotal.Text = $"Total: R$ {totalVenda:F2}";
        }

        private void BtnFinalizar_Click(object sender, EventArgs e)
        {
            if (dgvItens.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum item adicionado à venda.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show($"Venda finalizada com sucesso!\n\nTotal: R$ {totalVenda:F2}", 
                            "Venda Concluída", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dgvItens.Rows.Clear();
            txtNomeProduto.Clear();
            txtPreco.Clear();
            lblTotal.Text = "Total: R$ 0,00";
            totalVenda = 0m;
            txtCodigoBarras.Focus();
        }
    }
}