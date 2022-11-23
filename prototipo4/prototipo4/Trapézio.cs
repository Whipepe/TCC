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
    public partial class Trapézio : UserControl
    {
        public Trapézio()
        {
            InitializeComponent();
        }

        double lado1 = 0;
        double lado2 = 0;
        double baseMaior = 0;
        double baseMenor = 0;
        double basetri1 = 0;
        double basetri2 = 0;
        double altura = 0;
        double angulo1 = 0;
        double angulo2 = 0;
        double angulo3 = 0;
        double angulo4 = 0;
        bool altura_visivel, angulo_visivel, divisao_visivel = false;
        int tipo = 1; //1 = isóceles | 2 = escaleno | 3 = retângulo

        public int Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        private void btnLado1_Click(object sender, EventArgs e)
        {
            pnlBotoesLado1.Visible = true;
            pnlBotoesLado1.BringToFront();
        }

        private void btnPedirLado1_Click(object sender, EventArgs e)
        {
            TipoTrapézio();
            //calcular lado1
            if (tipo == 1)
            {
                if (basetri1 != 0 && altura != 0)
                {
                    lado1 = Math.Sqrt(Math.Pow(altura, 2) + Math.Pow(basetri1, 2));
                    //lado1 = (altura² + basetri1²)^1/2
                }
                else if (basetri2 != 0 && altura != 0)
                {
                    lado1 = Math.Sqrt(Math.Pow(altura, 2) + Math.Pow(basetri2, 2));
                    //lado1 = (altura² + basetri1²)^1/2
                }
                else if (angulo1 != 0 && altura != 0)
                {
                    //cosangulo1 = altura/lado1 -> cosangulo1*lado1 = altura -> lado1 = altura/cosangulo1
                    lado1 = altura / ((Math.Round(Math.Cos((angulo1 - 90) * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2));
                }
                else if (angulo2 != 0 && altura != 0)
                {
                    //cosangulo1 = altura/lado1 -> cosangulo1*lado1 = altura -> lado1 = altura/cosangulo1
                    lado1 = altura / ((Math.Round(Math.Cos((angulo2 - 90) * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2));
                }
                else if (angulo1 != 0 && basetri1 != 0)
                {
                    //senangulo1 = basetri1/lado1 -> senangulo1*lado1 = basetri1 -> lado1 = basetri1/senangulo1
                    lado1 = basetri1 / ((Math.Round(Math.Sin((angulo1 - 90) * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2));
                }
                else if (angulo1 != 0 && basetri2 != 0)
                {
                    //senangulo1 = basetri1/lado1 -> senangulo1*lado1 = basetri1 -> lado1 = basetri1/senangulo1
                    lado1 = basetri2 / ((Math.Round(Math.Sin((angulo1 - 90) * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2));
                }
                else if (angulo2 != 0 && basetri2 != 0)
                {
                    //senangulo1 = basetri1/lado1 -> senangulo1*lado1 = basetri1 -> lado1 = basetri1/senangulo1
                    lado1 = basetri2 / ((Math.Round(Math.Sin((angulo2 - 90) * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2));
                }
                else if (angulo2 != 0 && basetri1 != 0)
                {
                    //senangulo1 = basetri1/lado1 -> senangulo1*lado1 = basetri1 -> lado1 = basetri1/senangulo1
                    lado1 = basetri1 / ((Math.Round(Math.Sin((angulo2 - 90) * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2));
                }
                else if (angulo4 != 0 && altura != 0)
                {
                    //senangulo4 = altura/lado1
                    lado1 = altura / ((Math.Round(Math.Sin(angulo4 * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2));
                }
                else if (angulo3 != 0 && altura != 0)
                {
                    //senangulo4 = altura/lado1
                    lado1 = altura / ((Math.Round(Math.Sin(angulo3 * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2));
                }
                else if (angulo4 != 0 && basetri1 != 0)
                {
                    //cosangulo4 = basetri1/lado1
                    lado1 = basetri1 / ((Math.Round(Math.Cos(angulo4 * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2));
                }
                else if (angulo3 != 0 && basetri2 != 0)
                {
                    //cosangulo4 = basetri1/lado1
                    lado1 = basetri1 / ((Math.Round(Math.Cos(angulo3 * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2));
                }
            }
            //escaleno
            else if (tipo == 2)
            {
                //se tiver basetri1 e altura -> pitágoras
                if (basetri1 != 0 && altura != 0)
                {
                    lado1 = Math.Sqrt(Math.Pow(altura, 2) + Math.Pow(basetri1, 2));
                    //lado1 = (altura² + basetri1²)^1/2
                }
                else if (angulo1 != 0 && altura != 0)
                {
                    //cosangulo1 = altura/lado1 -> cosangulo1*lado1 = altura -> lado1 = altura/cosangulo1
                    lado1 = altura / ((Math.Round(Math.Cos((angulo1 - 90) * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2));
                }
                else if (angulo1 != 0 && basetri1 != 0)
                {
                    //senangulo1 = basetri1/lado1 -> senangulo1*lado1 = basetri1 -> lado1 = basetri1/senangulo1
                    lado1 = basetri1 / ((Math.Round(Math.Sin((angulo1 - 90) * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2));
                }
                else if (angulo4 != 0 && altura != 0)
                {
                    //senangulo4 = altura/lado1
                    lado1 = altura / ((Math.Round(Math.Sin(angulo4 * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2));
                }
                else if (angulo4 != 0 && basetri1 != 0)
                {
                    //cosangulo4 = basetri1/lado1 -> cosangulo4 * lado1 = basetri1 -> lado1 = basetri1/cosangulo4
                    lado1 = basetri1 / ((Math.Round(Math.Cos(angulo4 * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2));
                }

            }
            //retângulo
            else
            {
                if (basetri2 != 0 && lado2 != 0)
                {
                    //lado2² = basetri2² + altura² -> lado2² - altura² = basetri2² -> -altura² = basetri2² - lado2² -> altura² = lado2² - basetri2²
                    altura = Math.Pow(lado2,2) - Math.Pow(basetri2,2);
                }
                else if (angulo2 == 0 && lado2 != 0)
                {
                    //cosangulo3 = altura/lado2 -> cosangulo3*lado2 = altura
                    altura = (Math.Round(Math.Cos((angulo4 - 90) * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2) * lado2;
                }
                else if (angulo2 != 0 && basetri2 != 0)
                {
                    //tgangulo2 = basetri2/altura -> tgangulo2 * altura = basetri2 -> altura = basetri2/tgangulo2
                    altura = basetri2/ (Math.Round(Math.Tan((angulo2 - 90) * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2);
                }
                else if (angulo3 != 0 && lado2 != 0)
                {
                    //senangulo3 = altura/lado2 -> senangulo3*lado2 = altura
                    altura = (Math.Round(Math.Sin(angulo3 * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2) * lado2;
                }
                else if (angulo3 != 0 && basetri2 != 0)
                {
                    //tgangulo3 = altura/basetri2 -> altura = tgangulo3*basetri2
                    altura = (Math.Round(Math.Tan(angulo3 * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2 * basetri2);
                }
                
                if (altura != 0)
                {
                    lado1 = altura;
                }
            }

            if (lado1 != 0)
            {
                lblLado1.Text = Convert.ToString(Math.Round(lado1,2));
                lblLado1.Visible = true;
                lblExplicacaoTexto.Visible = true;
                lblExplicacaoTexto.MaximumSize = new Size(200, 0);
                lblExplicacaoTexto.Text = "Explicação não disponível no momento.";
                pnlBotoesLado1.Visible = false;
            }
            else
            {
                MessageBox.Show("Impossível calcular.");
                pnlBotoesLado1.Visible = false;
            }
        }


        private void btnInserirLado1_Click(object sender, EventArgs e)
        {

            txtInserirLado1.Visible = true;
            txtInserirLado1.BringToFront();
        }

        private void txtInserirLado1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.lado1 = Convert.ToDouble(txtInserirLado1.Text);
                lblLado1.Text = Convert.ToString(Math.Round(this.lado1,2));
                lblLado1.Visible = true;
                lblLado1.BringToFront();
                pnlBotoesLado1.Visible = false;
                txtInserirLado1.Visible = false;
                TipoTrapézio();
            }
        }

        private void btnLado2_Click(object sender, EventArgs e)
        {
            pnlBotoesLado2.Visible = true;
            pnlBotoesLado2.BringToFront();
        }

        private void btnPedirLado2_Click(object sender, EventArgs e)
        {
            TipoTrapézio();
            //calcular lado2
            if (tipo == 1)
            {
                if (basetri2 != 0 && altura != 0)
                {
                    lado2 = Math.Sqrt(Math.Pow(altura, 2) + Math.Pow(basetri2, 2));
                    //lado2 = (altura² + basetri2²)^1/2
                }
                if (basetri1 != 0 && altura != 0)
                {
                    lado2 = Math.Sqrt(Math.Pow(altura, 2) + Math.Pow(basetri1, 2));
                    //lado2 = (altura² + basetri2²)^1/2
                }
                else if (angulo2 != 0 && altura != 0)
                {
                    //cosangulo2 = altura/lado2 -> cosangulo2*lado2 = altura -> lado2 = altura/cosangulo2
                    lado2 = altura / ((Math.Round(Math.Cos((angulo2 - 90) * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2));
                }
                else if (angulo1 != 0 && altura != 0)
                {
                    //cosangulo2 = altura/lado2 -> cosangulo2*lado2 = altura -> lado2 = altura/cosangulo2
                    lado2 = altura / ((Math.Round(Math.Cos((angulo1 - 90) * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2));
                }
                else if (angulo2 != 0 && basetri2 != 0)
                {
                    //senangulo2 = basetri1/lado2 -> senangulo2*lado2 = basetri2 -> lado2 = basetri2/senangulo2
                    lado2 = basetri2 / ((Math.Round(Math.Sin((angulo2 - 90) * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2));
                }
                else if (angulo1 != 0 && basetri1 != 0)
                {
                    //senangulo2 = basetri1/lado2 -> senangulo2*lado2 = basetri2 -> lado2 = basetri2/senangulo2
                    lado2 = basetri1 / ((Math.Round(Math.Sin((angulo1 - 90) * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2));
                }
                else if (angulo3 != 0 && altura != 0)
                {
                    //senangulo3 = altura/lado1
                    lado2 = altura / ((Math.Round(Math.Sin(angulo3 * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2));
                }
                else if (angulo4 != 0 && altura != 0)
                {
                    //senangulo3 = altura/lado1
                    lado2 = altura / ((Math.Round(Math.Sin(angulo4 * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2));
                }
                else if (angulo3 != 0 && basetri2 != 0)
                {
                    //cosangulo3 = basetri2/lado2
                    lado2 = basetri2 / ((Math.Round(Math.Cos(angulo3 * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2));
                }
                else if (angulo4 != 0 && basetri1 != 0)
                {
                    //cosangulo3 = basetri2/lado2
                    lado2 = basetri1 / ((Math.Round(Math.Cos(angulo4 * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2));
                }
            }
            //escaleno
            else if (tipo == 2)
            {
                //se tiver basetri1 e altura -> pitágoras
                if (basetri2 != 0 && altura != 0)
                {
                    lado1 = Math.Sqrt(Math.Pow(altura, 2) + Math.Pow(basetri2, 2));
                    //lado1 = (altura² + basetri1²)^1/2
                }
                else if (angulo2 != 0 && altura != 0)
                {
                    //cosangulo1 = altura/lado1 -> cosangulo1*lado1 = altura -> lado1 = altura/cosangulo1
                    lado1 = altura / ((Math.Round(Math.Cos((angulo2 - 90) * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2));
                }
                else if (angulo2 != 0 && basetri2 != 0)
                {
                    //senangulo1 = basetri1/lado1 -> senangulo1*lado1 = basetri1 -> lado1 = basetri1/senangulo1
                    lado1 = basetri1 / ((Math.Round(Math.Sin((angulo1 - 90) * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2));
                }
                else if (angulo3 != 0 && altura != 0)
                {
                    //senangulo4 = altura/lado1
                    lado1 = altura / ((Math.Round(Math.Sin(angulo3 * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2));
                }
                else if (angulo3 != 0 && basetri2 != 0)
                {
                    //cosangulo4 = basetri1/lado1 -> cosangulo4 * lado1 = basetri1 -> lado1 = basetri1/cosangulo4
                    lado1 = basetri2 / ((Math.Round(Math.Cos(angulo3 * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2));
                }
            }
            //retângulo
            else
            {
                if (basetri2 != 0 && (altura != 0 || lado1 != 0))
                {
                    //lado2² = altura² + basetri2²
                    if (altura != 0)
                    {
                        lado2 = Math.Sqrt(Math.Pow(altura, 2) + Math.Pow(basetri2, 2));
                    }
                    else if (lado1 != 0)
                    {
                        lado2 = Math.Sqrt(Math.Pow(lado1, 2) + Math.Pow(basetri2, 2));
                    }
                }
                 else if (angulo2 != 0 && basetri2 != 0)
                {
                    //senangulo2 = basetri2/lado2 -> senangulo2 * lado2 = basetri2 -> lado2 = basetri2/senangulo2
                    lado2 = basetri2 / ((Math.Round(Math.Sin((angulo1 - 90) * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2));
                }
                else if (angulo2 != 0 && (altura != 0 || lado1 != 0))
                {
                    //cosangulo2 = altura/lado2 -> cosangulo2 * lado2 = altura -> lado2 = altura/cosangulo2
                    if (altura != 0)
                    {
                        lado2 = altura / (Math.Round(Math.Cos((angulo2 - 90) * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2);
                    }
                    else if (lado1 != 0)
                    {
                        lado2 = lado1 / Math.Cos(angulo2 - 90);
                    }
                }
                else if (angulo3 != 0 && basetri2 != 0)
                {
                    //cosangulo3 = basetri2/lado2 -> cosangulo3 * lado2 = basetri2 -> lado2 = basetri2/cosangulo3
                    lado2 = basetri2 / (Math.Round(Math.Cos(angulo3 * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2);
                }
                else if (angulo3 != 0 && (altura != 0 || lado1 != 0))
                {
                    //senangulo3 = altura/lado2 -> senangulo3 * lado2 = altura ->lado2 = altura/senangulo3
                    if (altura != 0)
                    {
                        lado2 = altura / (Math.Round(Math.Sin(angulo3 * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2);
                    }
                    else if (lado1 != 0)
                    {
                        lado2 = lado1 / (Math.Round(Math.Sin(angulo3 * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2);
                    }
                }

            }

            if (lado2 != 0)
            {
                lblLado2.Text = Convert.ToString(Math.Round(lado2,2));
                lblLado2.Visible = true;
                lblExplicacaoTexto.Visible = true;
                lblExplicacaoTexto.MaximumSize = new Size(200, 0);
                lblExplicacaoTexto.Text = "Explicação não disponível no momento.";
                pnlBotoesLado2.Visible = false;
            }
            else
            {
                MessageBox.Show("Impossível calcular.");
                pnlBotoesLado2.Visible = false;
            }
        }

        private void btnInserirLado2_Click(object sender, EventArgs e)
        {
            txtInserirLado2.Visible = true;
            txtInserirLado2.BringToFront();
        }

        private void txtInserirLado2_KeyDown(object sender, KeyEventArgs e)
        {
                if (e.KeyCode == Keys.Enter)
                {
                    this.lado2 = Convert.ToDouble(txtInserirLado2.Text);
                    lblLado2.Text = Convert.ToString(Math.Round(this.lado2,2));
                    lblLado2.Visible = true;
                    lblLado2.BringToFront();
                    pnlBotoesLado2.Visible = false;
                    txtInserirLado2.Visible = false;
                    TipoTrapézio();
                }
        }

        // baseMenor
        private void btnBaseMenor_Click(object sender, EventArgs e)
        {
            pnlBotoesBaseMenor.Visible = true;
            pnlBotoesBaseMenor.BringToFront();
        }

        private void btnPedirBaseMenor_Click(object sender, EventArgs e)
        {
            TipoTrapézio();
            //calcular baseMenor
            if (tipo == 1)
            {
                if (baseMaior != 0 && basetri1 != 0)
                {
                    baseMenor = baseMaior - (basetri1 * 2);
                }
                else if (baseMaior != 0 && basetri2 != 0)
                {
                    baseMenor = baseMaior - (basetri2 * 2);
                }
            }
            //escaleno
            else if (tipo == 2)
            {
                if (baseMaior != 0 && basetri1 != 0 && basetri2 != 0)
                {
                    baseMenor = baseMaior - basetri1 - basetri2;
                }
            }
            //retângulo
            else
            {
                if (baseMaior != 0 && basetri2 != 0)
                {
                    baseMenor = baseMaior - basetri2;
                }
            }

            if (baseMenor != 0)
            {
                lblBaseMenor.Text = Convert.ToString(Math.Round(baseMenor,2));
                lblBaseMenor.Visible = true;
                lblExplicacaoTexto.Visible = true;
                lblExplicacaoTexto.MaximumSize = new Size(200, 0);
                lblExplicacaoTexto.Text = "Explicação não disponível no momento.";
                pnlBotoesBaseMenor.Visible = false;
            }
            else
            {
                MessageBox.Show("Impossível calcular.");
                pnlBotoesBaseMenor.Visible = false;
            }
        }

        private void btnInserirBaseMenor_Click(object sender, EventArgs e)
        {
            txtInserirBaseMenor.Visible = true;
            txtInserirBaseMenor.BringToFront();
        }
        private void txtInserirBaseMenor_KeyDown(object sender, KeyEventArgs e)
        {       
            if (e.KeyCode == Keys.Enter)     
            { 
                    this.baseMenor = Convert.ToDouble(txtInserirBaseMenor.Text);

                if (baseMaior != 0 && baseMenor < baseMaior)
                {
                    lblBaseMenor.Text = Convert.ToString(Math.Round(this.baseMenor,2));
                    lblBaseMenor.Visible = true;
                    lblBaseMenor.BringToFront();
                    pnlBotoesBaseMenor.Visible = false;
                    txtInserirBaseMenor.Visible = false;
                    TipoTrapézio();
                }
                else if (baseMaior == 0)
                {
                    lblBaseMenor.Text = Convert.ToString(Math.Round(this.baseMenor,2));
                    lblBaseMenor.Visible = true;
                    lblBaseMenor.BringToFront();
                    pnlBotoesBaseMenor.Visible = false;
                    txtInserirBaseMenor.Visible = false;
                    TipoTrapézio();
                }
                else
                {
                    MessageBox.Show("A base menor não pode ser menor que a base maior");
                }
            }
        }

        private void btnBaseMaior_Click(object sender, EventArgs e)
        {
            pnlBotoesBaseMaior.Visible = true;
            pnlBotoesBaseMaior.BringToFront();
        }
        private void btnPedirBaseMaior_Click(object sender, EventArgs e)
        {
            TipoTrapézio();
            //calcular baseMaior
            if (tipo == 1)
            {
                if (baseMenor != 0 && basetri1 != 0)
                {
                    baseMaior = baseMenor + (basetri1*2);
                }
                else if (baseMenor != 0 && basetri2 != 0)
                {
                    baseMaior = baseMenor + (basetri2 * 2);
                }
            }
            //escaleno
            else if (tipo == 2)
            {
                if (baseMenor != 0 && basetri1 != 0 && basetri2 != 0)
                {
                    baseMaior = baseMenor + basetri1 + basetri2;
                }
            }
            //retângulo
            else
            {
                if (baseMenor != 0 && basetri2 != 0)
                {
                    baseMaior = baseMenor + basetri2;
                }
            }

            if (baseMaior != 0)
            {
                lblBaseMaior.Text = Convert.ToString(Math.Round(baseMaior,2));
                lblBaseMaior.Visible = true;
                lblExplicacaoTexto.Visible = true;
                lblExplicacaoTexto.MaximumSize = new Size(200, 0);
                lblExplicacaoTexto.Text = "Explicação não disponível no momento.";
                pnlBotoesBaseMaior.Visible = false;
            }
            else
            {
                MessageBox.Show("Impossível calcular.");
                pnlBotoesBaseMaior.Visible = false;
            }
        }

        private void btnInserirBaseMaior_Click(object sender, EventArgs e)
        {
            txtInserirBaseMaior.Visible = true;
            txtInserirBaseMaior.BringToFront();
        }

        private void txtInserirBaseMaior_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.baseMaior = Convert.ToDouble(txtInserirBaseMaior.Text);
                if (baseMenor != 0 && baseMaior > baseMenor)
                {
                    lblBaseMaior.Text = Convert.ToString(Math.Round(this.baseMaior,2));
                    lblBaseMaior.Visible = true;
                    lblBaseMaior.BringToFront();
                    pnlBotoesBaseMaior.Visible = false;
                    txtInserirBaseMaior.Visible = false;
                    TipoTrapézio();
                }
                else if (baseMenor == 0)
                {
                    lblBaseMaior.Text = Convert.ToString(Math.Round(this.baseMaior,2));
                    lblBaseMaior.Visible = true;
                    lblBaseMaior.BringToFront();
                    pnlBotoesBaseMaior.Visible = false;
                    txtInserirBaseMaior.Visible = false;
                    TipoTrapézio();
                }

                else
                {
                    MessageBox.Show("A base maior não pode ser menor que a base menor.");
                }
            }
        }

        private void btnAltura_Click(object sender, EventArgs e)
        {
            pnlBotoesAltura.Visible = true;
            pnlBotoesAltura.BringToFront();
        }

        private void btnPedirAltura_Click(object sender, EventArgs e)
        {
            TipoTrapézio();
            //calcular altura

            //isósceles
            if (tipo == 1)
            {
                if (lado1 != 0 && lado2 != 0 && baseMaior != 0 && baseMenor != 0)
                {
                    basetri1 = (Math.Pow(lado1, 2) + ((Math.Pow(baseMaior - baseMenor, 2)) - Math.Pow(lado2, 2))) / (2 * (baseMaior - baseMenor));

                    basetri2 = baseMaior - baseMenor - basetri1;

                    altura = Math.Sqrt((Math.Pow(lado1, 2) - Math.Pow(basetri1, 2)));

                    if (divisao_visivel == true)
                    {
                        lblBasetri1.Visible = true;
                        lblBasetri1.Text = Convert.ToString(Math.Round(basetri1,2));
                        lblBasetri1.BringToFront();
                        lblBasetri2.Visible = true;
                        lblBasetri2.Text = Convert.ToString(Math.Round(basetri2,2));
                        lblBasetri2.BringToFront();
                    }

                }
                if (basetri1 != 0 && lado1 !=0)
                {
                    //lado1² = basetri² + altura² -> lado1² - basetri1² = altura² -> altura = (lado1² - basetri1²)^1/2
                    altura = Math.Sqrt(Math.Pow(lado1,2) - Math.Pow(basetri1,2));
                }
                else if (basetri2 != 0 && lado2 != 0)
                {
                    //lado1² = basetri² + altura² -> lado1² - basetri1² = altura² -> altura = (lado1² - basetri1²)^1/2
                    altura = Math.Sqrt(Math.Pow(lado2, 2) - Math.Pow(basetri2, 2));
                }
                else if (angulo1 !=0 && basetri1 != 0)
                {
                    //tanangulo1 = basetri1/altura -> tanangulo1*altura = basetri1 -> altura = basetri1/tanangulo1
                    altura = (basetri1 / (Math.Round(Math.Tan((angulo1 - 90) * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2));
                }
                else if (angulo2 != 0 && basetri2 != 0)
                {
                    //tanangulo1 = basetri1/altura -> tanangulo1*altura = basetri1 -> altura = basetri1/tanangulo1
                    altura = (basetri2 / (Math.Round(Math.Tan((angulo2 - 90) * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2));
                }
                else if (angulo1 !=0 && lado1 != 0)
                {
                    //cosangulo1 = altura/lado1 -> altura = cosangulo1 * lado1
                    altura = (Math.Round(Math.Cos((angulo1 - 90) * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2) * lado1;
                }
                else if (angulo2 != 0 && lado2 != 0)
                {
                    //cosangulo1 = altura/lado1 -> altura = cosangulo1 * lado1
                    altura = (Math.Round(Math.Cos((angulo2 - 90) * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2) * lado2;
                }
                else if (angulo4 != 0 && basetri1 != 0)
                {
                    //tanangulo4 = altura/basetri1 -> altura = tanangulo4*basetri1
                    altura = (Math.Round(Math.Tan(angulo4 * Math.PI/180) * 2, MidpointRounding.AwayFromZero)/2) * basetri1;
                }
                else if (angulo3 != 0 && basetri2 != 0)
                {
                    //tanangulo4 = altura/basetri1 -> altura = tanangulo4*basetri1
                    altura = (Math.Round(Math.Tan((angulo3 - 90) * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2) * basetri2;
                }
                else if (angulo4 !=0 && lado1 != 0)
                {
                    //senangulo4 = altura/lado1 -> altura = senangulo4 * lado1
                    altura = (Math.Round(Math.Sin(angulo4 * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2) * lado1;
                }
                else if (angulo3 != 0 && lado2 != 0)
                {
                    //senangulo4 = altura/lado1 -> altura = senangulo4 * lado1
                    altura = (Math.Round(Math.Sin(angulo3 * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2) * lado2;
                }
            }
            //escaleno
            else if (tipo == 2)
            {
                if (lado1 != 0 && lado2 != 0 && baseMaior != 0 && baseMenor != 0)
                {
                    basetri1 = (Math.Pow(lado1, 2) + ((Math.Pow(baseMaior - baseMenor, 2)) - Math.Pow(lado2, 2))) / (2 * (baseMaior - baseMenor));

                    basetri2 = baseMaior - baseMenor - basetri1;

                    altura = Math.Sqrt((Math.Pow(lado1, 2) - Math.Pow(basetri1, 2)));

                    if (divisao_visivel == true)
                    {
                        lblBasetri1.Visible = true;
                        lblBasetri1.Text = Convert.ToString(Math.Round(basetri1,2));
                        lblBasetri1.BringToFront();
                        lblBasetri2.Visible = true;
                        lblBasetri2.Text = Convert.ToString(Math.Round(basetri2,2));
                        lblBasetri2.BringToFront();
                    }

                }

                //lado esquerdo
                else if (lado1 != 0 && basetri1 != 0)
                {
                    //lado1² = basetri1² + altura² -> lado1² - basetri1² = altura²
                    altura = Math.Sqrt(Math.Pow(lado1,2) - Math.Pow(basetri1,2));
                }
                else if (angulo1 != 0 && basetri1 != 0)
                {
                    //tgangulo1 = basetri1/altura -> altura = basetri1/senangulo1
                    altura = basetri1 / Math.Tan(angulo1 - 90);
                }
                else if (angulo1 != 0 && lado1 != 0)
                {
                    //cosangulo1 = altura/lado1 -> altura = cosangulo1*lado1
                    altura = lado1 * (Math.Round(Math.Cos((angulo1 - 90) * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2);
                }
                else if (angulo4 != 0 && basetri1 != 0)
                {
                    //tgangulo4 = altura/basetri1 -> altura = tgangulo4 * basetri1
                    altura = basetri1 * (Math.Round(Math.Tan((angulo4) * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2);
                }
                else if (angulo4 != 0 && lado1 != 0)
                {
                    //senangulo4 = altura/lado1 -> altura = senangulo4 * lado1
                    altura = lado1 * (Math.Round(Math.Sin(angulo4 * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2);
                }

                //lado direito
                else if (lado2 != 0 && basetri2 != 0)
                {
                    //lado1² = basetri1² + altura² -> lado1² - basetri1² = altura²
                    altura = Math.Sqrt(Math.Pow(lado2, 2) - Math.Pow(basetri2, 2));
                }
                else if (angulo2 != 0 && basetri2 != 0)
                {
                    //tgangulo1 = basetri1/altura -> altura = basetri1/senangulo1
                    altura = basetri2 / Math.Tan(angulo2 - 90);
                }
                else if (angulo2 != 0 && lado2 != 0)
                {
                    //cosangulo1 = altura/lado1 -> altura = cosangulo1*lado1
                    altura = lado2 * (Math.Round(Math.Cos((angulo2 - 90) * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2);
                }
                else if (angulo3 != 0 && basetri2 != 0)
                {
                    //tgangulo4 = altura/basetri1 -> altura = tgangulo4 * basetri1
                    altura = basetri2 * (Math.Round(Math.Tan(angulo3 * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2);
                }
                else if (angulo3 != 0 && lado2 != 0)
                {
                    //senangulo4 = altura/lado1 -> altura = senangulo4 * lado1
                    altura = lado2 * (Math.Round(Math.Sin(angulo3 * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2);
                }
            }
            //retângulo
            else
            {
                if (lado2 != 0 && baseMaior != 0 && baseMenor != 0)
                { 
                    basetri2 = baseMaior - baseMenor;

                    altura = Math.Sqrt((Math.Pow(lado2, 2) - Math.Pow(basetri2, 2)));

                    if (divisao_visivel == true)
                    {
                        lblBasetri2.Visible = true;
                        lblBasetri2.Text = Convert.ToString(Math.Round(basetri2,2));
                        lblBasetri2.BringToFront();
                    }

                }
                else if (lado2 != 0 && basetri2 != 0)
                {
                    altura = Math.Sqrt((Math.Pow(lado2, 2) - Math.Pow(basetri2, 2)));
                }
                else if (angulo2 != 0 && basetri2 != 0)
                {
                    //tgangulo2 = basetri2/altura -> altura = basetri2/tgangulo2
                    altura = basetri2 / Math.Tan(angulo2 - 90);
                }
                else if (angulo2 != 0 && lado2 != 0)
                {
                    //cosangulo2 = altura/lado2 -> altura = cosangulo2 * lado2
                    altura = lado2 * (Math.Round(Math.Cos((angulo2 - 90) * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2);
                }
                else if (angulo3 != 0 && basetri2 != 0)
                {
                    //tgangulo3 = altura/basetri2 -> altura = tgangulo3 * basetri2
                    altura = basetri2 * (Math.Round(Math.Tan(angulo3 * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2);
                }
                else if (angulo3 != 0 && lado2 != 0)
                {
                    //senangulo3 = altura/lado2 -> altura = lado2 * senangulo3
                    altura = lado2 * (Math.Round(Math.Sin(angulo3 * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2);
                }

            }

            if (altura != 0)
            {
                lblAltura.Text = Convert.ToString(Math.Round(altura,2));
                lblAltura.Visible = true;
                lblExplicacaoTexto.Visible = true;
                lblExplicacaoTexto.MaximumSize = new Size(200, 0);
                lblExplicacaoTexto.Text = "Explicação não disponível no momento.";
                pnlBotoesAltura.Visible = false;
            }
            else
            {
                MessageBox.Show("Impossível calcular.");
                pnlBotoesAltura.Visible = false;
            }
        }

        private void btnInserirAltura_Click(object sender, EventArgs e)
        {
            txtInserirAltura.Visible = true;
            txtInserirAltura.BringToFront();
        }

        private void txtInserirAltura_KeyDown(object sender, KeyEventArgs e)
        {
                if (e.KeyCode == Keys.Enter)
                {
                    this.altura = Convert.ToDouble(txtInserirAltura.Text);
                    lblAltura.Text = Convert.ToString(Math.Round(this.altura,2));
                    lblAltura.Visible = true;
                    lblAltura.BringToFront();
                    pnlBotoesAltura.Visible = false;
                    txtInserirAltura.Visible = false;
                    TipoTrapézio();
            }
        }

        private void btnBasetri1_Click(object sender, EventArgs e)
        {
            pnlBotoesBasetri1.Visible = true;
            pnlBotoesBasetri1.BringToFront();
        }

        private void btnPedirBasetri1_Click(object sender, EventArgs e)
        {
            TipoTrapézio();
            //calcular basetri1
            if (tipo == 1)
            {
                if (lado1 != 0 && lado2 != 0 && baseMaior != 0 && baseMenor != 0)
                {
                    basetri1 = (Math.Pow(lado1, 2) + ((Math.Pow(baseMaior - baseMenor, 2)) - Math.Pow(lado2, 2))) / (2 * (baseMaior - baseMenor));

                }
                else if (baseMaior != 0 && baseMenor != 0)
                {
                    //basemenor = basemaior -2basetri1 -> 2*basetri1 = basemaior - basemenor
                    basetri1 = (baseMaior - baseMenor) / 2;
                }
                else if (angulo1 != 0 && altura != 0)
                {
                    //tanangulo1 = basetri1/altura -> basetri1 = tanangulo1*altura
                    basetri1 = ((Math.Round(Math.Tan((angulo1 - 90) * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2) * altura);
                }
                else if (angulo2 != 0 && altura != 0)
                {
                    //tanangulo1 = basetri1/altura -> basetri1 = tanangulo1*altura
                    basetri1 = ((Math.Round(Math.Tan((angulo2 - 90) * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2) * altura);
                }
                else if (angulo1 != 0 && lado1 != 0)
                {
                    //senangulo1 = basetri1/lado1 -> basetri1 = senangulo1 * lado1
                    basetri1 = ((Math.Round(Math.Sin((angulo1 - 90) * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2) * lado1);
                }
                else if (angulo2 != 0 && lado2 != 0)
                {
                    //senangulo1 = basetri1/lado1 -> basetri1 = senangulo1 * lado1
                    basetri1 = ((Math.Round(Math.Sin((angulo2 - 90) * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2) * lado2);
                }
                else if (angulo4 != 0 && altura != 0)
                {
                    //tanangulo4 = altura/basetri1 -> tanangulo4*basetri1 = altura -> basetri1 = altura/tanangulo4
                    basetri1 = altura / (Math.Round(Math.Tan(angulo4 * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2);
                }
                else if (angulo3 != 0 && altura != 0)
                {
                    //tanangulo4 = altura/basetri1 -> tanangulo4*basetri1 = altura -> basetri1 = altura/tanangulo4
                    basetri1 = altura / (Math.Round(Math.Tan(angulo3 * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2);
                }
                else if (angulo4 != 0 && lado1 != 0)
                {
                    //cosangulo4 = basetri1/lado1 -> basetri1 = cosangulo4 * lado1
                    basetri1 = ((Math.Round(Math.Sin(angulo4 * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2) * lado1); 
                }
                else if (angulo3 != 0 && lado2 != 0)
                {
                    //cosangulo4 = basetri1/lado1 -> basetri1 = cosangulo4 * lado1
                    basetri1 = ((Math.Round(Math.Sin(angulo3 * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2) * lado2);
                }
            }
            //escaleno
            else if (tipo == 2)
            {
                if (lado1 != 0 && lado2 != 0 && baseMaior != 0 && baseMenor != 0)
                {
                    basetri1 = (Math.Pow(lado1, 2) + ((Math.Pow(baseMaior - baseMenor, 2)) - Math.Pow(lado2, 2))) / (2 * (baseMaior - baseMenor));

                }
                else if (baseMaior != 0 && baseMenor != 0 && basetri2 != 0)
                {
                    basetri1 = baseMaior - baseMenor - basetri2;
                }

                else if (lado1 != 0 && altura != 0)
                {
                    //basetri1² + altura² = lado1² -> basetri1² = lado1² - altura²
                    basetri1 = Math.Sqrt(Math.Pow(lado1,2) - Math.Pow(altura,2));
                }
                else if (angulo1 != 0 && lado1 != 0)
                {
                    //senangulo1 = basetri1/lado1 -> basetri1 = lado1 * senangulo1
                    basetri1 = lado1 * (Math.Round(Math.Sin((angulo1 - 90) * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2);
                }
                else if (angulo1 != 0 && altura != 0)
                {
                    //tgangulo1 = basetri1/altura -> basetri1 = tgangulo1 * altura
                    basetri1 = altura * (Math.Round(Math.Tan((angulo1 - 90) * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2);
                }
                else if (angulo4 != 0 && lado1 != 0)
                {
                    //cosangulo4 = basetri1/lado1 -> basetri1 = cosangulo4 * lado1
                    basetri1 = lado1 * (Math.Round(Math.Cos(angulo4 * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2);
                }
                else if (angulo4 != 0 && altura != 0)
                {
                    //tgangulo4 = altura/basetri1 -> basetri1 = altura/tgangulo4
                    basetri1 = altura / (Math.Round(Math.Tan(angulo4 * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2);
                }
            }
            else
            {

            }

            if (basetri1 != 0)
            {
                lblBasetri1.Text = Convert.ToString(Math.Round(basetri1,2));
                lblBasetri1.Visible = true;
                lblExplicacaoTexto.Visible = true;
                lblExplicacaoTexto.MaximumSize = new Size(200, 0);
                lblExplicacaoTexto.Text = "Explicação não disponível no momento.";
                pnlBotoesBasetri1.Visible = false;
            }
            else
            {
                MessageBox.Show("Impossível calcular.");
                pnlBotoesBasetri1.Visible = false;
            }
        }

        private void btnInserirBasetri1_Click(object sender, EventArgs e)
        {
            txtInserirBasetri1.Visible = true;
            txtInserirBasetri1.BringToFront();
        }

        private void txtInserirBasetri1_KeyDown(object sender, KeyEventArgs e)
        {
                if (e.KeyCode == Keys.Enter)
                {
                if ((Convert.ToDouble(txtInserirBasetri1.Text) * 2) < baseMaior || baseMaior == 0/* && (Convert.ToDouble(txtInserirBasetri2.Text) * 2) > baseMenor*/)
                {

                    this.basetri1 = Convert.ToDouble(txtInserirBasetri1.Text);
                    lblBasetri1.Text = Convert.ToString(Math.Round(this.basetri1,2));
                    lblBasetri1.Visible = true;
                    lblBasetri1.BringToFront();
                    pnlBotoesBasetri1.Visible = false;
                    txtInserirBasetri1.Visible = false;
                }
                else
                {
                    MessageBox.Show("Valor inválido");
                }
                TipoTrapézio();
            }
        }

        private void btnBasetri2_Click(object sender, EventArgs e)
        {
            pnlBotoesBasetri2.Visible = true;
            pnlBotoesBasetri2.BringToFront();
        }

        private void btnPedirBasetri2_Click(object sender, EventArgs e)
        {
            TipoTrapézio();
            //calcular basetri2
            if (tipo == 1)
            {
                if (lado1 != 0 && lado2 != 0 && baseMaior != 0 && baseMenor != 0)
                {
                    basetri1 = (Math.Pow(lado1, 2) + ((Math.Pow(baseMaior - baseMenor, 2)) - Math.Pow(lado2, 2))) / (2 * (baseMaior - baseMenor));

                    basetri2 = baseMaior - baseMenor - basetri1;
                }
                else if (baseMaior != 0 && baseMenor != 0)
                {
                    //basemenor = basemaior -2basetri1 -> 2*basetri1 = basemaior - basemenor
                    basetri2 = (baseMaior - baseMenor) / 2;
                }
                else if (angulo2 != 0 && altura != 0)
                {
                    //tanangulo1 = basetri1/altura -> basetri1 = tanangulo1*altura
                    basetri2 = ((Math.Round(Math.Tan((angulo2 - 90) * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2) * altura);
                }
                else if (angulo1 != 0 && altura != 0)
                {
                    //tanangulo1 = basetri1/altura -> basetri1 = tanangulo1*altura
                    basetri2 = ((Math.Round(Math.Tan((angulo1 - 90) * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2) * altura);
                }
                else if (angulo2 != 0 && lado2 != 0)
                {
                    //senangulo1 = basetri1/lado1 -> basetri1 = senangulo1 * lado1
                    basetri2 = (Math.Sin(angulo2 - 90) * lado2);
                }
                else if (angulo1 != 0 && lado1 != 0)
                {
                    //senangulo1 = basetri1/lado1 -> basetri1 = senangulo1 * lado1
                    basetri2 = ((Math.Round(Math.Sin((angulo1 - 90) * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2) * lado1);
                }
                else if (angulo3 != 0 && altura != 0)
                {
                    //tanangulo4 = altura/basetri1 -> tanangulo4*basetri1 = altura -> basetri1 = altura/tanangulo4
                    basetri2 = altura / (Math.Round(Math.Tan(angulo3 * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2);
                }
                else if (angulo4 != 0 && altura != 0)
                {
                    //tanangulo4 = altura/basetri1 -> tanangulo4*basetri1 = altura -> basetri1 = altura/tanangulo4
                    basetri2 = altura / (Math.Round(Math.Tan(angulo4 * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2);
                }
                else if (angulo3 != 0 && lado1 != 0)
                {
                    //cosangulo4 = basetri1/lado1 -> basetri1 = cosangulo4 * lado1
                    basetri2 = ((Math.Round(Math.Sin(angulo3 * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2) * lado1);
                }
                else if (angulo4 != 0 && lado2 != 0)
                {
                    //cosangulo4 = basetri1/lado1 -> basetri1 = cosangulo4 * lado1
                    basetri2 = ((Math.Round(Math.Sin(angulo4 * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2) * lado2);
                }
            }

            //escaleno
            else if (tipo == 2)
            {
                if (lado1 != 0 && lado2 != 0 && baseMaior != 0 && baseMenor != 0)
                {
                    basetri1 = (Math.Pow(lado1, 2) + ((Math.Pow(baseMaior - baseMenor, 2)) - Math.Pow(lado2, 2))) / (2 * (baseMaior - baseMenor));

                    basetri2 = baseMaior - baseMenor - basetri1;
                }
                else if (baseMaior != 0 && baseMenor != 0 && basetri1 != 0)
                {
                    basetri2 = baseMaior - baseMenor - basetri1;
                }

                else if (lado2 != 0 && altura != 0)
                {
                    //basetri1² + altura² = lado1² -> basetri1² = lado1² - altura²
                    basetri2 = Math.Sqrt(Math.Pow(lado2, 2) - Math.Pow(altura, 2));
                }
                else if (angulo2 != 0 && lado2 != 0)
                {
                    //senangulo1 = basetri1/lado1 -> basetri1 = lado1 * senangulo1
                    basetri2 = lado2 * (Math.Round(Math.Sin((angulo2 - 90) * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2);
                }
                else if (angulo2 != 0 && altura != 0)
                {
                    //tgangulo1 = basetri1/altura -> basetri1 = tgangulo1 * altura
                    basetri2 = altura * (Math.Round(Math.Tan((angulo2 - 90) * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2);
                }
                else if (angulo3 != 0 && lado2 != 0)
                {
                    //cosangulo4 = basetri1/lado1 -> basetri1 = cosangulo4 * lado1
                    basetri2 = lado2 * (Math.Round(Math.Cos(angulo3 * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2);
                }
                else if (angulo3 != 0 && altura != 0)
                {
                    //tgangulo4 = altura/basetri1 -> basetri1 = altura/tgangulo4
                    basetri2 = altura / (Math.Round(Math.Tan(angulo3 * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2);
                }
            }

            //retângulo
            else
            {
                if (baseMaior != 0 && baseMenor != 0)
                {
                    basetri2 = baseMaior - baseMenor;
                }
                else if (lado2 != 0 && (altura != 0 || lado1 != 0))
                {
                    //lado2² = basetri2² + altura² -> basetri2² = lado2² - altura²
                    if (altura != 0)
                    {
                        basetri2 = Math.Sqrt(Math.Pow(lado2,2) - Math.Pow(altura,2));
                    }
                    else if (lado1 != 0)
                    {
                        basetri2 = Math.Sqrt(Math.Pow(lado2, 2) - Math.Pow(lado2, 2));
                    }
                }
                else if (angulo3 != 0 && lado2 != 0)
                {
                    //cosangulo3 = basetri2/lado2 -> basetri2 = cosangulo3 * lado2
                    basetri2 = lado2 * (Math.Round(Math.Cos(angulo3 * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2);
                }
                else if (angulo3 != 0 && (altura != 0 || lado1 != 0))
                {
                    //tgangulo3 = altura/basetri2 -> basetri2 = altura/tgangulo3
                    if (altura != 0)
                    {
                        basetri2 = altura / (Math.Round(Math.Tan(angulo3 * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2);
                    }
                    else if (lado1 != 0)
                    {
                        basetri2 = lado1 / (Math.Round(Math.Tan(angulo3 * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2);
                    }
                }
                else if (angulo2 != 0 && lado2 != 0)
                {
                    //senangulo2 = basetri2/lado2 -> basetri2 = senangulo2 * lado2
                    basetri2 = lado2 * (Math.Round(Math.Sin((angulo2 - 90) * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2);
                }
                else if (angulo2 != 0 && (altura != 0 || lado1 != 0))
                {
                    //tgangulo2 = basetri2/altura -> basetri2 = tgangulo2 * altura
                    if (altura != 0)
                    {
                        basetri2 = altura * (Math.Round(Math.Tan((angulo2 - 90) * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2);
                    }
                    else if (lado1 != 0)
                    {
                        basetri2 = lado1 * (Math.Round(Math.Tan((angulo2 - 90) * Math.PI / 180) * 2, MidpointRounding.AwayFromZero) / 2);
                    }
                }
            }

            if (basetri2 != 0)
            {
                lblBasetri2.Text = Convert.ToString(Math.Round(basetri2,2));
                lblBasetri2.Visible = true;
                lblExplicacaoTexto.Visible = true;
                lblExplicacaoTexto.MaximumSize = new Size(200, 0);
                lblExplicacaoTexto.Text = "Explicação não disponível no momento.";
                pnlBotoesBasetri2.Visible = false;
            }
            else
            {
                MessageBox.Show("Impossível calcular.");
                pnlBotoesBasetri2.Visible = false;
            }
        }

        private void btnInserirBasetri2_Click(object sender, EventArgs e)
        {
            txtInserirBasetri2.Visible = true;
            txtInserirBasetri2.BringToFront();
        }

        private void txtInserirBasetri2_KeyDown(object sender, KeyEventArgs e)
        {
                if (e.KeyCode == Keys.Enter)
                {
                if ((Convert.ToDouble(txtInserirBasetri2.Text) * 2) < baseMaior && (Convert.ToDouble(txtInserirBasetri2.Text) * 2) > baseMenor)
                {

                    this.basetri2 = Convert.ToDouble(txtInserirBasetri2.Text);
                    lblBasetri2.Text = Convert.ToString(Math.Round(this.basetri2,2));
                    lblBasetri2.Visible = true;
                    lblBasetri2.BringToFront();
                    pnlBotoesBasetri1.Visible = false;
                    txtInserirBasetri1.Visible = false;
                }
                else
                {
                    MessageBox.Show("Valor inválido");
                }
                TipoTrapézio();
            }

        }

        private void btnAngulo1_Click(object sender, EventArgs e)
        {
            TipoTrapézio();
            pnlAngulo1.Visible = true;
            pnlAngulo1.BringToFront();
            if (tipo == 3)
            {
                btnPedirAngulo1.Visible = false;
            }
            else btnPedirAngulo1.Visible = true;
        }

        private void btnPedirAngulo1_Click(object sender, EventArgs e)
        {
            TipoTrapézio();
            //calcular angulo1
            if (tipo ==1)
            {
                if (angulo2 != 0 && angulo3 != 0 && angulo4 != 0)
                {
                    //angulo1 = 360 - angulo2 - angulo3 - angulo4
                    angulo1 = 360 - angulo2 - angulo3 - angulo4;
                }
                else if (angulo4 != 0)
                {
                    // angulo1 - 90 = 180 - angulo4 - 90 -> angulo1 = 180-angulo4
                    // se angulo 4 = 50 -> angulo1 = 180 - 50 = 130 -> 130 - 90 = 40
                    angulo1 = 180 - angulo4;
                }
                else if (angulo3 != 0)
                {
                    // angulo1 - 90 = 180 - angulo4 - 90 -> angulo1 = 180-angulo4
                    // se angulo 4 = 50 -> angulo1 = 180 - 50 = 130 -> 130 - 90 = 40
                    angulo1 = 180 - angulo3;
                }
            }
            //escaleno
            else if (tipo == 2)
            {
                if (angulo2 != 0 && angulo3 != 0 && angulo4 != 0)
                {
                    //angulo1 = 360 - angulo2 - angulo3 - angulo4
                    angulo1 = 360 - angulo2 - angulo3 - angulo4;
                }
                else if (angulo4 != 0)
                {
                    //angulo1 - 90 = 180 - angulo4 - 90 -> angulo1 = 180 - angulo4
                    angulo1 = 180 - angulo4;

                }
            }
            //retângulo
            else
            {
                angulo1 = 90;
                angulo4 = 90;
            }

            if (angulo1 != 0)
            {
                if (divisao_visivel == false)
                {
                    lblAngulo1.Text = Convert.ToString(Math.Round(angulo1,2));
                    lblAngulo1.Visible = true;
                }
                else if(divisao_visivel == true)
                {
                    lblAngulo1.Text = Convert.ToString(Math.Round(angulo1 - 90,2));
                    lblAngulo1.Visible = true;
                }
                lblExplicacaoTexto.Visible = true;
                lblExplicacaoTexto.MaximumSize = new Size(200, 0);
                lblExplicacaoTexto.Text = "Explicação não disponível no momento.";
                pnlAngulo1.Visible = false;
            }
            else
            {
                MessageBox.Show("Impossível calcular.");
                pnlAngulo1.Visible = false;
            }
        }

        private void btnInserirAngulo1_Click(object sender, EventArgs e)
        {
            txtInserirAngulo1.Visible = true;
            txtInserirAngulo1.BringToFront();
        }

        private void txtInserirAngulo1_KeyDown(object sender, KeyEventArgs e)
        {
                if (e.KeyCode == Keys.Enter)
                {
                    this.angulo1 = Convert.ToDouble(txtInserirAngulo1.Text);
                    if (this.angulo1 >= 90)
                    {
                        lblAngulo1.Text = Convert.ToString(Math.Round(this.angulo1));
                        lblAngulo1.Visible = true;
                        lblAngulo1.BringToFront();
                        pnlAngulo1.Visible = false;
                        txtInserirAngulo1.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("O valor desse ângulo não pode ser menor que 90°.");
                    }
                TipoTrapézio();
                }
        }

        private void btnAngulo2_Click(object sender, EventArgs e)
        {
            pnlAngulo2.Visible = true;
            pnlAngulo2.BringToFront();

        }

        private void btnPedirAngulo2_Click(object sender, EventArgs e)
        {
            TipoTrapézio();
            //calcular angulo2
            if (tipo == 1)
            {
                if (angulo1 != 0 && angulo3 != 0 && angulo4 != 0)
                {
                    //angulo1 = 360 - angulo2 - angulo3 - angulo4
                    angulo2 = 360 - angulo1 - angulo3 - angulo4;
                }
                else if (angulo3 != 0)
                {
                    // angulo1 - 90 = 180 - angulo4 - 90 -> angulo1 = 180-angulo4
                    // se angulo 4 = 50 -> angulo1 = 180 - 50 = 130 -> 130 - 90 = 40
                    angulo2 = 180 - angulo3;
                }
                else if (angulo4 != 0)
                {
                    // angulo1 - 90 = 180 - angulo4 - 90 -> angulo1 = 180-angulo4
                    // se angulo 4 = 50 -> angulo1 = 180 - 50 = 130 -> 130 - 90 = 40
                    angulo2 = 180 - angulo4;
                }
            }
            //escaleno
            else if (tipo == 2)
            {
                if (angulo1 != 0 && angulo3 != 0 && angulo4 != 0)
                {
                    //angulo1 = 360 - angulo2 - angulo3 - angulo4
                    angulo2 = 360 - angulo1 - angulo3 - angulo4;
                }
                else if (angulo3 != 0)
                {
                    //angulo1 - 90 = 180 - angulo4 - 90 -> angulo1 = 180 - angulo4
                    angulo2 = 180 - angulo3;

                }
            }
            //retângulo
            else
            {
                if (angulo1 != 0 && angulo3 != 0 && angulo4 != 0)
                {
                    //angulo1 = 360 - angulo2 - angulo3 - angulo4
                    angulo2 = 360 - angulo1 - angulo3 - angulo4;
                }
                else if (angulo3 != 0)
                {
                    angulo2 = 180 - angulo3;
                }
            }

            if (angulo2 != 0)
            {
                if (divisao_visivel != true)
                {
                    lblAngulo2.Text = Convert.ToString(Math.Round(angulo2,2));
                    lblAngulo2.Visible = true;
                }
                else
                {
                    lblAngulo2.Text = Convert.ToString(Math.Round(angulo2 - 90,2));
                    lblAngulo2.Visible = true;
                }
                lblExplicacaoTexto.Visible = true;
                lblExplicacaoTexto.MaximumSize = new Size(200, 0);
                lblExplicacaoTexto.Text = "Explicação não disponível no momento.";
                pnlAngulo2.Visible = false;
            }
            else
            {
                MessageBox.Show("Impossível calcular.");
                pnlAngulo2.Visible = false;
            }
        }

        private void btnInserirAngulo2_Click(object sender, EventArgs e)
        {

            txtInserirAngulo2.Visible = true;
            txtInserirAngulo2.BringToFront();
        }

        private void txtInserirAngulo2_KeyDown(object sender, KeyEventArgs e)
        {
                if (e.KeyCode == Keys.Enter)
                {
                    this.angulo2 = Convert.ToDouble(txtInserirAngulo2.Text);
                    if (this.angulo2 >= 90)
                    {
                        lblAngulo2.Text = Convert.ToString(Math.Round(this.angulo2,2));
                        lblAngulo2.Visible = true;
                        lblAngulo2.BringToFront();
                        pnlAngulo2.Visible = false;
                        txtInserirAngulo2.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("O valor desse ângulo não pode ser menor que 90°.");
                    }
                TipoTrapézio();
            }
        }

        private void btnAngulo3_Click(object sender, EventArgs e)
        {
            pnlAngulo3.Visible = true;
            pnlAngulo3.BringToFront();
        }

        private void btnPedirAngulo3_Click(object sender, EventArgs e)
        {
            TipoTrapézio();
            //calcular angulo3
            if (tipo == 1)
            {
                if (angulo1 != 0 && angulo2 != 0 && angulo4 != 0)
                {
                    //angulo1 = 360 - angulo2 - angulo3 - angulo4
                    angulo3 = 360 - angulo1 - angulo2 - angulo4;
                }
                else if (angulo2 != 0)
                {
                    //angulo3 = 180 - (angulo2 - 90) - 90
                    angulo3 = 180 - (angulo2 - 90) - 90;
                }
                else if (angulo1 != 0)
                {
                    //angulo3 = 180 - (angulo2 - 90) - 90
                    angulo3 = 180 - (angulo1 - 90) - 90;
                }
            }
            //escaleno
            else if (tipo == 2)
            {
                if (angulo1 != 0 && angulo2 != 0 && angulo4 != 0)
                {
                    //angulo1 = 360 - angulo2 - angulo3 - angulo4
                    angulo3 = 360 - angulo1 - angulo2 - angulo4;
                }
                else if (angulo2 != 0)
                {
                    //angulo3 = 180 - 90 - (angulo2 - 90) -> angulo3 = 90 - (angulo2 - 90)
                    angulo3 = 90 - (angulo2 - 90);
                }
            }
            else
            {
                if (angulo1 != 0 && angulo2 != 0 && angulo4 != 0)
                {
                    //angulo1 = 360 - angulo2 - angulo3 - angulo4
                    angulo3 = 360 - angulo1 - angulo2 - angulo4;
                }
                else if (angulo2 != 0)
                {
                    //angulo3 = 180 - 90 - (angulo2 - 90) -> angulo3 = 90 - (angulo2 - 90)
                    angulo3 = 90 - (angulo2 - 90);
                }
            }

            if (angulo3 != 0)
            {
                if (divisao_visivel != true)
                {
                    lblAngulo3.Text = Convert.ToString(Math.Round(angulo3,2));
                    lblAngulo3.Visible = true;
                }
                else
                {
                    lblAngulo3.Text = Convert.ToString(Math.Round(angulo3,2));
                    lblAngulo3.Visible = true;
                }
                lblExplicacaoTexto.Visible = true;
                lblExplicacaoTexto.MaximumSize = new Size(200, 0);
                lblExplicacaoTexto.Text = "Explicação não disponível no momento.";
                pnlAngulo3.Visible = false;
            }
            else
            {
                MessageBox.Show("Impossível calcular.");
                pnlAngulo3.Visible = false;
            }
        }

        private void btnInserirAngulo3_Click(object sender, EventArgs e)
        {
            txtInserirAngulo3.Visible = true;
            txtInserirAngulo3.BringToFront();
        }

        private void txtInserirAngulo3_KeyDown(object sender, KeyEventArgs e)
        {
                if (e.KeyCode == Keys.Enter)
                {
                    this.angulo3 = Convert.ToDouble(txtInserirAngulo3.Text);
                    if (this.angulo3 <= 90)
                    {
                        lblAngulo3.Text = Convert.ToString(Math.Round(this.angulo3,2));
                        lblAngulo3.Visible = true;
                        lblAngulo3.BringToFront();
                        pnlAngulo3.Visible = false;
                        txtInserirAngulo3.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("O valor desse ângulo não pode ser maior que 90°.");
                    }
                TipoTrapézio();
            }
        }

        private void btnAngulo4_Click(object sender, EventArgs e)
        {
            pnlAngulo4.Visible = true;
            pnlAngulo4.BringToFront();
            if (tipo == 3)
            {
                btnPedirAngulo4.Visible = false;
            }
            else btnPedirAngulo4.Visible = true;
        }

        private void btnPedirAngulo4_Click(object sender, EventArgs e)
        {
            TipoTrapézio();
            //calcular angulo4
            if (tipo == 1)
            {
                if (angulo1 != 0 && angulo2 != 0 && angulo3 != 0)
                {
                    //angulo1 = 360 - angulo2 - angulo3 - angulo4
                    angulo4 = 360 - angulo1 - angulo2 - angulo3;
                }
                else if (angulo1 != 0)
                {
                    //angulo3 = 180 - (angulo2 - 90) - 90
                    angulo4 = 180 - (angulo1 - 90) - 90;
                }
                else if (angulo2 != 0)
                {
                    //angulo3 = 180 - (angulo2 - 90) - 90
                    angulo4 = 180 - (angulo2 - 90) - 90;
                }
            }
            //escaleno
            else if (tipo == 2)
            {
                if (angulo1 != 0 && angulo2 != 0 && angulo3 != 0)
                {
                    //angulo1 = 360 - angulo2 - angulo3 - angulo4
                    angulo4 = 360 - angulo1 - angulo2 - angulo3;
                }
                else if (angulo1 != 0)
                {
                    angulo4 = 90 - (angulo1 - 90);
                }
            }
            //retângulo
            else
            {
                angulo4 = 90;
                angulo3 = 90;
            }

            if (angulo4 != 0)
            {
                if (divisao_visivel != true)
                {
                    lblAngulo4.Text = Convert.ToString(Math.Round(angulo4,2));
                    lblAngulo4.Visible = true;
                }
                else
                {
                    lblAngulo4.Text = Convert.ToString(Math.Round(angulo4,2));
                    lblAngulo4.Visible = true;
                }
                lblExplicacaoTexto.Visible = true;
                lblExplicacaoTexto.MaximumSize = new Size(200, 0);
                lblExplicacaoTexto.Text = "Explicação não disponível no momento.";
                pnlAngulo4.Visible = false;
            }
            else
            {
                MessageBox.Show("Impossível calcular.");
                pnlAngulo4.Visible = false;
            }
        }

        private void btnInserirAngulo4_Click(object sender, EventArgs e)
        {
            txtInserirAngulo4.Visible = true;
            txtInserirAngulo4.BringToFront();
        }

        private void txtInserirAngulo4_KeyDown(object sender, KeyEventArgs e)
        {
                if (e.KeyCode == Keys.Enter)
                {
                    this.angulo4 = Convert.ToDouble(txtInserirAngulo4.Text);
                    if (this.angulo4 <= 90)
                    {
                        lblAngulo4.Text = Convert.ToString(Math.Round(this.angulo4,2));
                        lblAngulo4.Visible = true;
                        lblAngulo4.BringToFront();
                        pnlAngulo4.Visible = false;
                        txtInserirAngulo4.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("O valor desse ângulo não pode ser maior que 90°.");
                    }
                TipoTrapézio();
            }
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            if (baseMaior != 0 && baseMenor != 0 && altura != 0)
            {
                lblArea.Text = "Área: " + Math.Round((((baseMaior + baseMenor) * altura) / 2),2);
                lblExplicacaoTexto.Visible = true;
                lblExplicacaoTexto.MaximumSize = new Size(200, 0);
                lblExplicacaoTexto.Text = "A área de um trapézio é calculada usando a seguinte fórmula: ((B + b) * h)/2, ou seja: ((" + Convert.ToString(baseMaior) + " + " + Convert.ToString(baseMenor) + ") * " + Convert.ToString(altura) + ") ÷ 2";
            }
            else
            {
                MessageBox.Show("Impossível calcular");
            }
        }

        private void btnPerimetro_Click(object sender, EventArgs e)
        {
            if (baseMaior != 0 && baseMenor != 0 && lado1 != 0 && lado2 != 0)
            {
                lblPerimetro.Text = "Perímetro: " + Math.Round((baseMaior + baseMenor + lado1 + lado2),2);
                lblExplicacaoTexto.Visible = true;
                lblExplicacaoTexto.MaximumSize = new Size(200, 0);
                lblExplicacaoTexto.Text = "O perímetro de um trapézio é calculado somando todos seus lados, ou seja: " + Convert.ToString(lado1) + " + " + Convert.ToString(baseMenor) + " + " + Convert.ToString(lado2) + " + " + Convert.ToString(baseMaior);
            }
            else
            {
                MessageBox.Show("Impossível calcular");
            }
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            pnlOcultar.Visible = false;
            pnlExibir.Visible = true;
            pnlExibir.BringToFront();
        }

        private void btnExibirAltura_Click(object sender, EventArgs e)
        {
            altura_visivel = true;
            
            if (tipo == 1)
            {
                if (angulo_visivel == true && divisao_visivel == true)
                {
                    picTrapézio.Load("trapézio_isóceles_angulos_dividido.png");
                }
                else if (angulo_visivel == true && divisao_visivel == false)
                {
                    picTrapézio.Load("trapézio_isóceles_altura_angulos.png");
                }
                else if (angulo_visivel == false && divisao_visivel == true)
                {
                    picTrapézio.Load("trapézio_isóceles_dividido.png");
                }
                else if (angulo_visivel == false && divisao_visivel == false)
                {
                    picTrapézio.Load("trapézio_isóceles_altura.png");
                }
                lblAltura.BringToFront();
                btnAltura.Visible = true;
                btnAltura.BringToFront();
            }
            else if (tipo == 2)
            {
                if (angulo_visivel == true && divisao_visivel == true)
                {
                    picTrapézio.Load("trapézio_escaleno_angulos_dividido.png");
                }
                else if (angulo_visivel == true && divisao_visivel == false)
                {
                    picTrapézio.Load("trapézio_escaleno_altura_angulos.png");
                }
                else if (angulo_visivel == false && divisao_visivel == true)
                {
                    picTrapézio.Load("trapézio_escaleno_dividido.png");
                }
                else if (angulo_visivel == false && divisao_visivel == false)
                {
                    picTrapézio.Load("trapézio_escaleno_altura.png");
                }
                lblAltura.BringToFront();
                btnAltura.Visible = true;
                btnAltura.BringToFront();
            }
            else if (tipo == 3)
            {
                if (angulo_visivel == true && divisao_visivel == true)
                {
                    picTrapézio.Load("trapézio_retângulo_angulos_dividido.png");
                }
                else if (angulo_visivel == true && divisao_visivel == false)
                {
                    picTrapézio.Load("trapézio_retângulo_angulos.png");
                }
                else if (angulo_visivel == false && divisao_visivel == true)
                {
                    picTrapézio.Load("trapézio_retângulo_dividido.png");
                }
                else if (angulo_visivel == false && divisao_visivel == false)
                {
                    picTrapézio.Load("trapézio_retângulo.png");
                }
            }



        }

        private void btnExibirAngulos_Click(object sender, EventArgs e)
        {
            angulo_visivel = true;
            btnAngulo1.Visible = true;
            btnAngulo1.BringToFront();
            btnAngulo2.Visible = true;
            btnAngulo2.BringToFront();
            btnAngulo3.Visible = true;
            btnAngulo3.BringToFront();
            btnAngulo4.Visible = true;
            btnAngulo4.BringToFront();
            
            if (tipo == 1)
            {
                if (altura_visivel == true && divisao_visivel == true)
                {
                    picTrapézio.Load("trapézio_isóceles_angulos_dividido.png");
                }
                else if (altura_visivel == true && divisao_visivel == false)
                {
                    picTrapézio.Load("trapézio_isóceles_altura_angulos.png");
                }
                else if (altura_visivel == false && divisao_visivel == true)
                {
                    picTrapézio.Load("trapézio_isóceles_angulos_dividido.png");
                }
                else if (altura_visivel == false && divisao_visivel == false)
                {
                    picTrapézio.Load("trapézio_isóceles_angulos.png");
                }
            }
            else if (tipo == 2)
            {
                if (altura_visivel == true && divisao_visivel == true)
                {
                    picTrapézio.Load("trapézio_escaleno_angulos_dividido.png");
                }
                else if (altura_visivel == true && divisao_visivel == false)
                {
                    picTrapézio.Load("trapézio_escaleno_altura_angulos.png");
                }
                else if (altura_visivel == false && divisao_visivel == true)
                {
                    picTrapézio.Load("trapézio_escaleno_angulos_dividido.png");
                }
                else if (altura_visivel == false && divisao_visivel == false)
                {
                    picTrapézio.Load("trapézio_escaleno_angulos.png");
                }
            }
            else if (tipo == 3)
            {
                if (altura_visivel == true && divisao_visivel == true)
                {
                    picTrapézio.Load("trapézio_retângulo_angulos_dividido.png");
                }
                else if (altura_visivel == true && divisao_visivel == false)
                {
                    picTrapézio.Load("trapézio_retângulo_angulos.png");
                }
                else if (altura_visivel == false && divisao_visivel == true)
                {
                    picTrapézio.Load("trapézio_retângulo_angulos_dividido.png");
                }
                else if (altura_visivel == false && divisao_visivel == false)
                {
                    picTrapézio.Load("trapézio_retângulo_angulos.png");
                }
            }
        }

        private void btnExibirDivisões_Click(object sender, EventArgs e)
        {
            divisao_visivel = true;

            if (tipo == 1)
            {
                if (altura_visivel == true && angulo_visivel == true)
                {
                    picTrapézio.Load("trapézio_isóceles_angulos_dividido.png");

                    btnAltura.Location = new Point(181, 208);
                    lblAltura.Location = new Point(226, 197);
                    pnlBotoesAltura.Location = new Point(59, 170);
                    txtInserirAltura.Location = new Point(188, 204);
                    btnAngulo1.Location = new Point(184, 84);
                    btnAngulo1.Size = new Size(10, 24);
                    btnAngulo2.Location = new Point(527, 84);
                    btnAngulo2.Size = new Size(10, 24);
                    lblAngulo1.Location = new Point(156, 144);
                    lblAngulo1.Font = new Font("Microsoft Sans Serif", 16);
                    lblAngulo2.Location = new Point(527, 144);
                    lblAngulo2.Font = new Font("Microsoft Sans Serif", 16);
                    lblAngulo1.Text = Convert.ToString(Math.Round(angulo1 - 90,2));
                    lblAngulo2.Text = Convert.ToString(Math.Round(angulo2 - 90,2));
                }
                else if (altura_visivel == true && angulo_visivel == false)
                {
                    picTrapézio.Load("trapézio_isóceles_dividido.png");

                    btnAltura.Location = new Point(181, 208);
                    lblAltura.Location = new Point(226, 197);
                    pnlBotoesAltura.Location = new Point(59, 170);
                    txtInserirAltura.Location = new Point(188, 204);
                    btnAngulo1.Location = new Point(184, 84);
                    btnAngulo1.Size = new Size(10, 24);
                    btnAngulo2.Location = new Point(527, 84);
                    btnAngulo2.Size = new Size(10, 24);
                    lblAngulo1.Location = new Point(156, 144);
                    lblAngulo1.Font = new Font("Microsoft Sans Serif", 16);
                    lblAngulo2.Location = new Point(527, 144);
                    lblAngulo2.Font = new Font("Microsoft Sans Serif", 16);
                    lblAngulo1.Text = Convert.ToString(Math.Round(angulo1 - 90,2));
                    lblAngulo2.Text = Convert.ToString(Math.Round(angulo2 - 90,2));
                }
                else if (altura_visivel == false && angulo_visivel == true)
                {
                    picTrapézio.Load("trapézio_isóceles_angulos_dividido.png");

                    btnAltura.Location = new Point(181, 208);
                    lblAltura.Location = new Point(226, 197);
                    pnlBotoesAltura.Location = new Point(59, 170);
                    txtInserirAltura.Location = new Point(188, 204);
                    btnAngulo1.Location = new Point(184, 84);
                    btnAngulo1.Size = new Size(10, 24);
                    btnAngulo2.Location = new Point(527, 84);
                    btnAngulo2.Size = new Size(10, 24);
                    lblAngulo1.Location = new Point(156, 144);
                    lblAngulo1.Font = new Font("Microsoft Sans Serif", 16);
                    lblAngulo2.Location = new Point(527, 144);
                    lblAngulo2.Font = new Font("Microsoft Sans Serif", 16);
                    lblAngulo1.Text = Convert.ToString(Math.Round(angulo1 - 90,2));
                    lblAngulo2.Text = Convert.ToString(Math.Round(angulo2 - 90,2));
                }
                else if (altura_visivel == false && angulo_visivel == false)
                {
                    picTrapézio.Load("trapézio_isóceles_dividido.png");

                    btnAltura.Location = new Point(181, 208);
                    lblAltura.Location = new Point(226, 197);
                    pnlBotoesAltura.Location = new Point(59, 170);
                    txtInserirAltura.Location = new Point(188, 204);
                    btnAngulo1.Location = new Point(184, 84);
                    btnAngulo1.Size = new Size(10, 24);
                    btnAngulo2.Location = new Point(527, 84);
                    btnAngulo2.Size = new Size(10, 24);
                    lblAngulo1.Location = new Point(156, 144);
                    lblAngulo1.Font = new Font("Microsoft Sans Serif", 16);
                    lblAngulo2.Location = new Point(527, 144);
                    lblAngulo2.Font = new Font("Microsoft Sans Serif", 16);
                    lblAngulo1.Text = Convert.ToString(Math.Round(angulo1 - 90,2));
                    lblAngulo2.Text = Convert.ToString(Math.Round(angulo2 - 90,2));
                }
                btnBasetri1.Visible = true;
                btnBasetri1.BringToFront();
                btnBasetri2.Visible = true;
                btnBasetri2.BringToFront();
            }
            else if (tipo == 2)
            {
                if (altura_visivel == true && angulo_visivel == true)
                {
                    picTrapézio.Load("trapézio_escaleno_angulos_dividido.png");

                    btnAltura.Location = new Point(181, 208);
                    lblAltura.Location = new Point(226, 197);
                    pnlBotoesAltura.Location = new Point(59, 170);
                    txtInserirAltura.Location = new Point(188, 204);
                    btnAngulo1.Location = new Point(184, 84);
                    btnAngulo1.Size = new Size(10, 24);
                    btnAngulo2.Location = new Point(527, 84);
                    btnAngulo2.Size = new Size(10, 24);
                    lblAngulo1.Location = new Point(156, 144);
                    lblAngulo1.Font = new Font("Microsoft Sans Serif", 16);
                    lblAngulo2.Location = new Point(527, 144);
                    lblAngulo2.Font = new Font("Microsoft Sans Serif", 16);
                    lblAngulo1.Text = Convert.ToString(Math.Round(angulo1 - 90,2));
                    lblAngulo2.Text = Convert.ToString(Math.Round(angulo2 - 90,2));
                }
                else if (altura_visivel == true && angulo_visivel == false)
                {
                    picTrapézio.Load("trapézio_escaleno_dividido.png");

                    btnAltura.Location = new Point(181, 208);
                    lblAltura.Location = new Point(226, 197);
                    pnlBotoesAltura.Location = new Point(59, 170);
                    txtInserirAltura.Location = new Point(188, 204);
                    btnAngulo1.Location = new Point(184, 84);
                    btnAngulo1.Size = new Size(10, 24);
                    btnAngulo2.Location = new Point(527, 84);
                    btnAngulo2.Size = new Size(10, 24);
                    lblAngulo1.Location = new Point(156, 144);
                    lblAngulo1.Font = new Font("Microsoft Sans Serif", 16);
                    lblAngulo2.Location = new Point(527, 144);
                    lblAngulo2.Font = new Font("Microsoft Sans Serif", 16);
                    lblAngulo1.Text = Convert.ToString(Math.Round(angulo1 - 90,2));
                    lblAngulo2.Text = Convert.ToString(Math.Round(angulo2 - 90,2));
                }
                else if (altura_visivel == false && angulo_visivel == true)
                {
                    picTrapézio.Load("trapézio_escaleno_angulos_dividido.png");

                    btnAltura.Location = new Point(181, 208);
                    lblAltura.Location = new Point(226, 197);
                    pnlBotoesAltura.Location = new Point(59, 170);
                    txtInserirAltura.Location = new Point(188, 204);
                    btnAngulo1.Location = new Point(184, 84);
                    btnAngulo1.Size = new Size(10, 24);
                    btnAngulo2.Location = new Point(527, 84);
                    btnAngulo2.Size = new Size(10, 24);
                    lblAngulo1.Location = new Point(156, 144);
                    lblAngulo1.Font = new Font("Microsoft Sans Serif", 16);
                    lblAngulo2.Location = new Point(527, 144);
                    lblAngulo2.Font = new Font("Microsoft Sans Serif", 16);
                    lblAngulo1.Text = Convert.ToString(Math.Round(angulo1 - 90,2));
                    lblAngulo2.Text = Convert.ToString(Math.Round(angulo2 - 90,2));
                }
                else if (altura_visivel == false && angulo_visivel == false)
                {
                    picTrapézio.Load("trapézio_escaleno_dividido.png");

                    btnAltura.Location = new Point(181, 208);
                    lblAltura.Location = new Point(226, 197);
                    pnlBotoesAltura.Location = new Point(59, 170);
                    txtInserirAltura.Location = new Point(188, 204);
                    btnAngulo1.Location = new Point(184, 84);
                    btnAngulo1.Size = new Size(10, 24);
                    btnAngulo2.Location = new Point(527, 84);
                    btnAngulo2.Size = new Size(10, 24);
                    lblAngulo1.Location = new Point(156, 144);
                    lblAngulo1.Font = new Font("Microsoft Sans Serif", 16);
                    lblAngulo2.Location = new Point(527, 144);
                    lblAngulo2.Font = new Font("Microsoft Sans Serif", 16);
                    lblAngulo1.Text = Convert.ToString(Math.Round(angulo1 - 90,2));
                    lblAngulo2.Text = Convert.ToString(Math.Round(angulo2 - 90,2));
                }
                btnBasetri1.Visible = true;
                btnBasetri1.BringToFront();
                btnBasetri2.Visible = true;
                btnBasetri2.BringToFront();
            }
            else if (tipo == 3)
            {
                if (altura_visivel == true && angulo_visivel == true)
                {
                    picTrapézio.Load("trapézio_retângulo_angulos_dividido.png");
                    btnAngulo2.Location = new Point(463, 72);
                    btnAngulo2.Size = new Size(10, 24);
                    lblAngulo2.Location = new Point(464, 122);
                    lblAngulo2.Font = new Font("Microsoft Sans Serif", 16);
                    lblAngulo2.Text = Convert.ToString(Math.Round(angulo2 - 90,2));
                }
                else if (altura_visivel == true && angulo_visivel == false)
                {
                    picTrapézio.Load("trapézio_retângulo_dividido.png");

                    btnAngulo2.Location = new Point(463, 72);
                    btnAngulo2.Size = new Size(10, 24);
                    lblAngulo2.Location = new Point(464, 122);
                    lblAngulo2.Font = new Font("Microsoft Sans Serif", 16);
                    lblAngulo2.Text = Convert.ToString(Math.Round(angulo2 - 90,2));
                }
                else if (altura_visivel == false && angulo_visivel == true)
                {
                    picTrapézio.Load("trapézio_retângulo_angulos_dividido.png");

                    btnAngulo2.Location = new Point(463, 72);
                    btnAngulo2.Size = new Size(10, 24);
                    lblAngulo2.Location = new Point(464, 122);
                    lblAngulo2.Font = new Font("Microsoft Sans Serif", 16);
                    lblAngulo2.Text = Convert.ToString(Math.Round(angulo2 - 90,2));
                }
                else if (altura_visivel == false && angulo_visivel == false)
                {
                    picTrapézio.Load("trapézio_retângulo_dividido.png");
                    btnAngulo2.Location = new Point(463, 72);
                    btnAngulo2.Size = new Size(10, 24);
                    lblAngulo2.Location = new Point(464, 122);
                    lblAngulo2.Font = new Font("Microsoft Sans Serif", 16);
                    lblAngulo2.Text = Convert.ToString(Math.Round(angulo2 - 90,2));
                }
                btnBasetri2.Visible = true;
                btnBasetri2.BringToFront();
            }
        }

        private void btnOcultar_Click(object sender, EventArgs e)
        {
            pnlOcultar.Visible = true;
            pnlExibir.Visible = false;
            pnlOcultar.BringToFront();
        }

        private void btnOcultarAltura_Click(object sender, EventArgs e)
        {
            if (altura_visivel == true)
            {
                altura_visivel = false;
                lblAltura.Visible = false;
                btnAltura.Visible = false;

                if (tipo == 1)
                {
                    if (angulo_visivel == true && divisao_visivel == true)
                    {
                        picTrapézio.Load("trapézio_isóceles_angulos_dividido.png");
                    }
                    else if (angulo_visivel == true && divisao_visivel == false)
                    {
                        picTrapézio.Load("trapézio_isóceles_angulos.png");
                    }
                    else if (angulo_visivel == false && divisao_visivel == true)
                    {
                        picTrapézio.Load("trapézio_isóceles_dividido.png");
                    }
                    else if (angulo_visivel == false && divisao_visivel == false)
                    {
                        picTrapézio.Load("trapézio_isóceles.png");
                    }
                }
                else if (tipo == 2)
                {
                    if (angulo_visivel == true && divisao_visivel == true)
                    {
                        picTrapézio.Load("trapézio_escaleno_angulos_dividido.png");
                    }
                    else if (angulo_visivel == true && divisao_visivel == false)
                    {
                        picTrapézio.Load("trapézio_escaleno_angulos.png");
                    }
                    else if (angulo_visivel == false && divisao_visivel == true)
                    {
                        picTrapézio.Load("trapézio_escaleno_dividido.png");
                    }
                    else if (angulo_visivel == false && divisao_visivel == false)
                    {
                        picTrapézio.Load("trapézio_escaleno.png");
                    }
                }
                else if (tipo == 3)
                {
                    if (angulo_visivel == true && divisao_visivel == true)
                    {
                        picTrapézio.Load("trapézio_retângulo_angulos_dividido.png");
                    }
                    else if (angulo_visivel == true && divisao_visivel == false)
                    {
                        picTrapézio.Load("trapézio_retângulo_angulos.png");
                    }
                    else if (angulo_visivel == false && divisao_visivel == true)
                    {
                        picTrapézio.Load("trapézio_retângulo_dividido.png");
                    }
                    else if (angulo_visivel == false && divisao_visivel == false)
                    {
                        picTrapézio.Load("trapézio_retângulo.png");
                    }
                }
            }
            else
            {
                MessageBox.Show("A altura não está visível.");
            }
        }

        private void btnOcultarAngulos_Click(object sender, EventArgs e)
        {
            if (angulo_visivel == true)
            {
                angulo_visivel = false;
                lblAngulo1.Visible = false;
                lblAngulo2.Visible = false;
                lblAngulo3.Visible = false;
                lblAngulo4.Visible = false;
                btnAngulo1.Visible = false;
                btnAngulo2.Visible = false;
                btnAngulo3.Visible = false;
                btnAngulo4.Visible = false;

                if (tipo == 1)
                {
                    if (altura_visivel == true && divisao_visivel == true)
                    {
                        picTrapézio.Load("trapézio_isóceles_dividido.png");
                    }
                    else if (altura_visivel == true && divisao_visivel == false)
                    {
                        picTrapézio.Load("trapézio_isóceles_altura.png");
                    }
                    else if (altura_visivel == false && divisao_visivel == true)
                    {
                        picTrapézio.Load("trapézio_isóceles_dividido.png");
                    }
                    else if (altura_visivel == false && divisao_visivel == false)
                    {
                        picTrapézio.Load("trapézio_isóceles.png");
                    }
                }
                else if (tipo == 2)
                {
                    if (altura_visivel == true && divisao_visivel == true)
                    {
                        picTrapézio.Load("trapézio_escaleno_dividido.png");
                    }
                    else if (altura_visivel == true && divisao_visivel == false)
                    {
                        picTrapézio.Load("trapézio_escaleno_altura.png");
                    }
                    else if (altura_visivel == false && divisao_visivel == true)
                    {
                        picTrapézio.Load("trapézio_escaleno_dividido.png");
                    }
                    else if (altura_visivel == false && divisao_visivel == false)
                    {
                        picTrapézio.Load("trapézio_escaleno.png");
                    }
                }
                else if (tipo == 3)
                {
                    if (altura_visivel == true && divisao_visivel == true)
                    {
                        picTrapézio.Load("trapézio_retângulo_dividido.png");
                    }
                    else if (altura_visivel == true && divisao_visivel == false)
                    {
                        picTrapézio.Load("trapézio_retângulo.png");
                    }
                    else if (altura_visivel == false && divisao_visivel == true)
                    {
                        picTrapézio.Load("trapézio_retângulo_dividido.png");
                    }
                    else if (altura_visivel == false && divisao_visivel == false)
                    {
                        picTrapézio.Load("trapézio_retângulo.png");
                    }
                }
            }
            else
            {
                MessageBox.Show("Os ângulos não estão visíveis.");
            }
        }

        private void btnOcultarDivisões_Click(object sender, EventArgs e)
        {
            if (divisao_visivel == true)
            {
                divisao_visivel = false;
                btnBasetri1.Visible = false;
                btnBasetri2.Visible = false;

                //isósceles
                if (tipo == 1)
                {
                    if (altura_visivel == true && angulo_visivel == true)
                    {
                        picTrapézio.Load("trapézio_isóceles_altura_angulos.png");
                        pnlBotoesAltura.Location = new Point(371, 208);
                        lblAltura.Location = new Point(392, 175);
                        txtInserirAltura.Location = new Point(500, 242);
                        btnAltura.Location = new Point(345, 208);
                        btnAngulo1.Location = new Point(205, 77);
                        btnAngulo1.Size = new Size(29, 10);
                        btnAngulo2.Location = new Point(487, 77);
                        btnAngulo2.Size = new Size(29, 10);
                        lblAngulo1.Location = new Point(238, 108);
                        lblAngulo1.Font = new Font("Microsoft Sans Serif", 20);
                        lblAngulo2.Location = new Point(448, 108);
                        lblAngulo2.Font = new Font("Microsoft Sans Serif", 20);
                        lblAngulo1.Text = Convert.ToString(Math.Round(angulo1,2));
                        lblAngulo2.Text = Convert.ToString(Math.Round(angulo2,2));
                    }
                    else if (altura_visivel == true && angulo_visivel == false)
                    {
                        picTrapézio.Load("trapézio_isóceles_altura.png");
                        pnlBotoesAltura.Location = new Point(371, 208);
                        lblAltura.Location = new Point(392, 175);
                        txtInserirAltura.Location = new Point(500, 242);
                        btnAltura.Location = new Point(345, 208);
                        btnAngulo1.Location = new Point(205, 77);
                        btnAngulo1.Size = new Size(29, 10);
                        btnAngulo2.Location = new Point(487, 77);
                        btnAngulo2.Size = new Size(29, 10);
                        lblAngulo1.Location = new Point(238, 108);
                        lblAngulo1.Font = new Font("Microsoft Sans Serif", 20);
                        lblAngulo2.Location = new Point(448, 108);
                        lblAngulo2.Font = new Font("Microsoft Sans Serif", 20);
                        lblAngulo1.Text = Convert.ToString(Math.Round(angulo1,2));
                        lblAngulo2.Text = Convert.ToString(Math.Round(angulo2,2));
                    }
                    else if (altura_visivel == false && angulo_visivel == true)
                    {
                        picTrapézio.Load("trapézio_isóceles_angulos.png");
                        pnlBotoesAltura.Location = new Point(371, 208);
                        lblAltura.Location = new Point(392, 175);
                        txtInserirAltura.Location = new Point(500, 242);
                        btnAltura.Location = new Point(345, 208);
                        btnAngulo1.Location = new Point(205, 77);
                        btnAngulo1.Size = new Size(29, 10);
                        btnAngulo2.Location = new Point(487, 77);
                        btnAngulo2.Size = new Size(29, 10);
                        lblAngulo1.Location = new Point(238, 108);
                        lblAngulo1.Font = new Font("Microsoft Sans Serif", 20);
                        lblAngulo2.Location = new Point(448, 108);
                        lblAngulo2.Font = new Font("Microsoft Sans Serif", 20);
                        lblAngulo1.Text = Convert.ToString(Math.Round(angulo1,2));
                        lblAngulo2.Text = Convert.ToString(Math.Round(angulo2,2));
                    }
                    else if (altura_visivel == false && angulo_visivel == false)
                    {
                        picTrapézio.Load("trapézio_isóceles.png");
                        pnlBotoesAltura.Location = new Point(371, 208);
                        lblAltura.Location = new Point(392, 175);
                        txtInserirAltura.Location = new Point(500, 242);
                        btnAltura.Location = new Point(345, 208);
                        btnAngulo1.Location = new Point(205, 77);
                        btnAngulo1.Size = new Size(29, 10);
                        btnAngulo2.Location = new Point(487, 77);
                        btnAngulo2.Size = new Size(29, 10);
                        lblAngulo1.Location = new Point(238, 108);
                        lblAngulo1.Font = new Font("Microsoft Sans Serif", 20);
                        lblAngulo2.Location = new Point(448, 108);
                        lblAngulo2.Font = new Font("Microsoft Sans Serif", 20);
                        lblAngulo1.Text = Convert.ToString(Math.Round(angulo1,2));
                        lblAngulo2.Text = Convert.ToString(Math.Round(angulo2,2));
                    }
                }
                //escaleno
                else if (tipo == 2)
                {
                    if (altura_visivel == true && angulo_visivel == true)
                    {
                        picTrapézio.Load("trapézio_escaleno_altura_angulos.png");
                        pnlBotoesAltura.Location = new Point(371, 208);
                        lblAltura.Location = new Point(392, 175);
                        txtInserirAltura.Location = new Point(500, 242);
                        btnAltura.Location = new Point(345, 208);
                        btnAngulo1.Location = new Point(205, 77);
                        btnAngulo1.Size = new Size(29, 10);
                        btnAngulo2.Location = new Point(487, 77);
                        btnAngulo2.Size = new Size(29, 10);
                        lblAngulo1.Location = new Point(238, 108);
                        lblAngulo1.Font = new Font("Microsoft Sans Serif", 20);
                        lblAngulo2.Location = new Point(448, 108);
                        lblAngulo2.Font = new Font("Microsoft Sans Serif", 20);
                        lblAngulo1.Text = Convert.ToString(Math.Round(angulo1,2));
                        lblAngulo2.Text = Convert.ToString(Math.Round(angulo2,2));
                    }
                    else if (altura_visivel == true && angulo_visivel == false)
                    {
                        picTrapézio.Load("trapézio_escaleno_altura.png");
                        pnlBotoesAltura.Location = new Point(371, 208);
                        lblAltura.Location = new Point(392, 175);
                        txtInserirAltura.Location = new Point(500, 242);
                        btnAltura.Location = new Point(345, 208);
                        btnAngulo1.Location = new Point(205, 77);
                        btnAngulo1.Size = new Size(29, 10);
                        btnAngulo2.Location = new Point(487, 77);
                        btnAngulo2.Size = new Size(29, 10);
                        lblAngulo1.Location = new Point(238, 108);
                        lblAngulo1.Font = new Font("Microsoft Sans Serif", 20);
                        lblAngulo2.Location = new Point(448, 108);
                        lblAngulo2.Font = new Font("Microsoft Sans Serif", 20);
                        lblAngulo1.Text = Convert.ToString(Math.Round(angulo1,2));
                        lblAngulo2.Text = Convert.ToString(Math.Round(angulo2,2));
                    }
                    else if (altura_visivel == false && angulo_visivel == true)
                    {
                        picTrapézio.Load("trapézio_escaleno_angulos.png");
                        pnlBotoesAltura.Location = new Point(371, 208);
                        lblAltura.Location = new Point(392, 175);
                        txtInserirAltura.Location = new Point(500, 242);
                        btnAltura.Location = new Point(345, 208);
                        btnAngulo1.Location = new Point(205, 77);
                        btnAngulo1.Size = new Size(29, 10);
                        btnAngulo2.Location = new Point(487, 77);
                        btnAngulo2.Size = new Size(29, 10);
                        lblAngulo1.Location = new Point(238, 108);
                        lblAngulo1.Font = new Font("Microsoft Sans Serif", 20);
                        lblAngulo2.Location = new Point(448, 108);
                        lblAngulo2.Font = new Font("Microsoft Sans Serif", 20);
                        lblAngulo1.Text = Convert.ToString(Math.Round(angulo1,2));
                        lblAngulo2.Text = Convert.ToString(Math.Round(angulo2,2));
                    }
                    else if (altura_visivel == false && angulo_visivel == false)
                    {
                        picTrapézio.Load("trapézio_escaleno.png");
                        pnlBotoesAltura.Location = new Point(371, 208);
                        lblAltura.Location = new Point(392, 175);
                        txtInserirAltura.Location = new Point(500, 242);
                        btnAltura.Location = new Point(345, 208);
                        btnAngulo1.Location = new Point(205, 77);
                        btnAngulo1.Size = new Size(29, 10);
                        btnAngulo2.Location = new Point(487, 77);
                        btnAngulo2.Size = new Size(29, 10);
                        lblAngulo1.Location = new Point(238, 108);
                        lblAngulo1.Font = new Font("Microsoft Sans Serif", 20);
                        lblAngulo2.Location = new Point(448, 108);
                        lblAngulo2.Font = new Font("Microsoft Sans Serif", 20);
                        lblAngulo1.Text = Convert.ToString(Math.Round(angulo1,2));
                        lblAngulo2.Text = Convert.ToString(Math.Round(angulo2,2));
                    }
                }
                //retângulo
                else if (tipo == 3)
                {
                    if (altura_visivel == true && angulo_visivel == true)
                    {
                        picTrapézio.Load("trapézio_retângulo_angulos.png");
                        btnAngulo2.Location = new Point(417, 66);
                        btnAngulo2.Size = new Size(29, 10);
                        lblAngulo2.Location = new Point(380, 79);
                        lblAngulo2.Font = new Font("Microsoft Sans Serif", 20);
                        lblAngulo2.Text = Convert.ToString(Math.Round(angulo2,2));
                    }
                    else if (altura_visivel == true && angulo_visivel == false)
                    {
                        picTrapézio.Load("trapézio_retângulo_altura_angulos.png");
                        btnAngulo2.Location = new Point(417, 66);
                        btnAngulo2.Size = new Size(29, 10);
                        lblAngulo2.Location = new Point(380, 79);
                        lblAngulo2.Font = new Font("Microsoft Sans Serif", 20);
                        lblAngulo2.Text = Convert.ToString(Math.Round(angulo2,2));
                    }
                    else if (altura_visivel == false && angulo_visivel == true)
                    {
                        picTrapézio.Load("trapézio_retângulo_angulos.png");
                        btnAngulo2.Location = new Point(417, 66);
                        btnAngulo2.Size = new Size(29, 10);
                        lblAngulo2.Location = new Point(380, 79);
                        lblAngulo2.Font = new Font("Microsoft Sans Serif", 20);
                        lblAngulo2.Text = Convert.ToString(Math.Round(angulo2,2));
                    }
                    else if (altura_visivel == false && angulo_visivel == false)
                    {
                        picTrapézio.Load("trapézio_retângulo_angulos.png");
                        btnAngulo2.Location = new Point(417, 66);
                        btnAngulo2.Size = new Size(29, 10);
                        lblAngulo2.Location = new Point(380, 79);
                        lblAngulo2.Font = new Font("Microsoft Sans Serif", 20);
                        lblAngulo2.Text = Convert.ToString(Math.Round(angulo2,2));
                    }
                }
            }
            else
            {
                MessageBox.Show("As divisões não estão visíveis.");
            }
        }

        private void picTrapézio_Click(object sender, EventArgs e)
        {

        }

        private void txtInserirBaseMaior_Leave(object sender, EventArgs e)
        {
            pnlBotoesBaseMaior.Visible = false;
            txtInserirBaseMaior.Visible = false;
        }

        private void TipoTrapézio()
        {
            if (lado1 != lado2)
            {
                if ((angulo1 > 90 || angulo1 == 0) && (lado1 != 0 && lado2 != 0))
                {
                    this.tipo = 2;
                }
                else if (angulo1 == 90)
                {
                    this.tipo = 3;
                }
            }
            else if (angulo1 != angulo2)
            {
                if ((angulo1 > 90) && (lado1 != 0 && lado2 != 0))
                {
                    this.tipo = 2;
                }
                else if (angulo1 == 90)
                {
                    this.tipo = 3;
                }
                else
                {
                    this.tipo = 2;
                }
            }
            else if (angulo4 != angulo3)
            {
                if ((angulo1 > 90) && (lado1 != 0 && lado2 != 0))
                {
                    this.tipo = 2;
                }
                else if (angulo1 == 90)
                {
                    this.tipo = 3;
                }
                else
                {
                    this.tipo = 2;
                }
            }
            if (lado1 == lado2)
            {
                this.tipo = 1;
            }
            else if (angulo1 != 0)
            {

                if (angulo1 == angulo2)
                {
                    this.tipo = 1;
                }
            }
            else if (angulo4 != 0)
            {
                if (angulo4 == angulo3)
                {
                    this.tipo = 1;
                }
            }

            if (angulo1 == 90 )
            {
                this.angulo4 = 90;
                this.tipo = 3;
            }
            else if (angulo2 == 90)
            {
                this.angulo1 = 90;
                this.angulo4 = 90;
                this.angulo2 = 0;
                this.tipo = 3;
            }
            else if (angulo3 == 90)
            {
                this.angulo1 = 90;
                this.angulo4 = 90;
                this.angulo3 = 0;
                this.tipo = 3;
            }
            else if (angulo4 == 90)
            {
                this.angulo1 = 90;
                this.angulo4 = 90;
                this.tipo = 3;
            }

            if (tipo == 1) //isóceles
            {
                lblTipo.Text = "Isósceles";

                if (angulo_visivel == true && altura_visivel == true && divisao_visivel == true)
                {
                    picTrapézio.Load("trapézio_isóceles_angulos_dividido.png");
                }
                else if (angulo_visivel == true && altura_visivel == false && divisao_visivel == true)
                {
                    picTrapézio.Load("trapézio_isóceles_angulos_dividido.png");
                }
                else if (angulo_visivel == false && altura_visivel == true && divisao_visivel == true)
                {
                    picTrapézio.Load("trapézio_isóceles_dividido.png");
                }
                else if (angulo_visivel == false && altura_visivel == false && divisao_visivel == true)
                {
                    picTrapézio.Load("trapézio_isóceles_dividido.png");
                }
                else if (angulo_visivel == true && altura_visivel == false && divisao_visivel == false)
                {
                    picTrapézio.Load("trapézio_isóceles_angulos.png");
                }
                else if (angulo_visivel == true && altura_visivel == true && divisao_visivel == false)
                {
                    picTrapézio.Load("trapézio_isóceles_altura_angulos.png");
                }
                else if (angulo_visivel == false && altura_visivel == true && divisao_visivel == false)
                {
                    picTrapézio.Load("trapézio_isóceles_altura.png");
                }
                else if (angulo_visivel == false && altura_visivel == false && divisao_visivel == false)
                {
                    picTrapézio.Load("trapézio_isóceles.png");
                }

                    //panels
                    pnlBotoesLado1.Location = new Point(148, 167);
                    pnlBotoesLado2.Location = new Point(419, 168);
                    pnlBotoesBaseMaior.Location = new Point(293, 282);
                    pnlBotoesBaseMenor.Location = new Point(294, 63);
                    pnlBotoesAltura.Location = new Point(371, 208);
                    pnlBotoesBasetri1.Location = new Point(87, 290);
                    pnlBotoesBasetri2.Location = new Point(540, 276);
                    pnlAngulo1.Location = new Point(168, 128);
                    pnlAngulo2.Location = new Point(450, 141);
                    pnlAngulo3.Location = new Point(474, 347);
                    pnlAngulo4.Location = new Point(136, 325);

                    //labels
                    lblLado1.Location = new Point(51, 175);
                    lblLado2.Location = new Point(637, 175);
                    lblBaseMaior.Location = new Point(342, 408);
                    lblBaseMenor.Location = new Point(342, 6);
                    lblAltura.Location = new Point(392, 175);
                    lblBasetri1.Location = new Point(86, 398);
                    lblBasetri2.Location = new Point(596, 398);
                    lblAngulo1.Location = new Point(238, 108);
                    lblAngulo2.Location = new Point(448, 108);
                    lblAngulo3.Location = new Point(532, 299);
                    lblAngulo4.Location = new Point(116, 305);

                    //textbox
                    txtInserirLado1.Location = new Point(280, 196);
                    txtInserirLado2.Location = new Point(552, 203);
                    txtInserirBaseMaior.Location = new Point(422, 317);
                    txtInserirBaseMenor.Location = new Point(426, 98);
                    txtInserirAltura.Location = new Point(500, 242);
                    txtInserirBasetri1.Location = new Point(219, 324);
                    txtInserirBasetri2.Location = new Point(671, 311);
                    txtInserirAngulo1.Location = new Point(298, 163);
                    txtInserirAngulo2.Location = new Point(580, 175);
                    txtInserirAngulo3.Location = new Point(604, 382);
                    txtInserirAngulo4.Location = new Point(268, 359);

                    //buttons
                    btnLado1.Location = new Point(101, 208);
                    btnLado2.Location = new Point(586, 208);
                    btnBaseMaior.Location = new Point(359, 359);
                    btnBaseMenor.Location = new Point(359, 38);
                    btnAltura.Location = new Point(345, 208);
                    btnBasetri1.Location = new Point(113, 359);
                    btnBasetri2.Location = new Point(594, 359);
                    btnAngulo1.Location = new Point(205, 77);
                    btnAngulo1.Size = new Size(29, 10);
                    btnAngulo2.Location = new Point(487, 77);
                    btnAngulo2.Size = new Size(29, 10);
                    btnAngulo3.Location = new Point(611, 347);
                    btnAngulo4.Location = new Point(75, 347);
                btnAngulo4.Size = new Size(29, 10);

            }
            else if (tipo == 2) //escaleno
            {
                lblTipo.Text = "Escaleno";

                if (angulo_visivel == true && altura_visivel == true && divisao_visivel == true)
                {
                    picTrapézio.Load("trapézio_escaleno_angulos_dividido.png");
                }
                else if (angulo_visivel == true && altura_visivel == false && divisao_visivel == true)
                {
                    picTrapézio.Load("trapézio_escaleno_angulos_dividido.png");
                }
                else if (angulo_visivel == false && altura_visivel == true && divisao_visivel == true)
                {
                    picTrapézio.Load("trapézio_escaleno_dividido.png");
                }
                else if (angulo_visivel == false && altura_visivel == false && divisao_visivel == true)
                {
                    picTrapézio.Load("trapézio_escaleno_dividido.png");
                }
                else if (angulo_visivel == true && altura_visivel == false && divisao_visivel == false)
                {
                    picTrapézio.Load("trapézio_escaleno_angulos.png");
                }
                else if (angulo_visivel == true && altura_visivel == true && divisao_visivel == false)
                {
                    picTrapézio.Load("trapézio_escaleno_altura_angulos.png");
                }
                else if (angulo_visivel == false && altura_visivel == true && divisao_visivel == false)
                {
                    picTrapézio.Load("trapézio_escaleno_altura.png");
                }
                else if (angulo_visivel == false && altura_visivel == false && divisao_visivel == false)
                {
                    picTrapézio.Load("trapézio_escaleno.png");
                }

                    //panels
                    pnlBotoesLado1.Location = new Point(148, 167);
                    pnlBotoesLado2.Location = new Point(419, 168);
                    pnlBotoesBaseMaior.Location = new Point(293, 282);
                    pnlBotoesBaseMenor.Location = new Point(294, 63);
                    pnlBotoesAltura.Location = new Point(371, 208);
                    pnlBotoesBasetri1.Location = new Point(87, 290);
                    pnlBotoesBasetri2.Location = new Point(540, 276);
                    pnlAngulo1.Location = new Point(168, 128);
                    pnlAngulo2.Location = new Point(450, 141);
                    pnlAngulo3.Location = new Point(474, 347);
                    pnlAngulo4.Location = new Point(136, 325);

                    //labels
                    lblLado1.Location = new Point(51, 175);
                    lblLado2.Location = new Point(614, 175);
                    lblBaseMaior.Location = new Point(342, 408);
                    lblBaseMenor.Location = new Point(342, 6);
                    lblAltura.Location = new Point(392, 175);
                    lblBasetri1.Location = new Point(86, 398);
                    lblBasetri2.Location = new Point(553, 398);
                    lblAngulo1.Location = new Point(238, 108);
                    lblAngulo2.Location = new Point(448, 108);
                    lblAngulo3.Location = new Point(532, 299);
                    lblAngulo4.Location = new Point(116, 305);

                    //textbox
                    txtInserirLado1.Location = new Point(280, 196);
                    txtInserirLado2.Location = new Point(552, 203);
                    txtInserirBaseMaior.Location = new Point(422, 317);
                    txtInserirBaseMenor.Location = new Point(426, 98);
                    txtInserirAltura.Location = new Point(500, 242);
                    txtInserirBasetri1.Location = new Point(219, 324);
                    txtInserirBasetri2.Location = new Point(671, 311);
                    txtInserirAngulo1.Location = new Point(298, 163);
                    txtInserirAngulo2.Location = new Point(580, 175);
                    txtInserirAngulo3.Location = new Point(604, 382);
                    txtInserirAngulo4.Location = new Point(268, 359);

                    //buttons
                    btnLado1.Location = new Point(101, 208);
                    btnLado2.Location = new Point(563, 208);
                    btnBaseMaior.Location = new Point(359, 359);
                    btnBaseMenor.Location = new Point(359, 38);
                    btnAltura.Location = new Point(345, 208);
                    btnBasetri1.Location = new Point(113, 359);
                    btnBasetri2.Location = new Point(569, 359);
                    btnAngulo1.Location = new Point(205, 77);
                    btnAngulo1.Size = new Size(29, 10);
                    btnAngulo2.Location = new Point(518, 84);
                    btnAngulo2.Size = new Size(29, 10);
                    btnAngulo3.Location = new Point(581, 347);
                    btnAngulo4.Location = new Point(67, 347);
                btnAngulo4.Size = new Size(29, 10);

                if (divisao_visivel == true)
                {
                    btnAngulo1.Location = new Point(184, 84);
                    btnAngulo1.Size = new Size(10, 24);
                    lblAngulo1.Location = new Point(156, 144);
                    lblAngulo1.Font = new Font("Microsoft Sans Serif", 16);
                    lblAngulo1.Text = Convert.ToString(angulo1 - 90);
                    btnAngulo2.Location = new Point(520, 84);
                    btnAngulo2.Size = new Size(10, 24);
                    lblAngulo2.Location = new Point(520, 144);
                    lblAngulo2.Font = new Font("Microsoft Sans Serif", 16);
                    lblAngulo2.Text = Convert.ToString(angulo2 - 90);
                    btnAltura.Location = new Point(181, 208);
                    lblAltura.Location = new Point(226, 197);
                    pnlBotoesAltura.Location = new Point(59, 170);
                    txtInserirAltura.Location = new Point(188, 204);
                }
            }
            //retângulo
            else if (tipo == 3)
            {
                lblTipo.Text = "Retângulo";

                btnAltura.Visible = false;
                lblAltura.Visible= false;
                btnBasetri1.Visible = false;
                lblBasetri1.Visible = false;

                if (lado1 <= lado2)
                {
                    this.lado2 = 0;
                    lblLado2.Visible = false;
                }

                if (angulo_visivel == true && altura_visivel == true && divisao_visivel == true)
                {
                    picTrapézio.Load("trapézio_retângulo_angulos_dividido.png");
                }
                else if (angulo_visivel == true && altura_visivel == false && divisao_visivel == true)
                {
                    picTrapézio.Load("trapézio_retângulo_angulos_dividido.png");
                }
                else if (angulo_visivel == false && altura_visivel == true && divisao_visivel == true)
                {
                    picTrapézio.Load("trapézio_retângulo_dividido.png");
                }
                else if (angulo_visivel == false && altura_visivel == false && divisao_visivel == true)
                {
                    picTrapézio.Load("trapézio_retângulo_dividido.png");
                }
                else if (angulo_visivel == true && altura_visivel == false && divisao_visivel == false)
                {
                    picTrapézio.Load("trapézio_retângulo_angulos.png");
                }
                else if (angulo_visivel == true && altura_visivel == true && divisao_visivel == false)
                {
                    picTrapézio.Load("trapézio_retângulo_angulos.png");
                }
                else if (angulo_visivel == false && altura_visivel == true && divisao_visivel == false)
                {
                    picTrapézio.Load("trapézio_retângulo.png");
                }
                else if (angulo_visivel == false && altura_visivel == false && divisao_visivel == false)
                {
                    picTrapézio.Load("trapézio_retângulo.png");
                }

                //panels
                pnlBotoesLado1.Location = new Point(148, 167);
                pnlBotoesLado2.Location = new Point(558, 153);
                pnlBotoesBaseMaior.Location = new Point(293, 282);
                pnlBotoesBaseMenor.Location = new Point(294, 63);
                pnlBotoesAltura.Location = new Point(371, 208);
                pnlBotoesBasetri1.Location = new Point(87, 290);
                pnlBotoesBasetri2.Location = new Point(491, 317);
                pnlAngulo1.Location = new Point(168, 120);
                pnlAngulo2.Location = new Point(343, 120);
                pnlAngulo3.Location = new Point(408, 243);
                pnlAngulo4.Location = new Point(168, 243);

                //labels
                lblLado1.Location = new Point(52, 175);
                lblLado2.Location = new Point(576, 175);
                lblBaseMaior.Location = new Point(636, 175);
                lblBaseMenor.Location = new Point(303, 0);
                lblAltura.Location = new Point(392, 175);
                lblBasetri1.Location = new Point(86, 398);
                lblBasetri2.Location = new Point(508, 406);
                lblAngulo1.Location = new Point(142, 72);
                lblAngulo2.Location = new Point(380, 79);
                lblAngulo3.Location = new Point(536, 313);
                lblAngulo4.Location = new Point(142, 320);

                //textbox
                txtInserirLado1.Location = new Point(280, 196);
                txtInserirLado2.Location = new Point(691, 188);
                txtInserirBaseMaior.Location = new Point(359, 369);
                txtInserirBaseMenor.Location = new Point(426, 98);
                txtInserirAltura.Location = new Point(500, 242);
                txtInserirBasetri1.Location = new Point(219, 324);
                txtInserirBasetri2.Location = new Point(621, 352);
                txtInserirAngulo1.Location = new Point(298, 155);
                txtInserirAngulo2.Location = new Point(474, 155);
                txtInserirAngulo3.Location = new Point(539, 278);
                txtInserirAngulo4.Location = new Point(300, 277);

                //buttons
                btnLado1.Location = new Point(88, 208);
                btnLado2.Location = new Point(528, 208);
                btnBaseMaior.Location = new Point(359, 359);
                btnBaseMenor.Location = new Point(287, 21);
                btnAltura.Location = new Point(345, 208);
                btnBasetri1.Location = new Point(113, 359);
                btnBasetri2.Location = new Point(527, 369);
                btnAngulo1.Location = new Point(113, 44);
                btnAngulo1.Size = new Size(10, 36);
                btnAngulo2.Location = new Point(417, 66);
                btnAngulo2.Size = new Size(29, 10);
                btnAngulo3.Location = new Point(567, 356);
                btnAngulo4.Location = new Point(113, 343);
                btnAngulo4.Size = new Size(10, 36);

                if (divisao_visivel == true)
                {
                    picTrapézio.Load("trapézio_retângulo_angulos.png");
                    btnAngulo2.Location = new Point(463, 72);
                    btnAngulo2.Size = new Size(29, 10);
                    lblAngulo2.Location = new Point(464, 122);
                    lblAngulo2.Font = new Font("Microsoft Sans Serif", 20);
                    lblAngulo2.Text = Convert.ToString(angulo2);
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

             //variaveis
             this.lado1 = 0;
             this.lado2 = 0;
             this.baseMaior = 0;
             this.baseMenor = 0;
             this.basetri1 = 0;
             this.basetri2 = 0;
             this.altura = 0;
             this.angulo1 = 0;
             this.angulo2 = 0;
             this.angulo3 = 0;
             this.angulo4 = 0;
             this.altura_visivel = false; ;
             this.angulo_visivel = false; ;
             this.divisao_visivel = false;
            //1 = isóceles | 2 = escaleno | 3 = retângulo

            //labels
             this.lblBaseMaior.Visible = false;
             this.lblBaseMenor.Visible = false;
             this.lblLado1.Visible = false;
             this.lblLado2.Visible = false;
             this.lblAltura.Visible = false;
             this.lblAngulo1.Visible = false;
             this.lblAngulo2.Visible = false;
             this.lblAngulo3.Visible = false;
             this.lblAngulo4.Visible = false;
             this.lblArea.Text = "Área: ";
             this.lblPerimetro.Text = "Perímetro: ";
             this.lblExplicacaoTexto.Visible = false;

            //buttons
            btnBasetri1.Visible = false;
            btnBasetri2.Visible = false;
            btnAltura.Visible = false;
            btnAngulo1.Visible = false;
            btnAngulo2.Visible = false;
            btnAngulo3.Visible = false;
            btnAngulo4.Visible = false;

            //imagem
            if (tipo == 1)
            {
                picTrapézio.Load("trapézio_isóceles.png");
            }
            else if (tipo == 2)
            {
                picTrapézio.Load("trapézio_escaleno.png");
            }
            else if (tipo == 3)
            {
                picTrapézio.Load("trapézio_retângulo.png");
            }
        }

    }
}
