using System;
using System.Collections.Generic;
using System.Text;

namespace Libreria.LogicaNegocio.CustomExceptions.Genericas
{
    public class DatoVacioException : Exception
    {
        public DatoVacioException(string mensaje) : base(mensaje)
        {
            
        }
    }
}
