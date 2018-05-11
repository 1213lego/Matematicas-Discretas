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
    public partial class guiLista : Form
    {
        private int posi;
        private ServicioLista servicioLista;
        public guiLista()
        {
            InitializeComponent();
            posi = 0;
            servicioLista = new ServicioLista();
        }
    
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string titulo = txtTitulo.Text;
                string genero = listBoxGenero.Text;
                int precio = Convert.ToInt32(txtPrecio.Text);
                DateTime dt = DateTime.Parse(dateTimePicker1.Text);
                JuegoNodo juego = new JuegoNodo(precio, titulo, genero, dt,Juego.ACTIVO);
                servicioLista.agregarInicio(juego);
                actualizaGrilla();
                reiniciarCampos();
            }
            catch(FormatException fe)
            {
                MessageBox.Show("En el precio solo se puede ingresar enteros");
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }                                 
        }

       

        private void butLeerEn_Click(object sender, EventArgs e)
        {
            try
            {
                if (posi == 0 )
                {
                    int posicion = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese la posicion del juego a buscar: "));
                    JuegoNodo jj = servicioLista.buscarPorPosicion(posicion);
                    posi = posicion;
                    grillaListas.Rows[posi - 1].Selected = true;
                    grillaListas.CurrentCell = grillaListas.Rows[posi-1].Cells[0];                    
                }
                else
                {
                    grillaListas.Rows[posi - 1].Selected = false;
                    grillaListas.CurrentCell = grillaListas.Rows[0].Cells[0];
                    int posicion = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese la posicion del juego a buscar: "));                    
                    JuegoNodo jj = servicioLista.buscarPorPosicion(posicion);
                    posi = posicion;
                    grillaListas.Rows[posi - 1].Selected = true;
                    grillaListas.CurrentCell = grillaListas.Rows[posi - 1].Cells[0];
                }
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void buttBuscar_Click(object sender, EventArgs e)
        {
           try
            {
                if(posi==0)
                {
                    string titulo = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el titulo el cual desea buscar: ");
                    int posicion = servicioLista.buscarPorTitulo(titulo);
                    posi = posicion;
                    grillaListas.Rows[posi - 1].Selected = true;
                    grillaListas.CurrentCell = grillaListas.Rows[posi - 1].Cells[0];
                }
                else
                {
                    grillaListas.Rows[posi - 1].Selected = false;
                    grillaListas.CurrentCell = grillaListas.Rows[0].Cells[0];
                    string titulo = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el titulo el cual desea buscar: ");
                    int posicion = servicioLista.buscarPorTitulo(titulo);
                    posi = posicion;
                    grillaListas.Rows[posi - 1].Selected = true;
                    grillaListas.CurrentCell = grillaListas.Rows[posi - 1].Cells[0];
                }
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.Message);
            }

        }
        public void reiniciarCampos()
        {
            txtTitulo.Clear();
            txtPrecio.Clear();
            
            listBoxGenero.ClearSelected();
            txtTitulo.ReadOnly = false;
            
            dateTimePicker1.Enabled = true;
            listBoxGenero.Enabled = true;
            txtPrecio.ReadOnly = false;
        }                        
        private void llenarCampos(Juego jj)
        {
            txtTitulo.Text = jj.darTitulo();
            txtPrecio.Text = jj.darPrecio().ToString();
            dateTimePicker1.Text = jj.darFecha().ToShortDateString();
            listBoxGenero.Text = jj.darGenero();       
        }

        private void butReiniciar_Click(object sender, EventArgs e)
        {
            reiniciarCampos();         
        }

        private void butEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int fila = grillaListas.CurrentRow.Index;                             
                    if(MessageBox.Show("Esta seguro de eliminar le juego: " + grillaListas.Rows[fila].Cells[1].Value, "Atencion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        servicioLista.eliminar(fila + 1);
                        actualizaGrilla();
                        MessageBox.Show("se ha eliminado");
                    }
                    return;                              
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
       private void butVolcar_Click(object sender, EventArgs e)
        {
            try
            {
                servicioLista.seleccionarRutaVolcado();
                servicioLista.hayRutaVolcado();
                if (MessageBox.Show("Esta seguro que desea volcar los datos de la ruta: " + servicioLista.darRutavolcado(), "Atencion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    servicioLista.volcar();
                    //servicioLista.recorrer();
                    actualizaGrilla();
                    servicioLista.quitaRutaVolcado();
                    MessageBox.Show("Se han volcado los datos");
                }
                else
                {
                    return;
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void actualizaGrilla()
        {
            grillaListas.Rows.Clear();
            JuegoNodo cabeza = servicioLista.getCabeza();
            int i = 0;            
            while(cabeza!=null)
            {
                i++;
                string[] datos = new string[5];
                datos[0] = i.ToString();
                datos[1] = cabeza.darTitulo();
                datos[2] = cabeza.darGenero();
                datos[3] = cabeza.darPrecio().ToString();
                datos[4] = cabeza.darFecha().ToShortDateString();
                grillaListas.Rows.Add(datos);
                cabeza = cabeza.getSiguiente();
            }
        }
      
        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void grillaListas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                int fila = grillaListas.CurrentRow.Index;
                int columna = grillaListas.CurrentCell.ColumnIndex;
                if (columna == 3)
                {
                    int precio = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el precio: "));
                    servicioLista.modificarPrecio(precio, fila + 1);
                    actualizaGrilla();
                }
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                servicioLista.ordenarPorPrecio();
                actualizaGrilla();
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.Message);
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("La lista contiene : "+ servicioLista.darNumeroRegistro() + " registros.");
        }

        private void guiLista_Load(object sender, EventArgs e)
        {

        }

        private void buttEliminarN_Click(object sender, EventArgs e)
        {
            try
            {
                int cantidad = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese La cantidad de juegos a eliminar: "));
                servicioLista.eliminarNNodos(cantidad);
                actualizaGrilla();
                return;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
    }
}
