using FSH.WebApi.Application.Catalog.Cabyss;

namespace FSH.WebApi.Host.Controllers.Catalog;

public class CabysController : VersionedApiController
{
    [HttpPost("search")]
    [MustHavePermission(FSHAction.Search, FSHResource.Cabys)]
    [OpenApiOperation("Search cabys using available filters.", "")]
    public Task<PaginationResponse<CabysDto>> searchAsync(SearchCabysRequest request)
    {
        return Mediator.Send(request);
    }
}