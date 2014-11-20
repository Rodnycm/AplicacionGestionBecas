using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesLayer;
using DAL.Repositories;
using System.Security.Cryptography;
using System.Windows.Forms;
using TIL;

namespace BLL
{
    public class GestorUsuario
    {

        public String key = "MiLLave";
        private static int DEFAULT_MIN_PASSWORD_LENGTH = 8;
        private static int DEFAULT_MAX_PASSWORD_LENGTH = 10;
        private static string PASSWORD_CHARS_LCASE = "abcdefgijkmnopqrstwxyz";
        private static string PASSWORD_CHARS_UCASE = "ABCDEFGHJKLMNPQRSTWXYZ";
        private static string PASSWORD_CHARS_NUMERIC = "23456789";



        //<summary> Método que se encarga de crear un nuevo usuario</summary>
        //<author> Gabriela Gutiérrez Corrales </author> 
        //<param name = "ppNombre"> variable de tipo String que almacena el primer nombre del usuario  </param>
        //<param name= "psNombre" > variable de tipo String que almacena el segundo nombre del usuario  </param>
        //<param name = "ppApellido"> variable de tipo String que almacena el primer apellido del usuario  </param>
        //<param name = " psApellido"> variable de tipo String que almacena el segundo apellido del usuario  </param>
        //<param name = "pidentificacion"> variable de tipo String que almacena la identificación del usuario  </param>
        //<param name = " ptelefono"> variable de tipo String que almacena el número de teléfono del usuario  </param>
        //<param name = "pfechaNacimiento">  variable de tipo Date que almacena la fecha de nacimiento del usuario  </param>
        //<param name = "prol "> variable de tipo String que almacena el nombre del rol del usuario  </param>
        //<param name = "pgenero"> variable de tipo int que almacena el género del usuario  </param>
        //<param name = "pcorreoElectronico"> variable de tipo String que almacena el correo electrónico del usuario  </param>
        //<param name = "pcontraseña"> variable de tipo String que almacena la contraseña del usuario  </param>
        //<param name = "pconfirmación "> variable de tipo String que almacena la confirmación de la contraseña del usuario  </param>
        //<returns> No retorna valor.</returns> 

        public void crearUsuario(string ppNombre, String psNombre, String ppApellido, String psApellido, String pidentificacion, String ptelefono, DateTime pfechaNacimiento, String prol, int pgenero, String pcorreoElectronico)
        {
            try
            {
                DateTime fecha = pfechaNacimiento.Date;
                Rol objRol = RolRepository.Instance.GetByNombre(prol);
                String contraseña = Generate(8, 10);
                String contraseñaEncriptada = encriptar(contraseña);
                Usuario objetoUsuario = ContenedorMantenimiento.Instance.crearUsuario(ppNombre, psNombre, ppApellido, psApellido, pidentificacion, ptelefono, fecha, objRol, pgenero, pcorreoElectronico, contraseñaEncriptada);
               
                if (objetoUsuario.IsValid)
                {
                    UsuarioRepository.Instance.Insert(objetoUsuario);
                    notificarUsuario(pcorreoElectronico, contraseña);
                }
                else
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (RuleViolation rv in objetoUsuario.GetRuleViolations())
                    {
                        sb.Append(rv.ErrorMessage + "\n");
                    }
                    throw new ApplicationException(sb.ToString());
                }
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }
        //<summary> Método que se encarga de validar si las contraseñas ingresadas por el usuario son idénticas</summary>
        //<author> Gabriela Gutiérrez Corrales </author> 
        //<param name = "pcontraseña ">  variable de tipo String que almacena la contraseña ingresada por el usuario  </param>
        //<param name = " pconfirmacion ">variable de tipo String que almacena la confirmación de la contraseña ingresada por el usuario  </param>
        //<returns> Retorna una variable booleana llamada sonIdenticas</returns> 
        public Boolean validarContraseñasIdenticas(String pcontraseña, String pconfirmacion)
        {
            Boolean sonIdenticas = true;

            if (pcontraseña.Equals(pconfirmacion))
            {
                sonIdenticas = true;
            }
            else
            {
                sonIdenticas = false;
            }

            return sonIdenticas;
        }

