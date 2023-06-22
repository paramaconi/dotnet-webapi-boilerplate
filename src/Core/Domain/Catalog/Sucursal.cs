namespace FSH.WebApi.Domain.Catalog;
public class Sucursal : AuditableEntity, IAggregateRoot
{
    public string Codigo { get; private set; } = default!;
    public string Nombre { get; private set; } = default!;
    public Guid SociedadId { get; private set; }
    public virtual Sociedad Sociedad { get; private set; } = default!;

    public Sucursal(string codigo, string nombre, Guid sociedadId)
    {
        Codigo = codigo;
        Nombre = nombre;
        SociedadId = sociedadId;
    }

    public Sucursal Update(string? codigo, string? nombre, Guid? sociedadId)
    {
        if (codigo is not null && Codigo?.Equals(codigo) is not true) Codigo = codigo;
        if (nombre is not null && Nombre?.Equals(nombre) is not true) Nombre = nombre;
        if (sociedadId.HasValue && sociedadId.Value != Guid.Empty && !SociedadId.Equals(sociedadId.Value)) SociedadId = sociedadId.Value;
        return this;
    }
}
