using System;
using System.Collections.Generic;
using System.Text;

namespace OBS.Domain.Entity
{
    public class AreaNegocioEntity : EntityBase 
    {
        public string NomeAreaNegocio { get; set; }
        public List<UsuarioEntity> lUsuarios { get; set; }

        public AreaNegocioEntity()
        {
            this.Id = Guid.NewGuid();
            this.NomeAreaNegocio = String.Empty;
            this.lUsuarios = new List<UsuarioEntity>();
        }
    }
}
