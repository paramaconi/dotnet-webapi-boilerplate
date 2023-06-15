namespace FSH.WebApi.Domain.Catalog;
public class ActividadEconomicaPorSociedad : AuditableEntity, IAggregateRoot
{
    public string Codigo { get; set; } = default!;
    public string Descripcion { get; set; } = default!;
    public Guid SociedadId { get; private set; }
    public virtual Sociedad Sociedad { get; private set; } = default!;

    public ActividadEconomicaPorSociedad(string codigo, string descripcion, Guid sociedadId)
    {
        Codigo = codigo;
        Descripcion = descripcion;
        SociedadId = sociedadId;
    }

    public ActividadEconomicaPorSociedad Update(string? codigo, string? descripcion, Guid? sociedadId)
    {
        if (codigo is not null && Codigo.Equals(codigo) is not true) Codigo = codigo;
        if (descripcion is not null && Descripcion.Equals(descripcion) is not true) Descripcion = descripcion;
        if (sociedadId.HasValue && sociedadId.Value != Guid.Empty && !SociedadId.Equals(sociedadId.Value)) SociedadId = sociedadId.Value;
        return this;
    }
}
