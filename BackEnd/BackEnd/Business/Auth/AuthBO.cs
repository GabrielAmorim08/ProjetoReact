using BackEnd.DTO;
using BackEnd.Interfaces.Auth;
using BackEnd.Models;
using BackEnd.Models.Usuario;

namespace BackEnd.Business.Auth
{
    public class AuthBO : IAuth
    {
        protected readonly BibliotecaContext _context;
        public AuthBO(BibliotecaContext context)
        {
            _context = context;
        }

        public ResultadoDTO<UsuarioDTO> AuthUser(UsuarioDTO usuario)
        {
            try
            {
                var existeLogin = _context.Usuario.FirstOrDefault(x => x.Cpf == usuario.Cpf);

                if (existeLogin == null)
                    return new ResultadoDTO<UsuarioDTO>(false,"Usuario não possui cadastro",new UsuarioDTO());
                if (usuario.Senha != existeLogin.Senha)
                    return new ResultadoDTO<UsuarioDTO>(false, "Senha incorreta", new UsuarioDTO());

                return new ResultadoDTO<UsuarioDTO>(false, "Usuario Cadastrado", existeLogin);
            }
            catch (Exception ex)
            {
                return new ResultadoDTO<UsuarioDTO>(false, ex.Message, new UsuarioDTO());
            }
        }
    }
}
