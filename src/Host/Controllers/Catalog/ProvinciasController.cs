using FSH.WebApi.Application.Catalog.Provincias;

namespace FSH.WebApi.Host.Controllers.Catalog;

public class ProvinciasController : VersionedApiController
{
    [HttpGet("getAll")]
    [MustHavePermission(FSHAction.Search, FSHResource.Provincias)]
    [OpenApiOperation("Listing all provincias.", "")]
    public Task<IReadOnlyList<ProvinciaDto>> GetProvinciasAsync()
    {
        return Mediator.Send(new SearchProvinciasRequest());
    }
}
