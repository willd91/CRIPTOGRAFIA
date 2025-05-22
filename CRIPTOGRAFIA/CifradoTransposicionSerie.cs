using System;
using System.Linq;
using System.Text;

namespace CRIPTOGRAFIA
{
    /// <summary>
    /// Implementa el cifrado de transposición por serie, donde la clave alfabética define
    /// automáticamente el tamaño de la serie y el orden de permutación.
    /// </summary>
    public class CifradoTransposicionSerie
    {
        private string _clave = "HOLA";  // Clave alfabética por defecto (tamaño de serie = 4)
        private int[] _claveNumerica;    // Clave numérica derivada de la alfabética
        private const char Relleno = 'X'; // Carácter para rellenar series incompletas

        /// <summary>
        /// Propiedad Clave: Establece o devuelve la clave alfabética.
        /// - Al asignarla, se valida, limpia y actualiza la clave numérica automáticamente.
        /// </summary>
        public string Clave
        {
            get => _clave;
            set
            {
                // Limpiar la clave: eliminar caracteres no alfabéticos y convertir a mayúsculas
                string nuevaClave = new string(value.Where(c => char.IsLetter(c)).ToArray()).ToUpper();

                if (nuevaClave.Length < 2)
                    throw new ArgumentException("La clave debe tener al menos 2 letras.");

                _clave = nuevaClave;
                ActualizarClaveNumerica(); // Actualiza la clave numérica
            }
        }

        /// <summary>
        /// Tamaño de la serie (solo lectura). Se calcula como la longitud de la clave.
        /// </summary>
        public int TamanoSerie => _clave.Length;

        /// <summary>
        /// Constructor: Inicializa la clave numérica con la clave alfabética por defecto ("HOLA").
        /// </summary>
        public CifradoTransposicionSerie()
        {
            ActualizarClaveNumerica();
        }

        /// <summary>
        /// Cifra un texto aplicando la transposición por serie usando la clave configurada.
        /// </summary>
        /// <param name="textoPlano">Texto a cifrar (se eliminan espacios y se convierte a mayúsculas).</param>
        /// <returns>Texto cifrado.</returns>
        public string Cifrar(string textoPlano)
        {
            // Normalizar el texto: a mayúsculas y sin espacios
            textoPlano = textoPlano.ToUpper().Replace(" ", "");
            StringBuilder textoCifrado = new StringBuilder();

            // Rellenar con 'X' si la longitud no es divisible por el tamaño de la serie
            while (textoPlano.Length % TamanoSerie != 0)
                textoPlano += Relleno;

            // Dividir en series y permutar cada una
            for (int i = 0; i < textoPlano.Length; i += TamanoSerie)
            {
                string serie = textoPlano.Substring(i, TamanoSerie);
                textoCifrado.Append(PermutarSerie(serie, _claveNumerica));
            }

            return textoCifrado.ToString();
        }

        /// <summary>
        /// Descifra un texto aplicando la permutación inversa.
        /// </summary>
        /// <param name="textoCifrado">Texto cifrado (se eliminan espacios).</param>
        /// <returns>Texto descifrado (sin caracteres de relleno).</returns>
        public string Descifrar(string textoCifrado)
        {
            textoCifrado = textoCifrado.ToUpper().Replace(" ", "");
            StringBuilder textoDescifrado = new StringBuilder();

            // Obtener clave inversa para descifrar
            int[] claveInversa = ObtenerClaveInversa(_claveNumerica);

            // Dividir en series y aplicar permutación inversa
            for (int i = 0; i < textoCifrado.Length; i += TamanoSerie)
            {
                string serie = textoCifrado.Substring(i, TamanoSerie);
                textoDescifrado.Append(PermutarSerie(serie, claveInversa));
            }

            // Eliminar caracteres de relleno (opcional)
            return textoDescifrado.ToString().TrimEnd(Relleno);
        }

        /// <summary>
        /// Actualiza la clave numérica basándose en la clave alfabética actual.
        /// - Ordena las letras alfabéticamente y asigna posiciones.
        /// </summary>
        private void ActualizarClaveNumerica()
        {
            var letrasOrdenadas = _clave.Select((c, i) => new { Char = c, Index = i + 1 })
                                       .OrderBy(x => x.Char)
                                       .ToArray();

            _claveNumerica = new int[TamanoSerie];
            for (int i = 0; i < letrasOrdenadas.Length; i++)
            {
                _claveNumerica[letrasOrdenadas[i].Index - 1] = i + 1;
            }
        }

        /// <summary>
        /// Permuta una serie según una clave numérica.
        /// </summary>
        private string PermutarSerie(string serie, int[] clave)
        {
            char[] seriePermutada = new char[serie.Length];
            for (int i = 0; i < clave.Length; i++)
            {
                seriePermutada[i] = serie[clave[i] - 1]; // -1 para índices base 0
            }
            return new string(seriePermutada);
        }

        /// <summary>
        /// Genera la clave inversa para descifrar.
        /// </summary>
        private int[] ObtenerClaveInversa(int[] clave)
        {
            int[] claveInversa = new int[clave.Length];
            for (int i = 0; i < clave.Length; i++)
            {
                claveInversa[clave[i] - 1] = i + 1;
            }
            return claveInversa;
        }
    }
}