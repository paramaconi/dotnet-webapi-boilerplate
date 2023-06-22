namespace FSH.WebApi.Application.Catalog.Sociedades;
public class SociedadDto : IDto
{
    public string RazonSocial { get; set; } = default!;
    public string? NombreComercial { get; set; }
    public string TipoIdentificacion { get; set; } = default!;
    public string Identificacion { get; set; } = default!;
    public Guid ProvinciaId { get; private set; } = default!;
    public Guid CantonId { get; set; } = default!;
    public Guid DistritoId { get; set; } = default!;
    public Guid? BarrioId { get; set; }
    public string OtrasSenas { get; set; } = default!;
    public string? CodigoPaisPrincipal { get; set; }
    public string? NumTelefonoPrincipal { get; set; }
    public string? CodigoPaisSecundario { get; set; }
    public string? NumTelefonoSecundario { get; set; }
    public string? CodigoPaisFax { get; set; }
    public string? Fax { get; set; }
    public string? CorreoElectronico { get; set; }
    public string? LogoPath { get; set; }
}
