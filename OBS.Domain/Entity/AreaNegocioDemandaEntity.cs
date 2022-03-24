using OBS.Domain.Interface.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace OBS.Domain.Entity
{
    public class AreaNegocioDemandaEntity : EntityBase
    {
        //INTERFACES UTILIZADAS
        //private IDemandaService iDemandaService;

        public string IdAreaNegocio { get; set; }
        public string IdDemanda { get; set; }
        public string DescricaoSolucao { get; set; }
        public bool IsAprovado { get; set; }
        public DateTime DataAvaliacao { get; set; }
        public List<DemandaEntity> lDemandas { get; set; }

        public AreaNegocioDemandaEntity()
        {
            //INJECAO DE DEPENDENCIA
            //iDemandaService = _demandaService;

            this.Id = Guid.NewGuid();
            this.IdAreaNegocio = String.Empty;
            this.IdDemanda = String.Empty;
            this.DescricaoSolucao = String.Empty;
            this.IsAprovado = false;
            this.DataAlteracao = DateTime.MinValue;
            this.IdUsuarioAlteracao = string.Empty;
            this.IdUsuarioCadastro = string.Empty;
            this.DataCadastro = DateTime.MinValue;
            this.DataAlteracao = DateTime.MinValue;
        }

        //public List<DemandaEntity> ObterListaDemandasAreaNegocio()
        //{
        //    return iDemandaService.ObterListaDemandasAreaNegocio(this.Id.ToString());
        //}

    }
}
