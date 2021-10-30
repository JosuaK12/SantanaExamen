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
    public partial class Resumen : ContentPage
    {
        public Resumen(string usuario, string nombre, double pagoM)
        {
            InitializeComponent();
            lblUsuario.Text = usuario;
            lblNombre.Text = nombre;
            double total = Convert.ToDouble(pagoM * 3);
            lblTotal.Text = Convert.ToString(total);

        }
    }
}