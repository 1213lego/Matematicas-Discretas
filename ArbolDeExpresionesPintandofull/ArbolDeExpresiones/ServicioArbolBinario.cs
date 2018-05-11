using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolDeExpresiones
{
    public class ServicioArbolBinario
    {

        const string POTENCIA = "^";
        const string RESTA = "-";
        const string SUMA = "+";
        const string DIVISION = "/";
        const string MULTIPLICACION = "*";


        private NodoArbol raiz;
        public NodoArbol darRaiz()
        {
            return raiz;
        }
        public bool arbolVacio()
        {
            return raiz == null;
        }
        public void generarArbol(string sss, string valorX)
        {
            sss = sss.Replace(" ", "");
            sss = sss.ToLower();
            if (sss.Contains("x") && valorX=="")
            {
                throw new Exception("Debe ingresar el valor de la x");
            }
            if( sss.Contains("x") && (valorX!=null || valorX!=""))
            {                
                valorX=valorX.Replace(" ", "");
                sss = sss.Replace("x", valorX.Trim());
            }
            raiz = new NodoArbol(sss, null,0);
            
        }
        public String mostrarRuta(string nodo)
        {
            return mostrarRuta(buscar(raiz,nodo));
        }
        private string mostrarRuta(NodoArbol nodo)
        {
            string result = null;
            if(nodo!=null)
            {
                result = nodo.getOperando() + mostrarRuta(nodo.getPadre());
            }
            return result;
        }
        public void eliminar(string nodo)
        {
            NodoArbol buscado = buscar(raiz, nodo);
            if(buscado!=null)
            {
                NodoArbol padre = buscado.getPadre();
                if(padre==null)
                {
                    raiz = null;
                }
                else if(padre.getIzq()==buscado)
                {
                    padre.setIzq(null);
                    buscado.setPadre(null);
                }
                else
                {
                    padre.setDer(null);
                    buscado.setPadre(null);
                }
            }
            else
            {
                throw new Exception("El nodo no existe");
            }
        }

        public int buscar(string nodo)
        {
            if(!arbolVacio())
            {
                NodoArbol result = buscar(raiz, nodo);
                if (result != null)
                {
                    return result.getNivel();
                }
                else
                {
                    throw new Exception("No existe el nodo");
                }
            }
            else
            {
                throw new Exception("El arbol esta vacio");
            }
        }
        private NodoArbol buscar(NodoArbol inicio, string nodo)
        {
            NodoArbol result = null;
            if(inicio!=null)
            {
                if(nodo.Equals(inicio.getOperando()))
                {
                    return inicio;
                }
                result = buscar(inicio.getIzq(), nodo);
                if(result==null)
                {
                    result = buscar(inicio.getDer(), nodo);
                }

            }
            return result;
        }

        public int buscar1(string nodo)
        {
            return buscar1(raiz, nodo,0);
        }
        private int buscar1(NodoArbol inicio, string nodo,int count)
        {
            int result = 0;
            if (inicio != null)
            {
                if (nodo.Equals(inicio.getOperando()))
                {
                    return count;
                }
                result = buscar1(inicio.getIzq(), nodo,count++);
                if (result == 0)
                {
                    result = buscar1(inicio.getDer(), nodo,count++);
                }
            }
            return result;
        }

        public int ContarNodos()
        {
            return ContarNodo(raiz);
        }
        private int ContarNodo(NodoArbol inicio)
        {
            int contador = 0;
            if (inicio != null)
            {
                contador = 1 + ContarNodo(inicio.getIzq()) + ContarNodo(inicio.getDer());
            }
            return contador;
        }
        public String preOrden()
        {
            return preOrder(raiz);
        }
        private String preOrder(NodoArbol inicio)
        {
            string ss = null;
            if (inicio != null)
            {
                ss = inicio.getOperando() + preOrder(inicio.getIzq()) + preOrder(inicio.getDer());
            }
            return ss;
        }

        public String inorden()
        {
            return inorder(raiz);
        }
        private String inorder(NodoArbol inicio)
        {
            string ss = null;
            if (inicio != null)
            {
                ss = inorder(inicio.getIzq()) + inicio.getOperando() + inorder(inicio.getDer());
            }
            return ss;

        }

        public String postOrden()
        {
            return postOrder(raiz);
        }
        private String postOrder(NodoArbol inicio)
        {
            string ss = null;
            if (inicio != null)
            {
                ss = postOrder(inicio.getIzq()) + postOrder(inicio.getDer()) + inicio.getOperando() ;
            }
            return ss;
        }
        public String evaluar()
        {
            if(!arbolVacio())
            {
                return operar(raiz);
            }
            else
            {
                return "Arbol vacio";
            }
        }
        private String operar(NodoArbol inicio)
        {
            NodoArbol result = null;
            if (inicio.getIzq() != null)
            {
                operar(inicio.getIzq());
            }
            if (inicio.getDer() != null)
            {
                operar(inicio.getDer());
            }
            if (inicio.getIzq() != null && inicio.getDer() != null)
            {
                if (inicio.getIzq().esHoja() && inicio.getDer().esHoja())
                {

                    try
                    {
                        double operacion = realizarOperacion(inicio.getIzq().getOperando(), inicio.getOperando(), inicio.getDer().getOperando());
                        inicio.setOperando(operacion.ToString());
                        inicio.setIzq(null);
                        inicio.setDer(null);
                        result = inicio;
                    }
                    catch (Exception eee)
                    {
                        throw new Exception("Se esta intentando dividir entre cero");
                    }
                }
            }
            else if(inicio.getIzq()==null&&  inicio.getDer()!=null)
            {
                try
                {
                    if(inicio.getDer().esHoja())
                    {
                        double operacion = realizarOperacion("0", inicio.getOperando(), inicio.getDer().getOperando());
                        inicio.setOperando(operacion.ToString());
                        inicio.setIzq(null);
                        inicio.setDer(null);
                        result = inicio;
                    }
                }
                catch (Exception eee)
                {
                    throw new Exception("Se esta intentando dividir entre cero");
                }
            }
            else if (inicio.getDer() == null && inicio.getIzq() != null)
            {
                try
                {
                    if (inicio.getIzq().esHoja())
                    {
                        double operacion = realizarOperacion(inicio.getIzq().getOperando(), inicio.getOperando(), "0");
                        inicio.setOperando(operacion.ToString());
                        inicio.setIzq(null);
                        inicio.setDer(null);
                        result = inicio;
                    }
                }
                catch (Exception eee)
                {
                    throw new Exception("Se esta intentando dividir entre cero");
                }
            }

            return raiz.getOperando();
        }
        public double realizarOperacion(string izq, string operador, string der)
        {
            double result = 0;
            if (operador.Equals(POTENCIA))
            {
                result = Math.Pow(Convert.ToDouble(izq), Convert.ToDouble(der));
            }
            else if (operador.Equals(SUMA))
            {
                result = (Convert.ToDouble(izq) + Convert.ToDouble(der));
            }
            else if (operador.Equals(RESTA))
            {
                result = (Convert.ToDouble(izq) - Convert.ToDouble(der));
            }
            else if (operador.Equals(MULTIPLICACION))
            {
                result = (Convert.ToDouble(izq) * Convert.ToDouble(der));
            }
            else if (operador.Equals(DIVISION))
            {
                if (Convert.ToDouble(der) == 0)
                {
                    throw new Exception("No se puede dividir entre cero");
                }
                else
                {
                    double n1 = Convert.ToDouble(izq);
                    double n2 = Convert.ToDouble(der);
                    result = n1 / n2;
                }
            }
            return result;
        }
        public void pintar(Graphics graph, Size panel)
        {
            if(!arbolVacio())
            {
                int x = panel.Width / 2;
                int y = 0;
                pintarArbol(graph, x, y, raiz, "Raiz", 1, panel.Width);
            }           
        }
        private void pintarArbol(Graphics Graph, int x, int y, NodoArbol nodo, String direccion, int cont, int ancho)
        {
            Pen pen = new Pen(Color.Black);
            if (nodo != null)
            {
                if (direccion.Equals("Raiz"))
                {
                    Graph.DrawEllipse(pen, x - 7, y, 30, 30);
                    Graph.FillEllipse(Brushes.Red, x - 7, y, 30, 30);
                    Graph.DrawString(nodo.getOperando(), new Font("Arial", 12), Brushes.Black, x, y + 6);

                    x = x - 7;
                }
                else if (direccion.Equals("Izq"))
                {
                    int xActual = x;
                    Graph.DrawLine(pen, x, y + 15, x - ancho / (int)Math.Pow(2, cont) + 15, y + 45);
                    Graph.DrawEllipse(pen, x - ancho / (int)Math.Pow(2, cont), y + 30, 30, 30);
                    Graph.FillEllipse(Brushes.Red, x - ancho / (int)Math.Pow(2, cont), y + 30, 30, 30);
                    Graph.DrawString(nodo.getOperando(), new Font("Arial", 12), Brushes.Black, x - ancho / (int)Math.Pow(2, cont) + 7, y + 36);

                    x = x - ancho / (int)Math.Pow(2, cont);
                    y = y + 45;
                }
                else if (direccion.Equals("Der"))
                {
                    Graph.DrawLine(pen, x + 30, y + 15, x + ancho / (int)Math.Pow(2, cont) + 15, y + 45);
                    Graph.DrawEllipse(pen, x + ancho / (int)Math.Pow(2, cont), y + 30, 30, 30);
                    Graph.FillEllipse(Brushes.Red, x + ancho / (int)Math.Pow(2, cont), y + 30, 30, 30);
                    Graph.DrawString(nodo.getOperando(), new Font("Arial", 12), Brushes.Black, x + ancho / (int)Math.Pow(2, cont) + 7, y + 36);
                    x = x + ancho / (int)Math.Pow(2, cont);
                    y = y + 45;
                }
                pintarArbol(Graph, x, y, nodo.getIzq(), "Izq", cont + 1, ancho);
                pintarArbol(Graph, x, y, nodo.getDer(), "Der", cont + 1, ancho);
            }
        }

        public void pintar2(Graphics graph, Size panel)
        {
            int x = panel.Width / 2;
            int y = 0;
            pintarArbol2(graph, x, y, raiz, "Raiz", 1, panel.Width);

        }
        private void pintarArbol2(Graphics Graph, int x, int y, NodoArbol nodo, String direccion, int cont, int ancho)
        {
            Pen pen = new Pen(Color.Black);
            if (nodo != null)
            {
                if (direccion.Equals("Raiz"))
                {
                    Graph.DrawEllipse(pen, x - 7, y, 30, 30);
                    Graph.FillEllipse(Brushes.Yellow, x - 7, y, 30, 30);
                    Graph.DrawString(nodo.getOperando(), new Font("Arial", 12), Brushes.Black, x, y + 6);

                    x = x - 7;
                }
                else if (direccion.Equals("Izq"))
                {
                    int xActual = x;
                    Graph.DrawLine(pen, x, y + 15, x - ancho / (int)Math.Pow(2, cont) + 15, y + 45);
                    Graph.DrawEllipse(pen, x - ancho / (int)Math.Pow(2, cont), y + 30, 30, 30);
                    Graph.FillEllipse(Brushes.Yellow, x - ancho / (int)Math.Pow(2, cont), y + 30, 30, 30);
                    Graph.DrawString(nodo.getOperando(), new Font("Arial", 12), Brushes.Black, x - ancho / (int)Math.Pow(2, cont) + 7, y + 36);

                    x = x - ancho / (int)Math.Pow(2, cont);
                    y = y + 45;
                }
                else if (direccion.Equals("Der"))
                {
                    Graph.DrawLine(pen, x + 30, y + 15, x + ancho / (int)Math.Pow(2, cont) + 15, y + 45);
                    Graph.DrawEllipse(pen, x + ancho / (int)Math.Pow(2, cont), y + 30, 30, 30);
                    Graph.FillEllipse(Brushes.Yellow, x + ancho / (int)Math.Pow(2, cont), y + 30, 30, 30);
                    Graph.DrawString(nodo.getOperando(), new Font("Arial", 12), Brushes.Black, x + ancho / (int)Math.Pow(2, cont) + 7, y + 36);
                    x = x + ancho / (int)Math.Pow(2, cont);
                    y = y + 45;
                }
                pintarArbol(Graph, x, y, nodo.getIzq(), "Izq", cont + 1, ancho);
                pintarArbol(Graph, x, y, nodo.getDer(), "Der", cont + 1, ancho);
            }
        }


    }
}
