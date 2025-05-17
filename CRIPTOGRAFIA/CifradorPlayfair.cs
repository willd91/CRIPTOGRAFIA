using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRIPTOGRAFIA
{
    using System;
    using System.Text;
    using System.Linq;

    public class CifradorPlayfair
    {
        private char[,] matrizClave = new char[5, 5];
        private const string alfabeto = "ABCDEFGHIKLMNOPQRSTUVWXYZ"; // Excluye 'J'

        public CifradorPlayfair(string clave)
        {
            GenerarMatrizClave(clave);
        }

        // =====================================
        // 1. GENERACIÓN DE LA MATRIZ CLAVE
        // =====================================
        private void GenerarMatrizClave(string clave)
        {
            // Preprocesar la clave: eliminar duplicados y reemplazar J con I
            clave = clave.ToUpper()
                    .Replace("J", "I")
                    .Replace(" ", "");

            string claveUnica = new string(clave.Distinct().ToArray());
            string letrasRestantes = new string(alfabeto.Except(claveUnica).ToArray());
            string claveCompleta = claveUnica + letrasRestantes;

            // Llenar matriz 5x5
            for (int i = 0, indice = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrizClave[i, j] = claveCompleta[indice++];
                }
            }
        }

        // =====================================
        // 2. FUNCIÓN DE CIFRADO
        // =====================================
        public string Cifrar(string textoPlano)
        {
            // Preprocesar el texto de entrada
            textoPlano = PrepararTexto(textoPlano);

            StringBuilder textoCifrado = new StringBuilder();

            for (int i = 0; i < textoPlano.Length; i += 2)
            {
                char primerCaracter = textoPlano[i];
                char segundoCaracter = (i + 1 < textoPlano.Length) ? textoPlano[i + 1] : 'X';

                // Manejar pares de letras repetidas
                if (primerCaracter == segundoCaracter)
                {
                    segundoCaracter = 'X';
                    i--; // Revisitar el segundo carácter en la siguiente iteración
                }

                var posicion1 = BuscarPosicion(primerCaracter);
                var posicion2 = BuscarPosicion(segundoCaracter);

                // Aplicar reglas de cifrado
                if (posicion1.Fila == posicion2.Fila)
                {
                    // Misma fila: desplazar a la derecha
                    textoCifrado.Append(matrizClave[posicion1.Fila, (posicion1.Columna + 1) % 5]);
                    textoCifrado.Append(matrizClave[posicion2.Fila, (posicion2.Columna + 1) % 5]);
                }
                else if (posicion1.Columna == posicion2.Columna)
                {
                    // Misma columna: desplazar hacia abajo
                    textoCifrado.Append(matrizClave[(posicion1.Fila + 1) % 5, posicion1.Columna]);
                    textoCifrado.Append(matrizClave[(posicion2.Fila + 1) % 5, posicion2.Columna]);
                }
                else
                {
                    // Rectángulo: intercambiar columnas
                    textoCifrado.Append(matrizClave[posicion1.Fila, posicion2.Columna]);
                    textoCifrado.Append(matrizClave[posicion2.Fila, posicion1.Columna]);
                }
            }

            return textoCifrado.ToString();
        }

        // =====================================
        // 3. FUNCIÓN DE DESCIFRADO
        // =====================================
        public string Descifrar(string textoCifrado)
        {
            textoCifrado = textoCifrado.ToUpper().Replace(" ", "");
            StringBuilder textoPlano = new StringBuilder();

            for (int i = 0; i < textoCifrado.Length; i += 2)
            {
                char primerCaracter = textoCifrado[i];
                char segundoCaracter = textoCifrado[i + 1];

                var posicion1 = BuscarPosicion(primerCaracter);
                var posicion2 = BuscarPosicion(segundoCaracter);

                // Aplicar reglas inversas
                if (posicion1.Fila == posicion2.Fila)
                {
                    // Misma fila: desplazar a la izquierda
                    textoPlano.Append(matrizClave[posicion1.Fila, (posicion1.Columna - 1 + 5) % 5]);
                    textoPlano.Append(matrizClave[posicion2.Fila, (posicion2.Columna - 1 + 5) % 5]);
                }
                else if (posicion1.Columna == posicion2.Columna)
                {
                    // Misma columna: desplazar hacia arriba
                    textoPlano.Append(matrizClave[(posicion1.Fila - 1 + 5) % 5, posicion1.Columna]);
                    textoPlano.Append(matrizClave[(posicion2.Fila - 1 + 5) % 5, posicion2.Columna]);
                }
                else
                {
                    // Rectángulo: intercambiar columnas (igual que cifrado)
                    textoPlano.Append(matrizClave[posicion1.Fila, posicion2.Columna]);
                    textoPlano.Append(matrizClave[posicion2.Fila, posicion1.Columna]);
                }
            }

            // Eliminar X de relleno (excepto si eran parte del mensaje original)
            return EliminarRelleno(textoPlano.ToString());
        }

        // =====================================
        // FUNCIONES AUXILIARES
        // =====================================
        private string PrepararTexto(string texto)
        {
            texto = texto.ToUpper()
                      .Replace("J", "I")
                      .Replace(" ", "");

            // Insertar X entre letras repetidas
            StringBuilder textoProcesado = new StringBuilder();
            for (int i = 0; i < texto.Length; i++)
            {
                textoProcesado.Append(texto[i]);
                if (i + 1 < texto.Length && texto[i] == texto[i + 1])
                {
                    textoProcesado.Append('X');
                }
            }

            // Añadir X si la longitud es impar
            if (textoProcesado.Length % 2 != 0)
            {
                textoProcesado.Append('X');
            }

            return textoProcesado.ToString();
        }

        private string EliminarRelleno(string texto)
        {
            if (texto.Length <= 2) return texto;

            // Solo elimina X final si fue añadida
            if (texto[texto.Length - 1] == 'X' &&
                texto[texto.Length - 3] != texto[texto.Length - 2])
            {
                return texto.Substring(0, texto.Length - 1);
            }

            return texto;
        }

        private (int Fila, int Columna) BuscarPosicion(char caracter)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (matrizClave[i, j] == caracter)
                    {
                        return (i, j);
                    }
                }
            }
            throw new ArgumentException($"Carácter no encontrado: {caracter}");
        }

        // =====================================
        // MÉTODO PARA VISUALIZAR MATRIZ (DEBUG)
        // =====================================
        public string ObtenerMatrizClaveComoCadena()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    sb.Append(matrizClave[i, j] + " ");
                }
                sb.AppendLine(); // Salto de línea al final de cada fila
            }

            return sb.ToString();
        }
        public void ActualizarClave(string clave)
        {
            GenerarMatrizClave(clave);
        }
        public string PrepararTextoParaPlayfair(string textoOriginal)
        {
            // 1. Convertir a mayúsculas y eliminar espacios
            string texto = textoOriginal.ToUpper().Replace(" ", "");

            // 2. Reemplazar 'J' por 'I' (según convención estándar)
            texto = texto.Replace("J", "I");

            // 3. Insertar 'X' entre letras repetidas en digramas
            StringBuilder textoProcesado = new StringBuilder();
            for (int i = 0; i < texto.Length; i++)
            {
                textoProcesado.Append(texto[i]);

                // Si es el último carácter no verificamos el siguiente
                if (i + 1 >= texto.Length) continue;

                // Si hay dos letras iguales seguidas, insertar 'X' entre ellas
                if (texto[i] == texto[i + 1])
                {
                    textoProcesado.Append('X');
                }
            }

            // 4. Añadir 'X' al final si la longitud es impar
            if (textoProcesado.Length % 2 != 0)
            {
                textoProcesado.Append('X');
            }

            return textoProcesado.ToString();
        }
    }
}
