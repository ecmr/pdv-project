namespace PdvDesktop
{
    public partial class CaixaFechado : Form
    {
        public CaixaFechado()
        {
            InitializeComponent();
            this.KeyDown += Form1_KeyDown;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripRelogio.Text = string.Concat(DateTime.Now.ToShortDateString(), " ", DateTime.Now.ToString("HH:mm:ss"));
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Aqui você coloca a ação que deseja
                Login login = new Login();
                login.ShowDialog(); 
                e.Handled = true;  // impede que o Enter vá para o controle padrão
            }
        }
    }
}
