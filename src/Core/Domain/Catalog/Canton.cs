namespace FSH.WebApi.Domain.Catalog;
public class Canton : AuditableEntity, IAggregateRoot
{
    public string LocationID { get; set; } = default!;
    public string Name { get; set; } = default!;
    public Guid ProvinciaId { get; set; }
    public virtual Provincia Provincia { get; set; } = default!;
}
