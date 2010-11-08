namespace Red_Neuronal
{
    partial class I_Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(I_Principal));
            this.barra_estado = new System.Windows.Forms.StatusStrip();
            this.menu_principal = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_salir = new System.Windows.Forms.ToolStripMenuItem();
            this.acciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_entrenamiento = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_ejecucion = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_acerca_de = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_entrenamiento = new System.Windows.Forms.Panel();
            this.campo_elegir_tipo_red = new System.Windows.Forms.ComboBox();
            this.label33 = new System.Windows.Forms.Label();
            this.configuracion_red_cp = new System.Windows.Forms.GroupBox();
            this.boton_entrenar_cp = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.campo_cant_salida = new System.Windows.Forms.NumericUpDown();
            this.campo_cant_ocult_cp = new System.Windows.Forms.NumericUpDown();
            this.campo_cant_entrada_cp = new System.Windows.Forms.NumericUpDown();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.boton_crear_muestras_cp = new System.Windows.Forms.Button();
            this.boton_elegir_ruta_muestras_cp = new System.Windows.Forms.Button();
            this.campo_ruta_muestras_cp = new System.Windows.Forms.TextBox();
            this.campo_alpha_cp = new System.Windows.Forms.NumericUpDown();
            this.error_capa_oculta_cp = new System.Windows.Forms.NumericUpDown();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.configuracion_red_bp = new System.Windows.Forms.GroupBox();
            this.boton_entrenar_bp = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.campo_neuronas_salida_bp = new System.Windows.Forms.NumericUpDown();
            this.campo_neuronas_intermedia_bp = new System.Windows.Forms.NumericUpDown();
            this.campo_neuronas_entrada_bp = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.boton_crear_muestras_bp = new System.Windows.Forms.Button();
            this.boton_elegir_ruta_muestras_bp = new System.Windows.Forms.Button();
            this.campo_ruta_muestras_bp = new System.Windows.Forms.TextBox();
            this.campo_error_bp = new System.Windows.Forms.NumericUpDown();
            this.campo_aprendizaje_bp = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.campo_IniPesos_Hasta_bp = new System.Windows.Forms.NumericUpDown();
            this.campo_IniPesos_Desde_bp = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_ejecucion = new System.Windows.Forms.Panel();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.campo_resultado_ejecucion_bp = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.campo_tiempo_ejecucion_bp = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.boton_estabalecer_pesos_ejecucion_bp = new System.Windows.Forms.Button();
            this.boton_elegir_pesos_ejecucion_bp = new System.Windows.Forms.Button();
            this.campo_ruta_pesos_ejecucion_bp = new System.Windows.Forms.TextBox();
            this.groupBox_Dibujo = new System.Windows.Forms.GroupBox();
            this.panel_dibujo = new System.Windows.Forms.Panel();
            this.boton_reconocer_figura = new System.Windows.Forms.Button();
            this.boton_limpiar_panel = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.campo_resultado_ejecucion_cp = new System.Windows.Forms.PictureBox();
            this.label30 = new System.Windows.Forms.Label();
            this.campo_tiempo_ejecucion_cp = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.boton_estabalecer_pesos_ejecucion_cp = new System.Windows.Forms.Button();
            this.boton_elegir_pesos_ejecucion_cp = new System.Windows.Forms.Button();
            this.campo_ruta_pesos_ejecucion_cp = new System.Windows.Forms.TextBox();
            this.ventana_elegir_ruta_muestras = new System.Windows.Forms.OpenFileDialog();
            this.veantana_elegir_ruta_pesos = new System.Windows.Forms.OpenFileDialog();
            this.panel_crear_muestras = new System.Windows.Forms.Panel();
            this.campo_iteraciones_muestras = new System.Windows.Forms.NumericUpDown();
            this.label19 = new System.Windows.Forms.Label();
            this.boton_cancelar_muestras = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.boton_guardar_muestras = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.campo_muestra = new System.Windows.Forms.PictureBox();
            this.panel_dibujo_muestra = new System.Windows.Forms.Panel();
            this.boton_guardar_muestra = new System.Windows.Forms.Button();
            this.boton_limpiar_panel_muestra = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.ventana_salvar_muestras = new System.Windows.Forms.SaveFileDialog();
            this.panel_muestra_entrenamiento_bp = new System.Windows.Forms.Panel();
            this.boton_abortar_entrenamiento = new System.Windows.Forms.Button();
            this.campo_iteraciones_entrenamiento = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.campo_tiempo_entrenamiento = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.panel_grafico_error = new System.Windows.Forms.Panel();
            this.ventana_salvar_pesos = new System.Windows.Forms.SaveFileDialog();
            this.panel_entrenamiento_cp = new System.Windows.Forms.Panel();
            this.num_it_entr_cp = new System.Windows.Forms.NumericUpDown();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.tiempo_final_entr_cp = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.imagenes_figuras = new System.Windows.Forms.ImageList(this.components);
            this.menu_principal.SuspendLayout();
            this.panel_entrenamiento.SuspendLayout();
            this.configuracion_red_cp.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.campo_cant_salida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.campo_cant_ocult_cp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.campo_cant_entrada_cp)).BeginInit();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.campo_alpha_cp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_capa_oculta_cp)).BeginInit();
            this.configuracion_red_bp.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.campo_neuronas_salida_bp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.campo_neuronas_intermedia_bp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.campo_neuronas_entrada_bp)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.campo_error_bp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.campo_aprendizaje_bp)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.campo_IniPesos_Hasta_bp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.campo_IniPesos_Desde_bp)).BeginInit();
            this.panel_ejecucion.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.campo_resultado_ejecucion_bp)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox_Dibujo.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.campo_resultado_ejecucion_cp)).BeginInit();
            this.groupBox10.SuspendLayout();
            this.panel_crear_muestras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.campo_iteraciones_muestras)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.campo_muestra)).BeginInit();
            this.panel_muestra_entrenamiento_bp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.campo_iteraciones_entrenamiento)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.panel_entrenamiento_cp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_it_entr_cp)).BeginInit();
            this.SuspendLayout();
            // 
            // barra_estado
            // 
            this.barra_estado.Location = new System.Drawing.Point(0, 488);
            this.barra_estado.Name = "barra_estado";
            this.barra_estado.Size = new System.Drawing.Size(1176, 22);
            this.barra_estado.SizingGrip = false;
            this.barra_estado.TabIndex = 0;
            this.barra_estado.Text = "Barra de estado";
            // 
            // menu_principal
            // 
            this.menu_principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.acciónToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menu_principal.Location = new System.Drawing.Point(0, 0);
            this.menu_principal.Name = "menu_principal";
            this.menu_principal.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menu_principal.Size = new System.Drawing.Size(1176, 24);
            this.menu_principal.TabIndex = 1;
            this.menu_principal.Text = "Menu Principal";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_salir});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // menu_salir
            // 
            this.menu_salir.Name = "menu_salir";
            this.menu_salir.Size = new System.Drawing.Size(96, 22);
            this.menu_salir.Text = "Salir";
            this.menu_salir.Click += new System.EventHandler(this.menu_salir_Click);
            // 
            // acciónToolStripMenuItem
            // 
            this.acciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_entrenamiento,
            this.menu_ejecucion});
            this.acciónToolStripMenuItem.Name = "acciónToolStripMenuItem";
            this.acciónToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.acciónToolStripMenuItem.Text = "Modo";
            // 
            // menu_entrenamiento
            // 
            this.menu_entrenamiento.Name = "menu_entrenamiento";
            this.menu_entrenamiento.Size = new System.Drawing.Size(152, 22);
            this.menu_entrenamiento.Text = "Entrenamiento";
            this.menu_entrenamiento.Click += new System.EventHandler(this.menu_entrenamiento_Click);
            // 
            // menu_ejecucion
            // 
            this.menu_ejecucion.Name = "menu_ejecucion";
            this.menu_ejecucion.Size = new System.Drawing.Size(152, 22);
            this.menu_ejecucion.Text = "Ejecución";
            this.menu_ejecucion.Click += new System.EventHandler(this.menu_ejecucion_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_acerca_de});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // menu_acerca_de
            // 
            this.menu_acerca_de.Name = "menu_acerca_de";
            this.menu_acerca_de.Size = new System.Drawing.Size(135, 22);
            this.menu_acerca_de.Text = "Acerca de...";
            this.menu_acerca_de.Click += new System.EventHandler(this.menu_acerca_de_Click);
            // 
            // panel_entrenamiento
            // 
            this.panel_entrenamiento.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel_entrenamiento.Controls.Add(this.campo_elegir_tipo_red);
            this.panel_entrenamiento.Controls.Add(this.label33);
            this.panel_entrenamiento.Controls.Add(this.configuracion_red_cp);
            this.panel_entrenamiento.Controls.Add(this.configuracion_red_bp);
            this.panel_entrenamiento.Location = new System.Drawing.Point(0, 28);
            this.panel_entrenamiento.Name = "panel_entrenamiento";
            this.panel_entrenamiento.Size = new System.Drawing.Size(1176, 459);
            this.panel_entrenamiento.TabIndex = 2;
            this.panel_entrenamiento.Visible = false;
            // 
            // campo_elegir_tipo_red
            // 
            this.campo_elegir_tipo_red.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.campo_elegir_tipo_red.FormattingEnabled = true;
            this.campo_elegir_tipo_red.Items.AddRange(new object[] {
            "Retropropagación",
            "Contrapropagación"});
            this.campo_elegir_tipo_red.Location = new System.Drawing.Point(559, 18);
            this.campo_elegir_tipo_red.Name = "campo_elegir_tipo_red";
            this.campo_elegir_tipo_red.Size = new System.Drawing.Size(178, 21);
            this.campo_elegir_tipo_red.TabIndex = 2;
            this.campo_elegir_tipo_red.SelectedIndexChanged += new System.EventHandler(this.campo_elegir_tipo_red_SelectedIndexChanged);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(440, 16);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(112, 13);
            this.label33.TabIndex = 1;
            this.label33.Text = "Tipo de red a entrenar";
            // 
            // configuracion_red_cp
            // 
            this.configuracion_red_cp.Controls.Add(this.boton_entrenar_cp);
            this.configuracion_red_cp.Controls.Add(this.groupBox1);
            this.configuracion_red_cp.Controls.Add(this.groupBox11);
            this.configuracion_red_cp.Location = new System.Drawing.Point(15, 45);
            this.configuracion_red_cp.Name = "configuracion_red_cp";
            this.configuracion_red_cp.Size = new System.Drawing.Size(1140, 392);
            this.configuracion_red_cp.TabIndex = 10;
            this.configuracion_red_cp.TabStop = false;
            this.configuracion_red_cp.Text = "Configuración del aprendizaje";
            this.configuracion_red_cp.Visible = false;
            // 
            // boton_entrenar_cp
            // 
            this.boton_entrenar_cp.Enabled = false;
            this.boton_entrenar_cp.Location = new System.Drawing.Point(520, 338);
            this.boton_entrenar_cp.Name = "boton_entrenar_cp";
            this.boton_entrenar_cp.Size = new System.Drawing.Size(113, 23);
            this.boton_entrenar_cp.TabIndex = 12;
            this.boton_entrenar_cp.Text = "Entrenar";
            this.boton_entrenar_cp.UseVisualStyleBackColor = true;
            this.boton_entrenar_cp.Click += new System.EventHandler(this.boton_entrenar_cp_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.campo_cant_salida);
            this.groupBox1.Controls.Add(this.campo_cant_ocult_cp);
            this.groupBox1.Controls.Add(this.campo_cant_entrada_cp);
            this.groupBox1.Controls.Add(this.label34);
            this.groupBox1.Controls.Add(this.label35);
            this.groupBox1.Controls.Add(this.label36);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1117, 66);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estructura de la red neuronal";
            // 
            // campo_cant_salida
            // 
            this.campo_cant_salida.BackColor = System.Drawing.SystemColors.Window;
            this.campo_cant_salida.Enabled = false;
            this.campo_cant_salida.Location = new System.Drawing.Point(1006, 27);
            this.campo_cant_salida.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.campo_cant_salida.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.campo_cant_salida.Name = "campo_cant_salida";
            this.campo_cant_salida.ReadOnly = true;
            this.campo_cant_salida.Size = new System.Drawing.Size(61, 20);
            this.campo_cant_salida.TabIndex = 10;
            this.campo_cant_salida.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // campo_cant_ocult_cp
            // 
            this.campo_cant_ocult_cp.BackColor = System.Drawing.SystemColors.Window;
            this.campo_cant_ocult_cp.Enabled = false;
            this.campo_cant_ocult_cp.Location = new System.Drawing.Point(600, 27);
            this.campo_cant_ocult_cp.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.campo_cant_ocult_cp.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.campo_cant_ocult_cp.Name = "campo_cant_ocult_cp";
            this.campo_cant_ocult_cp.ReadOnly = true;
            this.campo_cant_ocult_cp.Size = new System.Drawing.Size(61, 20);
            this.campo_cant_ocult_cp.TabIndex = 9;
            this.campo_cant_ocult_cp.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // campo_cant_entrada_cp
            // 
            this.campo_cant_entrada_cp.BackColor = System.Drawing.SystemColors.Window;
            this.campo_cant_entrada_cp.Enabled = false;
            this.campo_cant_entrada_cp.Location = new System.Drawing.Point(220, 27);
            this.campo_cant_entrada_cp.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.campo_cant_entrada_cp.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.campo_cant_entrada_cp.Name = "campo_cant_entrada_cp";
            this.campo_cant_entrada_cp.ReadOnly = true;
            this.campo_cant_entrada_cp.Size = new System.Drawing.Size(61, 20);
            this.campo_cant_entrada_cp.TabIndex = 8;
            this.campo_cant_entrada_cp.Value = new decimal(new int[] {
            225,
            0,
            0,
            0});
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(437, 27);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(146, 13);
            this.label34.TabIndex = 7;
            this.label34.Text = "Neuronas de capa intermedia";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(870, 27);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(125, 13);
            this.label35.TabIndex = 6;
            this.label35.Text = "Neuronas de capa salida";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(50, 27);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(149, 13);
            this.label36.TabIndex = 5;
            this.label36.Text = "Neuronas de capa de entrada";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.boton_crear_muestras_cp);
            this.groupBox11.Controls.Add(this.boton_elegir_ruta_muestras_cp);
            this.groupBox11.Controls.Add(this.campo_ruta_muestras_cp);
            this.groupBox11.Controls.Add(this.campo_alpha_cp);
            this.groupBox11.Controls.Add(this.error_capa_oculta_cp);
            this.groupBox11.Controls.Add(this.label37);
            this.groupBox11.Controls.Add(this.label38);
            this.groupBox11.Controls.Add(this.label41);
            this.groupBox11.Location = new System.Drawing.Point(12, 123);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(1117, 164);
            this.groupBox11.TabIndex = 10;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Parámetros de aprendizaje";
            // 
            // boton_crear_muestras_cp
            // 
            this.boton_crear_muestras_cp.Location = new System.Drawing.Point(931, 110);
            this.boton_crear_muestras_cp.Name = "boton_crear_muestras_cp";
            this.boton_crear_muestras_cp.Size = new System.Drawing.Size(143, 23);
            this.boton_crear_muestras_cp.TabIndex = 9;
            this.boton_crear_muestras_cp.Text = "Crear conjunto muestras";
            this.boton_crear_muestras_cp.UseVisualStyleBackColor = true;
            this.boton_crear_muestras_cp.Click += new System.EventHandler(this.boton_crear_muestras_Click);
            // 
            // boton_elegir_ruta_muestras_cp
            // 
            this.boton_elegir_ruta_muestras_cp.Location = new System.Drawing.Point(894, 110);
            this.boton_elegir_ruta_muestras_cp.Name = "boton_elegir_ruta_muestras_cp";
            this.boton_elegir_ruta_muestras_cp.Size = new System.Drawing.Size(31, 23);
            this.boton_elegir_ruta_muestras_cp.TabIndex = 8;
            this.boton_elegir_ruta_muestras_cp.Text = "...";
            this.boton_elegir_ruta_muestras_cp.UseVisualStyleBackColor = true;
            this.boton_elegir_ruta_muestras_cp.Click += new System.EventHandler(this.boton_elegir_ruta_muestras_cp_Click);
            // 
            // campo_ruta_muestras_cp
            // 
            this.campo_ruta_muestras_cp.Location = new System.Drawing.Point(203, 112);
            this.campo_ruta_muestras_cp.Name = "campo_ruta_muestras_cp";
            this.campo_ruta_muestras_cp.Size = new System.Drawing.Size(681, 20);
            this.campo_ruta_muestras_cp.TabIndex = 7;
            this.campo_ruta_muestras_cp.TextChanged += new System.EventHandler(this.campo_ruta_muestras_cp_TextChanged);
            // 
            // campo_alpha_cp
            // 
            this.campo_alpha_cp.DecimalPlaces = 2;
            this.campo_alpha_cp.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.campo_alpha_cp.Location = new System.Drawing.Point(423, 44);
            this.campo_alpha_cp.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.campo_alpha_cp.Name = "campo_alpha_cp";
            this.campo_alpha_cp.Size = new System.Drawing.Size(61, 20);
            this.campo_alpha_cp.TabIndex = 4;
            this.campo_alpha_cp.Value = new decimal(new int[] {
            8,
            0,
            0,
            65536});
            // 
            // error_capa_oculta_cp
            // 
            this.error_capa_oculta_cp.DecimalPlaces = 3;
            this.error_capa_oculta_cp.Increment = new decimal(new int[] {
            5,
            0,
            0,
            196608});
            this.error_capa_oculta_cp.Location = new System.Drawing.Point(803, 44);
            this.error_capa_oculta_cp.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.error_capa_oculta_cp.Name = "error_capa_oculta_cp";
            this.error_capa_oculta_cp.Size = new System.Drawing.Size(61, 20);
            this.error_capa_oculta_cp.TabIndex = 6;
            this.error_capa_oculta_cp.Value = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(10, 112);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(188, 13);
            this.label37.TabIndex = 3;
            this.label37.Text = "Archivo de muestras de entrenamiento";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(253, 42);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(162, 13);
            this.label38.TabIndex = 0;
            this.label38.Text = "Coeficiente de aprendizaje Alpha";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(640, 42);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(157, 13);
            this.label41.TabIndex = 1;
            this.label41.Text = "Error permitido para capa oculta";
            // 
            // configuracion_red_bp
            // 
            this.configuracion_red_bp.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.configuracion_red_bp.Controls.Add(this.boton_entrenar_bp);
            this.configuracion_red_bp.Controls.Add(this.groupBox4);
            this.configuracion_red_bp.Controls.Add(this.groupBox3);
            this.configuracion_red_bp.Location = new System.Drawing.Point(15, 48);
            this.configuracion_red_bp.Name = "configuracion_red_bp";
            this.configuracion_red_bp.Size = new System.Drawing.Size(1146, 389);
            this.configuracion_red_bp.TabIndex = 0;
            this.configuracion_red_bp.TabStop = false;
            this.configuracion_red_bp.Text = "Configuración del aprendizaje";
            this.configuracion_red_bp.Visible = false;
            // 
            // boton_entrenar_bp
            // 
            this.boton_entrenar_bp.Enabled = false;
            this.boton_entrenar_bp.Location = new System.Drawing.Point(517, 348);
            this.boton_entrenar_bp.Name = "boton_entrenar_bp";
            this.boton_entrenar_bp.Size = new System.Drawing.Size(113, 23);
            this.boton_entrenar_bp.TabIndex = 9;
            this.boton_entrenar_bp.Text = "Entrenar";
            this.boton_entrenar_bp.UseVisualStyleBackColor = true;
            this.boton_entrenar_bp.Click += new System.EventHandler(this.boton_entrenar_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.campo_neuronas_salida_bp);
            this.groupBox4.Controls.Add(this.campo_neuronas_intermedia_bp);
            this.groupBox4.Controls.Add(this.campo_neuronas_entrada_bp);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(9, 41);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1117, 66);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Estructura de la red neuronal";
            // 
            // campo_neuronas_salida_bp
            // 
            this.campo_neuronas_salida_bp.Enabled = false;
            this.campo_neuronas_salida_bp.Location = new System.Drawing.Point(966, 27);
            this.campo_neuronas_salida_bp.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.campo_neuronas_salida_bp.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.campo_neuronas_salida_bp.Name = "campo_neuronas_salida_bp";
            this.campo_neuronas_salida_bp.Size = new System.Drawing.Size(61, 20);
            this.campo_neuronas_salida_bp.TabIndex = 10;
            this.campo_neuronas_salida_bp.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // campo_neuronas_intermedia_bp
            // 
            this.campo_neuronas_intermedia_bp.Location = new System.Drawing.Point(549, 27);
            this.campo_neuronas_intermedia_bp.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.campo_neuronas_intermedia_bp.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.campo_neuronas_intermedia_bp.Name = "campo_neuronas_intermedia_bp";
            this.campo_neuronas_intermedia_bp.Size = new System.Drawing.Size(61, 20);
            this.campo_neuronas_intermedia_bp.TabIndex = 9;
            this.campo_neuronas_intermedia_bp.Value = new decimal(new int[] {
            169,
            0,
            0,
            0});
            // 
            // campo_neuronas_entrada_bp
            // 
            this.campo_neuronas_entrada_bp.Enabled = false;
            this.campo_neuronas_entrada_bp.Location = new System.Drawing.Point(165, 29);
            this.campo_neuronas_entrada_bp.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.campo_neuronas_entrada_bp.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.campo_neuronas_entrada_bp.Name = "campo_neuronas_entrada_bp";
            this.campo_neuronas_entrada_bp.Size = new System.Drawing.Size(61, 20);
            this.campo_neuronas_entrada_bp.TabIndex = 8;
            this.campo_neuronas_entrada_bp.Value = new decimal(new int[] {
            225,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(397, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Neuronas de capa intermedia";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(830, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Neuronas de capa salida";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Neuronas de capa de entrada";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.boton_crear_muestras_bp);
            this.groupBox3.Controls.Add(this.boton_elegir_ruta_muestras_bp);
            this.groupBox3.Controls.Add(this.campo_ruta_muestras_bp);
            this.groupBox3.Controls.Add(this.campo_error_bp);
            this.groupBox3.Controls.Add(this.campo_aprendizaje_bp);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(9, 133);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1117, 164);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Parámetros de aprendizaje";
            // 
            // boton_crear_muestras_bp
            // 
            this.boton_crear_muestras_bp.Location = new System.Drawing.Point(931, 110);
            this.boton_crear_muestras_bp.Name = "boton_crear_muestras_bp";
            this.boton_crear_muestras_bp.Size = new System.Drawing.Size(143, 23);
            this.boton_crear_muestras_bp.TabIndex = 9;
            this.boton_crear_muestras_bp.Text = "Crear conjunto muestras";
            this.boton_crear_muestras_bp.UseVisualStyleBackColor = true;
            this.boton_crear_muestras_bp.Click += new System.EventHandler(this.boton_crear_muestras_Click);
            // 
            // boton_elegir_ruta_muestras_bp
            // 
            this.boton_elegir_ruta_muestras_bp.Location = new System.Drawing.Point(894, 110);
            this.boton_elegir_ruta_muestras_bp.Name = "boton_elegir_ruta_muestras_bp";
            this.boton_elegir_ruta_muestras_bp.Size = new System.Drawing.Size(31, 23);
            this.boton_elegir_ruta_muestras_bp.TabIndex = 8;
            this.boton_elegir_ruta_muestras_bp.Text = "...";
            this.boton_elegir_ruta_muestras_bp.UseVisualStyleBackColor = true;
            this.boton_elegir_ruta_muestras_bp.Click += new System.EventHandler(this.boton_elegir_ruta_patrones_Click);
            // 
            // campo_ruta_muestras_bp
            // 
            this.campo_ruta_muestras_bp.Location = new System.Drawing.Point(203, 112);
            this.campo_ruta_muestras_bp.Name = "campo_ruta_muestras_bp";
            this.campo_ruta_muestras_bp.Size = new System.Drawing.Size(681, 20);
            this.campo_ruta_muestras_bp.TabIndex = 7;
            this.campo_ruta_muestras_bp.TextChanged += new System.EventHandler(this.campo_ruta_muestras_TextChanged);
            // 
            // campo_error_bp
            // 
            this.campo_error_bp.DecimalPlaces = 2;
            this.campo_error_bp.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.campo_error_bp.Location = new System.Drawing.Point(165, 44);
            this.campo_error_bp.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.campo_error_bp.Name = "campo_error_bp";
            this.campo_error_bp.Size = new System.Drawing.Size(61, 20);
            this.campo_error_bp.TabIndex = 4;
            this.campo_error_bp.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // campo_aprendizaje_bp
            // 
            this.campo_aprendizaje_bp.DecimalPlaces = 2;
            this.campo_aprendizaje_bp.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.campo_aprendizaje_bp.Location = new System.Drawing.Point(549, 44);
            this.campo_aprendizaje_bp.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.campo_aprendizaje_bp.Name = "campo_aprendizaje_bp";
            this.campo_aprendizaje_bp.Size = new System.Drawing.Size(61, 20);
            this.campo_aprendizaje_bp.TabIndex = 6;
            this.campo_aprendizaje_bp.Value = new decimal(new int[] {
            8,
            0,
            0,
            65536});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Archivo de muestras de entrenamiento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Factor de error permitido";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.campo_IniPesos_Hasta_bp);
            this.groupBox2.Controls.Add(this.campo_IniPesos_Desde_bp);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(802, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 59);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rango de inicialización de pesos";
            // 
            // campo_IniPesos_Hasta_bp
            // 
            this.campo_IniPesos_Hasta_bp.DecimalPlaces = 2;
            this.campo_IniPesos_Hasta_bp.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.campo_IniPesos_Hasta_bp.Location = new System.Drawing.Point(209, 25);
            this.campo_IniPesos_Hasta_bp.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.campo_IniPesos_Hasta_bp.Name = "campo_IniPesos_Hasta_bp";
            this.campo_IniPesos_Hasta_bp.Size = new System.Drawing.Size(50, 20);
            this.campo_IniPesos_Hasta_bp.TabIndex = 7;
            this.campo_IniPesos_Hasta_bp.Value = new decimal(new int[] {
            3,
            0,
            0,
            65536});
            // 
            // campo_IniPesos_Desde_bp
            // 
            this.campo_IniPesos_Desde_bp.DecimalPlaces = 2;
            this.campo_IniPesos_Desde_bp.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.campo_IniPesos_Desde_bp.Location = new System.Drawing.Point(53, 25);
            this.campo_IniPesos_Desde_bp.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.campo_IniPesos_Desde_bp.Name = "campo_IniPesos_Desde_bp";
            this.campo_IniPesos_Desde_bp.Size = new System.Drawing.Size(50, 20);
            this.campo_IniPesos_Desde_bp.TabIndex = 6;
            this.campo_IniPesos_Desde_bp.Value = new decimal(new int[] {
            3,
            0,
            0,
            -2147418112});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(165, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Hasta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Desde:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(397, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Coeficiente de aprendizaje";
            // 
            // panel_ejecucion
            // 
            this.panel_ejecucion.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel_ejecucion.Controls.Add(this.groupBox7);
            this.panel_ejecucion.Controls.Add(this.groupBox_Dibujo);
            this.panel_ejecucion.Controls.Add(this.groupBox9);
            this.panel_ejecucion.Location = new System.Drawing.Point(0, 28);
            this.panel_ejecucion.Name = "panel_ejecucion";
            this.panel_ejecucion.Size = new System.Drawing.Size(1172, 459);
            this.panel_ejecucion.TabIndex = 3;
            this.panel_ejecucion.Visible = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.campo_resultado_ejecucion_bp);
            this.groupBox7.Controls.Add(this.label11);
            this.groupBox7.Controls.Add(this.campo_tiempo_ejecucion_bp);
            this.groupBox7.Controls.Add(this.label9);
            this.groupBox7.Controls.Add(this.label10);
            this.groupBox7.Controls.Add(this.groupBox6);
            this.groupBox7.Location = new System.Drawing.Point(4, 18);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(405, 412);
            this.groupBox7.TabIndex = 13;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Configuración Red Neuronal de RetroPropagación";
            // 
            // campo_resultado_ejecucion_bp
            // 
            this.campo_resultado_ejecucion_bp.Location = new System.Drawing.Point(141, 212);
            this.campo_resultado_ejecucion_bp.Name = "campo_resultado_ejecucion_bp";
            this.campo_resultado_ejecucion_bp.Size = new System.Drawing.Size(100, 100);
            this.campo_resultado_ejecucion_bp.TabIndex = 19;
            this.campo_resultado_ejecucion_bp.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(247, 355);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "segundos";
            // 
            // campo_tiempo_ejecucion_bp
            // 
            this.campo_tiempo_ejecucion_bp.BackColor = System.Drawing.SystemColors.Window;
            this.campo_tiempo_ejecucion_bp.Location = new System.Drawing.Point(155, 355);
            this.campo_tiempo_ejecucion_bp.Name = "campo_tiempo_ejecucion_bp";
            this.campo_tiempo_ejecucion_bp.ReadOnly = true;
            this.campo_tiempo_ejecucion_bp.Size = new System.Drawing.Size(86, 20);
            this.campo_tiempo_ejecucion_bp.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 355);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Tiempo final de ejecución";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(163, 190);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Resultado";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.boton_estabalecer_pesos_ejecucion_bp);
            this.groupBox6.Controls.Add(this.boton_elegir_pesos_ejecucion_bp);
            this.groupBox6.Controls.Add(this.campo_ruta_pesos_ejecucion_bp);
            this.groupBox6.Location = new System.Drawing.Point(8, 60);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(340, 96);
            this.groupBox6.TabIndex = 15;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Ruta del archivo de pesos de la red neuronal retropropagación";
            // 
            // boton_estabalecer_pesos_ejecucion_bp
            // 
            this.boton_estabalecer_pesos_ejecucion_bp.Enabled = false;
            this.boton_estabalecer_pesos_ejecucion_bp.Location = new System.Drawing.Point(140, 54);
            this.boton_estabalecer_pesos_ejecucion_bp.Name = "boton_estabalecer_pesos_ejecucion_bp";
            this.boton_estabalecer_pesos_ejecucion_bp.Size = new System.Drawing.Size(75, 23);
            this.boton_estabalecer_pesos_ejecucion_bp.TabIndex = 2;
            this.boton_estabalecer_pesos_ejecucion_bp.Text = "Establecer";
            this.boton_estabalecer_pesos_ejecucion_bp.UseVisualStyleBackColor = true;
            this.boton_estabalecer_pesos_ejecucion_bp.Click += new System.EventHandler(this.boton_estabalecer_pesos_ejecucion_bp_Click);
            // 
            // boton_elegir_pesos_ejecucion_bp
            // 
            this.boton_elegir_pesos_ejecucion_bp.Location = new System.Drawing.Point(307, 18);
            this.boton_elegir_pesos_ejecucion_bp.Name = "boton_elegir_pesos_ejecucion_bp";
            this.boton_elegir_pesos_ejecucion_bp.Size = new System.Drawing.Size(27, 23);
            this.boton_elegir_pesos_ejecucion_bp.TabIndex = 1;
            this.boton_elegir_pesos_ejecucion_bp.Text = "...";
            this.boton_elegir_pesos_ejecucion_bp.UseVisualStyleBackColor = true;
            this.boton_elegir_pesos_ejecucion_bp.Click += new System.EventHandler(this.boton_elegir_pesos_ejecucion_Click);
            // 
            // campo_ruta_pesos_ejecucion_bp
            // 
            this.campo_ruta_pesos_ejecucion_bp.Location = new System.Drawing.Point(7, 20);
            this.campo_ruta_pesos_ejecucion_bp.Name = "campo_ruta_pesos_ejecucion_bp";
            this.campo_ruta_pesos_ejecucion_bp.Size = new System.Drawing.Size(294, 20);
            this.campo_ruta_pesos_ejecucion_bp.TabIndex = 0;
            this.campo_ruta_pesos_ejecucion_bp.TextChanged += new System.EventHandler(this.campo_ruta_pesos_ejecucion_bp_TextChanged);
            // 
            // groupBox_Dibujo
            // 
            this.groupBox_Dibujo.Controls.Add(this.panel_dibujo);
            this.groupBox_Dibujo.Controls.Add(this.boton_reconocer_figura);
            this.groupBox_Dibujo.Controls.Add(this.boton_limpiar_panel);
            this.groupBox_Dibujo.Enabled = false;
            this.groupBox_Dibujo.Location = new System.Drawing.Point(415, 18);
            this.groupBox_Dibujo.Name = "groupBox_Dibujo";
            this.groupBox_Dibujo.Size = new System.Drawing.Size(335, 412);
            this.groupBox_Dibujo.TabIndex = 8;
            this.groupBox_Dibujo.TabStop = false;
            this.groupBox_Dibujo.Text = "Dibuje su figura";
            // 
            // panel_dibujo
            // 
            this.panel_dibujo.BackColor = System.Drawing.SystemColors.Window;
            this.panel_dibujo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_dibujo.Location = new System.Drawing.Point(17, 34);
            this.panel_dibujo.Name = "panel_dibujo";
            this.panel_dibujo.Size = new System.Drawing.Size(301, 301);
            this.panel_dibujo.TabIndex = 0;
            this.panel_dibujo.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_dibujo_Paint);
            this.panel_dibujo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_dibujo_MouseMove);
            this.panel_dibujo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_dibujo_MouseDown);
            this.panel_dibujo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_dibujo_MouseUp);
            // 
            // boton_reconocer_figura
            // 
            this.boton_reconocer_figura.Enabled = false;
            this.boton_reconocer_figura.Location = new System.Drawing.Point(89, 356);
            this.boton_reconocer_figura.Name = "boton_reconocer_figura";
            this.boton_reconocer_figura.Size = new System.Drawing.Size(75, 23);
            this.boton_reconocer_figura.TabIndex = 2;
            this.boton_reconocer_figura.Text = "Reconocer";
            this.boton_reconocer_figura.UseVisualStyleBackColor = true;
            this.boton_reconocer_figura.Click += new System.EventHandler(this.boton_reconocer_figura_Click);
            // 
            // boton_limpiar_panel
            // 
            this.boton_limpiar_panel.Enabled = false;
            this.boton_limpiar_panel.Location = new System.Drawing.Point(171, 355);
            this.boton_limpiar_panel.Name = "boton_limpiar_panel";
            this.boton_limpiar_panel.Size = new System.Drawing.Size(75, 23);
            this.boton_limpiar_panel.TabIndex = 5;
            this.boton_limpiar_panel.Text = "Limpiar";
            this.boton_limpiar_panel.UseVisualStyleBackColor = true;
            this.boton_limpiar_panel.Click += new System.EventHandler(this.boton_limpiar_panel_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.campo_resultado_ejecucion_cp);
            this.groupBox9.Controls.Add(this.label30);
            this.groupBox9.Controls.Add(this.campo_tiempo_ejecucion_cp);
            this.groupBox9.Controls.Add(this.label31);
            this.groupBox9.Controls.Add(this.label32);
            this.groupBox9.Controls.Add(this.groupBox10);
            this.groupBox9.Location = new System.Drawing.Point(756, 18);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(405, 412);
            this.groupBox9.TabIndex = 19;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Configuración Red Neuronal de ContraPropagación";
            // 
            // campo_resultado_ejecucion_cp
            // 
            this.campo_resultado_ejecucion_cp.Location = new System.Drawing.Point(139, 210);
            this.campo_resultado_ejecucion_cp.Name = "campo_resultado_ejecucion_cp";
            this.campo_resultado_ejecucion_cp.Size = new System.Drawing.Size(100, 100);
            this.campo_resultado_ejecucion_cp.TabIndex = 20;
            this.campo_resultado_ejecucion_cp.TabStop = false;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(251, 355);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(53, 13);
            this.label30.TabIndex = 18;
            this.label30.Text = "segundos";
            // 
            // campo_tiempo_ejecucion_cp
            // 
            this.campo_tiempo_ejecucion_cp.BackColor = System.Drawing.SystemColors.Window;
            this.campo_tiempo_ejecucion_cp.Location = new System.Drawing.Point(159, 355);
            this.campo_tiempo_ejecucion_cp.Name = "campo_tiempo_ejecucion_cp";
            this.campo_tiempo_ejecucion_cp.ReadOnly = true;
            this.campo_tiempo_ejecucion_cp.Size = new System.Drawing.Size(86, 20);
            this.campo_tiempo_ejecucion_cp.TabIndex = 17;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(21, 355);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(128, 13);
            this.label31.TabIndex = 16;
            this.label31.Text = "Tiempo final de ejecución";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(159, 189);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(55, 13);
            this.label32.TabIndex = 14;
            this.label32.Text = "Resultado";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.boton_estabalecer_pesos_ejecucion_cp);
            this.groupBox10.Controls.Add(this.boton_elegir_pesos_ejecucion_cp);
            this.groupBox10.Controls.Add(this.campo_ruta_pesos_ejecucion_cp);
            this.groupBox10.Location = new System.Drawing.Point(8, 60);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(340, 96);
            this.groupBox10.TabIndex = 15;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Ruta del archivo de pesos de la red neuronal contrapropagación";
            // 
            // boton_estabalecer_pesos_ejecucion_cp
            // 
            this.boton_estabalecer_pesos_ejecucion_cp.Enabled = false;
            this.boton_estabalecer_pesos_ejecucion_cp.Location = new System.Drawing.Point(140, 54);
            this.boton_estabalecer_pesos_ejecucion_cp.Name = "boton_estabalecer_pesos_ejecucion_cp";
            this.boton_estabalecer_pesos_ejecucion_cp.Size = new System.Drawing.Size(75, 23);
            this.boton_estabalecer_pesos_ejecucion_cp.TabIndex = 2;
            this.boton_estabalecer_pesos_ejecucion_cp.Text = "Establecer";
            this.boton_estabalecer_pesos_ejecucion_cp.UseVisualStyleBackColor = true;
            this.boton_estabalecer_pesos_ejecucion_cp.Click += new System.EventHandler(this.boton_estabalecer_pesos_ejecucion_cp_Click);
            // 
            // boton_elegir_pesos_ejecucion_cp
            // 
            this.boton_elegir_pesos_ejecucion_cp.Location = new System.Drawing.Point(307, 18);
            this.boton_elegir_pesos_ejecucion_cp.Name = "boton_elegir_pesos_ejecucion_cp";
            this.boton_elegir_pesos_ejecucion_cp.Size = new System.Drawing.Size(27, 23);
            this.boton_elegir_pesos_ejecucion_cp.TabIndex = 1;
            this.boton_elegir_pesos_ejecucion_cp.Text = "...";
            this.boton_elegir_pesos_ejecucion_cp.UseVisualStyleBackColor = true;
            this.boton_elegir_pesos_ejecucion_cp.Click += new System.EventHandler(this.boton_elegir_pesos_ejecucion_cp_Click);
            // 
            // campo_ruta_pesos_ejecucion_cp
            // 
            this.campo_ruta_pesos_ejecucion_cp.Location = new System.Drawing.Point(7, 20);
            this.campo_ruta_pesos_ejecucion_cp.Name = "campo_ruta_pesos_ejecucion_cp";
            this.campo_ruta_pesos_ejecucion_cp.Size = new System.Drawing.Size(294, 20);
            this.campo_ruta_pesos_ejecucion_cp.TabIndex = 0;
            this.campo_ruta_pesos_ejecucion_cp.TextChanged += new System.EventHandler(this.campo_ruta_pesos_ejecucion_cp_TextChanged);
            // 
            // ventana_elegir_ruta_muestras
            // 
            this.ventana_elegir_ruta_muestras.DefaultExt = "cm";
            this.ventana_elegir_ruta_muestras.Filter = "\"Conjunto Muestras(*.cm)|*.cm|All files (*.*)|*.*\"";
            this.ventana_elegir_ruta_muestras.InitialDirectory = "Muestras";
            this.ventana_elegir_ruta_muestras.Title = "Elegir Conjunto de Muestras";
            // 
            // veantana_elegir_ruta_pesos
            // 
            this.veantana_elegir_ruta_pesos.DefaultExt = "ap";
            this.veantana_elegir_ruta_pesos.Filter = "\"Archivo Pesos(*.ap)|*.ap|All files (*.*)|*.*\"";
            this.veantana_elegir_ruta_pesos.InitialDirectory = "Pesos";
            this.veantana_elegir_ruta_pesos.Title = "Elegir el archivo de los pesos de la red";
            // 
            // panel_crear_muestras
            // 
            this.panel_crear_muestras.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel_crear_muestras.Controls.Add(this.campo_iteraciones_muestras);
            this.panel_crear_muestras.Controls.Add(this.label19);
            this.panel_crear_muestras.Controls.Add(this.boton_cancelar_muestras);
            this.panel_crear_muestras.Controls.Add(this.label15);
            this.panel_crear_muestras.Controls.Add(this.label14);
            this.panel_crear_muestras.Controls.Add(this.boton_guardar_muestras);
            this.panel_crear_muestras.Controls.Add(this.label13);
            this.panel_crear_muestras.Controls.Add(this.groupBox5);
            this.panel_crear_muestras.Location = new System.Drawing.Point(0, 27);
            this.panel_crear_muestras.Name = "panel_crear_muestras";
            this.panel_crear_muestras.Size = new System.Drawing.Size(1176, 460);
            this.panel_crear_muestras.TabIndex = 4;
            this.panel_crear_muestras.Visible = false;
            // 
            // campo_iteraciones_muestras
            // 
            this.campo_iteraciones_muestras.BackColor = System.Drawing.SystemColors.Window;
            this.campo_iteraciones_muestras.Enabled = false;
            this.campo_iteraciones_muestras.Location = new System.Drawing.Point(848, 234);
            this.campo_iteraciones_muestras.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.campo_iteraciones_muestras.Name = "campo_iteraciones_muestras";
            this.campo_iteraciones_muestras.ReadOnly = true;
            this.campo_iteraciones_muestras.Size = new System.Drawing.Size(75, 20);
            this.campo_iteraciones_muestras.TabIndex = 18;
            this.campo_iteraciones_muestras.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(667, 234);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(173, 13);
            this.label19.TabIndex = 17;
            this.label19.Text = "Número de iteraciones de muestras";
            // 
            // boton_cancelar_muestras
            // 
            this.boton_cancelar_muestras.Location = new System.Drawing.Point(844, 345);
            this.boton_cancelar_muestras.Name = "boton_cancelar_muestras";
            this.boton_cancelar_muestras.Size = new System.Drawing.Size(101, 23);
            this.boton_cancelar_muestras.TabIndex = 16;
            this.boton_cancelar_muestras.Text = "Cancelar";
            this.boton_cancelar_muestras.UseVisualStyleBackColor = true;
            this.boton_cancelar_muestras.Click += new System.EventHandler(this.boton_cancelar_muestras_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(664, 153);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(241, 13);
            this.label15.TabIndex = 15;
            this.label15.Text = "esto por cada una de las iteraciones de muestras.";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(664, 132);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(337, 13);
            this.label14.TabIndex = 14;
            this.label14.Text = "Debe de ingresar al menos una muestra para cada una de las figuras, ";
            // 
            // boton_guardar_muestras
            // 
            this.boton_guardar_muestras.Location = new System.Drawing.Point(739, 345);
            this.boton_guardar_muestras.Name = "boton_guardar_muestras";
            this.boton_guardar_muestras.Size = new System.Drawing.Size(101, 23);
            this.boton_guardar_muestras.TabIndex = 13;
            this.boton_guardar_muestras.Text = "Guardar muestras";
            this.boton_guardar_muestras.UseVisualStyleBackColor = true;
            this.boton_guardar_muestras.Click += new System.EventHandler(this.boton_guardar_muestras_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(664, 99);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 17);
            this.label13.TabIndex = 12;
            this.label13.Text = "Nota: ";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.campo_muestra);
            this.groupBox5.Controls.Add(this.panel_dibujo_muestra);
            this.groupBox5.Controls.Add(this.boton_guardar_muestra);
            this.groupBox5.Controls.Add(this.boton_limpiar_panel_muestra);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Location = new System.Drawing.Point(175, 18);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(468, 425);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ingrese la muestra";
            // 
            // campo_muestra
            // 
            this.campo_muestra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.campo_muestra.Location = new System.Drawing.Point(215, 15);
            this.campo_muestra.Name = "campo_muestra";
            this.campo_muestra.Size = new System.Drawing.Size(50, 50);
            this.campo_muestra.TabIndex = 12;
            this.campo_muestra.TabStop = false;
            // 
            // panel_dibujo_muestra
            // 
            this.panel_dibujo_muestra.BackColor = System.Drawing.SystemColors.Window;
            this.panel_dibujo_muestra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_dibujo_muestra.Location = new System.Drawing.Point(85, 79);
            this.panel_dibujo_muestra.Name = "panel_dibujo_muestra";
            this.panel_dibujo_muestra.Size = new System.Drawing.Size(301, 301);
            this.panel_dibujo_muestra.TabIndex = 0;
            this.panel_dibujo_muestra.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_dibujo_Paint);
            this.panel_dibujo_muestra.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_dibujo_MouseMove);
            this.panel_dibujo_muestra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_dibujo_MouseDown);
            this.panel_dibujo_muestra.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_dibujo_MouseUp);
            // 
            // boton_guardar_muestra
            // 
            this.boton_guardar_muestra.Enabled = false;
            this.boton_guardar_muestra.Location = new System.Drawing.Point(136, 392);
            this.boton_guardar_muestra.Name = "boton_guardar_muestra";
            this.boton_guardar_muestra.Size = new System.Drawing.Size(99, 23);
            this.boton_guardar_muestra.TabIndex = 2;
            this.boton_guardar_muestra.Text = "Guardar Muestra";
            this.boton_guardar_muestra.UseVisualStyleBackColor = true;
            this.boton_guardar_muestra.Click += new System.EventHandler(this.boton_guardar_muestra_Click);
            // 
            // boton_limpiar_panel_muestra
            // 
            this.boton_limpiar_panel_muestra.Enabled = false;
            this.boton_limpiar_panel_muestra.Location = new System.Drawing.Point(241, 392);
            this.boton_limpiar_panel_muestra.Name = "boton_limpiar_panel_muestra";
            this.boton_limpiar_panel_muestra.Size = new System.Drawing.Size(99, 23);
            this.boton_limpiar_panel_muestra.TabIndex = 5;
            this.boton_limpiar_panel_muestra.Text = "Limpiar";
            this.boton_limpiar_panel_muestra.UseVisualStyleBackColor = true;
            this.boton_limpiar_panel_muestra.Click += new System.EventHandler(this.boton_limpiar_panel_muestra_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(82, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Ingrese una muestra para";
            // 
            // ventana_salvar_muestras
            // 
            this.ventana_salvar_muestras.DefaultExt = "cm";
            this.ventana_salvar_muestras.FileName = "Nueva Muestra";
            this.ventana_salvar_muestras.Filter = "\"Conjunto Muestras(*.cm)|*.cm|All files (*.*)|*.*\"";
            this.ventana_salvar_muestras.InitialDirectory = "Muestras";
            // 
            // panel_muestra_entrenamiento_bp
            // 
            this.panel_muestra_entrenamiento_bp.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel_muestra_entrenamiento_bp.Controls.Add(this.boton_abortar_entrenamiento);
            this.panel_muestra_entrenamiento_bp.Controls.Add(this.campo_iteraciones_entrenamiento);
            this.panel_muestra_entrenamiento_bp.Controls.Add(this.label18);
            this.panel_muestra_entrenamiento_bp.Controls.Add(this.label16);
            this.panel_muestra_entrenamiento_bp.Controls.Add(this.campo_tiempo_entrenamiento);
            this.panel_muestra_entrenamiento_bp.Controls.Add(this.label17);
            this.panel_muestra_entrenamiento_bp.Controls.Add(this.groupBox8);
            this.panel_muestra_entrenamiento_bp.Location = new System.Drawing.Point(0, 27);
            this.panel_muestra_entrenamiento_bp.Name = "panel_muestra_entrenamiento_bp";
            this.panel_muestra_entrenamiento_bp.Size = new System.Drawing.Size(1176, 460);
            this.panel_muestra_entrenamiento_bp.TabIndex = 17;
            this.panel_muestra_entrenamiento_bp.VisibleChanged += new System.EventHandler(this.panel_muestra_entrenamiento_VisibleChanged);
            // 
            // boton_abortar_entrenamiento
            // 
            this.boton_abortar_entrenamiento.Location = new System.Drawing.Point(549, 393);
            this.boton_abortar_entrenamiento.Name = "boton_abortar_entrenamiento";
            this.boton_abortar_entrenamiento.Size = new System.Drawing.Size(75, 23);
            this.boton_abortar_entrenamiento.TabIndex = 19;
            this.boton_abortar_entrenamiento.Text = "Abortar";
            this.boton_abortar_entrenamiento.UseVisualStyleBackColor = true;
            this.boton_abortar_entrenamiento.Click += new System.EventHandler(this.boton_abortar_entrenamiento_Click);
            // 
            // campo_iteraciones_entrenamiento
            // 
            this.campo_iteraciones_entrenamiento.BackColor = System.Drawing.SystemColors.Window;
            this.campo_iteraciones_entrenamiento.Enabled = false;
            this.campo_iteraciones_entrenamiento.Location = new System.Drawing.Point(428, 329);
            this.campo_iteraciones_entrenamiento.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.campo_iteraciones_entrenamiento.Name = "campo_iteraciones_entrenamiento";
            this.campo_iteraciones_entrenamiento.ReadOnly = true;
            this.campo_iteraciones_entrenamiento.Size = new System.Drawing.Size(86, 20);
            this.campo_iteraciones_entrenamiento.TabIndex = 18;
            this.campo_iteraciones_entrenamiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(267, 331);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(156, 13);
            this.label18.TabIndex = 17;
            this.label18.Text = "Número de iteraciones actuales";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(853, 331);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 13);
            this.label16.TabIndex = 15;
            this.label16.Text = "segundos";
            // 
            // campo_tiempo_entrenamiento
            // 
            this.campo_tiempo_entrenamiento.BackColor = System.Drawing.SystemColors.Window;
            this.campo_tiempo_entrenamiento.Location = new System.Drawing.Point(761, 331);
            this.campo_tiempo_entrenamiento.Name = "campo_tiempo_entrenamiento";
            this.campo_tiempo_entrenamiento.ReadOnly = true;
            this.campo_tiempo_entrenamiento.Size = new System.Drawing.Size(86, 20);
            this.campo_tiempo_entrenamiento.TabIndex = 14;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(600, 331);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(149, 13);
            this.label17.TabIndex = 13;
            this.label17.Text = "Tiempo final de entrenamiento";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label29);
            this.groupBox8.Controls.Add(this.label28);
            this.groupBox8.Controls.Add(this.label27);
            this.groupBox8.Controls.Add(this.label26);
            this.groupBox8.Controls.Add(this.label25);
            this.groupBox8.Controls.Add(this.label24);
            this.groupBox8.Controls.Add(this.label23);
            this.groupBox8.Controls.Add(this.label22);
            this.groupBox8.Controls.Add(this.label21);
            this.groupBox8.Controls.Add(this.label20);
            this.groupBox8.Controls.Add(this.panel_grafico_error);
            this.groupBox8.Location = new System.Drawing.Point(158, 45);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(860, 258);
            this.groupBox8.TabIndex = 1;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Gráfico de error";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.Transparent;
            this.label29.ForeColor = System.Drawing.Color.Navy;
            this.label29.Location = new System.Drawing.Point(10, 136);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(10, 13);
            this.label29.TabIndex = 10;
            this.label29.Text = "r";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.Transparent;
            this.label28.ForeColor = System.Drawing.Color.Navy;
            this.label28.Location = new System.Drawing.Point(10, 108);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(10, 13);
            this.label28.TabIndex = 9;
            this.label28.Text = "r";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.ForeColor = System.Drawing.Color.Navy;
            this.label27.Location = new System.Drawing.Point(10, 94);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(10, 13);
            this.label27.TabIndex = 8;
            this.label27.Text = "r";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.ForeColor = System.Drawing.Color.Navy;
            this.label26.Location = new System.Drawing.Point(9, 122);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(13, 13);
            this.label26.TabIndex = 7;
            this.label26.Text = "o";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.ForeColor = System.Drawing.Color.Navy;
            this.label25.Location = new System.Drawing.Point(9, 83);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(14, 13);
            this.label25.TabIndex = 6;
            this.label25.Text = "E";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.ForeColor = System.Drawing.Color.Navy;
            this.label24.Location = new System.Drawing.Point(381, 229);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(98, 13);
            this.label24.TabIndex = 5;
            this.label24.Text = "Número iteraciones";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.ForeColor = System.Drawing.Color.Navy;
            this.label23.Location = new System.Drawing.Point(831, 223);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(25, 13);
            this.label23.TabIndex = 4;
            this.label23.Text = "800";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.Color.Navy;
            this.label22.Location = new System.Drawing.Point(16, 210);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(13, 13);
            this.label22.TabIndex = 3;
            this.label22.Text = "0";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.Color.Navy;
            this.label21.Location = new System.Drawing.Point(16, 16);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(13, 13);
            this.label21.TabIndex = 2;
            this.label21.Text = "1";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.Navy;
            this.label20.Location = new System.Drawing.Point(27, 223);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(13, 13);
            this.label20.TabIndex = 1;
            this.label20.Text = "0";
            // 
            // panel_grafico_error
            // 
            this.panel_grafico_error.BackColor = System.Drawing.Color.White;
            this.panel_grafico_error.Location = new System.Drawing.Point(30, 20);
            this.panel_grafico_error.Name = "panel_grafico_error";
            this.panel_grafico_error.Size = new System.Drawing.Size(800, 200);
            this.panel_grafico_error.TabIndex = 0;
            // 
            // ventana_salvar_pesos
            // 
            this.ventana_salvar_pesos.DefaultExt = "ap";
            this.ventana_salvar_pesos.FileName = "Nuevos Pesos";
            this.ventana_salvar_pesos.Filter = "\"Archivo Pesos(*.ap)|*.ap|All files (*.*)|*.*\"";
            this.ventana_salvar_pesos.InitialDirectory = "Pesos";
            this.ventana_salvar_pesos.Title = "Guardar Pesos";
            // 
            // panel_entrenamiento_cp
            // 
            this.panel_entrenamiento_cp.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel_entrenamiento_cp.Controls.Add(this.num_it_entr_cp);
            this.panel_entrenamiento_cp.Controls.Add(this.label39);
            this.panel_entrenamiento_cp.Controls.Add(this.label40);
            this.panel_entrenamiento_cp.Controls.Add(this.tiempo_final_entr_cp);
            this.panel_entrenamiento_cp.Controls.Add(this.label42);
            this.panel_entrenamiento_cp.Location = new System.Drawing.Point(0, 25);
            this.panel_entrenamiento_cp.Name = "panel_entrenamiento_cp";
            this.panel_entrenamiento_cp.Size = new System.Drawing.Size(1176, 460);
            this.panel_entrenamiento_cp.TabIndex = 18;
            this.panel_entrenamiento_cp.Visible = false;
            // 
            // num_it_entr_cp
            // 
            this.num_it_entr_cp.BackColor = System.Drawing.SystemColors.Window;
            this.num_it_entr_cp.Enabled = false;
            this.num_it_entr_cp.Location = new System.Drawing.Point(430, 187);
            this.num_it_entr_cp.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.num_it_entr_cp.Name = "num_it_entr_cp";
            this.num_it_entr_cp.ReadOnly = true;
            this.num_it_entr_cp.Size = new System.Drawing.Size(86, 20);
            this.num_it_entr_cp.TabIndex = 18;
            this.num_it_entr_cp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(269, 189);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(156, 13);
            this.label39.TabIndex = 17;
            this.label39.Text = "Número de iteraciones actuales";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(855, 189);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(53, 13);
            this.label40.TabIndex = 15;
            this.label40.Text = "segundos";
            // 
            // tiempo_final_entr_cp
            // 
            this.tiempo_final_entr_cp.BackColor = System.Drawing.SystemColors.Window;
            this.tiempo_final_entr_cp.Location = new System.Drawing.Point(763, 189);
            this.tiempo_final_entr_cp.Name = "tiempo_final_entr_cp";
            this.tiempo_final_entr_cp.ReadOnly = true;
            this.tiempo_final_entr_cp.Size = new System.Drawing.Size(86, 20);
            this.tiempo_final_entr_cp.TabIndex = 14;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(602, 189);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(149, 13);
            this.label42.TabIndex = 13;
            this.label42.Text = "Tiempo final de entrenamiento";
            // 
            // imagenes_figuras
            // 
            this.imagenes_figuras.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imagenes_figuras.ImageStream")));
            this.imagenes_figuras.TransparentColor = System.Drawing.Color.Transparent;
            this.imagenes_figuras.Images.SetKeyName(0, "Circulo.png");
            this.imagenes_figuras.Images.SetKeyName(1, "Triangulo.png");
            this.imagenes_figuras.Images.SetKeyName(2, "Cuadrado.png");
            this.imagenes_figuras.Images.SetKeyName(3, "pentagono.png");
            this.imagenes_figuras.Images.SetKeyName(4, "Hexagono.png");
            this.imagenes_figuras.Images.SetKeyName(5, "error.png");
            // 
            // I_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1176, 510);
            this.Controls.Add(this.barra_estado);
            this.Controls.Add(this.menu_principal);
            this.Controls.Add(this.panel_entrenamiento);
            this.Controls.Add(this.panel_entrenamiento_cp);
            this.Controls.Add(this.panel_muestra_entrenamiento_bp);
            this.Controls.Add(this.panel_crear_muestras);
            this.Controls.Add(this.panel_ejecucion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu_principal;
            this.MaximizeBox = false;
            this.Name = "I_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Red Neuronal";
            this.Load += new System.EventHandler(this.I_Principal_Load);
            this.menu_principal.ResumeLayout(false);
            this.menu_principal.PerformLayout();
            this.panel_entrenamiento.ResumeLayout(false);
            this.panel_entrenamiento.PerformLayout();
            this.configuracion_red_cp.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.campo_cant_salida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.campo_cant_ocult_cp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.campo_cant_entrada_cp)).EndInit();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.campo_alpha_cp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_capa_oculta_cp)).EndInit();
            this.configuracion_red_bp.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.campo_neuronas_salida_bp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.campo_neuronas_intermedia_bp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.campo_neuronas_entrada_bp)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.campo_error_bp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.campo_aprendizaje_bp)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.campo_IniPesos_Hasta_bp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.campo_IniPesos_Desde_bp)).EndInit();
            this.panel_ejecucion.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.campo_resultado_ejecucion_bp)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox_Dibujo.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.campo_resultado_ejecucion_cp)).EndInit();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.panel_crear_muestras.ResumeLayout(false);
            this.panel_crear_muestras.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.campo_iteraciones_muestras)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.campo_muestra)).EndInit();
            this.panel_muestra_entrenamiento_bp.ResumeLayout(false);
            this.panel_muestra_entrenamiento_bp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.campo_iteraciones_entrenamiento)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.panel_entrenamiento_cp.ResumeLayout(false);
            this.panel_entrenamiento_cp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_it_entr_cp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip barra_estado;
        private System.Windows.Forms.MenuStrip menu_principal;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_salir;
        private System.Windows.Forms.ToolStripMenuItem acciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_entrenamiento;
        private System.Windows.Forms.ToolStripMenuItem menu_ejecucion;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_acerca_de;
        private System.Windows.Forms.Panel panel_entrenamiento;
        private System.Windows.Forms.GroupBox configuracion_red_bp;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown campo_error_bp;
        private System.Windows.Forms.NumericUpDown campo_aprendizaje_bp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown campo_IniPesos_Hasta_bp;
        private System.Windows.Forms.NumericUpDown campo_IniPesos_Desde_bp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox campo_ruta_muestras_bp;
        private System.Windows.Forms.Button boton_elegir_ruta_muestras_bp;
        private System.Windows.Forms.NumericUpDown campo_neuronas_salida_bp;
        private System.Windows.Forms.NumericUpDown campo_neuronas_intermedia_bp;
        private System.Windows.Forms.NumericUpDown campo_neuronas_entrada_bp;
        private System.Windows.Forms.Button boton_crear_muestras_bp;
        private System.Windows.Forms.Button boton_entrenar_bp;
        private System.Windows.Forms.Panel panel_ejecucion;
        private System.Windows.Forms.Panel panel_dibujo;
        private System.Windows.Forms.Button boton_reconocer_figura;
        private System.Windows.Forms.Button boton_limpiar_panel;
        private System.Windows.Forms.GroupBox groupBox_Dibujo;
        private System.Windows.Forms.OpenFileDialog ventana_elegir_ruta_muestras;
        private System.Windows.Forms.OpenFileDialog veantana_elegir_ruta_pesos;
        private System.Windows.Forms.Panel panel_crear_muestras;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Panel panel_dibujo_muestra;
        private System.Windows.Forms.Button boton_guardar_muestra;
        private System.Windows.Forms.Button boton_limpiar_panel_muestra;
        private System.Windows.Forms.Button boton_guardar_muestras;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button boton_cancelar_muestras;
        private System.Windows.Forms.SaveFileDialog ventana_salvar_muestras;
        private System.Windows.Forms.Panel panel_muestra_entrenamiento_bp;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox campo_tiempo_entrenamiento;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Panel panel_grafico_error;
        private System.Windows.Forms.SaveFileDialog ventana_salvar_pesos;
        private System.Windows.Forms.NumericUpDown campo_iteraciones_entrenamiento;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown campo_iteraciones_muestras;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button boton_abortar_entrenamiento;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox campo_tiempo_ejecucion_cp;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Button boton_estabalecer_pesos_ejecucion_cp;
        private System.Windows.Forms.Button boton_elegir_pesos_ejecucion_cp;
        private System.Windows.Forms.TextBox campo_ruta_pesos_ejecucion_cp;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox campo_tiempo_ejecucion_bp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button boton_estabalecer_pesos_ejecucion_bp;
        private System.Windows.Forms.Button boton_elegir_pesos_ejecucion_bp;
        private System.Windows.Forms.TextBox campo_ruta_pesos_ejecucion_bp;
        private System.Windows.Forms.ComboBox campo_elegir_tipo_red;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.GroupBox configuracion_red_cp;
        private System.Windows.Forms.Button boton_entrenar_cp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown campo_cant_salida;
        private System.Windows.Forms.NumericUpDown campo_cant_ocult_cp;
        private System.Windows.Forms.NumericUpDown campo_cant_entrada_cp;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Button boton_crear_muestras_cp;
        private System.Windows.Forms.Button boton_elegir_ruta_muestras_cp;
        private System.Windows.Forms.TextBox campo_ruta_muestras_cp;
        private System.Windows.Forms.NumericUpDown campo_alpha_cp;
        private System.Windows.Forms.NumericUpDown error_capa_oculta_cp;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Panel panel_entrenamiento_cp;
        private System.Windows.Forms.NumericUpDown num_it_entr_cp;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.TextBox tiempo_final_entr_cp;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.PictureBox campo_muestra;
        private System.Windows.Forms.PictureBox campo_resultado_ejecucion_bp;
        private System.Windows.Forms.PictureBox campo_resultado_ejecucion_cp;
        private System.Windows.Forms.ImageList imagenes_figuras;
    }
}

