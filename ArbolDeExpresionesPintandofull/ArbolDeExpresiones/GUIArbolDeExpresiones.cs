using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArbolDeExpresiones
{
    public partial class GUIArbolDeExpresiones : Form
    {

        private ServicioArbolBinario arbol;
        public GUIArbolDeExpresiones()
        {
            arbol = new ServicioArbolBinario();
            InitializeComponent();
        }

        private void buttonGenerar_Click_1(object sender, EventArgs e)
        {
           try
            {
                arbol.generarArbol(textBoxGeneral.Text, textBoxValor.Text);
                panelDibujo.CreateGraphics().Clear(Color.White);
                arbol.pintar(panelDibujo.CreateGraphics(), panelDibujo.Size);
                MessageBox.Show("Se ha generado el arbol de expresiones");
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void buttonEvaluar_Click_1(object sender, EventArgs e)
        {
            try
            {
                textBoxEvaluar.Text = arbol.evaluar();
                panelDibujo.CreateGraphics().Clear(Color.White);
                arbol.pintar(panelDibujo.CreateGraphics(), panelDibujo.Size);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void buttonRecorrer_Click_1(object sender, EventArgs e)
        {
            textBoxPreOrder.Text = arbol.preOrden();
            textBoxPostOrder.Text = arbol.postOrden();
            textBoxInorder.Text = arbol.inorden();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Existen "+arbol.ContarNodos().ToString()+" nodos","Numero Nodos");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(arbol.buscar(txtBuscar.Text).ToString());
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                arbol.eliminar(txtBuscar.Text);
                panelDibujo.CreateGraphics().Clear(Color.White);
                arbol.pintar(panelDibujo.CreateGraphics(), panelDibujo.Size);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void mostrarRuta_Click(object sender, EventArgs e)
        {
            try
            {
                string nodo = txtNumeroRuta.Text;
                txtRuta.Text = arbol.mostrarRuta(nodo);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
