using System;
using System.Collections.Generic;
using System.Text;

namespace OBS.Domain.Entity
{
    public class SolicitanteEntity : EntityBase
    {

        public string NomeSolicitante { get;set; }
        public string EmailSolicitante { get; set; }
        public string TelefoneSolicitante { get; set; } 
        public IList<DemandaEntity> lDemandas { get; set; }


        public SolicitanteEntity()
        {
            Id = Guid.NewGuid();
            NomeSolicitante = string.Empty;
            EmailSolicitante = string.Empty;
            TelefoneSolicitante = string.Empty;
            DataCadastro = DateTime.MinValue;
            DataAlteracao = DateTime.MinValue;
            IdUsuarioCadastro = 0;
            IdUsuarioAlteracao = 0;
            lDemandas = new List<DemandaEntity>();

        }

    }
}
