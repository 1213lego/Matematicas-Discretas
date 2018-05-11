using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class GUIPrincipal : Form
    {
        public GUIPrincipal()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form clase = new GUIClasico();
            clase.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form particion = new GUIParticion();
            particion.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form strassen = new GUIStrassen();
            strassen.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form winograd = new GUIWinograd();
            winograd.Show();
        }
    }
}
