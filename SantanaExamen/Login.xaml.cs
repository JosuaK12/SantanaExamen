using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SantanaExamen
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnIngreso_Clicked(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string clave = txtClave.Text;
            if (usuario == "estudiante2021" && clave == "uisrael2021")
            {
                await Navigation.PushAsync(new Registro(usuario));
            }
            else
            {
                await DisplayAlert("Advertencia", "Clave o Usuario incorrecto", "OK");
            }
        }
    }
}
