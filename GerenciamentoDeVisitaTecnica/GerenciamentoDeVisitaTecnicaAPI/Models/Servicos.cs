namespace GerenciamentoDeVisitaTecnicaAPI.Models
{
    public class Servicos
    {
        public int Id { get; set; }
        public string NomeServico { get; set; }
        public decimal valor { get; set; }
        public List<Material> materiais { get; set; }
        public PrestadorServico prestadorServicoId { get; set; }
        public Cliente clienteId { get; set; }
        public DateTime? dataServico { get; set; }
        public TimeSpan Duracao { get; set; }
        public int? AvaliacaoCliente { get; set; }
    }
}
