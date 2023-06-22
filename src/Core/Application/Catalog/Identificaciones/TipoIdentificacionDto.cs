namespace FSH.WebApi.Application.Catalog.Identificaciones;
public class TipoIdentificacionDto : IDto
{
    public string Id { get; set; } = default!;
    public string Descripcion { get; set; } = default!;
}
