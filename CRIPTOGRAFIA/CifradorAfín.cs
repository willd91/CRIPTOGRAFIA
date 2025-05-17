using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRIPTOGRAFIA
{
    public class CifradorAfín
    {
        private int _a;  // Clave 'a' (debe ser coprimo con 26)
        private int _b;  // Clave 'b'
        private int _aInverso;  // Inverso modular de 'a'

        public CifradorAfín(int a, int b)
        {
            if (MaximoComunDivisor(a, 26) != 1)
                throw new ArgumentException("'a' debe ser coprimo con 26.");

            _a = a;
            _b = b;
            _aInverso = InversoModular(a, 26);
        }

        // Cifrar texto
        public string Cifrar(string textoPlano)
        {
            textoPlano = LimpiarTexto(textoPlano);
            StringBuilder textoCifrado = new StringBuilder();

            foreach (char letra in textoPlano)
            {
                int p = letra - 'A';
                int c = (_a * p + _b) % 26;
                textoCifrado.Append((char)(c + 'A'));
            }

            return textoCifrado.ToString();
        }

        // Descifrar texto
        public string Descifrar(string textoCifrado)
        {
            textoCifrado = LimpiarTexto(textoCifrado);
            StringBuilder textoPlano = new StringBuilder();

            foreach (char letra in textoCifrado)
            {
                int c = letra - 'A';
                int p = (_aInverso * (c - _b + 26)) % 26; // +26 evita negativos
                textoPlano.Append((char)(p + 'A'));
            }

            return textoPlano.ToString();
        }

        // Limpiar texto (solo letras mayúsculas)
        private string LimpiarTexto(string texto)
        {
            StringBuilder limpio = new StringBuilder();
            foreach (char c in texto.ToUpper())
            {
                if (char.IsLetter(c))
                    limpio.Append(c);
            }
            return limpio.ToString();
        }

        // Calcular el Máximo Común Divisor (MCD)
        private int MaximoComunDivisor(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        // Calcular el inverso modular de 'a' módulo 26
        private int InversoModular(int a, int m)
        {
            a = a % m;
            for (int x = 1; x < m; x++)
            {
                if ((a * x) % m == 1)
                    return x;
            }
            throw new ArgumentException("No existe inverso modular para 'a'.");
        }
    }
}
