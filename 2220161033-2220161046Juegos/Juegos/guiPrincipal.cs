using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juegos
{
    public partial class guiPrincipal : Form
    {
        public guiPrincipal()
        {
            InitializeComponent();
        }

        private void servicioListasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form servicioListas = new guiLista();
            servicioListas.Show();
        }

        private void servicioArchivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form servicioArchivos = new guiJuego();
            servicioArchivos.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form acercaDe = new acercaDe();
            acercaDe.Show();
        }
    }
}
