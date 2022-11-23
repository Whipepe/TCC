namespace prototipo4
{
    partial class Quadrado
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
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnOcultar = new System.Windows.Forms.Button();
            this.btnExibir = new System.Windows.Forms.Button();
            this.lblLado4 = new System.Windows.Forms.Label();
            this.lblLado2 = new System.Windows.Forms.Label();
            this.lblLado3 = new System.Windows.Forms.Label();
            this.lblLado1 = new System.Windows.Forms.Label();
            this.btnLado = new System.Windows.Forms.Button();
            this.btnDiagonal = new System.Windows.Forms.Button();
            this.pnlBotoesLado = new System.Windows.Forms.Panel();
            this.btnInserirLado = new System.Windows.Forms.Button();
            this.btnPedirLado = new System.Windows.Forms.Button();
            this.pnlBotoesDiagonal = new System.Windows.Forms.Panel();
            this.btnInserirDiagonal = new System.Windows.Forms.Button();
            this.btnPedirDiagonal = new System.Windows.Forms.Button();
            this.txtInserirLado = new System.Windows.Forms.TextBox();
            this.txtInserirDiagonal = new System.Windows.Forms.TextBox();
            this.lblDiagonal = new System.Windows.Forms.Label();
            this.pnlExibir = new System.Windows.Forms.Panel();
            this.btnExibirAngulos = new System.Windows.Forms.Button();
            this.btnExibirDiagonal = new System.Windows.Forms.Button();
            this.pnlOcultar = new System.Windows.Forms.Panel();
            this.btnOcultarAngulos = new System.Windows.Forms.Button();
            this.btnOcultarDiagonal = new System.Windows.Forms.Button();
            this.picQuadrado = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlBotoesLado.SuspendLayout();
            this.pnlBotoesDiagonal.SuspendLayout();
            this.pnlExibir.SuspendLayout();
            this.pnlOcultar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQuadrado)).BeginInit();
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
            this.panel1.TabIndex = 3;
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
            this.panel2.TabIndex = 4;
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
            this.btnLimpar.TabIndex = 14;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
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
            this.btnOcultar.TabIndex = 19;
            this.btnOcultar.Text = "Ocultar";
            this.btnOcultar.UseVisualStyleBackColor = false;
            this.btnOcultar.Click += new System.EventHandler(this.btnOcultar_Click);
            // 
            // btnExibir
            // 
            this.btnExibir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnExibir.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnExibir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExibir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnExibir.ForeColor = System.Drawing.Color.Silver;
            this.btnExibir.Location = new System.Drawing.Point(656, 1);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(77, 36);
            this.btnExibir.TabIndex = 18;
            this.btnExibir.Text = "Exibir";
            this.btnExibir.UseVisualStyleBackColor = false;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // lblLado4
            // 
            this.lblLado4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLado4.AutoSize = true;
            this.lblLado4.BackColor = System.Drawing.Color.Transparent;
            this.lblLado4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLado4.ForeColor = System.Drawing.Color.Silver;
            this.lblLado4.Location = new System.Drawing.Point(343, 402);
            this.lblLado4.Name = "lblLado4";
            this.lblLado4.Size = new System.Drawing.Size(44, 31);
            this.lblLado4.TabIndex = 23;
            this.lblLado4.Text = "20";
            this.lblLado4.Visible = false;
            // 
            // lblLado2
            // 
            this.lblLado2.AutoSize = true;
            this.lblLado2.BackColor = System.Drawing.Color.Transparent;
            this.lblLado2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLado2.ForeColor = System.Drawing.Color.Silver;
            this.lblLado2.Location = new System.Drawing.Point(343, 9);
            this.lblLado2.Name = "lblLado2";
            this.lblLado2.Size = new System.Drawing.Size(44, 31);
            this.lblLado2.TabIndex = 22;
            this.lblLado2.Text = "20";
            this.lblLado2.Visible = false;
            // 
            // lblLado3
            // 
            this.lblLado3.AutoSize = true;
            this.lblLado3.BackColor = System.Drawing.Color.Transparent;
            this.lblLado3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLado3.ForeColor = System.Drawing.Color.Silver;
            this.lblLado3.Location = new System.Drawing.Point(562, 208);
            this.lblLado3.Name = "lblLado3";
            this.lblLado3.Size = new System.Drawing.Size(44, 31);
            this.lblLado3.TabIndex = 21;
            this.lblLado3.Text = "20";
            this.lblLado3.Visible = false;
            // 
            // lblLado1
            // 
            this.lblLado1.AutoSize = true;
            this.lblLado1.BackColor = System.Drawing.Color.Transparent;
            this.lblLado1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLado1.ForeColor = System.Drawing.Color.Silver;
            this.lblLado1.Location = new System.Drawing.Point(118, 208);
            this.lblLado1.Name = "lblLado1";
            this.lblLado1.Size = new System.Drawing.Size(44, 31);
            this.lblLado1.TabIndex = 20;
            this.lblLado1.Text = "20";
            this.lblLado1.Visible = false;
            // 
            // btnLado
            // 
            this.btnLado.FlatAppearance.BorderColor = System.Drawing.Color.Magenta;
            this.btnLado.FlatAppearance.BorderSize = 10;
            this.btnLado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLado.Location = new System.Drawing.Point(166, 220);
            this.btnLado.Name = "btnLado";
            this.btnLado.Size = new System.Drawing.Size(36, 10);
            this.btnLado.TabIndex = 24;
            this.btnLado.UseVisualStyleBackColor = true;
            this.btnLado.Click += new System.EventHandler(this.btnLado_Click);
            // 
            // btnDiagonal
            // 
            this.btnDiagonal.FlatAppearance.BorderColor = System.Drawing.Color.Magenta;
            this.btnDiagonal.FlatAppearance.BorderSize = 10;
            this.btnDiagonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiagonal.Location = new System.Drawing.Point(350, 220);
            this.btnDiagonal.Name = "btnDiagonal";
            this.btnDiagonal.Size = new System.Drawing.Size(36, 10);
            this.btnDiagonal.TabIndex = 25;
            this.btnDiagonal.UseVisualStyleBackColor = true;
            this.btnDiagonal.Visible = false;
            this.btnDiagonal.Click += new System.EventHandler(this.btnDiagonal_Click);
            // 
            // pnlBotoesLado
            // 
            this.pnlBotoesLado.Controls.Add(this.btnInserirLado);
            this.pnlBotoesLado.Controls.Add(this.btnPedirLado);
            this.pnlBotoesLado.Location = new System.Drawing.Point(195, 187);
            this.pnlBotoesLado.Name = "pnlBotoesLado";
            this.pnlBotoesLado.Size = new System.Drawing.Size(149, 90);
            this.pnlBotoesLado.TabIndex = 26;
            this.pnlBotoesLado.Visible = false;
            // 
            // btnInserirLado
            // 
            this.btnInserirLado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnInserirLado.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInserirLado.FlatAppearance.BorderColor = System.Drawing.Color.Fuchsia;
            this.btnInserirLado.FlatAppearance.BorderSize = 2;
            this.btnInserirLado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserirLado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirLado.ForeColor = System.Drawing.Color.Silver;
            this.btnInserirLado.Location = new System.Drawing.Point(0, 45);
            this.btnInserirLado.Name = "btnInserirLado";
            this.btnInserirLado.Size = new System.Drawing.Size(149, 42);
            this.btnInserirLado.TabIndex = 1;
            this.btnInserirLado.Text = "Inserir Info";
            this.btnInserirLado.UseVisualStyleBackColor = false;
            this.btnInserirLado.Click += new System.EventHandler(this.btnInserirLado_Click);
            // 
            // btnPedirLado
            // 
            this.btnPedirLado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnPedirLado.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPedirLado.FlatAppearance.BorderColor = System.Drawing.Color.Fuchsia;
            this.btnPedirLado.FlatAppearance.BorderSize = 2;
            this.btnPedirLado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedirLado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedirLado.ForeColor = System.Drawing.Color.Silver;
            this.btnPedirLado.Location = new System.Drawing.Point(0, 0);
            this.btnPedirLado.Name = "btnPedirLado";
            this.btnPedirLado.Size = new System.Drawing.Size(149, 45);
            this.btnPedirLado.TabIndex = 0;
            this.btnPedirLado.Text = "Pedir Info";
            this.btnPedirLado.UseVisualStyleBackColor = false;
            this.btnPedirLado.Click += new System.EventHandler(this.btnPedirLado_Click);
            // 
            // pnlBotoesDiagonal
            // 
            this.pnlBotoesDiagonal.Controls.Add(this.btnInserirDiagonal);
            this.pnlBotoesDiagonal.Controls.Add(this.btnPedirDiagonal);
            this.pnlBotoesDiagonal.Location = new System.Drawing.Point(282, 187);
            this.pnlBotoesDiagonal.Name = "pnlBotoesDiagonal";
            this.pnlBotoesDiagonal.Size = new System.Drawing.Size(149, 90);
            this.pnlBotoesDiagonal.TabIndex = 27;
            this.pnlBotoesDiagonal.Visible = false;
            // 
            // btnInserirDiagonal
            // 
            this.btnInserirDiagonal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnInserirDiagonal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInserirDiagonal.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnInserirDiagonal.FlatAppearance.BorderSize = 2;
            this.btnInserirDiagonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserirDiagonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirDiagonal.ForeColor = System.Drawing.Color.Silver;
            this.btnInserirDiagonal.Location = new System.Drawing.Point(0, 45);
            this.btnInserirDiagonal.Name = "btnInserirDiagonal";
            this.btnInserirDiagonal.Size = new System.Drawing.Size(149, 45);
            this.btnInserirDiagonal.TabIndex = 1;
            this.btnInserirDiagonal.Text = "Inserir Info";
            this.btnInserirDiagonal.UseVisualStyleBackColor = false;
            this.btnInserirDiagonal.Click += new System.EventHandler(this.btnInserirDiagonal_Click);
            // 
            // btnPedirDiagonal
            // 
            this.btnPedirDiagonal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnPedirDiagonal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPedirDiagonal.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnPedirDiagonal.FlatAppearance.BorderSize = 2;
            this.btnPedirDiagonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedirDiagonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedirDiagonal.ForeColor = System.Drawing.Color.Silver;
            this.btnPedirDiagonal.Location = new System.Drawing.Point(0, 0);
            this.btnPedirDiagonal.Name = "btnPedirDiagonal";
            this.btnPedirDiagonal.Size = new System.Drawing.Size(149, 45);
            this.btnPedirDiagonal.TabIndex = 0;
            this.btnPedirDiagonal.Text = "Pedir Info";
            this.btnPedirDiagonal.UseVisualStyleBackColor = false;
            this.btnPedirDiagonal.Click += new System.EventHandler(this.btnPedirDiagonal_Click);
            // 
            // txtInserirLado
            // 
            this.txtInserirLado.Location = new System.Drawing.Point(325, 220);
            this.txtInserirLado.Name = "txtInserirLado";
            this.txtInserirLado.Size = new System.Drawing.Size(37, 20);
            this.txtInserirLado.TabIndex = 29;
            this.txtInserirLado.Visible = false;
            this.txtInserirLado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInserirLado_KeyDown);
            // 
            // txtInserirDiagonal
            // 
            this.txtInserirDiagonal.Location = new System.Drawing.Point(410, 220);
            this.txtInserirDiagonal.Name = "txtInserirDiagonal";
            this.txtInserirDiagonal.Size = new System.Drawing.Size(37, 20);
            this.txtInserirDiagonal.TabIndex = 28;
            this.txtInserirDiagonal.Visible = false;
            this.txtInserirDiagonal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInserirDiagonal_KeyDown);
            // 
            // lblDiagonal
            // 
            this.lblDiagonal.AutoSize = true;
            this.lblDiagonal.BackColor = System.Drawing.Color.Transparent;
            this.lblDiagonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiagonal.ForeColor = System.Drawing.Color.Silver;
            this.lblDiagonal.Location = new System.Drawing.Point(370, 188);
            this.lblDiagonal.Name = "lblDiagonal";
            this.lblDiagonal.Size = new System.Drawing.Size(44, 31);
            this.lblDiagonal.TabIndex = 30;
            this.lblDiagonal.Text = "20";
            this.lblDiagonal.Visible = false;
            // 
            // pnlExibir
            // 
            this.pnlExibir.Controls.Add(this.btnExibirAngulos);
            this.pnlExibir.Controls.Add(this.btnExibirDiagonal);
            this.pnlExibir.Location = new System.Drawing.Point(656, 38);
            this.pnlExibir.Name = "pnlExibir";
            this.pnlExibir.Size = new System.Drawing.Size(77, 68);
            this.pnlExibir.TabIndex = 31;
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
            // btnExibirDiagonal
            // 
            this.btnExibirDiagonal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnExibirDiagonal.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnExibirDiagonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExibirDiagonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnExibirDiagonal.ForeColor = System.Drawing.Color.Silver;
            this.btnExibirDiagonal.Location = new System.Drawing.Point(0, -1);
            this.btnExibirDiagonal.Name = "btnExibirDiagonal";
            this.btnExibirDiagonal.Size = new System.Drawing.Size(77, 34);
            this.btnExibirDiagonal.TabIndex = 19;
            this.btnExibirDiagonal.Text = "Diagonal";
            this.btnExibirDiagonal.UseVisualStyleBackColor = false;
            this.btnExibirDiagonal.Click += new System.EventHandler(this.btnExibirDiagonal_Click);
            // 
            // pnlOcultar
            // 
            this.pnlOcultar.Controls.Add(this.btnOcultarAngulos);
            this.pnlOcultar.Controls.Add(this.btnOcultarDiagonal);
            this.pnlOcultar.Location = new System.Drawing.Point(581, 38);
            this.pnlOcultar.Name = "pnlOcultar";
            this.pnlOcultar.Size = new System.Drawing.Size(77, 68);
            this.pnlOcultar.TabIndex = 32;
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
            // btnOcultarDiagonal
            // 
            this.btnOcultarDiagonal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnOcultarDiagonal.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnOcultarDiagonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOcultarDiagonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnOcultarDiagonal.ForeColor = System.Drawing.Color.Silver;
            this.btnOcultarDiagonal.Location = new System.Drawing.Point(0, -1);
            this.btnOcultarDiagonal.Name = "btnOcultarDiagonal";
            this.btnOcultarDiagonal.Size = new System.Drawing.Size(77, 34);
            this.btnOcultarDiagonal.TabIndex = 19;
            this.btnOcultarDiagonal.Text = "Diagonal";
            this.btnOcultarDiagonal.UseVisualStyleBackColor = false;
            this.btnOcultarDiagonal.Click += new System.EventHandler(this.btnOcultarDiagonal_Click);
            // 
            // picQuadrado
            // 
            this.picQuadrado.Image = global::prototipo4.Properties.Resources.quadrado;
            this.picQuadrado.Location = new System.Drawing.Point(0, 0);
            this.picQuadrado.Name = "picQuadrado";
            this.picQuadrado.Size = new System.Drawing.Size(734, 443);
            this.picQuadrado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picQuadrado.TabIndex = 2;
            this.picQuadrado.TabStop = false;
            // 
            // Quadrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.Controls.Add(this.pnlOcultar);
            this.Controls.Add(this.pnlExibir);
            this.Controls.Add(this.lblDiagonal);
            this.Controls.Add(this.txtInserirLado);
            this.Controls.Add(this.txtInserirDiagonal);
            this.Controls.Add(this.pnlBotoesLado);
            this.Controls.Add(this.pnlBotoesDiagonal);
            this.Controls.Add(this.btnDiagonal);
            this.Controls.Add(this.btnLado);
            this.Controls.Add(this.lblLado4);
            this.Controls.Add(this.lblLado2);
            this.Controls.Add(this.lblLado3);
            this.Controls.Add(this.lblLado1);
            this.Controls.Add(this.btnOcultar);
            this.Controls.Add(this.btnExibir);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picQuadrado);
            this.Name = "Quadrado";
            this.Size = new System.Drawing.Size(934, 523);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pnlBotoesLado.ResumeLayout(false);
            this.pnlBotoesDiagonal.ResumeLayout(false);
            this.pnlExibir.ResumeLayout(false);
            this.pnlOcultar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picQuadrado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picQuadrado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblExplicacaoTexto;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblPerimetro;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblExplicacao;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPerimetro;
        private System.Windows.Forms.Button btnArea;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnOcultar;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.Label lblLado4;
        private System.Windows.Forms.Label lblLado2;
        private System.Windows.Forms.Label lblLado3;
        private System.Windows.Forms.Label lblLado1;
        private System.Windows.Forms.Button btnLado;
        private System.Windows.Forms.Button btnDiagonal;
        private System.Windows.Forms.Panel pnlBotoesLado;
        private System.Windows.Forms.Button btnInserirLado;
        private System.Windows.Forms.Button btnPedirLado;
        private System.Windows.Forms.Panel pnlBotoesDiagonal;
        private System.Windows.Forms.Button btnInserirDiagonal;
        private System.Windows.Forms.Button btnPedirDiagonal;
        private System.Windows.Forms.TextBox txtInserirLado;
        private System.Windows.Forms.TextBox txtInserirDiagonal;
        private System.Windows.Forms.Label lblDiagonal;
        private System.Windows.Forms.Panel pnlExibir;
        private System.Windows.Forms.Button btnExibirAngulos;
        private System.Windows.Forms.Button btnExibirDiagonal;
        private System.Windows.Forms.Panel pnlOcultar;
        private System.Windows.Forms.Button btnOcultarAngulos;
        private System.Windows.Forms.Button btnOcultarDiagonal;
    }
}
