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
            this.numericUpDown_potenciaCC = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button_borrar = new System.Windows.Forms.Button();
            this.label_potenciaCC = new System.Windows.Forms.Label();
            this.label_resistencia = new System.Windows.Forms.Label();
            this.label_intensidadCC = new System.Windows.Forms.Label();
            this.label_tension = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label_potenciaCA_III = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_potenciaCA_II = new System.Windows.Forms.Label();
            this.label_intensidadCA_II = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label_intensidadCA_III = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_tension)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_intensidadCC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_resistencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_cosFi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_potenciaCC)).BeginInit();
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
            this.label6.Text = "Cos φ";
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
            this.label4.Text = "Potencia (W)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDown_potenciaCC
            // 
            this.numericUpDown_potenciaCC.DecimalPlaces = 4;
            this.numericUpDown_potenciaCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_potenciaCC.Location = new System.Drawing.Point(138, 77);
            this.numericUpDown_potenciaCC.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.numericUpDown_potenciaCC.Name = "numericUpDown_potenciaCC";
            this.numericUpDown_potenciaCC.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown_potenciaCC.TabIndex = 6;
            this.numericUpDown_potenciaCC.ValueChanged += new System.EventHandler(this.numericUpDown_potenciaCC_ValueChanged);
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
            // label_potenciaCC
            // 
            this.label_potenciaCC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_potenciaCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_potenciaCC.Location = new System.Drawing.Point(138, 201);
            this.label_potenciaCC.Name = "label_potenciaCC";
            this.label_potenciaCC.Size = new System.Drawing.Size(120, 23);
            this.label_potenciaCC.TabIndex = 21;
            this.label_potenciaCC.Text = "0 W";
            this.label_potenciaCC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.label11.Text = "Potencia CA III";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_potenciaCA_III
            // 
            this.label_potenciaCA_III.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_potenciaCA_III.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_potenciaCA_III.Location = new System.Drawing.Point(438, 201);
            this.label_potenciaCA_III.Name = "label_potenciaCA_III";
            this.label_potenciaCA_III.Size = new System.Drawing.Size(120, 23);
            this.label_potenciaCA_III.TabIndex = 37;
            this.label_potenciaCA_III.Text = "0 W";
            this.label_potenciaCA_III.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(309, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 16);
            this.label5.TabIndex = 44;
            this.label5.Text = "Potencia CA II";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_potenciaCA_II
            // 
            this.label_potenciaCA_II.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_potenciaCA_II.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_potenciaCA_II.Location = new System.Drawing.Point(312, 202);
            this.label_potenciaCA_II.Name = "label_potenciaCA_II";
            this.label_potenciaCA_II.Size = new System.Drawing.Size(120, 23);
            this.label_potenciaCA_II.TabIndex = 43;
            this.label_potenciaCA_II.Text = "0 W";
            this.label_potenciaCA_II.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_intensidadCA_II
            // 
            this.label_intensidadCA_II.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_intensidadCA_II.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_intensidadCA_II.Location = new System.Drawing.Point(312, 146);
            this.label_intensidadCA_II.Name = "label_intensidadCA_II";
            this.label_intensidadCA_II.Size = new System.Drawing.Size(120, 23);
            this.label_intensidadCA_II.TabIndex = 42;
            this.label_intensidadCA_II.Text = "0 A";
            this.label_intensidadCA_II.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(312, 123);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(123, 16);
            this.label14.TabIndex = 41;
            this.label14.Text = "Intensidad CA II";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_intensidadCA_III
            // 
            this.label_intensidadCA_III.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_intensidadCA_III.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_intensidadCA_III.Location = new System.Drawing.Point(438, 146);
            this.label_intensidadCA_III.Name = "label_intensidadCA_III";
            this.label_intensidadCA_III.Size = new System.Drawing.Size(120, 23);
            this.label_intensidadCA_III.TabIndex = 46;
            this.label_intensidadCA_III.Text = "0 A";
            this.label_intensidadCA_III.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(438, 123);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(123, 16);
            this.label20.TabIndex = 45;
            this.label20.Text = "Intensidad CA III";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 289);
            this.Controls.Add(this.label_intensidadCA_III);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_potenciaCA_II);
            this.Controls.Add(this.label_intensidadCA_II);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label_potenciaCA_III);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label_tension);
            this.Controls.Add(this.label_potenciaCC);
            this.Controls.Add(this.label_resistencia);
            this.Controls.Add(this.label_intensidadCC);
            this.Controls.Add(this.button_borrar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDown_cosFi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown_potenciaCC);
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_potenciaCC)).EndInit();
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
        private System.Windows.Forms.NumericUpDown numericUpDown_potenciaCC;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_borrar;
        private System.Windows.Forms.Label label_potenciaCC;
        private System.Windows.Forms.Label label_resistencia;
        private System.Windows.Forms.Label label_intensidadCC;
        private System.Windows.Forms.Label label_tension;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label_potenciaCA_III;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_potenciaCA_II;
        private System.Windows.Forms.Label label_intensidadCA_II;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label_intensidadCA_III;
        private System.Windows.Forms.Label label20;
    }
}

