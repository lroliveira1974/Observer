using OBS.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace OBS.Domain.Interface.Service
{
    public interface IDemandaService
    {
        List<DemandaEntity> ObterListaDemandas(string IdSolicitante);
        DemandaEntity ObterDetalheDemanda(string IdDemanda);
    }
}
