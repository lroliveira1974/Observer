using OBS.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace OBS.Domain.Interface.Service.Demanda
{
    public interface IDemandaService
    {
        List<DemandaEntity> ObterListaDemandas(string IdSolicitante);
        List<DemandaEntity> ObterListaDemandasAreaNegocio(string IdAreaNegocio);
        DemandaEntity ObterDetalheDemanda(string IdDemanda);
        DemandaEntity InserirDemanda(DemandaEntity oDemanda);
        DemandaEntity AlterarDemanda(DemandaEntity oDemanda);

    }
}
