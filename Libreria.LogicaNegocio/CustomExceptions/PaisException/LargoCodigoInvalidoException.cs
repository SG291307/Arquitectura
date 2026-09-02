using System;
using System.Collections.Generic;
using System.Text;

namespace Libreria.LogicaNegocio.CustomExceptions.PaisException
{
    public class LargoCodigoInvalidoException : Exception
    {
        public LargoCodigoInvalidoException(string mensaje) : base(mensaje)
        {
            
        }
    }
}
