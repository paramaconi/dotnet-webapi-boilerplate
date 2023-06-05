namespace FSH.WebApi.Domain.Catalog;
public class Provincia : AuditableEntity, IAggregateRoot
{
    public string LocationID { get; set; } = default!;
    public string Name { get; set; } = default!;

    public Provincia()
    {
    }
}
