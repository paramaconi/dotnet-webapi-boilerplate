namespace FSH.WebApi.Domain.Catalog;
public class Cabys : AuditableEntity, IAggregateRoot
{
    public string CabysID { get; set; } = default!;
    public string? Descripcion { get; set; }
    public decimal Impuesto { get; set; }
    public string? NotaExplicativa1 { get; set; }
    public string? NotaExplicativa2 { get; set; }
}
