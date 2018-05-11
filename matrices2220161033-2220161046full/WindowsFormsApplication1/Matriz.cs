using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Matriz
    {
        private int[,] matriz;
        private int[,] matriz2;
        private Random ran;

        public Matriz()
        {
            ran = new Random();
        }
        public int[,] getMatriz()
        {
            return matriz;
        }

        public int[,] getMatriz2()
        {
            return matriz2;
        }
        public void generarMatriz(int numero)
        {
            matriz = new int[numero, numero];
        }

        public void generarMatriz2(int numero)
        {
            matriz2 = new int[numero, numero];
        }

        public void rellenarMatriz()
        {
            if(verficar())
            {
                if (matriz.GetLength(0) % 2 == 0)
                {
                    for (int i = 0; i < matriz.GetLength(0); i++)
                    {
                        for (int j = 0; j < matriz.GetLength(1); j++)
                        {
                            matriz[i, j] = ran.Next(1, 9);

                        }
                    }
                }
                else
                {
                    int n = matriz.GetLength(0);
                    matriz = new int[n + 1, n + 1];
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            matriz[i, j] = ran.Next(1, 9);

                        }
                    }
                }
            }
            else
            {
                throw new Exception("No ha generado la matrices");
            }      
        }

        public void rellenarMatriz2()
        {
            if(verficar())
            {
                if (matriz2.GetLength(0) % 2 == 0)
                {
                    for (int i = 0; i < matriz2.GetLength(0); i++)
                    {
                        for (int j = 0; j < matriz2.GetLength(1); j++)
                        {
                            matriz2[i, j] = ran.Next(1, 9);
                        }
                    }
                }
                else
                {
                    int n = matriz2.GetLength(0);
                    matriz2 = new int[n + 1, n + 1];
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            matriz2[i, j] = ran.Next(1, 9);
                        }
                    }
                }
            }
            else
            {
                throw new Exception("No ha generado la matrices");
            }
        }
        public bool verficar()
        {
            return matriz != null && matriz2 != null;
        }
        public int[,] multiplicarMatrices()
        {
           if(verficar())
            {
                int[,] matrizResult = new int[matriz.GetLength(1), matriz2.GetLength(0)];
                for (int i = 0; i < matrizResult.GetLength(0); i++)
                {
                    for (int j = 0; j < matrizResult.GetLength(1); j++)
                    {

                        for (int k = 0; k < matriz.GetLength(1); k++)
                        {
                            matrizResult[i, j] += matriz[i, k] * matriz2[k, j];
                        }
                    }
                }
                return matrizResult;
            }
           else
            {
                throw new Exception("No ha generado las matrices");
            }
            
        }

        public int[,] mulplicarMatrices2x2Particion(int[,] matrizA, int[,] matrizB)
        {
            int[,] matrizResult = new int[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {

                    for (int k = 0; k < 2; k++)
                    {
                        matrizResult[i, j] += matrizA[i, k] * matrizB[k, j];

                    }
                }
            }
            return matrizResult;
        }
        public int[,] SumarMatrices2x2(int[,] matrizA, int[,] matrizB)
        {
            int[,] matrizResult = new int[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {

                    matrizResult[i, j] = matrizA[i, j] + matrizB[i, j];


                }
            }
            return matrizResult;
        }

        public int[,] multParticion()
        {

            if(verficar())
            {
                int[,] matrizResultante = new int[matriz.GetLength(1), matriz2.GetLength(0)];
                for (int i = 0; i < matrizResultante.GetLength(0); i = i + 2)
                {

                    for (int j = 0; j < matrizResultante.GetLength(1); j = j + 2)
                    {
                        int[,] sumatoria = new int[2, 2];
                        for (int k = 0; k < matriz.GetLength(0); k = k + 2)
                        {
                            int[,] matrizAux = new int[2, 2];
                            int[,] matrizAux2 = new int[2, 2];
                            matrizAux[0, 0] = matriz[i, k];
                            matrizAux[1, 0] = matriz[i + 1, k];
                            matrizAux[0, 1] = matriz[i, k + 1];
                            matrizAux[1, 1] = matriz[i + 1, k + 1];
                            matrizAux2[0, 0] = matriz2[k, j];
                            matrizAux2[1, 0] = matriz2[k + 1, j];
                            matrizAux2[0, 1] = matriz2[k, j + 1];
                            matrizAux2[1, 1] = matriz2[k + 1, j + 1];

                            sumatoria = SumarMatrices2x2(sumatoria, mulplicarMatrices2x2Particion(matrizAux, matrizAux2));
                        }
                        matrizResultante[i, j] = sumatoria[0, 0];
                        matrizResultante[i, j + 1] = sumatoria[0, 1];
                        matrizResultante[i + 1, j] = sumatoria[1, 0];
                        matrizResultante[i + 1, j + 1] = sumatoria[1, 1];

                    }

                }
                return matrizResultante;
            }
            else
            {
                throw new Exception("No ha generado las matrices");
            }
        }
        public int[,] multStrassen()
        {

            if(verficar())
            {
                int[,] matrizResultante = new int[matriz.GetLength(1), matriz2.GetLength(0)];
                for (int i = 0; i < matrizResultante.GetLength(0); i = i + 2)
                {

                    for (int j = 0; j < matrizResultante.GetLength(1); j = j + 2)
                    {
                        int[,] sumatoria = new int[2, 2];
                        for (int k = 0; k < matriz.GetLength(0); k = k + 2)
                        {
                            int[,] matrizAux = new int[2, 2];
                            int[,] matrizAux2 = new int[2, 2];
                            matrizAux[0, 0] = matriz[i, k];
                            matrizAux[1, 0] = matriz[i + 1, k];
                            matrizAux[0, 1] = matriz[i, k + 1];
                            matrizAux[1, 1] = matriz[i + 1, k + 1];
                            matrizAux2[0, 0] = matriz2[k, j];
                            matrizAux2[1, 0] = matriz2[k + 1, j];
                            matrizAux2[0, 1] = matriz2[k, j + 1];
                            matrizAux2[1, 1] = matriz2[k + 1, j + 1];

                            sumatoria = SumarMatrices2x2(sumatoria, mulplicarMatrices2x2Strassen(matrizAux, matrizAux2));
                        }
                        matrizResultante[i, j] = sumatoria[0, 0];
                        matrizResultante[i, j + 1] = sumatoria[0, 1];
                        matrizResultante[i + 1, j] = sumatoria[1, 0];
                        matrizResultante[i + 1, j + 1] = sumatoria[1, 1];

                    }

                }
                return matrizResultante;
            }
            else
            {
                throw new Exception("No ha generado las matrices");
            }
        }
        public int[,] mulplicarMatrices2x2Strassen(int[,] matrizA, int[,] matrizB)
        {
            int[,] matrizResult = new int[2, 2];
            int p1 = matrizA[0, 0] * (matrizB[0, 1] - matrizB[1, 1]);
            int p2 = (matrizA[0, 0] + matrizA[0,1])*matrizB[1,1];
            int p3= (matrizA[1, 0] + matrizA[1, 1]) * matrizB[0, 0];
            int p4= matrizA[1,1] * (matrizB[1, 0] - matrizB[0, 0]);
            int p5 = (matrizA[0, 0] + matrizA[1, 1]) * (matrizB[0, 0] + matrizB[1, 1]);//+
            int p6 = (matrizA[0, 1] - matrizA[1, 1]) * (matrizB[1, 0] + matrizB[1, 1]);
            int p7= (matrizA[0, 0] - matrizA[1, 0]) * (matrizB[0, 0] + matrizB[0, 1]);
            matrizResult[0, 0] = p5 + p6 + p4 - p2;
            matrizResult[0, 1] = p1 + p2;
            matrizResult[1, 0] = p3 + p4;
            matrizResult[1, 1] = p1 - p7 - p3 + p5;
            return matrizResult;
        }
        public int[,] multWinograd()
        {

            if(verficar())
            {
                int[,] matrizResultante = new int[matriz.GetLength(1), matriz2.GetLength(0)];
                for (int i = 0; i < matrizResultante.GetLength(0); i = i + 2)
                {

                    for (int j = 0; j < matrizResultante.GetLength(1); j = j + 2)
                    {
                        int[,] sumatoria = new int[2, 2];
                        for (int k = 0; k < matriz.GetLength(0); k = k + 2)
                        {
                            int[,] matrizAux = new int[2, 2];
                            int[,] matrizAux2 = new int[2, 2];
                            matrizAux[0, 0] = matriz[i, k];
                            matrizAux[1, 0] = matriz[i + 1, k];
                            matrizAux[0, 1] = matriz[i, k + 1];
                            matrizAux[1, 1] = matriz[i + 1, k + 1];
                            matrizAux2[0, 0] = matriz2[k, j];
                            matrizAux2[1, 0] = matriz2[k + 1, j];
                            matrizAux2[0, 1] = matriz2[k, j + 1];
                            matrizAux2[1, 1] = matriz2[k + 1, j + 1];

                            sumatoria = SumarMatrices2x2(sumatoria, mulplicarMatrices2x2Winograd(matrizAux, matrizAux2));
                        }
                        matrizResultante[i, j] = sumatoria[0, 0];
                        matrizResultante[i, j + 1] = sumatoria[0, 1];
                        matrizResultante[i + 1, j] = sumatoria[1, 0];
                        matrizResultante[i + 1, j + 1] = sumatoria[1, 1];

                    }

                }
                return matrizResultante;
            }
            else
            {
                throw new Exception("No ha generado las matrices");
            }
        }
        public int[,] mulplicarMatrices2x2Winograd(int[,] matrizA, int[,] matrizB)
        {
            int[,] matrizResult = new int[2, 2];
            int a = matrizA[0, 0];
            int b = matrizA[0, 1];
            int c = matrizA[1, 0];
            int d = matrizA[1, 1];
            int e = matrizB[0, 0];
            int f = matrizB[0, 1];
            int g = matrizB[1, 0];
            int h = matrizB[1, 1];
            int p1 = (c + d - a) * (h - f + e);
            int p2 = a * e;
            int p3 = b * g;
            int p4 = (a - c) * (h - f);
            int p5 = (c + d) * (f - e);
            int p6 = (b - c + a - d) * h;
            int p7 = d * (g - h + f - e);
            matrizResult[0, 0] = p2 + p3;
            matrizResult[0, 1] = p1 + p2 + p5 + p6;
            matrizResult[1, 0] = p1 + p2 + p4 + p7;
            matrizResult[1, 1] = p1 + p2 + p4 + p5;
            return matrizResult;
            /*
                        int p1 = (matrizA[1,0]+matrizA[1,1]-matrizA[0,0])*(matrizB[1,1]+matrizB[0,1]-matrizB[0,0]);//s
                        int p2 = matrizA[0,0]*matrizB[0,0];//
                        int p3 = matrizA[0,1]*matrizB[1,0];//
                        int p4 = (matrizA[0,0]-matrizA[1,0])*(matrizB[1,1]-matrizB[0,1]);//s
                        int p5 = (matrizA[1, 0] + matrizA[1, 1]) * (matrizB[0, 1] - matrizB[0, 0]);//s
                        int p6 = (matrizA[0, 1] - matrizA[1, 0]+ matrizA[0,0]- matrizA[1, 1]) * matrizB[1, 1];//s
                        int p7 = matrizA[1, 1]*(matrizB[1, 0] - matrizB[1, 1] + matrizB[0, 1] - matrizB[0, 0]) ;
                        matrizResult[0, 0] = p2+p3;
                        matrizResult[0, 1] = p1+p2+p5+p6;
                        matrizResult[1, 0] = p1+p2+p4+p7;
                        matrizResult[1, 1] = p1+p2+p4+p5;*/
        }
    }
}
