namespace FSH.WebApi.Application.Catalog.Cantones;
public class CantonDto : IDto
{
    public Guid Id { get; set; }
    public string LocationID { get; set; } = default!;
    public string Name { get; set; } = default!;
    public Guid ProvinciaId { get; set; }
    public virtual Provincia Provincia { get; set; } = default!;
}
