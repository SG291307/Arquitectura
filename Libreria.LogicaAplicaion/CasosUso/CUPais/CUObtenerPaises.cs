using DTOs.DataTransferObjects.DTOPais;
using DTOs.Mappers;
using Libreria.LogicaAccesoDatos.Repositorios;
using Libreria.LogicaAplicacion.ICasosUso.ICUPais;
using Libreria.LogicaNegocio.Entidades;
using Libreria.LogicaNegocio.IRepositorios;
using System;
using System.Collections.Generic;
using System.Text;

namespace Libreria.LogicaAplicacion.CasosUso.CUPais
{
    public class CUObtenerPaises : ICUObtenerPaises
    {
        private IRepositorioPais _repoPais;

        public CUObtenerPaises(IRepositorioPais repoPais)
        {
            _repoPais = repoPais;
        }

        public List<DTOPais> Ejecutar()
        {
            //Mappear la lista de Pais(que viene de la base) a Lista de DTOPais(que es la que se va a devolver)

            List<Pais> todoslosPaises = _repoPais.FindAll();
            List<DTOPais> listaParaRetornar = MapperPais.ToDtoPaisList(todoslosPaises);
            return listaParaRetornar;

            //Otra forma de hacerlo mas facil
            //return MapperPais.ToDtoPaisList(_repoPais.FindAll());
        }
    }
}
