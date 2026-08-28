using Libreria.LogicaNegocio.Entidades;

namespace Libreria.LogicaAplicacion.ICasosUso.ICUPais
{
    public interface ICUObtenerPaisXCodigo
    {
        Pais Ejecutar(string codigo);
    }
}