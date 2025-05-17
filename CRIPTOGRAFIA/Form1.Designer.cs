namespace CRIPTOGRAFIA
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnGENERAR_Mclave = new Button();
            txtOriginal = new TextBox();
            txtAlfabeto = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            menuStrip1 = new MenuStrip();
            abrirArchivoToolStripMenuItem = new ToolStripMenuItem();
            abrirArchivoToolStripMenuItem1 = new ToolStripMenuItem();
            guardarEnArchivoToolStripMenuItem = new ToolStripMenuItem();
            cRIPTOToolStripMenuItem = new ToolStripMenuItem();
            decifrarArchivoToolStripMenuItem = new ToolStripMenuItem();
            cifrarArchivoToolStripMenuItem = new ToolStripMenuItem();
            actulzarLaClaveToolStripMenuItem = new ToolStripMenuItem();
            cIFRARToolStripMenuItem = new ToolStripMenuItem();
            dECIFRARToolStripMenuItem = new ToolStripMenuItem();
            cIfradoPlayFairToolStripMenuItem = new ToolStripMenuItem();
            ingresarClaveToolStripMenuItem = new ToolStripMenuItem();
            cIFRARToolStripMenuItem1 = new ToolStripMenuItem();
            dECIFRARToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            cifrarToolStripMenuItem2 = new ToolStripMenuItem();
            decifrarToolStripMenuItem2 = new ToolStripMenuItem();
            cifradoSustitucionPolialfabeticaToolStripMenuItem = new ToolStripMenuItem();
            cIFRARToolStripMenuItem3 = new ToolStripMenuItem();
            dECIFRARToolStripMenuItem3 = new ToolStripMenuItem();
            cifradoAfinToolStripMenuItem = new ToolStripMenuItem();
            cIFRARToolStripMenuItem4 = new ToolStripMenuItem();
            dECIFRARToolStripMenuItem4 = new ToolStripMenuItem();
            lbl1 = new Label();
            txtResultado = new TextBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnGENERAR_Mclave
            // 
            btnGENERAR_Mclave.Location = new Point(22, 28);
            btnGENERAR_Mclave.Name = "btnGENERAR_Mclave";
            btnGENERAR_Mclave.Size = new Size(159, 23);
            btnGENERAR_Mclave.TabIndex = 1;
            btnGENERAR_Mclave.Text = "MOSTRAR CLAVE";
            btnGENERAR_Mclave.UseVisualStyleBackColor = true;
            // 
            // txtOriginal
            // 
            txtOriginal.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtOriginal.Location = new Point(22, 61);
            txtOriginal.Multiline = true;
            txtOriginal.Name = "txtOriginal";
            txtOriginal.ScrollBars = ScrollBars.Vertical;
            txtOriginal.Size = new Size(1281, 253);
            txtOriginal.TabIndex = 3;
            txtOriginal.Text = "HOLA MUNDO";
            // 
            // txtAlfabeto
            // 
            txtAlfabeto.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtAlfabeto.Location = new Point(206, 32);
            txtAlfabeto.Multiline = true;
            txtAlfabeto.Name = "txtAlfabeto";
            txtAlfabeto.Size = new Size(976, 23);
            txtAlfabeto.TabIndex = 8;
            txtAlfabeto.Text = " !\"#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_`abcdefghijklmnopqrstuvwxyz{|}~¡¢£¤¥¦§¨©ª«¬­®¯°±²³´µ¶·¸¹º»¼½¾¿ÀÁÂÃÄÅÆÇÈÉÊËÌÍÎÏÐÑÒÓÔÕÖ×ØÙÚÛÜÝÞßàáâãäåæçèéêëìíîïðñòóôõö÷øùúûüýþÿ\n";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { abrirArchivoToolStripMenuItem, cRIPTOToolStripMenuItem, cIfradoPlayFairToolStripMenuItem, toolStripMenuItem1, cifradoSustitucionPolialfabeticaToolStripMenuItem, cifradoAfinToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1315, 24);
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
            abrirArchivoToolStripMenuItem1.Size = new Size(142, 22);
            abrirArchivoToolStripMenuItem1.Text = "Abrir archivo";
            abrirArchivoToolStripMenuItem1.Click += abrirArchivoToolStripMenuItem1_Click;
            // 
            // guardarEnArchivoToolStripMenuItem
            // 
            guardarEnArchivoToolStripMenuItem.Name = "guardarEnArchivoToolStripMenuItem";
            guardarEnArchivoToolStripMenuItem.Size = new Size(142, 22);
            guardarEnArchivoToolStripMenuItem.Text = "Guardar";
            guardarEnArchivoToolStripMenuItem.Click += guardarEnArchivoToolStripMenuItem_Click;
            // 
            // cRIPTOToolStripMenuItem
            // 
            cRIPTOToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { decifrarArchivoToolStripMenuItem, cifrarArchivoToolStripMenuItem, actulzarLaClaveToolStripMenuItem, cIFRARToolStripMenuItem, dECIFRARToolStripMenuItem });
            cRIPTOToolStripMenuItem.Name = "cRIPTOToolStripMenuItem";
            cRIPTOToolStripMenuItem.Size = new Size(79, 20);
            cRIPTOToolStripMenuItem.Text = "Cifrado Hill";
            // 
            // decifrarArchivoToolStripMenuItem
            // 
            decifrarArchivoToolStripMenuItem.Name = "decifrarArchivoToolStripMenuItem";
            decifrarArchivoToolStripMenuItem.Size = new Size(180, 22);
            decifrarArchivoToolStripMenuItem.Text = "Generar nueva clave";
            decifrarArchivoToolStripMenuItem.Click += decifrarArchivoToolStripMenuItem_Click;
            // 
            // cifrarArchivoToolStripMenuItem
            // 
            cifrarArchivoToolStripMenuItem.Name = "cifrarArchivoToolStripMenuItem";
            cifrarArchivoToolStripMenuItem.Size = new Size(180, 22);
            cifrarArchivoToolStripMenuItem.Text = "Exportar Clave";
            cifrarArchivoToolStripMenuItem.Click += cifrarArchivoToolStripMenuItem_Click;
            // 
            // actulzarLaClaveToolStripMenuItem
            // 
            actulzarLaClaveToolStripMenuItem.Name = "actulzarLaClaveToolStripMenuItem";
            actulzarLaClaveToolStripMenuItem.Size = new Size(180, 22);
            actulzarLaClaveToolStripMenuItem.Text = "Actualizar la clave";
            actulzarLaClaveToolStripMenuItem.Click += actulzarLaClaveToolStripMenuItem_Click;
            // 
            // cIFRARToolStripMenuItem
            // 
            cIFRARToolStripMenuItem.Name = "cIFRARToolStripMenuItem";
            cIFRARToolStripMenuItem.Size = new Size(180, 22);
            cIFRARToolStripMenuItem.Text = "CIFRAR";
            cIFRARToolStripMenuItem.Click += cIFRARToolStripMenuItem_Click;
            // 
            // dECIFRARToolStripMenuItem
            // 
            dECIFRARToolStripMenuItem.Name = "dECIFRARToolStripMenuItem";
            dECIFRARToolStripMenuItem.Size = new Size(180, 22);
            dECIFRARToolStripMenuItem.Text = "DECIFRAR";
            dECIFRARToolStripMenuItem.Click += dECIFRARToolStripMenuItem_Click;
            // 
            // cIfradoPlayFairToolStripMenuItem
            // 
            cIfradoPlayFairToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ingresarClaveToolStripMenuItem, cIFRARToolStripMenuItem1, dECIFRARToolStripMenuItem1 });
            cIfradoPlayFairToolStripMenuItem.Name = "cIfradoPlayFairToolStripMenuItem";
            cIfradoPlayFairToolStripMenuItem.Size = new Size(102, 20);
            cIfradoPlayFairToolStripMenuItem.Text = "CIfrado PlayFair";
            // 
            // ingresarClaveToolStripMenuItem
            // 
            ingresarClaveToolStripMenuItem.Name = "ingresarClaveToolStripMenuItem";
            ingresarClaveToolStripMenuItem.Size = new Size(148, 22);
            ingresarClaveToolStripMenuItem.Text = "Ingresar Clave";
            ingresarClaveToolStripMenuItem.Click += ingresarClaveToolStripMenuItem_Click;
            // 
            // cIFRARToolStripMenuItem1
            // 
            cIFRARToolStripMenuItem1.Name = "cIFRARToolStripMenuItem1";
            cIFRARToolStripMenuItem1.Size = new Size(148, 22);
            cIFRARToolStripMenuItem1.Text = "CIFRAR";
            cIFRARToolStripMenuItem1.Click += cIFRARToolStripMenuItem1_Click;
            // 
            // dECIFRARToolStripMenuItem1
            // 
            dECIFRARToolStripMenuItem1.Name = "dECIFRARToolStripMenuItem1";
            dECIFRARToolStripMenuItem1.Size = new Size(148, 22);
            dECIFRARToolStripMenuItem1.Text = "DECIFRAR";
            dECIFRARToolStripMenuItem1.Click += dECIFRARToolStripMenuItem1_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { cifrarToolStripMenuItem2, decifrarToolStripMenuItem2 });
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
            // cifradoSustitucionPolialfabeticaToolStripMenuItem
            // 
            cifradoSustitucionPolialfabeticaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cIFRARToolStripMenuItem3, dECIFRARToolStripMenuItem3 });
            cifradoSustitucionPolialfabeticaToolStripMenuItem.Name = "cifradoSustitucionPolialfabeticaToolStripMenuItem";
            cifradoSustitucionPolialfabeticaToolStripMenuItem.Size = new Size(193, 20);
            cifradoSustitucionPolialfabeticaToolStripMenuItem.Text = "Cifrado sustitucion polialfabetica";
            // 
            // cIFRARToolStripMenuItem3
            // 
            cIFRARToolStripMenuItem3.Name = "cIFRARToolStripMenuItem3";
            cIFRARToolStripMenuItem3.Size = new Size(127, 22);
            cIFRARToolStripMenuItem3.Text = "CIFRAR";
            cIFRARToolStripMenuItem3.Click += cIFRARToolStripMenuItem3_Click;
            // 
            // dECIFRARToolStripMenuItem3
            // 
            dECIFRARToolStripMenuItem3.Name = "dECIFRARToolStripMenuItem3";
            dECIFRARToolStripMenuItem3.Size = new Size(127, 22);
            dECIFRARToolStripMenuItem3.Text = "DECIFRAR";
            dECIFRARToolStripMenuItem3.Click += dECIFRARToolStripMenuItem3_Click;
            // 
            // cifradoAfinToolStripMenuItem
            // 
            cifradoAfinToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cIFRARToolStripMenuItem4, dECIFRARToolStripMenuItem4 });
            cifradoAfinToolStripMenuItem.Name = "cifradoAfinToolStripMenuItem";
            cifradoAfinToolStripMenuItem.Size = new Size(81, 20);
            cifradoAfinToolStripMenuItem.Text = "Cifrado afin";
            // 
            // cIFRARToolStripMenuItem4
            // 
            cIFRARToolStripMenuItem4.Name = "cIFRARToolStripMenuItem4";
            cIFRARToolStripMenuItem4.Size = new Size(180, 22);
            cIFRARToolStripMenuItem4.Text = "CIFRAR";
            cIFRARToolStripMenuItem4.Click += cIFRARToolStripMenuItem4_Click;
            // 
            // dECIFRARToolStripMenuItem4
            // 
            dECIFRARToolStripMenuItem4.Name = "dECIFRARToolStripMenuItem4";
            dECIFRARToolStripMenuItem4.Size = new Size(180, 22);
            dECIFRARToolStripMenuItem4.Text = "DECIFRAR";
            dECIFRARToolStripMenuItem4.Click += dECIFRARToolStripMenuItem4_Click;
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
            txtResultado.Location = new Point(22, 320);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.ScrollBars = ScrollBars.Vertical;
            txtResultado.Size = new Size(1281, 257);
            txtResultado.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1315, 679);
            Controls.Add(txtResultado);
            Controls.Add(lbl1);
            Controls.Add(txtAlfabeto);
            Controls.Add(txtOriginal);
            Controls.Add(btnGENERAR_Mclave);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "CRIPTOGRAFIA Y SEGURIDAD";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnGENERAR_Mclave;
        private TextBox txtOriginal;
        private TextBox txtAlfabeto;
        private Button button1;
        private Button btnMostrar;
        private OpenFileDialog openFileDialog1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem abrirArchivoToolStripMenuItem;
        private ToolStripMenuItem abrirArchivoToolStripMenuItem1;
        private ToolStripMenuItem guardarEnArchivoToolStripMenuItem;
        private Label lbl1;
        private ToolStripMenuItem cRIPTOToolStripMenuItem;
        private ToolStripMenuItem decifrarArchivoToolStripMenuItem;
        private ToolStripMenuItem cifrarArchivoToolStripMenuItem;
        private TextBox txtResultado;
        private ToolStripMenuItem actulzarLaClaveToolStripMenuItem;
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
    }
}
