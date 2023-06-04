namespace FSH.WebApi.Application.Catalog.Distritos;
public class DistritoDto : IDto
{
    public Guid Id { get; set; }
    public string LocationID { get; set; } = default!;
    public string Name { get; set; } = default!;
    public Guid CantonId { get; set; }
    public virtual Canton Canton { get; set; } = default!;
}
