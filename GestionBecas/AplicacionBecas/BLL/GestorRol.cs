using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntitiesLayer;
using DAL;
using System.Collections;
using DAL.Repositories;

namespace BLL
{

    public class GestorRol 

    {
        public void agregarRol(string pnombre)
        {
            try
            {
                Rol objRol = ContenedorMantenimiento.Instance.crearObjetoRol(pnombre);
                if (objRol.IsValid)
                {
                    RolRepository.Instance.Insert(objRol);
                }
                else
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (RuleViolation rv in objRol.GetRuleViolations())
                    {
                        sb.Append(rv.ErrorMessage + "\n");
                    }
                   
                }
            }
            catch (Exception ex)
            {
                throw ex;
                
            }
        }

        
        /// <summary>
        /// Este metodo Modifica un rol
        /// </summary>
        /// <param name="pnombre">El nombre del rol</param>
        /// <param name="pidRol">El id del rol</param>
        public void modificarRol(string pnombre, int pidRol)
        {
            try
            {
                Rol objRol = ContenedorMantenimiento.Instance.crearObjetoRol(pidRol, pnombre);
                if (objRol.IsValid)
                {
                    RolRepository.Instance.Update(objRol);
                }
                else
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (RuleViolation rv in objRol.GetRuleViolations())
                    {
                        sb.Append(rv.ErrorMessage + "\n");
                    }
                    
                }
            }
            catch (Exception ex)
            {
                throw ex;
                
            }
        }


        /// <summary>
        /// Este metodo asigna un permiso a algun rol
        /// </summary>
        /// <param name="pidPermiso"></param>
        /// <param name="pidRol"></param>
        public void asignarPermisoAUnRol(int pidPermiso, int pidRol)
        {
            try
            {
                PermisoRepository.Instance.InsertPermisoAUnRol(pidPermiso, pidRol);
            }
            catch (Exception ex) {

                throw ex;
            }

        }

        public IEnumerable<int> ConsultarIdPermisoROl(int pidPermiso, int pidRol)
        {

            try
            {
                return PermisoRepository.Instance.GetIdRolesPermisos(pidPermiso, pidRol);
            }
            catch (Exception ex) {

                throw ex;
            }
        }

        public void eliminarPermisoAUnRol(int pIdPermiso, int pIdROl)
        {
            try
            {
                PermisoRepository.Instance.EliminarPermisoAUnRol(pIdPermiso, pIdROl);
            }
            catch (Exception ex) {

                throw ex;
            }
        }
       /// <summary>
       /// Elimina un rol
       /// </summary>
       /// <param name="pnombre">Nombre del rol</param>
       /// <param name="pidRol">Id del Rol</param>
        public void eliminarRol(String pnombre, int pidRol)
        {
            try
            {
                Rol objRol = ContenedorMantenimiento.Instance.crearObjetoRol(pidRol, pnombre);
                RolRepository.Instance.Delete(objRol);
            }
            catch (Exception ex) {

                throw ex;
            }
        }

        /// <summary>
        /// Consultar los roles
        /// </summary>
        /// <returns>Retorna una lista de roles</returns>
        public IEnumerable<Rol> consultarRoles()
        {
            try
            {
                return RolRepository.Instance.GetAll();
            }
            catch(Exception ex){

                throw ex;
            }
        }

        /// <summary>
        /// Consulta los permisos
        /// </summary>
        /// <returns>Retorna una lista de permisos</returns>
        public IEnumerable<Permiso> consultarPermisos()
        {
            try
            {
                return PermisoRepository.Instance.GetAll();
            }
            catch (Exception ex) {

                throw ex;
            }
        }

        public IEnumerable<Permiso> consultarPermisosPorRol(int pidRol)
        {
            try
            {
                return PermisoRepository.Instance.GetPermisosPorRol(pidRol);
            }
            catch (Exception ex) {

                throw ex;
            }
        }

        /// <summary>
        /// Consulta un rol por el nombre
        /// </summary>
        /// <param name="pnombre">Nombre del rol a consultar</param>
        /// <returns>El rol digitado</returns>
        public Rol consultarRolPorNombre(String pnombre)
        {
            try
            {
               
                if (RolRepository.Instance.GetByNombre(pnombre) == null)
                {
                    throw new ApplicationException("Debe ingresar el nombre del rol");
                }
                else {
                    return RolRepository.Instance.GetByNombre(pnombre);
                
                }
            }
            catch (Exception ex) {

                throw ex;
            }
        }


        /// <summary>
        /// Guarda los datos 
        /// </summary>
        public void guardarCambios()
        {
            //try
            //{
            RolRepository.Instance.Save();
            //    }
            //    catch (DataAccessException ex)
            //    {
            //        throw ex;
            //    }
            //    catch (Exception ex)
            //    {
            //        //logear a la bd
            //        throw new BusinessLogicException("Ha ocurrido un error al eliminar un usuario", ex);
            //    }
        }
    }
}
