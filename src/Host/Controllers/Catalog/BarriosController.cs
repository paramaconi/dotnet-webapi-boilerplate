using FSH.WebApi.Application.Catalog.Barrios;

namespace FSH.WebApi.Host.Controllers.Catalog;

public class BarriosController : VersionedApiController
{
    [HttpGet("getallbydistrito/{iddistrito:guid}")]
    [MustHavePermission(FSHAction.Search, FSHResource.Barrios)]
    [OpenApiOperation("Listing all barrios by distrito.", "")]
    public Task<IReadOnlyList<BarrioDto>> GetBarriosByDistritoAsync(Guid iddistrito)
    {
        return Mediator.Send(new GetBarriosRequest(iddistrito));
    }
}
