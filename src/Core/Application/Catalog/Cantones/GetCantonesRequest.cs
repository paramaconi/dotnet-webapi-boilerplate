using Mapster;

namespace FSH.WebApi.Application.Catalog.Cantones;
public class GetCantonesRequest : IRequest<IReadOnlyList<CantonDto>>
{
    public Guid ProvinciaId { get; set; }

    public GetCantonesRequest(Guid provinciaId) => ProvinciaId = provinciaId;
}

public class GetCantonesRequestHandler : IRequestHandler<GetCantonesRequest, IReadOnlyList<CantonDto>>
{
    private readonly IDapperRepository _repository;

    public GetCantonesRequestHandler(IDapperRepository repository) => _repository = repository;

    public async Task<IReadOnlyList<CantonDto>> Handle(GetCantonesRequest request, CancellationToken cancellationToken)
    {
        var values = new Dictionary<string, object>
        {
            { "@ProvinciaId", request.ProvinciaId}
        };
        var lst = await _repository.ExecSpQueryDynamicAsync("CantonGetAllByProvinciaId", values, isTenantRequired: false, null, cancellationToken: cancellationToken);
        return lst.Adapt<List<CantonDto>>();
    }
}
