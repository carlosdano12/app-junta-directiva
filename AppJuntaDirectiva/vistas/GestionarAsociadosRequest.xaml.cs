using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using AppJuntaDirectiva.dtos;
using AppJuntaDirectiva.clases;
using AppJuntaDirectiva.comunicaciones;
using AppJuntaDirectiva.vistas;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppJuntaDirectiva.vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GestionarAsociadosRequest : ContentPage
    {
        LoginResponseDto asociado = new LoginResponseDto();
        List<AsociadoRequest> solicitudes = new List<AsociadoRequest>();
        readonly AsociadosManager asociadosManager = new AsociadosManager();
        public GestionarAsociadosRequest(LoginResponseDto aso)
        {
            InitializeComponent();
            asociado = aso;

            llenaLista();

            solicitudes_lv.RefreshCommand = new Command(() =>
            {
                llenaLista();
                solicitudes_lv.IsRefreshing = false;
            });
        }

        public async void llenaLista()
        {
            solicitudes = new List<AsociadoRequest>();
            var response = await asociadosManager.GetAll(asociado.accessToken);
            if (response.code == "OK")
            {
                var solicitudesList = JsonConvert.DeserializeObject<List<AsociadoRequest>>(response.message);

                foreach (AsociadoRequest solicitud in solicitudesList)
                {
                    if (solicitud.id != "")
                    {
                        solicitudes.Add(solicitud);
                    }
                }
                solicitudes = solicitudes.OrderBy(o => o.nombre).ToList();
                solicitudes_lv.ItemsSource = solicitudes;
            }
            else
            {
                if (response.code == "Unauthorized")
                {
                    Navigation.PushAsync(new MainPage());
                }
                else
                {
                    Console.WriteLine("error llenaListaSolicitudes():" + response.message);
                    await DisplayAlert("Error", "Ocurrio algun problema al listar las solicitudes", "OK");
                }
            }
        }

        private void solicitudes_lv_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var solicitud = (AsociadoRequest)e.SelectedItem;
            Navigation.PushAsync(new Solicitud(solicitud));
        }
    }
}