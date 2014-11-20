using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace EntitiesLayer
{
    public class Carrera : IEntity
    {
        private int _idCarrera;

        public int Id
        {
            get { return _idCarrera; }
            set { _idCarrera = value; }
        }

        public String nombre { get; set; }
        public String codigo { get; set; }
        public String color { get; set; }
        public Usuario directorAcademico { get; set; }

        public List<Curso> listaCursos { get; set; }

        public Carrera()
        {
            nombre = "";
            codigo = "";
            color = "";
            directorAcademico = null;
        }

        public Carrera(String pNombre, String pCodigo, String pColor, Usuario pDirectorAcademico)
        {
            nombre = pNombre;
            codigo = pCodigo;
            color = pColor;
            directorAcademico = pDirectorAcademico;
        }

        public Carrera(String pNombre, String pCodigo, String pColor)
        {
            nombre = pNombre;
            codigo = pCodigo;
            color = pColor;
            directorAcademico = null;
        }

        public Carrera(String pNombre, String pCodigo, String pColor, int pidCarrera, Usuario pDirectorAcademico)
        {
            nombre = pNombre;
            codigo = pCodigo;
            color = pColor;
            directorAcademico = pDirectorAcademico;
            _idCarrera = pidCarrera;
        }

        public Carrera(String pCodigo)
        {
            nombre = "";
            codigo = pCodigo;
            color = "";
        }

        //<summary> Método que se encarga de determinar si los datos ingresados del requisito son validos</summary>
        //<author> Gabriela Gutiérrez Corrales </author> 
        //<param > No recibe parámetros </param>
        //<returns> Variable booleana </returns> 
        public bool IsValid
        {
            get { return (GetRuleViolations().Count() == 0); }
        }


        //<summary> Método que se encarga de validar que los diferentes atributos del requisito esten correctos</summary>
        //<author> Gabriela Gutiérrez Corrales </author> 
        //<param > No recibe parámetros </param>
        //<returns> Retorna una lista de objetos RuleViolation </returns> 
        public IEnumerable<RuleViolation> GetRuleViolations()
        {
            if (!(Regex.IsMatch(nombre, "^[\\p{L} .'-]+$")))
            {
                yield return new RuleViolation("Error en el nombre", "Nombre incorrecto");
            }

            if (directorAcademico == null)
            {
                yield return new RuleViolation("Director académico requerido", "directorAcademico");

            }

            if (String.IsNullOrEmpty(nombre))
            {
                yield return new RuleViolation("Nombre Requerido", "nombre");
            }

            if (String.IsNullOrEmpty(codigo))
            {
                yield return new RuleViolation("Codigo Requerido", "codigo");
            }

            yield break;
        }

    }
}



