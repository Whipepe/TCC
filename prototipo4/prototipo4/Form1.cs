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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PagInicial uc = new PagInicial();
            addUserControl(uc);
        }

    private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnlGeral.Controls.Clear();
            pnlGeral.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btnAreaExe_Click(object sender, EventArgs e)
        {
            AreaExe uc = new AreaExe();
            addUserControl(uc);
            btnAreaExe.FlatAppearance.BorderColor = Color.Fuchsia;
            btnPaginaInicial.FlatAppearance.BorderColor = Color.Cyan;      }

        private void btnPaginaInicial_Click(object sender, EventArgs e)
        {
            PagInicial uc = new PagInicial();
            addUserControl(uc);
            btnPaginaInicial.FlatAppearance.BorderColor = Color.Fuchsia;
            btnAreaExe.FlatAppearance.BorderColor = Color.Cyan;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
