namespace EjerciciosSRP.Ejercicio6
{
    public class Utilitarios
    {
        public static bool ValidarMail(string email)
        {
            try
            {
                var direccionCorreo = new System.Net.Mail.MailAddress(email);
                return direccionCorreo.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}