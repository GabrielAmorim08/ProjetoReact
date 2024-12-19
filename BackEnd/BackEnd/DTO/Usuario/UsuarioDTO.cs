using BackEnd.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.Models.Usuario
{
    public class UsuarioDTO : BaseDTO
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public string Senha { get; set; }
        public DateTime? Data_Nascimento{ get; set; }
    }
}
