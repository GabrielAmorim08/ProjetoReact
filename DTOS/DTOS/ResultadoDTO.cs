
namespace DTOS
{
	public class ResultadoDTO
	{
        public bool Sucesso { get; set; }
        public string Mensagem { get; set; }
    }
    public class ResultadoDTO
    {
        public bool Sucesso { get; set; }
        public string Mensagem { get; set; }
        public T Retorno {get;set;}
    }

}
