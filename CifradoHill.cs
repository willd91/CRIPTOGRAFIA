using System;
namespace CRIPTOGRAFIA
{
    public class CifradoHill
    {
        int tamaño_matriz;
        int[,] clave_matriz;
        int modulo = 26;
        private static Random rand = new Random();
        public CifradoHill(int tamaño)
        {
            tamaño_matriz = tamaño;
            clave_matriz = new int[tamaño_matriz, tamaño_matriz];

        }
        public void llenar_matrizclave(int matriz)
        {

        }
        public static double[,] GenerarMatrizInvertible(int n)
        {
            double[,] matriz;
            double det;

            do
            {
                matriz = new double[n, n];
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                        matriz[i, j] = rand.Next(-10, 11); // valores entre -10 y 10

                det = Determinante(matriz);
            }
            while (Math.Abs(det) < 1e-6); // Evitar determinantes cercanos a cero

            return matriz;
        }
        // Determinante recursivo (para matrices pequeñas)
        private static double Determinante(double[,] matriz)
        {
            int n = matriz.GetLength(0);
            if (n == 1) return matriz[0, 0];
            if (n == 2)
                return matriz[0, 0] * matriz[1, 1] - matriz[0, 1] * matriz[1, 0];

            double det = 0;
            for (int col = 0; col < n; col++)
            {
                double signo = (col % 2 == 0) ? 1 : -1;
                det += signo * matriz[0, col] * Determinante(Menor(matriz, 0, col));
            }

            return det;
        }
        private static double[,] Menor(double[,] matriz, int filaExcluir, int colExcluir)
        {
            int n = matriz.GetLength(0);
            double[,] resultado = new double[n - 1, n - 1];

            int r = 0;
            for (int i = 0; i < n; i++)
            {
                if (i == filaExcluir) continue;
                int c = 0;
                for (int j = 0; j < n; j++)
                {
                    if (j == colExcluir) continue;
                    resultado[r, c++] = matriz[i, j];
                }
                r++;
            }

            return resultado;
        }
    }
}