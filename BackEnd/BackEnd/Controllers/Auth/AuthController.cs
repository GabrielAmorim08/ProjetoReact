using Microsoft.AspNetCore.Mvc;
using DTOS.Usuarios;
using BackEnd.Interfaces.Auth;
using BackEnd.Models.Usuario;
using BackEnd.DTO;
namespace BackEnd.Controllers.Auth
{
    [ApiController]
    [Route("api/Auth")]
    public class AuthController : ControllerBase
    {
        protected readonly IAuth _auth;
        public AuthController(IAuth auth)
        {
            _auth = auth;
        }

        [HttpPost]
        [Route("AuthUser")]
        public ResultadoDTO<UsuarioDTO> AuthUser([FromBody] UsuarioDTO usuario) =>_auth.AuthUser(usuario);
    }
}
