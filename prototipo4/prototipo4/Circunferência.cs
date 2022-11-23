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
    public partial class Circunferência : UserControl
    {
        public Circunferência()
        {
            InitializeComponent();
        }

        double diametro = 0;
        bool diametro_visivel = false;

        private void btnDiametro_Click(object sender, EventArgs e)
        {
            pnlDiametro.Visible = true;
            pnlDiametro.BringToFront();
        }

        private void btnInserirDiametro_Click(object sender, EventArgs e)
        {
            txtInserirDiametro.Visible = true;
            txtInserirDiametro.BringToFront();
        }

        private void txtInserirDiametro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                diametro = Convert.ToDouble(txtInserirDiametro.Text);
                lblDiametro.Visible = true;
                lblDiametro.BringToFront();
                lblDiametro.Text = Convert.ToString(diametro);
                pnlDiametro.Visible = false;
                txtInserirDiametro.Visible = false;
            }
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            pnlOcultar.Visible = false;
            pnlExibir.Visible = true;
            pnlExibir.BringToFront();
        }

        private void btnExibirDiametro_Click(object sender, EventArgs e)
        {
            diametro_visivel = true;
            picCircunferência.Load("circunferência_diametro.png");
            btnDiametro.Visible = true;
            btnDiametro.BringToFront();
        }

        private void btnOcultar_Click(object sender, EventArgs e)
        {
            pnlExibir.Visible = false;
            pnlOcultar.Visible = true;
            pnlOcultar.BringToFront();
        }

        private void btnOcultarDiametro_Click(object sender, EventArgs e)
        {
            diametro_visivel = false;
            picCircunferência.Load("circunferência.png");
            btnDiametro.Visible = false;
            lblDiametro.Visible = false;
        }

        private void btnExibirAngulos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Indisponível no momento.");
        }

        private void btnOcultarAngulos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Os ângulos não estão visíveis");
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            lblArea.Text = "Área: " + Convert.ToString(Math.Round(Math.PI * Math.Pow(diametro/2,2),2));
            lblExplicacaoTexto.Visible = true;
            lblExplicacaoTexto.MaximumSize = new Size(200, 0);
            lblExplicacaoTexto.Text = "A área de uma circunferência é calculada da seguinte forma: πR², ou seja: π * " + Convert.ToString(diametro/2) + "² ≅ " + Convert.ToString(Math.Round(Math.PI * Math.Pow(diametro / 2, 2), 2));
        }

        private void btnPerimetro_Click(object sender, EventArgs e)
        {
            lblPerimetro.Text = "Perímetro: " + Convert.ToString(2 * Math.PI * (diametro/2));
            lblExplicacaoTexto.Visible = true;
            lblExplicacaoTexto.MaximumSize = new Size(200, 0);
            lblExplicacaoTexto.Text = "O perímetro de uma circunferência é calculado da seguinte forma: 2πR, ou seja: 2 * π * " + Convert.ToString(diametro / 2) + " ≅ " + Convert.ToString(Math.Round(2 * Math.PI * (diametro / 2),2));
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            diametro = 0;
            lblDiametro.Visible = false;
            lblArea.Text = "Área: ";
            lblPerimetro.Text = "Perímetro: ";
            lblExplicacaoTexto.Visible = false;
        }
    }
}
