using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class Excepciones
    {

        public String excepciones(int numero)
        {
           String mensaje = validarExcepcion(numero);
           return mensaje;
                
        }

        public String validarExcepcion(int numero)
        {

            string mensaje = "";
            switch (numero)
            {

                case 40:
                    mensaje = "No se pudo establecer una conexión con la base de datos";
                    break;

                case 201:
                    mensaje = "Error al ingresar los datos";
                    break;

                case 257:
                    mensaje = "Error en el tipo de dato ingresado";
                    break;

                case 25016:
                    mensaje = "Claves duplicadas";
                    break;

                case 25027:
                    mensaje = "La información ingresada, sobrepasa el límite de caracteres establecidos";
                    break;

                case 8101:
                    mensaje = "Los datos ingresados ya se encuentran registrados";
                    break;

                case 8114:
                    mensaje = "EL tipo de dato ingresado es incorrecto";
                    break;

              default :
                    mensaje = "Error en el sistema"; 
                    break ;



            }

            return mensaje;

        }
    }
}
