namespace FSH.WebApi.Domain.Catalog;
public class Barrio : AuditableEntity, IAggregateRoot
{
    public string LocationID { get; set; } = default!;
    public string Name { get; set; } = default!;
    public Guid DistritoId { get; set; }
    public virtual Distrito Distrito { get; set; } = default!;

    public Barrio()
    {
    }
}
