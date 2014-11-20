using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntitiesLayer;
using DAL;
using DAL.Repositories;

namespace BLL
{

    public class GestorCarrera
    {
  
        /// <summary>
        /// Agrega una nueva carrera
        /// </summary>
        /// <param name="nombre">Nombre de la carrera</param>
        /// <param name="codigo">Codigo de la carrera</param>
        /// <param name="color">Color de la carrera</param>
        /// <param name="idDirector">id del director de la carrera</param>
        /// <autor>Alvaro Artavia</autor>

        public void agregarCarrera(string nombre, string codigo, string color, string idDirector)
        {
            Usuario director = UsuarioRepository.Instance.GetByNombre(idDirector);
            Carrera carrera = ContenedorMantenimiento.Instance.crearObjetoCarrera(nombre, codigo, color, director);
            try
            {
                if (carrera.IsValid)
                {

                    CarreraRepository.Instance.Insert(carrera);

                }
                else {

                    StringBuilder sb = new StringBuilder();
                    foreach (RuleViolation rv in carrera.GetRuleViolations())
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
        /// Trae de la base de datos los directores academicos
        /// </summary>
        /// <returns>lista de usuarios</returns>

        public IEnumerable <Usuario> consultarDirectoresAcademicos() {

            return UsuarioRepository.Instance.GetDirectoresAcademicos();
        
        }

        /// <summary>
        /// Metodo encargado de comunicarse con la capa de acceso para modificar una carrera
        /// </summary>
        /// <param name="nombre">Nombre de la carrera</param>
        /// <param name="codigo">Codigo de la carrera</param>
        /// <param name="color">Color de la carrera</param>
        /// <param name="idCarrera">id de la carrera</param>
        /// <param name="idDirector">director de la carrera</param>
        /// <param name="directorAntiguo">antiguo director de la carrera</param>
        //public void asignarCursoCarrera(List<Curso> listaCursos, Carrera objCarrera)
        //{
        //    CursoRepository.objCarrera = objCarrera;
        //    foreach (Curso objCurso in listaCursos)
        //    {
        //        CursoRepository.Instance.Insert(objCurso);
        //    }
        //    CursoRepository.Instance.asignarCurso(objCarrera);
        //}
        public void modificarCarrera(string nombre, string codigo, string color, int idCarrera, string idDirector)
        {
            Usuario director = UsuarioRepository.Instance.GetByNombre(idDirector);
            Carrera carrera = ContenedorMantenimiento.Instance.crearObjetoCarrera(nombre, codigo, color, idCarrera, director);

            try
            {
                if(carrera.IsValid){

                    CarreraRepository.Instance.UpdateCarrera(carrera);

                }else{
                    
                    StringBuilder sb = new StringBuilder();
                    foreach (RuleViolation rv in carrera.GetRuleViolations())
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
        /// Busca la carrera solocitdad
        /// </summary>
        /// <param name="param">codigo o nombre de la carrera a consultar</param>
        /// <returns>carrera consultada</returns>
        /// <autor>Alvaro Artavia</autor>

        public Carrera buscarCarrera(String param)
        {
            return CarreraRepository.Instance.GetByNombre(param);
        }

        /// <summary>
        /// Elimina la carrera de la base de datos
        /// </summary>
        /// <param name="codigo">Codigo de la carrera a eliminar</param>
        /// <autor>Alvaro Artavia</autor>

        public void eliminarCarrera(String codigo)
        {
            Carrera carrera = ContenedorMantenimiento.Instance.crearObjetoCarrera(codigo);
            CarreraRepository.Instance.Delete(carrera);
        }

        /// <summary>
        /// Consulta todas las carreras existentes
        /// </summary>
        /// <returns>lista de carreras</returns>
        /// <autor>Alvaro Artavia</autor>

        public IEnumerable<Carrera> consultarCarreras()
        {

            return CarreraRepository.Instance.GetAll();

        }

        /// <summary>
        /// Ejecuta los metodos de la capa DAL
        /// </summary>
        /// <autor>Alvaro Artavia</autor>
        public void guardarCambios()
        {

            CarreraRepository.Instance.Save();
        }
        public void asignarCursosCarrera(List<Curso>listaCursos, Carrera objCarrera)
        {
            CursoRepository.objCarrera = objCarrera;
            foreach (Curso objCurso in listaCursos)
            {
                CursoRepository.Instance.Insert(objCurso);
            }
            CursoRepository.Instance.asignarCurso(objCarrera);
        }
    }
}


