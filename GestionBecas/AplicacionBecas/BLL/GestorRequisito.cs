using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesLayer;
using DAL.Repositories;
using TIL;

namespace BLL
{
    public class GestorRequisito
    {
        //<summary> Método que se encarga de un nuevo Requisito</summary>
        //<author> Gabriela Gutiérrez Corrales </author> 
        //<param name = "pNombre"> variable de tipo String que almacena el nombre del requisito  </param>
        //<param name= "pdescripcion" > variable de tipo String que almacena la descripción del requisito  </param>
        //<returns>No retorna valor</returns> 
        public void crearRequisito(String pnombre, String pdescripcion)
        {
            try
            {
                Requisito objRequisito = ContenedorMantenimiento.Instance.crearRequisito(pnombre, pdescripcion);
                if (objRequisito.IsValid)
                {
                    RequisitoRepository.Instance.Insert(objRequisito);
                    //UoW.RequisitoRepository.Insert(objRequisito);
                }
                else
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (RuleViolation rv in objRequisito.GetRuleViolations())
                    {
                        sb.Append(rv.ErrorMessage );
                    }
                    throw new ApplicationException(sb.ToString());
                    
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }


        public IEnumerable<Requisito> consultarRequisitos()
        {
            try {
                return RequisitoRepository.Instance.GetAll();
            }
            catch (Exception ex) {
                throw ex;
            }
        }

        public IEnumerable<TipoBeca> consultarBecasPorRequisitos(int pidrequisito)
        {
            try {
                return RequisitoRepository.Instance.buscarRequisitosAUnTipoBeca(pidrequisito);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Requisito buscarRequisito(String param)
        {
          try {
              return RequisitoRepository.Instance.GetByNombre(param);
          }
          catch (Exception ex) {
              throw ex;
          }
        }
        public IEnumerable<Requisito> buscarRequisito()
        {
            try {
                return RequisitoRepository.Instance.GetAll();
            }
            catch (Exception ex){
                throw ex;
            }
        }

        public IEnumerable<Requisito> mostrarRequisitoTB(TipoBeca ptipoBeca)
        {
            try {
               
                if (RequisitoRepository.Instance.GetLista(ptipoBeca)  == null){

                    throw new ApplicationException("El tipo de beca seleccionado no tiene requisitos asignados");
                }
                else
                {
                    return RequisitoRepository.Instance.GetLista(ptipoBeca);
                }
            }
            catch (Exception ex){
                throw ex;
            }
           
        }
        //public IEnumerable<Requisito> mostrarRequisitoTB(TipoBeca ptipoBeca)
        //{

        //    return RequisitoRepository.Instance.GetLista(ptipoBeca);
        //}

        //<summary> Método que se encarga de modificcar un requisito</summary>
        //<author> Valeria Ramírez Cordero </author> 
        //<param name = "pnombre"> variable de tipo String que almacena el nombre del requisito  </param>
        //<param name = "pdescripcion"> variable de tipo String que almacena la descripción del requisito</param>
        //<param name = "pid"> variable de tipo int que almacena el id del requisito</param>
        //<returns> No retorna valor </returns> 
        public void modificarRequisito(String pnombre,String pdescripcion,int pid){

            try{
                Requisito objRequisito = ContenedorMantenimiento.Instance.crearRequisito(pnombre,pdescripcion,pid);
                RequisitoRepository.Instance.Update(objRequisito);
            }
            catch (Exception ex){

                throw ex;
            }
        }

        public void eliminarRequisito(String pnombre, String pdescripcion, int pid)
        {

            try
            {
                Requisito objRequisito = ContenedorMantenimiento.Instance.crearRequisito(pnombre, pdescripcion, pid);
                RequisitoRepository.Instance.Delete(objRequisito);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        //<summary> Método que se encarga de guardar los cambios de un requisito</summary>
        //<author> Gabriela Gutiérrez Corrales </author> 
        //<param> No recibe parametros  </param>
        //<returns> No retorna valor </returns> 
        public void guardarCambios()
        {
            try
            {
                RequisitoRepository.Instance.Save();
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
    }
}
