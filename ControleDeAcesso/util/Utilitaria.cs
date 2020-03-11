using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace ControleDeAcesso.util
{
    class Utilitaria
    {

        public static void LimparCampos(Control controlePai)
        {        
            foreach (TextBox txt in controlePai.Controls)
            {
                if (txt is TextBox)
                {
                    txt.Clear();
                }
}
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="senha"></param>
        /// <returns>retorna uma string, contendo a senha criptografada</returns>
        public static string criptografarSenha(string senha)
        {
            using (System.Security.Cryptography.MD5 md5Hash = System.Security.Cryptography.MD5.Create())
            {
                // Convert the valor string to a byte array and compute the hash.
                byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(senha));

                // Create a new Stringbuilder to collect the bytes
                // and create a string.
                StringBuilder sBuilder = new StringBuilder();

                // Loop through each byte of the hashed data 
                // and format each one as a hexadecimal string.
                for (int i = 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("x2"));
                }

                // Return the hexadecimal string.
                return sBuilder.ToString();
            }
        }

        /// <summary>
        /// Recebe a senha digitada pelo usuário, transforma em um hashMD5 e compara com o outro hash 'senhaCriptografada'
        /// </summary>
        /// <param name="senhaNormal">Senha a ser transformada em um hash e comparada com a senha do BD</param>
        /// <param name="senhaCriptografada">Senha a ser buscada no BD </param>
        /// <returns>Retorna TRUE se as senhas forem iguais ou FALSE caso Contrário</returns>
        public static bool validarSenha(string senhaNormal, string senhaCriptografada)
        {

            senhaNormal = criptografarSenha(senhaNormal);

            if (senhaNormal.Equals(senhaCriptografada))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Envio de Emails

        public static void enviarEmailRecuperacao(string email, int codVerificacao)
        {
            MailMessage mail = new MailMessage();
            SmtpClient smtp = new SmtpClient();

            mail.From = new MailAddress("robertogbezerra@gmail.com");
            mail.To.Add(email); // para
            mail.Subject = "Recuperação de senha"; // assunto
            mail.IsBodyHtml = true;
            mail.Body = "<center><h1 > SEU CÓDIGO DE VERIFICAÇÃO ESTÁ ABAIXO</h1> </center> <hr style='border: 5px solid orange;'/> <section " +
                "style='background-image: linear-gradient(blue, steelblue); color: white; padding:50px 0px'> <center> " +
                "<p style=' margin:0px 0% ; font-size:20px'> Para continuar com a renovação da sua senha, copie este código e cole dentro do campo 'Código de Verificação' no sistema.</p></center> " +
                "<center style='margin: 50px auto; '><h2 style=' color:orange; text-weight:900; font-size:25px' > " + codVerificacao + "</h2> " +
                "</center> </section> <hr style='border: 5px solid orange;'/> <center> <p style='text-weight:900; font-size:18px;'> Atenciosamente, " +
                "Equipe VS3 Sistemas. </p>  </ center >";

            // em caso de anexos
            //mail.Attachments.Add(new Attachment(@"C:\teste.txt"));
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true; // GMail requer SSL
            // 465 – Porta SSL, também conhecidas como SMTPS
            // 587 – Porta TLS, também conhecida como SMTP TLS
            smtp.Port = 587;       // porta para SSL
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network; // modo de envio
            smtp.UseDefaultCredentials = false; // vamos utilizar credencias especificas

            // seu usuário e senha para autenticação
            smtp.Credentials = new NetworkCredential("atendimento@vs3sistemas.com.br", "3537vs3@");
            // envia o e-mail
            smtp.Send(mail);

            // Também é possível enviar emails de forma assíncrona, para isso você não pode utilizar o using
            // pois o smtp só pode chamar Dispose depois de enviar mensagem. Para isto há o evento SendCompleted.

            smtp.SendCompleted += (s, e) =>
            {
                // após o envio pode chamar o Dispose
                smtp.Dispose();
            };

            // envia assíncronamente
            // smtp.SendAsync(mail, null);
        }

        public static void enviarEmailConfirmacao(string email, string titulo, string bodyMessage)
        {
            MailMessage mail = new MailMessage();
            SmtpClient smtp = new SmtpClient();

            mail.From = new MailAddress("robertogbezerra@gmail.com");
            mail.To.Add(email); // para
            mail.Subject = "Solicitação de Chave de Acesso"; // assunto
            mail.IsBodyHtml = true;
            mail.Body = "<center><h1 >" + titulo + "</h1> </center> <hr style='border: 5px solid orange;'/> <section style='background-image: " +
                "linear-gradient(blue, steelblue); color: white; padding:50px 0px'> <center> <p style=' margin:0px 0% ; font-size:20px'>" + bodyMessage + "</p></center> <center  style='margin: 50px auto; '><a style='" +
                "color:orange; text-weight:900; font-size:25px' href='google.com'> Clique para baixar seu boleto</a> </center> <center><p " +
                "style='text-weight:900; font-size:20px; margin:0px'> </p> </section> <hr " +
                "style='border: 5px solid orange;'/> <p style='text-weight:900; font-size:18px;'> Atenciosamente, Equipe VS3 Sistemas. </p>  </ center >";


            // em caso de anexos
            //mail.Attachments.Add(new Attachment(@"C:\teste.txt"));
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true; // GMail requer SSL
            // 465 – Porta SSL, também conhecidas como SMTPS
            // 587 – Porta TLS, também conhecida como SMTP TLS
            smtp.Port = 587;       // porta para SSL
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network; // modo de envio
            smtp.UseDefaultCredentials = false; // vamos utilizar credencias especificas

            // seu usuário e senha para autenticação
            smtp.Credentials = new NetworkCredential("robertogbezerra@gmail.com", "umnovocomeco");
            // envia o e-mail
            smtp.Send(mail);

            // Também é possível enviar emails de forma assíncrona, para isso você não pode utilizar o using
            // pois o smtp só pode chamar Dispose depois de enviar mensagem. Para isto há o evento SendCompleted.

            smtp.SendCompleted += (s, e) =>
            {
                // após o envio pode chamar o Dispose
                smtp.Dispose();
            };

            // envia assíncronamente
            // smtp.SendAsync(mail, null);

        }
    }
}
