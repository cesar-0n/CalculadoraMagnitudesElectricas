using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraMagnitudesElectricas
{
    public partial class Form1 : Form
    {
        decimal tension;
        decimal intensidadCC;
        decimal intensidadCA_II;
        decimal intensidadCA_III;
        decimal resistencia;
        decimal potenciaCC;
        decimal potenciaCA_II;
        decimal potenciaCA_III;
        decimal cosFi;
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        void calcular()
        {
            tension = numericUpDown_tension.Value;
            intensidadCC = numericUpDown_intensidadCC.Value;
            resistencia = numericUpDown_resistencia.Value;
            potenciaCC = numericUpDown_potenciaCC.Value;
            cosFi = numericUpDown_cosFi.Value;

            //TENSIÓN
            //V = I * R
            if (numericUpDown_intensidadCC.Value != 0 && numericUpDown_resistencia.Value != 0)
            {
                tension = numericUpDown_intensidadCC.Value * numericUpDown_resistencia.Value;
            }
            //V = Pcc / I
            if (numericUpDown_potenciaCC.Value != 0 && numericUpDown_intensidadCC.Value != 0)
            {
                tension = numericUpDown_potenciaCC.Value / numericUpDown_intensidadCC.Value;
            }
            //V = sqrt (P * R)
            if (numericUpDown_potenciaCC.Value != 0 && numericUpDown_resistencia.Value != 0)
            {
                tension = (decimal)Math.Sqrt((double)numericUpDown_potenciaCC.Value * (double)numericUpDown_resistencia.Value);
            }
        //INTENSIDADCC
            //I = V / R
            if (numericUpDown_tension.Value != 0 && numericUpDown_resistencia.Value != 0)
            {
                intensidadCC = numericUpDown_tension.Value / numericUpDown_resistencia.Value;
            }
            //I = P / V
            if (numericUpDown_potenciaCC.Value != 0 && numericUpDown_tension.Value != 0)
            {
                intensidadCC = numericUpDown_potenciaCC.Value / numericUpDown_tension.Value;
            }
            //I = sqrt (P / R)
            if (numericUpDown_potenciaCC.Value != 0 && numericUpDown_resistencia.Value != 0)
            {
                intensidadCC = (decimal)Math.Sqrt((double)numericUpDown_potenciaCC.Value / (double)numericUpDown_resistencia.Value);
            }
        //RESISTENCIA
            //R = V / I
            if (numericUpDown_tension.Value != 0 && numericUpDown_intensidadCC.Value != 0)
            {
                resistencia = numericUpDown_tension.Value / numericUpDown_intensidadCC.Value;
            }
            //R = P / I^2
            if (numericUpDown_potenciaCC.Value != 0 && numericUpDown_intensidadCC.Value != 0)
            {
                resistencia = numericUpDown_potenciaCC.Value / (decimal)Math.Pow((double)numericUpDown_intensidadCC.Value, 2);
            }
            //R = V^2 / P
            if (numericUpDown_tension.Value != 0 && numericUpDown_potenciaCC.Value != 0)
            {
                resistencia = (decimal)Math.Pow((double)numericUpDown_tension.Value, 2) / numericUpDown_potenciaCC.Value;
            }
        //POTENCIA
            //P = I * V
            if (numericUpDown_intensidadCC.Value != 0 && numericUpDown_tension.Value != 0)
            {
                potenciaCC = numericUpDown_intensidadCC.Value * numericUpDown_tension.Value;
            }
            //P = I^2 * R
            if (numericUpDown_intensidadCC.Value != 0 && numericUpDown_resistencia.Value != 0)
            {
                potenciaCC = (decimal)Math.Pow((double)numericUpDown_intensidadCC.Value, 2) * numericUpDown_resistencia.Value;
            }
            //P = V^2 / R
            if (numericUpDown_tension.Value != 0 && numericUpDown_resistencia.Value != 0)
            {
                potenciaCC = (decimal)Math.Pow((double)numericUpDown_tension.Value, 2) / numericUpDown_resistencia.Value;
            }
        //INTENSIDAD AC
            //Iacii = P / ( V * cosFi)
            if (tension != 0 && numericUpDown_cosFi.Value != 0)
            {
                intensidadCA_II = potenciaCC / (tension * numericUpDown_cosFi.Value);
            } else { intensidadCA_II = 0; }
            //Iaciii = (sqrt 3) * P / ( V * cosFi)
            if (tension != 0 && numericUpDown_cosFi.Value != 0)
            {
                intensidadCA_III = (potenciaCC) / ((decimal)Math.Sqrt(3) * tension * numericUpDown_cosFi.Value);
            } else { intensidadCA_III = 0; }
        //POTENCIA AC
            //Iacii = P * cosFi
                potenciaCA_II = potenciaCC * numericUpDown_cosFi.Value;
            //Iaciii = (sqrt 3) * P * cosFi
                potenciaCA_III = (decimal)Math.Sqrt(3) * potenciaCC * numericUpDown_cosFi.Value;

            if (numericUpDown_tension.Value != tension) { if (numericUpDown_tension.Value != 0) {
                    label_tension.ForeColor = Color.Red; }
                else { label_tension.ForeColor = Color.Green; } }
            else { label_tension.ForeColor = Color.Black; }

            if (numericUpDown_intensidadCC.Value != intensidadCC) { if (numericUpDown_intensidadCC.Value != 0) {
                    label_intensidadCC.ForeColor = Color.Red; }
                else { label_intensidadCC.ForeColor = Color.Green; } }
            else { label_intensidadCC.ForeColor = Color.Black; }

            if (numericUpDown_resistencia.Value != resistencia) { if (numericUpDown_resistencia.Value != 0) {
                    label_resistencia.ForeColor = Color.Red; }
                else { label_resistencia.ForeColor = Color.Green; } }
            else { label_resistencia.ForeColor = Color.Black; }

            if (numericUpDown_potenciaCC.Value != potenciaCC) { if (numericUpDown_potenciaCC.Value != 0) {
                    label_potenciaCC.ForeColor = Color.Red; }
                else { label_potenciaCC.ForeColor = Color.Green; } }
            else { label_potenciaCC.ForeColor = Color.Black; }
            //|| Convert.ToInt16(label_potenciaCC.Text) == 0
            //if (cosFi == 0)
            //{
            //    intensidadCA_II = 0;
            //    intensidadCA_III = 0;
            //    potenciaCA_II = 0;
            //    potenciaCA_III = 0;
            //}

            if (intensidadCA_II!= 0) {
                label_intensidadCA_II.ForeColor = Color.Green; }
            else { label_intensidadCA_II.ForeColor = Color.Black; }

            if (intensidadCA_III != 0) {
                label_intensidadCA_III.ForeColor = Color.Green; }
            else { label_intensidadCA_III.ForeColor = Color.Black; }

            if (potenciaCA_II != 0) {
                label_potenciaCA_II.ForeColor = Color.Green; }
            else { label_potenciaCA_II.ForeColor = Color.Black; }

            if (potenciaCA_III != 0) {
                label_potenciaCA_III.ForeColor = Color.Green; }
            else { label_potenciaCA_III.ForeColor = Color.Black; }

            label_tension.Text = Math.Round(tension, 4) + " V";
            label_intensidadCC.Text = Math.Round(intensidadCC, 4) + " A";
            label_intensidadCA_II.Text = Math.Round(intensidadCA_II, 4) + " A";
            label_intensidadCA_III.Text = Math.Round(intensidadCA_III, 4) + " A";
            label_resistencia.Text = Math.Round(resistencia, 4) + " Ω";
            label_potenciaCC.Text = Math.Round(potenciaCC, 4) + " W";
            label_potenciaCA_II.Text = Math.Round(potenciaCA_II, 4) + " W";
            label_potenciaCA_III.Text = Math.Round(potenciaCA_III, 4) + " W";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calcular();
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
            numericUpDown_tension.Value = 0;
            numericUpDown_intensidadCC.Value = 0;
            numericUpDown_resistencia.Value = 0;
            numericUpDown_potenciaCC.Value = 0;
            numericUpDown_cosFi.Value = 0;
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

        private void numericUpDown_potenciaCC_ValueChanged(object sender, EventArgs e)
        {
            calcular();
        }

        private void numericUpDown_cosFi_ValueChanged(object sender, EventArgs e)
        {
            calcular();
        }
    }
}
