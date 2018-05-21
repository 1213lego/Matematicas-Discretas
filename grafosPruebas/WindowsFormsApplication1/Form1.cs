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
    public partial class Form1 : Form
    {
        private ServicioGrafo servicioGrafo;
        public Form1()
        {
            InitializeComponent();
            servicioGrafo = new ServicioGrafo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text)+1;
            dataGridView1.RowCount = x;
            dataGridView1.ColumnCount = x;
            for(int i=1, k=65;i<dataGridView1.ColumnCount;i++,k++)
            {
                dataGridView1[i,0].Value = Convert.ToString(Convert.ToChar(k));
                dataGridView1[0, i].Value = Convert.ToString(Convert.ToChar(k));

            }
            llenar();
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoResizeRows();
        }
        public void llenar()
        {
            for(int i=1; i<dataGridView1.RowCount;i++)
            {
                for(int j=1;j<dataGridView1.ColumnCount; j++)
                {
                    dataGridView1[j, i].Value = 0;
                }
            }
        }
        private void dataGridView1_CellContentdoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=1 && e.ColumnIndex>=1)
            {
               if (Convert.ToInt32(dataGridView1[e.ColumnIndex, e.RowIndex].Value) == 1)
                {
                    dataGridView1[e.ColumnIndex, e.RowIndex].Value = 0;
                }
                else
                {
                    dataGridView1[e.ColumnIndex, e.RowIndex].Value = 1;
                }
            }           
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            string [,] matrizGrafo = new string[dataGridView1.RowCount-1 , dataGridView1.ColumnCount -1];
            for (int i = 1; i < dataGridView1.RowCount; i++)
            {
                for (int j = 1; j < dataGridView1.ColumnCount; j++)
                {
                    matrizGrafo[i-1 , j-1 ] =Convert.ToString(dataGridView1[j, i].Value);
                }
            }
            servicioGrafo.setGrafo(matrizGrafo);
            string nodoOrigen = textBoxOrigen.Text.ToUpper();
            string nodoDestino = textBoxDestino.Text.ToUpper();
            MessageBox.Show(servicioGrafo.calcularRuta(nodoOrigen, nodoDestino));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[,] matrizGrafo = new string[dataGridView1.RowCount - 1, dataGridView1.ColumnCount - 1];
            for (int i = 1; i < dataGridView1.RowCount; i++)
            {
                for (int j = 1; j < dataGridView1.ColumnCount; j++)
                {
                    matrizGrafo[i - 1, j - 1] = Convert.ToString(dataGridView1[j, i].Value);
                }
            }
            servicioGrafo.setGrafo(matrizGrafo);
            string nodoOrigen = textBoxOrigen.Text.ToUpper();
            string nodoDestino = textBoxDestino.Text.ToUpper();
            string [,] s = servicioGrafo.bfs(nodoOrigen);
            dataGridView2.RowCount = s.GetLength(0);
            dataGridView2.ColumnCount = s.GetLength(1);
            for(int i=0; i< dataGridView2.RowCount;i++)
            {
                for(int j=0;j<dataGridView2.ColumnCount;j++)
                {
                    dataGridView2[j, i].Value = s[i, j];
                }
            }
            dataGridView2.AutoResizeColumns();
            dataGridView2.AutoResizeRows();
            MessageBox.Show(servicioGrafo.ruta(nodoOrigen, nodoDestino));
        }
    }
}
