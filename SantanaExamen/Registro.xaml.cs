using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SantanaExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        string usuarioG;
        public Registro(string usuario)
        {
            InitializeComponent();
            lblUsuario.Text = usuario;
            usuarioG = usuario;

        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            double monto = Convert.ToDouble(txtMonto.Text);
            double mensual = Convert.ToDouble(txtPagoM.Text);

            if(monto > 0 && monto < 1800)
            {
                double interes = 1800 * 0.05;
                double m = (1800 - monto) / 3;
                mensual = m + interes;
                txtPagoM.Text = Convert.ToString(mensual);
            }
            else
            {
                DisplayAlert("Alerta", "No se puede ingresar valores menores de 0, ni mayores de 1800 o igual a 1800","ok");
            }
        }

        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            double pagoM = Convert.ToDouble(txtPagoM.Text);  
            await DisplayAlert("Mensaje", "Guardado con exito", "ok");
            await Navigation.PushAsync(new Resumen(usuarioG,nombre,pagoM));
        }
    }
}