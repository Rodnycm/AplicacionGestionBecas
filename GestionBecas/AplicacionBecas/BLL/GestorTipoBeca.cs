using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesLayer;
using DAL;
using DAL.Repositories;
using TIL;

namespace BLL
{
    public class GestorTipoBeca
    {
        TipoBecaRepository objTipoBeca = new TipoBecaRepository();
        ///<sumary>
        ///El metodo agregarTipoBeca recibe los parámetros necesarios para poder crear la instancia tipo beca
        ///Este envía los parámetros para poder crear un tipo de beca y recibe una instancia
        ///Envía el objeto nuevo al repositorio para agregarlo a la lista del repositorio respectiva.
        ///El objeto es enviado para ser agregado en la base de datos
        ///En caso de algún error se atrapa la excepción
        ///</sumary>
        ///<author>María Jesús Gutiérrez</author>
        ///<param name="descripcion">Esta es la descripción del tipo de beca</param>
        ///<param name="estado">Este es el estado en el que se encuentra el tipo de beca</param>
        ///<param name="nombre"> Este es el nombre del tipo de beca</param>

        public TipoBeca agregarTipoBeca(string nombre, string estado, string descripcion)
        {
          

            try
            {
                TipoBeca objTipoBeca = new TipoBeca(nombre, estado, descripcion);

                if (objTipoBeca.IsValid)
                {
                    TipoBecaRepository.Instance.Insert(objTipoBeca);
                    return objTipoBeca;

                }
                else
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (RuleViolation rv in objTipoBeca.GetRuleViolations())
                    {
                        sb.AppendLine(rv.ErrorMessage);
                    }
                    throw new ApplicationException(sb.ToString());
                }


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        /// <summary>
        /// Se llama al método GetAll del repositorio y este recibe una lista con los tipos de beca
        /// </summary>
        /// <author>María Jesús Gutiérrez</author>
        /// <returns>Retorna una lista de los tipos de beca</returns>
        public IEnumerable<TipoBeca> consultarTipoBeca()
        {
            try {
                return TipoBecaRepository.Instance.GetAll();
            
            }
            catch (Exception ex) {

                throw ex ;
            }
            
        }
        /// <summary>
        /// Método que busca un tipo de beca por el nombre 
        /// </summary>
        /// <author>María Jesús Gutiérrez Calvo</author>
        /// <param name="pnombre"> se envía por parámetro el nombre del tipo de beca que se desea buscar.</param>
        /// <returns>Retorna el tipo de beca encontrado con el nombre enviado</returns>
        public TipoBeca buscarUnTipoBeca(string pnombre)
        {

            try {
                return TipoBecaRepository.Instance.GetByNombre(pnombre);
            }
            catch(Exception ex){
                throw ex;
            }
            
        }
        /// <summary>
        /// Método que busca un tipo de beca por su nombre y trae el id que se relaciona a ese nombre del tipo de beca
        /// </summary>
        /// <author>María Jesús Gutiérrez Calvo</author>
        /// <param name="pnombre">nombre del tipo de beca que es enviado por parámetro</param>
        /// <returns>Retorna el id del tipo de beca de acuerdo al nombre enviado</returns>
        public int idTipoBeca(string pnombre)
        {
            try
            {
                TipoBeca tmpTipo = buscarUnTipoBeca(pnombre);
                return tmpTipo.Id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
        /// <summary>
        /// Llama al método Save del repository
        ///</summary>
        ///<author>María Jesús Gutiérrez</author>
        public void guardarCambios()
        {
            try
            {
                TipoBecaRepository.Instance.Save();
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
        /// <summary>
        /// Método que inserta una lista de beneficios para asignarlos a un tipo de beca
        /// </summary>
        /// <author>María Jesús Gutiérrez Calvo</author>
        /// <param name="listaBeneficios">lista de beneficios que es envíada por parámetro para asignar a un tipo de beca</param>
        /// <param name="objTipoBeca">objeto de tipo beca</param>
        public void asignarBeneficioTipoBeca(List<Beneficio> listaBeneficios, TipoBeca objTipoBeca)
        {

            try {
                BeneficioRepository.objTipoBeca = objTipoBeca;
                foreach (Beneficio objBeneficio in listaBeneficios)
                {
                  BeneficioRepository.Instance.Insert(objBeneficio);
                }
                BeneficioRepository.Instance.asignarBeneficio(objTipoBeca);
            }
            catch(Exception ex){
                throw ex;
            }
        }
        /// <summary>
        /// Método que inserta un alista de requisitos para asignarlos a un tipo de beca
        /// </summary>
        /// <author>María Jesús Gutiérrez Calvo</author>
        /// <param name="listaRequisitos">lista de requisitos que es enviada por parámetro para asignar a un tipo de beca</param>
        /// <param name="objTipoBeca">objeto de tipo de beca</param>
        public void asignarRequisitoTipoBeca(List<Requisito> listaRequisitos, TipoBeca objTipoBeca)
        {
            try {
                RequisitoRepository.objTipoBeca = objTipoBeca;
                foreach (Requisito objRequisito in listaRequisitos)
                {
                    RequisitoRepository.Instance.Insert(objRequisito);
                }
                RequisitoRepository.Instance.asignarRequisito(objTipoBeca);
            }
            catch(Exception ex){
                throw ex;
            }
            
        }
        /// <summary>
        /// Método que modifica los datos de un tipo de beca, busca los beneficios y requisitos que están asociados a un tipo de beca
        /// vuelve a asignar a un tipo de beca los beneficios y requisitos marcados.
        /// </summary>
        /// <author>María Jesús Gutiérrez Calvo</author>
        /// <param name="idTipoBeca">id tipo de beca a modificar</param>
        /// <param name="pnombre">nombre del tipo de beca que se desea modificar</param>
        /// <param name="pestado">estado a modificar en que se encuentra la beca (activo o inactivo)</param>
        /// <param name="pdescripcion">descripción del tipo de beca que se desea modificar</param>
        /// <param name="plistaBeneficios">lista de beneficios associados a un tipo de beca en específico</param>
        /// <param name="plistaRequisitos">lista de requisitos asociados a un tipo de beca en específico</param>
        public void modificarTipoBeca(int idTipoBeca, string pnombre, string pestado, string pdescripcion, List<int> plistaBeneficios, List<int> plistaRequisitos)
        {
           
            try
            {
                TipoBeca objTipoBeca = ContenedorMantenimiento.Instance.crearTipoBeca(idTipoBeca, pnombre, pestado, pdescripcion);
                List<Beneficio> listaBeneficios = new List<Beneficio>();
                List<Requisito> listaRequisitos = new List<Requisito>();
                if (objTipoBeca.IsValid)
                {
                    TipoBecaRepository.Instance.Update(objTipoBeca);
                    eliminarBeneficiosTipoBeca(idTipoBeca);
                    eliminarRequisitoTipoBeca(idTipoBeca);

                    foreach (int idBeneficio in plistaBeneficios)
                    {
                        Beneficio beneficio = new Beneficio(idBeneficio);
                        listaBeneficios.Add(beneficio);
                    }

                    foreach (int idRequisito in plistaRequisitos)
                    {
                        Requisito requisito = new Requisito(idRequisito);
                        listaRequisitos.Add(requisito);
                    }
                    asignarBeneficioTipoBeca(listaBeneficios, objTipoBeca);
                    asignarRequisitoTipoBeca(listaRequisitos, objTipoBeca);
                }
                else
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (RuleViolation rv in objTipoBeca.GetRuleViolations())
                    {
                        sb.AppendLine(rv.ErrorMessage);
                    }
                    throw new ApplicationException(sb.ToString());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Método que modifica los requisitos asociados a un tipo de beca
        /// </summary>
        /// <author>María Jesús Gutiérrez Calvo</author>
        /// <param name="listaRequisitos">lista de requisitos asociados a un tipo de beca en específico</param>
        /// <param name="objTipoBeca">objeto de tipo de beca</param>
        public void modificarRequisitos(List<Requisito> listaRequisitos, TipoBeca objTipoBeca)
        {
            try {
                RequisitoRepository.objTipoBeca = objTipoBeca;
                foreach (Requisito objRequisito in listaRequisitos)
                {
                    RequisitoRepository.Instance.Update(objRequisito);
                }
                RequisitoRepository.Instance.asignarRequisito();
            }
            catch (Exception ex){
                throw ex;
            }
        }
        /// <summary>
        /// Método que modifica los beneficios asociados a un tipo de beca
        /// </summary>
        /// <author>María Jesús Gutiérrez Calvo</author>
        /// <param name="listaBeneficios">envía por parámetro la lista de beneficios</param>
        /// <param name="objTipoBeca">envíapor parámetro un objeto de tipo beca</param>
        public void modificarBeneficios(List<Beneficio> listaBeneficios, TipoBeca objTipoBeca)
        {
            try {
                BeneficioRepository.objTipoBeca = objTipoBeca;
                foreach (Beneficio objBeneficio in listaBeneficios)
                {
                    BeneficioRepository.Instance.Insert(objBeneficio);
                }
                BeneficioRepository.Instance.asignarBeneficio();
            }
            catch (Exception ex){
                throw ex;
            }
        }
        /// <summary>
        /// Método que elimina un tipo de beca por medio de un nombre en específico.
        /// </summary>
        /// <author>María Jesús Gutiérrez Calvo</author>
        /// <param name="pnombre">nombre de un tipo de beca que se envía por parámetro para eliminar un tipo de beca en específico</param>
        public void eliminarTipoBeca(String pnombre)
        {
            try
            {
                TipoBeca objTipoBeca = ContenedorMantenimiento.Instance.crearTipoBeca(pnombre);
                TipoBecaRepository.Instance.Delete(objTipoBeca);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        /// <summary>
        /// Método que busca por medio del id los beneficios relacionados a un tipo de beca
        /// </summary>
        /// <author>María Jesús Gutiérrez Calvo</author>
        /// <param name="pid">id del tipo de beca con el que se busca los beneficios relacionados a ese tipo de beca</param>
        /// <returns>retorna los beneficios relacionados a un tipo de beca por medio de su id</returns>
        public IEnumerable<Beneficio> buscarBeneficiosRelacionadosTipoBeca(int pid)
        {
            try {
                return objTipoBeca.buscarBeneficiosRelacionadosTipoBeca(pid);
            }
            catch(Exception ex){
                throw ex;
            }
        }
        /// <summary>
        /// Método que busca los requisitos relacionados a un tipo de beca por medio de su id
        /// </summary>
        /// <param name="pid">id del tipo de beca con el que se busca los requisitos relacionados a ese tipo de beca</param>
        /// <returns></returns>
        public IEnumerable<Requisito> buscarRequisitosRelacionadosTipoBeca(int pid)
        {
            try {
                return objTipoBeca.buscarRequisitosRelacionadosTipoBeca(pid);
            }
            catch (Exception ex) {
                throw ex;
            }
           
        }
        /// <summary>
        /// Método que elimina los requisitos asociados a un tipo de beca específico por medio de su id
        /// </summary>
        /// <author>María Jesús Gutiérrez Calvo</author>
        /// <param name="id">id del tipo de beca con el que se busca los requisitos que están asociados a ese tipo de beca</param>
        public void eliminarRequisitoTipoBeca(int id)
        {
            try {
                objTipoBeca.DeleteRequisitoTipoBeca(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
        /// <summary>
        /// Método que elimina los beneficios asociados a un tipo de beca específico por medio de su id
        /// </summary>
        /// <author>María Jesús Gutiérrez Calvo</author>
        /// <param name="id">id del tipo de beca con el que se busca los beneficios asociados a ese tipo de beca</param>
        public void eliminarBeneficiosTipoBeca(int id)
        {
            try {
                objTipoBeca.DeleteBeneficioTipoBeca(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}



