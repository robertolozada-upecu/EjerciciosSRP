using System;

namespace EjerciciosSRP.Ejercicio6
{
    public class Persona
    {
        private string Nombre;
        private string Apellido;
        private string Email;

        public Persona(string nombre, string apellido, string email)
        {
            Nombre = nombre;
            Apellido = apellido;
            if (Utilitarios.ValidarMail(email))
                Email = email;
            else
                throw new Exception("Mail inválido");
        }
    }
}