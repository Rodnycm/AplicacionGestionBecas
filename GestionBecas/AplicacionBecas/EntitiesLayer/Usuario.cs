using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace EntitiesLayer
{
    public class Usuario : IEntity
    {
        //<summary> Métodos set y get de la variable primerNombre</summary>
        //<author> Gabriela Gutiérrez Corrales </author> 
        //<param > variable de tipo String que almacena el primer nombre</param>
        //<returns> Retorna una variable String con el primer nombre del usuario.</returns> 
        public String primerNombre { get; set; }
        //<summary> Métodos set y get de la variable segundoNombre</summary>
        //<author> Gabriela Gutiérrez Corrales </author> 
        //<param > variable de tipo String que almacena el segundo nombre</param>
        //<returns> Retorna una variable String con el segundo nombre del usuario.</returns> 
        public String segundoNombre { get; set; }
        //<summary> Métodos set y get de la variable primerApellido</summary>
        //<author> Gabriela Gutiérrez Corrales </author> 
        //<param > variable de tipo String que almacena el primer apellido</param>
        //<returns> Retorna una variable String con el primer apellido del usuario.</returns> 
        public String primerApellido { get; set; }
        //<summary> Métodos set y get de la variable segundoApellido</summary>
        //<author> Gabriela Gutiérrez Corrales </author> 
        //<param > variable de tipo String que almacena el segundo apellido</param>
        //<returns> Retorna una variable String con el segundo apellido del usuario.</returns> 
        public String segundoApellido { get; set; }
        //<summary> Métodos set y get de la variable identificacion</summary>
        //<author> Gabriela Gutiérrez Corrales </author> 
        //<param > variable de tipo String que almacena la identificacion</param>
        //<returns> Retorna una variable String con la identificacion del usuario.</returns> 
        public String identificacion { get; set; }
        //<summary> Métodos set y get de la variable telefono</summary>
        //<author> Gabriela Gutiérrez Corrales </author> 
        //<param > variable de tipo String que almacena el telefono</param>
        //<returns> Retorna una variable String con el telefono del usuario.</returns> 
        public String telefono { get; set; }
        //<summary> Métodos set y get de la variable fechaNacimiento</summary>
        //<author> Gabriela Gutiérrez Corrales </author> 
        //<param > variable de tipo DateTime que almacena la fecha de nacimiento</param>
        //<returns> Retorna una variable DateTime con la fecha de nacimiento usuario.</returns> 
        public DateTime fechaNacimiento { get; set; }
        //<summary> Métodos set y get de la variable genero</summary>
        //<author> Gabriela Gutiérrez Corrales </author> 
        //<param > variable de tipo int que almacena el genero</param>
        //<returns> Retorna una variable int con el genero del usuario.</returns> 
        public int genero { get; set; }
        //<summary> Métodos set y get de la variable rol</summary>
        //<author> Gabriela Gutiérrez Corrales </author> 
        //<param > variable de tipo Rol que almacena el rol del usuario</param>
        //<returns> Retorna una variable rol con el rol del usuario.</returns> 
        public Rol rol { get; set; }
        //<summary> Métodos set y get de la variable correo electrónico</summary>
        //<author> Gabriela Gutiérrez Corrales </author> 
        //<param > variable de tipo String que almacena el correo electrónico del usuario</param>
        //<returns> Retorna una variable String con el correo electrónico del usuario.</returns> 
        public String correoElectronico { get; set; }
        //<summary> Métodos set y get de la variable contraseña</summary>
        //<author> Gabriela Gutiérrez Corrales </author> 
        //<param > variable de tipo String que almacena la contraseña</param>
        //<returns> Retorna una variable String con la contraseña del usuario.</returns> 
        public String contraseña { get; set; }
        private int idUsuario;
        //<summary> Métodos set y get de la variable idUsuario</summary>
        //<author> Gabriela Gutiérrez Corrales </author> 
        //<param > variable de tipo int  que almacena el id del usuario</param>
        //<returns> Retorna una variable int con el id del usuario.</returns> 
        public int Id
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }
        //<summary> Constructor de la clase Usuario</summary>
        //<author> Gabriela Gutiérrez Corrales </author> 
        //<param name = "pparametro">variable que almacena la identificación del usuario</param>
        //<returns> No retorna valor.</returns> 
        public Usuario(String pparametro)
        {
            Id = 0;
            primerNombre = "";
            segundoNombre = "";
            primerApellido = "";
            segundoApellido = "";
            identificacion = pparametro;
            telefono = "";
            fechaNacimiento = DateTime.Today;
            genero = 0;
            rol = null;
            correoElectronico = "";
            contraseña = "";
        }
        //<summary> Constructor de la clase Usuario</summary>
        //<author> Gabriela Gutiérrez Corrales </author> 
        //<param >No recibe parametro</param>
        //<returns> No retorna valor.</returns> 
        public Usuario()
        {
            Id = 0;
            primerNombre = "";
            segundoNombre = "";
            primerApellido = "";
            segundoApellido = "";
            identificacion = "";
            telefono = "";
            fechaNacimiento = DateTime.Today;
            genero = 0;
            rol = null;
            correoElectronico = "";
            contraseña = "";
        }
        //<summary> Constructor de la clase Usuario</summary>
        //<author> Gabriela Gutiérrez Corrales </author> 
        //<param name = "ppNombre"> variable de tipo String que almacena el primer nombre del usuario  </param>
        //<param name= "psNombre" > variable de tipo String que almacena el segundo nombre del usuario  </param>
        //<param name = "ppApellido"> variable de tipo String que almacena el primer apellido del usuario  </param>
        //<param name = " psApellido"> variable de tipo String que almacena el segundo apellido del usuario  </param>
        //<param name = "pidentificacion"> variable de tipo String que almacena la identificación del usuario  </param>
        //<param name = " ptelefono"> variable de tipo String que almacena el número de teléfono del usuario  </param>
        //<param name = "pfechaNacimiento">  variable de tipo Date que almacena la fecha de nacimiento del usuario  </param>
        //<param name = "prol "> variable de tipo Rol que almacena el rol del usuario  </param>
        //<param name = "pgenero"> variable de tipo int que almacena el género del usuario  </param>
        //<param name = "pcorreoElectronico"> variable de tipo String que almacena el correo electrónico del usuario  </param>
        //<param name = "pcontraseña"> variable de tipo String que almacena la contraseña del usuario  </param>
        //<returns> No retorna valor.</returns> 
        public Usuario(String ppNombre, String psNombre, String ppApellido, String psApellido, String pidentificacion, String ptelefono,
                     DateTime pfechaNacimiento, Rol prol, int pgenero, String pcorreoElectronico, String pcontraseña)
        {
            DateTime fecha = pfechaNacimiento.Date;
            Id = 0;
            primerNombre = ppNombre;
            segundoNombre = psNombre;
            primerApellido = ppApellido;
            segundoApellido = psApellido;
            identificacion = pidentificacion;
            telefono = ptelefono;
            fechaNacimiento = fecha;
            genero = pgenero;
            rol = prol;
            correoElectronico = pcorreoElectronico;
            contraseña = pcontraseña;
        }
        //<summary> Método que se encarga de determinar si los datos ingresados por el usuario son validos</summary>
        //<author> Gabriela Gutiérrez Corrales </author> 
        //<param > No recibe parámetros </param>
        //<returns> Variable booleana </returns> 
        public bool IsValid
        {
            get { return (GetRuleViolations().Count() == 0); }
        }
        //<summary> Método que se encarga de validar que los diferentes atributos del usuario este correctos</summary>
        //<author> Gabriela Gutiérrez Corrales </author> 
        //<param > No recibe parámetros </param>
        //<returns> Retorna una lista de objetos RuleViolation </returns> 
        public IEnumerable<RuleViolation> GetRuleViolations()
        {
            if (String.IsNullOrEmpty(primerNombre))
            {
                yield return new RuleViolation("Nombre Requerido", "primerNombre");
            }
            if (String.IsNullOrEmpty(primerApellido))
            {
                yield return new RuleViolation("Primer apellido Requerido", "primerApellido");
            }
            if (String.IsNullOrEmpty(telefono))
            {
                yield return new RuleViolation("Telefono Requerido", "telefono");
            }
            // VALIDACION FECHA Y NUMEROS FALTA
            if (rol == null)
            {
                yield return new RuleViolation("Rol requerido", "rol");
            }
            if (String.IsNullOrEmpty(correoElectronico))
            {
                yield return new RuleViolation("Correo electrónico Requerido", "correoElectronico");
            }
            if (String.IsNullOrEmpty(contraseña))
            {
                yield return new RuleViolation("Contraseña Requerida", "contraseña");
            }
            if (!(Regex.IsMatch(primerNombre, "^[\\p{L} .'-]+$")))
            {
                yield return new RuleViolation("Solo se aceptan letras en el primer nombre", "Nombre incorrecto");
            }
            if (primerNombre.Length > 45)
            {
                yield return new RuleViolation("El nombre ingresado sobrepasa el tamaño permitido", "Primer nombre incorrecto");
            }
            if (segundoNombre.Length > 45)
            {
                yield return new RuleViolation("El segundo nombre ingresado sobrepasa el tamaño permitido", "Segundo nombre incorrecto");
            }
            if (!(Regex.IsMatch(primerApellido, "^[\\p{L} .'-]+$")))
            {
                yield return new RuleViolation("Solo se aceptan letras en el primer apellido", "Primer apellido incorrecto");
            }
            if (primerApellido.Length > 45)
            {
                yield return new RuleViolation("El primer apellido ingresado sobrepasa el tamaño permitido", "Primer apellido incorrecto");
            }
            if (segundoApellido.Length > 45)
            {
                yield return new RuleViolation("El segundo apellido ingresado sobrepasa el tamaño permitido", "Segundo apellido incorrecto");
            }
            if ((Regex.IsMatch(identificacion, "^([0-9a-zA-Z]{12})$")))
            {
                yield return new RuleViolation("Identificación en formato incorrecto", "Identificación incorrecta");
            }
            string expresionTelefono = "^0[1-6]{1}(([0-9]{2}){4})|(([0-9]{2}){4})|((-[0-9]{2}){4})$";
            if (!(Regex.IsMatch(telefono, expresionTelefono)))
            {
                yield return new RuleViolation("Error en el teléfono", "Teléfono incorrecto");
            }
            if (telefono.Length > 12)
            {
                yield return new RuleViolation("El teléfono ingresado sobrepasa el tamaño permitido", "Teléfono incorrecto");
            }
            String expresionEmail = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (!(Regex.IsMatch(correoElectronico, expresionEmail)))
            {
                yield return new RuleViolation("Correo electrónico incorrecto", "Correo electrónico incorrecto");
            }
            if (correoElectronico.Length > 50)
            {
                yield return new RuleViolation("El Correo electrónico sobre pasa el tamaño permitido", "Correo electrónico incorrecto");
            }
            yield break;
        }
    }
}