using System;
using System.Linq;
using System.Text;

namespace CRIPTOGRAFIA
{
    public class CifradoTransposicionGrupos
    {
        private int _tamanoGrupo = 3;
        private string _tipoPermutacion = "Invertir";

        public int TamanoGrupo
        {
            get => _tamanoGrupo;
            set => _tamanoGrupo = value > 0 ? value : 3;
        }

        public string TipoPermutacion
        {
            get => _tipoPermutacion;
            set => _tipoPermutacion = ValidarTipoPermutacion(value);
        }

        public string Cifrar(string textoOriginal)
        {
            textoOriginal = PrepararTexto(textoOriginal);
            var textoCifrado = new StringBuilder();

            for (int i = 0; i < textoOriginal.Length; i += TamanoGrupo)
            {
                string grupo = ExtraerGrupo(textoOriginal, i);
                string grupoCifrado = AplicarPermutacion(grupo);
                textoCifrado.Append(grupoCifrado);
            }

            return textoCifrado.ToString();
        }

        public string Descifrar(string textoCifrado)
        {
            textoCifrado = PrepararTexto(textoCifrado);
            var textoDescifrado = new StringBuilder();

            for (int i = 0; i < textoCifrado.Length; i += TamanoGrupo)
            {
                string grupo = ExtraerGrupo(textoCifrado, i);
                string grupoDescifrado = AplicarPermutacionInversa(grupo);
                textoDescifrado.Append(grupoDescifrado);
            }

            return textoDescifrado.ToString();
        }

        private string PrepararTexto(string texto)
        {
            // 1. Convertir a mayúsculas
            texto = texto.ToUpperInvariant();

            // 2. Eliminar espacios
            texto = texto.Replace(" ", "");

            // 3. Completar con caracteres de relleno si es necesario
            int caracteresFaltantes = texto.Length % TamanoGrupo;
            if (caracteresFaltantes != 0)
            {
                texto += new string('X', TamanoGrupo - caracteresFaltantes);
            }

            return texto;
        }

        private string ExtraerGrupo(string texto, int indiceInicio)
        {
            int longitud = Math.Min(TamanoGrupo, texto.Length - indiceInicio);
            return texto.Substring(indiceInicio, longitud);
        }

        private string AplicarPermutacion(string grupo)
        {
            switch (TipoPermutacion)
            {
                case "Invertir":
                    return InvertirGrupo(grupo);

                case "Intercalar":
                    return IntercalarGrupo(grupo);

                case "Rotar":
                    return RotarGrupo(grupo, 1);

                default:
                    return grupo;
            }
        }

        private string AplicarPermutacionInversa(string grupo)
        {
            switch (TipoPermutacion)
            {
                case "Invertir":
                    return InvertirGrupo(grupo);

                case "Intercalar":
                    return IntercalarGrupo(grupo);

                case "Rotar":
                    return RotarGrupo(grupo, -1);

                default:
                    return grupo;
            }
        }

        private string InvertirGrupo(string grupo)
        {
            char[] caracteres = grupo.ToCharArray();
            Array.Reverse(caracteres);
            return new string(caracteres);
        }

        private string IntercalarGrupo(string grupo)
        {
            if (grupo.Length == 3)
            {
                return $"{grupo[1]}{grupo[0]}{grupo[2]}";
            }
            return grupo;
        }

        private string RotarGrupo(string grupo, int posiciones)
        {
            if (grupo.Length == 0) return grupo;

            posiciones %= grupo.Length;
            if (posiciones < 0)
                posiciones += grupo.Length;

            return grupo.Substring(posiciones) + grupo.Substring(0, posiciones);
        }

        private string ValidarTipoPermutacion(string tipo)
        {
            string[] tiposValidos = { "Invertir", "Intercalar", "Rotar" };
            return tiposValidos.Contains(tipo) ? tipo : "Invertir";
        }
    }
}