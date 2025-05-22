

using Microsoft.VisualBasic;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CRIPTOGRAFIA
{

    public partial class Criptografia : Form
    {
        CifradoHill cifraHill;
        CifradorPlayfair cifraPlayfair;
        CifradorAnagramacion cifraAnagramacion;
        CifradorSustitucionPolialfabetica cifraSustitucionPoli;
        CifradorAfín cifraAfin;
        CifradoDesplazamiento cifraDesplazamiento;
        CifradoTransposicionGrupos cifraTransposicionG;
        CifradoTransposicionSerie cifraTransposicionS;
        AtaqueKasiski AtaqueK;
        int[,] Mclaveint;
        string texto;

        public Criptografia()
        {
            InitializeComponent();
            // cifra1 = new CifradoHill(int.Parse(txtTamaño.Text), txtAlfabeto.Text, txtOriginal.Text);
            string rutaArchivo = "claveHill.txt";
            string contenido = File.ReadAllText(rutaArchivo);

            // Mclaveint = math.GenerarMatrizClaveInvertible(int.Parse(txtTamaño.Text), txtAlfabeto.Text.Length);
            cifraHill = new CifradoHill();
            Mclaveint = cifraHill.ObtenerPosicionesEnAlfabeto(cifraHill.LlenarMatriz(contenido, (int)Math.Sqrt(contenido.Length)));
            cifraHill.SetMclave(Mclaveint);
            texto = "";
            cifraPlayfair = new CifradorPlayfair("HOLAMUND");
            cifraAnagramacion = new CifradorAnagramacion("FIGOL", true);
            cifraSustitucionPoli = new CifradorSustitucionPolialfabetica("FIGOLE");
            cifraAfin = new CifradorAfín(5, 8);
            cifraDesplazamiento = new CifradoDesplazamiento();
            cifraTransposicionG = new CifradoTransposicionGrupos();
            cifraTransposicionS = new CifradoTransposicionSerie();
            AtaqueK = new AtaqueKasiski(txtOriginal.Text);
        }




        private void button2_Click(object sender, EventArgs e)
        {
            cifraHill.llenar_matriztexto();

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

        /// <summary>
        /// Cifrado de Transposición por Serie
        /// Muestra una ventana emergente para configurar tamaño de serie y clave.
        /// </summary>
        private void MostrarVentanaParametrosTransposicion()
        {
            Form formParametros = new Form();
            formParametros.Text = "Configurar Transposición por Serie";
            formParametros.Size = new Size(300, 150);
            formParametros.FormBorderStyle = FormBorderStyle.FixedDialog;
            formParametros.StartPosition = FormStartPosition.CenterParent;

            // Etiqueta y campo para la clave
            Label lblClave = new Label { Text = "Clave alfabética:", Left = 10, Top = 20, Width = 100 };
            TextBox txtClave = new TextBox
            {
                Text = cifraTransposicionS.Clave,
                Left = 120,
                Top = 20,
                Width = 100,
                MaxLength = 10 // Límite opcional para evitar claves muy largas
            };

            // Botón para aplicar
            Button btnAplicar = new Button { Text = "Aplicar", Left = 100, Top = 60, Width = 80 };
            btnAplicar.Click += (sender, e) =>
            {
                try
                {
                    cifraTransposicionS.Clave = txtClave.Text; // Actualiza clave y tamaño automáticamente
                    formParametros.Close();
                    MessageBox.Show($"Clave configurada: {cifraTransposicionS.Clave}\nTamaño de serie: {cifraTransposicionS.TamanoSerie}",
                                  "Éxito",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}\nEjemplo válido: 'CLAVE'",
                                  "Error",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Error);
                }
            };

            // Agregar controles al formulario
            formParametros.Controls.AddRange(new Control[] { lblClave, txtClave, btnAplicar });
            formParametros.ShowDialog();
        }
        private void guardarClaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuardarArchivo(cifraHill.ConvertirMatrizAtexto(Mclaveint));
        }

        private void abrirClaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string clave = AbrirArchivo();
            this.Mclaveint = cifraHill.ObtenerPosicionesEnAlfabeto(cifraHill.LlenarMatriz(clave, (int)Math.Sqrt(clave.Length)));
            cifraHill.SetMclave(Mclaveint);

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
                Mclaveint = math.GenerarMatrizClaveInvertible(numero, cifraHill.GetAlfabeto().Length);
                cifraHill.SetMclave(Mclaveint);
            }
            else
            {
                Console.WriteLine("No es un número entero válido");
            }
        }
        private void cAMBIARCLAVEToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            string datoa = Interaction.InputBox("ingrese un entero", "CAMBIAR CLAVE", "Valor por defecto");
            string datob = Interaction.InputBox("ingrese otro entero", "CAMBIAR CLAVE", "Valor por defecto");
            try { cifraAfin.Setclave(int.Parse(datoa), int.Parse(datob)); }
            catch (Exception ex)
            {
            }

        }
        private void mOSTRARCLAVEToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(cifraAfin.Getclave(), "Éxito",
                             MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void actulzarLaClaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // 3. Guardar el contenido en el archivo seleccionado
                File.WriteAllText("claveHill.txt", cifraHill.ConvertirMatrizAtexto(cifraHill.GetMclave()));

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
            GuardarArchivo(cifraHill.ConvertirMatrizAtexto(cifraHill.GetMclave()));
        }




        private void cAMBIARCLAVEToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            string nuevaClave = Interaction.InputBox(
                "Ingrese la nueva clave:",
                "Cambiar clave desplazamiento",
                cifraDesplazamiento.GetClave());

            if (!string.IsNullOrEmpty(nuevaClave))
            {
                cifraDesplazamiento.SetClave(nuevaClave);
                MessageBox.Show("Clave actualizada correctamente");
            }
        }


        private void cIFRARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtResultado.Text = cifraHill.cifrar(txtOriginal.Text);
        }

        private void dECIFRARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtResultado.Text = cifraHill.decifrar(txtOriginal.Text);
        }

        private void cIFRARToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            txtResultado.Text = cifraPlayfair.Cifrar(txtOriginal.Text);
        }

        private void dECIFRARToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            txtResultado.Text = cifraPlayfair.Descifrar(txtOriginal.Text);
        }

        private void cifrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            txtResultado.Text = cifraAnagramacion.Cifrar(txtOriginal.Text);

        }

        private void decifrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            txtResultado.Text = cifraAnagramacion.Descifrar(txtOriginal.Text);
        }

        private void cIFRARToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            txtResultado.Text = cifraSustitucionPoli.Cifrar(txtOriginal.Text);
        }

        private void dECIFRARToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            txtResultado.Text = cifraSustitucionPoli.Descifrar(txtOriginal.Text);
        }

        private void cIFRARToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            txtResultado.Text = cifraAfin.Cifrar(txtOriginal.Text);
        }

        private void dECIFRARToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            txtResultado.Text = cifraAfin.Descifrar(txtOriginal.Text);
        }

        private void cifradoDesplazamientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Crea un submenú si es necesario
            var menu = sender as ToolStripMenuItem;
            if (menu != null)
            {
                // Implementa lógica para mostrar opciones específicas si es necesario
            }
        }



        private void cIFRARToolStripMenuItem5_Click_1(object sender, EventArgs e)
        {
            txtResultado.Text = cifraDesplazamiento.Cifrar(txtOriginal.Text);
        }

        private void dECIFRARToolStripMenuItem5_Click_1(object sender, EventArgs e)
        {
            txtResultado.Text = cifraDesplazamiento.Descifrar(txtOriginal.Text);
        }

        private void cLAVEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lblOriginal_Click(object sender, EventArgs e)
        {

        }

        private void cIFRARToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            txtResultado.Text = cifraTransposicionG.Cifrar(txtOriginal.Text);
        }

        private void dESCIFRARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtResultado.Text = cifraTransposicionG.Descifrar(txtOriginal.Text);
        }

        private void pARAMETROSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new Form())
            {
                form.Text = "Configurar Transposición por Grupos";
                var lblTamano = new Label { Text = "Tamaño del grupo:", Left = 10, Top = 20 };
                var numTamano = new NumericUpDown { Minimum = 2, Maximum = 10, Value = 3, Left = 150, Top = 20 };
                var lblPermutacion = new Label { Text = "Permutación:", Left = 10, Top = 50 };
                var comboPermutacion = new ComboBox { Items = { "Invertir", "Intercalar", "Rotar" }, Left = 150, Top = 50 };
                var btnAceptar = new Button { Text = "Aceptar", Left = 100, Top = 80 };

                btnAceptar.Click += (s, ev) =>
                {
                    cifraTransposicionG.TamanoGrupo = (int)numTamano.Value;
                    cifraTransposicionG.TipoPermutacion = comboPermutacion.SelectedItem.ToString();
                    form.Close();
                };

                form.Controls.AddRange(new Control[] { lblTamano, numTamano, lblPermutacion, comboPermutacion, btnAceptar });
                form.ShowDialog();
            }
        }
        // Cifrar Cifra trans serie
        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                txtResultado.Text = cifraTransposicionS.Cifrar(txtOriginal.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cifrar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Descifrar Cifra trans serie
        private void decifrarToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            try
            {
                txtResultado.Text = cifraTransposicionS.Descifrar(txtOriginal.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al descifrar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void parametrosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MostrarVentanaParametrosTransposicion();
        }

        private void generarNuevaClaveToolStripMenuItem_Click(object sender, EventArgs e)
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
                Mclaveint = math.GenerarMatrizClaveInvertible(numero, cifraHill.GetAlfabeto().Length);
                cifraHill.SetMclave(Mclaveint);
            }
            else
            {
                Console.WriteLine("No es un número entero válido");
            }
        }

        private void exportarClaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuardarArchivo(cifraHill.ConvertirMatrizAtexto(cifraHill.GetMclave()));
        }

        private void actualizarLaClaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // 3. Guardar el contenido en el archivo seleccionado
                File.WriteAllText("claveHill.txt", cifraHill.ConvertirMatrizAtexto(cifraHill.GetMclave()));

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

        private void nuevaClaveToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void cambiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string nuevaClave = Interaction.InputBox(
           "Ingrese la nueva clave:",
           "Cambiar clave desplazamiento",
           cifraDesplazamiento.GetClave());

            if (!string.IsNullOrEmpty(nuevaClave))
            {
                cifraDesplazamiento.SetClave(nuevaClave);
                MessageBox.Show("Clave actualizada correctamente");
            }
        }


        private void cambiarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            string datoa = Interaction.InputBox("ingrese un entero", "CAMBIAR CLAVE", "Valor por defecto");
            string datob = Interaction.InputBox("ingrese otro entero", "CAMBIAR CLAVE", "Valor por defecto");
            try { cifraAfin.Setclave(int.Parse(datoa), int.Parse(datob)); }
            catch (Exception ex)
            {
            }
        }

        private void mostrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cifraAfin.Getclave(), "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cifradoAfinToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cifraAfin.Getclave(), "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mostrarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cifraPlayfair.ObtenerMatrizClaveComoCadena(), "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mostrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cifraSustitucionPoli.GetClave(), "Éxito",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cambiarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string nuevaClave = Interaction.InputBox(
     "Ingrese la nueva clave:",
     "Cambiar clave desplazamiento",
      cifraSustitucionPoli.GetClave());
            if (!string.IsNullOrEmpty(nuevaClave))
            {
                cifraSustitucionPoli.SetClave(nuevaClave);
                MessageBox.Show("Clave actualizada correctamente");
            }
        }

        private void cambiarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            string nuevaClave = Interaction.InputBox(
   "Ingrese la nueva clave:",
   "Cambiar clave desplazamiento",
   cifraDesplazamiento.GetClave());

            if (!string.IsNullOrEmpty(nuevaClave))
            {
                cifraDesplazamiento.SetClave(nuevaClave);
                MessageBox.Show("Clave actualizada correctamente");
            }
        }

        private void mostrarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cifraDesplazamiento.GetClave(), "Éxito",
                         MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void decifrarToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            AtaqueK.SetTexto(txtOriginal.Text);
            var (clave, textoDescifrado) = AtaqueK.DescifrarAutomatico("es");
            txtResultado.Text = clave + "\n" + textoDescifrado;
        }

        private void decifradoConLongitudToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AtaqueK.SetTexto(txtOriginal.Text);
            string nuevaClave = Interaction.InputBox(
           "Ingrese tamaño de clave conocida:"
           )
           ;

            if (!string.IsNullOrEmpty(nuevaClave))
            {
                cifraDesplazamiento.SetClave(nuevaClave);
                MessageBox.Show("ok");
            }
            var (clave, textoDescifrado) = AtaqueK.DescifrarConLongitud(int.Parse(nuevaClave), "es");
            txtResultado.Text = clave + "\n" + textoDescifrado;
        }

        private void lblCifrado_Click(object sender, EventArgs e)
        {

        }
    }
}
