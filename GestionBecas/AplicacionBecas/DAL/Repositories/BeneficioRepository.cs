using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntitiesLayer;
using System.Collections;
using System.Transactions;
using System.Data.SqlClient;
using System.Data;
using TIL;
using DAL.Repositories;
using System.Windows.Forms;

namespace DAL
{
    public class BeneficioRepository : IRepository<Beneficio>
    {

        private string actividad;
        public static TipoBeca objTipoBeca { get; set; }
        private static BeneficioRepository instance;
        private List<IEntity> _insertItems;
        private List<IEntity> _deleteItems;
        private List<IEntity> _updateItems;
        private static Excepciones exceptions = new Excepciones();
        private static int numero;
        private static string mensaje;

        /// <summary>
        /// Es el constructor del repositorio.
        /// Instancia las listas de beneficios.
        /// </summary>
        /// <author>Mathias Muller</author>

        public BeneficioRepository()
        {
            _insertItems = new List<IEntity>();
            _deleteItems = new List<IEntity>();
            _updateItems = new List<IEntity>();
        }

        public static BeneficioRepository Instance
        {

            get
            {
                if (instance == null)
                {
                    instance = new BeneficioRepository() { };
                }
                return instance;
            }
        }

        /// <summary>
        /// Agrega un beneficio a la lista de insertar.
        /// </summary>
        /// <author>Mathias Muller</author>
        /// <returns>Una Liste de beneficios</returns>

        public void Insert(Beneficio entity)
        {
            _insertItems.Add(entity);
        }
        /// <summary>
        /// Agrega un beneficio a la lista de eliminar.
        /// </summary>
        /// <author>Mathias Muller</author>

        public void Delete(Beneficio entity)
        {
            _deleteItems.Add(entity);
        }

        /// <summary>
        /// Agrega un beneficio a la lista de editar.
        /// </summary>
        /// <author>Mathias Muller</author>

        public void Update(Beneficio entity)
        {
            _updateItems.Add(entity);
        }

        /// <summary>
        /// Trae un DataSet de la base de datos.
        /// Por cada DataRow en el DataSet, instancia un beneficio.
        /// </summary>
        /// <author>Mathias Muller</author>
        /// <returns>Una lista de beneficios</returns>
        public IEnumerable<Beneficio> GetLista(TipoBeca objTipoBeca)
        {

            List<Beneficio> pbeneficio = null;

            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.Add(new SqlParameter("@Nombre", objTipoBeca.nombre));

            DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "Sp_consultarTipoBecaBeneficios");

            if (ds.Tables[0].Rows.Count > 0)
            {
                pbeneficio = new List<Beneficio>();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    pbeneficio.Add(new Beneficio
                    {
                        Id = Convert.ToInt32(dr["idBeneficio"]),
                        Nombre = dr["Nombre"].ToString(),
                        Porcentaje = Convert.ToDouble(dr["Porcentaje"]),
                        Aplicacion = dr["Aplicabilidad"].ToString()
                    });
                }
            }

