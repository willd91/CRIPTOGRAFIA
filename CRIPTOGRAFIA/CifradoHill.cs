using CRIPTOGRAFIA;
using System;

    /*La clase Cifrado Hill contendra todos los procedimientos que forman parte del proceso de los algotirmos
     de cifradom se tratara de que todos los atributos sean genericos*/
    public class CifradoHill
    {   
    //---------------------------------------------------Atriburos-----------------------------------------------------------------------//
        int[,] clave_matriz;                            //Matriz que contiene la matriz de numeros clave que se usara en los procesos de cidrado.
        char[,] matrizTexto;                            //Matriz que contiene los caracteres del texto original dividitos en columnas de acuerto al modulo.
        int[,] matizTextoNumerico;                      //Matriz que contiene el valor numero de las letras en base al alfabeto.
        int modulo;                                      //el modulo es la base del sistema de cifrado basado en la cantidad de caracteres del alfabeto.
        int tamaño;
        string alfabeto;                                //Todos los caracteres que conformaran el alfabeto de cifrado.
        string texto;                                   //texto que contiene el texto que sera cifrado.
        private static Random rand = new Random();      //variable interna que se usara para generar numeros aleatorios.
        
    //------------------------------------------------------Constructores----------------------------------------------------------------//
    public CifradoHill()
    {
        this.tamaño = 4;
        this.texto = "hola mundo";     
        this.alfabeto = " !\"#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_`abcdefghijklmnopqrstuvwxyz{|}~¡¢£¤¥¦§¨©ª«¬­®¯°±²³´µ¶·¸¹º»¼½¾¿ÀÁÂÃÄÅÆÇÈÉÊËÌÍÎÏÐÑÒÓÔÕÖ×ØÙÚÛÜÝÞßàáâãäåæçèéêëìíîïðñòóôõö÷øùúûüýþÿ\r\n";
        this.clave_matriz = math.GenerarMatrizClaveInvertible(this.tamaño,alfabeto.Length);
    }
    public CifradoHill(int tamaño,string alfabeto)
    {
        this.modulo = alfabeto.Length;
        this.tamaño = tamaño;
        this.clave_matriz = new int[tamaño,tamaño];
        this.alfabeto= alfabeto;
        this.texto = "hola mundo";
        this.llenar_matrizclave();
        this.llenar_matriztexto();
        this.llenar_matriztextoint();
    }
    public CifradoHill(string alfabeto, string texto)
    {
        this.modulo = alfabeto.Length;
        this.alfabeto = alfabeto;
        this.texto = texto;
        this.llenar_matrizclave();
        this.llenar_matriztexto();
        this.llenar_matriztextoint();
    }
    public CifradoHill(int tamaño, string alfabeto,string texto)
    {
        this.modulo =alfabeto.Length;
        this.clave_matriz = new int[tamaño, tamaño];
        this.alfabeto = alfabeto;
        this.tamaño = tamaño;
        this.texto= texto;
        this.llenar_matrizclave();
        this.llenar_matriztexto();
        this.llenar_matriztextoint();
    }
    //---------------------------------------------------Geters y setters----------------------------------------------------------------//
    public String GetTexto()
    {
        return this.texto;
    }
    public void SetTexto(String texto)
    {
        this.texto = texto;
    }
    public int[,] GetMclave()
    {
        return clave_matriz;
    }
    public void SetMclave(int[,] mclave)
    {
        this.clave_matriz=mclave;
    }
    public char[,] GetMtexto()
    {
        return this.matrizTexto;
    }
    public int[,] GetMtextoInt()
    {
        return this.matizTextoNumerico;
    }
    public int GetModulo()
    {
        return this.modulo;
    }
    public void SetModulo(int modulo)
    {
        this.modulo = modulo;
    }
    public string GetAlfabeto()
    {
        return this.alfabeto;
    }
    public void SetAlfabeto(string alfabeto)
    {
        this.alfabeto = alfabeto;
    }
    public int GetTamaño()
    {
        return this.tamaño;
    }
    public void SetTamaño(int tama)
    {
        this.tamaño = tama;
    }
    //----------------------------------------------Funciones y procedimientos de apoyo----------------------------------------------------------------//
    public void llenar_matrizclave()
    {
        this.clave_matriz = GenerarMatrizInvertible();
    }
    public void llenar_matriztexto()
    {
        this.LlenarMatriz();
    }
    public void llenar_matriztextoint()
    {
        this.matizTextoNumerico = ObtenerPosicionesEnAlfabeto();
    }
    //--------------Funciones y procedimientos------------------------------------------------------------------------------------------//
    public int[,] GenerarMatrizInvertible(int n)
    {
        int[,] matriz;
        int det;

        do
        {
            matriz = new int[n, n];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    matriz[i, j] = rand.Next(1, alfabeto.Length); // valores entre -10 y 10

            det = Determinante(matriz);
        }
        while (Math.Abs(det) < 1e-6); // Evitar determinantes cercanos a cero

        return matriz;
    }
    public int[,] GenerarMatrizInvertible()
    {
        int[,] matriz;
        int det;
        int n = this.tamaño;
        do
        {
            matriz = new int[n, n];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    matriz[i, j] = rand.Next(1, alfabeto.Length); // valores entre -10 y 10

            det = Determinante(matriz);
        }
        while (Math.Abs(det) < 1e-6); // Evitar determinantes cercanos a cero
         return matriz;
    }
    public void LlenarMatriz()
    {   
        int filas =this.tamaño;
        int columnas = (int)Math.Ceiling((double)GetTexto().Length/ filas);
        char[,] matriz = new char[filas, columnas];

        int index = 0;

        for (int col = 0; col < columnas; col++)
        {
            for (int fila = 0; fila < filas; fila++)
            {
                if (index < texto.Length)
                {
                    matriz[fila, col] = texto[index++];
                }
                else
                {
                    matriz[fila, col] = ' ';
                }
            }
        }

        this.matrizTexto= matriz;
    }
    public char[,] LlenarMatriz(string texto, int n)
    {
        // Calcular la cantidad de filas necesarias
        int m = (int)Math.Ceiling((double)texto.Length / n); // número de filas
        char[,] matriz = new char[m, n];
        int index = 0;

        for (int fila = 0; fila < m; fila++)          // recorre filas
        {
            for (int col = 0; col < n; col++)         // recorre columnas
            {
                if (index < texto.Length)
                {
                    matriz[fila, col] = texto[index];
                    index++;
                }
                else
                {
                    matriz[fila, col] = ' '; // relleno con espacios
                }
            }
        }

        return matriz;
    }


    public char[,] LlenarMatriz(string texto, int filas, out int columnas)
    {
        columnas = (int)Math.Ceiling((double)texto.Length / filas);
        char[,] matriz = new char[filas, columnas];

        int index = 0;

        for (int col = 0; col < columnas; col++)
        {
            for (int fila = 0; fila < filas; fila++)
            {
                if (index < texto.Length)
                {
                    matriz[fila, col] = texto[index++];
                }
                else
                {
                    matriz[fila, col] = ' ';
                }
            }
        }

        return matriz;
    }

    //--------------------------------Funciones auxiliares------------------------------------------------------------------------------//
    private int Determinante(int[,] matriz)
    {
        int n = matriz.GetLength(0);
        if (n == 1) return matriz[0, 0];
        if (n == 2)
            return matriz[0, 0] * matriz[1, 1] - matriz[0, 1] * matriz[1, 0];

        int det = 0;
        for (int col = 0; col < n; col++)
        {
            int signo = (col % 2 == 0) ? 1 : -1;
            det += signo * matriz[0, col] * Determinante(Menor(matriz, 0, col));
        }

        return det;
    }
    private int[,] Menor(int[,] matriz, int filaExcluir, int colExcluir)
    {
        int n = matriz.GetLength(0);
        int[,] resultado = new int[n - 1, n - 1];

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
    public int[,] MultiplicarMatrices()
    {
        int[,] matrizClave = GetMclave();
        int[,] matrizM = GetMtextoInt();
        int filasClave = matrizClave.GetLength(0);
        int columnasClave = matrizClave.GetLength(1);
        int filasM = matrizM.GetLength(0);
        int columnasM = matrizM.GetLength(1);

        if (columnasClave != filasM)
            throw new ArgumentException("No se pueden multiplicar: columnas de matrizClave ≠ filas de matrizM");

        int[,] resultado = new int[filasClave, columnasM];

        for (int i = 0; i < filasClave; i++)
        {
            for (int j = 0; j < columnasM; j++)
            {
                int suma = 0;
                for (int k = 0; k < columnasClave; k++)
                {
                    suma += matrizClave[i, k] * matrizM[k, j];
                }
                resultado[i, j] = suma;
            }
        }

        return resultado;
    }
    public int[,] MultiplicarMatrices(int[,] matrizA, int[,] matrizB)
    {
        int filasA = matrizA.GetLength(0);     // número de filas de A
        int columnasA = matrizA.GetLength(1);  // número de columnas de A
        int filasB = matrizB.GetLength(0);     // número de filas de B
        int columnasB = matrizB.GetLength(1);  // número de columnas de B

        // Verificar condición para multiplicar matrices
        if (columnasA != filasB)
            throw new ArgumentException("No se pueden multiplicar: las columnas de la primera matriz deben ser igual a las filas de la segunda.");

        // Crear matriz resultado
        int[,] resultado = new int[filasA, columnasB];

        // Multiplicación de matrices
        for (int i = 0; i < filasA; i++)
        {
            for (int j = 0; j < columnasB; j++)
            {
                int suma = 0;
                for (int k = 0; k < columnasA; k++)
                {
                    suma += matrizA[i, k] * matrizB[k, j];
                }
                resultado[i, j] = suma;
            }
        }

        return resultado;
    }




    // Determinante recursivo (para matrices pequeñas)



    public int[,] AplicarModulo(int[,] matriz, int modulo)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);
        int[,] resultado = new int[filas, columnas];

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                int valor = matriz[i, j] % modulo;
                if (valor < 0)
                    valor += modulo;

                resultado[i, j] = valor;
            }
        }

        return resultado;
    }
    public int[,] AplicarModulo(int[,] matriz)
    {
        int modulo = this.modulo;
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);
        int[,] resultado = new int[filas, columnas];

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                int valor = matriz[i, j] % modulo;
                if (valor < 0)
                    valor += modulo;

                resultado[i, j] = valor;
            }
        }
        return resultado;
    }

    public int[,] ObtenerPosicionesEnAlfabeto()
    {
        char[,] matriz = this.matrizTexto;
        string alfabeto = this.alfabeto;
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);
        int[,] posiciones = new int[filas, columnas];

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                char c = char.ToUpper(matriz[i, j]); // convierte a mayúscula por seguridad
                int pos = alfabeto.IndexOf(c);
                posiciones[i, j] = pos; // -1 si no se encuentra
            }
        }

        return posiciones;
    }
    public int[,] ObtenerPosicionesEnAlfabeto(char[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);
        int[,] posiciones = new int[filas, columnas];

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                char c = matriz[i, j];
                int pos = this.alfabeto.IndexOf(c);
                posiciones[i, j] = pos; // -1 si no se encuentra
            }
        }

        return posiciones;
    }
    public int[,] ObtenerPosicionesEnAlfabeto(char[,] matriz, string alfabeto)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);
        int[,] posiciones = new int[filas, columnas];

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                char c = matriz[i, j]; // convierte a mayúscula por seguridad
                int pos = alfabeto.IndexOf(c);
                posiciones[i, j] = pos; // -1 si no se encuentra
            }
        }

        return posiciones;
    }
    public string ConvertirMatrizAtexto(int[,] matriz, string alfabeto)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);
        string resultado = "";

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                int indice = matriz[i, j];
                if (indice >= 0 && indice < alfabeto.Length)
                {
                    resultado += alfabeto[indice];
                }
                else
                {
                    resultado += '?'; // carácter de relleno si índice es inválido
                }
            }
        }

        return resultado;
    }
    public string ConvertirMatrizAtexto(int[,] matriz)
    {
        string alfabeto = this.alfabeto;
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);
        string resultado = "";

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                int indice = matriz[i, j];
                if (indice >= 0 && indice < alfabeto.Length)
                {
                    resultado += alfabeto[indice];
                }
                else
                {
                    resultado += '?'; // carácter de relleno si índice es inválido
                }
            }
        }
        return resultado;
    }
    public string cifrar()
    {
        return ConvertirMatrizAtexto(AplicarModulo(MultiplicarMatrices()));
    }
    public string cifrar(string texto, int[,] clave, string alfabeto)
    {
        char[,] Mtexto = LlenarMatriz(texto,clave.GetLength(0));
        int[,] Mtextoint = ObtenerPosicionesEnAlfabeto(Mtexto, alfabeto);
        int[,] MtextoD = MultiplicarMatrices(Mtextoint,clave );
        return ConvertirMatrizAtexto(AplicarModulo(MtextoD));
    }
    public string cifrar(string texto)
    {
        char[,] Mtexto = LlenarMatriz(texto,this.clave_matriz.GetLength(0));
        int[,] Mtextoint = ObtenerPosicionesEnAlfabeto(Mtexto, alfabeto);
        int[,] MtextoD = MultiplicarMatrices(Mtextoint, this.clave_matriz);
        return ConvertirMatrizAtexto(AplicarModulo(MtextoD));
    }
    public string decifrar(int[,] Mclave,String Alfabeto,String TextoCifrado){
        char[,] Mtexto = LlenarMatriz(TextoCifrado, Mclave.GetLength(0));
        int[,] Mtextoint = ObtenerPosicionesEnAlfabeto(Mtexto,Alfabeto);
        int[,] inversaClave = math.InversaModular(Mclave, Alfabeto.Length);
        int[,] MtextoD=MultiplicarMatrices(Mtextoint,inversaClave);   
        return ConvertirMatrizAtexto(AplicarModulo(MtextoD));
    }
    public string decifrar(String TextoCifrado)
    {
        char[,] Mtexto = LlenarMatriz(TextoCifrado, this.clave_matriz.GetLength(0));
        int[,] Mtextoint = ObtenerPosicionesEnAlfabeto(Mtexto, this.alfabeto);
        int[,] inversaClave = math.InversaModular(this.clave_matriz, this.alfabeto.Length);
        int[,] MtextoD = MultiplicarMatrices(Mtextoint, inversaClave);
        return ConvertirMatrizAtexto(AplicarModulo(MtextoD));
    }
}
