using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosSRP.Ejercicio2
{
    internal class ServicioPublicacion
    {
        public void CrearPublicacion(DbContext contextoDB, string mensajeAPublicar)
        {
            try
            {
                contextoDB.Add(mensajeAPublicar);
            }
            catch (Exception ex)
            {
                contextoDB.LogError("Error: ", ex.ToString());
                File.WriteAllText("Log.txt", ex.ToString());
            }
        }
    }
}
