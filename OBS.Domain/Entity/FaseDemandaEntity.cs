using System;
using System.Collections.Generic;
using System.Text;

namespace OBS.Domain.Entity
{
    public class FaseDemandaEntity : EntityBase
    {
        public string IdDemanda { get; set; }
        public string IdFaseAtual { get; set; }
        public DateTime DataInicioFase { get; set; }
        public DateTime DataFimFase { get; set; }

        public FaseDemandaEntity()
        {
            this.IdDemanda = string.Empty;
            this.IdFaseAtual = string.Empty;
            this.DataInicioFase = DateTime.MinValue;
            this.DataFimFase = DateTime.MinValue;
        }
    }
}
