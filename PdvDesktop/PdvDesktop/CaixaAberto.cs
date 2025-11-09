using Microsoft.Data.Sqlite;
using System.Data.SQLite;

namespace PdvDesktop
{
    public partial class CaixaAberto : Form
    {
        private int iCodigoUsuario;
        private string sNome;
        private decimal totalVenda = 0m;


        public CaixaAberto(int id, string nome)
        {
            InitializeComponent();
            iCodigoUsuario = id;
            sNome = nome;

            #region grid


            // --- DataGridView (lista de itens) ---
            dgvItens.Location = new Point(518, 170);
            dgvItens.Size = new Size(718, 420);
            dgvItens.Font = new Font("Segoe UI", 14);
            dgvItens.BackgroundColor = Color.White;
            dgvItens.AllowUserToAddRows = false;
            dgvItens.ReadOnly = true;
            dgvItens.RowHeadersVisible = false;
            dgvItens.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            /* 
                        dgvItens.Columns.Add("Codigo", "Código");
                        dgvItens.Columns.Add("Nome", "Produto");
                        dgvItens.Columns.Add("Preco", "Preço (R$)");
                        dgvItens.Columns.Add("Qtd", "Qtd");
                        dgvItens.Columns.Add("Total", "Total (R$)");

                        Controls.Add(dgvItens);
            */

            // Impede redimensionamento automático
            dgvItens.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvItens.AllowUserToResizeColumns = false;

            /*
            // Define o tamanho fixo de cada coluna
            dgvItens.Columns["Codigo"].Width = 150; // Código de barras (14 dígitos)
            dgvItens.Columns["Nome"].Width = 790;
            dgvItens.Columns["Qtd"].Width = 80;
            dgvItens.Columns["Preco"].Width = 120;
            dgvItens.Columns["Total"].Width = 135;

            */

            // Impede redimensionamento automático individual
            foreach (DataGridViewColumn col in dgvItens.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            }

            /*
            // Alinha à direita e formata colunas de preço e total como moeda
            dgvItens.Columns["Preco"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvItens.Columns["Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvItens.Columns["Preco"].DefaultCellStyle.Format = "C2"; // Formato moeda (ex: R$ 12,50)
            dgvItens.Columns["Total"].DefaultCellStyle.Format = "C2";
            */

            // Deixa os cabeçalhos centralizados
            dgvItens.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Deixa o grid visualmente mais limpo
            dgvItens.RowHeadersVisible = false;
            dgvItens.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItens.MultiSelect = false;
            dgvItens.ReadOnly = true;

            //dgvItens.Visible = false;    
            #endregion
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripRelogio.Text = string.Concat(DateTime.Now.ToShortDateString(), " ", DateTime.Now.ToString("HH:mm:ss"));
            toolStripUsuarioLogado.Text = string.Concat("Usuário: ", iCodigoUsuario.ToString(), " - ", sNome);
        }

        private void CaixaAberto_Show(object sender, EventArgs e)
        {

            Form caixaFechado = Application.OpenForms["CaixaFechado"];
            if (caixaFechado != null)
            {
                caixaFechado.Visible = false;
            }

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
                    string query = "SELECT codigo_barras, nome, preco FROM produtos WHERE codigo_barras = @codigo";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@codigo", codigo);
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string nome = reader["nome"].ToString();
                                decimal preco = Convert.ToDecimal(reader["preco"]);

                                txtNome.Text = nome;
                                txtPrecoUnitario.Text = preco.ToString("F2");

                                AdicionarItem(codigo, nome, preco);
                            }
                            else
                            {
                                MessageBox.Show("Produto não encontrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                txtNome.Clear();
                                txtPrecoUnitario.Clear();
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

        private void btnFecharTela_Click(object sender, EventArgs e)
        {
            Form caixaFechado = Application.OpenForms["CaixaFechado"];
            if (caixaFechado != null)
            {
                caixaFechado.Close();
            }
        }
    }
}
