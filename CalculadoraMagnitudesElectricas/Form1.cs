#pragma warning disable IDE1006 //Infracción de regla de nomenclatura: Estas palabras deben comenzar por caracteres en mayúscula
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using System.IO;

namespace CalculadoraMagnitudesElectricas
{
    public partial class Form1 : Form
    {

        decimal tension;
        decimal intensidad;
        decimal resistencia;
        decimal potenciaActiva;

        decimal anguloFi;
        decimal cosFi;
        decimal potenciaAparente;
        decimal potenciaReactiva;

        public static bool ConfigurarionAbierta = false;
        public static bool console;
        bool PotAvanzada;

        public Form1()
        {
            //console = true;
            //AllocConsole();
            //VT100();

            InitializeComponent();
            LoadLanguage();
            PotenciaAvanzada();
            calculateAnotherCycleWithCalcularButtonToolStripMenuItem.Checked=false;
            //timer1.Start();
        }

        void LoadLanguage()
        {
            if (!File.Exists(@"Languages\language.ini"))
            {
                TextWriter config2Create = new StreamWriter(@"Languages\language.ini");
                config2Create.WriteLine("en_US");
                config2Create.Close();
            }
            TextReader config2 = new StreamReader(@"Languages\language.ini");
            Configuracion.LanguageFile = config2.ReadLine();
            config2.Close();
            CallLanguage();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (console) { Console.WriteLine("Configuracion abierta"); }
            if (!ConfigurarionAbierta)
            {
                if (console) { Console.WriteLine("Configuracion cerrada"); }
                timer1.Stop();
            }
            CallLanguage();
        }

        void calcular()
        {
            asignar();
            formulas();
            formulas();
            formulas();
            colores();
            display();
        }

