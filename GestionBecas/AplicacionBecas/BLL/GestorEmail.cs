using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntitiesLayer;
using DAL;
using DAL.Repositories;

namespace BLL
{
    public class GestorEmail
    {

        public Email getEmail()
        {
            return EmailRepository.Instance.GetEmail();
        }

        public void modificarEmail(String pemisor,String preceptor, String pasunto, String pmensaje, String psmtpServidor, String puserName, String pcontrasenna, int id)
        {
            Email email = ContenedorMantenimiento.Instance.crearObjetoEmail(pemisor,preceptor, pasunto, pmensaje, psmtpServidor, puserName, pcontrasenna,id);

            try
            {
                if (email.IsValid)
                {
                    EmailRepository.Instance.UpdateEmail(email);
                }
                else
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (RuleViolation rv in email.GetRuleViolations())
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
        public void enviarMensajeInstantaneo(String emisor, String receptor, String asunto, String mensaje, String smtpserver, String userName, String contrasenna)
        {
            Email email = ContenedorMantenimiento.Instance.crearObjetoEmail(receptor, emisor, asunto, mensaje, smtpserver, userName, contrasenna);

            try
            {
                if (email.IsValid)
                {
                    email.notificarUsuario();
                }
                else
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (RuleViolation rv in email.GetRuleViolations())
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
    }
}
