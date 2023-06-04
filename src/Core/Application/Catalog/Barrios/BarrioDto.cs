namespace FSH.WebApi.Application.Catalog.Barrios;
public class BarrioDto : IDto
{
    public Guid Id { get; set; }
    public string LocationID { get; set; } = default!;
    public string Name { get; set; } = default!;
    public Guid DistritoId { get; set; }
    public virtual Distrito Distrito { get; set; } = default!;
}
