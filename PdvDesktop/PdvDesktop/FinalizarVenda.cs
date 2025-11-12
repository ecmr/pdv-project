using System.Globalization;

namespace PdvDesktop
{
    public partial class FinalizarVenda : Form
    {
        string sTotalVenda;
        Array processo = Array.Empty<string>();
        int item = 0;
        public bool VendaFinalizada = false;

        public FinalizarVenda()
        {
            InitializeComponent();
        }

        public FinalizarVenda(int iCodigoUsuario, string sNome, Decimal totalVenda)
        {
            InitializeComponent();
            sTotalVenda = totalVenda.ToString("C2");
            processo = new string[] { "Processando pagamento", "Finalizando venda", "Imprimindo cupom", "Atualizando estoque", "Concluído" };
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void FinalizarVenda_Load(object sender, EventArgs e)
        {
            lblTotal.Text = sTotalVenda;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (listBox1.SelectedItem.ToString() == "DINHEIRO")
                {
                    txtRecebidoDinheiro.Enabled = true;
                    txtRecebidoDinheiro.Focus();
                    txtProsesso.Text = "Aguardando Pagamento...";
                }
                else
                {
                    txtRecebidoDinheiro.Visible = false;
                    lblTroco.Visible = false;
                    label3.Visible = false;
                    label4.Visible = false; 
                    txtProsesso.Text = "Aguardando Pagamento...";
                    timer1.Start();
                }
            }
        }

        private void txtRecebidoDinheiro_keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CultureInfo culturaBR = new CultureInfo("pt-BR");

                decimal recebido = decimal.Parse(txtRecebidoDinheiro.Text, NumberStyles.Currency, culturaBR);
                decimal total = decimal.Parse(sTotalVenda, NumberStyles.Currency, culturaBR);

                decimal troco = recebido - total;
                lblTroco.Text = troco.ToString("C2", culturaBR);

                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (item == 4)
            {
                VendaFinalizada = true;
                timer1.Stop();
                this.Close();
            }
            else
            {
                txtProsesso.Text += Environment.NewLine + processo.GetValue(item).ToString();
                item++;
            }
        }
    }
}
