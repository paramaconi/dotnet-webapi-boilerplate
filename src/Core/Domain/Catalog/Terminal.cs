namespace FSH.WebApi.Domain.Catalog;
public class Terminal : AuditableEntity, IAggregateRoot
{
    public string Codigo { get; private set; } = default!;
    public string Nombre { get; private set; } = default!;
    public Guid SucursalId { get; private set; }
    public virtual Sucursal Sucursal { get; private set; } = default!;

    public Terminal(string codigo, string nombre, Guid sucursalId)
    {
        Codigo = codigo;
        Nombre = nombre;
        SucursalId = sucursalId;
    }

    public Terminal Update(string? codigo, string? nombre, Guid? sucursalId)
    {
        if (codigo is not null && Codigo?.Equals(codigo) is not true) Codigo = codigo;
        if (nombre is not null && Nombre?.Equals(nombre) is not true) Nombre = nombre;
        if (sucursalId.HasValue && sucursalId.Value != Guid.Empty && !SucursalId.Equals(sucursalId.Value)) SucursalId = sucursalId.Value;
        return this;
    }
}
