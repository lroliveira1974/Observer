using System;
using System.Collections.Generic;
using System.Text;

namespace OBS.Domain.Interface.Service
{
    public interface IAreaNegocioService
    {
        List<IAreaNegocioService> ObterListaAreaNegocio();
        IAreaNegocioService ObterDetalheAreaNegocio(string IdAreaNegocio);
    }
}
