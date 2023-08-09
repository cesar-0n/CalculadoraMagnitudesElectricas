namespace CalculadoraMagnitudesElectricas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.numericUpDown_tension = new System.Windows.Forms.NumericUpDown();
            this.label_tensionVTXT = new System.Windows.Forms.Label();
            this.label_intensidadATXT = new System.Windows.Forms.Label();
            this.numericUpDown_intensidad = new System.Windows.Forms.NumericUpDown();
            this.label_resistenciaRTXT = new System.Windows.Forms.Label();
            this.numericUpDown_resistencia = new System.Windows.Forms.NumericUpDown();
            this.label_cosFiTXT = new System.Windows.Forms.Label();
            this.numericUpDown_cosFi = new System.Windows.Forms.NumericUpDown();
            this.label_potActivaWTXT = new System.Windows.Forms.Label();
            this.numericUpDown_potenciaActiva = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button_calcular = new System.Windows.Forms.Button();
            this.button_borrar = new System.Windows.Forms.Button();
            this.label_potenciaActiva = new System.Windows.Forms.Label();
            this.label_resistencia = new System.Windows.Forms.Label();
            this.label_intensidad = new System.Windows.Forms.Label();
            this.label_tension = new System.Windows.Forms.Label();
            this.label_tensionTXT = new System.Windows.Forms.Label();
            this.label_intensidadTXT = new System.Windows.Forms.Label();
            this.label_resistenciaTXT = new System.Windows.Forms.Label();
            this.label_potenciaTXT = new System.Windows.Forms.Label();
            this.label_potenciaReactivaTXT2 = new System.Windows.Forms.Label();
            this.label_potenciaReactiva = new System.Windows.Forms.Label();
            this.label_potenciaAparenteTXT2 = new System.Windows.Forms.Label();
            this.label_potenciaAparente = new System.Windows.Forms.Label();
            this.label_anguloFi = new System.Windows.Forms.Label();
            this.label_anguloFiTXT2 = new System.Windows.Forms.Label();
            this.label_cosFi = new System.Windows.Forms.Label();
            this.label_cosFiTXT2 = new System.Windows.Forms.Label();
            this.label_anguloFiTXT = new System.Windows.Forms.Label();
            this.label_potenciaAparenteTXT = new System.Windows.Forms.Label();
            this.label_potenciaReactivaTXT = new System.Windows.Forms.Label();
            this.numericUpDown_anguloFi = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_potenciaAparente = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_potenciaReactiva = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem_Archivo = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Editar = new System.Windows.Forms.ToolStripMenuItem();
            this.despejarCeldasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calcularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Ver = new System.Windows.Forms.ToolStripMenuItem();
            this.MostrarControlesDePotenciaAvanzadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ShowDeveloperConsoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calcularFormulasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateAnotherCycleWithCalcularButtonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_tension)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_intensidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_resistencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_cosFi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_potenciaActiva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_anguloFi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_potenciaAparente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_potenciaReactiva)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // numericUpDown_tension
            // 
            this.numericUpDown_tension.DecimalPlaces = 4;
            this.numericUpDown_tension.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_tension.Location = new System.Drawing.Point(12, 51);
            this.numericUpDown_tension.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.numericUpDown_tension.Name = "numericUpDown_tension";
            this.numericUpDown_tension.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown_tension.TabIndex = 0;
            this.numericUpDown_tension.ValueChanged += new System.EventHandler(this.numericUpDown_tension_ValueChanged);
            // 
            // label_tensionVTXT
            // 
            this.label_tensionVTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tensionVTXT.Location = new System.Drawing.Point(9, 32);
            this.label_tensionVTXT.Name = "label_tensionVTXT";
            this.label_tensionVTXT.Size = new System.Drawing.Size(123, 16);
            this.label_tensionVTXT.TabIndex = 1;
            this.label_tensionVTXT.Text = "Tensión (V)";
            this.label_tensionVTXT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_intensidadATXT
            // 
            this.label_intensidadATXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_intensidadATXT.Location = new System.Drawing.Point(135, 32);
            this.label_intensidadATXT.Name = "label_intensidadATXT";
            this.label_intensidadATXT.Size = new System.Drawing.Size(123, 16);
            this.label_intensidadATXT.TabIndex = 3;
            this.label_intensidadATXT.Text = "Intensidad (A)";
            this.label_intensidadATXT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDown_intensidad
            // 
            this.numericUpDown_intensidad.DecimalPlaces = 4;
            this.numericUpDown_intensidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_intensidad.Location = new System.Drawing.Point(138, 51);
            this.numericUpDown_intensidad.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.numericUpDown_intensidad.Name = "numericUpDown_intensidad";
            this.numericUpDown_intensidad.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numericUpDown_intensidad.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown_intensidad.TabIndex = 2;
            this.numericUpDown_intensidad.ValueChanged += new System.EventHandler(this.numericUpDown_intensidad_ValueChanged);
            // 
            // label_resistenciaRTXT
            // 
            this.label_resistenciaRTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_resistenciaRTXT.Location = new System.Drawing.Point(9, 84);
            this.label_resistenciaRTXT.Name = "label_resistenciaRTXT";
            this.label_resistenciaRTXT.Size = new System.Drawing.Size(123, 16);
            this.label_resistenciaRTXT.TabIndex = 5;
            this.label_resistenciaRTXT.Text = "Resistencia (Ω)";
            this.label_resistenciaRTXT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDown_resistencia
            // 
            this.numericUpDown_resistencia.DecimalPlaces = 4;
            this.numericUpDown_resistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_resistencia.Location = new System.Drawing.Point(12, 103);
            this.numericUpDown_resistencia.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.numericUpDown_resistencia.Name = "numericUpDown_resistencia";
            this.numericUpDown_resistencia.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown_resistencia.TabIndex = 4;
            this.numericUpDown_resistencia.ValueChanged += new System.EventHandler(this.numericUpDown_resistencia_ValueChanged);
            // 
            // label_cosFiTXT
            // 
            this.label_cosFiTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cosFiTXT.Location = new System.Drawing.Point(435, 32);
            this.label_cosFiTXT.Name = "label_cosFiTXT";
            this.label_cosFiTXT.Size = new System.Drawing.Size(123, 16);
            this.label_cosFiTXT.TabIndex = 11;
            this.label_cosFiTXT.Text = "F.P. (Cos φ)";
            this.label_cosFiTXT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDown_cosFi
            // 
            this.numericUpDown_cosFi.DecimalPlaces = 4;
            this.numericUpDown_cosFi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_cosFi.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_cosFi.Location = new System.Drawing.Point(438, 51);
            this.numericUpDown_cosFi.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_cosFi.Name = "numericUpDown_cosFi";
            this.numericUpDown_cosFi.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown_cosFi.TabIndex = 10;
            this.numericUpDown_cosFi.ValueChanged += new System.EventHandler(this.numericUpDown_cosFi_ValueChanged);
            // 
            // label_potActivaWTXT
            // 
            this.label_potActivaWTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_potActivaWTXT.Location = new System.Drawing.Point(135, 84);
            this.label_potActivaWTXT.Name = "label_potActivaWTXT";
            this.label_potActivaWTXT.Size = new System.Drawing.Size(133, 16);
            this.label_potActivaWTXT.TabIndex = 7;
            this.label_potActivaWTXT.Text = "Potencia activa (W)";
            this.label_potActivaWTXT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDown_potenciaActiva
            // 
            this.numericUpDown_potenciaActiva.DecimalPlaces = 4;
            this.numericUpDown_potenciaActiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_potenciaActiva.Location = new System.Drawing.Point(138, 103);
            this.numericUpDown_potenciaActiva.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.numericUpDown_potenciaActiva.Name = "numericUpDown_potenciaActiva";
            this.numericUpDown_potenciaActiva.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown_potenciaActiva.TabIndex = 6;
            this.numericUpDown_potenciaActiva.ValueChanged += new System.EventHandler(this.numericUpDown_potenciaActiva_ValueChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button_calcular
            // 
            this.button_calcular.BackColor = System.Drawing.Color.LimeGreen;
            this.button_calcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_calcular.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_calcular.Location = new System.Drawing.Point(171, 269);
            this.button_calcular.Name = "button_calcular";
            this.button_calcular.Size = new System.Drawing.Size(87, 31);
            this.button_calcular.TabIndex = 12;
            this.button_calcular.Text = "Calcular";
            this.button_calcular.UseVisualStyleBackColor = false;
            this.button_calcular.Click += new System.EventHandler(this.button_calcular_Click);
            // 
            // button_borrar
            // 
            this.button_borrar.BackColor = System.Drawing.Color.IndianRed;
            this.button_borrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_borrar.Location = new System.Drawing.Point(12, 277);
            this.button_borrar.Name = "button_borrar";
            this.button_borrar.Size = new System.Drawing.Size(103, 23);
            this.button_borrar.TabIndex = 13;
            this.button_borrar.Text = "Despejar celdas";
            this.button_borrar.UseVisualStyleBackColor = false;
            this.button_borrar.Click += new System.EventHandler(this.button_borrar_Click);
            // 
            // label_potenciaActiva
            // 
            this.label_potenciaActiva.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_potenciaActiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_potenciaActiva.Location = new System.Drawing.Point(138, 227);
            this.label_potenciaActiva.Name = "label_potenciaActiva";
            this.label_potenciaActiva.Size = new System.Drawing.Size(120, 23);
            this.label_potenciaActiva.TabIndex = 21;
            this.label_potenciaActiva.Text = "0 W";
            this.label_potenciaActiva.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_resistencia
            // 
            this.label_resistencia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_resistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_resistencia.Location = new System.Drawing.Point(12, 228);
            this.label_resistencia.Name = "label_resistencia";
            this.label_resistencia.Size = new System.Drawing.Size(120, 23);
            this.label_resistencia.TabIndex = 19;
            this.label_resistencia.Text = "0 Ω";
            this.label_resistencia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_intensidad
            // 
            this.label_intensidad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_intensidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_intensidad.Location = new System.Drawing.Point(138, 172);
            this.label_intensidad.Name = "label_intensidad";
            this.label_intensidad.Size = new System.Drawing.Size(120, 23);
            this.label_intensidad.TabIndex = 17;
            this.label_intensidad.Text = "0 A";
            this.label_intensidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_tension
            // 
            this.label_tension.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_tension.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tension.Location = new System.Drawing.Point(12, 172);
            this.label_tension.Name = "label_tension";
            this.label_tension.Size = new System.Drawing.Size(120, 23);
            this.label_tension.TabIndex = 26;
            this.label_tension.Text = "0 V";
            this.label_tension.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_tensionTXT
            // 
            this.label_tensionTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tensionTXT.Location = new System.Drawing.Point(9, 149);
            this.label_tensionTXT.Name = "label_tensionTXT";
            this.label_tensionTXT.Size = new System.Drawing.Size(123, 16);
            this.label_tensionTXT.TabIndex = 27;
            this.label_tensionTXT.Text = "Tensión";
            this.label_tensionTXT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_intensidadTXT
            // 
            this.label_intensidadTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_intensidadTXT.Location = new System.Drawing.Point(135, 149);
            this.label_intensidadTXT.Name = "label_intensidadTXT";
            this.label_intensidadTXT.Size = new System.Drawing.Size(123, 16);
            this.label_intensidadTXT.TabIndex = 28;
            this.label_intensidadTXT.Text = "Intensidad";
            this.label_intensidadTXT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_resistenciaTXT
            // 
            this.label_resistenciaTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_resistenciaTXT.Location = new System.Drawing.Point(9, 206);
            this.label_resistenciaTXT.Name = "label_resistenciaTXT";
            this.label_resistenciaTXT.Size = new System.Drawing.Size(123, 16);
            this.label_resistenciaTXT.TabIndex = 29;
            this.label_resistenciaTXT.Text = "Resistencia";
            this.label_resistenciaTXT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_potenciaTXT
            // 
            this.label_potenciaTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_potenciaTXT.Location = new System.Drawing.Point(135, 206);
            this.label_potenciaTXT.Name = "label_potenciaTXT";
            this.label_potenciaTXT.Size = new System.Drawing.Size(123, 16);
            this.label_potenciaTXT.TabIndex = 30;
            this.label_potenciaTXT.Text = "Potencia";
            this.label_potenciaTXT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_potenciaReactivaTXT2
            // 
            this.label_potenciaReactivaTXT2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_potenciaReactivaTXT2.Location = new System.Drawing.Point(438, 204);
            this.label_potenciaReactivaTXT2.Name = "label_potenciaReactivaTXT2";
            this.label_potenciaReactivaTXT2.Size = new System.Drawing.Size(123, 16);
            this.label_potenciaReactivaTXT2.TabIndex = 31;
            this.label_potenciaReactivaTXT2.Text = "Potencia reactiva";
            this.label_potenciaReactivaTXT2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_potenciaReactiva
            // 
            this.label_potenciaReactiva.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_potenciaReactiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_potenciaReactiva.Location = new System.Drawing.Point(438, 227);
            this.label_potenciaReactiva.Name = "label_potenciaReactiva";
            this.label_potenciaReactiva.Size = new System.Drawing.Size(120, 23);
            this.label_potenciaReactiva.TabIndex = 37;
            this.label_potenciaReactiva.Text = "0 VAR";
            this.label_potenciaReactiva.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_potenciaAparenteTXT2
            // 
            this.label_potenciaAparenteTXT2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_potenciaAparenteTXT2.Location = new System.Drawing.Point(309, 207);
            this.label_potenciaAparenteTXT2.Name = "label_potenciaAparenteTXT2";
            this.label_potenciaAparenteTXT2.Size = new System.Drawing.Size(123, 16);
            this.label_potenciaAparenteTXT2.TabIndex = 44;
            this.label_potenciaAparenteTXT2.Text = "Potencia aparente";
            this.label_potenciaAparenteTXT2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_potenciaAparente
            // 
            this.label_potenciaAparente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_potenciaAparente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_potenciaAparente.Location = new System.Drawing.Point(312, 228);
            this.label_potenciaAparente.Name = "label_potenciaAparente";
            this.label_potenciaAparente.Size = new System.Drawing.Size(120, 23);
            this.label_potenciaAparente.TabIndex = 43;
            this.label_potenciaAparente.Text = "0 VA";
            this.label_potenciaAparente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_anguloFi
            // 
            this.label_anguloFi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_anguloFi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_anguloFi.Location = new System.Drawing.Point(312, 172);
            this.label_anguloFi.Name = "label_anguloFi";
            this.label_anguloFi.Size = new System.Drawing.Size(120, 23);
            this.label_anguloFi.TabIndex = 42;
            this.label_anguloFi.Text = "0 °";
            this.label_anguloFi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_anguloFiTXT2
            // 
            this.label_anguloFiTXT2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_anguloFiTXT2.Location = new System.Drawing.Point(312, 149);
            this.label_anguloFiTXT2.Name = "label_anguloFiTXT2";
            this.label_anguloFiTXT2.Size = new System.Drawing.Size(123, 16);
            this.label_anguloFiTXT2.TabIndex = 41;
            this.label_anguloFiTXT2.Text = "Ángulo φ";
            this.label_anguloFiTXT2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_cosFi
            // 
            this.label_cosFi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_cosFi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cosFi.Location = new System.Drawing.Point(438, 172);
            this.label_cosFi.Name = "label_cosFi";
            this.label_cosFi.Size = new System.Drawing.Size(120, 23);
            this.label_cosFi.TabIndex = 46;
            this.label_cosFi.Text = "0";
            this.label_cosFi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_cosFiTXT2
            // 
            this.label_cosFiTXT2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cosFiTXT2.Location = new System.Drawing.Point(438, 149);
            this.label_cosFiTXT2.Name = "label_cosFiTXT2";
            this.label_cosFiTXT2.Size = new System.Drawing.Size(123, 16);
            this.label_cosFiTXT2.TabIndex = 45;
            this.label_cosFiTXT2.Text = "F.P. (Cos φ)";
            this.label_cosFiTXT2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_anguloFiTXT
            // 
            this.label_anguloFiTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_anguloFiTXT.Location = new System.Drawing.Point(309, 32);
            this.label_anguloFiTXT.Name = "label_anguloFiTXT";
            this.label_anguloFiTXT.Size = new System.Drawing.Size(123, 16);
            this.label_anguloFiTXT.TabIndex = 50;
            this.label_anguloFiTXT.Text = "Ángulo φ";
            this.label_anguloFiTXT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_potenciaAparenteTXT
            // 
            this.label_potenciaAparenteTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_potenciaAparenteTXT.Location = new System.Drawing.Point(312, 84);
            this.label_potenciaAparenteTXT.Name = "label_potenciaAparenteTXT";
            this.label_potenciaAparenteTXT.Size = new System.Drawing.Size(120, 16);
            this.label_potenciaAparenteTXT.TabIndex = 51;
            this.label_potenciaAparenteTXT.Text = "Potencia aparente";
            this.label_potenciaAparenteTXT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_potenciaReactivaTXT
            // 
            this.label_potenciaReactivaTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_potenciaReactivaTXT.Location = new System.Drawing.Point(435, 84);
            this.label_potenciaReactivaTXT.Name = "label_potenciaReactivaTXT";
            this.label_potenciaReactivaTXT.Size = new System.Drawing.Size(123, 16);
            this.label_potenciaReactivaTXT.TabIndex = 52;
            this.label_potenciaReactivaTXT.Text = "Potencia reactiva";
            this.label_potenciaReactivaTXT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDown_anguloFi
            // 
            this.numericUpDown_anguloFi.DecimalPlaces = 4;
            this.numericUpDown_anguloFi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_anguloFi.Location = new System.Drawing.Point(312, 51);
            this.numericUpDown_anguloFi.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.numericUpDown_anguloFi.Name = "numericUpDown_anguloFi";
            this.numericUpDown_anguloFi.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown_anguloFi.TabIndex = 53;
            this.numericUpDown_anguloFi.ValueChanged += new System.EventHandler(this.numericUpDown_anguloFi_ValueChanged);
            // 
            // numericUpDown_potenciaAparente
            // 
            this.numericUpDown_potenciaAparente.DecimalPlaces = 4;
            this.numericUpDown_potenciaAparente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_potenciaAparente.Location = new System.Drawing.Point(312, 103);
            this.numericUpDown_potenciaAparente.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.numericUpDown_potenciaAparente.Name = "numericUpDown_potenciaAparente";
            this.numericUpDown_potenciaAparente.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown_potenciaAparente.TabIndex = 54;
            this.numericUpDown_potenciaAparente.ValueChanged += new System.EventHandler(this.numericUpDown_potenciaAparente_ValueChanged);
            // 
            // numericUpDown_potenciaReactiva
            // 
            this.numericUpDown_potenciaReactiva.DecimalPlaces = 4;
            this.numericUpDown_potenciaReactiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_potenciaReactiva.Location = new System.Drawing.Point(438, 103);
            this.numericUpDown_potenciaReactiva.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.numericUpDown_potenciaReactiva.Name = "numericUpDown_potenciaReactiva";
            this.numericUpDown_potenciaReactiva.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown_potenciaReactiva.TabIndex = 55;
            this.numericUpDown_potenciaReactiva.ValueChanged += new System.EventHandler(this.numericUpDown_potenciaReactiva_ValueChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Archivo,
            this.ToolStripMenuItem_Editar,
            this.ToolStripMenuItem_Ver});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip1.Size = new System.Drawing.Size(574, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItem_Archivo
            // 
            this.ToolStripMenuItem_Archivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuracionToolStripMenuItem,
            this.toolStripSeparator2,
            this.cerrarToolStripMenuItem});
            this.ToolStripMenuItem_Archivo.Name = "ToolStripMenuItem_Archivo";
            this.ToolStripMenuItem_Archivo.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.ToolStripMenuItem_Archivo.Size = new System.Drawing.Size(55, 24);
            this.ToolStripMenuItem_Archivo.Text = "Archivo";
            // 
            // configuracionToolStripMenuItem
            // 
            this.configuracionToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.configuracionToolStripMenuItem.Name = "configuracionToolStripMenuItem";
            this.configuracionToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.configuracionToolStripMenuItem.Text = "Configuración";
            this.configuracionToolStripMenuItem.Click += new System.EventHandler(this.configuracionToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(147, 6);
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem_Editar
            // 
            this.ToolStripMenuItem_Editar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.despejarCeldasToolStripMenuItem,
            this.calcularToolStripMenuItem});
            this.ToolStripMenuItem_Editar.Name = "ToolStripMenuItem_Editar";
            this.ToolStripMenuItem_Editar.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.ToolStripMenuItem_Editar.Size = new System.Drawing.Size(44, 24);
            this.ToolStripMenuItem_Editar.Text = "Editar";
            // 
            // despejarCeldasToolStripMenuItem
            // 
            this.despejarCeldasToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.despejarCeldasToolStripMenuItem.Name = "despejarCeldasToolStripMenuItem";
            this.despejarCeldasToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.despejarCeldasToolStripMenuItem.Text = "Despejar celdas";
            this.despejarCeldasToolStripMenuItem.Click += new System.EventHandler(this.despejarCeldasToolStripMenuItem_Click);
            // 
            // calcularToolStripMenuItem
            // 
            this.calcularToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.calcularToolStripMenuItem.Name = "calcularToolStripMenuItem";
            this.calcularToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.calcularToolStripMenuItem.Text = "Calcular";
            this.calcularToolStripMenuItem.Click += new System.EventHandler(this.calcularToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem_Ver
            // 
            this.ToolStripMenuItem_Ver.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MostrarControlesDePotenciaAvanzadosToolStripMenuItem,
            this.toolStripSeparator1,
            this.ShowDeveloperConsoleToolStripMenuItem});
            this.ToolStripMenuItem_Ver.Name = "ToolStripMenuItem_Ver";
            this.ToolStripMenuItem_Ver.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.ToolStripMenuItem_Ver.Size = new System.Drawing.Size(30, 24);
            this.ToolStripMenuItem_Ver.Text = "Ver";
            // 
            // MostrarControlesDePotenciaAvanzadosToolStripMenuItem
            // 
            this.MostrarControlesDePotenciaAvanzadosToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MostrarControlesDePotenciaAvanzadosToolStripMenuItem.Name = "MostrarControlesDePotenciaAvanzadosToolStripMenuItem";
            this.MostrarControlesDePotenciaAvanzadosToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
            this.MostrarControlesDePotenciaAvanzadosToolStripMenuItem.Text = "Mostrar controles de potencia avanzados";
            this.MostrarControlesDePotenciaAvanzadosToolStripMenuItem.Click += new System.EventHandler(this.MostrarControlesDePotenciaAvanzadosToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(287, 6);
            // 
            // ShowDeveloperConsoleToolStripMenuItem
            // 
            this.ShowDeveloperConsoleToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ShowDeveloperConsoleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.calcularFormulasToolStripMenuItem,
            this.calculateAnotherCycleWithCalcularButtonToolStripMenuItem});
            this.ShowDeveloperConsoleToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ShowDeveloperConsoleToolStripMenuItem.Name = "ShowDeveloperConsoleToolStripMenuItem";
            this.ShowDeveloperConsoleToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
            this.ShowDeveloperConsoleToolStripMenuItem.Text = "Dev Tools";
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(394, 22);
            this.showToolStripMenuItem.Text = "Show Console (It can only be closed by closing the program)";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // calcularFormulasToolStripMenuItem
            // 
            this.calcularFormulasToolStripMenuItem.Name = "calcularFormulasToolStripMenuItem";
            this.calcularFormulasToolStripMenuItem.Size = new System.Drawing.Size(394, 22);
            this.calcularFormulasToolStripMenuItem.Text = "Calculate another cycle";
            this.calcularFormulasToolStripMenuItem.Click += new System.EventHandler(this.calcularFormulasToolStripMenuItem_Click);
            // 
            // calculateAnotherCycleWithCalcularButtonToolStripMenuItem
            // 
            this.calculateAnotherCycleWithCalcularButtonToolStripMenuItem.Name = "calculateAnotherCycleWithCalcularButtonToolStripMenuItem";
            this.calculateAnotherCycleWithCalcularButtonToolStripMenuItem.Size = new System.Drawing.Size(394, 22);
            this.calculateAnotherCycleWithCalcularButtonToolStripMenuItem.Text = "Calculate another cycle with \"Calcular\" button";
            this.calculateAnotherCycleWithCalcularButtonToolStripMenuItem.Click += new System.EventHandler(this.calculateAnotherCycleWithCalcularButtonToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 308);
            this.Controls.Add(this.numericUpDown_potenciaReactiva);
            this.Controls.Add(this.numericUpDown_potenciaAparente);
            this.Controls.Add(this.numericUpDown_anguloFi);
            this.Controls.Add(this.label_potenciaReactivaTXT);
            this.Controls.Add(this.label_potenciaAparenteTXT);
            this.Controls.Add(this.label_anguloFiTXT);
            this.Controls.Add(this.label_cosFi);
            this.Controls.Add(this.label_cosFiTXT2);
            this.Controls.Add(this.label_potenciaAparenteTXT2);
            this.Controls.Add(this.label_potenciaAparente);
            this.Controls.Add(this.label_anguloFi);
            this.Controls.Add(this.label_anguloFiTXT2);
            this.Controls.Add(this.label_potenciaReactiva);
            this.Controls.Add(this.label_potenciaReactivaTXT2);
            this.Controls.Add(this.label_potenciaTXT);
            this.Controls.Add(this.label_resistenciaTXT);
            this.Controls.Add(this.label_intensidadTXT);
            this.Controls.Add(this.label_tensionTXT);
            this.Controls.Add(this.label_tension);
            this.Controls.Add(this.label_potenciaActiva);
            this.Controls.Add(this.label_resistencia);
            this.Controls.Add(this.label_intensidad);
            this.Controls.Add(this.button_borrar);
            this.Controls.Add(this.button_calcular);
            this.Controls.Add(this.label_cosFiTXT);
            this.Controls.Add(this.numericUpDown_cosFi);
            this.Controls.Add(this.label_potActivaWTXT);
            this.Controls.Add(this.numericUpDown_potenciaActiva);
            this.Controls.Add(this.label_resistenciaRTXT);
            this.Controls.Add(this.numericUpDown_resistencia);
            this.Controls.Add(this.label_intensidadATXT);
            this.Controls.Add(this.numericUpDown_intensidad);
            this.Controls.Add(this.label_tensionVTXT);
            this.Controls.Add(this.numericUpDown_tension);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Calculadora de magnitudes eléctricas";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_tension)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_intensidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_resistencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_cosFi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_potenciaActiva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_anguloFi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_potenciaAparente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_potenciaReactiva)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown_tension;
        private System.Windows.Forms.Label label_tensionVTXT;
        private System.Windows.Forms.Label label_intensidadATXT;
        private System.Windows.Forms.NumericUpDown numericUpDown_intensidad;
        private System.Windows.Forms.Label label_resistenciaRTXT;
        private System.Windows.Forms.NumericUpDown numericUpDown_resistencia;
        private System.Windows.Forms.Label label_cosFiTXT;
        private System.Windows.Forms.NumericUpDown numericUpDown_cosFi;
        private System.Windows.Forms.Label label_potActivaWTXT;
        private System.Windows.Forms.NumericUpDown numericUpDown_potenciaActiva;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button_calcular;
        private System.Windows.Forms.Button button_borrar;
        private System.Windows.Forms.Label label_potenciaActiva;
        private System.Windows.Forms.Label label_resistencia;
        private System.Windows.Forms.Label label_intensidad;
        private System.Windows.Forms.Label label_tension;
        private System.Windows.Forms.Label label_tensionTXT;
        private System.Windows.Forms.Label label_intensidadTXT;
        private System.Windows.Forms.Label label_resistenciaTXT;
        private System.Windows.Forms.Label label_potenciaTXT;
        private System.Windows.Forms.Label label_potenciaReactivaTXT2;
        private System.Windows.Forms.Label label_potenciaReactiva;
        private System.Windows.Forms.Label label_potenciaAparenteTXT2;
        private System.Windows.Forms.Label label_potenciaAparente;
        private System.Windows.Forms.Label label_anguloFi;
        private System.Windows.Forms.Label label_anguloFiTXT2;
        private System.Windows.Forms.Label label_cosFi;
        private System.Windows.Forms.Label label_cosFiTXT2;
        private System.Windows.Forms.Label label_anguloFiTXT;
        private System.Windows.Forms.Label label_potenciaAparenteTXT;
        private System.Windows.Forms.Label label_potenciaReactivaTXT;
        private System.Windows.Forms.NumericUpDown numericUpDown_anguloFi;
        private System.Windows.Forms.NumericUpDown numericUpDown_potenciaAparente;
        private System.Windows.Forms.NumericUpDown numericUpDown_potenciaReactiva;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Editar;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Ver;
        private System.Windows.Forms.ToolStripMenuItem ShowDeveloperConsoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem despejarCeldasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calcularToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MostrarControlesDePotenciaAvanzadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calcularFormulasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateAnotherCycleWithCalcularButtonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Archivo;
    }
}

