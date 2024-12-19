using System.Collections.Generic;

namespace BackEnd.DTO
{
    public class ResultadoDTO
    {
        ResultadoDTO() { }

        public ResultadoDTO(bool sucesso, string mensagem)
        {
            Sucesso = sucesso;
            Mensagem = mensagem;
        }

        public bool Sucesso { get; set; }
        public string Mensagem { get; set; }
        public object Retorno { get; set; }
    }
    public class ResultadoDTO<T>
    {
        public ResultadoDTO(bool sucesso, string mensagem, T retorno)
        {
            Sucesso= sucesso;
            Mensagem = mensagem;
            Retorno = retorno;
        }
        public bool Sucesso { get; set; }
        public string Mensagem { get; set; }
        public T Retorno { get; set; }

    }
}
