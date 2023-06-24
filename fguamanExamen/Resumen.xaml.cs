using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace fguamanExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Resumen : ContentPage
    {
        string usuario1;
        public Resumen(string usuario)
        {
            InitializeComponent();
            lblUsuario.Text = "USUARIO CONECTADO :" + usuario;
            usuario1 = usuario;
        }

        private void btnSalir_Clicked(object sender, EventArgs e)
        {

        }
    }
    
}