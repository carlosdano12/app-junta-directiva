using AppJuntaDirectiva.clases;
using AppJuntaDirectiva.vistas;
using AppJuntaDirectiva.comunicaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Newtonsoft.Json;
using AppJuntaDirectiva.dtos;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppJuntaDirectiva
{
    public partial class MainPage : ContentPage
    {
        readonly LoginManager loginManager = new LoginManager();
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Login(object sender, EventArgs e)
        {
            string documento = txtDocumento.Text;
            string contrsena = txtContrasena.Text;
            var response = await loginManager.login(documento, contrsena);
            if (response.code == "OK")
            {
                var login = JsonConvert.DeserializeObject<LoginResponseDto>(response.message);
                await Navigation.PushAsync(new MenuApp(login));
            }
            else
            {
                await DisplayAlert("Login fallo", "Documento y/o contraseña no validos", "OK");
            }

        }

    }
}
