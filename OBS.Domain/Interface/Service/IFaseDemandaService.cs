using OBS.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace OBS.Domain.Interface.Service
{
    public interface IFaseDemandaService
    {
        List<FaseDemandaEntity> ObterListaFaseDemanda();
        FaseDemandaEntity ObterDetalheFaseDemanda(string IdFaseDemanda);
    }
}
