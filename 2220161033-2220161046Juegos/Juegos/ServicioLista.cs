using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juegos
{
    class ServicioLista
    {
        public JuegoNodo cabeza;
        public int numeroRegistros;


        private string rutaVolcado;
        private StreamReader sr;

        public ServicioLista()
        {
            cabeza = null;
            numeroRegistros = 0;
        }
        public void seleccionarRutaVolcado()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Seleccione el archivo";
            ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                rutaVolcado = ofd.FileName;
            }
            else
            {
                throw new Exception("No selecciono la ruta");
            }
        }
        public string darRutavolcado()
        {
            return rutaVolcado;
        }
        public void hayRutaVolcado()
        {
            if (rutaVolcado == null)
            {
                throw new Exception("No ha ingresado la ruta de volcado");
            }
        }
        public void quitaRutaVolcado()
        {
            rutaVolcado = null;
        }
        private bool verificarCabeza()
        {
            if (cabeza == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void agregarInicio(JuegoNodo juego)
        {
            if (verificarCabeza() == true)
            {
                cabeza = juego;
                numeroRegistros++;
            }
            else
            {
                cabeza.setAnterior(juego);
                juego.setSiguiente(cabeza);
                cabeza = juego;
                numeroRegistros++;
            }
        }
        public void ordenarPorPrecio()
        {
            if (verificarCabeza() == true)
            {
                throw new Exception("No hay elementos para ordenar");
            }
            else
            {
                JuegoNodo puntero1 = cabeza;
                while (puntero1 != null)
                {
                    JuegoNodo minimo = puntero1;
                    JuegoNodo puntero2 = puntero1.getSiguiente();
                    while (puntero2 != null)
                    {
                        if (puntero2.darPrecio() < minimo.darPrecio())
                        {
                            minimo = puntero2;
                        }
                        puntero2 = puntero2.getSiguiente();
                    }
                    if (minimo != puntero1)
                    {
                        string tituloMinimo = minimo.darTitulo();
                        string generoMinimo = minimo.darGenero();
                        int precioMinimo = minimo.darPrecio();
                        DateTime fechaMinimo = minimo.darFecha();

                        minimo.cambiarTitulo(puntero1.darTitulo());
                        minimo.cambiarGenero(puntero1.darGenero());
                        minimo.cambiarPrecio(puntero1.darPrecio());
                        minimo.cambiarFecha(puntero1.darFecha());

                        puntero1.cambiarTitulo(tituloMinimo);
                        puntero1.cambiarGenero(generoMinimo);
                        puntero1.cambiarPrecio(precioMinimo);
                        puntero1.cambiarFecha(fechaMinimo);
                    }
                    puntero1 = puntero1.getSiguiente();
                }

            }
        }
        public JuegoNodo buscarPorPosicion(int pos)
        {
            JuegoNodo jn = null;
            int contador = 0;
            if (verificarCabeza())
            {
                throw new Exception("No hay ningun juego");
            }
            else if (pos <= 0)
            {
                throw new Exception("La posicion especificada no es valida debe ser mayor a cero");
            }
            else if (pos > numeroRegistros)
            {
                throw new Exception("La posicion no existe, existen actualmente: " + numeroRegistros + " Registros");
            }
            else
            {
                JuegoNodo temp = cabeza;
                while (temp != null)
                {
                    contador++;
                    if (contador == pos)
                    {
                        jn = temp;
                        break;
                    }
                    temp = temp.getSiguiente();
                }
            }
            return jn;
        }
        public void modificarPrecio(int precio, int posicion)
        {
            try
            {
                if (JuegoNodo.verificarPrecio(precio) == false)
                {
                    throw new Exception("El precio no es valido");
                }
                JuegoNodo juego = buscarPorPosicion(posicion);
                juego.cambiarPrecio(precio);
            }
            catch (Exception ee)
            {
                throw ee;
            }
        }
        public int buscarPorTitulo(string pTitulo)
        {

            int contador = 0;
            int result = -1;
            if (verificarCabeza() == true)
            {
                throw new Exception("No hay ningun juego");
            }
            else if (pTitulo == null || pTitulo == "")
            {
                throw new Exception("El titulo no debe estar vacio");
            }
            else
            {
                JuegoNodo temp = cabeza;
                while (temp != null)
                {
                    contador++;
                    if (temp.darTitulo().ToLower().Equals(pTitulo.ToLower()))
                    {
                        result = contador;
                        break;
                    }
                    temp = temp.getSiguiente();
                }
                if (result == -1)
                {
                    throw new Exception("No se ha econtrado un juego con el titulo: " + pTitulo);
                }
            }
            return result;
        }
        public int getNumeroRegistros()
        {
            return numeroRegistros;
        }

        public JuegoNodo getCabeza()
        {
            return cabeza;
        }
        public void eliminar(int posicion)
        {
            int contador = 0;
            if (verificarCabeza() == true)
            {
                throw new Exception("No hay ningun juego");
            }
            else if (posicion <= 0)
            {
                throw new Exception("La posicion especificada no es valida debe ser mayor a cero");
            }
            else if (posicion > numeroRegistros)
            {
                throw new Exception("La posicion no existe, existen actualmente: " + numeroRegistros + " Registros");
            }
            else if (posicion == 1)
            {
                cabeza = cabeza.getSiguiente();
                if (cabeza != null)
                {
                    cabeza.setAnterior(null);
                }
                numeroRegistros--;
            }
            else
            {
                JuegoNodo temp = cabeza;
                while (temp != null)
                {
                    contador++;
                    if (contador == posicion)
                    {
                        if (temp.getSiguiente() != null)
                        {
                            temp.getSiguiente().setAnterior(temp.getAnterior());
                            temp.getAnterior().setSiguiente(temp.getSiguiente());
                        }
                        else
                        {
                            temp.getAnterior().setSiguiente(null);
                        }
                        numeroRegistros--;
                        break;
                    }
                    temp = temp.getSiguiente();
                }
            }
        }

        public void eliminarNNodos(int CantidadaEliminar)
        {          
            if (verificarCabeza() == true)
            {
                throw new Exception("No hay ningun juego");
            }

            else if (CantidadaEliminar <= 0)
            {
                throw new Exception("La cantidad especificada no es valida debe ser mayor a cero");
            }
            else if (CantidadaEliminar > numeroRegistros)
            {
                throw new Exception("La cantidad a eliminar de ser menor o igual a: " + numeroRegistros);
            }                 
            else
            {
                int contador = 0;
                int posicion = 1;
                if (numeroRegistros != CantidadaEliminar)
                {
                    posicion = numeroRegistros - CantidadaEliminar;
                }

                JuegoNodo temp = cabeza;
                while (temp != null)
                {
                    contador++;
                    if (contador == posicion)
                    {                                                
                        temp.setSiguiente(null);                                                                                   
                        numeroRegistros= numeroRegistros-CantidadaEliminar;
                        break;
                    }
                    temp = temp.getSiguiente();
                }
            }
        }
        public void volcar()
        {
            try
            {
                hayRutaVolcado();
                sr = new StreamReader(rutaVolcado);
                string linea = sr.ReadLine();
                while (linea != null)
                {
                    string[] datos = linea.Split(',');
                    string titulo = datos[0].Trim();
                    string genero = datos[1].Trim();
                    int precio = Convert.ToInt32(datos[2].Trim());
                    DateTime dt = DateTime.Parse(datos[3]);
                    int estado = Convert.ToInt32(datos[4]);
                    if (estado == JuegoNodo.ACTIVO)
                    {
                        JuegoNodo jj = new JuegoNodo(precio, titulo, genero, dt, estado);
                        agregarInicio(jj);
                    }
                    linea = sr.ReadLine();
                }
                sr.Close();

            }
            catch (Exception ee)
            {
                sr.Close();

                throw ee;
            }
        }
        public int darNumeroRegistro()
        {
            return numeroRegistros;
        }

        public void recorrer()
        {
            JuegoNodo nodo = cabeza;
            while(nodo!=null)
            {
                nodo = nodo.getSiguiente();
            }
        }

    }
}
