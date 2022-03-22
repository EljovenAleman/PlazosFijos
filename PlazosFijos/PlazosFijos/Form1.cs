using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlazosFijos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_ProcesarOperación_Click(object sender, EventArgs e)
        {
            float inversionInicial = float.Parse(textBox_InversionInicial.Text);
            float interesAnual = float.Parse(textBox_InteresAnual.Text);

            float totalAnual = CalcularTotalAnual(inversionInicial, interesAnual);
            label_TotalUnicaInversion.Text = totalAnual.ToString();

            List<float> totalesReinversionMensual = CalcularReinversionMensual(inversionInicial, interesAnual);

            MostrarTotalesEnListBox(totalesReinversionMensual, totalAnual);
            
            label_TotalReinversionMensual.Text = totalesReinversionMensual[11].ToString();

            label_TotalGananciaReinversion.Text = (totalesReinversionMensual[11] - totalAnual).ToString();

        }

        private void MostrarTotalesEnListBox(List<float> totalesReinversionMensual, float totalAnual)
        {
            listBox_IngresosMensuales.Items.Clear();

            int month = 1;
            foreach (var item in totalesReinversionMensual)
            {
                listBox_IngresosMensuales.Items.Add("Mes " + month + ": " + item);
                month++;
            }            
        }

        private List<float> CalcularReinversionMensual(float inversionInicial, float interesAnual)
        {
            float interesGanado = 0;
            float inversionMensual = inversionInicial;
            List<float> resultados = new List<float>();
            float interesMensual = (interesAnual / 100) / 12;

            for (int i=0; i<12; i++)
            {
                interesGanado = inversionMensual * interesMensual;

                //Importante, interes redondeado a 2 decimales
                //float interesRedondeado = (float)Math.Round(interesGanado * 100f) / 100f;

                float interesRedondeado = (float)(Math.Truncate((double)interesGanado * 100f) / 100f);

                inversionMensual = inversionMensual + interesRedondeado;

                resultados.Add(inversionMensual);
            }

            return resultados;
        }

        private float CalcularTotalAnual(float inversionInicial, float interesAnual)
        {
            float interes = inversionInicial * (interesAnual / 100);

            float interesRedondeado = (float)(Math.Truncate((double)interes * 100f) / 100f);

            float total = inversionInicial + interes;

            return total;
        }
    }
}
