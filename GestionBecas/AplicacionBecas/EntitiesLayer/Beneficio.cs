using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace EntitiesLayer
{

    public class Beneficio : IEntity
    {

        private int _idBeneficio;
        public int Id
        {

            get { return _idBeneficio; }
            set { _idBeneficio = value; }
        }

        public String Nombre;
        public double Porcentaje;
        public String Aplicacion;

        /// <summary>
        /// Este método es el constructor de la clase. 
        /// Este metedo sirve para crear una instancia de la clase.
        /// </summary>
        /// <author>Mathias Muller</author>
        /// <param name="pnombre">Es el nombre del beneficio</param>
        /// <param name="pporcentaje">Es el porcentaje que cubre el beneficio</param>
        /// <param name="paplicacion">Describe a que se aplica el beneficio</param>

        public Beneficio(String pnombre, double pporcentaje, String paplicacion)
        {

            Nombre = pnombre;
            Porcentaje = pporcentaje;
            Aplicacion = paplicacion;

        }
        /// <summary>
        /// Este método es el constructor por default de la clase. 
        /// Este metedo sirve para crear una instancia de la clase.
        /// No recibe parametros y setea una instancia con valores predeterminados.
        /// </summary>
        /// <author>Mathias Muller</author>
        public Beneficio()
        {

            Nombre = "";
            Porcentaje = 2.0;
            Aplicacion = "";

        }
        public Beneficio(int pid, String pnombre, double pporcentaje, String paplicacion)
        {
            Id = pid;
            Nombre = pnombre;
            Porcentaje = pporcentaje;
            Aplicacion = paplicacion;

        }
        public Beneficio(int id)
        {
            this.Id = id;

        }
        public bool IsValid
        {
            get { return (GetRuleViolations().Count() == 0); }
        }

        /// <summary>
        /// Este metodo sirve para atrapar excepciones o errores relacionados con la base de datos.
        /// Aqui también se realizan validaciones utilizando expresiones regulares.
        /// </summary>
        /// <author>Mathias Muller</author>
        /// <returns>Retorna un 'Rule Violation' que es un mensaje de texto personalizado</returns>
        /// 

        public IEnumerable<RuleViolation> GetRuleViolations()
        {
           
            if (String.IsNullOrEmpty(Nombre))
            {
                yield return new RuleViolation("Nombre Requerido", "Nombre");
            }

            if (Porcentaje <= 0)
            {
                yield return new RuleViolation("Porcentaje debe ser mayor o igual a 0", "Porcentaje");
            }

            if (String.IsNullOrEmpty(Aplicacion))
            {
                yield return new RuleViolation("Aplicabilidad Requerida", "Aplicabilidad");
            }

            if (!(Regex.IsMatch(Aplicacion, "^[\\p{L} .'-]+$")))
            {
                yield return new RuleViolation("Solo se permiten letras en la aplicabilidad", "Aplicacion");
            }

            if (!(Regex.IsMatch(Nombre, "^[\\p{L} .'-]+$")))
            {
                yield return new RuleViolation("Solo se permiten letras en el nombre", "Nombre");
                yield break;
            }


        }

    }
}