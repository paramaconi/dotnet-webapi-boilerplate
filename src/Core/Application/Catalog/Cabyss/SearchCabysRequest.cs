namespace FSH.WebApi.Application.Catalog.Cabyss;
public class SearchCabysRequest : PaginationFilter, IRequest<PaginationResponse<CabysDto>>
{
}

public class SearchCabysRequestSpec : EntitiesByPaginationFilterSpec<Cabys, CabysDto>
{
    public SearchCabysRequestSpec(SearchCabysRequest request)
        : base(request) =>
        Query.OrderBy(c => c.Descripcion, !request.HasOrderBy());
}

public class SearchCabysRequestHandler : IRequestHandler<SearchCabysRequest, PaginationResponse<CabysDto>>
{
    private readonly IReadRepository<Cabys> _repository;

    public SearchCabysRequestHandler(IReadRepository<Cabys> repository) => _repository = repository;

    public async Task<PaginationResponse<CabysDto>> Handle(SearchCabysRequest request, CancellationToken cancellationToken)
    {
        var spec = new SearchCabysRequestSpec(request);
        return await _repository.PaginatedListAsync(spec, request.PageNumber, request.PageSize, cancellationToken);
    }
}
