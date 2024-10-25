using BackEnd.Interfaces.Auth;
using BackEnd.Models;
using DTOS.Usuarios;
using Microsoft.AspNetCore.Http.HttpResults;
using System.CodeDom;

namespace BackEnd.Business.Auth
{
    public class AuthBO : IAuth
    {
        protected readonly BibliotecaContext _context;
        public AuthBO(BibliotecaContext context)
        {
            _context = context;
        }

        public bool AuthUser(UsuarioDTO usuario)
        {
            try
            {
                var existeLogin = _context.Usuario.FirstOrDefault(x => x.Cpf == usuario.Cpf);

                if (existeLogin == null)
                {
                    return false;
                }
                if(usuario.Cpf != existeLogin.Cpf)
                {
                    return false;
                }
                if (usuario.Senha != existeLogin.Senha) 
                {
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
