using Microsoft.Data.Sqlite;
using System.Data.SQLite;

namespace PdvDesktop
{
    public partial class Login : Form
    {
        private string dbPath = "dbPdv.db";



        public Login()
        {
            InitializeComponent();
            txtSenha.KeyDown += txtSenha_KeyDown;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string Nome = txtUsuario.Text.Trim();
                string Senha = txtSenha.Text.Trim();

                var id = 0;
                var nome = "";
                var senha = "";

                if (string.IsNullOrWhiteSpace(Nome) ||
                    string.IsNullOrWhiteSpace(Senha))
                {
                    MessageBox.Show("Preencha todos os campos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
                try
                {
                    if (!File.Exists(dbPath))
                    {
                        SQLiteConnection.CreateFile(dbPath);
                    }

                    using (var conexao = new SqliteConnection($"Data Source={dbPath};"))
                    {
                        conexao.Open();

                        string sql = "SELECT CODIGO, NOME, LOGIN FROM usuario WHERE NOME= @Nome AND LOGIN = @Senha";
                        using (var cmd = new SqliteCommand(sql, conexao))
                        {
                            cmd.Parameters.AddWithValue("@Nome", Nome);
                            cmd.Parameters.AddWithValue("@Senha", Senha);

                            using (var reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    id = Convert.ToInt32(reader["CODIGO"]);
                                    nome = reader["NOME"].ToString();
                                    senha = reader["LOGIN"].ToString();

                                    if (txtUsuario.Text.Equals(nome) && txtSenha.Text.Equals(senha))
                                    {
                                        CaixaAberto caixaAberto = new CaixaAberto(id, nome);
                                        caixaAberto.Show();
                                        caixaAberto.Activate();
                                        this.Close();

                                    }
                                    else
                                    {
                                        this.lblmensagem.Text = "Usuário ou senha inválidos!";
                                        this.txtUsuario.Text = "";
                                        this.txtSenha.Text = "";
                                        this.txtUsuario.Focus();    
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Usuário não encontrado.");
                                }
                            }


                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao salvar no banco: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                e.Handled = true;  // impede que o Enter vá para o controle padrão
            }
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
