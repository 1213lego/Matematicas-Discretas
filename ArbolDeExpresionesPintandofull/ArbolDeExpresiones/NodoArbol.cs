using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolDeExpresiones
{
    public class NodoArbol
    {
        private string operando;

        private NodoArbol padre;
        private NodoArbol izq;
        private NodoArbol der;
        private int nivel;

        public NodoArbol(string cadena, NodoArbol pPadre, int nivell)
        {
            string[] partes = ServicioStrings.darArreglo(cadena);
            if (partes[2] == null && partes[1] == null)
            {
                padre = pPadre;
                operando =partes[0];
                nivel = nivell;
            }
            else
            {
                nivel = nivell;
                operando = partes[1];
                padre = pPadre;
                izq = new NodoArbol(partes[0], this,nivell+1);
                der = new NodoArbol(partes[2],this,nivell+1);
            }
        }
     
        public int  getNivel()
        {
            return nivel;
        }
        public string getOperando()
        {
            return operando;
        }
        public void setOperando(string operando)
        {
            this.operando = operando;
        }
        public NodoArbol getPadre()
        {
            return padre;
        }
        public void setPadre(NodoArbol padre)
        {
            this.padre = padre;
        }
        public NodoArbol getIzq()
        {
            return izq;
        }
        public void setIzq(NodoArbol izq)
        {
            this.izq = izq;
        }
        public NodoArbol getDer()
        {
            return der;
        }
        public void setDer(NodoArbol der)
        {
            this.der = der;
        }
        public bool esHoja()
        {
            return (izq == null && der == null);
        }
    }
}
