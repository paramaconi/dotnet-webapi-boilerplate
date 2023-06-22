namespace FSH.WebApi.Application.Catalog.Sociedades;
public class SociedadByIdentificacionSpec : Specification<Sociedad>, ISingleResultSpecification
{
    public SociedadByIdentificacionSpec(string identificacion)
        => Query.Where(s => s.Identificacion == identificacion);
}
