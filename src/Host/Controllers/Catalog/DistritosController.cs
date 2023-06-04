using FSH.WebApi.Application.Catalog.Distritos;

namespace FSH.WebApi.Host.Controllers.Catalog;

public class DistritosController : VersionedApiController
{
    [HttpGet("getallbycanton/{idcanton:guid}")]
    [MustHavePermission(FSHAction.Search, FSHResource.Distritos)]
    [OpenApiOperation("Listing all distritos by canton.", "")]
    public Task<IReadOnlyList<DistritoDto>> GetDistritosByCantonAsync(Guid idcanton)
    {
        return Mediator.Send(new GetDistritosRequest(idcanton));
    }
}
