using System;
using System.Collections.Generic;
using System.Text;

namespace OBS.Domain.Entity
{
    public class AreaNegocioDemandaEntity : EntityBase
    {
        public string IdAreaNegocio { get; set; }
        public string IdDemanda { get; set; }
        public string DescricaoSolucao { get; set; }
        public bool IsAprovado { get; set; }
        public DateTime DataAvaliacao { get; set; }

        public AreaNegocioDemandaEntity()
        {
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

    }
}
