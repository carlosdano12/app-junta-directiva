using System;
using System.Collections.Generic;
using System.Text;

namespace AppJuntaDirectiva.clases
{
    public class AsociadoRequest
    {
        public string id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string documento { get; set; }
        public string telefono { get; set; }
        public string descripcion { get; set; }
        public Boolean estado { get; set; }
    }
}
