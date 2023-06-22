namespace FSH.WebApi.Application.Catalog.Sociedades;
public class SociedadByRazonSocialSpec : Specification<Sociedad>, ISingleResultSpecification
{
    public SociedadByRazonSocialSpec(string razonSocial) =>
        Query.Where(b => b.RazonSocial == razonSocial);
}
