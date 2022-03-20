using System;
using System.Collections.Generic;
using System.Text;

namespace OBS.Domain.Entity
{
    public abstract class EntityBase
    {

        public Guid Id { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }
        public int IdUsuarioCadastro { get; set; }
        public int IdUsuarioAlteracao { get;set; }



        public EntityBase()
        {
            
        }

    }
}
