using Mapster;

namespace FSH.WebApi.Application.Catalog.Barrios;
public class GetBarriosRequest : IRequest<IReadOnlyList<BarrioDto>>
{
    public Guid DistritoId { get; set; }
    public GetBarriosRequest(Guid distritoid) => DistritoId = distritoid;
}

public class GetBarriosRequestHandler : IRequestHandler<GetBarriosRequest, IReadOnlyList<BarrioDto>>
{
    private IDapperRepository _repository;
    public GetBarriosRequestHandler(IDapperRepository repository) => _repository = repository;

    public async Task<IReadOnlyList<BarrioDto>> Handle(GetBarriosRequest request, CancellationToken cancellationToken)
    {
        var values = new Dictionary<string, object>
        {
            { "@DistritoId", request.DistritoId}
        };
        var lst = await _repository.ExecSpQueryDynamicAsync("BarrioGetAllByDistritoId", values, isTenantRequired: false, null, cancellationToken: cancellationToken);
        return lst.Adapt<List<BarrioDto>>();
    }
}