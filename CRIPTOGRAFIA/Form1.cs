

using Microsoft.VisualBasic;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace CRIPTOGRAFIA
{

    public partial class Form1 : Form
    {
        CifradoHill cifra1;
        CifradorPlayfair cifra2;
        CifradorAnagramacion cifra3;
        CifradorSustitucionPolialfabetica cifra4;
        CifradorAfín cifra5;
        int[,] Mclaveint;
        string texto;

        public Form1()
        {
            InitializeComponent();
            // cifra1 = new CifradoHill(int.Parse(txtTamaño.Text), txtAlfabeto.Text, txtOriginal.Text);
            string rutaArchivo = "clave.txt";
            string contenido = File.ReadAllText(rutaArchivo);

            // Mclaveint = math.GenerarMatrizClaveInvertible(int.Parse(txtTamaño.Text), txtAlfabeto.Text.Length);
            cifra1 = new CifradoHill(4, txtAlfabeto.Text, txtOriginal.Text);
            Mclaveint = cifra1.ObtenerPosicionesEnAlfabeto(cifra1.LlenarMatriz(contenido, (int)Math.Sqrt(contenido.Length)));
            cifra1.SetMclave(Mclaveint);
            texto = "";
            cifra2 = new CifradorPlayfair("HOLAMUND");
            cifra3 = new CifradorAnagramacion("FIGOL", true);
            cifra4 = new CifradorSustitucionPolialfabetica("FIGOLE");
            cifra5 = new CifradorAfín(5, 8);
        }




        private void button2_Click(object sender, EventArgs e)
        {
            cifra1.llenar_matriztexto();

            int[,] m = Mclaveint;

        }
        private void CargarDatos(DataGridView G, int[,] datos)
        {
            //CifradoHill Cifra = new CifradoHill(int.Parse(txtTamaño.Text), txtAlfabeto.Text);
            int[,] posiciones = datos;
            int filas = posiciones.GetLength(0);
            int columnas = posiciones.GetLength(1);
            // Configurar el DataGridView
            G.ColumnCount = filas;
            if (columnas <= 0)
            {
                G.RowCount = 1;
            }
            else
            {
                G.RowCount = filas;
            }
            if (filas <= 0)
            {
                G.ColumnCount = 1;
            }
            else
            {
                G.ColumnCount = columnas;
            }

            /*  for (int i = 0; i < columnas; i++)
              {
                  matriz.Columns[i].Width = 50; // opcional
              }*/
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    G.Rows[i].Cells[j].Value = posiciones[i, j].ToString();
                }
            }
        }
        private void abrirArchivoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.texto = AbrirArchivo();
            txtOriginal.Text = texto;

        }

        private void guardarEnArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuardarArchivo(txtResultado.Text);
        }
        private void GuardarArchivo(string contenido)
        {
            // 1. Crear y configurar el diálogo
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            saveFileDialog.Title = "Guardar archivo";
            saveFileDialog.DefaultExt = "txt";
            saveFileDialog.AddExtension = true;

            // 2. Mostrar el diálogo y verificar si el usuario hizo clic en "Guardar"
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // 3. Guardar el contenido en el archivo seleccionado
                    File.WriteAllText(saveFileDialog.FileName, contenido);

                    // 4. (Opcional) Mostrar confirmación
                    MessageBox.Show("Archivo guardado correctamente", "Éxito",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar: {ex.Message}", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private string AbrirArchivo()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt";
            string contenido = "";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaArchivo = openFileDialog.FileName;
                contenido = File.ReadAllText(rutaArchivo);

                // Usar el contenido como necesites

            }
            return contenido;
        }

        private void guardarClaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuardarArchivo(cifra1.ConvertirMatrizAtexto(Mclaveint));
        }

        private void abrirClaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string clave = AbrirArchivo();
            this.Mclaveint = cifra1.ObtenerPosicionesEnAlfabeto(cifra1.LlenarMatriz(clave, (int)Math.Sqrt(clave.Length)));
            cifra1.SetMclave(Mclaveint);

        }



        private void decifrarArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string respuesta = Interaction.InputBox(
                   "Ingrese un numero:",    // Mensaje
                    "Tamaño de matriz clave", // Título
                    "4",   // Valor predeterminado
    -1, -1);              // Posición (x,y). -1 para centrar

            if (!string.IsNullOrEmpty(respuesta))
            {
                MessageBox.Show($"Dato ingresado: {respuesta}");
            }
            else
            {
                MessageBox.Show("No se ingresó ningún dato");
            }
            if (int.TryParse(respuesta, out int numero))
            {
                Mclaveint = math.GenerarMatrizClaveInvertible(numero, cifra1.GetAlfabeto().Length);
                cifra1.SetMclave(Mclaveint);
            }
            else
            {
                Console.WriteLine("No es un número entero válido");
            }


        }

        private void actulzarLaClaveToolStripMenuItem_Click(object sender, EventArgs e)
        {




            // 2. Mostrar el diálogo y verificar si el usuario hizo clic en "Guardar"

            try
            {
                // 3. Guardar el contenido en el archivo seleccionado
                File.WriteAllText("clave.txt", cifra1.ConvertirMatrizAtexto(cifra1.GetMclave()));

                // 4. (Opcional) Mostrar confirmación
                MessageBox.Show("Archivo guardado correctamente", "Éxito",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cifrarArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuardarArchivo(cifra1.ConvertirMatrizAtexto(cifra1.GetMclave()));
        }

        private void ingresarClaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string respuesta = Interaction.InputBox(
          "Ingrese una clave:",    // Mensaje
           "clave", // Título
           "HOLAMUND",   // Valor predeterminado
-1, -1);              // Posición (x,y). -1 para centrar

            if (!string.IsNullOrEmpty(respuesta))
            {
                MessageBox.Show($"Dato ingresado: {respuesta}");
            }
            else
            {
                MessageBox.Show("No se ingresó ningún dato");
            }

        }


        private void cIFRARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtResultado.Text = cifra1.cifrar(txtOriginal.Text);
        }

        private void dECIFRARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtResultado.Text = cifra1.decifrar(txtOriginal.Text);
        }

        private void cIFRARToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            txtResultado.Text = cifra2.Cifrar(txtOriginal.Text);
        }

        private void dECIFRARToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            txtResultado.Text = cifra2.Descifrar(txtOriginal.Text);
        }

        private void cifrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            txtResultado.Text = cifra3.Cifrar(txtOriginal.Text);

        }

        private void decifrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            txtResultado.Text = cifra3.Descifrar(txtOriginal.Text);
        }

        private void cIFRARToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            txtResultado.Text = cifra4.Cifrar(txtOriginal.Text);
        }

        private void dECIFRARToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            txtResultado.Text = cifra4.Descifrar(txtOriginal.Text);
        }

        private void cIFRARToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            txtResultado.Text = cifra5.Cifrar(txtOriginal.Text);
        }

        private void dECIFRARToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            txtResultado.Text=cifra5.Descifrar(txtOriginal.Text);
        }
    }
}
