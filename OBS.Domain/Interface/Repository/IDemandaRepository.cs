using OBS.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace OBS.Domain.Interface.Repository
{
    public interface IDemandaRepository
    {
        List<DemandaEntity> ObterListaDemandas(string IdSolicitante);
        List<DemandaEntity> ObterListaDemandasAreaNegocio(string IdAreaNegocio);
        DemandaEntity ObterDetalheDemanda(string IdDemanda);
    }
}
