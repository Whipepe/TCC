namespace prototipo4
{
    partial class AreaExe
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblImagem = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlImagemGeral = new System.Windows.Forms.Panel();
            this.picCircunferência = new System.Windows.Forms.PictureBox();
            this.picTrapézio = new System.Windows.Forms.PictureBox();
            this.picTriângulo = new System.Windows.Forms.PictureBox();
            this.picQuadrado = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCircunferência)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTrapézio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTriângulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQuadrado)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 0);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.picCircunferência, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.picTrapézio, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.picTriângulo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.picQuadrado, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(735, 136);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(934, 138);
            this.panel2.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblImagem);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(738, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(194, 136);
            this.panel4.TabIndex = 5;
            // 
            // lblImagem
            // 
            this.lblImagem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblImagem.AutoSize = true;
            this.lblImagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lblImagem.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblImagem.Location = new System.Drawing.Point(43, 102);
            this.lblImagem.Name = "lblImagem";
            this.lblImagem.Size = new System.Drawing.Size(107, 25);
            this.lblImagem.TabIndex = 0;
            this.lblImagem.Text = "Quadrado";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.panel3.Controls.Add(this.tableLayoutPanel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(735, 136);
            this.panel3.TabIndex = 4;
            // 
            // pnlImagemGeral
            // 
            this.pnlImagemGeral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlImagemGeral.Location = new System.Drawing.Point(0, 138);
            this.pnlImagemGeral.Name = "pnlImagemGeral";
            this.pnlImagemGeral.Size = new System.Drawing.Size(934, 523);
            this.pnlImagemGeral.TabIndex = 3;
            // 
            // picCircunferência
            // 
            this.picCircunferência.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picCircunferência.Image = global::prototipo4.Properties.Resources.circunferência;
            this.picCircunferência.Location = new System.Drawing.Point(552, 3);
            this.picCircunferência.Name = "picCircunferência";
            this.picCircunferência.Size = new System.Drawing.Size(180, 130);
            this.picCircunferência.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCircunferência.TabIndex = 3;
            this.picCircunferência.TabStop = false;
            this.picCircunferência.Click += new System.EventHandler(this.picCircunferência_Click);
            // 
            // picTrapézio
            // 
            this.picTrapézio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picTrapézio.Image = global::prototipo4.Properties.Resources.trapézio_isóceles;
            this.picTrapézio.Location = new System.Drawing.Point(369, 3);
            this.picTrapézio.Name = "picTrapézio";
            this.picTrapézio.Size = new System.Drawing.Size(177, 130);
            this.picTrapézio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTrapézio.TabIndex = 2;
            this.picTrapézio.TabStop = false;
            this.picTrapézio.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // picTriângulo
            // 
            this.picTriângulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picTriângulo.Image = global::prototipo4.Properties.Resources.triângulo;
            this.picTriângulo.Location = new System.Drawing.Point(186, 3);
            this.picTriângulo.Name = "picTriângulo";
            this.picTriângulo.Size = new System.Drawing.Size(177, 130);
            this.picTriângulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTriângulo.TabIndex = 1;
            this.picTriângulo.TabStop = false;
            this.picTriângulo.Click += new System.EventHandler(this.picTriângulo_Click);
            // 
            // picQuadrado
            // 
            this.picQuadrado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picQuadrado.Image = global::prototipo4.Properties.Resources.quadrado;
            this.picQuadrado.Location = new System.Drawing.Point(3, 3);
            this.picQuadrado.Name = "picQuadrado";
            this.picQuadrado.Size = new System.Drawing.Size(177, 130);
            this.picQuadrado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picQuadrado.TabIndex = 0;
            this.picQuadrado.TabStop = false;
            this.picQuadrado.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // AreaExe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.Controls.Add(this.pnlImagemGeral);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AreaExe";
            this.Size = new System.Drawing.Size(934, 661);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCircunferência)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTrapézio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTriângulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQuadrado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picCircunferência;
        private System.Windows.Forms.PictureBox picTrapézio;
        private System.Windows.Forms.PictureBox picTriângulo;
        private System.Windows.Forms.PictureBox picQuadrado;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblImagem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlImagemGeral;
    }
}
