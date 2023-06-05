namespace FSH.WebApi.Domain.Catalog;
public class Distrito : AuditableEntity, IAggregateRoot
{
    public string LocationID { get; set; } = default!;
    public string Name { get; set; } = default!;
    public Guid CantonId { get; set; }
    public virtual Canton Canton { get; set; } = default!;

    public Distrito()
    {
    }
}
