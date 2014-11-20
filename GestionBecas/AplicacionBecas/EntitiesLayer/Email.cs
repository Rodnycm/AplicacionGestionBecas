using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using EASendMail;

namespace EntitiesLayer 
{

    public class Email : IEntity
    {

        private int _idEmail;
        public int Id
        {
            get { return _idEmail; }
            set { _idEmail = value; }
        }

        SmtpMail oMail = new SmtpMail("TryIt");
        SmtpClient oSmtp = new SmtpClient();
        public String receptor { get; set; }
        public String emisor { get; set; }
        public String asunto { get; set; }
        public String mensaje { get; set; }
        public String smtpServidor { get; set; }
        public String userName { get; set; }
        public String contrasenna { get; set; }


        public Email(String pemisor, String pasunto, String pmensaje, String psmtpServidor, String puserName, String pcontrasenna)
        {
            emisor = pemisor;
            asunto = pasunto;
            mensaje = pmensaje;
            smtpServidor = psmtpServidor;
            userName = puserName;
            contrasenna = pcontrasenna;
        }

        public Email(String pemisor,String preceptor, String pasunto, String pmensaje, String psmtpServidor, String puserName, String pcontrasenna, int pid)
        {
            emisor = pemisor;
            receptor = preceptor;
            asunto = pasunto;
            mensaje = pmensaje;
            smtpServidor = psmtpServidor;
            userName = puserName;
            contrasenna = pcontrasenna;
            Id = pid;
        }

        public Email()
        {

        }

        public Email(string preceptor, string pemisor, string pasunto, string pmensaje, string psmtpServidor, string puserName, string pcontrasenna)
        {
            this.receptor = preceptor;
            this.emisor = pemisor;
            this.asunto = pasunto;
            this.mensaje = pmensaje;
            this.smtpServidor = psmtpServidor;
            this.userName = puserName;
            this.contrasenna = pcontrasenna;
        }
    
        public void notificarUsuario(String correo){

            try
            {
            // Your gmail email address
            oMail.From = emisor;

            // Set recipient email ad   dress
            oMail.To = correo;

            // Set email subject
            oMail.Subject = asunto;

            // Set email body
            oMail.TextBody = mensaje;

            // Gmail SMTP server address
            SmtpServer oServer = new SmtpServer(smtpServidor);

            // oServer.Port = 465;

            // detect SSL/TLS automatically
            oServer.ConnectType = SmtpConnectType.ConnectSSLAuto;

            // Gmail user authentication
            oServer.User = userName;
            oServer.Password = contrasenna;
            oSmtp.SendMail(oServer, oMail);
                
            }
            catch (Exception ep)
            {
                throw ep;
            }
        }

        public void notificarUsuario()
        {

            try
            {
                // Your gmail email address
                oMail.From = emisor;

                // Set recipient email ad   dress
                oMail.To = receptor;

                // Set email subject
                oMail.Subject = asunto;

                // Set email body
                oMail.TextBody = mensaje;

                // Gmail SMTP server address
                SmtpServer oServer = new SmtpServer(smtpServidor);

                // oServer.Port = 465;

                // detect SSL/TLS automatically
                oServer.ConnectType = SmtpConnectType.ConnectSSLAuto;

                // Gmail user authentication
                oServer.User = userName;
                oServer.Password = contrasenna;
                oSmtp.SendMail(oServer, oMail);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //<summary> Método que se encarga de determinar si los datos ingresados del email son validos</summary>
        //<author> Alvaro Artavia </author> 
        //<param > No recibe parámetros </param>
        //<returns> Variable booleana </returns> 

        public bool IsValid
        {
            get { return (GetRuleViolations().Count() == 0); }
        }


        //<summary> Método que se encarga de validar que los diferentes atributos del email esten correctos</summary>
        //<author> Alvaro Artavia </author> 
        //<param > No recibe parámetros </param>
        //<returns> Retorna una lista de objetos RuleViolation </returns> 

        public IEnumerable<RuleViolation> GetRuleViolations()
        {
            if (String.IsNullOrEmpty(asunto))
            {
                yield return new RuleViolation("Asunto requerido", "asunto");
            }
            if (String.IsNullOrEmpty(mensaje))
            {
                yield return new RuleViolation("Mensaje Requerido", "mensaje");
            }
            if (String.IsNullOrEmpty(emisor))
            {
                yield return new RuleViolation("Se requiere un correo electronico para notificar", "emisor");
            }
            if (String.IsNullOrEmpty(receptor))
            {
                yield return new RuleViolation("Se requiere un correo electronico para notificar", "receptor");
            }
            if (String.IsNullOrEmpty(userName))
            {
                yield return new RuleViolation("Se requiere un correo electronico para notificar", "userName");
            }
            if (String.IsNullOrEmpty(contrasenna))
            {
                yield return new RuleViolation("Se requiere la contraseña del email", "contrasenna");
            }
            if (!(Regex.IsMatch(emisor, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase)))
            {
                yield return new RuleViolation("", "Correo electrónico incorrecto");
            }
            if (!(Regex.IsMatch(receptor, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase)))
            {
                yield return new RuleViolation("", "Correo electrónico incorrecto");
            }
            yield break;
        }
    }
}