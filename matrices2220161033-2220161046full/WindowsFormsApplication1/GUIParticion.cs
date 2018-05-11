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
    public partial class GUIParticion : Form
    {

        private Matriz matriz;
        public GUIParticion()
        {
            InitializeComponent();
            matriz = new Matriz();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt.Text == null || txt.Text == "")
            {
                MessageBox.Show("No ha ingresado el tamaño de la matriz");
            }
            else
            {
                generarPrimeraMatriz();
                generarSegundaMatriz();
            }

        }

        public void generarPrimeraMatriz()
        {

            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ColumnHeadersVisible = false;

            int num = Convert.ToInt32(txt.Text);
            matriz.generarMatriz(num);
            if (num % 2 == 0)
            {
                dataGridView1.AutoSize = true;
                dataGridView1.ColumnCount = num;
                dataGridView1.RowCount = num;
                dataGridView1.AutoResizeColumns();
            }
            else
            {
                dataGridView1.AutoSize = true;
                dataGridView1.ColumnCount = num + 1;
                dataGridView1.RowCount = num + 1;
                dataGridView1.AutoResizeColumns();

            }


        }

        public void generarSegundaMatriz()
        {

            dataGridView2.RowHeadersVisible = false;
            dataGridView2.ColumnHeadersVisible = false;

            int num = Convert.ToInt32(txt.Text);
            matriz.generarMatriz2(num);
            if (num % 2 == 0)
            {
                dataGridView2.AutoSize = true;
                dataGridView2.ColumnCount = num;
                dataGridView2.RowCount = num;
                dataGridView2.AutoResizeColumns();
            }
            else
            {
                dataGridView2.AutoSize = true;
                dataGridView2.ColumnCount = num + 1;
                dataGridView2.RowCount = num + 1;
                dataGridView2.AutoResizeColumns();
            }

        }

        public void generarTerceraMatriz(int x)
        {

            dataGridView3.RowHeadersVisible = false;
            dataGridView3.ColumnHeadersVisible = false;

            dataGridView3.Columns.Clear();
            dataGridView3.Rows.Clear();
            int num = x;
            dataGridView3.AutoSize = true;
            dataGridView3.ColumnCount = num;
            dataGridView3.RowCount = num;
            dataGridView3.AutoResizeColumns();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                matriz.rellenarMatriz();
                matriz.rellenarMatriz2();
                int[,] matriz1 = matriz.getMatriz();
                int[,] matriz2 = matriz.getMatriz2();
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        dataGridView1[j, i].Value = matriz1[i, j];
                        dataGridView2[j, i].Value = matriz2[i, j];
                    }
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            
            try
            {
                int[,] matriz3 = matriz.multParticion();
                generarTerceraMatriz(matriz3.GetLength(0));
                for (int i = 0; i < dataGridView3.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView3.ColumnCount; j++)
                    {
                        dataGridView3[j, i].Value = matriz3[i, j];

                    }
                }
                dataGridView3.AutoResizeColumns();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

    }
}
