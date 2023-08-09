using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraMagnitudesElectricas
{
    public partial class Form1 : Form
    {
        public static string Ñ_Form1;
        public static string Ñ_ToolStripMenuItem_Archivo;
            public static string Ñ_configuracionToolStripMenuItem;
            public static string Ñ_cerrarToolStripMenuItem;
        public static string Ñ_ToolStripMenuItem_Editar;
            public static string Ñ_despejarCeldasToolStripMenuItem;
            public static string Ñ_calcularToolStripMenuItem;
        public static string Ñ_ToolStripMenuItem_Ver;
            public static string Ñ_MostrarControlesDePotenciaAvanzadosToolStripMenuItem;

        public static string Ñ_label_tensionVTXT;
        public static string Ñ_label_intensidadATXT;
        public static string Ñ_label_resistenciaRTXT;
        public static string Ñ_label_potActivaWTXT;
        public static string Ñ_label_tensionTXT;
        public static string Ñ_label_intensidadTXT;
        public static string Ñ_label_resistenciaTXT;
        public static string Ñ_label_potenciaTXT;
        public static string Ñ_label_anguloFiTXT;
        public static string Ñ_label_cosFiTXT;
        public static string Ñ_label_potenciaAparenteTXT;
        public static string Ñ_label_potenciaReactivaTXT;

        public static string Ñ_button_borrar;
        public static string Ñ_button_calcular;

        public void ApplyLanguage()
        {
            this.Text = Ñ_Form1;
            ToolStripMenuItem_Archivo.Text = Ñ_ToolStripMenuItem_Archivo;
                configuracionToolStripMenuItem.Text = Ñ_configuracionToolStripMenuItem;
                cerrarToolStripMenuItem.Text = Ñ_cerrarToolStripMenuItem;
            ToolStripMenuItem_Editar.Text = Ñ_ToolStripMenuItem_Editar;
                despejarCeldasToolStripMenuItem.Text = Ñ_despejarCeldasToolStripMenuItem;
                calcularToolStripMenuItem.Text = Ñ_calcularToolStripMenuItem;
            ToolStripMenuItem_Ver.Text = Ñ_ToolStripMenuItem_Ver;
                MostrarControlesDePotenciaAvanzadosToolStripMenuItem.Text = Ñ_MostrarControlesDePotenciaAvanzadosToolStripMenuItem;

            label_tensionVTXT.Text = Ñ_label_tensionVTXT;
            label_intensidadATXT.Text = Ñ_label_intensidadATXT;
            label_resistenciaRTXT.Text = Ñ_label_resistenciaRTXT;
            label_potActivaWTXT.Text = Ñ_label_potActivaWTXT;
            label_tensionTXT.Text = Ñ_label_tensionTXT;
            label_intensidadTXT.Text = Ñ_label_intensidadTXT;
            label_resistenciaTXT.Text = Ñ_label_resistenciaTXT;
            label_potenciaTXT.Text = Ñ_label_potenciaTXT;
            label_anguloFiTXT.Text = Ñ_label_anguloFiTXT;
            label_cosFiTXT.Text = Ñ_label_cosFiTXT;
            label_potenciaAparenteTXT.Text = Ñ_label_potenciaAparenteTXT;
            label_potenciaReactivaTXT.Text = Ñ_label_potenciaReactivaTXT;
            label_anguloFiTXT2.Text = Ñ_label_anguloFiTXT;
            label_cosFiTXT2.Text = Ñ_label_cosFiTXT;
            label_potenciaAparenteTXT2.Text = Ñ_label_potenciaAparenteTXT;
            label_potenciaReactivaTXT2.Text = Ñ_label_potenciaReactivaTXT;

            button_borrar.Text = Ñ_button_borrar;
            button_calcular.Text = Ñ_button_calcular;
        }

        public void CallLanguage()
        {
            if (Configuracion.LanguageFile == "en_US") { CalculadoraMagnitudesElectricas.Languages.en_US.language(); ApplyLanguage(); }
            if (Configuracion.LanguageFile == "es_ES") { CalculadoraMagnitudesElectricas.Languages.es_ES.language(); ApplyLanguage(); }
        }
    }
}
