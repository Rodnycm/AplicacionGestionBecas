using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
   public class RegistroAccion
    {
            public int idRegistro { get; set; }

            public string nombreUsuario;
            public DateTime fechaAccion;
            public string nombreRol;
            public string descripcion;


            public RegistroAccion(string pnombreUsuario, string pnombreRol, string pdescripcion, DateTime pfechaAccion)
            {

                nombreUsuario = pnombreUsuario;
                nombreRol = pnombreRol;
                descripcion = pdescripcion;
                fechaAccion = pfechaAccion;
            }

            public RegistroAccion()
            {
                nombreUsuario = "";
                nombreRol = "";
                descripcion = "";
                fechaAccion = DateTime.Today;
            }

        }
}
