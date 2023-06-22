using FSH.WebApi.Application.Catalog.Brands;
using FSH.WebApi.Application.Catalog.Sociedades;

namespace FSH.WebApi.Host.Controllers.Catalog;

public class SociedadesController : VersionedApiController
{
    [HttpPost("search")]
    [MustHavePermission(FSHAction.Search, FSHResource.Brands)]
    [OpenApiOperation("Search sociedades using available filters.", "")]
    public Task<PaginationResponse<SociedadDto>> SearchAsync(SearchSociedadesRequest request)
    {
        return Mediator.Send(request);
    }

    [HttpGet("{id:guid}")]
    [MustHavePermission(FSHAction.View, FSHResource.Sociedades)]
    [OpenApiOperation("Get sociedades details.", "")]
    public Task<SociedadDto> GetAsync(Guid id)
    {
        return Mediator.Send(new GetSociedadRequest(id));
    }

    [HttpPost]
    [MustHavePermission(FSHAction.Create, FSHResource.Sociedades)]
    [OpenApiOperation("Create a new sociedad.", "")]
    public Task<Guid> CreateAsync(CreateSociedadRequest request)
    {
        return Mediator.Send(request);
    }
}
