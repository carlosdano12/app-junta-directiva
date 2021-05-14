using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppJuntaDirectiva.vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Reporte2 : ContentPage
    {
        public Reporte2()
        {
            InitializeComponent();
            WebView.Source = "http://10.0.2.2:57622/viewer/preview?__report=C%3A%5CUsers%5CUser%5Cworkspace%5CrepoteWeb%5Creporte.rptdesign&__format=html&__svg=true&__locale=es_CO&__timezone=America%2FBogota&__masterpage=true&__rtl=false&__cubememsize=10&__resourceFolder=C%3A%5CUsers%5CUser%5Cworkspace%5CrepoteWeb&__emitterid=org.eclipse.birt.report.engine.emitter.html&2038345002";

        }
    }
}