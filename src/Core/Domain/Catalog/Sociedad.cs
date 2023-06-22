using System.Runtime.InteropServices;

namespace FSH.WebApi.Domain.Catalog;
public class Sociedad : AuditableEntity, IAggregateRoot
{
    public string RazonSocial { get; private set; } = default!;
    public string? NombreComercial { get; private set; }
    public string TipoIdentificacion { get; private set; } = default!;
    public string Identificacion { get; private set; } = default!;
    public Guid ProvinciaId { get; private set; }
    public Guid CantonId { get; private set; }
    public Guid DistritoId { get; private set; }
    public Guid? BarrioId { get; private set; }
    public string OtrasSenas { get; private set; } = default!;
    public string? CodigoPaisPrincipal { get; private set; }
    public string? NumTelefonoPrincipal { get; private set; }
    public string? CodigoPaisSecundario { get; private set; }
    public string? NumTelefonoSecundario { get; private set; }
    public string? CodigoPaisFax { get; private set; }
    public string? Fax { get; private set; }
    public string? CorreoElectronico { get; private set; }
    public string? LogoPath { get; private set; }
    public virtual Provincia Provincia { get; set; } = default!;
    public virtual Canton Canton { get; set; } = default!;
    public virtual Distrito Distrito { get; set; } = default!;
    public virtual Barrio? Barrio { get; set; }

    public virtual List<ActividadEconomicaPorSociedad>? ActividadesEconomicas { get; set; }

    public Sociedad(string razonSocial, string? nombreComercial, string tipoIdentificacion, string identificacion, Guid provinciaId, Guid cantonId, Guid distritoId, Guid? barrioId, string otrasSenas, string? codigoPaisPrincipal, string? numTelefonoPrincipal, string? codigoPaisSecundario, string? numTelefonoSecundario, string? codigoPaisFax, string? fax, string? correoElectronico, string? logoPath)
    {
        RazonSocial = razonSocial;
        NombreComercial = nombreComercial;
        TipoIdentificacion = tipoIdentificacion;
        Identificacion = identificacion;
        ProvinciaId = provinciaId;
        CantonId = cantonId;
        DistritoId = distritoId;
        BarrioId = barrioId!.Value;
        OtrasSenas = otrasSenas;
        CodigoPaisPrincipal = codigoPaisPrincipal;
        NumTelefonoPrincipal = numTelefonoPrincipal;
        CodigoPaisSecundario = codigoPaisSecundario;
        NumTelefonoSecundario = numTelefonoSecundario;
        CodigoPaisFax = codigoPaisFax;
        Fax = fax;
        CorreoElectronico = correoElectronico;
        LogoPath = logoPath;
    }

    public Sociedad Update(string? razonSocial, string? nombreComercial, string? tipoIdentificacion, string? identificacion, Guid? provinciaId, Guid? cantonId, Guid? distritoId, Guid? barrioId, string? otrasSenas, string? codigoPaisPrincipal, string? numTelefonoPrincipal, string? codigoPaisSecundario, string? numTelefonoSecundario, string? codigoPaisFax, string? fax, string? correoElectronico, string? logoPath)
    {
        if (razonSocial is not null && RazonSocial.Equals(razonSocial) is not true) RazonSocial = razonSocial;
        if (nombreComercial is not null && NombreComercial?.Equals(nombreComercial) is not true) NombreComercial = nombreComercial;
        if (tipoIdentificacion is not null && TipoIdentificacion.Equals(tipoIdentificacion) is not true) TipoIdentificacion = tipoIdentificacion;
        if (identificacion is not null && Identificacion.Equals(identificacion) is not true) Identificacion = identificacion;
        if (provinciaId.HasValue && provinciaId.Value != Guid.Empty && ProvinciaId.Equals(provinciaId.Value) is not true) ProvinciaId = provinciaId.Value;
        if (cantonId.HasValue && cantonId.Value != Guid.Empty && CantonId.Equals(cantonId.Value) is not true) CantonId = cantonId.Value;
        if (distritoId.HasValue && distritoId.Value != Guid.Empty && DistritoId.Equals(distritoId.Value) is not true) DistritoId = distritoId.Value;
        if (barrioId.HasValue && barrioId.Value != Guid.Empty && BarrioId?.Equals(barrioId.Value) is not true) BarrioId = barrioId.Value;
        if (otrasSenas is not null && OtrasSenas.Equals(otrasSenas) is not true) OtrasSenas = otrasSenas;
        if (codigoPaisPrincipal is not null && CodigoPaisPrincipal?.Equals(codigoPaisPrincipal) is not true) CodigoPaisPrincipal = codigoPaisPrincipal;
        if (numTelefonoPrincipal is not null && NumTelefonoPrincipal?.Equals(numTelefonoPrincipal) is not true) NumTelefonoPrincipal = numTelefonoPrincipal;
        if (codigoPaisSecundario is not null && CodigoPaisSecundario?.Equals(codigoPaisSecundario) is not true) CodigoPaisSecundario = codigoPaisSecundario;
        if (numTelefonoSecundario is not null && NumTelefonoSecundario?.Equals(numTelefonoSecundario) is not true) NumTelefonoSecundario = numTelefonoSecundario;
        if (codigoPaisFax is not null && CodigoPaisFax?.Equals(codigoPaisFax) is not true) CodigoPaisFax = codigoPaisFax;
        if (fax is not null && Fax?.Equals(fax) is not true) Fax = fax;
        if (correoElectronico is not null && CorreoElectronico?.Equals(correoElectronico) is not true) CorreoElectronico = correoElectronico;
        if (logoPath is not null && LogoPath?.Equals(logoPath) is not true) LogoPath = logoPath;
        return this;
    }

    public Sociedad ClearLogoPath()
    {
        LogoPath = string.Empty;
        return this;
    }
}
