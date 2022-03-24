using OBS.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace OBS.Domain.Interface.Service
{
    public interface IGrupoUsuarioService
    {
        List<GrupoUsuarioEntity> ObterGrupoUsuario(string IdUsuario);
        GrupoUsuarioEntity ObterDetalheGrupoUsuario(string IdGrupoUsuario);
        GrupoUsuarioEntity InserirGrupoUsuario(GrupoUsuarioEntity oGrupoUsuario);
        GrupoUsuarioEntity AlterarGrupoUsuario(GrupoUsuarioEntity oGrupoUsuario);
    }
}
