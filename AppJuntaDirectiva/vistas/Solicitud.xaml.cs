using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppJuntaDirectiva.clases;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppJuntaDirectiva.vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Solicitud : ContentPage
    {
        public Solicitud(AsociadoRequest asociadoReq)
        {
            InitializeComponent();
            llenarDatos(asociadoReq);
        }

        public void llenarDatos(AsociadoRequest asociadoReq)
        {
            txtNombre.Text = asociadoReq.nombre;
            txtApellido.Text = asociadoReq.apellido;
            txtDoc.Text = asociadoReq.documento;
            txtPhone.Text = asociadoReq.telefono;
            txtDes.Text = asociadoReq.descripcion;
        }
    }
}