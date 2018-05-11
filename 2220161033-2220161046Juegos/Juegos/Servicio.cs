using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Juegos
{
    class Servicio
    {
        private string ruta;
        private FileStream fs;
        private string rutaVolcado;
        private StreamReader sr;
        public void seleccionarRuta()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Seleccione el archivo";
            ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ruta = ofd.FileName;
            }
            else
            {
                throw new Exception("No selecciono la ruta");
            }           
        }
        public string darRuta()
        {
            return ruta;
        }
        public void hayRuta()
        {
            if (ruta == null)
            {
                throw new Exception("No ha ingresado la ruta");
            }
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


        public void escribirAlFinal(Juego juego)
        {
           try
            {
                hayRuta();
                string escribir = juego.arreglar();
                fs = new FileStream(ruta, FileMode.Append);
                fs.Write(Encoding.ASCII.GetBytes(escribir), 0, Juego.TAMREGISTRO);
                fs.Close();               
            }
            catch(Exception ee)
            {
                fs.Close();
                throw ee;
                
            }
        }
        public Juego leerEnPosicion(int pPosicion)
        {
            Juego jj = null;
            try
            {
                hayRuta();
                fs = new FileStream(ruta, FileMode.Open);
                int cantidadRegistros = (int)fs.Length/Juego.TAMREGISTRO;
                if(pPosicion<=cantidadRegistros && pPosicion>=0)
                {
                    byte[] bytes = new byte[Juego.TAMREGISTRO];
                    fs.Seek((pPosicion - 1) * Juego.TAMREGISTRO, SeekOrigin.Begin);
                    fs.Read(bytes, 0, Juego.TAMREGISTRO);
                    string cadena = Encoding.ASCII.GetString(bytes);
                    int estado = Convert.ToInt32(cadena.Substring(59, 1));
                    if(estado==Juego.ACTIVO)
                    {
                        string titulo = cadena.Substring(0, Juego.TAMTITULO).Trim();
                        string genero = cadena.Substring(30, Juego.TAMGENERO).Trim();
                        int precio = Convert.ToInt32(cadena.Substring(40, Juego.TAMPRECIO).Trim());
                        DateTime dt = DateTime.Parse(cadena.Substring(49, Juego.TAMFECHA));
                        jj = new Juego(precio, titulo, genero, dt, estado);
                    }
                    else
                    {
                        fs.Close();
                        throw new Exception("El juego esta eliminado");
                    }
                    
                    fs.Close();
                } 
                else
                {
                    fs.Close();
                    throw new Exception("la posicion ingresada no existe");                    
                }              
            }
            catch(Exception ee)
            {
                fs.Close();
                throw ee;
                
            }
            return jj;
        }

        public int buscarPorTitulo(String pTitulo)
        {         
            int posicion = -1;
            try
            {
                if(pTitulo==null||pTitulo=="")
                {
                    throw new Exception("El titulo debe ser diferente de null");
                }                                  
                hayRuta();
                fs = new FileStream(ruta, FileMode.Open);
                int cantidadRegistros = (int)fs.Length / Juego.TAMREGISTRO;
                string tituloAbuscar = pTitulo.ToLower();
                for (int i = 0; i < cantidadRegistros; i++)
                {
                    byte[] bytes = new byte[Juego.TAMREGISTRO];
                    fs.Seek((i) * Juego.TAMREGISTRO, SeekOrigin.Begin);
                    fs.Read(bytes, 0, Juego.TAMREGISTRO);
                    String cadena = Encoding.ASCII.GetString(bytes);
                    string titulo = cadena.Substring(0, Juego.TAMTITULO).Trim().ToLower();
                    string genero = cadena.Substring(30, Juego.TAMGENERO).Trim();
                    int precio = Convert.ToInt32(cadena.Substring(40, Juego.TAMPRECIO).Trim());
                    DateTime dt = DateTime.Parse(cadena.Substring(49, Juego.TAMFECHA));
                    int estado = Convert.ToInt32(cadena.Substring(59, 1));
                    if (tituloAbuscar.Equals(titulo)&&estado==Juego.ACTIVO )
                    {
                        posicion = i + 1;
                        break;
                    }
                }
                fs.Close();
                if(posicion==-1)
                {                    
                    throw new Exception("El juego no existe");
                }
            }
            catch(Exception ee)
            {
                fs.Close();
                throw ee;
                
            }
            return posicion;
        }

        public void modificarPrecio( int posicion, int pPrecio)
        {
            string precio = Juego.arreglarPrecio(pPrecio);
            try
            {
                hayRuta();
                fs = new FileStream(ruta, FileMode.Open);
                fs.Seek((posicion - 1) * Juego.TAMREGISTRO + 40, SeekOrigin.Begin);
                fs.Write(Encoding.ASCII.GetBytes(precio), 0, Juego.TAMPRECIO);
                fs.Close();
            }
            catch (Exception ee)
            {
                fs.Close();
                throw ee;
                
            }
        }
        public void eliminar(int posicion)
        {
            try
            {
                hayRuta();
                fs = new FileStream(ruta, FileMode.Open);
                fs.Seek((posicion - 1) * Juego.TAMREGISTRO + 59, SeekOrigin.Begin);
                fs.Write(Encoding.ASCII.GetBytes(Juego.INACTIVO.ToString()), 0, 1);
                fs.Close();                
            }
            catch (Exception ee)
            {
                fs.Close();
                throw ee;
                
            }
        }
        public void volcar()
        {                       
            try
            {
                hayRuta();
                hayRutaVolcado();               
                sr = new StreamReader(rutaVolcado);
                fs = new FileStream(ruta, FileMode.Append);
                string linea = sr.ReadLine();
                while(linea!=null)
                {
                    string[] datos = linea.Split(',');
                    string titulo = datos[0].Trim();
                    string genero = datos[1].Trim();
                    int precio = Convert.ToInt32(datos[2].Trim());
                    DateTime dt = DateTime.Parse(datos[3]);
                    int estado = Convert.ToInt32(datos[4]);
                    Juego jj = new Juego(precio, titulo, genero, dt, estado);
                    fs.Write(Encoding.ASCII.GetBytes(jj.arreglar()), 0, Juego.TAMREGISTRO);
                    linea = sr.ReadLine();
                }
                sr.Close();
                fs.Close();
            }
            catch(Exception ee)
            {
                sr.Close();
                fs.Close();
                throw ee;                
            }
        }
    }
}
