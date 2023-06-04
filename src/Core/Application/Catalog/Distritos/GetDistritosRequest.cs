using Mapster;

namespace FSH.WebApi.Application.Catalog.Distritos;
public class GetDistritosRequest : IRequest<IReadOnlyList<DistritoDto>>
{
    public Guid CantonId { get; set; }
    public GetDistritosRequest(Guid cantonId) => CantonId = cantonId;
}

public class GetDistritosRequestHandler : IRequestHandler<GetDistritosRequest, IReadOnlyList<DistritoDto>>
{
    private readonly IDapperRepository _repository;

    public GetDistritosRequestHandler(IDapperRepository repository) => _repository = repository;

    public async Task<IReadOnlyList<DistritoDto>> Handle(GetDistritosRequest request, CancellationToken cancellationToken)
    {
        var values = new Dictionary<string, object>
        {
            { "@CantonId", request.CantonId}
        };
        var lst = await _repository.ExecSpQueryDynamicAsync("DistritoGetAllByCantonId", values, isTenantRequired: false, null, cancellationToken: cancellationToken);
        return lst.Adapt<List<DistritoDto>>();
    }
}