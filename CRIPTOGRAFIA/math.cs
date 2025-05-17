using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRIPTOGRAFIA
{
    internal class math
    {
       
        public static int InversoModular(int a, int m)
        {
            a = ((a % m) + m) % m;
            for (int i = 1; i < m; i++)
            {
                if ((a * i) % m == 1)
                    return i;
            }
            return -1; // No tiene inverso
        }
        public static int[,] Menor(int[,] matriz, int filaExcluir, int colExcluir)
        {
            int n = matriz.GetLength(0);
            int[,] menor = new int[n - 1, n - 1];

            int r = 0;
            for (int i = 0; i < n; i++)
            {
                if (i == filaExcluir) continue;
                int c = 0;
                for (int j = 0; j < n; j++)
                {
                    if (j == colExcluir) continue;
                    menor[r, c++] = matriz[i, j];
                }
                r++;
            }

            return menor;
        }
        public static int[,] MatrizAdjunta(int[,] matriz, int m)
        {
            int n = matriz.GetLength(0);
            int[,] adjunta = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int[,] menor = Menor(matriz, i, j);
                    int signo = ((i + j) % 2 == 0) ? 1 : -1;
                    adjunta[j, i] = (signo * Determinante(menor, m)) % m;  // nota el transpuesto
                    if (adjunta[j, i] < 0)
                        adjunta[j, i] += m;
                }
            }

            return adjunta;
        }
        public static int Determinante(int[,] matriz, int m)
        {
            int n = matriz.GetLength(0);

            if (n == 1)
                return matriz[0, 0] % m;

            int det = 0;
            for (int col = 0; col < n; col++)
            {
                int[,] menor = Menor(matriz, 0, col);
                int cofactor = ((col % 2 == 0 ? 1 : -1) * matriz[0, col] * Determinante(menor, m)) % m;
                det = (det + cofactor + m) % m;
            }

            return det;
        }
        public static int[,] InversaModular(int[,] matriz, int m)
        {
            int n = matriz.GetLength(0);
            int det = Determinante(matriz, m);
            int detInverso = InversoModular(det, m);

            if (detInverso == -1)
                throw new InvalidOperationException("La matriz no es invertible módulo " + m);

            int[,] adjunta = MatrizAdjunta(matriz, m);
            int[,] inversa = new int[n, n];

            // Multiplicar cada elemento de la adjunta por el inverso del determinante
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    inversa[i, j] = (detInverso * adjunta[i, j]) % m;
                    if (inversa[i, j] < 0)
                        inversa[i, j] += m;
                }
            }

            return inversa;
        }
        public static int[,] GenerarMatrizClaveInvertible(int n, int modulo)
{
    Random rand = new Random();
    int[,] matriz;

    while (true)
    {
        matriz = new int[n, n];
        // Llenar con valores aleatorios [0, m)
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                matriz[i, j] = rand.Next(modulo);

        int det = Determinante(matriz, modulo);
        int inv = InversoModular(det, modulo);

        if (inv != -1)
            break; // es invertible
    }

    return matriz;
}

    }
}
