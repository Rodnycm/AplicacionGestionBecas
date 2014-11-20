using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntitiesLayer;
using System.Collections;
using System.Transactions;
using System.Data.SqlClient;
using System.Data;
using DAL.Repositories;
using DAL;
using TIL;

namespace DAL
{

    public class CursoRepository : IRepository<Curso>
    {
        private String actividad;
        private static CursoRepository instance;
        private List<IEntity> _insertItems;
        private List<IEntity> _deleteItems;
        private List<IEntity> _updateItems;
        private static Excepciones exceptions = new Excepciones();
        private static int numero;
        private static string mensaje;

        public static Carrera objCarrera { get; set; }
        private CursoRepository()
        {
            _insertItems = new List<IEntity>();
            _deleteItems = new List<IEntity>();
            _updateItems = new List<IEntity>();
        }

        //<summary> Método que se encarga de instanciar un CursoRepository</summary>
        //<author> Valeria Ramírez Cordero </author> 
        //<param> No recibe valor  </param>
        //<returns> Retorna una instancia de la clase CursoRepository.</returns> 
        public static CursoRepository Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CursoRepository() { };
                }
                return instance;
            }
        }

        //<summary> Método que se encarga de agregar un curso a la lista de cursos que se desean insertar</summary>
        //<author> Valeria Ramírez Cordero </author> 
        //<param name "entity">  variable de tipo Curso que contiene el objeto Curso que se desea insertar  </param>
        //<returns> No retorna valor.</returns> 
        public void Insert(Curso entity)
        {
            _insertItems.Add(entity);
        }

        //<summary> Método que se encarga de agregar un curso a la lista de cursos que se desean eliminar</summary>
        //<author>  Valeria Ramírez Cordero  </author> 
        //<param name "entity">  variable de tipo Curso que contiene el objeto Curso que se desea eliminar  </param>
        //<returns> No retorna valor.</returns> 
        public void Delete(Curso entity)
        {
            _deleteItems.Add(entity);
        }

        //<summary> Método que se encarga de agregar un curso a la lista de cursos que se desean modificar</summary>
        //<author> Valeria Ramírez Cordero </author> 
        //<param name "entity">  variable de tipo Curso que contiene el objeto Curso que se desea modificar  </param>
        //<returns> No retorna valor.</returns> 
        public void Update(Curso entity)
        {
            _updateItems.Add(entity);
        }

        //<summary> Método que se encarga de traer de la base de datos todos los cursos registrados </summary>
        //<author>Valeria Ramírez Cordero</author> 
        //<param> no recibe parametros </param>
        //<returns>Retorna una lista con todos los cursos registrados en el sistema.</returns> 
        public IEnumerable<Curso> GetAll()
        {
            try
            {
                List<Curso> pCurso = null;
                SqlCommand cmd = new SqlCommand();
                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "Sp_buscarCursos");

                if (ds.Tables[0].Rows.Count > 0)
                {
                    pCurso = new List<Curso>();
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        pCurso.Add(new Curso
                        {
                            codigo = dr["Codigo"].ToString(),
                            nombre = dr["Nombre"].ToString(),
                            cuatrimestre = dr["Cuatrimestre"].ToString(),
                            creditos = Convert.ToInt32(dr["Creditos"]),
                            precio = Convert.ToDouble(dr["Precio"]),
                            Id = Convert.ToInt32(dr["IdCurso"])
                        });
                    }
                }

                return pCurso;
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

        //<summary> Método que se encarga de traer de la base de datos todos los cursos registrados </summary>
        //<author>Valeria Ramírez Cordero</author> 
        //<param> no recibe parametros </param>
        //<returns>Retorna una lista con todos los cursos registrados en el sistema.</returns> 
        //public IEnumerable<Curso> GetCuatrimestres(){
        //    try{
        //        DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "Sp_buscarCuatrimestre")
        //    }
        //    catch (SqlException ex)
        //    {
        //        numero = ex.Number;
        //        mensaje = exceptions.validarExcepcion(numero);
        //        throw new CustomExceptions.DataAccessException(mensaje, ex);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        //<summary> Método que se encarga de traer de la base de datos un curso en específico </summary>
        //<author>Valeria Ramírez Cordero</author> 
        //<param name "id"> parámetro de tipo int que contiene el Id del curso que se desea traer </param>
        //<returns>Retorna el curso deseado</returns> 
        public Curso GetById(int Id)
        {
            try
            {
                Curso objCurso = null;
                return objCurso;
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


        public IEnumerable<Curso> getCursoPorCuatrimestre(String pcuatri)
        {

            try
            {

                List<Curso> listaCursos = null;
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.AddWithValue("@Cuatrimestre", pcuatri);
                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "Sp_buscarCursoPorCuatrimestre");

                if (ds.Tables[0].Rows.Count > 0)
                {
                    listaCursos = new List<Curso>();
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        listaCursos.Add(new Curso
                        {
                            codigo = dr["Codigo"].ToString(),
                            nombre = dr["Nombre"].ToString(),
                            cuatrimestre = dr["Cuatrimestre"].ToString(),
                            creditos = Convert.ToInt32(dr["Creditos"]),
                            precio = Convert.ToDouble(dr["Precio"]),
                            //Id = Convert.ToInt32(dr["IdCurso"])
                        });
                    }
                }

                return listaCursos;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public Array consultarCursosPorCuatrimestre()
        {
            try
            {

                int i = 0;
                String cuatrimestre;
                String[] listaCursos = null;
                SqlCommand cmd = new SqlCommand();
                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "Sp_consultarCursosPorCuatrimestre");

                if (ds.Tables[0].Rows.Count > 0)
                {
                    listaCursos = new String[ds.Tables[0].Rows.Count];

                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        cuatrimestre = dr["Cuatrimestre"].ToString();

                        listaCursos[i] = cuatrimestre;
                        i = i + 1;
                    }
                }
                return listaCursos;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        //<summary> Método que se encarga de traer de la base de datos un curso específico </summary>
        //<author> Valeria Ramírez Cordero</author> 
        //<param name "parametro"> parámetro de tipo string que contiene el nombre o código del curso que se desea traer </param>
        //<returns>Retorna el curso deseado</returns> 
        public Curso GetByNombre(String pparametro)
        {
            try
            {
                Curso objCurso = null;
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.AddWithValue("@parametro", pparametro);

                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "Sp_buscarUnCurso");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    var dr = ds.Tables[0].Rows[0];
                    objCurso = new Curso
                    {
                        codigo = dr["Codigo"].ToString(),
                        nombre = dr["Nombre"].ToString(),
                        cuatrimestre = dr["Cuatrimestre"].ToString(),
                        creditos = Convert.ToInt32(dr["Creditos"]),
                        precio = Convert.ToDouble(dr["Precio"]),
                        Id = Convert.ToInt32(dr["IdCurso"])
                    };
                    //objCurso.Id = Convert.ToInt32(dr["Id"]);
                }
                return objCurso;
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
        //<author>Valeria Ramírez Cordero</author> 
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
                        foreach (Curso objCurso in _insertItems)
                        {
                            InsertCurso(objCurso);
                        }
                    }

                    if (_updateItems.Count > 0)
                    {
                        foreach (Curso p in _updateItems)
                        {
                            UpdateCurso(p);
                        }
                    }

                    if (_deleteItems.Count > 0)
                    {
                        foreach (Curso p in _deleteItems)
                        {
                            DeleteCurso(p);
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
        //<author> Valeria Ramírez Cordero </author> 
        //<param> No recibe parámetros </param>
        //<returns>No retorna valor </returns> 
        public void Clear()
        {
            _insertItems.Clear();
            _deleteItems.Clear();
            _updateItems.Clear();
        }

        //<summary> Método que se encarga de insertar en la base de datos un curso</summary>
        //<author>Valeria Ramírez Cordero</author> 
        //<param name "objCurso"> variable de tipo Curso que contiene el objeto curso que se desea insertar en la base de datos </param>
        //<returns> No retorna valor</returns> 
        private void InsertCurso(Curso objCurso)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Parameters.Add(new SqlParameter("@Codigo", objCurso.codigo));
                cmd.Parameters.Add(new SqlParameter("@Nombre", objCurso.nombre));
                cmd.Parameters.Add(new SqlParameter("@Cuatrimestre", objCurso.cuatrimestre));
                cmd.Parameters.Add(new SqlParameter("@Creditos", objCurso.creditos));
                cmd.Parameters.Add(new SqlParameter("@Precio", objCurso.precio));

                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "Sp_crearCurso ");

                actividad = "Se ha creado un Curso";
                registrarAccion(actividad);

            }catch (SqlException ex){

           
                numero = ex.Number;
                mensaje = exceptions.excepciones(numero);
                throw new CustomExceptions.DataAccessException(mensaje, ex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //<summary> Método que se encarga de modificar en la base de datos un curso </summary>
        //<author> Valeria Ramírez Cordero </author> 
        //<param name "objCurso"> variable de tipo Curso que contiene el objeto curso que se desea modificar en la base de datos </param>
        //<returns> No retorna valor</returns> 
        private void UpdateCurso(Curso objCurso)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Parameters.Add(new SqlParameter("@Codigo", objCurso.codigo));
                cmd.Parameters.Add(new SqlParameter("@Nombre", objCurso.nombre));
                cmd.Parameters.Add(new SqlParameter("@Cuatrimestre", objCurso.cuatrimestre));
                cmd.Parameters.Add(new SqlParameter("@Creditos", objCurso.creditos));
                cmd.Parameters.Add(new SqlParameter("@Precio", objCurso.precio));
                cmd.Parameters.Add(new SqlParameter("@IdCurso", objCurso.Id));

                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "Sp_modificarCursos");

                actividad = "Se ha modificado un Curso";
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
                throw ex;
            }
        }

        //<summary> Método que se encarga de eliminar un curso de la base de datos </summary>
        //<author> Valeria Ramírez Cordero </author> 
        //<param name "objCurso"> variable de tipo Curso que contiene el objeto curso que se desea eliminar de la base de datos </param>
        //<returns> No retorna valor</returns> 
        private void DeleteCurso(Curso objCurso)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.Add(new SqlParameter("@Codigo", objCurso.codigo));
                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "Sp_eliminarCurso");

                actividad = "Se ha eliminado un Curso";
                registrarAccion(actividad);

            }
            //catch (SqlException ex){
            //}
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
        public void registrarAccion(string pactividad)
        {
            RegistroAccion objRegistro;
            DateTime fecha = DateTime.Today;
            string nombreUsuario = Globals.usuario.primerNombre + " " + Globals.usuario.primerApellido;
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
        public void asignarCurso(Curso objCurso, Carrera objCarrera)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Parameters.Add(new SqlParameter("@CodigoCurso", objCurso.codigo));
                cmd.Parameters.Add(new SqlParameter("@CodigoCarrera", objCarrera.codigo));

                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "Sp_insertarCursoCarrera");

            }
            catch (Exception ex)
            {

            }
        }




        public void asignarCursoCarrera(List<Curso> listaCursos, Carrera objCarrera)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    if (listaCursos.Count > 0)
                    {
                        foreach (Curso objCurso in listaCursos)
                        {
                            asignarCurso(objCurso, objCarrera);

                        }
                    }



                    scope.Complete();
                }
                catch (TransactionAbortedException ex)
                {

                }
                catch (ApplicationException ex)
                {

                }
                finally
                {
                    Clear();
                }

            }
        }



        public void asignarCurso(Carrera objCarrera)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    if (_insertItems.Count > 0)
                    {
                        foreach (Curso objCurso in _insertItems)
                        {
                            asignarCurso(objCarrera);

                        }
                    }



                    scope.Complete();
                }
                catch (TransactionAbortedException ex)
                {

                }
                catch (ApplicationException ex)
                {

                }
                finally
                {
                    Clear();
                }

            }
        }

    }
}
        //public void asignarCurso(EntitiesLayer.Carrera objCarrera)
        //{
        //    throw new NotImplementedException();
        //}
    
