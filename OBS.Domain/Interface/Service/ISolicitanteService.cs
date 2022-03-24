using OBS.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace OBS.Domain.Interface.Service
{
    public interface ISolicitanteService
    {
        public List<SolicitanteEntity> ObterListaSolicitante();        
        SolicitanteEntity ObterDetalheSolicitante(string IdSolicitante);
        SolicitanteEntity ObterDetalheSolicitantePorDemanda(string IdDemanda);
        SolicitanteEntity InserirSolicitante(SolicitanteEntity oSolicitante);
        SolicitanteEntity AlterarSolicitante(SolicitanteEntity oSolicitante);

    }
}
