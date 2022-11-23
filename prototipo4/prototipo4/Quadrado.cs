using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prototipo4
{
    public partial class Quadrado : UserControl
    {
        public Quadrado()
        {
            InitializeComponent();
        }

        double lado = 0;
        double diagonal = 0;
        bool diagonal_visivel = false;
        bool angulo_visivel = false;

        public double Lado
        {
            get { return this.lado; }
            set { this.lado = value; }
        }

        public double Diagonal
        {
            get { return this.diagonal; }
            set { this.diagonal = value; }
        }

        public string LblDiagonalText
        {
            get { return lblDiagonal.Text; }
            set { lblDiagonal.Text = value; }
        }
        public string LblDiagonalVisible
        {
            get { return Convert.ToString(lblDiagonal.Visible); }
            set { lblDiagonal.Visible = Convert.ToBoolean(value); }
        }

        public string PnlBotoesDiagonalVisible
        {
            get { return Convert.ToString(pnlBotoesDiagonal.Visible); }
            set { pnlBotoesDiagonal.Visible = Convert.ToBoolean(value); }
        }

        private void btnLado_Click(object sender, EventArgs e)
        {
            pnlBotoesLado.Visible = true;
            pnlBotoesLado.BringToFront();
            pnlBotoesDiagonal.Visible = false;
        }

        private void btnInserirDiagonal_Click(object sender, EventArgs e)
        {
            txtInserirDiagonal.Visible = true;
            txtInserirDiagonal.BringToFront();
        }

        private void btnPedirDiagonal_Click(object sender, EventArgs e)
        {
            if (lado != 0)
            {
                diagonal = Math.Round(lado * (Math.Sqrt(2)), 2);
                lblExplicacaoTexto.Visible = true;
                lblExplicacaoTexto.MaximumSize = new Size(200, 0);
                lblExplicacaoTexto.Text = "A diagonal de um quadrado é calculada multiplicando um de seus lados por √2, ou seja: " + lado + "√2 ≈ " + diagonal;
                lblDiagonal.Text = Convert.ToString(diagonal);
                lblDiagonal.Visible = true;
                lblDiagonal.BringToFront();
            }
            else
            {
                MessageBox.Show("Impossível calcular");
            }
            pnlBotoesDiagonal.Visible = false;
        }

        private void btnInserirLado_Click(object sender, EventArgs e)
        {
            txtInserirLado.Visible = true;
            txtInserirLado.BringToFront();
        }

        private void btnPedirLado_Click(object sender, EventArgs e)
        {
            if (diagonal != 0)
            {
                lado = Math.Round(diagonal / (Math.Sqrt(2)), 2);
                lblExplicacaoTexto.Visible = true;
                lblExplicacaoTexto.MaximumSize = new Size(200, 0);
                lblExplicacaoTexto.Text = "Se soubermos o valor da diagonal, é possível calcular o lado de um quadrado com a fórmula da diagonal (d = L√2), ou seja (L = d/√2): L= " + diagonal + "/√2 ≈ " + lado;
                lblLado1.Text = Convert.ToString(lado);
                lblLado1.Visible = true;
                lblLado1.BringToFront();
                lblLado2.Text = Convert.ToString(lado);
                lblLado2.Visible = true;
                lblLado2.BringToFront();
                lblLado3.Text = Convert.ToString(lado);
                lblLado3.Visible = true;
                lblLado3.BringToFront();
                lblLado4.Text = Convert.ToString(lado);
                lblLado4.Visible = true;
                lblLado4.BringToFront();
            }
            else
            {
                MessageBox.Show("Impossível calcular");
            }
            pnlBotoesLado.Visible = false;
        }

        private void txtInserirLado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                double.TryParse(txtInserirLado.Text, out this.lado);
                lblLado1.Text = Convert.ToString(lado);
                lblLado1.Visible = true;
                lblLado1.BringToFront();
                lblLado2.Text = Convert.ToString(lado);
                lblLado2.Visible = true;
                lblLado2.BringToFront();
                lblLado3.Text = Convert.ToString(lado);
                lblLado3.Visible = true;
                lblLado3.BringToFront();
                lblLado4.Text = Convert.ToString(lado);
                lblLado4.Visible = true;
                lblLado4.BringToFront();
                pnlBotoesLado.Visible = false;
                txtInserirLado.Visible = false;

            }
        }

        private void txtInserirDiagonal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                double.TryParse(txtInserirDiagonal.Text, out this.diagonal);
                lblDiagonal.Text = Convert.ToString(diagonal);
                lblDiagonal.Visible = true;
                lblDiagonal.BringToFront();
                pnlBotoesDiagonal.Visible = false;
                txtInserirDiagonal.Visible = false;
            }
        }

        private void btnDiagonal_Click(object sender, EventArgs e)
        {
            pnlBotoesDiagonal.Visible = true;
            pnlBotoesDiagonal.BringToFront();
            pnlBotoesLado.Visible = false;
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            if (this.lado != 0)
            {
                lblArea.Text = "Área: " + Convert.ToString(Math.Pow(lado,2));
                lblExplicacaoTexto.Visible = true;
                lblExplicacaoTexto.MaximumSize = new Size(200, 0);
                lblExplicacaoTexto.Text = "A área de um quadrado é calculada multiplicando dois de seus lados, ou seja: " + Convert.ToString(this.lado) + "².";
            }
            else
            {
                MessageBox.Show("Impossível calcular");
            }
        }

        private void btnPerimetro_Click(object sender, EventArgs e)
        {
            if (this.lado != 0)
            {
                lblPerimetro.Text = "Perímetro: " + Convert.ToString(this.lado * 4);
                lblExplicacaoTexto.Visible = true;
                lblExplicacaoTexto.MaximumSize = new Size(200, 0);
                lblExplicacaoTexto.Text = "O perímetro de um quadrado é calculado somando todos seus lados, ou seja: " + Convert.ToString(this.lado) + "x4";
            }
            else
            {
                MessageBox.Show("Impossível calcular");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            this.lado = 0;
            this.diagonal = 0;
            this.diagonal_visivel = false;
            this.angulo_visivel = false;
            lblLado1.Visible = false;
            lblLado2.Visible = false;
            lblLado3.Visible = false;
            lblLado4.Visible = false;
            lblDiagonal.Visible = false;
            picQuadrado.Load("quadrado.png");
        }

        private void btnOcultar_Click(object sender, EventArgs e)
        {
            pnlExibir.Visible = false;
            pnlOcultar.Visible = true;
            pnlOcultar.BringToFront();
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            pnlOcultar.Visible = false;
            pnlExibir.Visible = true;
            pnlExibir.BringToFront();
        }

        private void btnExibirDiagonal_Click(object sender, EventArgs e)
        {
            diagonal_visivel = true;
            if (angulo_visivel == false)
            {
                picQuadrado.Load("quadrado_altura.png");
            }
            else if (angulo_visivel == true)
            {
                picQuadrado.Load("quadrado_altura_angulos.png");
            }
            btnDiagonal.Visible = true;
        }

        private void btnExibirAngulos_Click(object sender, EventArgs e)
        {
            angulo_visivel = true;
            if (diagonal_visivel == false)
            {
                picQuadrado.Load("quadrado_angulos.png");
            }
            else if (diagonal_visivel == true)
            {
                picQuadrado.Load("quadrado_altura_angulos.png");
            }
        }

        private void btnOcultarDiagonal_Click(object sender, EventArgs e)
        {
            diagonal_visivel = false;
            if (angulo_visivel == false)
            {
                picQuadrado.Load("quadrado.png");
            }
            else if (angulo_visivel == true)
            {
                picQuadrado.Load("quadrado_angulos.png");
            }
            btnDiagonal.Visible = false;
            lblDiagonal.Visible = false;
        }

        private void btnOcultarAngulos_Click(object sender, EventArgs e)
        {
            angulo_visivel = false;
            if (diagonal_visivel == false)
            {
                picQuadrado.Load("quadrado.png");
            }
            else if (diagonal_visivel == true)
            {
                picQuadrado.Load("quadrado_altura.png");
            }
        }
    }
}
