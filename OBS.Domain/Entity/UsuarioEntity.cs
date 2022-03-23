using System;
using System.Collections.Generic;
using System.Text;

namespace OBS.Domain.Entity
{
    public class UsuarioEntity : EntityBase
    {
        public string NomeUsuario { get; set; }
        public string EmailUsuario { get; set; }
        public bool FlgAtivo { get; set; }

        
    }
}
