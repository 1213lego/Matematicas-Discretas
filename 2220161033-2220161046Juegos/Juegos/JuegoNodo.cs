using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juegos
{
    class JuegoNodo
    {
        public const int TAMREGISTRO = 60;
        public const int TAMGENERO = 10;
        public const int TAMTITULO = 30;
        public const int TAMPRECIO = 9;
        public const int TAMFECHA = 10;

        public const int INACTIVO = 0;
        public const int ACTIVO = 1;
        private int estado;

        private int precio;
        private string titulo;
        private string genero;
        private DateTime fecha;

        private JuegoNodo siguiente;
        private JuegoNodo anterior;

        public JuegoNodo(int pPrecio, string pTitulo, string pGenero, DateTime pFecha, int pEstado)
        {
            if (pPrecio >= 0 && pPrecio <= 999999999)
            {
                precio = pPrecio;
            }
            else
            {
                throw new Exception("El precio debe ser mayor o igual a cero y menor igual a 999999999");
            }

            if (pTitulo != null && pTitulo != "")
            {
                titulo = pTitulo;
            }
            else
            {
                throw new Exception("El juego debe tener un titulo");
            }

            if (pGenero != null && pGenero != "")
            {
                genero = pGenero;
            }
            else
            {
                throw new Exception("El juego debe tener un genero");
            }
            if (pFecha != null && pFecha.CompareTo(DateTime.Today) <= 0)
            {
                fecha = pFecha;
            }
            else
            {
                throw new Exception("La fecha no puede ser posterior al dia actual");
            }
            if (pEstado >= 0 && pEstado <= 1)
            {
                estado = pEstado;
            }
            else
            {
                throw new Exception("Solo hay dos estados 0 y 1");
            }
            siguiente = null;
            anterior = null;
        }

        public JuegoNodo getSiguiente()
        {
            return siguiente;
        }
        public void setSiguiente(JuegoNodo pSiguiente)
        {
            siguiente = pSiguiente;
        }

        public JuegoNodo getAnterior()
        {
            return anterior;
        }
        public void setAnterior(JuegoNodo pAnterior)
        {
            anterior = pAnterior;
        }

        public void cambiarPrecio(int pPrecio)
        {
            if (pPrecio >= 0)
            {
                precio = pPrecio;
            }
            else
            {
                throw new Exception("El precio debe ser mayor o igual a cero");
            }
        }
        public void cambiarEstado(int pEstado)
        {
            estado = pEstado;
        }
        public void cambiarTitulo(string ptitulo)
        {
            titulo = ptitulo;
        }
        public void cambiarGenero(string pGenero)
        {
            genero = pGenero;
        }
        public void cambiarFecha(DateTime pFecha)
        {
            fecha = pFecha;
        }
        public int darPrecio()
        {
            return precio;
        }
        public string darTitulo()
        {
            return titulo;
        }
        public string darGenero()
        {
            return genero;
        }
        public DateTime darFecha()
        {
            return fecha;
        }
        

        public string arreglar()
        {
            string pGenero;
            if (genero.Length > TAMGENERO)
            {
                pGenero = genero.Substring(0, TAMGENERO);
            }
            else
            {
                string espacio = new string(' ', TAMGENERO - genero.Length);
                pGenero = genero + espacio;
            }

            string pTitulo;
            if (titulo.Length > TAMTITULO)
            {
                pTitulo = titulo.Substring(0, TAMTITULO);
            }
            else
            {
                string espacio = new string(' ', TAMTITULO - titulo.Length);
                pTitulo = titulo + espacio;
            }

            string pPrecio = Convert.ToString(precio);
            if (pPrecio.Length > TAMPRECIO)
            {
                pPrecio = pPrecio.Substring(0, TAMPRECIO);
            }
            else
            {
                string espacio = new string(' ', TAMPRECIO - pPrecio.Length);
                pPrecio = precio + espacio;
            }

            string pFecha = fecha.ToShortDateString();
            if (pFecha.Length > TAMFECHA)
            {
                pFecha = pFecha.Substring(0, TAMFECHA);
            }
            else
            {
                string espacio = new string(' ', TAMFECHA - pFecha.Length);
                pFecha = pFecha + espacio;
            }
            return (pTitulo + pGenero + pPrecio + pFecha + estado.ToString());
        }
        public string mostrarDatos()
        {
            return "Titulo: " + titulo + Environment.NewLine +
                    "Genero: " + genero + Environment.NewLine +
                    "Precio: " + precio + Environment.NewLine +
                    "Fecha: " + fecha.ToShortDateString();
        }
        public static String arreglarPrecio(int pPrecio)
        {
            String cadena = pPrecio.ToString();
            if (pPrecio < 0 || pPrecio > 999999999)
            {
                throw new Exception("El precio debe ser mayor o igual a cero y menor igual a 999999999");
            }
            else
            {
                if (cadena.Length > TAMPRECIO)
                {
                    cadena = cadena.Substring(0, TAMPRECIO);
                }
                else
                {
                    String espacio = new string(' ', TAMPRECIO - cadena.Length);
                    cadena = cadena + espacio;
                }
            }
            return cadena;
        }
        
        public static bool verificarPrecio(int pPrecio)
        {
            if (pPrecio < 0 || pPrecio > 999999999)
            {
                return false;
            }
            else
            {
                return true;
            }
        }     
    }
}
