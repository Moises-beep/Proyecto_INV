using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2_guía5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int i, numero;
            double suma = 0, promedio = 0, cantProm = 0;
            try
            {
                //Validación de ingreso de numeros
                numero = Convert.ToInt32(txtIngresar.Text);
                while (numero < 2 || numero > 100)
                {
                    MessageBox.Show("Ingrese valores entre 2 y 100. Intente nuevamente");
                    txtIngresar.Text = "";
                    return;
                }
                //Sumatoria impares

                for (i = 2; i <= numero; i++)
                {
                    if (i % 2 != 0)
                    {
                        suma = suma + i;
                    }
                    else
                    {
                        //Promedio pares
                        promedio = promedio + i;
                        cantProm = cantProm + 1;
                    }
                }
                //fin del for 

                ////////////////////////////////////////////////////
                // asignación de valores a los controles de salida
                txtSumatoria.Enabled = true;
                txtSumatoria.Text = suma.ToString();
                promedio = promedio / cantProm;
                txtPromedio.Enabled = true;
                txtPromedio.Text = promedio.ToString();
                ////////////////////////////////////////////////////
                ///




            }
            catch
            {
                MessageBox.Show("Ingreso un dato null, favor ejecutar nuevamente el programa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }





        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtIngresar.Text = "";
            txtPromedio.Text = "";
            txtSumatoria.Text = "";
            txtIngresar.Focus();
            txtSumatoria.Enabled = false;
            txtPromedio.Enabled = false;
        }
    }
}
