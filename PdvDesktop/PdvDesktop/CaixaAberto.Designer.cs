namespace PdvDesktop
{
    partial class CaixaAberto
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaixaAberto));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            txtNome = new TextBox();
            label1 = new Label();
            txtCodigoBarras = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtQuantidade = new TextBox();
            txtPrecoUnitario = new TextBox();
            txtPrecoTotal = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            lblTotal = new Label();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            toolStrip1 = new ToolStrip();
            toolStripRelogio = new ToolStripLabel();
            toolStripUsuarioLogado = new ToolStripLabel();
            btnFecharTela = new Button();
            dgvItens = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Preco = new DataGridViewTextBoxColumn();
            Qtd = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            btnFinalizarVenda = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItens).BeginInit();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Enabled = false;
            txtNome.Font = new Font("Segoe UI", 14F);
            txtNome.Location = new Point(12, 12);
            txtNome.Multiline = true;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(1239, 42);
            txtNome.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.MenuText;
            label1.Font = new Font("Segoe UI", 11F);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(12, 60);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 1;
            label1.Text = "Código";
            label1.Click += label1_Click;
            // 
            // txtCodigoBarras
            // 
            txtCodigoBarras.Location = new Point(14, 83);
            txtCodigoBarras.Name = "txtCodigoBarras";
            txtCodigoBarras.Size = new Size(306, 23);
            txtCodigoBarras.TabIndex = 0;
            txtCodigoBarras.KeyDown += txtCodigoBarras_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.MenuText;
            label2.Font = new Font("Segoe UI", 11F);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(533, 60);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 3;
            label2.Text = "Quantidade";
            // 
            // label3
            // 
            label3.BackColor = SystemColors.MenuText;
            label3.Font = new Font("Segoe UI", 13F);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(728, 83);
            label3.Name = "label3";
            label3.Size = new Size(18, 30);
            label3.TabIndex = 4;
            label3.Text = "X";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(516, 80);
            txtQuantidade.Multiline = true;
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(184, 42);
            txtQuantidade.TabIndex = 5;
            // 
            // txtPrecoUnitario
            // 
            txtPrecoUnitario.Enabled = false;
            txtPrecoUnitario.Location = new Point(769, 80);
            txtPrecoUnitario.Multiline = true;
            txtPrecoUnitario.Name = "txtPrecoUnitario";
            txtPrecoUnitario.Size = new Size(184, 42);
            txtPrecoUnitario.TabIndex = 6;
            // 
            // txtPrecoTotal
            // 
            txtPrecoTotal.Enabled = false;
            txtPrecoTotal.Location = new Point(1008, 80);
            txtPrecoTotal.Multiline = true;
            txtPrecoTotal.Name = "txtPrecoTotal";
            txtPrecoTotal.Size = new Size(243, 42);
            txtPrecoTotal.TabIndex = 7;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.MenuText;
            label4.Font = new Font("Segoe UI", 13F);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(975, 83);
            label4.Name = "label4";
            label4.Size = new Size(18, 30);
            label4.TabIndex = 8;
            label4.Text = "=";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.MenuText;
            label5.Font = new Font("Segoe UI", 11F);
            label5.ForeColor = Color.Transparent;
            label5.Location = new Point(782, 57);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 9;
            label5.Text = "Preço R$";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.MenuText;
            label6.Font = new Font("Segoe UI", 11F);
            label6.ForeColor = Color.Transparent;
            label6.Location = new Point(1024, 60);
            label6.Name = "label6";
            label6.Size = new Size(63, 20);
            label6.TabIndex = 10;
            label6.Text = "Total R$";
            // 
            // label7
            // 
            label7.BackColor = SystemColors.WindowText;
            label7.ForeColor = SystemColors.Window;
            label7.Location = new Point(520, 136);
            label7.Name = "label7";
            label7.Size = new Size(718, 36);
            label7.TabIndex = 11;
            label7.Text = resources.GetString("label7.Text");
            // 
            // lblTotal
            // 
            lblTotal.BackColor = SystemColors.MenuText;
            lblTotal.Font = new Font("Segoe UI", 13F);
            lblTotal.ForeColor = Color.Transparent;
            lblTotal.Location = new Point(520, 585);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(718, 30);
            lblTotal.TabIndex = 13;
            lblTotal.Text = "SUBTOTAL";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Banner_Ofertas_Exclusivas_gJEDfP;
            pictureBox1.Location = new Point(14, 136);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(500, 417);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripRelogio, toolStripUsuarioLogado });
            toolStrip1.Location = new Point(0, 621);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1271, 25);
            toolStrip1.TabIndex = 15;
            toolStrip1.Text = "toolStripRelogio";
            // 
            // toolStripRelogio
            // 
            toolStripRelogio.Alignment = ToolStripItemAlignment.Right;
            toolStripRelogio.Name = "toolStripRelogio";
            toolStripRelogio.Size = new Size(86, 22);
            toolStripRelogio.Text = "toolStripLabel1";
            // 
            // toolStripUsuarioLogado
            // 
            toolStripUsuarioLogado.Alignment = ToolStripItemAlignment.Right;
            toolStripUsuarioLogado.Name = "toolStripUsuarioLogado";
            toolStripUsuarioLogado.Size = new Size(86, 22);
            toolStripUsuarioLogado.Text = "toolStripLabel2";
            // 
            // btnFecharTela
            // 
            btnFecharTela.Location = new Point(14, 568);
            btnFecharTela.Name = "btnFecharTela";
            btnFecharTela.Size = new Size(137, 42);
            btnFecharTela.TabIndex = 16;
            btnFecharTela.Text = "FINALIZAR ATIVIDADE";
            btnFecharTela.UseVisualStyleBackColor = true;
            btnFecharTela.Click += btnFecharTela_Click;
            // 
            // dgvItens
            // 
            dgvItens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItens.Columns.AddRange(new DataGridViewColumn[] { Codigo, Nome, Preco, Qtd, Total });
            dgvItens.Location = new Point(533, 204);
            dgvItens.Name = "dgvItens";
            dgvItens.Size = new Size(8, 8);
            dgvItens.TabIndex = 17;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Código";
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            Codigo.Width = 140;
            // 
            // Nome
            // 
            Nome.HeaderText = "Produto";
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            Nome.Width = 350;
            // 
            // Preco
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "C2";
            Preco.DefaultCellStyle = dataGridViewCellStyle1;
            Preco.HeaderText = "Preço (R$)";
            Preco.Name = "Preco";
            Preco.ReadOnly = true;
            Preco.Width = 90;
            // 
            // Qtd
            // 
            Qtd.HeaderText = "Qtd";
            Qtd.Name = "Qtd";
            Qtd.ReadOnly = true;
            Qtd.Width = 50;
            // 
            // Total
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "C2";
            Total.DefaultCellStyle = dataGridViewCellStyle2;
            Total.HeaderText = "Total (R$)";
            Total.Name = "Total";
            Total.ReadOnly = true;
            Total.Width = 90;
            // 
            // btnFinalizarVenda
            // 
            btnFinalizarVenda.Location = new Point(404, 568);
            btnFinalizarVenda.Name = "btnFinalizarVenda";
            btnFinalizarVenda.Size = new Size(96, 47);
            btnFinalizarVenda.TabIndex = 18;
            btnFinalizarVenda.Text = "FINALIZAR VENDA";
            btnFinalizarVenda.UseVisualStyleBackColor = true;
            btnFinalizarVenda.Click += btnFinalizarVenda_Click;
            // 
            // CaixaAberto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(1271, 646);
            Controls.Add(btnFinalizarVenda);
            Controls.Add(dgvItens);
            Controls.Add(btnFecharTela);
            Controls.Add(toolStrip1);
            Controls.Add(pictureBox1);
            Controls.Add(lblTotal);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtPrecoTotal);
            Controls.Add(txtPrecoUnitario);
            Controls.Add(txtQuantidade);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtCodigoBarras);
            Controls.Add(label1);
            Controls.Add(txtNome);
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CaixaAberto";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pdv - Caixa";
            Load += CaixaAberto_Show;
            Shown += CaixaAberto_Show;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItens).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private Label label1;
        private TextBox txtCodigoBarras;
        private Label label2;
        private Label label3;
        private TextBox txtQuantidade;
        private TextBox txtPrecoUnitario;
        private TextBox txtPrecoTotal;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label lblTotal;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private ToolStrip toolStrip1;
        private Button btnFecharTela;
        private ToolStripLabel toolStripRelogio;
        private ToolStripLabel toolStripUsuarioLogado;
        private DataGridView dgvItens;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Preco;
        private DataGridViewTextBoxColumn Qtd;
        private DataGridViewTextBoxColumn Total;
        private Button btnFinalizarVenda;
    }
}