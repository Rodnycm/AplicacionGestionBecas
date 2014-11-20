using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesLayer;
using System.Configuration;
using System.Transactions;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using TIL;
namespace DAL.Repositories
{
    public class UsuarioRepository : IRepository<Usuario>
    {
        private string actividad;
        private static UsuarioRepository instance;
        private List<IEntity> _insertItems;
        private List<IEntity> _deleteItems;
        private List<IEntity> _updateItems;
        private static Excepciones exceptions = new Excepciones();
        private  static int numero;
        private static string mensaje;

        public UsuarioRepository()
        {
            _insertItems = new List<IEntity>();
            _deleteItems = new List<IEntity>();
            _updateItems = new List<IEntity>();
        }

        //<summary> Método que se encarga de instanciar un UsuarioRepository</summary>
        //<author> Gabriela Gutiérrez Corrales </author> 
        //<param> No recibe valor  </param>
        //<returns> Retorna una instancia de la clase UsuarioRepository.</returns> 
        public static UsuarioRepository Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UsuarioRepository() { };
                }
                return instance;
            }
        }

        //<summary> Método que se encarga de agregar un usuario a la lista de usuarios que se desean insertar</summary>
        //<author> Gabriela Gutiérrez Corrales </author> 
        //<param name "entity">  variable de tipo Usuario que contiene el objeto Usuario que se desea insertar  </param>
        //<returns> No retorna valor.</returns> 

        public void Insert(Usuario entity)
        {
            _insertItems.Add(entity);
        }

        //<summary> Método que se encarga de agregar un usuario a la lista de usuarios que se desean eliminar</summary>
        //<author> Gabriela Gutiérrez Corrales </author> 
        //<param name "entity">  variable de tipo Usuario que contiene el objeto Usuario que se desea eliminar  </param>
        //<returns> No retorna valor.</returns> 
        public void Delete(Usuario entity)
        {
            _deleteItems.Add(entity);
        }

        //<summary> Método que se encarga de agregar un usuario a la lista de usuarios que se desean modificar</summary>
        //<author> Gabriela Gutiérrez Corrales </author> 
        //<param name "entity">  variable de tipo Usuario que contiene el objeto Usuario que se desea modificar  </param>
        //<returns> No retorna valor.</returns> 
        public void Update(Usuario entity)
        {
            _updateItems.Add(entity);
        }

        //<summary> Método que se encarga de traer de la base de datos todos los usuarios registrados </summary>
        //<author> Gabriela Gutiérrez Corrales </author> 
        //<param> no recibe parametros </param>
        //<returns>Retorna una lista con todos los usuarios registrados en el sistema.</returns> 
        public IEnumerable<Usuario> GetAll()
        {
            try
            {
                List<Usuario> pusuario = null;
                SqlCommand cmd = new SqlCommand();
                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "Sp_buscarUsuarios");
                Rol rolUsuario = null;

                if (ds.Tables[0].Rows.Count > 0)
                {
                    pusuario = new List<Usuario>();

                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        int rol = Convert.ToInt32(dr["Fk_Tb_Roles_Tb_Usuarios_IdRol"]);

                        rolUsuario = RolRepository.Instance.GetById(rol);
                        Usuario objUsuario = new Usuario
                        {
                            primerNombre = dr["PrimerNombre"].ToString(),
                            segundoNombre = dr["SegundoNombre"].ToString(),
                            primerApellido = dr["PrimerApellido"].ToString(),
                            segundoApellido = dr["SegundoApellido"].ToString(),
                            identificacion = dr["Identificacion"].ToString(),
                            telefono = dr["Telefono"].ToString(),
                            fechaNacimiento = Convert.ToDateTime(dr["FechaNacimiento"]),
                            rol = rolUsuario,
                            genero = Convert.ToInt32(dr["Genero"]),
                            correoElectronico = dr["CorreoElectronico"].ToString(),
                            contraseña = dr["Contraseña"].ToString()
                        };
                        objUsuario.Id = Convert.ToInt32(dr["id"]);
                        pusuario.Add(objUsuario);
                    }
                }
                return pusuario;
            }

            catch (SqlException  ex)
            {
                numero = ex.Number;
                mensaje = exceptions.validarExcepcion(numero);
                throw new CustomExceptions.DataAccessException(mensaje, ex);
            }
            catch(Exception ex)
            {
                throw ex;
            }
         
        }

        //<summary> Método que se encarga de traer de la base de datos un usuario específico </summary>
        //<author> Gabriela Gutiérrez Corrales </author> 
        //<param name "id"> parámetro de tipo int que contiene el Id del usuario que se desea traer </param>
        //<returns>Retorna el usuario deseado</returns> 

        public Usuario GetById(int id)
        {
            try {
            Usuario objUsuario = null;
            return objUsuario;
            
            }
            catch (SqlException ex){
                numero = ex.Number;
                mensaje = exceptions.validarExcepcion(numero);
                throw new CustomExceptions.DataAccessException(mensaje, ex);
            }
            catch(Exception ex){

                throw ex;
            
            }
            
        }

        //<summary> Método que se encarga de traer de la base de datos un usuario específico </summary>
        //<author> Gabriela Gutiérrez Corrales </author> 
        //<param name "parametro"> parámetro de tipo string que contiene el nombre o identificación del usuario que se desea traer </param>
        //<returns>Retorna el usuario deseado</returns> 

        public Usuario GetByNombre(String parametro)
        {
            try {
                Usuario objUsuario = null;
                Rol rolUsuario = null;
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.AddWithValue("@parametro", parametro);

                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "Sp_buscarUnUsuario");

                if (ds.Tables[0].Rows.Count > 0)
                {
                    var dr = ds.Tables[0].Rows[0];
                    int rol = Convert.ToInt32(dr["Fk_Tb_Roles_Tb_Usuarios_IdRol"]);

                    rolUsuario = RolRepository.Instance.GetById(rol);
                    objUsuario = new Usuario
                    {
                        primerNombre = dr["PrimerNombre"].ToString(),
                        segundoNombre = dr["SegundoNombre"].ToString(),
                        primerApellido = dr["PrimerApellido"].ToString(),
                        segundoApellido = dr["SegundoApellido"].ToString(),
                        identificacion = dr["Identificacion"].ToString(),
                        telefono = dr["Telefono"].ToString(),
                        fechaNacimiento = Convert.ToDateTime(dr["FechaNacimiento"]),
                        rol = rolUsuario,
                        genero = Convert.ToInt32(dr["Genero"]),
                        correoElectronico = dr["CorreoElectronico"].ToString(),
                        contraseña = dr["Contraseña"].ToString(),
                    };
                    objUsuario.Id = Convert.ToInt32(dr["id"]);
                }
                return objUsuario;
            
            }
            catch(SqlException ex) {

                numero = ex.Number;
                mensaje = exceptions.validarExcepcion(numero);
                throw new CustomExceptions.DataAccessException(mensaje, ex);
            
            }
            catch(Exception ex){

                throw ex;
            }
               
        }


        public IEnumerable<Usuario> buscarUsuariosPorRol(int pidrol)

        {
            try
            {
                List<Usuario> pusuario = null;
                SqlCommand cmd = new SqlCommand();

                cmd.Parameters.AddWithValue("@idRol", pidrol);
                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "Sp_buscarUsuariosPorRol");
                Rol rolUsuario = null;

                if (ds.Tables[0].Rows.Count > 0)
                {
                    pusuario = new List<Usuario>();

                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        int rol = Convert.ToInt32(dr["Fk_Tb_Roles_Tb_Usuarios_IdRol"]);

                        rolUsuario = RolRepository.Instance.GetById(rol);
                        Usuario objUsuario = new Usuario
                        {
                            primerNombre = dr["PrimerNombre"].ToString(),
                            segundoNombre = dr["SegundoNombre"].ToString(),
                            primerApellido = dr["PrimerApellido"].ToString(),
                            segundoApellido = dr["SegundoApellido"].ToString(),
                            identificacion = dr["Identificacion"].ToString(),
                            telefono = dr["Telefono"].ToString(),
                            fechaNacimiento = Convert.ToDateTime(dr["FechaNacimiento"]),
                            rol = rolUsuario,
                            genero = Convert.ToInt32(dr["Genero"]),
                            correoElectronico = dr["CorreoElectronico"].ToString(),
                            contraseña = dr["Contraseña"].ToString()
                        };
                        objUsuario.Id = Convert.ToInt32(dr["id"]);
                        pusuario.Add(objUsuario);

                    }
                }
                return pusuario;
            }

            catch (SqlException ex)
            {
                numero = ex.Number;
                mensaje = exceptions.validarExcepcion(numero);
                throw new CustomExceptions.DataAccessException(mensaje, ex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        //<summary> Método que se encarga de guardar en la base de datos los cambios realizados </summary>
        //<author> Gabriela Gutiérrez Corrales </author> 
        //<param> No recibe parámetros </param>
        //<returns>No retorna valor</returns> 
        public void Save()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    if (_insertItems.Count > 0)
                    {

                        foreach (Usuario objUsuario in _insertItems)
                        {
                            InsertUsuario(objUsuario);
                        }
                    }

                    if (_updateItems.Count > 0)
                    {
                        foreach (Usuario p in _updateItems)
                        {
                            UpdateUsuario(p);
                        }
                    }

                    if (_deleteItems.Count > 0)
                    {
                        foreach (Usuario p in _deleteItems)
                        {
                            DeleteUsuario(p);
                        }
                    }

                    scope.Complete();
                }
                catch (TransactionAbortedException ex)
                {
                    throw ex;
                }
                catch (ApplicationException ex)
                {
                    throw ex;
                }
                finally
                {
                    Clear();
                }

            }
        }

        //<summary> Método que se encarga limpiar todas las listas </summary>
        //<author> Gabriela Gutiérrez Corrales </author> 
        //<param> No recibe parámetros </param>
        //<returns>No retorna valor </returns> 
        public void Clear()
        {
            _insertItems.Clear();
            _deleteItems.Clear();
            _updateItems.Clear();
        }

        //<summary> Método que se encarga de insertar en la base de datos un usuario </summary>
        //<author> Gabriela Gutiérrez Corrales </author> 
        //<param name "objUsuario"> variable de tipo Usuario que contiene el objeto usuario que se desea insertar en la base de datos </param>
        //<returns> No retorna valor</returns> 
        private void InsertUsuario(Usuario objUsuario)
        {

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.Add(new SqlParameter("@nombre", objUsuario.primerNombre));
                cmd.Parameters.Add(new SqlParameter("@segundoNombre", objUsuario.segundoNombre));
                cmd.Parameters.Add(new SqlParameter("@primerApellido", objUsuario.primerApellido));
                cmd.Parameters.Add(new SqlParameter("@segundoApellido", objUsuario.segundoApellido));
                cmd.Parameters.Add(new SqlParameter("@identificacion", objUsuario.identificacion));
                cmd.Parameters.Add(new SqlParameter("@telefono", objUsuario.telefono));
                cmd.Parameters.Add(new SqlParameter("@fechaNacimiento", objUsuario.fechaNacimiento));
                cmd.Parameters.Add(new SqlParameter("@rol", objUsuario.rol.Nombre));
                cmd.Parameters.Add(new SqlParameter("@genero", objUsuario.genero));
                cmd.Parameters.Add(new SqlParameter("@correoElectronico", objUsuario.correoElectronico));
                cmd.Parameters.Add(new SqlParameter("@contraseña", objUsuario.contraseña));

                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "Sp_crearUsuario");

                actividad = "Se ha registrado un Usuario";
                registrarAccion(actividad);
            }

            catch (SqlException ex)
            {
                
                numero = ex.Number;
                mensaje = exceptions.excepciones(numero);
               throw new CustomExceptions.DataAccessException(mensaje, ex);

            }
            catch (Exception ex)
            {

                throw ex;
              
            }
        }


        //<summary> Método que se encarga de modificar en la base de datos un usuario </summary>
        //<author> Gabriela Gutiérrez Corrales </author> 
        //<param name "objRequisto"> variable de tipo Usuario que contiene el objeto usuario que se desea modificar en la base de datos </param>
        //<returns> No retorna valor</returns> 

        public void UpdateUsuario(Usuario objUsuario)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Parameters.Add(new SqlParameter("@id", objUsuario.Id));
                cmd.Parameters.Add(new SqlParameter("@nombre", objUsuario.primerNombre));
                cmd.Parameters.Add(new SqlParameter("@segundoNombre", objUsuario.segundoNombre  ));
                cmd.Parameters.Add(new SqlParameter("@primerApellido", objUsuario.primerApellido));
                cmd.Parameters.Add(new SqlParameter("@segundoApellido", objUsuario.segundoApellido));
                cmd.Parameters.Add(new SqlParameter("@identificacion", objUsuario.identificacion));
                cmd.Parameters.Add(new SqlParameter("@telefono", objUsuario.telefono));
                cmd.Parameters.Add(new SqlParameter("@fechaNacimiento", objUsuario.fechaNacimiento));
                cmd.Parameters.Add(new SqlParameter("@rol", objUsuario.rol.Nombre));
                cmd.Parameters.Add(new SqlParameter("@genero", objUsuario.genero));
                cmd.Parameters.Add(new SqlParameter("@correoElectronico", objUsuario.correoElectronico));
                cmd.Parameters.Add(new SqlParameter("@contraseña", objUsuario.contraseña));
                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "Sp_modificarUsuario");

                actividad = "Se ha modificado un Usuario";
                registrarAccion(actividad);

            }

            catch (SqlException ex)
            {
                numero = ex.Number;
                
                mensaje = exceptions.validarExcepcion (numero );
                throw new CustomExceptions.DataAccessException(mensaje, ex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //<summary> Método que se encarga de eliminar un usuario de la base de datos </summary>
        //<author> Gabriela Gutiérrez Corrales </author> 
        //<param name "objRequisto"> variable de tipo Usuario que contiene el objeto usuario que se desea eliminar de la base de datos </param>
        //<returns> No retorna valor</returns> 
        private void DeleteUsuario(Usuario objUsuario)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.Add(new SqlParameter("@identificacion", objUsuario.identificacion));
                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "Sp_borrarUsuario");

                actividad = "Se ha eliminado un Usuario";
                registrarAccion(actividad);

            }
            catch (SqlException ex)
            {
                numero = ex.Number;
                mensaje = exceptions.validarExcepcion(numero);
                throw new CustomExceptions.DataAccessException(mensaje, ex);
             

            }
            catch (Exception ex)
            {

                throw new CustomExceptions.DataAccessException("Ha ocurrido un error al eliminar un usuario", ex);
               
            }
        }

        public static int autenticar(String pusuario, String pcontraseña)
        {
            try {
                int resultado = 1;
                SqlCommand cmd = new SqlCommand();
                return resultado;
            
            }
            catch(SqlException ex) {
                numero = ex.Number;
                mensaje = exceptions.validarExcepcion(numero);
                throw new CustomExceptions.DataAccessException(mensaje, ex);
            }
            catch(Exception ex){
                throw ex;
            }
           
        }

        public Usuario iniciarSesion(String pnombreUsuario)
        {
            try {
                Usuario objUsuario = null;

                Rol rolUsuario = null;
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.AddWithValue("@nombreUsuario", pnombreUsuario);

                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "Sp_iniciarSesion");

                if (ds.Tables[0].Rows.Count > 0)
                {
                    var dr = ds.Tables[0].Rows[0];
                    int rol = Convert.ToInt32(dr["Fk_Tb_Roles_Tb_Usuarios_IdRol"]);

                    rolUsuario = RolRepository.Instance.GetById(rol);
                    objUsuario = new Usuario
                    {
                        primerNombre = dr["PrimerNombre"].ToString(),
                        segundoNombre = dr["SegundoNombre"].ToString(),
                        primerApellido = dr["PrimerApellido"].ToString(),
                        segundoApellido = dr["SegundoApellido"].ToString(),
                        identificacion = dr["Identificacion"].ToString(),
                        telefono = dr["Telefono"].ToString(),
                        fechaNacimiento = Convert.ToDateTime(dr["FechaNacimiento"]),
                        rol = rolUsuario,
                        genero = Convert.ToInt32(dr["Genero"]),
                        correoElectronico = dr["CorreoElectronico"].ToString(),
                        contraseña = dr["Contraseña"].ToString(),
                    };
                    objUsuario.Id = Convert.ToInt32(dr["id"]);
                }
                return objUsuario;
            
            }
            catch (SqlException ex)
            {
                numero = ex.Number;
                mensaje = exceptions.validarExcepcion(numero);
                throw new CustomExceptions.DataAccessException(mensaje, ex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Usuario> GetDirectoresAcademicos()
        {

            try {

                List<Usuario> pusuario = null;
                SqlCommand cmd = new SqlCommand();
                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "Sp_buscarDirectoresAcademicos");
                Rol rolUsuario = null;

                if (ds.Tables[0].Rows.Count > 0)
                {
                    pusuario = new List<Usuario>();

                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        int rol = Convert.ToInt32(dr["Fk_Tb_Roles_Tb_Usuarios_IdRol"]);

                        rolUsuario = RolRepository.Instance.GetById(rol);
                        Usuario objUsuario = new Usuario
                        {
                            primerNombre = dr["PrimerNombre"].ToString(),
                            segundoNombre = dr["SegundoNombre"].ToString(),
                            primerApellido = dr["PrimerApellido"].ToString(),
                            segundoApellido = dr["SegundoApellido"].ToString(),
                            identificacion = dr["Identificacion"].ToString(),
                            telefono = dr["Telefono"].ToString(),
                            fechaNacimiento = Convert.ToDateTime(dr["FechaNacimiento"]),
                            rol = rolUsuario,
                            genero = Convert.ToInt32(dr["Genero"]),
                            correoElectronico = dr["CorreoElectronico"].ToString(),
                            contraseña = dr["Contraseña"].ToString(),
                        };
                        objUsuario.Id = Convert.ToInt32(dr["id"]);
                        pusuario.Add(objUsuario);
                    }
                }
                return pusuario;
            
            
            }
            catch (SqlException ex) {
                numero = ex.Number;
                mensaje = exceptions.validarExcepcion(numero);
                throw new CustomExceptions.DataAccessException(mensaje, ex);
            
            }
            catch (Exception ex) {
                throw ex;
            }
        }
        public void registrarAccion(string pactividad)
        {

            RegistroAccion objRegistro;
            DateTime fecha = DateTime.Today;
            string nombreUsuario = Globals.usuario.primerNombre +" "+ Globals.usuario.primerApellido;
            string nombreRol = Globals.usuario.rol.Nombre;
            string descripcion = pactividad;


            objRegistro = new RegistroAccion(nombreUsuario, nombreRol, descripcion, fecha);

            try
            {
                RegistroAccionRepository.Instance.InsertAccion(objRegistro);
            }
            catch (SqlException ex)
            {
                numero = ex.Number;
                mensaje = exceptions.validarExcepcion(numero);
                throw new CustomExceptions.DataAccessException(mensaje, ex);
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
