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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown_intensidadCC = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown_resistencia = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown_cosFi = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown_potenciaActiva = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button_borrar = new System.Windows.Forms.Button();
            this.label_potenciaActiva = new System.Windows.Forms.Label();
            this.label_resistencia = new System.Windows.Forms.Label();
            this.label_intensidadCC = new System.Windows.Forms.Label();
            this.label_tension = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label_potenciaReactiva = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_potenciaAparente = new System.Windows.Forms.Label();
            this.label_anguloFi = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label_cosFi = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.numericUpDown_anguloFi = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_potenciaAparente = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_potenciaReactiva = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_tension)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_intensidadCC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_resistencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_cosFi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_potenciaActiva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_anguloFi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_potenciaAparente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_potenciaReactiva)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown_tension
            // 
            this.numericUpDown_tension.DecimalPlaces = 4;
            this.numericUpDown_tension.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_tension.Location = new System.Drawing.Point(12, 25);
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
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tensión (V)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(135, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Intensidad (A)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDown_intensidadCC
            // 
            this.numericUpDown_intensidadCC.DecimalPlaces = 4;
            this.numericUpDown_intensidadCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_intensidadCC.Location = new System.Drawing.Point(138, 25);
            this.numericUpDown_intensidadCC.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.numericUpDown_intensidadCC.Name = "numericUpDown_intensidadCC";
            this.numericUpDown_intensidadCC.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numericUpDown_intensidadCC.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown_intensidadCC.TabIndex = 2;
            this.numericUpDown_intensidadCC.ValueChanged += new System.EventHandler(this.numericUpDown_intensidad_ValueChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Resistencia (Ω)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDown_resistencia
            // 
            this.numericUpDown_resistencia.DecimalPlaces = 4;
            this.numericUpDown_resistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_resistencia.Location = new System.Drawing.Point(12, 77);
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
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(435, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "F.P. (Cos φ)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.numericUpDown_cosFi.Location = new System.Drawing.Point(438, 25);
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
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(135, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Potencia activa (W)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDown_potenciaActiva
            // 
            this.numericUpDown_potenciaActiva.DecimalPlaces = 4;
            this.numericUpDown_potenciaActiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_potenciaActiva.Location = new System.Drawing.Point(138, 77);
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(493, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 31);
            this.button1.TabIndex = 12;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_borrar
            // 
            this.button_borrar.BackColor = System.Drawing.Color.IndianRed;
            this.button_borrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_borrar.Location = new System.Drawing.Point(12, 254);
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
            this.label_potenciaActiva.Location = new System.Drawing.Point(138, 201);
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
            this.label_resistencia.Location = new System.Drawing.Point(12, 202);
            this.label_resistencia.Name = "label_resistencia";
            this.label_resistencia.Size = new System.Drawing.Size(120, 23);
            this.label_resistencia.TabIndex = 19;
            this.label_resistencia.Text = "0 Ω";
            this.label_resistencia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_intensidadCC
            // 
            this.label_intensidadCC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_intensidadCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_intensidadCC.Location = new System.Drawing.Point(138, 146);
            this.label_intensidadCC.Name = "label_intensidadCC";
            this.label_intensidadCC.Size = new System.Drawing.Size(120, 23);
            this.label_intensidadCC.TabIndex = 17;
            this.label_intensidadCC.Text = "0 A";
            this.label_intensidadCC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_tension
            // 
            this.label_tension.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_tension.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tension.Location = new System.Drawing.Point(12, 146);
            this.label_tension.Name = "label_tension";
            this.label_tension.Size = new System.Drawing.Size(120, 23);
            this.label_tension.TabIndex = 26;
            this.label_tension.Text = "0 V";
            this.label_tension.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 16);
            this.label7.TabIndex = 27;
            this.label7.Text = "Tensión";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(135, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 16);
            this.label8.TabIndex = 28;
            this.label8.Text = "Intensidad";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 16);
            this.label9.TabIndex = 29;
            this.label9.Text = "Resistencia";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(135, 180);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 16);
            this.label10.TabIndex = 30;
            this.label10.Text = "Potencia";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(438, 178);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 16);
            this.label11.TabIndex = 31;
            this.label11.Text = "Potencia reactiva";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_potenciaReactiva
            // 
            this.label_potenciaReactiva.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_potenciaReactiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_potenciaReactiva.Location = new System.Drawing.Point(438, 201);
            this.label_potenciaReactiva.Name = "label_potenciaReactiva";
            this.label_potenciaReactiva.Size = new System.Drawing.Size(120, 23);
            this.label_potenciaReactiva.TabIndex = 37;
            this.label_potenciaReactiva.Text = "0 VAR";
            this.label_potenciaReactiva.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(309, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 16);
            this.label5.TabIndex = 44;
            this.label5.Text = "Potencia aparente";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_potenciaAparente
            // 
            this.label_potenciaAparente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_potenciaAparente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_potenciaAparente.Location = new System.Drawing.Point(312, 202);
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
            this.label_anguloFi.Location = new System.Drawing.Point(312, 146);
            this.label_anguloFi.Name = "label_anguloFi";
            this.label_anguloFi.Size = new System.Drawing.Size(120, 23);
            this.label_anguloFi.TabIndex = 42;
            this.label_anguloFi.Text = "0 °";
            this.label_anguloFi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(312, 123);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(123, 16);
            this.label14.TabIndex = 41;
            this.label14.Text = "Ángulo φ";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_cosFi
            // 
            this.label_cosFi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_cosFi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cosFi.Location = new System.Drawing.Point(438, 146);
            this.label_cosFi.Name = "label_cosFi";
            this.label_cosFi.Size = new System.Drawing.Size(120, 23);
            this.label_cosFi.TabIndex = 46;
            this.label_cosFi.Text = "0";
            this.label_cosFi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(438, 123);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(123, 16);
            this.label20.TabIndex = 45;
            this.label20.Text = "F.P. (Cos φ)";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(309, 6);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 16);
            this.label12.TabIndex = 50;
            this.label12.Text = "Ángulo φ";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(312, 58);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 16);
            this.label13.TabIndex = 51;
            this.label13.Text = "Potencia aparente";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(435, 58);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(123, 16);
            this.label15.TabIndex = 52;
            this.label15.Text = "Potencia reactiva";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDown_anguloFi
            // 
            this.numericUpDown_anguloFi.DecimalPlaces = 4;
            this.numericUpDown_anguloFi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_anguloFi.Location = new System.Drawing.Point(312, 25);
            this.numericUpDown_anguloFi.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.numericUpDown_anguloFi.Name = "numericUpDown_anguloFi";
            this.numericUpDown_anguloFi.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown_anguloFi.TabIndex = 53;
            // 
            // numericUpDown_potenciaAparente
            // 
            this.numericUpDown_potenciaAparente.DecimalPlaces = 4;
            this.numericUpDown_potenciaAparente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_potenciaAparente.Location = new System.Drawing.Point(312, 77);
            this.numericUpDown_potenciaAparente.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.numericUpDown_potenciaAparente.Name = "numericUpDown_potenciaAparente";
            this.numericUpDown_potenciaAparente.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown_potenciaAparente.TabIndex = 54;
            // 
            // numericUpDown_potenciaReactiva
            // 
            this.numericUpDown_potenciaReactiva.DecimalPlaces = 4;
            this.numericUpDown_potenciaReactiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_potenciaReactiva.Location = new System.Drawing.Point(438, 77);
            this.numericUpDown_potenciaReactiva.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.numericUpDown_potenciaReactiva.Name = "numericUpDown_potenciaReactiva";
            this.numericUpDown_potenciaReactiva.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown_potenciaReactiva.TabIndex = 55;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 289);
            this.Controls.Add(this.numericUpDown_potenciaReactiva);
            this.Controls.Add(this.numericUpDown_potenciaAparente);
            this.Controls.Add(this.numericUpDown_anguloFi);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label_cosFi);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_potenciaAparente);
            this.Controls.Add(this.label_anguloFi);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label_potenciaReactiva);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label_tension);
            this.Controls.Add(this.label_potenciaActiva);
            this.Controls.Add(this.label_resistencia);
            this.Controls.Add(this.label_intensidadCC);
            this.Controls.Add(this.button_borrar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDown_cosFi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown_potenciaActiva);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown_resistencia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown_intensidadCC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown_tension);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Calculadora de magnitudes eléctricas";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_tension)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_intensidadCC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_resistencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_cosFi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_potenciaActiva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_anguloFi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_potenciaAparente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_potenciaReactiva)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown_tension;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown_intensidadCC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown_resistencia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown_cosFi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown_potenciaActiva;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_borrar;
        private System.Windows.Forms.Label label_potenciaActiva;
        private System.Windows.Forms.Label label_resistencia;
        private System.Windows.Forms.Label label_intensidadCC;
        private System.Windows.Forms.Label label_tension;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label_potenciaReactiva;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_potenciaAparente;
        private System.Windows.Forms.Label label_anguloFi;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label_cosFi;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown numericUpDown_anguloFi;
        private System.Windows.Forms.NumericUpDown numericUpDown_potenciaAparente;
        private System.Windows.Forms.NumericUpDown numericUpDown_potenciaReactiva;
    }
}

