
using BackEnd.DTO;
using BackEnd.Models.Usuario;

namespace BackEnd.Interfaces.Auth
{
    public interface IAuth
    {
        public ResultadoDTO<UsuarioDTO> AuthUser(UsuarioDTO usuario);
    }
}
