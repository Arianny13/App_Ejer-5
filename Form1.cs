using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ejer_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Distribuir_Click(object sender, EventArgs e)
        {
            Double Presupuesto, Emergencia, Cirugia, Suministros, Administracion, Laboratorio, Imagenes;

            Presupuesto = Double.Parse(txt_Presupuesto.Text);


            Emergencia = (Presupuesto * 30) / 100;
            Cirugia = (Presupuesto * 15) / 100;
            Suministros = (Presupuesto * 25) / 100;
            Administracion = (Presupuesto * 18) / 100;
            Laboratorio = (Presupuesto * 5) / 100;
            Imagenes = (Presupuesto * 7) / 100;

            txt_Emergencia.Text = Emergencia.ToString();
            txt_Cirugia.Text = Emergencia.ToString();
            txt_Suministros.Text = Emergencia.ToString();
            txt_Administracion.Text = Emergencia.ToString();
            txt_Laboratorio.Text = Emergencia.ToString();
            txt_Imagenes.Text = Emergencia.ToString();
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_Emergencia.Clear();
            txt_Cirugia.Clear();
            txt_Suministros.Clear();
            txt_Administracion.Clear();
            txt_Laboratorio.Clear();
            txt_Imagenes.Clear();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
