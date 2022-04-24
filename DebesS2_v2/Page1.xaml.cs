using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DebesS2_v2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDeberesS1S4.Text))
            {
                DisplayAlert("Error", "Ingrese un valor para Deberes S1-S4", "Aceptar");
                return;
            }

            if (string.IsNullOrEmpty(txtDeberesS5S8.Text))
            {
                DisplayAlert("Error", "Ingrese un valor para Deberes S5-S8", "Aceptar");
                return;
            }

            if (string.IsNullOrEmpty(txtExamenS1S4.Text))
            {
                DisplayAlert("Error", "Ingrese un valor para Examen S1-S4", "Aceptar");
                return;
            }

            if (string.IsNullOrEmpty(txtExamenS5S8.Text))
            {
                DisplayAlert("Error", "Ingrese un valor para Examen S5-S8", "Aceptar");
                return;
            }

            double d1 = Convert.ToDouble(txtDeberesS1S4.Text) * 0.3;
            double e1 = Convert.ToDouble(txtExamenS1S4.Text) * 0.2;
            double d2 = Convert.ToDouble(txtDeberesS5S8.Text) * 0.3;
            double e2 = Convert.ToDouble(txtExamenS5S8.Text) * 0.2;
            double n1 = d1 + e1;
            double n2 = d2 + e2;
            double total = n1 + n2;

            txtNotaS1S4.Text = n1.ToString();
            txtNotaS5S8.Text = n2.ToString();

            txtNotaFinal.Text = total.ToString();

            string obs = "";


            if (total >= 7)
            {
                obs = "APROBADO";
            }
            else if (total >= 5 && total <= 6.9)
            {
                obs = "COMPLEMENTARIO";
            }
            else
            {
                obs = "REPROBADO";
            }

            lblObservacion.Text = obs;

        }







        private void txtDeberesS1S4_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!String.IsNullOrEmpty(txtDeberesS1S4.Text))
            {
                double value = Convert.ToDouble(txtDeberesS1S4.Text);
                if (value < 0 || value > 10)
                {
                    txtDeberesS1S4.Text = "";
                    DisplayAlert("Error", "Valor entre 0 y 10", "Aceptar");
                }
            }

        }

        private void txtExamenS1S4_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!String.IsNullOrEmpty(txtExamenS1S4.Text))
            {
                double value = Convert.ToDouble(txtExamenS1S4.Text);
                if (value < 0 || value > 10)
                {
                    txtExamenS1S4.Text = "";
                    DisplayAlert("Error", "Valor entre 0 y 10", "Aceptar");
                }
            }

        }

        private void txtDeberesS5S8_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!String.IsNullOrEmpty(txtDeberesS5S8.Text))
            {
                double value = Convert.ToDouble(txtDeberesS5S8.Text);
                if (value < 0 || value > 10)
                {
                    txtDeberesS5S8.Text = "";
                    DisplayAlert("Error", "Valor entre 0 y 10", "Aceptar");
                }
            }

        }

        private void txtExamenS5S8_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!String.IsNullOrEmpty(txtExamenS5S8.Text))
            {
                double value = Convert.ToDouble(txtExamenS5S8.Text);
                if (value < 0 || value > 10)
                {
                    txtExamenS5S8.Text = "";
                    DisplayAlert("Error", "Valor entre 0 y 10", "Aceptar");
                }
            }

        }

        private void buttonLimpiar_Clicked(object sender, EventArgs e)
        {

        }
    }
}