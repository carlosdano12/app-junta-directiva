using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppJuntaDirectiva.dtos;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppJuntaDirectiva.vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuApp : ContentPage
    {
        LoginResponseDto asociado = new LoginResponseDto();
        public MenuApp(LoginResponseDto aso)
        {
            InitializeComponent();
            asociado = aso;
        }

        private async void solicitudes_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GestionarAsociadosRequest(asociado));
        }

        private async void btn_reporte1_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Reporte1());
        }

        private void btn_reporte2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Reporte2());
        }
    }
}