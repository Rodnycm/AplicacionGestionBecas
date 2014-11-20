using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class Permiso : IEntity
    {
        private int idPermiso;
        public int Id
        {
            get { return idPermiso; }
            set { idPermiso = value; }
        }
        public String Nombre { get; set; }
        public String Descripción { get; set; }


        /// <summary>
        /// crea un nuevo permisos sin parametros
        /// </summary>
        public Permiso()
        {
            Id = 0;
            Nombre = "";
            Descripción = "";
        }


        /// <summary>
        /// Crea un nuevo permiso
        /// </summary>
        /// <param name="pnombre">nombre del permiso</param>
        /// <param name="pDescripción">descripcion del permiso</param>
        public Permiso(String pnombre, String pDescripción)
        {
            Id = 0;
            Nombre = pnombre;
            Descripción = pDescripción;
        }
    }
}




