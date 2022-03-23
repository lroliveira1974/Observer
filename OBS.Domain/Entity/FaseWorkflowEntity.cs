using System;
using System.Collections.Generic;
using System.Text;

namespace OBS.Domain.Entity
{
    public class FaseWorkflowEntity : EntityBase
    {
        public string NomeFase { get; set; }
        public int PrazoEmDiasParaResposta { get; set; }
        public string IdFaseAnterior { get; set; }
        public string IdProximaFase { get; set; }

        public FaseWorkflowEntity()
        {
            this.Id = Guid.NewGuid();
            this.NomeFase = string.Empty;
            this.PrazoEmDiasParaResposta = 0;
            this.IdFaseAnterior = string.Empty;
            this.IdProximaFase = string.Empty;
            this.DataCadastro = DateTime.MinValue;
            this.DataAlteracao = DateTime.MinValue;
            this.IdUsuarioCadastro = string.Empty;
            this.IdUsuarioAlteracao = string.Empty;
        }
    }
}
