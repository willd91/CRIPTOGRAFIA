using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRIPTOGRAFIA
{
    public class CifradorAnagramacion
    {
        private string clave;
        private bool anagramarFilas; // true = filas, false = columnas

        public CifradorAnagramacion(string clave, bool anagramarFilas = false)
        {
            this.clave = clave.ToUpper();
            this.anagramarFilas = anagramarFilas;
        }

        // Cifrar texto
        public string Cifrar(string textoPlano)
        {
            textoPlano = LimpiarTexto(textoPlano);
            string textoCifrado = SustitucionPolialfabetica(textoPlano, cifrar: true);

            if (anagramarFilas)
                textoCifrado = AnagramarFilas(textoCifrado, cifrar: true);
            else
                textoCifrado = AnagramarColumnas(textoCifrado, cifrar: true);

            return textoCifrado;
        }

        // Descifrar texto
        public string Descifrar(string textoCifrado)
        {
            textoCifrado = LimpiarTexto(textoCifrado);

            if (anagramarFilas)
                textoCifrado = AnagramarFilas(textoCifrado, cifrar: false);
            else
                textoCifrado = AnagramarColumnas(textoCifrado, cifrar: false);

            return SustitucionPolialfabetica(textoCifrado, cifrar: false);
        }

        // --- Métodos auxiliares ---
        private string LimpiarTexto(string texto)
        {
            return new string(texto.ToUpper().Where(c => char.IsLetter(c)).ToArray());
        }

        // Sustitución polialfabética (Vigenère)
        private string SustitucionPolialfabetica(string texto, bool cifrar)
        {
            StringBuilder resultado = new StringBuilder();
            for (int i = 0; i < texto.Length; i++)
            {
                char letraTexto = texto[i];
                char letraClave = clave[i % clave.Length];

                int desplazamiento = cifrar ? (letraClave - 'A') : -(letraClave - 'A');
                char letraTransformada = (char)(((letraTexto - 'A' + desplazamiento + 26) % 26) + 'A');

                resultado.Append(letraTransformada);
            }
            return resultado.ToString();
        }

        // Anagramación por columnas (permutación basada en clave)
        private string AnagramarColumnas(string texto, bool cifrar)
        {
            int columnas = clave.Length;
            int filas = (int)Math.Ceiling((double)texto.Length / columnas);
            texto = texto.PadRight(filas * columnas, 'X');

            char[,] matriz = new char[filas, columnas];
            for (int i = 0, k = 0; i < filas; i++)
                for (int j = 0; j < columnas; j++)
                    matriz[i, j] = texto[k++];

            int[] ordenColumnas = ObtenerOrdenPermutacion(clave);

            StringBuilder resultado = new StringBuilder();
            if (cifrar)
            {
                // Cifrar: leer columnas en orden permutado
                foreach (int col in ordenColumnas)
                    for (int i = 0; i < filas; i++)
                        resultado.Append(matriz[i, col]);
            }
            else
            {
                // Descifrar: reordenar columnas
                char[,] matrizReordenada = new char[filas, columnas];
                for (int j = 0; j < columnas; j++)
                    for (int i = 0; i < filas; i++)
                        matrizReordenada[i, ordenColumnas[j]] = matriz[i, j];

                // Leer por filas
                for (int i = 0; i < filas; i++)
                    for (int j = 0; j < columnas; j++)
                        resultado.Append(matrizReordenada[i, j]);
            }

            return resultado.ToString().Replace("X", "");
        }

        // Anagramación por filas (permutación basada en clave)
        private string AnagramarFilas(string texto, bool cifrar)
        {
            int columnas = clave.Length;
            int filas = (int)Math.Ceiling((double)texto.Length / columnas);
            texto = texto.PadRight(filas * columnas, 'X');

            char[,] matriz = new char[filas, columnas];
            for (int i = 0, k = 0; i < filas; i++)
                for (int j = 0; j < columnas; j++)
                    matriz[i, j] = texto[k++];

            int[] ordenFilas = ObtenerOrdenPermutacion(clave);

            StringBuilder resultado = new StringBuilder();
            if (cifrar)
            {
                // Cifrar: permutar filas
                foreach (int fila in ordenFilas)
                    for (int j = 0; j < columnas; j++)
                        if (fila < filas)
                            resultado.Append(matriz[fila, j]);
            }
            else
            {
                // Descifrar: revertir permutación
                char[,] matrizReordenada = new char[filas, columnas];
                int idxFila = 0;
                foreach (int fila in ordenFilas)
                {
                    if (fila >= filas) continue;
                    for (int j = 0; j < columnas; j++)
                        matrizReordenada[fila, j] = matriz[idxFila / columnas, j];
                    idxFila++;
                }

                // Leer por filas
                for (int i = 0; i < filas; i++)
                    for (int j = 0; j < columnas; j++)
                        resultado.Append(matrizReordenada[i, j]);
            }

            return resultado.ToString().Replace("X", "");
        }

        // Obtiene el orden de permutación basado en la clave (ejemplo: "CLAVE" -> [1, 3, 0, 4, 2])
        private int[] ObtenerOrdenPermutacion(string clave)
        {
            var caracteres = clave.Select((c, i) => new { Char = c, Index = i })
                                .OrderBy(x => x.Char)
                                .Select(x => x.Index)
                                .ToArray();
            return caracteres;
        }
    }
}
