using OBS.Domain.Interface.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace OBS.Domain.Entity
{
    public class GrupoUsuarioEntity
    {
        // INTERFACES A SEREM UTILIZADAS
        private IUsuarioService iUsuarioService;


        public Guid Id { get; set; }
        public string NomeGrupo { get; set; }
        public bool IsAtivo { get; set; }
        public List<UsuarioEntity> lUsuarios { get; set; }

        public GrupoUsuarioEntity(IUsuarioService _usuarioService)
        {
            //INJECAO DE DEPENDENCIA
            this.iUsuarioService = _usuarioService;

            this.Id=Guid.NewGuid();
            this.NomeGrupo = string.Empty;
            this.IsAtivo = false;
            this.lUsuarios = new List<UsuarioEntity>();
        }

        public List<UsuarioEntity> ObterListaUsuario()
        {
            return iUsuarioService.ObterListaUsuariosPorGrupo(this.Id.ToString());
        }
    }
}
