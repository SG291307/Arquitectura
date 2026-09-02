using DTOs.DataTransferObjects.DTOAutor;
using DTOs.Mappers;
using Libreria.LogicaAplicacion.ICasosUso.ICUAutor;
using Libreria.LogicaNegocio.Entidades;
using Libreria.LogicaNegocio.IRepositorios;
using System;
using System.Collections.Generic;
using System.Text;

namespace Libreria.LogicaAplicacion.CasosUso.CUsAutor
{
    public class CUObtenerAutores : ICUObtenerAutores
    {
        private IRepositorioAutor _repoAutor;

        public CUObtenerAutores(IRepositorioAutor repoAutor)
        {
            _repoAutor = repoAutor;
        }
        public List<DTOAutor> Ejecutar()
        {
            List<Autor> todosLosAutores = _repoAutor.FindAll();
            List<DTOAutor> resultado = MapperAutor.ToDTOAutor(todosLosAutores);
            return resultado;
        }
    }
}
