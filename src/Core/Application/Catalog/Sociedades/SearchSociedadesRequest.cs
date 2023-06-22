namespace FSH.WebApi.Application.Catalog.Sociedades;
public class SearchSociedadesRequest : PaginationFilter, IRequest<PaginationResponse<SociedadDto>>
{
}

public class SociedadesBySearchRequestSpec : EntitiesByPaginationFilterSpec<Sociedad, SociedadDto>
{
    public SociedadesBySearchRequestSpec(SearchSociedadesRequest request)
        : base(request) =>
        Query.OrderBy(c => c.RazonSocial, !request.HasOrderBy());
}

public class SearchSociedadesRequestHandler : IRequestHandler<SearchSociedadesRequest, PaginationResponse<SociedadDto>>
{
    private readonly IReadRepository<Sociedad> _repository;

    public SearchSociedadesRequestHandler(IReadRepository<Sociedad> repository) => _repository = repository;

    public async Task<PaginationResponse<SociedadDto>> Handle(SearchSociedadesRequest request, CancellationToken cancellationToken)
    {
        var spec = new SociedadesBySearchRequestSpec(request);
        return await _repository.PaginatedListAsync(spec, request.PageNumber, request.PageSize, cancellationToken);
    }
}
