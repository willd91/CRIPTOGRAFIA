using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CRIPTOGRAFIA
{
    public class CifradoDesplazamiento
    {
        private string clave;
        private string alfabeto;

        public CifradoDesplazamiento(string clave = "CLAVE", string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ")
        {
            this.clave = clave.ToUpper();
            this.alfabeto = alfabeto.ToUpper();
        }

        public void SetClave(string nuevaClave)
        {
            if (!string.IsNullOrEmpty(nuevaClave))
                this.clave = nuevaClave.ToUpper();
        }

        public string GetClave()
        {
            return this.clave;
        }

        public string Cifrar(string texto)
        {
            texto = texto.ToUpper();// se convierte todo a mayusculas
            StringBuilder resultado = new StringBuilder();

            for (int i = 0; i < texto.Length; i++)  
            {
                char letraTexto = texto[i];//se obtiene la la letra en la posicion i
                char letraClave = clave[i % clave.Length];//se obtiene la letra en la posicion i de la clave, si la clave es pequeña se vuelve a recorrer.

                if (alfabeto.Contains(letraTexto.ToString()))//se verifica si la letra pertenece al alfabeto, 
                {
                    int valorTexto = alfabeto.IndexOf(letraTexto);   //obtenemos la posicion de la letra en el alfabeto
                    int valorClave = alfabeto.IndexOf(letraClave);   //obtenemos la posicion de la letra clave en el alfabeto
                    int valorCifrado = (valorTexto + valorClave) % alfabeto.Length;// desplazamos i posiciones de la letra clave
                    resultado.Append(alfabeto[valorCifrado]);    //agregamos la letra al resultado
                }
                else  //si no lo esta simplemente se lo agrega
                {
                    resultado.Append(letraTexto);
                }
            }
            return resultado.ToString();  
        }

        public string Descifrar(string textoCifrado)
        {
            textoCifrado = textoCifrado.ToUpper();   //convertimos todo a mayusculas
            StringBuilder resultado = new StringBuilder();

            for (int i = 0; i < textoCifrado.Length; i++)
            {
                char letraTexto = textoCifrado[i];   //obtenemos la letra i del texto
                char letraClave = clave[i % clave.Length];//obtenemos la letra i de la clave, si la clave es menor se repite

                if (alfabeto.Contains(letraTexto.ToString())) //verificamos si la letra pertene al alfabeto
                {
                    int valorTexto = alfabeto.IndexOf(letraTexto);//obtenemos la posicion de la letra en el alfabeto
                    int valorClave = alfabeto.IndexOf(letraClave);//obtenemos la posicion de la letra clave en el alfabeto
                    int valorDescifrado = (valorTexto - valorClave + alfabeto.Length) % alfabeto.Length;//obtenemos la posicion desplazada
                    resultado.Append(alfabeto[valorDescifrado]); //agregamos el caracter en posicion desplazada al resultado
                }
                else
                {
                    resultado.Append(letraTexto);
                }
            }
            return resultado.ToString();
        }
    }
}