        void asignar()
        {
            tension = numericUpDown_tension.Value;
            intensidad = numericUpDown_intensidad.Value;
            resistencia = numericUpDown_resistencia.Value;
            potenciaActiva = numericUpDown_potenciaActiva.Value;

            anguloFi = numericUpDown_anguloFi.Value;
            cosFi = numericUpDown_cosFi.Value;
            potenciaAparente = numericUpDown_potenciaAparente.Value;
            potenciaReactiva = numericUpDown_potenciaReactiva.Value;

            if (console)
            {
                Console.Clear();
                Console.WriteLine("[Asignación] Tensión = " + tension);
                Console.WriteLine("[Asignación] Intensidad = " + intensidad);
                Console.WriteLine("[Asignación] Resistencia = " + resistencia);
                Console.WriteLine("[Asignación] Potencia activa = " + potenciaActiva);
                Console.WriteLine("[Asignación] Angulo Fi = " + anguloFi);
                Console.WriteLine("[Asignación] CosFi = " + cosFi);
                Console.WriteLine("[Asignación] Potencia Aparente = " + potenciaAparente);
                Console.WriteLine("[Asignación] Potencia Reactiva = " + potenciaReactiva);
                Console.WriteLine("========================================");
            }
        }
        void formulas()
        {

            //TENSIÓN
            if (numericUpDown_intensidad.Value != 0 && numericUpDown_resistencia.Value != 0)
            {
                //V = I * R
                tension = numericUpDown_intensidad.Value * numericUpDown_resistencia.Value;
                if (console) Console.WriteLine("\x1b[38;2;255;255;0m[Fórmula V] \x1b[38;2;0;255;255mV = I * R =\x1b[38;2;255;100;100m " + intensidad + "A * " + resistencia + "R =\x1b[0m " + tension + "V");
            }
            if (potenciaActiva != 0 && numericUpDown_intensidad.Value != 0)
            {
                //V = P / I
                tension = potenciaActiva / numericUpDown_intensidad.Value;
                if (console) Console.WriteLine("\x1b[38;2;255;255;0m[Fórmula V] \x1b[38;2;0;255;255mV = P / I =\x1b[38;2;255;100;100m " + potenciaActiva + "W / " + intensidad + "A =\x1b[0m " + tension + "V");
            }
            if (potenciaActiva != 0 && numericUpDown_resistencia.Value != 0)
            {
                //V = sqrt (P * R)
                tension = (decimal)Math.Sqrt((double)potenciaActiva * (double)numericUpDown_resistencia.Value);
                if (console) Console.WriteLine("\x1b[38;2;255;255;0m[Fórmula V] \x1b[38;2;0;255;255mV = sqrt (P * R) =\x1b[38;2;255;100;100m sqrt (" + potenciaActiva + "W * " + resistencia + "R) =\x1b[0m " + tension + "V");
            }
        //INTENSIDAD
            if (numericUpDown_tension.Value != 0 && numericUpDown_resistencia.Value != 0)
            {
                //I = V / R
                intensidad = numericUpDown_tension.Value / numericUpDown_resistencia.Value;
                if (console) Console.WriteLine("\x1b[38;2;255;255;0m[Fórmula I] \x1b[38;2;0;255;255mI = V / R =\x1b[38;2;255;100;100m " + tension + "V / " + resistencia + "R =\x1b[0m " + intensidad + "A");
            }
            if (potenciaActiva != 0 && numericUpDown_tension.Value != 0)
            {
                //I = P / V
                intensidad = potenciaActiva / numericUpDown_tension.Value;
                if (console) Console.WriteLine("\x1b[38;2;255;255;0m[Fórmula I] \x1b[38;2;0;255;255mI = P / V =\x1b[38;2;255;100;100m " + potenciaActiva + "W / " + tension + "V =\x1b[0m " + intensidad + "A");
            }
            if (potenciaActiva != 0 && numericUpDown_resistencia.Value != 0)
            {
                //I = sqrt (P / R)
                intensidad = (decimal)Math.Sqrt((double)potenciaActiva / (double)numericUpDown_resistencia.Value);
                if (console) Console.WriteLine("\x1b[38;2;255;255;0m[Fórmula I] \x1b[38;2;0;255;255mI = sqrt (P / R) =\x1b[38;2;255;100;100m sqrt (" + potenciaActiva + "W / " + resistencia + "R) =\x1b[0m " + intensidad + "A");
            }
        //RESISTENCIA
            if (numericUpDown_tension.Value != 0 && numericUpDown_intensidad.Value != 0)
            {
                //R = V / I
                resistencia = numericUpDown_tension.Value / numericUpDown_intensidad.Value;
                if (console) Console.WriteLine("\x1b[38;2;255;255;0m[Fórmula R] \x1b[38;2;0;255;255mR = V / I =\x1b[38;2;255;100;100m " + tension + "V / " + intensidad + "A =\x1b[0m " + resistencia + "R");
            }
            if (potenciaActiva != 0 && numericUpDown_intensidad.Value != 0)
            {
                //R = P / I^2
                resistencia = potenciaActiva / (decimal)Math.Pow((double)numericUpDown_intensidad.Value, 2);
                if (console) Console.WriteLine("\x1b[38;2;255;255;0m[Fórmula R] \x1b[38;2;0;255;255mR = P / I^2 =\x1b[38;2;255;100;100m " + potenciaActiva + "W / " + intensidad + "A^2 =\x1b[0m " + resistencia + "R");
            }
            if (numericUpDown_tension.Value != 0 && potenciaActiva != 0)
            {
                //R = V^2 / P
                resistencia = (decimal)Math.Pow((double)numericUpDown_tension.Value, 2) / potenciaActiva;
                if (console) Console.WriteLine("\x1b[38;2;255;255;0m[Fórmula R] \x1b[38;2;0;255;255mR = V^2 / P =\x1b[38;2;255;100;100m " + tension + "V^2 / " + potenciaActiva + "W =\x1b[0m " + resistencia + "R");
            }
        //POTENCIA ACTIVA
            if (numericUpDown_intensidad.Value != 0 && numericUpDown_tension.Value != 0)
            {
                //P = I * V
                potenciaActiva = numericUpDown_intensidad.Value * numericUpDown_tension.Value;
                if (console) Console.WriteLine("\x1b[38;2;255;255;0m[Fórmula P ACT] \x1b[38;2;0;255;255mP = I * V =\x1b[38;2;255;100;100m " + tension + "V * " + intensidad + "A =\x1b[0m " + potenciaActiva + "W");
            }
            if (numericUpDown_intensidad.Value != 0 && numericUpDown_resistencia.Value != 0)
            {
                //P = I^2 * R
                potenciaActiva = (decimal)Math.Pow((double)numericUpDown_intensidad.Value, 2) * numericUpDown_resistencia.Value;
                if (console) Console.WriteLine("\x1b[38;2;255;255;0m[Fórmula P ACT] \x1b[38;2;0;255;255mP = I^2 * R =\x1b[38;2;255;100;100m " + intensidad + "I^2 * " + resistencia + "R =\x1b[0m " + potenciaActiva + "W");
            }
            if (numericUpDown_tension.Value != 0 && numericUpDown_resistencia.Value != 0)
            {
                //P = V^2 / R
                potenciaActiva = (decimal)Math.Pow((double)numericUpDown_tension.Value, 2) / numericUpDown_resistencia.Value;
                if (console) Console.WriteLine("\x1b[38;2;255;255;0m[Fórmula P ACTIV] \x1b[38;2;0;255;255mP = V^2 / R =\x1b[38;2;255;100;100m " + tension + "V^2 / " + resistencia + "R =\x1b[0m " + potenciaActiva + "W");
            }
            if (potenciaActiva == 0 && numericUpDown_potenciaAparente.Value != 0 && numericUpDown_anguloFi.Value != 0)
            {
                //P = Pva * (sin (90 - anguloFi))
                potenciaActiva = potenciaAparente * ((decimal)Math.Sin(90 * units.deg - (double)anguloFi * units.deg));
            }
            //POTENCIA APARENTE
            if (potenciaActiva != 0)
            {
                //Pva = Pw / (sin (90 - anguloFi))
                potenciaAparente = potenciaActiva / ((decimal)Math.Sin(90 * units.deg - (double)anguloFi * units.deg));
                if (console) Console.WriteLine("\x1b[38;2;255;255;0m[Fórmula POT APARE] \x1b[38;2;0;255;255mPap = P / (sin (90 * units.deg - anguloFi * units.deg)) =\x1b[38;2;255;100;100m " + potenciaActiva + "W / (sin (90 * " + units.deg + " - " + anguloFi + " * " + units.deg + "°))) =\x1b[0m " + potenciaAparente + "VA");
            }
            //else if (numericUpDown_potenciaAparente.Value == 0) { potenciaAparente = 0; }
            //POTENCIA REACTIVA
            if (numericUpDown_potenciaReactiva.Value == 0)
            {
                if (potenciaActiva != 0 && anguloFi != 0)
                {
                    //Pvar = (Pva / (sin 90 * units.deg - anguloFi * units.deg)) * sin(anguloFi * units.deg)
                    potenciaReactiva = (potenciaActiva / ((decimal)Math.Sin(90 * units.deg -(double)anguloFi * units.deg)))*(decimal)Math.Sin((double)anguloFi * units.deg);
                    if (console) Console.WriteLine("\x1b[38;2;255;255;0m[Fórmula POT REACT] \x1b[38;2;0;255;255mPvar = (Pva / (sin (90 * units.deg - anguloFi * units.deg)) * sin (anguloFi * units.deg) =\x1b[38;2;255;100;100m " + potenciaActiva + "W / (sin (90 * " + units.deg + " - " + anguloFi + " * " + units.deg+ "°)) =\x1b[0m " + potenciaAparente + "VA");
                } else { potenciaReactiva = 0; }
            }
        //ÁNGULO FI
            if (numericUpDown_anguloFi.Value == 0 && cosFi != 0)
            {
                anguloFi = ((decimal)Math.Acos((double)cosFi)) * to.deg;
            }
        //COS FI ó FACTOR DE POTENCIA
            if (numericUpDown_cosFi.Value == 0)
            {
                if (potenciaActiva != 0 && potenciaAparente != 0)
                {
                    //cos FI = W / VA
                    cosFi = potenciaActiva / potenciaAparente;
                } else if (potenciaReactiva !=0 && potenciaActiva != 0)
                {
                    //cos FI = VAR / W
                    cosFi = potenciaReactiva / potenciaActiva;
                } else if (potenciaReactiva != 0 && potenciaAparente != 0)
                {
                    //cos FI = VAR / VA
                    cosFi = potenciaReactiva / potenciaAparente;
                } else if (anguloFi != 0 && numericUpDown_cosFi.Value == 0)
                {
                    //cos FI
                    cosFi = (decimal)Math.Cos((double)anguloFi * units.deg);
                } else { cosFi = 0; }
            }
        }
        void colores()
        {
            if (numericUpDown_tension.Value != tension) { if (numericUpDown_tension.Value != 0) {
                    label_tension.ForeColor = Color.Red; }
                else { label_tension.ForeColor = Color.Green; } }
            else { label_tension.ForeColor = Color.Black; }

            if (numericUpDown_intensidad.Value != intensidad) { if (numericUpDown_intensidad.Value != 0) {
                    label_intensidad.ForeColor = Color.Red; }
                else { label_intensidad.ForeColor = Color.Green; } }
            else { label_intensidad.ForeColor = Color.Black; }

            if (numericUpDown_resistencia.Value != resistencia) { if (numericUpDown_resistencia.Value != 0) {
                    label_resistencia.ForeColor = Color.Red; }
                else { label_resistencia.ForeColor = Color.Green; } }
            else { label_resistencia.ForeColor = Color.Black; }

            if (numericUpDown_potenciaActiva.Value != potenciaActiva) { if (numericUpDown_potenciaActiva.Value != 0) {
                    label_potenciaActiva.ForeColor = Color.Red; }
                else { label_potenciaActiva.ForeColor = Color.Green; } }
            else { label_potenciaActiva.ForeColor = Color.Black; }
                
            if (numericUpDown_anguloFi.Value != anguloFi) { if (numericUpDown_anguloFi.Value != 0) {
                    label_anguloFi.ForeColor = Color.Red; }
                else { label_anguloFi.ForeColor = Color.Green; } }
            else { label_anguloFi.ForeColor = Color.Black; }

            if (console) Console.WriteLine("numeric cosFi = " + numericUpDown_cosFi.Value);
            if (console) Console.WriteLine("var cosFi = " + cosFi);
            if (numericUpDown_cosFi.Value != cosFi && numericUpDown_cosFi.Value == 0)
            {
                label_cosFi.ForeColor = Color.Green;
            }
            else
            {
                label_cosFi.ForeColor = Color.Black;
            }

            if (numericUpDown_potenciaAparente.Value != potenciaAparente) { if (numericUpDown_potenciaAparente.Value != 0) {
                    label_potenciaAparente.ForeColor = Color.Red; }
                else { label_potenciaAparente.ForeColor = Color.Green; } }
            else { label_potenciaAparente.ForeColor = Color.Black; }

            if (console) Console.WriteLine("numeric VAR = " + numericUpDown_potenciaReactiva.Value);
            if (console) Console.WriteLine("var VAR = " + potenciaReactiva);
            if (numericUpDown_potenciaReactiva.Value != potenciaReactiva) { if (numericUpDown_potenciaReactiva.Value != 0) {
                    label_potenciaReactiva.ForeColor = Color.Red; }
                else { label_potenciaReactiva.ForeColor = Color.Green; } }
            else { label_potenciaReactiva.ForeColor = Color.Black; }
            //|| Convert.ToInt16(label_potenciaCC.Text) == 0
            //if (cosFi == 0)
            //{
            //    intensidadCA_II = 0;
            //    intensidadCA_III = 0;
            //    potenciaCA_II = 0;
            //    potenciaCA_III = 0;
            //}

            //if (anguloFi!= 0) {
            //    label_anguloFi.ForeColor = Color.Green; }
            //else { label_anguloFi.ForeColor = Color.Black; }

            //if (cosFi != 0) {
            //    label_cosFi.ForeColor = Color.Green; }
            //else { label_cosFi.ForeColor = Color.Black; }

            //if (potenciaAparente != 0) {
            //    label_potenciaAparente.ForeColor = Color.Green; }
            //else { label_potenciaAparente.ForeColor = Color.Black; }

            //if (potenciaReactiva != 0) {
            //    label_potenciaReactiva.ForeColor = Color.Green; }
            //else { label_potenciaReactiva.ForeColor = Color.Black; }
        }
        void display()
        {
            label_tension.Text = Math.Round(tension, 4) + " V";
            label_intensidad.Text = Math.Round(intensidad, 4) + " A";
            label_anguloFi.Text = Math.Round(anguloFi, 4) + " °";

            if (potenciaAparente >= potenciaReactiva)
            {
                label_cosFi.Text = Math.Round(cosFi, 4) + "";
            }
            else
            {
                label_cosFi.Text = "Imposible >1";
            }
            label_resistencia.Text = Math.Round(resistencia, 4) + " Ω";
            label_potenciaActiva.Text = Math.Round(potenciaActiva, 4) + " W";
            label_potenciaAparente.Text = Math.Round(potenciaAparente, 4) + " VA";
            label_potenciaReactiva.Text = Math.Round(potenciaReactiva, 4) + " VAR";
        }


