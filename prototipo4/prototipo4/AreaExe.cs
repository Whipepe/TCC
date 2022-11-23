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
    public partial class AreaExe : UserControl
    {
        public AreaExe()
        {
            InitializeComponent();
            Quadrado quadrado = new Quadrado();
            addUserControl(quadrado);
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnlImagemGeral.Controls.Clear();
            pnlImagemGeral.Controls.Add(userControl);
            userControl.BringToFront();
        }

        string tipo_trapezio = "Trapézio";
        string tipo_triangulo = "Triângulo";

        public string TipoTrapezio
        {
            get { return tipo_trapezio; }
            set { tipo_trapezio = value; }
        }

        public string TipoTriangulo
        {
            get { return tipo_triangulo; }
            set { tipo_triangulo = value; }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Quadrado quadrado = new Quadrado();
            addUserControl(quadrado);
            lblImagem.Text = "Quadrado";
            lblImagem.AutoSize = false;
            lblImagem.TextAlign = ContentAlignment.MiddleCenter;
            lblImagem.Dock = DockStyle.Fill;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Trapézio trapézio = new Trapézio();
            addUserControl(trapézio);
            if (trapézio.Tipo == 0)
            {
                lblImagem.Text = "Trapézio";
                lblImagem.AutoSize = false;
                lblImagem.TextAlign = ContentAlignment.MiddleCenter;
                lblImagem.Dock = DockStyle.Fill;
            }
            if (trapézio.Tipo == 1)
            {
                lblImagem.Text = "Trapézio";
                lblImagem.AutoSize = false;
                lblImagem.TextAlign = ContentAlignment.MiddleCenter;
                lblImagem.Dock = DockStyle.Fill;
            }
            else if (trapézio.Tipo == 2)
            {
                lblImagem.Text = "Trapézio Escaleno";
                lblImagem.AutoSize = false;
                lblImagem.TextAlign = ContentAlignment.MiddleCenter;
                lblImagem.Dock = DockStyle.Fill;
            }
            else if (trapézio.Tipo == 3)
            {
                lblImagem.Text = "Trapézio Retângulo";
                lblImagem.AutoSize = false;
                lblImagem.TextAlign = ContentAlignment.MiddleCenter;
                lblImagem.Dock = DockStyle.Fill;
            }
        }

        private void picCircunferência_Click(object sender, EventArgs e)
        {
            Circunferência circunferência = new Circunferência();
            addUserControl(circunferência);
            lblImagem.Text = "Circunferência";
            lblImagem.AutoSize = false;
            lblImagem.TextAlign = ContentAlignment.MiddleCenter;
            lblImagem.Dock = DockStyle.Fill;
        }

        private void picTriângulo_Click(object sender, EventArgs e)
        {
            Triângulo triângulo = new Triângulo();
            addUserControl(triângulo);
            lblImagem.Text = "Triângulo";
            lblImagem.AutoSize = false;
            lblImagem.TextAlign = ContentAlignment.MiddleCenter;
            lblImagem.Dock = DockStyle.Fill;
        }
    }
}
