using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace EntitiesLayer
{
    public class Rol : IEntity
    {

        private int idRol;
        private List<Permiso> listaPermisos = new List<Permiso>();
        public int Id
        {
            get { return idRol; }
            set { idRol = value; }
        }

        public String Nombre { get; set; }

        /// <summary>
        /// Crea un nuevo rol sin parametros
        /// </summary>
        public Rol()
        {

            Nombre = "";

        }

        /// <summary>
        /// Crea un nuevo Rol
        /// </summary>
        /// <param name="pNombre">nombre del rol</param>
        public Rol(String pNombre)
        {
            Nombre = pNombre;
        }

        /// <summary>
        /// Trae la lista de permisos del rol
        /// </summary>
        /// <returns>reporta la lista de permisos</returns>
        public List<Permiso> getListaPermisos()
        {

            return listaPermisos;

        }

        /// <summary>
        /// SETEA los permisos de el rol
        /// </summary>
        /// <param name="plistaPermisos">la nueva lista de permisos</param>
        public void setListaPermisos(List<Permiso> plistaPermisos)
        {

            listaPermisos = plistaPermisos;
        }
        /// <summary>
        /// Verifica si hay algun dato no valido
        /// </summary>
        public bool IsValid
        {
            get { return (GetRuleViolations().Count() == 0); }
        }

        /// <summary>
        /// Valida si los datos recibidos son validos
        /// </summary>
        /// <returns></returns>
        public IEnumerable<RuleViolation> GetRuleViolations()
        {
            if (String.IsNullOrEmpty(Nombre))
            {
                yield return new RuleViolation("Nombre Requerido", "Nombre");
            }

            if (!(Regex.IsMatch(Nombre, "^[\\p{L} .'-]+$")))
            {
                yield return new RuleViolation("Error en el nombre", "Nombre incorrecto");
            }


            yield break;
        }


    }
}




