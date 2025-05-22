using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace CRIPTOGRAFIA
{
    public class AtaqueKasiski
    {
        private string textoCifrado;
        private Dictionary<string, List<int>> secuenciasRepetidas;
        private int longitudClave;
        private string claveProbable;

        public AtaqueKasiski(string textoCifrado)
        {
            this.textoCifrado = LimpiarTexto(textoCifrado);
            this.secuenciasRepetidas = new Dictionary<string, List<int>>();
            this.longitudClave = 0;
            this.claveProbable = "";
        }
        public void SetTexto(string textoCifrado)
        {
            this.textoCifrado = LimpiarTexto(textoCifrado);
        }
        private string LimpiarTexto(string texto)
        {
            // Eliminar caracteres no alfabéticos y convertir a mayúsculas
            return Regex.Replace(texto.ToUpper(), "[^A-Z]", "");
        }

        public Dictionary<string, List<int>> EncontrarSecuenciasRepetidas(int longitudSecuencia = 3)
        {
            secuenciasRepetidas.Clear();

            for (int i = 0; i < textoCifrado.Length - longitudSecuencia + 1; i++)
            {
                string secuencia = textoCifrado.Substring(i, longitudSecuencia);

                if (secuenciasRepetidas.ContainsKey(secuencia))
                {
                    secuenciasRepetidas[secuencia].Add(i);
                }
                else
                {
                    secuenciasRepetidas[secuencia] = new List<int> { i };
                }
            }

            // Filtrar solo secuencias que aparecen más de una vez
            var secuenciasFiltradas = secuenciasRepetidas
                .Where(kv => kv.Value.Count > 1)
                .ToDictionary(kv => kv.Key, kv => kv.Value);

            secuenciasRepetidas = secuenciasFiltradas;
            return secuenciasRepetidas;
        }

        public List<int> CalcularDistancias()
        {
            var distancias = new List<int>();

            foreach (var secuencia in secuenciasRepetidas.Values)
            {
                for (int i = 1; i < secuencia.Count; i++)
                {
                    distancias.Add(secuencia[i] - secuencia[i - 1]);
                }
            }

            return distancias;
        }

        public int EstimarLongitudClave()
        {
            var distancias = CalcularDistancias();

            if (distancias.Count == 0)
                return 0;

            int CalcularMCD(int a, int b)
            {
                while (b != 0)
                {
                    int temp = b;
                    b = a % b;
                    a = temp;
                }
                return a;
            }

            int mcd = distancias.Aggregate(CalcularMCD);
            longitudClave = mcd;
            return mcd;
        }

        public List<List<char>> DividirEnGrupos(int longitud)
        {
            var grupos = new List<List<char>>();
            for (int i = 0; i < longitud; i++)
            {
                grupos.Add(new List<char>());
            }

            for (int i = 0; i < textoCifrado.Length; i++)
            {
                grupos[i % longitud].Add(textoCifrado[i]);
            }

            return grupos;
        }

        public int AnalizarFrecuencias(List<char> grupo, string idioma = "es")
        {
            var frecuencias = new Dictionary<string, Dictionary<char, double>>()
            {
                ["es"] = new Dictionary<char, double>
            {
                {'E', 0.130}, {'A', 0.115}, {'O', 0.087}, {'S', 0.079}, {'R', 0.068}
            },
                ["en"] = new Dictionary<char, double>
            {
                {'E', 0.127}, {'T', 0.091}, {'A', 0.082}, {'O', 0.075}, {'I', 0.070}
            }
            };

            var frecuenciasIdioma = frecuencias.ContainsKey(idioma) ? frecuencias[idioma] : frecuencias["es"];
            char letraMasComunIdioma = frecuenciasIdioma.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;

            var contador = new Dictionary<char, int>();
            foreach (char c in grupo)
            {
                if (contador.ContainsKey(c))
                    contador[c]++;
                else
                    contador[c] = 1;
            }

            char letraMasComunGrupo = contador.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;

            int desplazamiento = (letraMasComunGrupo - letraMasComunIdioma) % 26;
            return desplazamiento;
        }

        public string EncontrarClave(string idioma = "es")
        {
            if (longitudClave == 0)
            {
                EstimarLongitudClave();
                if (longitudClave == 0)
                    return "";
            }

            var grupos = DividirEnGrupos(longitudClave);
            var clave = new StringBuilder();

            foreach (var grupo in grupos)
            {
                int desplazamiento = AnalizarFrecuencias(grupo, idioma);
                char letraClave = (char)(((desplazamiento % 26) + 'A'));
                clave.Append(letraClave);
            }

            claveProbable = clave.ToString();
            return claveProbable;
        }

        public string DescifrarVigenere(string clave)
        {
            var textoDescifrado = new StringBuilder();
            string claveRepetida = clave;

            while (claveRepetida.Length < textoCifrado.Length)
            {
                claveRepetida += clave;
            }
            claveRepetida = claveRepetida.Substring(0, textoCifrado.Length);

            for (int i = 0; i < textoCifrado.Length; i++)
            {
                int valorC = textoCifrado[i] - 'A';
                int valorK = claveRepetida[i] - 'A';

                int valorDescifrado = (valorC - valorK) % 26;
                if (valorDescifrado < 0)
                    valorDescifrado += 26;

                char letraDescifrada = (char)(valorDescifrado + 'A');
                textoDescifrado.Append(letraDescifrada);
            }

            return textoDescifrado.ToString();
        }

        public (string clave, string textoDescifrado) DescifrarAutomatico(string idioma = "es")
        {
            // Paso 1: Encontrar secuencias repetidas
            EncontrarSecuenciasRepetidas();

            // Paso 2: Estimar longitud de la clave
            int longitud = EstimarLongitudClave();
            if (longitud == 0)
                return ("", "No se pudo determinar la longitud de la clave");

            // Paso 3: Encontrar la clave probable
            string clave = EncontrarClave(idioma);

            // Paso 4: Descifrar con la clave encontrada
            string textoDescifrado = DescifrarVigenere(clave);

            return (clave, textoDescifrado);
        }

        public (string clave, string textoDescifrado) DescifrarConLongitud(int longitud, string idioma = "es")
        {
            longitudClave = longitud;
            string clave = EncontrarClave(idioma);
            string textoDescifrado = DescifrarVigenere(clave);
            return (clave, textoDescifrado);
        }
    }
}