            return pbeneficio;
        }

        /// <summary>
        /// Trae un DataSet de la base de datos.
        /// Por cada DataRow en el DataSet, instancia un beneficio.
        /// </summary>
        /// <author>Mathias Muller</author>
        public IEnumerable<Beneficio> GetAll()
        {

            try
            {

                List<Beneficio> listaBeneficios = null;
                var sqlQuery = "Sp_buscarBeneficios";
                SqlCommand cmd = new SqlCommand(sqlQuery);

                var ds = DBAccess.ExecuteQuery(cmd);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    listaBeneficios = new List<Beneficio>();
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        listaBeneficios.Add(new Beneficio
                        {
                            Id = Convert.ToInt32(dr["idBeneficio"]),
                            Nombre = dr["Nombre"].ToString(),
                            Porcentaje = Convert.ToDouble(dr["Porcentaje"]),
                            Aplicacion = dr["Aplicabilidad"].ToString()
                        });
                    }
                }

                return listaBeneficios;

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
        /// Busca un beneficios, si este se encuentra asociado a un tipo de beca.
        /// </summary>
        /// <author>Mathias Muller</author>>
        /// <param name="pnombre">Es el nombre del beneficio</param>
        /// <returns></returns>
        /// 
        public IEnumerable<TipoBeca> getBeneficiosAsociados(int pid)
        {
            try
            {
                List<TipoBeca> listaBecas = null;
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.Add(new SqlParameter("@id", pid));

                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "Sp_buscarBeneficiosPorTipoDeBeca");

                if (ds.Tables[0].Rows.Count > 0)
                {
                    listaBecas = new List<TipoBeca>();
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        listaBecas.Add(new TipoBeca(
                          Convert.ToInt32(dr["idTipoDeBeca"]),
                          dr["Nombre"].ToString(),
                          Convert.ToDateTime(dr["FechaCreacion"]),
                          dr["Estado"].ToString(),
                          dr["Descripcion"].ToString()));
                    }
                }

                return listaBecas;
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

        public Beneficio GetById(int id)
        {
            Beneficio objBeneficio = null;
            //SqlCommand cmd = new SqlCommand();
            //cmd.Parameters.AddWithValue("@id", id);

            //var ds = DBAccess.ExecuteQuery(cmd);

            //if (ds.Tables[0].Rows.Count > 0)
            //{
            //    var dr = ds.Tables[0].Rows[0];

            //    objBeneficio = new Beneficio
            //    {
            //        Nombre = dr["Nombre"].ToString(),
            //        Porcentaje = Convert.ToDouble(dr["Porcentaje"]),
            //        Aplicacion = dr["Aplicabilidad"].ToString()
            //    };
            //}

            return objBeneficio;
        }

        /// <summary>
        /// Trae un DataSet de la base de datos.
        /// Instancia un beneficio, con la información que recibe de la base de datos.
        /// El beneficio se busca por el nombre.
        /// </summary>
        /// <author>Mathias Muller</author>
        /// <param name="pnombre">Es el nombre del beneficio por el cual e va a busca1r en la base de datos</param>
        /// <returns>Un objeto beneficio</returns>

        public Beneficio GetByNombre(String pnombre)
        {

            try
            {
                Beneficio objBeneficio = null;
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.Add(new SqlParameter("@Nombre", pnombre));

                var ds = DBAccess.ExecuteSPWithDS(ref cmd, "Sp_buscarBeneficioPorNombre");

                if (ds.Tables[0].Rows.Count > 0)
                {
                    var dr = ds.Tables[0].Rows[0];

                    objBeneficio = new Beneficio
                    {
                        Id = Convert.ToInt32(dr["idBeneficio"]),
                        Nombre = dr["Nombre"].ToString(),
                        Porcentaje = Convert.ToDouble(dr["Porcentaje"]),
                        Aplicacion = dr["Aplicabilidad"].ToString()
                    };
                }

                return objBeneficio;
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
        /// Este método sirve para validar si en la listas globales hay información, dependiendo de la lista, aquí se llama al método para insertar, modificar o eliminar.
        /// </summary>
        /// <author>Mathias Muller</author>

        public void Save()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    if (_insertItems.Count > 0)
                    {
                        foreach (Beneficio objBeneficio in _insertItems)
                        {
                            InsertBeneficio(objBeneficio);
                        }
                    }

                    if (_updateItems.Count > 0)
                    {
                        foreach (Beneficio objBeneficio in _updateItems)
                        {
                            UpdateBeneficio(objBeneficio);
                        }
                    }

                    if (_deleteItems.Count > 0)
                    {
                        foreach (Beneficio objBeneficio in _deleteItems)
                        {
                            DeleteBeneficio(objBeneficio);
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
        /// Limpia la información en las listas globales.
        /// </summary>
        /// <author>Mathias Muller</author>
        public void Clear()
        {
            _insertItems.Clear();
            _deleteItems.Clear();
            _updateItems.Clear();
        }

        /// <summary>
        /// Inserta un beneficio en la base de datos.
        /// </summary>
        /// <author>Mathias Muller</author>

        private void InsertBeneficio(Beneficio objBeneficio)
        {


            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Parameters.Add(new SqlParameter("@Nombre", objBeneficio.Nombre));
                cmd.Parameters.Add(new SqlParameter("@Porcentaje", objBeneficio.Porcentaje));
                cmd.Parameters.Add(new SqlParameter("@Aplicabilidad", objBeneficio.Aplicacion));

                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "Sp_crearBeneficio");


                actividad = "Se ha registrado un Beneficio";
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
        /// Modifica un beneficio en la base de datos.
        /// </summary>
        /// <author>Mathias Muller</author>

        private void UpdateBeneficio(Beneficio objBeneficio)
        {

            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Parameters.Add(new SqlParameter("@Id", objBeneficio.Id));
                cmd.Parameters.Add(new SqlParameter("@Nombre", objBeneficio.Nombre));
                cmd.Parameters.Add(new SqlParameter("@Porcentaje", objBeneficio.Porcentaje));
                cmd.Parameters.Add(new SqlParameter("@Aplicabilidad", objBeneficio.Aplicacion));


                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "Sp_modificarBeneficio");


                actividad = "Se ha modificado un Beneficio";
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
        /// Elimina un beneficio de la base de datos.
        /// </summary>
        /// <author>Mathias Muller</author>

        private void DeleteBeneficio(Beneficio objBeneficio)
        {

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.Add(new SqlParameter("@id", objBeneficio.Id));
                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "Sp_eliminarBeneficio");


                actividad = "Se ha Eliminado un Beneficio";
                registrarAccion(actividad);
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
        public void asignarBeneficioTipoBeca(Beneficio objBeneficio)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Parameters.Add(new SqlParameter("@idBeneficio", objBeneficio.Id));
                cmd.Parameters.Add(new SqlParameter("@Nombre", objTipoBeca.nombre));

                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "Sp_insertarTipoBecaCompleto");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;

            }
        }
        public void asignarBeneficio()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    if (_insertItems.Count > 0)
                    {
                        foreach (Beneficio objBeneficio in _insertItems)
                        {
                            asignarBeneficioTipoBeca(objBeneficio);

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
        public void asignarBeneficioTipoBeca(Beneficio objBeneficio, TipoBeca objTipoBeca)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Parameters.Add(new SqlParameter("@idBeneficio", objBeneficio.Id));
                cmd.Parameters.Add(new SqlParameter("@idTipoBeca", objTipoBeca.nombre ));


                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "Sp_insertarBeneficiosTiposBeca");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                throw ex;
            }
        }
        public void asignarBeneficio(TipoBeca objTipoBeca)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    if (_insertItems.Count > 0)
                    {
                        foreach (Beneficio objBeneficio in _insertItems)
                        {
                            asignarBeneficioTipoBeca(objBeneficio, objTipoBeca);

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
