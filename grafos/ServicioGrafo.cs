using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace WindowsFormsApplication1
{
    class ServicioGrafo
    {
        public string  [,] grafo;
        public string[,] bfss;
        public string calcularRuta(string nodoOrigen, string nodoDestino)
        {
            string result = null;
            int posOrigen = Encoding.ASCII.GetBytes(nodoOrigen.ToCharArray())[0]-65;
            int posDestino = Encoding.ASCII.GetBytes(nodoDestino.ToCharArray())[0]-65;
            if(grafo[posOrigen,posDestino].Equals("1"))
            {
                result = nodoOrigen+nodoDestino;
            }
            else
            {
                result = buscar(posOrigen, posDestino);
            }
            return result;
        }       
        public string buscar(int posOrigen, int posDestino)
        {
            string result = null;
            ArrayList rutas = new ArrayList();
            if (grafo[posOrigen, posDestino].Equals("1"))
            {
                grafo[posOrigen, posDestino] = "V";
                string origen = Convert.ToString(Convert.ToChar(posOrigen+65));
                string destino = Convert.ToString(Convert.ToChar(posDestino+65));
                result = origen+destino;
            }
            else
            {
                for(int i=0; i<grafo.GetLength(0);i++)
                {
                    if(grafo[posOrigen,i].Equals("1"))
                    {
                        grafo[posOrigen, i] = "V";
                        result = buscar(i, posDestino);
                        if (result != null)
                        {
                            string origen = Convert.ToString(Convert.ToChar(posOrigen+65));
                            rutas.Add( origen+ result);
                            result = null;
                        }
                    }                    
                }
                if(rutas.Count!=0)
                {
                    string menor = (string)rutas[0];
                    for (int i = 0; i < rutas.Count; i++)
                    {
                        string actual = (string)rutas[i];
                        if (actual.Length <= menor.Length)
                        {
                            menor = actual;
                        }
                    }
                    result = menor;
                }
            }
            return result;
        }
        public void verificar(string origen, string destino)
        {
            if(grafo!=null)
            {
                int posOrigen = Encoding.ASCII.GetBytes(origen.ToCharArray())[0] - 65;
                int posDestino = Encoding.ASCII.GetBytes(destino.ToCharArray())[0] - 65;
                if(posOrigen<0 || posOrigen>grafo.GetLength(0))
                {
                    throw new Exception("El nodo de origen no existe");
                }
                if(posDestino<0 || posDestino>grafo.GetLength(0))
                {
                    throw new Exception("El nodo de destino no existe");
                }
            }
            else
            {
                throw new Exception("No se ha creado el grafo");
            }
        }
        public string ruta(string origen, string destino)
        {
            string result = null;
            verificar(origen, destino);
            string[,] matrizBfs = bfs(origen);
            bfss = matrizBfs;
            int posOrigen = Encoding.ASCII.GetBytes(origen.ToCharArray())[0] - 65;
            int posDestino = Encoding.ASCII.GetBytes(destino.ToCharArray())[0] - 65;
            string pi = matrizBfs[2, posDestino];
            if(!pi.Equals("Null"))
            {
                result = rutabfs(posDestino, matrizBfs) + destino;
            }
            if(result=="" || result==null)
            {
                result = "No hay ruta";
            }
            return result;
        }
        public String darDistancia(String destino)
        {
            String result = null;
            int posDestino = Encoding.ASCII.GetBytes(destino.ToCharArray())[0] - 65;
            result = bfss[1, posDestino];
            if (result.Equals("Infinito"))
            {
                result = "0";
            }
            return result;
        }
        private string rutabfs(int destino, string [,] matrizBfs)
        {
            string result = null;
            string pi = matrizBfs[2, destino];
            int posPi = Encoding.ASCII.GetBytes(pi.ToCharArray())[0] - 65;
            if(!pi.Equals("-"))
            {
                result=rutabfs( posPi, matrizBfs)+pi;
            }
            return result;
        }
        public string[,] bfs(string origen)
        {
            string[,] bfs = new string[3,grafo.GetLength(0)];
            int posOrigen = Encoding.ASCII.GetBytes(origen.ToCharArray())[0] - 65;
            for (int i=0; i<bfs.GetLength(1);i++)
            {
                bfs[0, i] = "White";
                bfs[1, i] = "Infinito";
                bfs[2, i] = "Null";
            }
            bfs[0, posOrigen] = "Gray";
            bfs[1, posOrigen] = "0";
            bfs[2, posOrigen] = "-";
            Queue<string> cola = new Queue<string>();
            cola.Enqueue(origen);
            while(cola.Count!=0)
            {
                string head = cola.Peek();
                int posHead = Encoding.ASCII.GetBytes(head.ToCharArray())[0] - 65;
                for(int i=0; i < grafo.GetLength(0);i++)
                {
                    string actual = grafo[posHead, i];
                    string color = bfs[0, i];
                    if(actual.Equals("1")&&color.Equals("White"))
                    {
                        bfs[0, i] = "Gray";
                        bfs[1, i] = Convert.ToString(Convert.ToInt32(bfs[1, posHead]) + 1);
                        bfs[2, i] = head;
                        cola.Enqueue(Convert.ToString(Convert.ToChar(65+i)));
                    }
                }
                cola.Dequeue();
                bfs[0, posHead] = "Black";
            }
            return bfs;
        }
        public void setGrafo(string [,] pGrafo)
        {
            grafo = pGrafo;
        }
        ////Pruebaaaa

        //Prueba2
    }
}
