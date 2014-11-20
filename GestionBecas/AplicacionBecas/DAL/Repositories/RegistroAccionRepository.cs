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
   public class RegistroAccionRepository
    {
       private static RegistroAccionRepository instance;
       private RegistroAccionRepository()
        {

        }

        ///<summary>Patron singleton, encargado de obtener una unica instancia de esta clase</summary>
        //<autor>Alvaro Artavia</autor>
       public static RegistroAccionRepository Instance
        {

            get
            {
                if (instance == null)
                {
                    instance = new RegistroAccionRepository() { };
                }
                return instance;
            }
        }
        public IEnumerable<RegistroAccion> getAll()
        {
            List<RegistroAccion> listaAcciones = null;
            var sqlQuery = "Sp_buscarRegistroAcciones";
            SqlCommand cmd = new SqlCommand(sqlQuery);

            var ds = DBAccess.ExecuteQuery(cmd);

            if (ds.Tables[0].Rows.Count > 0)
            {
                listaAcciones = new List<RegistroAccion>();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    listaAcciones.Add(new RegistroAccion
                    {
                        fechaAccion = Convert.ToDateTime(dr["FechaAccion"]),
                        descripcion = dr["Accion"].ToString(),
                        nombreUsuario = dr["Usuario"].ToString(),
                        nombreRol = dr["Rol"].ToString(),
                        idRegistro = Convert.ToInt32(dr["IdBitacoraAccion"])
                    });
                }
            }
            return listaAcciones;
        }

        public IEnumerable<RegistroAccion> getByDate()
        {
            List<RegistroAccion> listaAcciones = null;
            var sqlQuery = "Sp_consultarBitacoraFecha";
            SqlCommand cmd = new SqlCommand(sqlQuery);
            var ds = DBAccess.ExecuteQuery(cmd);

            if (ds.Tables[0].Rows.Count > 0)
            {
                listaAcciones = new List<RegistroAccion>();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    listaAcciones.Add(new RegistroAccion
                    {
                        fechaAccion = Convert.ToDateTime(dr["FechaAccion"]),
                        descripcion = dr["Accion"].ToString(),
                        nombreUsuario = dr["Usuario"].ToString(),
                        nombreRol = dr["Rol"].ToString(),
                        idRegistro = Convert.ToInt32(dr["IdBitacoraAccion"])
                    });
                }
            }
            return listaAcciones;
        }

        public void InsertAccion(RegistroAccion objAccion)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();



                cmd.Parameters.Add(new SqlParameter("@FechaAccion", objAccion.fechaAccion));
                cmd.Parameters.Add(new SqlParameter("@Accion", objAccion.descripcion));
                cmd.Parameters.Add(new SqlParameter("@UserName", objAccion.nombreUsuario));
                cmd.Parameters.Add(new SqlParameter("@Rol", objAccion.nombreRol));

                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "Sp_registrarAccion");

            }
            catch (Exception ex)
            {
                throw ex;

            }

        }
    }
}
