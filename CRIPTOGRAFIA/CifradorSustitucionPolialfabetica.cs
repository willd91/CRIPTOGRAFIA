using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRIPTOGRAFIA
{
    public class CifradorSustitucionPolialfabetica
    {
        private string _clave;

        public CifradorSustitucionPolialfabetica(string clave)
        {
            _clave = clave.ToUpper(); // Normalizar la clave a mayúsculas
        }

        // Cifra un texto usando sustitución polialfabética
        public string Cifrar(string textoPlano)
        {
            textoPlano = LimpiarTexto(textoPlano);
            StringBuilder textoCifrado = new StringBuilder();

            for (int i = 0; i < textoPlano.Length; i++)
            {
                char letraOriginal = textoPlano[i];
                char letraClave = _clave[i % _clave.Length]; // Ciclar la clave

                // Aplicar el cifrado de Vigenère: C = (P + K) mod 26
                char letraCifrada = (char)(((letraOriginal - 'A' + letraClave - 'A') % 26) + 'A');
                textoCifrado.Append(letraCifrada);
            }

            return textoCifrado.ToString();
        }

        // Descifra un texto cifrado con sustitución polialfabética
        public string Descifrar(string textoCifrado)
        {
            textoCifrado = LimpiarTexto(textoCifrado);
            StringBuilder textoDescifrado = new StringBuilder();

            for (int i = 0; i < textoCifrado.Length; i++)
            {
                char letraCifrada = textoCifrado[i];
                char letraClave = _clave[i % _clave.Length];

                // Aplicar el descifrado de Vigenère: P = (C - K + 26) mod 26
                char letraOriginal = (char)(((letraCifrada - 'A' - (letraClave - 'A') + 26) % 26) + 'A');
                textoDescifrado.Append(letraOriginal);
            }

            return textoDescifrado.ToString();
        }

        // Elimina caracteres no alfabéticos y convierte a mayúsculas
        private string LimpiarTexto(string texto)
        {
            StringBuilder textoLimpio = new StringBuilder();
            foreach (char c in texto.ToUpper())
            {
                if (char.IsLetter(c))
                    textoLimpio.Append(c);
            }
            return textoLimpio.ToString();
        }
        public string GetClave()
        {
            return _clave;
        }
        public void SetClave(string clave)
        {
            _clave = clave.ToUpper(); // Normalizar la clave a mayúsculas
        }
    }
}
