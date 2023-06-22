namespace FSH.WebApi.Application.Catalog.Sociedades;
public class GetSociedadRequest : IRequest<SociedadDto>
{
    public Guid Id { get; set; }
    public GetSociedadRequest(Guid id) => Id = id;
}

public class SociedadByIdSpec : Specification<Sociedad, SociedadDto>, ISingleResultSpecification
{
    public SociedadByIdSpec(Guid id) =>
        Query.Where(p => p.Id == id);
}

public class GetSociedadRequestHandler : IRequestHandler<GetSociedadRequest, SociedadDto>
{
    private readonly IRepository<Sociedad> _repository;
    private readonly IStringLocalizer _t;

    public GetSociedadRequestHandler(IRepository<Sociedad> repository, IStringLocalizer<GetSociedadRequestHandler> localizer) => (_repository, _t) = (repository, localizer);

    public async Task<SociedadDto> Handle(GetSociedadRequest request, CancellationToken cancellationToken) =>
        await _repository.FirstOrDefaultAsync(
            (ISpecification<Sociedad, SociedadDto>)new SociedadByIdSpec(request.Id), cancellationToken)
        ?? throw new NotFoundException(_t["Sociedad {0} Not Found.", request.Id]);
}
