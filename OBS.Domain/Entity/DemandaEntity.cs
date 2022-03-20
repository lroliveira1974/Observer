﻿using OBS.Domain.Enums;
using System;


namespace OBS.Domain.Entity
{
    public class DemandaEntity : EntityBase
    {

    
        public DateTime DataDemanda { get; set; }
        public string DescricaoDemanda { get; set; }
        public EStatusDemanda StatusDemanda { get; set; }
        public SolicitanteEntity oSolicitante { get; set; }
        

        public DemandaEntity()
        {
            Id = Guid.NewGuid(); 
            DataDemanda = DateTime.MinValue;
            DescricaoDemanda =string.Empty;
            StatusDemanda = EStatusDemanda.None;
            DataCadastro=DateTime.MinValue;
            DataAlteracao=DateTime.MinValue;
            IdUsuarioCadastro = 0;
            IdUsuarioAlteracao=0;
            oSolicitante = new SolicitanteEntity();

        }
    }
}
