namespace prototipo4
{
    partial class Circunferência
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
            this.lblExplicacaoTexto = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblPerimetro = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblExplicacao = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPerimetro = new System.Windows.Forms.Button();
            this.btnArea = new System.Windows.Forms.Button();
            this.btnExibir = new System.Windows.Forms.Button();
            this.btnOcultar = new System.Windows.Forms.Button();
            this.pnlExibir = new System.Windows.Forms.Panel();
            this.btnExibirAngulos = new System.Windows.Forms.Button();
            this.btnExibirDiametro = new System.Windows.Forms.Button();
            this.pnlOcultar = new System.Windows.Forms.Panel();
            this.btnOcultarAngulos = new System.Windows.Forms.Button();
            this.btnOcultarDiametro = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnDiametro = new System.Windows.Forms.Button();
            this.picCircunferência = new System.Windows.Forms.PictureBox();
            this.pnlDiametro = new System.Windows.Forms.Panel();
            this.btnInserirDiametro = new System.Windows.Forms.Button();
            this.txtInserirDiametro = new System.Windows.Forms.TextBox();
            this.lblDiametro = new System.Windows.Forms.Label();
            this.lblWIP = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlExibir.SuspendLayout();
            this.pnlOcultar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCircunferência)).BeginInit();
            this.pnlDiametro.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblExplicacaoTexto);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.lblExplicacao);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(734, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 523);
            this.panel1.TabIndex = 4;
            // 
            // lblExplicacaoTexto
            // 
            this.lblExplicacaoTexto.AutoSize = true;
            this.lblExplicacaoTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExplicacaoTexto.ForeColor = System.Drawing.Color.Silver;
            this.lblExplicacaoTexto.Location = new System.Drawing.Point(5, 145);
            this.lblExplicacaoTexto.Name = "lblExplicacaoTexto";
            this.lblExplicacaoTexto.Size = new System.Drawing.Size(50, 24);
            this.lblExplicacaoTexto.TabIndex = 2;
            this.lblExplicacaoTexto.Text = "label";
            this.lblExplicacaoTexto.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblPerimetro);
            this.panel3.Controls.Add(this.lblArea);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(198, 102);
            this.panel3.TabIndex = 1;
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerimetro.ForeColor = System.Drawing.Color.Silver;
            this.lblPerimetro.Location = new System.Drawing.Point(3, 62);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(110, 25);
            this.lblPerimetro.TabIndex = 1;
            this.lblPerimetro.Text = "Perímetro:";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.ForeColor = System.Drawing.Color.Silver;
            this.lblArea.Location = new System.Drawing.Point(3, 37);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(63, 25);
            this.lblArea.TabIndex = 0;
            this.lblArea.Text = "Área:";
            // 
            // lblExplicacao
            // 
            this.lblExplicacao.AutoSize = true;
            this.lblExplicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExplicacao.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblExplicacao.Location = new System.Drawing.Point(27, 114);
            this.lblExplicacao.Margin = new System.Windows.Forms.Padding(0);
            this.lblExplicacao.Name = "lblExplicacao";
            this.lblExplicacao.Size = new System.Drawing.Size(145, 31);
            this.lblExplicacao.TabIndex = 0;
            this.lblExplicacao.Text = "Explicação";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnPerimetro);
            this.panel2.Controls.Add(this.btnArea);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 443);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(734, 80);
            this.panel2.TabIndex = 5;
            // 
            // btnPerimetro
            // 
            this.btnPerimetro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnPerimetro.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPerimetro.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnPerimetro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerimetro.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerimetro.ForeColor = System.Drawing.Color.Silver;
            this.btnPerimetro.Location = new System.Drawing.Point(367, 0);
            this.btnPerimetro.Name = "btnPerimetro";
            this.btnPerimetro.Size = new System.Drawing.Size(367, 80);
            this.btnPerimetro.TabIndex = 1;
            this.btnPerimetro.Text = "Perímetro";
            this.btnPerimetro.UseVisualStyleBackColor = false;
            this.btnPerimetro.Click += new System.EventHandler(this.btnPerimetro_Click);
            // 
            // btnArea
            // 
            this.btnArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnArea.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnArea.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArea.ForeColor = System.Drawing.Color.Silver;
            this.btnArea.Location = new System.Drawing.Point(0, 0);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(367, 80);
            this.btnArea.TabIndex = 0;
            this.btnArea.Text = "Área";
            this.btnArea.UseVisualStyleBackColor = false;
            this.btnArea.Click += new System.EventHandler(this.btnArea_Click);
            // 
            // btnExibir
            // 
            this.btnExibir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnExibir.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnExibir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExibir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnExibir.ForeColor = System.Drawing.Color.Silver;
            this.btnExibir.Location = new System.Drawing.Point(657, 1);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(77, 36);
            this.btnExibir.TabIndex = 19;
            this.btnExibir.Text = "Exibir";
            this.btnExibir.UseVisualStyleBackColor = false;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // btnOcultar
            // 
            this.btnOcultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnOcultar.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnOcultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOcultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOcultar.ForeColor = System.Drawing.Color.Silver;
            this.btnOcultar.Location = new System.Drawing.Point(581, 1);
            this.btnOcultar.Name = "btnOcultar";
            this.btnOcultar.Size = new System.Drawing.Size(77, 36);
            this.btnOcultar.TabIndex = 20;
            this.btnOcultar.Text = "Ocultar";
            this.btnOcultar.UseVisualStyleBackColor = false;
            this.btnOcultar.Click += new System.EventHandler(this.btnOcultar_Click);
            // 
            // pnlExibir
            // 
            this.pnlExibir.Controls.Add(this.btnExibirAngulos);
            this.pnlExibir.Controls.Add(this.btnExibirDiametro);
            this.pnlExibir.Location = new System.Drawing.Point(657, 38);
            this.pnlExibir.Name = "pnlExibir";
            this.pnlExibir.Size = new System.Drawing.Size(77, 68);
            this.pnlExibir.TabIndex = 32;
            this.pnlExibir.Visible = false;
            // 
            // btnExibirAngulos
            // 
            this.btnExibirAngulos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnExibirAngulos.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnExibirAngulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExibirAngulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnExibirAngulos.ForeColor = System.Drawing.Color.Silver;
            this.btnExibirAngulos.Location = new System.Drawing.Point(0, 32);
            this.btnExibirAngulos.Name = "btnExibirAngulos";
            this.btnExibirAngulos.Size = new System.Drawing.Size(77, 33);
            this.btnExibirAngulos.TabIndex = 20;
            this.btnExibirAngulos.Text = "Ângulos";
            this.btnExibirAngulos.UseVisualStyleBackColor = false;
            this.btnExibirAngulos.Click += new System.EventHandler(this.btnExibirAngulos_Click);
            // 
            // btnExibirDiametro
            // 
            this.btnExibirDiametro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnExibirDiametro.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnExibirDiametro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExibirDiametro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnExibirDiametro.ForeColor = System.Drawing.Color.Silver;
            this.btnExibirDiametro.Location = new System.Drawing.Point(0, -1);
            this.btnExibirDiametro.Name = "btnExibirDiametro";
            this.btnExibirDiametro.Size = new System.Drawing.Size(77, 34);
            this.btnExibirDiametro.TabIndex = 19;
            this.btnExibirDiametro.Text = "Diâmetro";
            this.btnExibirDiametro.UseVisualStyleBackColor = false;
            this.btnExibirDiametro.Click += new System.EventHandler(this.btnExibirDiametro_Click);
            // 
            // pnlOcultar
            // 
            this.pnlOcultar.Controls.Add(this.btnOcultarAngulos);
            this.pnlOcultar.Controls.Add(this.btnOcultarDiametro);
            this.pnlOcultar.Location = new System.Drawing.Point(581, 37);
            this.pnlOcultar.Name = "pnlOcultar";
            this.pnlOcultar.Size = new System.Drawing.Size(77, 68);
            this.pnlOcultar.TabIndex = 33;
            this.pnlOcultar.Visible = false;
            // 
            // btnOcultarAngulos
            // 
            this.btnOcultarAngulos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnOcultarAngulos.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnOcultarAngulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOcultarAngulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnOcultarAngulos.ForeColor = System.Drawing.Color.Silver;
            this.btnOcultarAngulos.Location = new System.Drawing.Point(0, 32);
            this.btnOcultarAngulos.Name = "btnOcultarAngulos";
            this.btnOcultarAngulos.Size = new System.Drawing.Size(77, 34);
            this.btnOcultarAngulos.TabIndex = 20;
            this.btnOcultarAngulos.Text = "Ângulos";
            this.btnOcultarAngulos.UseVisualStyleBackColor = false;
            this.btnOcultarAngulos.Click += new System.EventHandler(this.btnOcultarAngulos_Click);
            // 
            // btnOcultarDiametro
            // 
            this.btnOcultarDiametro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnOcultarDiametro.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnOcultarDiametro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOcultarDiametro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnOcultarDiametro.ForeColor = System.Drawing.Color.Silver;
            this.btnOcultarDiametro.Location = new System.Drawing.Point(0, -1);
            this.btnOcultarDiametro.Name = "btnOcultarDiametro";
            this.btnOcultarDiametro.Size = new System.Drawing.Size(77, 34);
            this.btnOcultarDiametro.TabIndex = 19;
            this.btnOcultarDiametro.Text = "Diâmetro";
            this.btnOcultarDiametro.UseVisualStyleBackColor = false;
            this.btnOcultarDiametro.Click += new System.EventHandler(this.btnOcultarDiametro_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnLimpar.ForeColor = System.Drawing.Color.Silver;
            this.btnLimpar.Location = new System.Drawing.Point(0, 0);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(77, 36);
            this.btnLimpar.TabIndex = 34;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnDiametro
            // 
            this.btnDiametro.FlatAppearance.BorderColor = System.Drawing.Color.Magenta;
            this.btnDiametro.FlatAppearance.BorderSize = 10;
            this.btnDiametro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiametro.Location = new System.Drawing.Point(359, 198);
            this.btnDiametro.Name = "btnDiametro";
            this.btnDiametro.Size = new System.Drawing.Size(10, 36);
            this.btnDiametro.TabIndex = 38;
            this.btnDiametro.UseVisualStyleBackColor = true;
            this.btnDiametro.Click += new System.EventHandler(this.btnDiametro_Click);
            // 
            // picCircunferência
            // 
            this.picCircunferência.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picCircunferência.Image = global::prototipo4.Properties.Resources.circunferência;
            this.picCircunferência.Location = new System.Drawing.Point(0, 0);
            this.picCircunferência.Name = "picCircunferência";
            this.picCircunferência.Size = new System.Drawing.Size(734, 443);
            this.picCircunferência.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCircunferência.TabIndex = 6;
            this.picCircunferência.TabStop = false;
            // 
            // pnlDiametro
            // 
            this.pnlDiametro.Controls.Add(this.btnInserirDiametro);
            this.pnlDiametro.Location = new System.Drawing.Point(367, 152);
            this.pnlDiametro.Name = "pnlDiametro";
            this.pnlDiametro.Size = new System.Drawing.Size(149, 43);
            this.pnlDiametro.TabIndex = 39;
            this.pnlDiametro.Visible = false;
            // 
            // btnInserirDiametro
            // 
            this.btnInserirDiametro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnInserirDiametro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInserirDiametro.FlatAppearance.BorderColor = System.Drawing.Color.Fuchsia;
            this.btnInserirDiametro.FlatAppearance.BorderSize = 2;
            this.btnInserirDiametro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserirDiametro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirDiametro.ForeColor = System.Drawing.Color.Silver;
            this.btnInserirDiametro.Location = new System.Drawing.Point(0, 0);
            this.btnInserirDiametro.Name = "btnInserirDiametro";
            this.btnInserirDiametro.Size = new System.Drawing.Size(149, 42);
            this.btnInserirDiametro.TabIndex = 1;
            this.btnInserirDiametro.Text = "Inserir Info";
            this.btnInserirDiametro.UseVisualStyleBackColor = false;
            this.btnInserirDiametro.Click += new System.EventHandler(this.btnInserirDiametro_Click);
            // 
            // txtInserirDiametro
            // 
            this.txtInserirDiametro.Location = new System.Drawing.Point(499, 143);
            this.txtInserirDiametro.Name = "txtInserirDiametro";
            this.txtInserirDiametro.Size = new System.Drawing.Size(37, 20);
            this.txtInserirDiametro.TabIndex = 40;
            this.txtInserirDiametro.Visible = false;
            this.txtInserirDiametro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInserirDiametro_KeyDown);
            // 
            // lblDiametro
            // 
            this.lblDiametro.AutoSize = true;
            this.lblDiametro.BackColor = System.Drawing.Color.Transparent;
            this.lblDiametro.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiametro.ForeColor = System.Drawing.Color.Silver;
            this.lblDiametro.Location = new System.Drawing.Point(343, 164);
            this.lblDiametro.Name = "lblDiametro";
            this.lblDiametro.Size = new System.Drawing.Size(44, 31);
            this.lblDiametro.TabIndex = 41;
            this.lblDiametro.Text = "20";
            this.lblDiametro.Visible = false;
            // 
            // lblWIP
            // 
            this.lblWIP.AutoSize = true;
            this.lblWIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWIP.ForeColor = System.Drawing.Color.Silver;
            this.lblWIP.Location = new System.Drawing.Point(2, 406);
            this.lblWIP.Name = "lblWIP";
            this.lblWIP.Size = new System.Drawing.Size(77, 37);
            this.lblWIP.TabIndex = 42;
            this.lblWIP.Text = "WIP";
            // 
            // Circunferência
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.Controls.Add(this.lblWIP);
            this.Controls.Add(this.lblDiametro);
            this.Controls.Add(this.txtInserirDiametro);
            this.Controls.Add(this.pnlDiametro);
            this.Controls.Add(this.btnDiametro);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.pnlOcultar);
            this.Controls.Add(this.pnlExibir);
            this.Controls.Add(this.btnOcultar);
            this.Controls.Add(this.btnExibir);
            this.Controls.Add(this.picCircunferência);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Circunferência";
            this.Size = new System.Drawing.Size(934, 523);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pnlExibir.ResumeLayout(false);
            this.pnlOcultar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCircunferência)).EndInit();
            this.pnlDiametro.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblExplicacaoTexto;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblPerimetro;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblExplicacao;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPerimetro;
        private System.Windows.Forms.Button btnArea;
        private System.Windows.Forms.PictureBox picCircunferência;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.Button btnOcultar;
        private System.Windows.Forms.Panel pnlExibir;
        private System.Windows.Forms.Button btnExibirAngulos;
        private System.Windows.Forms.Button btnExibirDiametro;
        private System.Windows.Forms.Panel pnlOcultar;
        private System.Windows.Forms.Button btnOcultarAngulos;
        private System.Windows.Forms.Button btnOcultarDiametro;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnDiametro;
        private System.Windows.Forms.Panel pnlDiametro;
        private System.Windows.Forms.Button btnInserirDiametro;
        private System.Windows.Forms.TextBox txtInserirDiametro;
        private System.Windows.Forms.Label lblDiametro;
        private System.Windows.Forms.Label lblWIP;
    }
}
