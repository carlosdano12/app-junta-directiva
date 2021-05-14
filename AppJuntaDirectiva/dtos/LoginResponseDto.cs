using System;
using System.Collections.Generic;
using System.Text;
using AppJuntaDirectiva.clases;

namespace AppJuntaDirectiva.dtos
{
    public class LoginResponseDto
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public Rol[] roles { get; set; }
        public string accessToken { get; set; }

    }
}
