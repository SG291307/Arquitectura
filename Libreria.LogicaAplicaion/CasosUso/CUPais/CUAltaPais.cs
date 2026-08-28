using Libreria.LogicaAccesoDatos.Repositorios;
using Libreria.LogicaAplicacion.ICasosUso.ICUPais;
using Libreria.LogicaNegocio.Entidades;
using Libreria.LogicaNegocio.IRepositorios;
using DTOs.DataTransferObjects.DTOPais;
using System;
using System.Collections.Generic;
using System.Text;
using DTOs.Mappers;

namespace Libreria.LogicaAplicacion.CasosUso.CUPais
{
    public class CUAltaPais : ICUAltaPais
    {

        private IRepositorioPais _repoPais;

        public CUAltaPais(IRepositorioPais repoPais)
        {
            _repoPais = repoPais;
        }

        public void Ejecutar(DTOAltaPais p)
        {
            //1 - Lo valida

            //2 - Mappear de DTO a Entidad

            Pais nuevo = MapperPais.ToPais(p);

            _repoPais.Add(nuevo);
        }
    }
}
