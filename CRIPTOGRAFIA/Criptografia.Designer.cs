namespace CRIPTOGRAFIA
{
    partial class Criptografia
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Criptografia));
            txtOriginal = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            menuStrip1 = new MenuStrip();
            abrirArchivoToolStripMenuItem = new ToolStripMenuItem();
            abrirArchivoToolStripMenuItem1 = new ToolStripMenuItem();
            guardarEnArchivoToolStripMenuItem = new ToolStripMenuItem();
            cifradoDesplazamientoToolStripMenuItem = new ToolStripMenuItem();
            cIFRARToolStripMenuItem5 = new ToolStripMenuItem();
            dECIFRARToolStripMenuItem5 = new ToolStripMenuItem();
            cLAVEToolStripMenuItem = new ToolStripMenuItem();
            cambiarToolStripMenuItem3 = new ToolStripMenuItem();
            mostrarToolStripMenuItem4 = new ToolStripMenuItem();
            cifradoToolStripMenuItem = new ToolStripMenuItem();
            cIFRARToolStripMenuItem6 = new ToolStripMenuItem();
            dESCIFRARToolStripMenuItem = new ToolStripMenuItem();
            pARAMETROSToolStripMenuItem = new ToolStripMenuItem();
            cifradoTransposicionSerieToolStripMenuItem = new ToolStripMenuItem();
            cToolStripMenuItem = new ToolStripMenuItem();
            decifrarToolStripMenuItem6 = new ToolStripMenuItem();
            parametrosToolStripMenuItem1 = new ToolStripMenuItem();
            cifradoAfinToolStripMenuItem = new ToolStripMenuItem();
            cIFRARToolStripMenuItem4 = new ToolStripMenuItem();
            dECIFRARToolStripMenuItem4 = new ToolStripMenuItem();
            claveToolStripMenuItem4 = new ToolStripMenuItem();
            cambiarToolStripMenuItem2 = new ToolStripMenuItem();
            mostrarToolStripMenuItem2 = new ToolStripMenuItem();
            cifradoSustitucionPolialfabeticaToolStripMenuItem = new ToolStripMenuItem();
            cIFRARToolStripMenuItem3 = new ToolStripMenuItem();
            dECIFRARToolStripMenuItem3 = new ToolStripMenuItem();
            claveToolStripMenuItem3 = new ToolStripMenuItem();
            cambiarToolStripMenuItem1 = new ToolStripMenuItem();
            mostrarToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            cifrarToolStripMenuItem2 = new ToolStripMenuItem();
            decifrarToolStripMenuItem2 = new ToolStripMenuItem();
            claveToolStripMenuItem2 = new ToolStripMenuItem();
            cambiarToolStripMenuItem = new ToolStripMenuItem();
            mostrarToolStripMenuItem = new ToolStripMenuItem();
            cIfradoPlayFairToolStripMenuItem = new ToolStripMenuItem();
            cIFRARToolStripMenuItem1 = new ToolStripMenuItem();
            dECIFRARToolStripMenuItem1 = new ToolStripMenuItem();
            ingresarClaveToolStripMenuItem = new ToolStripMenuItem();
            nuevaClaveToolStripMenuItem = new ToolStripMenuItem();
            mostrarToolStripMenuItem3 = new ToolStripMenuItem();
            cRIPTOToolStripMenuItem = new ToolStripMenuItem();
            cIFRARToolStripMenuItem = new ToolStripMenuItem();
            dECIFRARToolStripMenuItem = new ToolStripMenuItem();
            claveToolStripMenuItem1 = new ToolStripMenuItem();
            generarNuevaClaveToolStripMenuItem = new ToolStripMenuItem();
            exportarClaveToolStripMenuItem = new ToolStripMenuItem();
            actualizarLaClaveToolStripMenuItem = new ToolStripMenuItem();
            lbl1 = new Label();
            txtResultado = new TextBox();
            lblCifrado = new Label();
            lblOriginal = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtOriginal
            // 
            txtOriginal.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtOriginal.Location = new Point(12, 79);
            txtOriginal.Multiline = true;
            txtOriginal.Name = "txtOriginal";
            txtOriginal.ScrollBars = ScrollBars.Vertical;
            txtOriginal.Size = new Size(1263, 253);
            txtOriginal.TabIndex = 3;
            txtOriginal.Text = "HOLA MUNDO";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { abrirArchivoToolStripMenuItem, cifradoDesplazamientoToolStripMenuItem, cifradoToolStripMenuItem, cifradoTransposicionSerieToolStripMenuItem, cifradoAfinToolStripMenuItem, cifradoSustitucionPolialfabeticaToolStripMenuItem, toolStripMenuItem1, cIfradoPlayFairToolStripMenuItem, cRIPTOToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1297, 24);
            menuStrip1.TabIndex = 14;
            menuStrip1.Text = "menuStrip1";
            // 
            // abrirArchivoToolStripMenuItem
            // 
            abrirArchivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { abrirArchivoToolStripMenuItem1, guardarEnArchivoToolStripMenuItem });
            abrirArchivoToolStripMenuItem.Name = "abrirArchivoToolStripMenuItem";
            abrirArchivoToolStripMenuItem.Size = new Size(45, 20);
            abrirArchivoToolStripMenuItem.Text = "Abrir";
            // 
            // abrirArchivoToolStripMenuItem1
            // 
            abrirArchivoToolStripMenuItem1.Name = "abrirArchivoToolStripMenuItem1";
            abrirArchivoToolStripMenuItem1.Size = new Size(158, 22);
            abrirArchivoToolStripMenuItem1.Text = "Abrir archivo";
            abrirArchivoToolStripMenuItem1.Click += abrirArchivoToolStripMenuItem1_Click;
            // 
            // guardarEnArchivoToolStripMenuItem
            // 
            guardarEnArchivoToolStripMenuItem.Name = "guardarEnArchivoToolStripMenuItem";
            guardarEnArchivoToolStripMenuItem.Size = new Size(158, 22);
            guardarEnArchivoToolStripMenuItem.Text = "Guardar archivo";
            guardarEnArchivoToolStripMenuItem.Click += guardarEnArchivoToolStripMenuItem_Click;
            // 
            // cifradoDesplazamientoToolStripMenuItem
            // 
            cifradoDesplazamientoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cIFRARToolStripMenuItem5, dECIFRARToolStripMenuItem5, cLAVEToolStripMenuItem });
            cifradoDesplazamientoToolStripMenuItem.Name = "cifradoDesplazamientoToolStripMenuItem";
            cifradoDesplazamientoToolStripMenuItem.Size = new Size(145, 20);
            cifradoDesplazamientoToolStripMenuItem.Text = "Cifrado Desplazamiento";
            cifradoDesplazamientoToolStripMenuItem.Click += cifradoDesplazamientoToolStripMenuItem_Click;
            // 
            // cIFRARToolStripMenuItem5
            // 
            cIFRARToolStripMenuItem5.Name = "cIFRARToolStripMenuItem5";
            cIFRARToolStripMenuItem5.Size = new Size(115, 22);
            cIFRARToolStripMenuItem5.Text = "Cifrar";
            cIFRARToolStripMenuItem5.Click += cIFRARToolStripMenuItem5_Click_1;
            // 
            // dECIFRARToolStripMenuItem5
            // 
            dECIFRARToolStripMenuItem5.Name = "dECIFRARToolStripMenuItem5";
            dECIFRARToolStripMenuItem5.Size = new Size(115, 22);
            dECIFRARToolStripMenuItem5.Text = "Decifrar";
            dECIFRARToolStripMenuItem5.Click += dECIFRARToolStripMenuItem5_Click_1;
            // 
            // cLAVEToolStripMenuItem
            // 
            cLAVEToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cambiarToolStripMenuItem3, mostrarToolStripMenuItem4 });
            cLAVEToolStripMenuItem.Name = "cLAVEToolStripMenuItem";
            cLAVEToolStripMenuItem.Size = new Size(115, 22);
            cLAVEToolStripMenuItem.Text = "Clave";
            cLAVEToolStripMenuItem.Click += cLAVEToolStripMenuItem_Click;
            // 
            // cambiarToolStripMenuItem3
            // 
            cambiarToolStripMenuItem3.Name = "cambiarToolStripMenuItem3";
            cambiarToolStripMenuItem3.Size = new Size(119, 22);
            cambiarToolStripMenuItem3.Text = "Cambiar";
            cambiarToolStripMenuItem3.Click += cambiarToolStripMenuItem3_Click;
            // 
            // mostrarToolStripMenuItem4
            // 
            mostrarToolStripMenuItem4.Name = "mostrarToolStripMenuItem4";
            mostrarToolStripMenuItem4.Size = new Size(119, 22);
            mostrarToolStripMenuItem4.Text = "Mostrar";
            mostrarToolStripMenuItem4.Click += mostrarToolStripMenuItem4_Click;
            // 
            // cifradoToolStripMenuItem
            // 
            cifradoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cIFRARToolStripMenuItem6, dESCIFRARToolStripMenuItem, pARAMETROSToolStripMenuItem });
            cifradoToolStripMenuItem.Name = "cifradoToolStripMenuItem";
            cifradoToolStripMenuItem.Size = new Size(174, 20);
            cifradoToolStripMenuItem.Text = "Cifrado Transposicion Grupos";
            // 
            // cIFRARToolStripMenuItem6
            // 
            cIFRARToolStripMenuItem6.Name = "cIFRARToolStripMenuItem6";
            cIFRARToolStripMenuItem6.Size = new Size(134, 22);
            cIFRARToolStripMenuItem6.Text = "Cifrar";
            cIFRARToolStripMenuItem6.Click += cIFRARToolStripMenuItem6_Click;
            // 
            // dESCIFRARToolStripMenuItem
            // 
            dESCIFRARToolStripMenuItem.Name = "dESCIFRARToolStripMenuItem";
            dESCIFRARToolStripMenuItem.Size = new Size(134, 22);
            dESCIFRARToolStripMenuItem.Text = "Decifrar";
            dESCIFRARToolStripMenuItem.Click += dESCIFRARToolStripMenuItem_Click;
            // 
            // pARAMETROSToolStripMenuItem
            // 
            pARAMETROSToolStripMenuItem.Name = "pARAMETROSToolStripMenuItem";
            pARAMETROSToolStripMenuItem.Size = new Size(134, 22);
            pARAMETROSToolStripMenuItem.Text = "Parametros";
            pARAMETROSToolStripMenuItem.Click += pARAMETROSToolStripMenuItem_Click;
            // 
            // cifradoTransposicionSerieToolStripMenuItem
            // 
            cifradoTransposicionSerieToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cToolStripMenuItem, decifrarToolStripMenuItem6, parametrosToolStripMenuItem1 });
            cifradoTransposicionSerieToolStripMenuItem.Name = "cifradoTransposicionSerieToolStripMenuItem";
            cifradoTransposicionSerieToolStripMenuItem.Size = new Size(161, 20);
            cifradoTransposicionSerieToolStripMenuItem.Text = "Cifrado Transposicion Serie";
            // 
            // cToolStripMenuItem
            // 
            cToolStripMenuItem.Name = "cToolStripMenuItem";
            cToolStripMenuItem.Size = new Size(115, 22);
            cToolStripMenuItem.Text = "Cifrar";
            cToolStripMenuItem.Click += cToolStripMenuItem_Click;
            // 
            // decifrarToolStripMenuItem6
            // 
            decifrarToolStripMenuItem6.Name = "decifrarToolStripMenuItem6";
            decifrarToolStripMenuItem6.Size = new Size(115, 22);
            decifrarToolStripMenuItem6.Text = "Decifrar";
            decifrarToolStripMenuItem6.Click += decifrarToolStripMenuItem6_Click;
            // 
            // parametrosToolStripMenuItem1
            // 
            parametrosToolStripMenuItem1.Name = "parametrosToolStripMenuItem1";
            parametrosToolStripMenuItem1.Size = new Size(115, 22);
            parametrosToolStripMenuItem1.Text = "CLAVE";
            parametrosToolStripMenuItem1.Click += parametrosToolStripMenuItem1_Click;
            // 
            // cifradoAfinToolStripMenuItem
            // 
            cifradoAfinToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cIFRARToolStripMenuItem4, dECIFRARToolStripMenuItem4, claveToolStripMenuItem4 });
            cifradoAfinToolStripMenuItem.Name = "cifradoAfinToolStripMenuItem";
            cifradoAfinToolStripMenuItem.Size = new Size(81, 20);
            cifradoAfinToolStripMenuItem.Text = "Cifrado afin";
            cifradoAfinToolStripMenuItem.Click += cifradoAfinToolStripMenuItem_Click;
            // 
            // cIFRARToolStripMenuItem4
            // 
            cIFRARToolStripMenuItem4.Name = "cIFRARToolStripMenuItem4";
            cIFRARToolStripMenuItem4.Size = new Size(115, 22);
            cIFRARToolStripMenuItem4.Text = "Cifrar";
            cIFRARToolStripMenuItem4.Click += cIFRARToolStripMenuItem4_Click;
            // 
            // dECIFRARToolStripMenuItem4
            // 
            dECIFRARToolStripMenuItem4.Name = "dECIFRARToolStripMenuItem4";
            dECIFRARToolStripMenuItem4.Size = new Size(115, 22);
            dECIFRARToolStripMenuItem4.Text = "Decifrar";
            dECIFRARToolStripMenuItem4.Click += dECIFRARToolStripMenuItem4_Click;
            // 
            // claveToolStripMenuItem4
            // 
            claveToolStripMenuItem4.DropDownItems.AddRange(new ToolStripItem[] { cambiarToolStripMenuItem2, mostrarToolStripMenuItem2 });
            claveToolStripMenuItem4.Name = "claveToolStripMenuItem4";
            claveToolStripMenuItem4.Size = new Size(115, 22);
            claveToolStripMenuItem4.Text = "Clave";
            // 
            // cambiarToolStripMenuItem2
            // 
            cambiarToolStripMenuItem2.Name = "cambiarToolStripMenuItem2";
            cambiarToolStripMenuItem2.Size = new Size(119, 22);
            cambiarToolStripMenuItem2.Text = "Cambiar";
            cambiarToolStripMenuItem2.Click += cambiarToolStripMenuItem2_Click;
            // 
            // mostrarToolStripMenuItem2
            // 
            mostrarToolStripMenuItem2.Name = "mostrarToolStripMenuItem2";
            mostrarToolStripMenuItem2.Size = new Size(119, 22);
            mostrarToolStripMenuItem2.Text = "Mostrar";
            mostrarToolStripMenuItem2.Click += mostrarToolStripMenuItem2_Click;
            // 
            // cifradoSustitucionPolialfabeticaToolStripMenuItem
            // 
            cifradoSustitucionPolialfabeticaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cIFRARToolStripMenuItem3, dECIFRARToolStripMenuItem3, claveToolStripMenuItem3 });
            cifradoSustitucionPolialfabeticaToolStripMenuItem.Name = "cifradoSustitucionPolialfabeticaToolStripMenuItem";
            cifradoSustitucionPolialfabeticaToolStripMenuItem.Size = new Size(193, 20);
            cifradoSustitucionPolialfabeticaToolStripMenuItem.Text = "Cifrado sustitucion polialfabetica";
            // 
            // cIFRARToolStripMenuItem3
            // 
            cIFRARToolStripMenuItem3.Name = "cIFRARToolStripMenuItem3";
            cIFRARToolStripMenuItem3.Size = new Size(115, 22);
            cIFRARToolStripMenuItem3.Text = "Cifrar";
            cIFRARToolStripMenuItem3.Click += cIFRARToolStripMenuItem3_Click;
            // 
            // dECIFRARToolStripMenuItem3
            // 
            dECIFRARToolStripMenuItem3.Name = "dECIFRARToolStripMenuItem3";
            dECIFRARToolStripMenuItem3.Size = new Size(115, 22);
            dECIFRARToolStripMenuItem3.Text = "Decifrar";
            dECIFRARToolStripMenuItem3.Click += dECIFRARToolStripMenuItem3_Click;
            // 
            // claveToolStripMenuItem3
            // 
            claveToolStripMenuItem3.DropDownItems.AddRange(new ToolStripItem[] { cambiarToolStripMenuItem1, mostrarToolStripMenuItem1 });
            claveToolStripMenuItem3.Name = "claveToolStripMenuItem3";
            claveToolStripMenuItem3.Size = new Size(115, 22);
            claveToolStripMenuItem3.Text = "Clave";
            // 
            // cambiarToolStripMenuItem1
            // 
            cambiarToolStripMenuItem1.Name = "cambiarToolStripMenuItem1";
            cambiarToolStripMenuItem1.Size = new Size(119, 22);
            cambiarToolStripMenuItem1.Text = "Cambiar";
            cambiarToolStripMenuItem1.Click += cambiarToolStripMenuItem1_Click;
            // 
            // mostrarToolStripMenuItem1
            // 
            mostrarToolStripMenuItem1.Name = "mostrarToolStripMenuItem1";
            mostrarToolStripMenuItem1.Size = new Size(119, 22);
            mostrarToolStripMenuItem1.Text = "Mostrar";
            mostrarToolStripMenuItem1.Click += mostrarToolStripMenuItem1_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { cifrarToolStripMenuItem2, decifrarToolStripMenuItem2, claveToolStripMenuItem2 });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(158, 20);
            toolStripMenuItem1.Text = "Cifrado por anagramacion";
            // 
            // cifrarToolStripMenuItem2
            // 
            cifrarToolStripMenuItem2.Name = "cifrarToolStripMenuItem2";
            cifrarToolStripMenuItem2.Size = new Size(115, 22);
            cifrarToolStripMenuItem2.Text = "Cifrar";
            cifrarToolStripMenuItem2.Click += cifrarToolStripMenuItem2_Click;
            // 
            // decifrarToolStripMenuItem2
            // 
            decifrarToolStripMenuItem2.Name = "decifrarToolStripMenuItem2";
            decifrarToolStripMenuItem2.Size = new Size(115, 22);
            decifrarToolStripMenuItem2.Text = "Decifrar";
            decifrarToolStripMenuItem2.Click += decifrarToolStripMenuItem2_Click;
            // 
            // claveToolStripMenuItem2
            // 
            claveToolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { cambiarToolStripMenuItem, mostrarToolStripMenuItem });
            claveToolStripMenuItem2.Name = "claveToolStripMenuItem2";
            claveToolStripMenuItem2.Size = new Size(115, 22);
            claveToolStripMenuItem2.Text = "Clave";
            // 
            // cambiarToolStripMenuItem
            // 
            cambiarToolStripMenuItem.Name = "cambiarToolStripMenuItem";
            cambiarToolStripMenuItem.Size = new Size(119, 22);
            cambiarToolStripMenuItem.Text = "Cambiar";
            cambiarToolStripMenuItem.Click += cambiarToolStripMenuItem_Click;
            // 
            // mostrarToolStripMenuItem
            // 
            mostrarToolStripMenuItem.Name = "mostrarToolStripMenuItem";
            mostrarToolStripMenuItem.Size = new Size(119, 22);
            mostrarToolStripMenuItem.Text = "Mostrar";
            mostrarToolStripMenuItem.Click += mostrarToolStripMenuItem_Click;
            // 
            // cIfradoPlayFairToolStripMenuItem
            // 
            cIfradoPlayFairToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cIFRARToolStripMenuItem1, dECIFRARToolStripMenuItem1, ingresarClaveToolStripMenuItem });
            cIfradoPlayFairToolStripMenuItem.Name = "cIfradoPlayFairToolStripMenuItem";
            cIfradoPlayFairToolStripMenuItem.Size = new Size(102, 20);
            cIfradoPlayFairToolStripMenuItem.Text = "CIfrado PlayFair";
            // 
            // cIFRARToolStripMenuItem1
            // 
            cIFRARToolStripMenuItem1.Name = "cIFRARToolStripMenuItem1";
            cIFRARToolStripMenuItem1.Size = new Size(115, 22);
            cIFRARToolStripMenuItem1.Text = "Cifrar";
            cIFRARToolStripMenuItem1.Click += cIFRARToolStripMenuItem1_Click;
            // 
            // dECIFRARToolStripMenuItem1
            // 
            dECIFRARToolStripMenuItem1.Name = "dECIFRARToolStripMenuItem1";
            dECIFRARToolStripMenuItem1.Size = new Size(115, 22);
            dECIFRARToolStripMenuItem1.Text = "Decifrar";
            dECIFRARToolStripMenuItem1.Click += dECIFRARToolStripMenuItem1_Click;
            // 
            // ingresarClaveToolStripMenuItem
            // 
            ingresarClaveToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevaClaveToolStripMenuItem, mostrarToolStripMenuItem3 });
            ingresarClaveToolStripMenuItem.Name = "ingresarClaveToolStripMenuItem";
            ingresarClaveToolStripMenuItem.Size = new Size(115, 22);
            ingresarClaveToolStripMenuItem.Text = "Clave";
            // 
            // nuevaClaveToolStripMenuItem
            // 
            nuevaClaveToolStripMenuItem.Name = "nuevaClaveToolStripMenuItem";
            nuevaClaveToolStripMenuItem.Size = new Size(138, 22);
            nuevaClaveToolStripMenuItem.Text = "Nueva clave";
            nuevaClaveToolStripMenuItem.Click += nuevaClaveToolStripMenuItem_Click;
            // 
            // mostrarToolStripMenuItem3
            // 
            mostrarToolStripMenuItem3.Name = "mostrarToolStripMenuItem3";
            mostrarToolStripMenuItem3.Size = new Size(138, 22);
            mostrarToolStripMenuItem3.Text = "Mostrar";
            mostrarToolStripMenuItem3.Click += mostrarToolStripMenuItem3_Click;
            // 
            // cRIPTOToolStripMenuItem
            // 
            cRIPTOToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cIFRARToolStripMenuItem, dECIFRARToolStripMenuItem, claveToolStripMenuItem1 });
            cRIPTOToolStripMenuItem.Name = "cRIPTOToolStripMenuItem";
            cRIPTOToolStripMenuItem.Size = new Size(79, 20);
            cRIPTOToolStripMenuItem.Text = "Cifrado Hill";
            // 
            // cIFRARToolStripMenuItem
            // 
            cIFRARToolStripMenuItem.Name = "cIFRARToolStripMenuItem";
            cIFRARToolStripMenuItem.Size = new Size(115, 22);
            cIFRARToolStripMenuItem.Text = "Cifrar";
            cIFRARToolStripMenuItem.Click += cIFRARToolStripMenuItem_Click;
            // 
            // dECIFRARToolStripMenuItem
            // 
            dECIFRARToolStripMenuItem.Name = "dECIFRARToolStripMenuItem";
            dECIFRARToolStripMenuItem.Size = new Size(115, 22);
            dECIFRARToolStripMenuItem.Text = "Decifrar";
            dECIFRARToolStripMenuItem.Click += dECIFRARToolStripMenuItem_Click;
            // 
            // claveToolStripMenuItem1
            // 
            claveToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { generarNuevaClaveToolStripMenuItem, exportarClaveToolStripMenuItem, actualizarLaClaveToolStripMenuItem });
            claveToolStripMenuItem1.Name = "claveToolStripMenuItem1";
            claveToolStripMenuItem1.Size = new Size(115, 22);
            claveToolStripMenuItem1.Text = "Clave";
            // 
            // generarNuevaClaveToolStripMenuItem
            // 
            generarNuevaClaveToolStripMenuItem.Name = "generarNuevaClaveToolStripMenuItem";
            generarNuevaClaveToolStripMenuItem.Size = new Size(180, 22);
            generarNuevaClaveToolStripMenuItem.Text = "Generar nueva clave";
            generarNuevaClaveToolStripMenuItem.Click += generarNuevaClaveToolStripMenuItem_Click;
            // 
            // exportarClaveToolStripMenuItem
            // 
            exportarClaveToolStripMenuItem.Name = "exportarClaveToolStripMenuItem";
            exportarClaveToolStripMenuItem.Size = new Size(180, 22);
            exportarClaveToolStripMenuItem.Text = "Exportar Clave";
            exportarClaveToolStripMenuItem.Click += exportarClaveToolStripMenuItem_Click;
            // 
            // actualizarLaClaveToolStripMenuItem
            // 
            actualizarLaClaveToolStripMenuItem.Name = "actualizarLaClaveToolStripMenuItem";
            actualizarLaClaveToolStripMenuItem.Size = new Size(180, 22);
            actualizarLaClaveToolStripMenuItem.Text = "Actualizar la clave";
            actualizarLaClaveToolStripMenuItem.Click += actualizarLaClaveToolStripMenuItem_Click;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(200, 32);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(0, 15);
            lbl1.TabIndex = 15;
            // 
            // txtResultado
            // 
            txtResultado.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtResultado.Location = new Point(12, 370);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.ScrollBars = ScrollBars.Vertical;
            txtResultado.Size = new Size(1263, 280);
            txtResultado.TabIndex = 16;
            // 
            // lblCifrado
            // 
            lblCifrado.AllowDrop = true;
            lblCifrado.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblCifrado.AutoSize = true;
            lblCifrado.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCifrado.ForeColor = Color.White;
            lblCifrado.Location = new Point(12, 348);
            lblCifrado.Name = "lblCifrado";
            lblCifrado.Size = new Size(202, 19);
            lblCifrado.TabIndex = 17;
            lblCifrado.Text = "TEXTO CIFRADO/DECIFRADO:";
            lblCifrado.Click += lblCifrado_Click;
            // 
            // lblOriginal
            // 
            lblOriginal.AllowDrop = true;
            lblOriginal.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblOriginal.AutoSize = true;
            lblOriginal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblOriginal.ForeColor = Color.White;
            lblOriginal.Location = new Point(12, 57);
            lblOriginal.Name = "lblOriginal";
            lblOriginal.Size = new Size(125, 19);
            lblOriginal.TabIndex = 18;
            lblOriginal.Text = "TEXTO ORIGINAL:";
            lblOriginal.Click += lblOriginal_Click;
            // 
            // Criptografia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1297, 679);
            Controls.Add(lblOriginal);
            Controls.Add(lblCifrado);
            Controls.Add(txtResultado);
            Controls.Add(lbl1);
            Controls.Add(txtOriginal);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Criptografia";
            Text = "CRIPTOGRAFIA Y SEGURIDAD";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtOriginal;
        private Button button1;
        private Button btnMostrar;
        private OpenFileDialog openFileDialog1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem abrirArchivoToolStripMenuItem;
        private ToolStripMenuItem abrirArchivoToolStripMenuItem1;
        private ToolStripMenuItem guardarEnArchivoToolStripMenuItem;
        private Label lbl1;
        private ToolStripMenuItem cRIPTOToolStripMenuItem;
        private TextBox txtResultado;
        private ToolStripMenuItem cIfradoPlayFairToolStripMenuItem;
        private ToolStripMenuItem ingresarClaveToolStripMenuItem;
        private ToolStripMenuItem cIFRARToolStripMenuItem;
        private ToolStripMenuItem dECIFRARToolStripMenuItem;
        private ToolStripMenuItem cIFRARToolStripMenuItem1;
        private ToolStripMenuItem dECIFRARToolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem cifrarToolStripMenuItem2;
        private ToolStripMenuItem decifrarToolStripMenuItem2;
        private ToolStripMenuItem cifradoSustitucionPolialfabeticaToolStripMenuItem;
        private ToolStripMenuItem cIFRARToolStripMenuItem3;
        private ToolStripMenuItem dECIFRARToolStripMenuItem3;
        private ToolStripMenuItem cifradoAfinToolStripMenuItem;
        private ToolStripMenuItem cIFRARToolStripMenuItem4;
        private ToolStripMenuItem dECIFRARToolStripMenuItem4;
        private ToolStripMenuItem cifradoDesplazamientoToolStripMenuItem;
        private ToolStripMenuItem cIFRARToolStripMenuItem5;
        private ToolStripMenuItem dECIFRARToolStripMenuItem5;
        private ToolStripMenuItem cLAVEToolStripMenuItem;
        private Label lblCifrado;
        private Label lblOriginal;
        private ToolStripMenuItem cifradoToolStripMenuItem;
        private ToolStripMenuItem cIFRARToolStripMenuItem6;
        private ToolStripMenuItem dESCIFRARToolStripMenuItem;
        private ToolStripMenuItem pARAMETROSToolStripMenuItem;
        private ToolStripMenuItem cifradoTransposicionSerieToolStripMenuItem;
        private ToolStripMenuItem cToolStripMenuItem;
        private ToolStripMenuItem decifrarToolStripMenuItem6;
        private ToolStripMenuItem parametrosToolStripMenuItem1;
        private ToolStripMenuItem claveToolStripMenuItem1;
        private ToolStripMenuItem generarNuevaClaveToolStripMenuItem;
        private ToolStripMenuItem exportarClaveToolStripMenuItem;
        private ToolStripMenuItem actualizarLaClaveToolStripMenuItem;
        private ToolStripMenuItem nuevaClaveToolStripMenuItem;
        private ToolStripMenuItem claveToolStripMenuItem2;
        private ToolStripMenuItem cambiarToolStripMenuItem;
        private ToolStripMenuItem claveToolStripMenuItem3;
        private ToolStripMenuItem cambiarToolStripMenuItem1;
        private ToolStripMenuItem mostrarToolStripMenuItem1;
        private ToolStripMenuItem mostrarToolStripMenuItem;
        private ToolStripMenuItem claveToolStripMenuItem4;
        private ToolStripMenuItem cambiarToolStripMenuItem2;
        private ToolStripMenuItem mostrarToolStripMenuItem2;
        private ToolStripMenuItem mostrarToolStripMenuItem3;
        private ToolStripMenuItem cambiarToolStripMenuItem3;
        private ToolStripMenuItem mostrarToolStripMenuItem4;
    }
}
