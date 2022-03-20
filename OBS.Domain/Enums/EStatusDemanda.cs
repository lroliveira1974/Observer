using System;
using System.Collections.Generic;
using System.Text;

namespace OBS.Domain.Enums
{
    public enum EStatusDemanda
    {
        None=-1,
        Recebida=0,
        EmAnalise=1,
        DirecionadaParaAreadeNegocio=2,
        EmAnaliseSolucaoProposta=3,
        ElaborandoConclusao=4,
        EncaminhadaSolicitante=5,
        AprovadaSolicitante=6,
        ReprovadaSolicitante=7,
        EmAnaliseOuvidor=8,
        Finalizada=9,
        Cancelada=10
    }
}
