namespace PdvDesktop
{
    partial class CaixaFechado
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblCaixaFechado = new Label();
            statusStrip1 = new StatusStrip();
            toolStripRelogio = new ToolStripStatusLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblCaixaFechado
            // 
            lblCaixaFechado.BackColor = SystemColors.InactiveCaption;
            lblCaixaFechado.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            lblCaixaFechado.Location = new Point(0, 449);
            lblCaixaFechado.Name = "lblCaixaFechado";
            lblCaixaFechado.Size = new Size(1306, 37);
            lblCaixaFechado.TabIndex = 0;
            lblCaixaFechado.Text = "CAIXA FECHADO";
            lblCaixaFechado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripRelogio });
            statusStrip1.Location = new Point(0, 548);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1261, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripRelogio
            // 
            toolStripRelogio.Name = "toolStripRelogio";
            toolStripRelogio.Size = new Size(1246, 17);
            toolStripRelogio.Spring = true;
            toolStripRelogio.Text = "toolStripStatusLabel1";
            toolStripRelogio.TextAlign = ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.CebtralSupermercado;
            pictureBox1.Location = new Point(506, 275);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(233, 94);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // CaixaFechado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(1261, 570);
            Controls.Add(pictureBox1);
            Controls.Add(statusStrip1);
            Controls.Add(lblCaixaFechado);
            KeyPreview = true;
            Name = "CaixaFechado";
            Text = "PDV - Supmercado";
            WindowState = FormWindowState.Maximized;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCaixaFechado;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripRelogio;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox1;
    }
}
