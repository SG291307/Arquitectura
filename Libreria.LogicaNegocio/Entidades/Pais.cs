using Libreria.LogicaNegocio.CustomExceptions.Genericas;
using Libreria.LogicaNegocio.CustomExceptions.PaisException;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Libreria.LogicaNegocio.Entidades
{
    public class Pais
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public string Continente { get; set; }

 
        public void Validar() 
        {
            if (string.IsNullOrEmpty(Nombre))
            {
                throw new DatoVacioException("El nombre del país no puede estar vacío.");
            }
            if (string.IsNullOrEmpty(Codigo))
            {
                throw new DatoVacioException("El código del país no puede estar vacío.");
            }
            if (string.IsNullOrEmpty(Continente))
            {
                throw new DatoVacioException("El continente del país no puede estar vacío.");
            }
            if (Codigo.Length != 3)
            {
                throw new LargoCodigoInvalidoException("El código del país debe tener exactamente 3 caracteres.");
            }

        }

        // Constructor que recibe todos los parámetros
        public Pais(string codigo, string nombre, string continente)
        {

            Codigo = codigo;
            Nombre = nombre;
            Continente = continente;
        }
    }
}
