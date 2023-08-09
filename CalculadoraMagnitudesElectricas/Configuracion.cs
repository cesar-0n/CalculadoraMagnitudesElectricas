using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraMagnitudesElectricas
{
    public partial class Configuracion : Form
    {
        public static string LanguageFile;

        public static string Ñ_Configuracion;
        public static string Ñ_groupBox_language;
        //public static string[] files = new string[1000];
        public Configuracion()
        {
            InitializeComponent();
            string[] files = Directory.GetFiles(@"Languages\");
            string fileCut;
            if (Form1.console) { Console.WriteLine(files.Length); }
            foreach (string file in files)
            {
                if (Form1.console) { Console.WriteLine(file); }
                fileCut = file.Replace(@"Languages\","");
                fileCut = fileCut.Replace(".cs", "");
                if (Form1.console) { Console.WriteLine(fileCut); }
                if (fileCut != "language.ini") { listBox_languages.Items.Add(fileCut); }
                
            }
            listBox_languages.SelectedIndex = 0;
            CallLanguage();
        }

        private void listBox_languages_SelectedValueChanged(object sender, EventArgs e)
        {
            //label_languageSelected.Text = listBox_languages.SelectedItem.ToString();
        }



        public void ApplyLanguage()
        {
            LanguageFile = listBox_languages.SelectedItem.ToString();
            TextWriter config2Create = new StreamWriter(@"Languages\language.ini");
            config2Create.WriteLine(LanguageFile);
            config2Create.Close();
            CallLanguage();
        }

        public void CallLanguage()
        {
            if (LanguageFile == "en_US") { CalculadoraMagnitudesElectricas.Languages.en_US.language(); }
            if (LanguageFile == "es_ES") { CalculadoraMagnitudesElectricas.Languages.es_ES.language(); }

            this.Text = Ñ_Configuracion;
            groupBox_language.Text = Ñ_groupBox_language;
        }

        private void Configuracion_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1.ConfigurarionAbierta = false;
        }

        private void button_Apply_Click(object sender, EventArgs e)
        {
            ApplyLanguage();
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            Form1.ConfigurarionAbierta = false;
            this.Close();
        }

        private void button_Accept_Click(object sender, EventArgs e)
        {
            ApplyLanguage();
            Form1.ConfigurarionAbierta = false;
            this.Close();
        }
    }
}
