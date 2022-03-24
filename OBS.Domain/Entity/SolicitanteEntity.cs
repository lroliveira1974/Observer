using OBS.Domain.Interface.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace OBS.Domain.Entity
{
    public class SolicitanteEntity : EntityBase
    {
        //private IDemandaService iDemandaService;


        public string NomeSolicitante { get;set; }
        public string EmailSolicitante { get; set; }
        public string TelefoneSolicitante { get; set; } 
        public IList<DemandaEntity> lDemandas { get; set; }


        public SolicitanteEntity()
        {
            //this.iDemandaService = _demandaService;

            Id = Guid.NewGuid();
            NomeSolicitante = string.Empty;
            EmailSolicitante = string.Empty;
            TelefoneSolicitante = string.Empty;
            DataCadastro = DateTime.MinValue;
            DataAlteracao = DateTime.MinValue;
            IdUsuarioCadastro = string.Empty;
            IdUsuarioAlteracao = string.Empty;
            lDemandas = new List<DemandaEntity>();

        }

        //public List<DemandaEntity> ObterListaDemandas()
        //{                       
        //    return iDemandaService.ObterListaDemandas(this.Id.ToString());
        //}

    }
}
