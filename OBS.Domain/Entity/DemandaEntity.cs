using OBS.Domain.Enums;
using OBS.Domain.Interface.Service;

using System;


namespace OBS.Domain.Entity
{
    public class DemandaEntity : EntityBase
    {
        //INTERFACES UTILIZADAS
        private ISolicitanteService iSolicitanteService;

    
        public DateTime DataDemanda { get; set; }
        public string DescricaoDemanda { get; set; }
        public EStatusDemanda StatusDemanda { get; set; }
        public EPrioridadeDemanda PrioridadeDemanda { get; set; }
        public bool IsProcedente { get; set; }                
        public SolicitanteEntity oSolicitante { get; set; }
        

        public DemandaEntity(ISolicitanteService _solicitanteService)
        {
            // INJECAO DE DEPENDENCIA
            iSolicitanteService = _solicitanteService;


            Id = Guid.NewGuid(); 
            DataDemanda = DateTime.MinValue;
            DescricaoDemanda =string.Empty;
            StatusDemanda = EStatusDemanda.None;
            DataCadastro=DateTime.MinValue;
            DataAlteracao=DateTime.MinValue;
            IdUsuarioCadastro = string.Empty;
            IdUsuarioAlteracao= string.Empty;
            oSolicitante = new SolicitanteEntity();

        }

        public SolicitanteEntity ObterSolicitanteDemanda()
        {
            return iSolicitanteService.ObterDetalheSolicitantePorDemanda(this.Id.ToString());
        }
    }
}