        //<summary> Método que se encarga de encriptar la contraseña del usuario</summary>
        //<author> Gabriela Gutiérrez Corrales </author> 
        //<param name = "texto"> variable que contiene la contraseña que se desea encriptar   </param>
        //<returns> Retorna un String con la contraseña ya encriptada</returns> 
        public string encriptar(string texto)
        {
            //arreglo de bytes donde guardaremos la llave
            byte[] keyArray;

            //arreglo de bytes donde guardaremos el texto
            //que vamos a encriptar
            byte[] Arreglo_a_Cifrar = UTF8Encoding.UTF8.GetBytes(texto);

            //se utilizan las clases de encriptación
            //provistas por el Framework
            //Algoritmo MD5
            MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
            //se guarda la llave para que se le realice
            //hashing
            keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));

            hashmd5.Clear();

            //Algoritmo 3DAS
            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();

            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;

            //se empieza con la transformación de la cadena
            ICryptoTransform cTransform = tdes.CreateEncryptor();

            //arreglo de bytes donde se guarda la
            //cadena cifrada
            byte[] ArrayResultado = cTransform.TransformFinalBlock(Arreglo_a_Cifrar, 0, Arreglo_a_Cifrar.Length);

            tdes.Clear();

            //se regresa el resultado en forma de una cadena
            return Convert.ToBase64String(ArrayResultado, 0, ArrayResultado.Length);
        }



        //<summary> Método que se encarga de desencriptar la contraseña del usuario</summary>
        //<author> Gabriela Gutiérrez Corrales </author> 
        //<param name = "texto">  variable que contiene la contraseña que se desea desencriptar  </param>
        //<returns> Retorna un String con la contraseña ya desencriptada</returns> 
        public string Desencriptar(string textoEncriptado)
        {
            byte[] keyArray;
            //convierte el texto en una secuencia de bytes
            byte[] Array_a_Descifrar = Convert.FromBase64String(textoEncriptado);

            //se llama a las clases que tienen los algoritmos
            //de encriptación se le aplica hashing
            //algoritmo MD5
            MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();

            keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));

            hashmd5.Clear();

            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();

            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = tdes.CreateDecryptor();

            byte[] resultArray = cTransform.TransformFinalBlock(Array_a_Descifrar, 0, Array_a_Descifrar.Length);

            tdes.Clear();
            //se regresa en forma de cadena
            return UTF8Encoding.UTF8.GetString(resultArray);
        }


        //<summary> Método que se encarga de generar la contraseña de un usuario</summary>
        //<author> Gabriela Gutiérrez Corrales </author> 
        //<param name= "minLength"> Parametro que almacena la logitud minima de la contraseña  </param>
        //<param name= "maxLength"> Parametro que almacena la longitud maxima de la contraseña </param>
        //<returns> Retorna una contraseña autogenerada </returns> 

        public static string Generate()
        {
            return Generate(DEFAULT_MIN_PASSWORD_LENGTH,
                            DEFAULT_MAX_PASSWORD_LENGTH);
        }

        public static string Generate(int length)
        {
            return Generate(length, length);
        }

        public static string Generate(int minLength,
                                  int maxLength)
        {
            // Make sure that input parameters are valid.
            if (minLength <= 0 || maxLength <= 0 || minLength > maxLength)
            {


                return null;
            }

            char[][] charGroups = new char[][] 
        {
            PASSWORD_CHARS_LCASE.ToCharArray(),
            PASSWORD_CHARS_UCASE.ToCharArray(),
            PASSWORD_CHARS_NUMERIC.ToCharArray(),
           
        };

            int[] charsLeftInGroup = new int[charGroups.Length];

            // Initially, all characters in each group are not used.
            for (int i = 0; i < charsLeftInGroup.Length; i++)
                charsLeftInGroup[i] = charGroups[i].Length;

            // Use this array to track (iterate through) unused character groups.
            int[] leftGroupsOrder = new int[charGroups.Length];

            // Initially, all character groups are not used.
            for (int i = 0; i < leftGroupsOrder.Length; i++)
                leftGroupsOrder[i] = i;

            // Because we cannot use the default randomizer, which is based on the
            // current time (it will produce the same "random" number within a
            // second), we will use a random number generator to seed the
            // randomizer.

            // Use a 4-byte array to fill it with random bytes and convert it then
            // to an integer value.
            byte[] randomBytes = new byte[4];

            // Generate 4 random bytes.
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            rng.GetBytes(randomBytes);

            // Convert 4 bytes into a 32-bit integer value.
            int seed = (randomBytes[0] & 0x7f) << 24 |
                        randomBytes[1] << 16 |
                        randomBytes[2] << 8 |
                        randomBytes[3];

            // Now, this is real randomization.
            Random random = new Random(seed);

            // This array will hold password characters.
            char[] password = null;

            // Allocate appropriate memory for the password.
            if (minLength < maxLength)
                password = new char[random.Next(minLength, maxLength + 1)];
            else
                password = new char[minLength];

            // Index of the next character to be added to password.
            int nextCharIdx;

            // Index of the next character group to be processed.
            int nextGroupIdx;

            // Index which will be used to track not processed character groups.
            int nextLeftGroupsOrderIdx;

            // Index of the last non-processed character in a group.
            int lastCharIdx;

            // Index of the last non-processed group.
            int lastLeftGroupsOrderIdx = leftGroupsOrder.Length - 1;

            // Generate password characters one at a time.
            for (int i = 0; i < password.Length; i++)
            {
                // If only one character group remained unprocessed, process it;
                // otherwise, pick a random character group from the unprocessed
                // group list. To allow a special character to appear in the
                // first position, increment the second parameter of the Next
                // function call by one, i.e. lastLeftGroupsOrderIdx + 1.
                if (lastLeftGroupsOrderIdx == 0)
                    nextLeftGroupsOrderIdx = 0;
                else
                    nextLeftGroupsOrderIdx = random.Next(0,
                                                         lastLeftGroupsOrderIdx);

                // Get the actual index of the character group, from which we will
                // pick the next character.
                nextGroupIdx = leftGroupsOrder[nextLeftGroupsOrderIdx];

                // Get the index of the last unprocessed characters in this group.
                lastCharIdx = charsLeftInGroup[nextGroupIdx] - 1;

                // If only one unprocessed character is left, pick it; otherwise,
                // get a random character from the unused character list.
                if (lastCharIdx == 0)
                    nextCharIdx = 0;
                else
                    nextCharIdx = random.Next(0, lastCharIdx + 1);

                // Add this character to the password.
                password[i] = charGroups[nextGroupIdx][nextCharIdx];

                // If we processed the last character in this group, start over.
                if (lastCharIdx == 0)
                    charsLeftInGroup[nextGroupIdx] =
                                              charGroups[nextGroupIdx].Length;
                // There are more unprocessed characters left.
                else
                {
                    // Swap processed character with the last unprocessed character
                    // so that we don't pick it until we process all characters in
                    // this group.
                    if (lastCharIdx != nextCharIdx)
                    {
                        char temp = charGroups[nextGroupIdx][lastCharIdx];
                        charGroups[nextGroupIdx][lastCharIdx] =
                                    charGroups[nextGroupIdx][nextCharIdx];
                        charGroups[nextGroupIdx][nextCharIdx] = temp;
                    }
                    // Decrement the number of unprocessed characters in
                    // this group.
                    charsLeftInGroup[nextGroupIdx]--;
                }

                // If we processed the last group, start all over.
                if (lastLeftGroupsOrderIdx == 0)
                    lastLeftGroupsOrderIdx = leftGroupsOrder.Length - 1;
                // There are more unprocessed groups left.
                else
                {
                    // Swap processed group with the last unprocessed group
                    // so that we don't pick it until we process all groups.
                    if (lastLeftGroupsOrderIdx != nextLeftGroupsOrderIdx)
                    {
                        int temp = leftGroupsOrder[lastLeftGroupsOrderIdx];
                        leftGroupsOrder[lastLeftGroupsOrderIdx] =
                                    leftGroupsOrder[nextLeftGroupsOrderIdx];
                        leftGroupsOrder[nextLeftGroupsOrderIdx] = temp;
                    }
                    // Decrement the number of unprocessed groups.
                    lastLeftGroupsOrderIdx--;
                }
            }

            // Convert password characters into a string and return the result.
            return new string(password);
        }


        //<summary> Método que se encarga de guardar los cambios de un usuario</summary>
        //<author> Gabriela Gutiérrez Corrales </author> 
        //<param> No recibe parametros  </param>
        //<returns> No retorna valor </returns> 
        public void guardarCambios()
        {
            try
            {
                UsuarioRepository.Instance.Save();
            }
            catch (CustomExceptions.DataAccessException ex)
            {

                throw ex;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //<summary> Método que se encarga de buscar todos los usuarios registrados</summary>
        //<author> Gabriela Gutiérrez Corrales </author> 
        //<param > No recibe parámetros  </param>
        //<returns> Retorna una lista con los usuarios registrados</returns> 

        public IEnumerable<Usuario> buscarUsuarios(){

            return UsuarioRepository.Instance.GetAll();
        }

        //<summary> Método que se encarga de buscar todos los roles estudiantes </summary>
        //<author> Valeria Ramírez Cordero </author> 
        //<param > No recibe parámetros  </param>
        //<returns> Retorna una lista con los roles estudiantes registrados</returns> 

        //public IEnumerable<Usuario> buscarRolesEstudiantes(){
        //    try{
        //        return UsuarioRepository.Instance.GetAllRolesEstudiante();
        //    }
        //    catch (Exception ex){
        //        throw ex;
        //    }
           
        //}

        //<summary> Método que se encarga de buscar un usuario determinado</summary>
        //<author> Gabriela Gutiérrez Corrales </author> 
        //<param name = "parametro">variable de tipo String que almacena el Nombre o la identificación del usuario deseado </param>
        //<returns> Retorna el usuario buscado</returns> 
        public Usuario buscarUnUsuario(String pparametro)
        {
            return UsuarioRepository.Instance.GetByNombre(pparametro);
        }

        //<summary> Método que se encarga de eliminar un usuario determinado</summary>
        //<author> Gabriela Gutiérrez Corrales </author> 
        //<param name = "parametro">variable de tipo String que almacena la identificación del usuario deseado </param>
        //<returns> Retorna el usuario buscado</returns>
        public void eliminarUsuario(String pparametro)
        {
            Usuario objUsuario = ContenedorMantenimiento.Instance.crearUsuario(pparametro);
            UsuarioRepository.Instance.Delete(objUsuario);

        }

        //<summary> Método que se encarga de modificar la información de un usuario</summary>
        //<author> Gabriela Gutiérrez Corrales </author> 
        //<param name = "ppNombre"> variable de tipo String que almacena el primer nombre del usuario  </param>
        //<param name= "psNombre" > variable de tipo String que almacena el segundo nombre del usuario  </param>
        //<param name = "ppApellido"> variable de tipo String que almacena el primer apellido del usuario  </param>
        //<param name = " psApellido"> variable de tipo String que almacena el segundo apellido del usuario  </param>
        //<param name = "pidentificacion"> variable de tipo String que almacena la identificación del usuario  </param>
        //<param name = " ptelefono"> variable de tipo String que almacena el número de teléfono del usuario  </param>
        //<param name = "pfechaNacimiento">  variable de tipo Date que almacena la fecha de nacimiento del usuario  </param>
        //<param name = "prol "> variable de tipo String que almacena el nombre del rol del usuario  </param>
        //<param name = "pgenero"> variable de tipo int que almacena el género del usuario  </param>
        //<param name = "pcorreoElectronico"> variable de tipo String que almacena el correo electrónico del usuario  </param>
        //<param name = "pcontraseña"> variable de tipo String que almacena la contraseña del usuario  </param>
        //<param name = "pconfirmación "> variable de tipo String que almacena la confirmación de la contraseña del usuario  </param>
        //<returns> No retorna valor.</returns> 

        public void modificarUsuario(String ppNombre, String psNombre, String ppApellido, String psApellido, String pidentificacion, String ptelefono, DateTime pfechaNacimiento, String prol, int pgenero, String pcorreoElectronico, String pcontraseña, String pconfirmacion, int pidUsuario)
        {
            try
            {
                DateTime fecha = pfechaNacimiento.Date;
                Rol objRol = RolRepository.Instance.GetByNombre(prol);

                if (pconfirmacion != "")
                {
                Boolean sonIguales = validarContraseñasIdenticas(pcontraseña, pconfirmacion);

                    if (sonIguales == false)
                {
                        throw new ApplicationException("Las contraseñas ingresadas no son idénticas");
                    }

                }
                    String contraseñaEncriptada = encriptar(pcontraseña);
                    Usuario objetoUsuario = ContenedorMantenimiento.Instance.crearUsuario(ppNombre, psNombre, ppApellido, psApellido, pidentificacion, ptelefono, fecha, objRol, pgenero, pcorreoElectronico, contraseñaEncriptada);
                    if (objetoUsuario.IsValid)
                    {
                        objetoUsuario.Id = pidUsuario;
                        UsuarioRepository.Instance.UpdateUsuario(objetoUsuario);
                    }
                    else
                    {
                        StringBuilder sb = new StringBuilder();
                        foreach (RuleViolation rv in objetoUsuario.GetRuleViolations())
                        {
                            sb.Append(rv.ErrorMessage + "\n");
                        }
                        throw new ApplicationException(sb.ToString());
                    }
                }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //<summary> Método que se encarga de iniciar sesión en el sistema</summary>
        //<author> Gabriela Gutiérrez Corrales </author> 
        //<param name = "pnombreUsuario"> variable de tipo String que almacena el correo electrónico del usuario  </param>
        //<param name= "pcontraseña" > variable de tipo String que almacena la contraseña del usuario  </param>
        //<returns> Retorna una lista con los usuarios que cohinciden con el nombre de usuario ingresado</returns> 

        public List<Usuario> iniciarSesion(String pnombreUsuario, String pcontraseña)
        {
            List<Usuario> listaUsuarios = new List<Usuario>();
            try
            {
                Usuario objUsuario;
                String contraseñaEncriptada = encriptar(pcontraseña);

                objUsuario = UsuarioRepository.Instance.iniciarSesion(pnombreUsuario);
              
                if (!(objUsuario == null))
                {
                   
                    if ((objUsuario.contraseña).Equals(contraseñaEncriptada))
                    {
                        listaUsuarios.Add(objUsuario);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return listaUsuarios;
        }

        //<summary> Método que se encarga recuperar la contraseña de un usuario</summary>
        //<author> Gabriela Gutiérrez Corrales </author> 
        //<param name = "pnombreUsuario"> variable de tipo String que almacena el correo electrónico del usuario  </param>
        //<param name= "pcontraseña" > variable de tipo String que almacena la contraseña del usuario  </param>
        //<returns> Retorna una lista con los usuarios que cohinciden con el nombre de usuario ingresado</returns> 


        public void recuperarContraseña(String pusuario)
        {
            Usuario usuario = UsuarioRepository.Instance.iniciarSesion(pusuario);
            if (!(usuario == null))
            {
                String contraseña = Generate(8, 10);
                //EnviarCorreo
                String encriptada = encriptar(contraseña);
                usuario.contraseña = encriptada;
                UsuarioRepository.Instance.UpdateUsuario(usuario);
               
             //Alerts.Show("Contraseña enviada al correo electrónico");
            }
            else
            {
               //Alerts.Show("El usuario ingresado es incorrecto");
            }
            }

        public IEnumerable<Usuario> buscarUsuariosPorRol(int pIdrol)
        {
            return UsuarioRepository.Instance.buscarUsuariosPorRol(pIdrol);
        }

        public void modificar(String ppNombre, String psNombre, String ppApellido, String psApellido, String pidentificacion, String ptelefono, DateTime pfechaNacimiento, String prol, int pgenero, String pcorreoElectronico, String pcontraseña, int pidUsuario)
        {
            try
            {
                DateTime fecha = pfechaNacimiento.Date;
                Rol objRol = RolRepository.Instance.GetByNombre(prol);


                Usuario objetoUsuario = ContenedorMantenimiento.Instance.crearUsuario(ppNombre, psNombre, ppApellido, psApellido, pidentificacion, ptelefono, fecha, objRol, pgenero, pcorreoElectronico, pcontraseña);
                if (objetoUsuario.IsValid)
                {
                    objetoUsuario.Id = pidUsuario;
                    UsuarioRepository.Instance.UpdateUsuario(objetoUsuario);
                }
                else
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (RuleViolation rv in objetoUsuario.GetRuleViolations())
                    {
                        sb.Append(rv.ErrorMessage + "\n");
                    }
                    throw new ApplicationException(sb.ToString());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void notificarUsuario(String correo, String contrasenna){

            Email email = null;
            email = EmailRepository.Instance.GetEmail();
            try
            {
                if (email.IsValid)
                {
                email.mensaje += " Su contraseña es: " + contrasenna;
                email.notificarUsuario(correo);
                }
                else
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (RuleViolation rv in email.GetRuleViolations())
                    {
                        sb.Append(rv.ErrorMessage + "\n");
                    }
                    throw new ApplicationException(sb.ToString());
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public void cerrarSesion(){
            Globals.usuario=null;
        }
    }
}