        private void button_calcular_Click(object sender, EventArgs e)
        {
            if (calculateAnotherCycleWithCalcularButtonToolStripMenuItem.Checked)
            {
                formulas();
                colores();
                display();
            }
            else
            {
                calcular();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Keys key = e.KeyCode;
            //e.Handled = true;
            if (key == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Suprime el sonido de error al presionar una tecla
                calcular();
            }
        }

        private void button_borrar_Click(object sender, EventArgs e)
        {
            despejarCeldas();
        }

        private void numericUpDown_tension_ValueChanged(object sender, EventArgs e)
        {
            calcular();
        }

        private void numericUpDown_intensidad_ValueChanged(object sender, EventArgs e)
        {
            calcular();
        }

        private void numericUpDown_resistencia_ValueChanged(object sender, EventArgs e)
        {
            calcular();
        }

        private void numericUpDown_potenciaActiva_ValueChanged(object sender, EventArgs e)
        {
            calcular();
        }
        private void numericUpDown_anguloFi_ValueChanged(object sender, EventArgs e)
        {
            calcular();
        }

        private void numericUpDown_cosFi_ValueChanged(object sender, EventArgs e)
        {
            calcular();
        }


        private void numericUpDown_potenciaAparente_ValueChanged(object sender, EventArgs e)
        {
            calcular();
        }

        private void numericUpDown_potenciaReactiva_ValueChanged(object sender, EventArgs e)
        {
            calcular();
        }

        private void MostrarControlesDePotenciaAvanzadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (console) Console.WriteLine("MostrarControlesDePotenciaAvanzadosToolStripMenuItem.Checked = " + MostrarControlesDePotenciaAvanzadosToolStripMenuItem.Checked);
            if (MostrarControlesDePotenciaAvanzadosToolStripMenuItem.Checked)
            {
                PotAvanzada = false;
            }
            else
            {
                PotAvanzada = true;
            }
            TextWriter config = new StreamWriter("config.ini");
            config.WriteLine(PotAvanzada);
            config.Close();
            PotenciaAvanzada();
        }

