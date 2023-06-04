using FSH.WebApi.Application.Catalog.Cantones;

namespace FSH.WebApi.Host.Controllers.Catalog;

public class CantonesController : VersionedApiController
{
    [HttpGet("getallbyprovincia/{idprovincia:guid}")]
    [MustHavePermission(FSHAction.Search, FSHResource.Cantones)]
    [OpenApiOperation("Listing all cantones by provincia.", "")]
    public Task<IReadOnlyList<CantonDto>> GetCantonesByProvinciasAsync(Guid idprovincia)
    {
        return Mediator.Send(new GetCantonesRequest(idprovincia));
    }
}
