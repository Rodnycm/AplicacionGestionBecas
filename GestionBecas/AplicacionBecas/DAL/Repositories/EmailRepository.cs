using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntitiesLayer;
using System.Collections;
using System.Transactions;
using System.Data.SqlClient;
using System.Data;

namespace DAL.Repositories
{

    public class EmailRepository : IRepository<Email>
    {

        private static EmailRepository instance;
        private List<IEntity> _insertItems;
        private List<IEntity> _deleteItems;
        private List<IEntity> _updateItems;
        private EmailRepository()
        
        {
            _insertItems = new List<IEntity>();
            _deleteItems = new List<IEntity>();
            _updateItems = new List<IEntity>();
        }

        ///<summary>Patron singleton, encargado de obtener una unica instancia de esta clase</summary>
        //<autor>Alvaro Artavia</autor>
        public static EmailRepository Instance
        {

            get
            {
                if (instance == null)
                {
                    instance = new EmailRepository() { };
                }
                return instance;
            }
        }

        ///<summary>Agrega a la lista los objetos que se deseam eliminar,modificar o insertar</summary>
        ///<param name="entity">Objeto a ingresar a la lista</param>
        //<autor>Alvaro Artavia</autor>

        public void Insert(Email entity)
        {
            _insertItems.Add(entity);
        }

        public void Delete(Email entity)
        {
            _deleteItems.Add(entity);
        }

        public void Update(Email entity)
        {
            _updateItems.Add(entity);
        }

        ///<summary>Obtiene de la base de datos todos los elementos en la tabla carreras</summary>
        ///<returns>Retorna una coleccion de objetos de tipo carrera<retruns>
        //<autor>Alvaro Artavia</autor>

        public IEnumerable<Email> GetAll()
        {          
            List<Email> email = null;
           
            return email;
        }

        public Email GetEmail()
        {

            Email email = null;
            SqlCommand cmd = new SqlCommand();
            DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "Sp_consultarEmail");

            if (ds.Tables[0].Rows.Count > 0)
            {
                var dr = ds.Tables[0].Rows[0];
                email = new Email
                {
                    emisor = dr["Emisor"].ToString(),
                    asunto = dr["Asunto"].ToString(),
                    mensaje = dr["Mensaje"].ToString(),
                    smtpServidor = dr["SmtpServidor"].ToString(),
                    userName = dr["UserName"].ToString(),
                    contrasenna = dr["Contraseña"].ToString(),
                    receptor = dr["Receptor"].ToString(),
                    Id = Convert.ToInt32(dr["idEmail"])
                };
            }
            return email;
        }

        ///<summary>Modifica en la base de datos un objeto carrera</summary>
        ///<param name="objCarrera">Objeto de tipo carrera</param>
        //<autor>Alvaro Artavia</autor>

        public void UpdateEmail(Email email)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.Add(new SqlParameter("@Emisor", email.emisor));
                cmd.Parameters.Add(new SqlParameter("@Asunto", email.asunto));
                cmd.Parameters.Add(new SqlParameter("@SmtpServidor", email.smtpServidor));
                cmd.Parameters.Add(new SqlParameter("@UserName", email.userName));
                cmd.Parameters.Add(new SqlParameter("@Contrasenna", email.contrasenna));
                cmd.Parameters.Add(new SqlParameter("@Mensaje", email.mensaje));
                cmd.Parameters.Add(new SqlParameter("@idEmail", email.Id));
                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "Sp_modificarEmail");

            }
            catch (Exception ex)
            {

            }
        }

        public Email GetByNombre(String parametro)
        {

            Email email = new Email();
            return email;
        }

        public Email GetById(int id)
        {

            Email email = null;
            return email;
        }

        ///<summary>Metodo encargado de llamar a los metodos eliminar,insertar o modificar dependiendo 
        ///de la cantidad de objetos encontrados en la coleccion</summary>
        //<autor>Alvaro Artavia</autor>

        public void Save()
        {

            using (TransactionScope scope = new TransactionScope())
            {
                try
                {

                    if (_insertItems.Count > 0)
                    {

                        foreach (Email email in _insertItems)
                        {
                            InsertEmail(email);
                        }
                    }

                    if (_updateItems.Count > 0)
                    {
                        foreach (Email p in _updateItems)
                        {
                            UpdateEmail(p);
                        }
                    }

                    if (_deleteItems.Count > 0)
                    {
                        foreach (Email p in _deleteItems)
                        {
                            DeleteEmail(p);
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

        ///<summary>Vacia las colecciones</summary>
        //<autor>Alvaro Artavia</autor>

        public void Clear()
        {
            _insertItems.Clear();
            _deleteItems.Clear();
            _updateItems.Clear();
        }

        ///<summary>Inserta en la base de datos un objeto carrera</summary>
        ///<param name="objCarrera">Objeto de tipo carrera</param>
        //<autor>Alvaro Artavia</autor>

        private void InsertEmail(Email objCarrera)
        {

        }

      
        ///<summary>Elimina en la base de datos un objeto carrera</summary>
        ///<param name="objCarrera">Objeto de tipo carrera</param>
        //<autor>Alvaro Artavia</autor>

        private void DeleteEmail(Email email)
        {
         
        }
    }
}
