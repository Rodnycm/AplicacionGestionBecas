using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesLayer;
using System.Transactions;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using TIL;
using System.Windows.Forms;
namespace DAL.Repositories
{
    public class RequisitoRepository : IRepository<Requisito>
    {

        public string actividad;
        private static RequisitoRepository instance;
        private List<IEntity> _insertItems;
        private List<IEntity> _deleteItems;
        private List<IEntity> _updateItems;
        private int numero;
        private String mensaje;
        private Excepciones exceptions = new Excepciones ();
        public static TipoBeca objTipoBeca { get; set; }

        public RequisitoRepository()
        {
            _insertItems = new List<IEntity>();
            _deleteItems = new List<IEntity>();
            _updateItems = new List<IEntity>();
        }


        //<summary> Método que se encarga de instanciar un RequisitoRepository</summary>
        //<author> Gabriela Gutiérrez Corrales </author> 
        //<param> No recibe valor  </param>
        //<returns> Retorna una instancia de la clase RequisitoRepository.</returns> 
        public static RequisitoRepository Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new RequisitoRepository() { };
                }
                return instance;
            }
        }

        //<summary> Método que se encarga de agregar un requisito a la lista de requisitos que se desean insertar</summary>
        //<author> Gabriela Gutiérrez Corrales </author> 
        //<param name "entity">  variable de tipo Requisito que contiene el objeto requisito que se desea insertar  </param>
        //<returns> No retorna valor.</returns> 
        public void Insert(Requisito entity)
        {
            _insertItems.Add(entity);
        }

        //<summary> Método que se encarga de agregar un requisito a la lista de requisitos que se desean eliminar</summary>
        //<author> Gabriela Gutiérrez Corrales </author> 
        //<param name "entity"> variable de tipo Requisito que contiene el objeto requisito que se desea eliminar  </param>
        //<returns> No retorna valor.</returns> 
        public void Delete(Requisito entity)
        {
            _deleteItems.Add(entity);
        }

        //<summary> Método que se encarga de agregar un requisito a la lista de requisitos que se desean modificar</summary>
        //<author> Gabriela Gutiérrez Corrales </author> 
        //<param name "entity">variable de tipo Requisito que contiene el objeto requisito que se desea modificar  </param>
        //<returns> No retorna valor.</returns> 
        public void Update(Requisito entity)
        {
            _updateItems.Add(entity);
        }

        //<summary> Método que se encarga de traer de la base de datos todos los requisitos registrados </summary>
        //<author> Gabriela Gutiérrez Corrales </author> 
        //<param> no recibe parametros </param>
        //<returns>Retorna una lista con todos los requisitos registrados en el sistema.</returns> 

        public IEnumerable<Requisito> GetAll()
        {
            try
            {
            List<Requisito> prequisito = new List<Requisito>();
            SqlCommand cmd = new SqlCommand();
            DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "Sp_consultarRequisitos");

            if (ds.Tables[0].Rows.Count > 0)
            {
                prequisito = new List<Requisito>();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    prequisito.Add(new Requisito
                    (                     
                        dr["Nombre"].ToString(),
                        dr["Descripcion"].ToString(),
                        Convert.ToInt32(dr["idRequisito"])
                    ));
                }
            }
            return prequisito;

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

        //<summary> Método que se encarga de traer de la base de datos un requisito específico </summary>
        //<author> Gabriela Gutiérrez Corrales </author> 
        //<param name "id"> parámetro de tipo int que contiene el Id del requisito que se desea traer </param>
        //<returns>Retorna el requisito deseado</returns> 

        public Requisito GetByNombre(String parametro)
        {

            try {
                Requisito requisito = new Requisito();
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.AddWithValue("@parametro", parametro);
                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "Sp_buscarRequisito");

            if (ds.Tables[0].Rows.Count > 0)
            {
                var dr = ds.Tables[0].Rows[0];

                    requisito = new Requisito
                {

                        nombre = dr["Nombre"].ToString(),
                        descripcion = dr["Descripcion"].ToString()
                };

                    requisito.Id = Convert.ToInt32(dr["idRequisito"]);
        }
                return requisito;
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
        public IEnumerable<Requisito> GetLista(TipoBeca objTipoBeca)
        {

            try {
                List<Requisito> prequisito = null;

                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.Add(new SqlParameter("@Nombre", objTipoBeca.nombre));

                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "Sp_consultarTipoBecaRequisito");

                if (ds.Tables[0].Rows.Count > 0)
                {
                    prequisito = new List<Requisito>();
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        prequisito.Add(new Requisito
                        (

                            dr["Nombre"].ToString(),
                            dr["Descripcion"].ToString(),
                             Convert.ToInt32(dr["idRequisito"])
                        ));
                    }
                }

                return prequisito;
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


        public IEnumerable<TipoBeca> buscarRequisitosAUnTipoBeca(int idRequisito)
        {
            try
            {
                List<TipoBeca> ptipoBeca = null;

                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.Add(new SqlParameter("@idRequisito   ", idRequisito));
                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "Sp_buscarRequisitosAUnTipoBeca");

                if (ds.Tables[0].Rows.Count > 0)
                {
                    ptipoBeca = new List<TipoBeca>();
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        ptipoBeca.Add(new TipoBeca(
                          Convert.ToInt32(dr["idTipoDeBeca"]),
                          dr["Nombre"].ToString(),
                          Convert.ToDateTime(dr["FechaCreacion"]),
                          dr["Estado"].ToString(),
                          dr["Descripcion"].ToString()));
                    }
                }

                return ptipoBeca;
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

                        foreach (Requisito objRequisito in _insertItems)
                        {
                            InsertRequisito(objRequisito);
                        }
                    }

                    if (_updateItems.Count > 0)
                    {
                        foreach (Requisito p in _updateItems)
                        {
                            UpdateRequisito(p);
                        }
                    }

                    if (_deleteItems.Count > 0)
                    {
                        foreach (Requisito p in _deleteItems)
                        {
                            DeleteRequisito(p);
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

        public Requisito GetById(int id)
        {
            try {
                Requisito objRequisito = null;
                return objRequisito;
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

        //<summary> Método que se encarga de insertar en la base de datos un requisito </summary>
        //<author> Gabriela Gutiérrez Corrales </author> 
        //<param name "objRequisto"> variable de tipo Requisito que contiene el objeto requisito que se desea insertar en la base de datos </param>
        //<returns> No retorna valor</returns> 
        private void InsertRequisito(Requisito objRequisito)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Parameters.Add(new SqlParameter("@nombre", objRequisito.nombre));
                cmd.Parameters.Add(new SqlParameter("@descripcion", objRequisito.descripcion));

                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "Sp_crearRequisito");

                actividad = "Se ha Registrado un Requisito";
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

        //<summary> Método que se encarga de modificar en la base de datos un requisito </summary>
        //<author> Gabriela Gutiérrez Corrales </author> 
        //<param name "objRequisto"> variable de tipo Requisito que contiene el objeto requisito que se desea modificar en la base de datos </param>
        //<returns> No retorna valor</returns> 
        private void UpdateRequisito(Requisito objRequisito)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Parameters.Add(new SqlParameter("@Nombre", objRequisito.nombre));
                cmd.Parameters.Add(new SqlParameter("@Descripcion", objRequisito.descripcion));
                cmd.Parameters.Add(new SqlParameter("@IdRequisito", objRequisito.Id));


                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "Sp_modificarRequisitos");
                actividad = "Se ha Modificado un Requisito";
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

        //<summary> Método que se encarga de eliminar un requisito de la base de datos </summary>
        //<author> Gabriela Gutiérrez Corrales </author> 
        //<param name "objRequisto"> variable de tipo Requisito que contiene el objeto requisito que se desea eliminar de la base de datos </param>
        //<returns> No retorna valor</returns> 
        private void DeleteRequisito(Requisito objRequisito)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.Add(new SqlParameter("@IdRequisito", objRequisito.Id));

                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "Sp_eliminarRequisito");

                actividad = "Se ha Eliminado un Requisito";
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
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void asignarRequisitoTipoBeca(Requisito objRequisito)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Parameters.Add(new SqlParameter("@idRequisito", objRequisito.Id));
                cmd.Parameters.Add(new SqlParameter("@Nombre", objTipoBeca.nombre));

                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "Sp_insertarRequisitoTipoBeca");

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
        public void asignarRequisitoTipoBeca(Requisito objRequisito, TipoBeca objTipoBeca)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Parameters.Add(new SqlParameter("@idRequisito", objRequisito.Id));
                cmd.Parameters.Add(new SqlParameter("@Nombre", objTipoBeca.nombre));


                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "Sp_insertarRequisitoTipoBeca");

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

        public void asignarRequisito()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    if (_insertItems.Count > 0)
                    {
                        foreach (Requisito objRequisito in _insertItems)
                        {
                            asignarRequisitoTipoBeca(objRequisito);

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
        public void asignarRequisito(TipoBeca objTipoBeca)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    if (_insertItems.Count > 0)
                    {
                        foreach (Requisito objRequisito in _insertItems)
                        {
                            asignarRequisitoTipoBeca(objRequisito, objTipoBeca);

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
    }
}
        
