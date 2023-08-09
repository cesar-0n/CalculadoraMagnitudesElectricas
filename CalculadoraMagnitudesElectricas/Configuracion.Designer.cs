namespace CalculadoraMagnitudesElectricas
{
    partial class Configuracion
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
            this.groupBox_language = new System.Windows.Forms.GroupBox();
            this.button_Accept = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.button_Apply = new System.Windows.Forms.Button();
            this.listBox_languages = new System.Windows.Forms.ListBox();
            this.groupBox_language.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_language
            // 
            this.groupBox_language.Controls.Add(this.button_Accept);
            this.groupBox_language.Controls.Add(this.button_Close);
            this.groupBox_language.Controls.Add(this.button_Apply);
            this.groupBox_language.Controls.Add(this.listBox_languages);
            this.groupBox_language.Location = new System.Drawing.Point(12, 12);
            this.groupBox_language.Name = "groupBox_language";
            this.groupBox_language.Size = new System.Drawing.Size(254, 253);
            this.groupBox_language.TabIndex = 0;
            this.groupBox_language.TabStop = false;
            this.groupBox_language.Text = "Idioma";
            // 
            // button_Accept
            // 
            this.button_Accept.Location = new System.Drawing.Point(90, 224);
            this.button_Accept.Name = "button_Accept";
            this.button_Accept.Size = new System.Drawing.Size(75, 23);
            this.button_Accept.TabIndex = 5;
            this.button_Accept.Text = "Aceptar";
            this.button_Accept.UseVisualStyleBackColor = true;
            this.button_Accept.Click += new System.EventHandler(this.button_Accept_Click);
            // 
            // button_Close
            // 
            this.button_Close.Location = new System.Drawing.Point(9, 224);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(75, 23);
            this.button_Close.TabIndex = 4;
            this.button_Close.Text = "Cerrar";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // button_Apply
            // 
            this.button_Apply.Location = new System.Drawing.Point(171, 224);
            this.button_Apply.Name = "button_Apply";
            this.button_Apply.Size = new System.Drawing.Size(75, 23);
            this.button_Apply.TabIndex = 3;
            this.button_Apply.Text = "Aplicar";
            this.button_Apply.UseVisualStyleBackColor = true;
            this.button_Apply.Click += new System.EventHandler(this.button_Apply_Click);
            // 
            // listBox_languages
            // 
            this.listBox_languages.FormattingEnabled = true;
            this.listBox_languages.Location = new System.Drawing.Point(9, 19);
            this.listBox_languages.Name = "listBox_languages";
            this.listBox_languages.Size = new System.Drawing.Size(239, 186);
            this.listBox_languages.TabIndex = 1;
            this.listBox_languages.SelectedValueChanged += new System.EventHandler(this.listBox_languages_SelectedValueChanged);
            // 
            // Configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 277);
            this.Controls.Add(this.groupBox_language);
            this.Name = "Configuracion";
            this.Text = "Configuración";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Configuracion_FormClosing);
            this.groupBox_language.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox groupBox_language;
        private System.Windows.Forms.ListBox listBox_languages;
        private System.Windows.Forms.Button button_Apply;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Button button_Accept;
    }
}