 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Text.RegularExpressions;

namespace EntitiesLayer
{
    public class TipoBeca : IEntity
    {

        //public int id { get; set; }
        private int _idTipoBeca;
       /// <summary>
       /// Método get y set de la variable id
       /// variable de tipo integer</summary>
       /// <author>María Jesús Gutiérrez Calvo</author>
       /// <returns>Retorna una variable de tipo integer con el id del tipo de beca</returns>
        public int Id
        {
            get { return _idTipoBeca; }
            set { _idTipoBeca = value; }
        }
        /// <summary>
        /// Método get y set de la variable nombre 
        /// variable de tipo string</summary>
        /// <author>María Jesús Gutiérrez Calvo</author>
        public string nombre { get; set; }
        /// <summary>
        /// Método get y set de la variable estado
        /// variable de tipo string</summary>
        /// <author>María Jesús Gutiérrez Calvo</author>
        public string estado { get; set; }
        /// <summary>
        /// Método get y set de la variable descripcion
        /// variable de tipo string </summary>
        /// <author>María Jesús Gutiérrez Calvo</author>
        public string descripcion { get; set; }
        /// <summary>
        /// Método get y set de la variable objD que almacena la fecha actual del sistema
        /// variable de tipo datetime</summary>
        /// <author>María Jesús Gutiérrez Calvo</author>
        public DateTime objD { get; set; }
        /// <summary>
        /// Método get y set de la lista de beneficios asociados a un tipo de beca
        /// </summary>
        /// <author>María Jesús Gutiérrez Calvo</author>
        public List<Beneficio> listaBeneficios { get; set; }
        /// <summary>
        /// Método get y set de la lista de requisitos asociados a un tipo de beca
        /// </summary>
        /// <author>María Jesús Gutiérrez Calvo</author>
        public List<Requisito> listaRequisitos { get; set; }

        /// <summary>
        /// Constructor TipoBeca que crea una instancia de un TipoBeca.
        /// </summary>
        /// <author>María Jesús Gutiérrez</author>
        /// <param name="pid">id del tipo de beca</param>
        /// <param name="pnombre">Nombre del tipo de beca</param>
        /// <param name="pobjD">Fecha actual del sistema</param>
        /// <param name="pestado">Estado del tipo de beca</param>
        /// <param name="pdescripcion">Descripción del tipo de beca</param>
        public TipoBeca(int pid, String pnombre, DateTime pobjD, String pestado, String pdescripcion)
        {
            Id = pid;
            nombre = pnombre;
            estado = pestado;
            descripcion = pdescripcion;
            objD = pobjD;
        }
        /// <summary>
        /// Constructor TipoBeca que crea una instancia de un TipoBeca
        /// </summary>
        /// <author>María Jesús Gutiérrez Calvo</author>
        /// <param name="pid">id del tipo de beca</param>
        /// <param name="pnombre">nombre del tipo de beca</param>
        /// <param name="pestado">estado del tipo de beca</param>
        /// <param name="pdescripcion">descripción del tipo de beca</param>
        public TipoBeca(int pid, String pnombre, String pestado, String pdescripcion)
        {
            Id = pid;
            nombre = pnombre;
            estado = pestado;
            descripcion = pdescripcion;
        }


        public TipoBeca(String pnombre, String pestado, String pdescripcion)
         :   this(0,pnombre,System.DateTime.Now,pestado,pdescripcion)
        {
        }
        /// <summary>
        /// Constructor TipoBeca que crea una instancia de TipoBeca
        /// </summary>
        /// <author>María Jesús Gutiérrez Calvo</author>
        /// <param name="pnombre">nombre del tipo de beca</param>
        public TipoBeca(String pnombre)
        {
            nombre = pnombre;
        }
        /// <summary>
        /// Constructor vacío de TipoBeca
        /// </summary>
        /// <author>María Jesús Gutiérrez Calvo</author>
        public TipoBeca()
        {

        }
        /// <summary>
        /// Método que hace un get de lo que retorna el RuleViolationes
        /// </summary>
        /// <author>María Jesús Gutiérrez</author>
        public bool IsValid
        {
            get { return (GetRuleViolations().Count() == 0); }
        }

        /// <summary>
        /// Método que atrapa las excepciones de la base de datos.
        /// </summary>
        /// <author>María Jesús Gutiérrez</author>
        /// <returns>Retorna un RuleViolation (mensaje de error)</returns>
       
       public IEnumerable<RuleViolation> GetRuleViolations()
        {
            if (String.IsNullOrEmpty(nombre))
            {
                yield return new RuleViolation("Nombre Requerido", "nombre");
            }
             if (String.IsNullOrEmpty(estado))
            {
                yield return new RuleViolation("Estado Requerido", "estado");
            }
            if (String.IsNullOrEmpty(descripcion))
            {
                yield return new RuleViolation("Descripcion Requerido", "descripcion");
            }

            if (!(Regex.IsMatch(nombre, "^[\\p{L} .'-]+$")))
            {
                yield return new RuleViolation("Datos no váldios","Nombre");
            }

            if (!(Regex.IsMatch(estado, "^[\\p{L} .'-]+$")))
            {
                yield return new RuleViolation("Datos no váldios", "Estado");
            }

            if (!(Regex.IsMatch(descripcion, "^[\\p{L} .'-]+$")))
            {
                yield return new RuleViolation("Datos no váldios", "Descripción");
            }

            yield break;
            }
        } 
   }