        void PotenciaAvanzada()
        {
            if (!File.Exists("config.ini"))
            {
                TextWriter configCreate = new StreamWriter("config.ini");
                configCreate.WriteLine(PotAvanzada);
                configCreate.Close();
            }
            TextReader config = new StreamReader("config.ini");
            PotAvanzada = bool.Parse(config.ReadLine());
            config.Close();
            if (console) Console.WriteLine(PotAvanzada);
            if (PotAvanzada)
            {
                MostrarControlesDePotenciaAvanzadosToolStripMenuItem.Checked = true;
                this.Size = new Size(590, 347);
            }
            else
            {
                MostrarControlesDePotenciaAvanzadosToolStripMenuItem.Checked = false;
                this.Size = new Size(290, 347);
            }
        }

        private void despejarCeldasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            despejarCeldas();
        }

        void despejarCeldas()
        {
            numericUpDown_tension.Value = 0;
            numericUpDown_intensidad.Value = 0;
            numericUpDown_resistencia.Value = 0;
            numericUpDown_potenciaActiva.Value = 0;
            numericUpDown_anguloFi.Value = 0;
            numericUpDown_cosFi.Value = 0;
            numericUpDown_potenciaAparente.Value = 0;
            numericUpDown_potenciaReactiva.Value = 0;
        }

        private void calcularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            calcular();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            console = true;
            AllocConsole();
            VT100();
            if (console) Console.WriteLine("IT WORKS!");
        }

        private void calcularFormulasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formulas();
            colores();
            display();
        }

        private void calculateAnotherCycleWithCalcularButtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (calculateAnotherCycleWithCalcularButtonToolStripMenuItem.Checked)
            {

                calculateAnotherCycleWithCalcularButtonToolStripMenuItem.Checked = false;
            }
            else
            {
                calculateAnotherCycleWithCalcularButtonToolStripMenuItem.Checked = true;
            }
        }

        private void configuracionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Configuracion configuracion = new Configuracion();
            configuracion.Show();
            configuracion.BringToFront();
            ConfigurarionAbierta = true;
            timer1.Start();
        }
    }
}
