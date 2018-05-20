using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class ServicioGrafo
    {
        public string  [,] grafo;

        public string calcularRuta(string origen, string destino)
        {
            if(!verificar(origen)||!verificar(destino))
            {
                throw new Exception("El nodo ingresado no existe");
            }
            string result = null;
            origen = origen.ToUpper();
            destino = destino.ToUpper();
            int iOrigen = 0;
            int iDestino = 0;
            for(int i=1;i<grafo.GetLength(0);i++)
            {
                if(grafo[i,0].Equals(origen))
                {
                    iOrigen = i;                    
                }
                else if(grafo[0,i].Equals(destino))
                {
                    iDestino = i;
                }
            }
            return result;
        }
          
        public bool verificar(string nodo)
        {
            string pNodo = grafo[0, grafo.Length - 1];
            bool result = true;
            if(nodo.CompareTo(pNodo)<0)
            {
                result = false;
            }
            return result;
        }
        public void setGrafo(string [,] pGrafo)
        {
            grafo = pGrafo;
        }
        ////Pruebaaaa
    }
}
