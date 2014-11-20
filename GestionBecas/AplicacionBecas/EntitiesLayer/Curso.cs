using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace EntitiesLayer{

    public class Curso : IEntity{
        private int _idCurso;
        public int Id{
            get { return _idCurso; }
            set { _idCurso = value; }
        }

        //<summary> Métodos set y get de la variable nombre</summary>
        //<author> Valeria Ramírez Cordero </author> 
        //<param > variable de tipo String que almacena el  nombre del curso</param>
        //<returns> Retorna una variable String con el nombre del curso.</returns> 
        public String nombre { get; set; }

        //<summary> Métodos set y get de la variable codigo</summary>
        //<author>  Valeria Ramírez Cordero </author> 
        //<param > variable de tipo String que almacena el código del curso</param>
        //<returns> Retorna una variable String con el codigo del curso.</returns> 
        public String codigo { get; set; }

        //<summary> Métodos set y get de la variable cuatrimestre</summary>
        //<author>  Valeria Ramírez Cordero </author> 
        //<param > variable de tipo String que almacena el cuatrimestre</param>
        //<returns> Retorna una variable String con el el cuatrimestre en el que se encuentra el curso.</returns> 
        public String cuatrimestre { get; set; }

        //<summary> Métodos set y get de la variable creditos</summary>
        //<author>  Valeria Ramírez Cordero </author> 
        //<param > variable de tipo int que almacena los creditos del curso</param>
        //<returns> Retorna una variable int con los creditos del curso.</returns> 
        public Int32 creditos { get; set; }

        //<summary> Métodos set y get de la variable precio</summary>
        //<author>  Valeria Ramírez Cordero </author> 
        //<param > variable de tipo double que almacena el precio del curso</param>
        //<returns> Retorna una variable double con el precio del curso.</returns> 
        public double precio { get; set; }

        //<summary> Constructor de la clase Curso</summary>
        //<author> Valeria Ramírez Cordero </author> 
        //<param > No recibe parámetros</param>
        //<returns> No retorna valor.</returns> 
        public Curso(){
            nombre = "";
            codigo = "";
            cuatrimestre = "";
            creditos = 0;
            precio = 0;
        }

        //<summary> Constructor de la clase Curso</summary>
        //<author> Valeria Ramírez Cordero </author> 
        //<param name = "pnombre"> variable de tipo String que almacena el  nombre del curso  </param>
        //<param name= "pcodigo" > variable de tipo String que almacena el código del curso </param>
        //<param name = "pcuatrimestre"> variable de tipo String que almacena el cuatrimestre en el que se encuentra el curso </param>
        //<param name = " pcreditos"> variable de tipo int que almacena los créditos del curso</param>
        //<param name = "pprecio"> variable de tipo double que almacena el precio del curso</param>
        //<param name = "pprecio"> variable de tipo double que almacena el precio del curso</param>
        //<returns> No retorna valor.</returns> 
        public Curso(String pnombre, String pcodigo, String pcuatrimestre, int pcreditos, double pprecio){
            nombre = pnombre;
            codigo = pcodigo;
            cuatrimestre = pcuatrimestre;
            creditos = pcreditos;
            precio = pprecio;
        }

        //<summary> Constructor de la clase Curso</summary>
        //<author> Valeria Ramírez Cordero </author> 
        //<param name = "pnombre"> variable de tipo String que almacena el  nombre del curso  </param>
        //<param name= "pcodigo" > variable de tipo String que almacena el código del curso </param>
        //<param name = "pcuatrimestre"> variable de tipo String que almacena el cuatrimestre en el que se encuentra el curso </param>
        //<param name = " pcreditos"> variable de tipo int que almacena los créditos del curso</param>
        //<param name = "pprecio"> variable de tipo double que almacena el precio del curso</param>
        //<param name = "pid"> variable de tipo int que almacena el id  del curso</param>
        //<returns> No retorna valor.</returns> 
        public Curso(String pnombre, String pcodigo, String pcuatrimestre, int pcreditos, double pprecio, int pid){
            nombre = pnombre;
            codigo = pcodigo;
            cuatrimestre = pcuatrimestre;
            creditos = pcreditos;
            precio = pprecio;
            _idCurso = pid;
        }

        //<summary> Constructor de la clase Curso</summary>
        //<author> Valeria Ramírez Cordero </author> 
        //<param name = "pnombre"> variable de tipo String que almacena el  nombre del curso  </param>
        //<param name= "pcodigo" > variable de tipo String que almacena el código del curso </param>
        //<param name = "pid"> variable de tipo int que almacena el id  del curso</param>
        //<returns> No retorna valor.</returns> 
        public Curso(String pcodigo){
            Id = 0;
            nombre = "";
            codigo = pcodigo;
            cuatrimestre = "";
            creditos = 0;
            precio = 0;
        }

        //<summary> Constructor de la clase Curso</summary>
        //<author> Valeria Ramírez Cordero </author> 
        //<param name = "pnombre"> variable de tipo String que almacena el  nombre del curso  </param>
        //<param name= "pcodigo" > variable de tipo String que almacena el código del curso </param>
        //<param name = "pcuatrimestre"> variable de tipo String que almacena el cuatrimestre en el que se encuentra el curso </param>
        //<param name = " pcreditos"> variable de tipo int que almacena los créditos del curso</param>
        //<returns> No retorna valor.</returns> 
        public Curso(String pnombre, String pcodigo, String pcuatrimestre, int pcreditos){
            _idCurso = Id;
            nombre = pnombre;
            codigo = pcodigo;
            cuatrimestre = pcuatrimestre;
            creditos = pcreditos;
        }

        //<summary> Constructor de la clase Curso</summary>
        //<author> Valeria Ramírez Cordero </author> 
        //<param name = "pnombre"> variable de tipo String que almacena el  nombre del curso  </param>
        //<param name= "pcodigo" > variable de tipo String que almacena el código del curso </param>
        //<returns> No retorna valor.</returns> 
        public Curso(String pnombre, String pcodigo){
            nombre = pnombre;
            codigo = pcodigo;
        }

        //<summary> Método que se encarga de determinar si los datos ingresados por el usuario son validos</summary>
        //<author> Valeria Ramírez Cordero</author> 
        //<param > No recibe parámetros </param>
       //<returns> Variable booleana </returns> 
        public bool IsValid{
            get { return (GetRuleViolations().Count() == 0); }
        }

        //<summary> Método que se encarga de validar que los diferentes atributos del usuario este correctos</summary>
        //<author> Valeria Ramírez Cordero</author> 
        //<param > No recibe parámetros </param>
        //<returns> Retorna una lista de objetos RuleViolation </returns> 
        public IEnumerable<RuleViolation> GetRuleViolations(){
            if (String.IsNullOrEmpty(nombre)){
                yield return new RuleViolation("Nombre Requerido", "Nombre");
            }

            if (String.IsNullOrEmpty(codigo)){
                yield return new RuleViolation("Código Requerido", "Codigo");
            }

            if (String.IsNullOrEmpty(cuatrimestre)){
                yield return new RuleViolation("Cuatrimestre Requerido", "Cuatrimestre");
            }

            if (creditos <= 0){
                yield return new RuleViolation("Error en los creditos", "Creditos incorrectos");
            }

            if (!(Regex.IsMatch(cuatrimestre, "^[\\p{L} .'-]+$"))){
                yield return new RuleViolation("Solo se permiten letras en el cuatrimestre", "Cuatrimestre");
            }

            //if ((Regex.IsMatch(codigo, "^([0-9a-zA-Z]{1}$")))
            //{
            //    yield return new RuleViolation("Error en el código", "Código incorrecto");
            //}

            //if ((Regex.IsMatch(nombre, "^([0-9a-zA-Z]{1})$")))
            //{
            //    yield return new RuleViolation("Error en el nombre", "Nombre incorrecto");
            
        }
    }
}


       

        






