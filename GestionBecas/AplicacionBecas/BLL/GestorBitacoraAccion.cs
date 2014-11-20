using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntitiesLayer;
using DAL;
using DAL.Repositories;


namespace BLL
{
    public class GestorBitacoraAccion
    {
        public IEnumerable<RegistroAccion>consultarBitacoraAccionesFecha()
        {
            return RegistroAccionRepository.Instance.getByDate();
        }
    }
}
