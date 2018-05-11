using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolDeExpresiones
{
    class ServicioStrings
    {

        const string POTENCIA = "^";
        const string RESTA = "-";
        const string SUMA = "+";
        const string DIVISION = "/";
        const string MULTIPLICACION = "*";

        /**
         * retorna un arreglo de tres posiciones
         * la cadena ingresada debe de tener parentesis
         * en la posicion 0 del arreglo esta la parte izquierda del operando y se le han quitado el primer y ultimo parentesis
         * en la posicion 1 el operador
         * en la posicion 2 la parte iquierda del operador
         **/
        private static string[] hallarOperadorPrincipalParentesis(string expresion)
        {
            string[] partes = new string[3];
            char[] array = expresion.ToCharArray();
            int contador = 0;
            int i = operadorRaizParentesis(0, array, contador, false);

            if (i == expresion.Length)
            {
                string cadena = expresion.Substring(1, expresion.Length - 2);
                partes = darArreglo(cadena);
            }
            else
            {
                string izq = expresion.Substring(1, i - 2);
                string oper = expresion.Substring(i, 1);
                string der = expresion.Substring(i + 1);
                partes[0] = izq;
                partes[1] = oper;
                partes[2] = der;
            }

            return partes;
        }
        private static int operadorRaizParentesis(int inicio, char[] array, int contador, bool encontro)
        {
            if (encontro)
            {
                return inicio;
            }
            else
            {
                if (array[inicio].Equals('('))
                {
                    contador++;
                }
                else if (array[inicio].Equals(')'))
                {
                    contador--;
                }
                inicio++;
                if (contador == 0)
                {
                    encontro = true;
                }
                return operadorRaizParentesis(inicio, array, contador, encontro);
            }
        }

        public static string[] darArreglo(string expresion)
        {
            string[] result = new string[3];
            // si llega un solo numero ej 7
            if (esNumero(expresion))
            {
                result[0] = expresion;
                result[1] = null;
                result[2] = null;
            }
            // en caso 2/xxxxxx
            else if (hayNumeroParteIzquierda(expresion))
            {
                result = parteIzquierdaSimple(expresion);
            }
            // si llega (3-4) 
            else if (esSimple(expresion))
            {
                // quito primer y ultimo parentesis
                string cadena = expresion.Substring(1, expresion.Length - 2);
                result = separarExpresionSimple(cadena);
            }// en caso 2+4 
            else if (!expresion.Contains("(") && !expresion.Contains(")"))
            {
                result = separarExpresionSimple(expresion);
            }
            else
            {
                result = hallarOperadorPrincipalParentesis(expresion);
            }
            return result;
        }

        /** en caso 2/xxxxxx
         * ya se ha vericado la cadena
        * posicion 0= 2
        * posicion 1 = /
        * posicion 2= xxx
       **/
        private static string[] parteIzquierdaSimple(string cadena)
        {
            string[] result = new string[3];
            for (int i = 0; i < cadena.Length; i++)
            {
                if (i + 1 < cadena.Length)
                {
                    if (esNumero(cadena.Substring(i, 1)) && esOperador(cadena.Substring(i + 1, 1)))
                    {
                        result[0] = cadena.Substring(0, i + 1);
                        result[1] = cadena.Substring(i + 1, 1);
                        string parteDerecha = cadena.Substring(i + 2);
                //        if (parteDerecha.Contains("(") && parteDerecha.Contains(")"))
                  //      {
                    //        parteDerecha = parteDerecha.Substring(1, parteDerecha.Length - 2);
                      //  }
                        result[2] = parteDerecha;
                        break;
                    }
                }
            }

            return result;
        }
        /** en caso 2/xxxxxx
         * true si cumple
         * false en caso contrario
        **/
        private static bool hayNumeroParteIzquierda(string cadena)
        {
            bool hay = false;
            for (int i = 0; i < cadena.Length; i++)
            {
                if (i + 1 < cadena.Length)
                {
                    if (esNumero(cadena.Substring(i, 1)) && esOperador(cadena.Substring(i + 1, 1)))
                    {
                        string parteizq = cadena.Substring(0, i + 1);
                        if (parteizq.Contains("(") || parteizq.Contains(")"))
                        {
                            break;
                        }
                        else
                        {
                            hay = true;
                            break;
                        }
                    }
                }
            }
            return hay;
        }

        private static bool esOperador(string cadena)
        {
            bool result = false;
            if (cadena.Equals(POTENCIA))
            {
                result = true;
            }
            else if (cadena.Equals(SUMA))
            {
                result = true;
            }
            else if (cadena.Equals(RESTA))
            {
                result = true;
            }
            else if (cadena.Equals(MULTIPLICACION))
            {
                result = true;
            }
            else if (cadena.Equals(DIVISION))
            {
                result = true;
            }
            return result;
        }
        /**
         * eje: 3+5
         * posicion 0 = 3
         * posicion 1 = +
         * posicion 2= 5
        **/
        private static string[] separarExpresionSimple(string cadena)
        {
            string ss = null;
            if (cadena.StartsWith("-"))
            {
                ss = "-";
                cadena = cadena.Substring(1, cadena.Length - 1);
            }
            else
            {
                ss = "";
            }

            string[] result = new string[3];
            cadena.Trim();
            if (cadena.Contains(POTENCIA))
            {
                result[0] = ss + cadena.Split(Convert.ToChar(POTENCIA))[0];
                result[1] = POTENCIA;
                result[2] = cadena.Split(Convert.ToChar(POTENCIA))[1];
            }
            else if (cadena.Contains(SUMA))
            {
                result[0] = ss + cadena.Split(Convert.ToChar(SUMA))[0];
                result[1] = SUMA;
                result[2] = cadena.Split(Convert.ToChar(SUMA))[1];
            }
            else if (cadena.Contains(RESTA))
            {
                result[0] = ss + cadena.Split(Convert.ToChar(RESTA))[0];
                result[1] = RESTA;
                result[2] = cadena.Split(Convert.ToChar(RESTA))[1];
            }
            else if (cadena.Contains(MULTIPLICACION))
            {
                result[0] = ss + cadena.Split(Convert.ToChar(MULTIPLICACION))[0];
                result[1] = MULTIPLICACION;
                result[2] = cadena.Split(Convert.ToChar(MULTIPLICACION))[1];
            }
            else if (cadena.Contains(DIVISION))
            {
                result[0] = ss + cadena.Split(Convert.ToChar(DIVISION))[0];
                result[1] = DIVISION;
                result[2] = cadena.Split(Convert.ToChar(DIVISION))[1];
            }

            return result;
        }
        /**
         * me verifica si es una expresion simple ej:(3+4)
         * true si los es
         * false en caso contrario
        **/
        private static bool esSimple(string cadena)
        {
            string abre = "(";
            int vecesAbre = 0;
            string cierra = ")";
            bool cumple = true;
            int vecesCierra = 0;

            for (int i = 0; i < cadena.Length; i++)
            {
                string s = cadena.Substring(i, 1);
                if (s.Equals(abre))
                {
                    vecesAbre++;
                }
                else if (s.Equals(cierra))
                {
                    vecesCierra++;
                    if (i + 1 < cadena.Length)
                    {
                        cumple = false;
                        break;
                    }
                }
                if (vecesAbre > 1 || vecesCierra > 1)
                {
                    cumple = false;
                    break;
                }
            }
            if (vecesAbre == 0 || vecesCierra == 0)
            {
                cumple = false;
            }
            return cumple;
        }
        /*
         * Me verifica que la cadena es solo un numero 
         * True si lo es
         * False en caso contrario
         */
        private static bool esNumero(string cadena)
        {
            try
            {
                Convert.ToDouble(cadena);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

    }
}
