namespace BackEnd.Models.Usuarios
{
    public class Usuario
    {
        public Guid Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime? Data_Nascimento { get; set; }
    }
}
