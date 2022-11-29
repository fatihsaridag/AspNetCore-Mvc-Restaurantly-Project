using System.Net.Mail;

namespace Restaurantly.MVC.Helper
{
    public static class PasswordReset
    {
        public static void PassowrdResetSendEmail(string link, string email)
        {
            MailMessage mail = new MailMessage();       
            SmtpClient smtpClient = new SmtpClient();

            mail.From = new MailAddress("fatihsaridag26@gmail.com");
            mail.To.Add(email);


            mail.Subject = $"www.Restaurantly.com:: Şifre Sıfırlama";
            mail.Body = "<h2>Şifrenizi yenilemek için lütfen aşağıdaki linke tıklayınız.</h2><hr/>";
            mail.Body += $"<a href='{link}'>şifre yenileme linki</a>";
            mail.IsBodyHtml = true;

            smtpClient.Port = 587;
            smtpClient.Host = "smtp.gmail.com";
            smtpClient.EnableSsl = true;

            smtpClient.Credentials = new System.Net.NetworkCredential("fatihsaridag26@gmail.com", "asdasdasdasd");
            smtpClient.Send(mail);

        }
    }
}
