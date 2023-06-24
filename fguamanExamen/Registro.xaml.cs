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
    public partial class Registro : ContentPage
    {
        string usuario1;
        string Usuario, Apellido, fecha, ciudad, pais;
        double Moninicial, PagMensual;

        private void pkPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.pais = pkPais.Items[pkPais.SelectedIndex];
            lblUsuario.Text = this.pais.ToString();
        }

        private void pkCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ciudad = pkCiudad.Items[pkCiudad.SelectedIndex];
            lblUsuario.Text = this.ciudad.ToString();
        }

        public Registro(string usuario)
        {
            InitializeComponent();
           
            lblUsuario.Text = "USUARIO CONECTADO :" + usuario;
            usuario1 = usuario;
        }

        private void btnPago_Clicked(object sender, EventArgs e)
        {
            
            double Moninicial = Convert.ToDouble(txtMoninicial.Text);            
            double Moninicial1 = 1500 - Moninicial;
            double Moninicial2 = Moninicial1 / 4;            
            double Pormoninicial = Moninicial2 * 0.4;
            //MONTO MENSAUL + 4 %
            double Monmensual = Moninicial2 + Pormoninicial;
            textMonmensual.Text = Monmensual.ToString();
        }

        private void btnPago_Clicked_1(object sender, EventArgs e)
        {

        }

        private void btnResumen_Clicked(object sender, EventArgs e)
        {
                       
            
            Navigation.PushAsync(new Resumen(Usuario, textNombre.Text, textApellido.Text, textEdad.Text, this.fecha, this.ciudad, this.pais, txtMoninicial.Text, textMonmensual.Text));
        }

        private void txtMoninicial_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                double dato = Convert.ToDouble(txtMoninicial.Text);
                if (dato > 1500)
                {
                    DisplayAlert("Error", "El dato no esta en el rango", "Cerrar");
                    txtMoninicial.Text = "";
                }
                else
                {
                    double Moninicial = Convert.ToDouble(txtMoninicial.Text);
                    double Moninicial1 = 1500 - Moninicial;
                    double Moninicial2 = Moninicial1 / 4;
                    double Pormoninicial = Moninicial2 * 0.4;
                    //MONTO MENSAUL + 4 %
                    double Monmensual = Moninicial2 + Pormoninicial;
                    textMonmensual.Text = Monmensual.ToString();

                }

            }
            catch (Exception )
            {

                //DisplayAlert("Error", ex.Message, "Cerrar");
            }
        }
    }
}