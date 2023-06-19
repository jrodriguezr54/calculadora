using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace calculadora
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnsuma_Clicked(object sender, EventArgs e)
        {
            double num1, num2, resta, total;
            num1 = double.Parse(txtnumero1.Text);
            num2 = double.Parse(txtnumero2.Text);

            resta = num1 + num2;
            total = resta;
            DisplayAlert("la suma de los numeros es", total.ToString(), "ok");
            txtnumero1.Text = "";
            txtnumero2.Text = "";
        }

        private void btnresta_Clicked(object sender, EventArgs e)
        {
            double num1, num2, resta, total;
            num1 = double.Parse(txtnumero1.Text);
            num2 = double.Parse(txtnumero2.Text);

            resta = num1 - num2;
            total = resta;
            DisplayAlert("la resta de los numeros es", total.ToString(), "ok");
            txtnumero1.Text = "";
            txtnumero2.Text = "";
        }

        private void btnmultiplicacion_Clicked(object sender, EventArgs e)
        {
            double num1, num2, resta, total;
            num1 = double.Parse(txtnumero1.Text);
            num2 = double.Parse(txtnumero2.Text);

            resta = num1 * num2;
            total = resta;
            DisplayAlert("la multiplicacion de los numeros es", total.ToString(), "ok");
            txtnumero1.Text = "";
            txtnumero2.Text = "";
        }

        private void btndivision_Clicked(object sender, EventArgs e)
        {
            double num1, num2, division, total;
            num1 = double.Parse(txtnumero1.Text);
            num2 = double.Parse(txtnumero2.Text);

            division = num1 / num2;
            total = division;

            if (num2 == 0)
            { DisplayAlert("no se pude dividir entre cero", "  ", "ok"); }

            else { DisplayAlert("la division de los numeros es", total.ToString(), "ok"); };

            txtnumero1.Text = "";
            txtnumero2.Text = "";
        }
    }
}
