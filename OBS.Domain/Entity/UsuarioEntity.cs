using OBS.Domain.Interface.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace OBS.Domain.Entity
{
    public class UsuarioEntity : EntityBase
    {
        // DEFINICAO DE INTERFACES A SEREM UTILIZADAS
        private IGrupoUsuarioService iGrupoUsuarioService;

        // ATRIBUTOS
        public string NomeUsuario { get; set; }
        public string EmailUsuario { get; set; }
        public bool IsAtivo { get; set; }
        public List<GrupoUsuarioEntity> lGrupoUsuario { get; set; }


        // CONSTRUTOR PADRAO
        public UsuarioEntity(IGrupoUsuarioService _grupoUsuarioService)
        {
            // INJEÇÃO DE DEPENDENCIA
            this.iGrupoUsuarioService = _grupoUsuarioService;


            this.Id = Guid.NewGuid();
            this.NomeUsuario = String.Empty;
            this.EmailUsuario = String.Empty;
            this.IsAtivo = false;
            this.lGrupoUsuario = new List<GrupoUsuarioEntity>();
            this.DataCadastro = DateTime.MinValue;
            this.DataAlteracao = DateTime.MinValue;
            this.IdUsuarioCadastro = String.Empty;
            this.IdUsuarioAlteracao = String.Empty;
        }

        public List<GrupoUsuarioEntity> ObterGrupoUsuarios()
        {
            return iGrupoUsuarioService.ObterGrupoUsuario(this.Id.ToString());
        }
        
    }
}
