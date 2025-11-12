namespace PdvDesktop
{
    partial class FinalizarVenda
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
            label1 = new Label();
            label2 = new Label();
            listBox1 = new ListBox();
            Label6 = new Label();
            lblTotal = new Label();
            txtProsesso = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            label3 = new Label();
            txtRecebidoDinheiro = new TextBox();
            label4 = new Label();
            lblTroco = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(8, 9);
            label1.Name = "label1";
            label1.Size = new Size(167, 25);
            label1.TabIndex = 2;
            label1.Text = "Finalizando Venda";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(22, 46);
            label2.Name = "label2";
            label2.Size = new Size(163, 21);
            label2.TabIndex = 1;
            label2.Text = "Forma de pagameno...";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Items.AddRange(new object[] { "DINHEIRO", "PIX - QRCODE", "PIX - CHAVE", "CARTÃO DÉBITO", "CARTÃO CRÉDITO", "" });
            listBox1.Location = new Point(22, 70);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(172, 94);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            listBox1.KeyDown += listBox1_keydown;
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Font = new Font("Segoe UI", 12F);
            Label6.Location = new Point(215, 46);
            Label6.Name = "Label6";
            Label6.Size = new Size(42, 21);
            Label6.TabIndex = 3;
            Label6.Text = "Total";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 14F);
            lblTotal.Location = new Point(276, 43);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(23, 25);
            lblTotal.TabIndex = 4;
            lblTotal.Text = "X";
            lblTotal.Click += lblTotal_Click;
            // 
            // txtProsesso
            // 
            txtProsesso.Enabled = false;
            txtProsesso.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            txtProsesso.Location = new Point(200, 70);
            txtProsesso.Multiline = true;
            txtProsesso.Name = "txtProsesso";
            txtProsesso.Size = new Size(305, 141);
            txtProsesso.TabIndex = 5;
            // 
            // timer1
            // 
            timer1.Interval = 2000;
            timer1.Tick += timer1_Tick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 231);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 6;
            label3.Text = "Recebido";
            // 
            // txtRecebidoDinheiro
            // 
            txtRecebidoDinheiro.Location = new Point(103, 231);
            txtRecebidoDinheiro.Name = "txtRecebidoDinheiro";
            txtRecebidoDinheiro.Size = new Size(100, 23);
            txtRecebidoDinheiro.TabIndex = 7;
            txtRecebidoDinheiro.KeyDown += txtRecebidoDinheiro_keydown;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(266, 233);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 8;
            label4.Text = "Troco";
            // 
            // lblTroco
            // 
            lblTroco.AutoSize = true;
            lblTroco.Font = new Font("Segoe UI", 14F);
            lblTroco.Location = new Point(324, 234);
            lblTroco.Name = "lblTroco";
            lblTroco.Size = new Size(79, 25);
            lblTroco.TabIndex = 9;
            lblTroco.Text = "lblTroco";
            // 
            // FinalizarVenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 273);
            Controls.Add(lblTroco);
            Controls.Add(label4);
            Controls.Add(txtRecebidoDinheiro);
            Controls.Add(label3);
            Controls.Add(txtProsesso);
            Controls.Add(lblTotal);
            Controls.Add(Label6);
            Controls.Add(listBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FinalizarVenda";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FinalizarVenda";
            Load += FinalizarVenda_Load;
            Shown += FinalizarVenda_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ListBox listBox1;
        private Label Label6;
        private Label lblTotal;
        private TextBox txtProsesso;
        private System.Windows.Forms.Timer timer1;
        private Label label3;
        private TextBox txtRecebidoDinheiro;
        private Label label4;
        private Label lblTroco;
    }
}