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
    public class TipoBecaRepository : IRepository<TipoBeca>
    {
        private string actividad;
        private static int numero;
        private static string mensaje;
        private static Excepciones exceptions = new Excepciones();
        private static TipoBecaRepository instance;
        private List<IEntity> _insertItems;
        private List<IEntity> _deleteItems;
        private List<IEntity> _updateItems;

        /// <summary>
        /// Constructor del repositorio
        /// Contiene las instancias de las listas delos tipos de beca de insertar, eliminar y modificar.
        /// </summary>
        ///<author>María Jesús Gutiérrez</author>
        public TipoBecaRepository()
        {
            _insertItems = new List<IEntity>();
            _deleteItems = new List<IEntity>();
            _updateItems = new List<IEntity>();
        }

        /// <summary>
        /// Encargado de agregar un tipo de beca a la lista de insertar.
        /// </summary>
        /// <author>María Jesús Gutiérrez</author>
        /// <param name="entity"></param>
        public void Insert(TipoBeca entity)
        {
            _insertItems.Add(entity);
        }

        /// <summary>
        ///Encargado de agregar un tipo de beca a la lista de eliminar.
        /// </summary>
        ///<author>María Jesús Gutiérrez</author>
        /// <param name="entity"></param>
        public void Delete(TipoBeca entity)
        {
            _deleteItems.Add(entity);
        }

        /// <summary>
        /// Encargado de modificar un tipo de beca a la lista de modificar.
        /// </summary>
        /// <author>María Jesús Gutiérrez</author>
        /// <param name="entity"></param>
        public void Update(TipoBeca entity)
        {
            _updateItems.Add(entity);
        }

        /// <summary>
        /// Método que valida las instancias del TipoBecaRepository
        /// Crea una instancia cuando esta no se haya encontrado, de lo contrario utiliza la ya creada.
        /// </summary>
        /// <author>María Jesús Gutiérrez</author>
        public static TipoBecaRepository Instance
        {

            get
            {
                if (instance == null)
                {
                    instance = new TipoBecaRepository() { };
                }
                return instance;
            }
        }

        /// <summary>
        /// Encargado de traer el data set de la base de datos.
        /// Contiene DataRow que por cada uno que tenga, este instancia un tipo de beca.
        /// </summary>
        /// <author>María Jesús Gutiérrez</author>
        /// <returns>Retorna una lista de tipo de beca</returns>
        public IEnumerable<TipoBeca> GetAll()
        {

            try {
                List<TipoBeca> ptipoBeca = null;
                SqlCommand cmd = new SqlCommand();
                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "Sp_consultaTipoBeca");
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

        /// <summary>
        /// Método que tiene un data set de la base de datos.
        /// Instancia un tipo de beca de acuerdo a la información enviada a la base de datos.
        /// El tipo de beca es buscado por el nombre
        /// </summary>
        /// <author>María Jesús Gutiérrez</author>
        /// <param name="id"></param>
        /// <returns>Retorna un objeto de tipo beca</returns>
        public TipoBeca GetByNombre(string pnombre)
        {

          try
            {
            TipoBeca objTipoBeca = null;
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.Add(new SqlParameter("@Nombre", pnombre));
            var ds = DBAccess.ExecuteSPWithDS(ref cmd, "Sp_buscarTipoBecaNombre");

            if (ds.Tables[0].Rows.Count > 0)
            {
                var dr = ds.Tables[0].Rows[0];



                    objTipoBeca = new TipoBeca
                    (
                        Convert.ToInt32(dr["idTipoDeBeca"]),
                        dr["Nombre"].ToString(),
                        Convert.ToDateTime(dr["FechaCreacion"]),
                        dr["Estado"].ToString(),
                        dr["Descripcion"].ToString()
                  );

                    objTipoBeca.listaRequisitos = asociarRequisitos(objTipoBeca.Id);
                    objTipoBeca.listaBeneficios = asociarBeneficios(objTipoBeca.Id);

            }
                return objTipoBeca;
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

        /// <summary>
        /// Método que contiene un data set de la base de datos.
        /// Instancia un tipo de beca de acuerdo a la información enviada.
        /// El tipo de beca es buscado por el id
        /// </summary>
        /// <author>María Jesús Gutiérrez</author>
        /// <param name="id"></param>
        /// <returns>Retorna un objeto de tipo beca</returns>
        public TipoBeca GetById(int id)
        {
            try {
                TipoBeca objTipoBeca = null;
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.AddWithValue("@idTipoDeBeca", id);

                var ds = DBAccess.ExecuteQuery(cmd);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    var dr = ds.Tables[0].Rows[0];

                    objTipoBeca = new TipoBeca
                    (
                        Convert.ToInt32(dr["idTipoDeBeca"]),
                        dr["Nombre"].ToString(),
                        Convert.ToDateTime(dr["FechaCreacion"]),
                        dr["Estado"].ToString(),
                        dr["Descripcion"].ToString()
                  );
                }
                return objTipoBeca;
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
        /// <summary>
        /// Método encargado de validar cada una de las listas de insertar, modificar y eliminar.
        /// Este válida si hay o no información en cada lista.
        /// </summary>
        /// <author>María Jesús Gutiérrez</author>
        public void Save()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    if (_insertItems.Count > 0)
                    {
                        foreach (TipoBeca objTipoBeca in _insertItems)
                        {
                            InsertTipoBeca(objTipoBeca);
                            //throw new Exception("No se pudo insertar el tipo de beca");
                        }
                    }

                    if (_updateItems.Count > 0)
                    {
                        foreach (TipoBeca objTipoBeca in _updateItems)
                        {
                            UpdateTipoBeca(objTipoBeca);
                        }
                    }

                    if (_deleteItems.Count > 0)
                    {
                        foreach (TipoBeca objTipoBeca in _deleteItems)
                        {
                            DeleteTipoBeca(objTipoBeca);
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

        /// <summary>
        /// Método que limpia la información en las listas globales.
        /// </summary>
        /// <author>Maria Jesús Gutiérrez</author>
        public void Clear()
        {
            _insertItems.Clear();
            _deleteItems.Clear();
            _updateItems.Clear();
        }

        /// <summary>
        /// Método que inserta un tipo de beca en la base de datos
        /// </summary>
        /// <author>María Jesús Gutiérrez</author>
        /// <param name="objTipoBeca"></param>
        private void InsertTipoBeca(TipoBeca objTipoBeca)
        {

            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Parameters.Add(new SqlParameter("@nombre", objTipoBeca.nombre));
                cmd.Parameters.Add(new SqlParameter("@fechaCreacion", objTipoBeca.objD ));
                cmd.Parameters.Add(new SqlParameter("@estado", objTipoBeca.estado));
                cmd.Parameters.Add(new SqlParameter("@descripcion", objTipoBeca.descripcion));

                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "Sp_agregarTipoBeca");

                actividad = "Se ha registrado un Tipo De Beca";
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

        /// <summary>
        /// Método que modifica un tipo de beca en la base de datos.
        /// </summary>
        /// <author>María Jesús Gutiérrez</author>
        /// <param name="objTipoBeca"></param>
        private void UpdateTipoBeca(TipoBeca objTipoBeca)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Parameters.Add(new SqlParameter("@id", objTipoBeca.Id));
                cmd.Parameters.Add(new SqlParameter("@nombre", objTipoBeca.nombre));
                cmd.Parameters.Add(new SqlParameter("@estado", objTipoBeca.estado));
                cmd.Parameters.Add(new SqlParameter("@descripcion", objTipoBeca.descripcion));


                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "Sp_modificarTipoBeca");

                actividad = "Se ha modificado un Tipo De Beca";
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

        /// <summary>
        /// Método que elimina un tipo de beca en la base de datos
        /// </summary>
        /// <author>María Jesús Gutiérrez</author>
        /// <param name="objTipoBeca"></param>
        private void DeleteTipoBeca(TipoBeca objTipoBeca)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.Add(new SqlParameter("@nombre", objTipoBeca.nombre));
                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "Sp_eliminarTipoBeca");

                actividad = "Se ha eliminado un Tipo de Beca";
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
        //public void asignarBeneficiosTipoBeca(TipoBeca objTipoBeca, Beneficio objBeneficio)
        //{

        //}
        //public void asignarRequisitosTipoBeca(TipoBeca objTipoBeca, Requisito objRequisito)
        //{

        //}
        /// <summary>
        /// Método que asocia requisitos a un tipo de beca
        /// </summary>
        /// <author>María Jesús Gutiérrez Calvo</author>
        /// <param name="pid">id del tipo de beca al cual se desea asignar requisitos</param>
        /// <returns>retorna una lista de requisitos</returns>
        private List<Requisito> asociarRequisitos(int pid)
        {
            try
            {
                List<Requisito> prequisito = new List<Requisito>();

                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.Add(new SqlParameter("@id", pid));

                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "Sp_buscarRequisitosTipoBeca");

                if (ds.Tables[0].Rows.Count > 0)
                {
                    //prequisito = new List<Requisito>();
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
        /// <summary>
        /// Método que asocia beneficios a un tipo de beca
        /// </summary>
        /// <author>María Jesús Gutiérrez Calvo</author>
        /// <param name="pid">id del tipo de beca al que se le asocia los beneficios</param>
        /// <returns>retorna una lista de beneficios</returns>
        private List<Beneficio> asociarBeneficios(int pid)
        {
            try
            {
                List<Beneficio> pbeneficio = new List<Beneficio>();
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.Add(new SqlParameter("@id", pid));
                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "Sp_buscarBeneficiosTipoBeca");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        pbeneficio.Add(new Beneficio
                            (
                             Convert.ToInt32(dr["idBeneficio"]),
                             dr["Nombre"].ToString(),
                             Convert.ToDouble(dr["Porcentaje"]),""
                            //dr["Aplicabilidad"].ToString()
                            ));
                    }
                }
                return pbeneficio;
            }
            catch (SqlException e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Método que registra una acción realizada.
        /// </summary>
        /// <param name="pactividad"></param>
        public void registrarAccion(string pactividad)
        {

            RegistroAccion objRegistro;
            DateTime fecha = DateTime.Today;
            string nombreUsuario = Globals.usuario.primerNombre;
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
        /// <summary>
        /// Método que busca los beneficios asociados a un tipo de beca por medio del id del tipo de beca
        /// </summary>
        /// <author>María Jesús Gutiérrez Calvo</author>
        /// <param name="pid">id del tipo de beca con el que se busca los beneficios que están asociados a ese tipo de beca en específico</param>
        /// <returns>retorna una lista de beneficios</returns>
            public List<Beneficio> buscarBeneficiosRelacionadosTipoBeca(int pid)
        {
            try
            {
                List<Beneficio> pbeneficio = new List<Beneficio>();
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.Add(new SqlParameter("@id", pid));
                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "Sp_obtenerBeneficiosTipoBeca");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        pbeneficio.Add(new Beneficio
                            (
                            id = Convert.ToInt32(dr["Fk_Tb_Beneficios_Tb_BecaBeneficios_idBeneficio"])
                            
                            ));
                    }
                }
                return pbeneficio;
            }
            catch (SqlException e)
            {
                throw e;
            }
        }

        public int id { get; set; }

        /// <summary>
        /// Método que busca los requisitos que están relacionados a un tipo de beca en específico
        /// </summary>
        /// <author>María Jesús Gutiérrez Calvo</author>
        /// <param name="pid"> id del tipo de beca con el que se buscan los requisitos que están relacionados a ese id del tipo de beca</param>
        /// <returns>retorna una lista de requisitos</returns>
        public List<Requisito> buscarRequisitosRelacionadosTipoBeca(int pid)
        {
            try
            {


                List<Requisito> prequisito = new List<Requisito>();
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.Add(new SqlParameter("@id", pid));
                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "Sp_obtenerRequisitoTipoBeca");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        prequisito.Add(new Requisito
                            (
                            id = Convert.ToInt32(dr["Fk_Tb_Requisitos_Tb_RequisitosTipoBeca_idRequisito"])

                            ));
                    }
                }
                return prequisito;
            }
            catch (SqlException e)
            {
                throw e;
            }
        }
        /// <summary>
        /// Método que elimina los requisitos relacionados a un tipo de beca
        /// </summary>
        /// <author>María Jesús Gutiérrez Calvo</author>
        /// <param name="id">id del tipo de beca con el que se busca los requisitos relacionados a ese tipo de beca</param>
        public void DeleteRequisitoTipoBeca(int id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.Add(new SqlParameter("@id",id));
                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "Sp_eliminarRequisitosTipoBeca");

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
        /// <summary>
        /// Método que elimina los beneficios relacionados a ese tipo de beca
        /// </summary>
        /// <author>María Jesús Gutiérrez Calvo</author>
        /// <param name="id">id del tipo de beca con el que se busca los beneficios asociados a ese tipo de beca</param>
        public void DeleteBeneficioTipoBeca(int id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.Add(new SqlParameter("@id", id));
                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "Sp_eliminarBeneficiosTipoBeca");
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
    

        }
    }
   




