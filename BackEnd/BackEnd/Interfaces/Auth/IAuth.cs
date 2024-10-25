using DTOS.Usuarios;

namespace BackEnd.Interfaces.Auth
{
    public interface IAuth
    {
        public bool AuthUser(UsuarioDTO usuario);
    }
}
