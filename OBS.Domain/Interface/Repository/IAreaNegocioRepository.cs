using OBS.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace OBS.Domain.Interface.Repository
{
    public interface IAreaNegocioRepository
    {
        List<AreaNegocioEntity> ObterListaAreaNegocio();
        AreaNegocioEntity ObterDetalheAreaNegocio(string IdAreaNegocio);
    }
}
