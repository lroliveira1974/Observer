using OBS.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace OBS.Domain.Interface.Service
{
    public interface IUsuarioService
    {
        List<UsuarioEntity> ObterListaUsuarios();
        List<UsuarioEntity> ObterListaUsuariosPorGrupo(string IdGrupoUsuario);
        UsuarioEntity ObterDetalheUsuario(string IdUsuario);
        UsuarioEntity InserirUsuario(UsuarioEntity oUsuario);
        UsuarioEntity AlterarUsuario(UsuarioEntity oUsuario);

    }
}
