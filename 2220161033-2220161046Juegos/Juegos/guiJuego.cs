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
    public partial class guiJuego : Form
    {
        private Servicio servicio;
        
        public guiJuego()
        {
            InitializeComponent();
            servicio = new Servicio();
        }
    
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string titulo = txtTitulo.Text;
                string genero = listBoxGenero.Text;
                int precio = Convert.ToInt32(txtPrecio.Text);
                DateTime dt = DateTime.Parse(dateTimePicker1.Text);
                Juego juego = new Juego(precio, titulo, genero, dt,Juego.ACTIVO);
                servicio.escribirAlFinal(juego);
                MessageBox.Show("Se ha guardado el registro");
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

        private void butExaminar_Click(object sender, EventArgs e)
        {
            try
            {
                servicio.seleccionarRuta();
                txtRuta.Text = servicio.darRuta();
            }   
            catch(Exception ee)
            {
                MessageBox.Show(ee.Message);
            }       
        }

        private void butLeerEn_Click(object sender, EventArgs e)
        {
            try
            {
                int posicion = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese la posicion del juego a buscar: "));
                Juego jj = servicio.leerEnPosicion(posicion);
                llenarCampos(jj);
                txtLeerPosicion.Text = posicion.ToString();
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
                string titulo = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el titulo el cual desea buscar: ");
                int posicion = servicio.buscarPorTitulo(titulo);
                txtLeerPosicion.Text = posicion.ToString();
                Juego jj = servicio.leerEnPosicion(posicion);
                llenarCampos(jj);
                txtTitulo.ReadOnly = true;
                dateTimePicker1.Enabled = false;
                listBoxGenero.Enabled = false;
                txtLeerPosicion.ReadOnly = true;
                txtPrecio.ReadOnly = true;
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
            txtLeerPosicion.Clear();
            listBoxGenero.ClearSelected();
            txtTitulo.ReadOnly = false;
            txtLeerPosicion.ReadOnly = true;
            dateTimePicker1.Enabled = true;
            listBoxGenero.Enabled = true;
            txtPrecio.ReadOnly = false;
        }

        private void butCambiarPrecio_Click(object sender, EventArgs e)
        {
            try
            {
                int precio = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el precio a cambiar: "));
                int posicion = Convert.ToInt32(txtLeerPosicion.Text);

                if( MessageBox.Show("Esta seguro de cambiar el precio del juego " + txtTitulo.Text, "Atencion", MessageBoxButtons.YesNo)==DialogResult.Yes)
                {
                    servicio.modificarPrecio(posicion, precio);
                    MessageBox.Show("Se ha modificado el precio");
                }
                else
                {
                    return;
                }
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
           
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
                int posicion = Convert.ToInt32(txtLeerPosicion.Text);
                Juego jj = servicio.leerEnPosicion(posicion);
                llenarCampos(jj);
                if (MessageBox.Show("Esta seguro de elimnar le juego: " + jj.darTitulo(), "Atencion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    servicio.eliminar(posicion);
                    MessageBox.Show("se ha eliminado");
                    reiniciarCampos();
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
        private void butVolcar_Click(object sender, EventArgs e)
        {
            try
            {
                servicio.seleccionarRutaVolcado();
                servicio.hayRutaVolcado();
                if (MessageBox.Show("Esta seguro que desea volcar los datos de la ruta: " + servicio.darRutavolcado(), "Atencion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    servicio.volcar();
                    servicio.quitaRutaVolcado();
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
    }
}
