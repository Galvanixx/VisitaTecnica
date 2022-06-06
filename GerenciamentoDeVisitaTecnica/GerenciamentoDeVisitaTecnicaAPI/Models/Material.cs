namespace GerenciamentoDeVisitaTecnicaAPI.Models
{
    public class Material
    {
        public int Id { get; set; }
        public TipoMaterial tipoMaterialId { get; set; }
        public decimal? Quantidade { get; set; }
        public Servicos servicosID { get; set; }
    
    }
}
