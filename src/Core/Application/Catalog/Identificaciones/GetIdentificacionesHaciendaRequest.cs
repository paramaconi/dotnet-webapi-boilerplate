using FSH.WebApi.Shared.Identificacion;
using Mapster;

namespace FSH.WebApi.Application.Catalog.Identificaciones;
public class GetIdentificacionesHaciendaRequest : IRequest<IReadOnlyList<TipoIdentificacionDto>>
{
}

public class GetIdentificacionesHaciendaRequestHandler : IRequestHandler<GetIdentificacionesHaciendaRequest, IReadOnlyList<TipoIdentificacionDto>>
{
    public async Task<IReadOnlyList<TipoIdentificacionDto>> Handle(GetIdentificacionesHaciendaRequest request, CancellationToken cancellationToken)
    {
        List<TipoIdentificacionDto> result = new();
        var lst = await Task.FromResult(TiposIdentificacion.Hacienda);

        foreach (var item in lst)
        {
            result.Add(new TipoIdentificacionDto { Id = item.id, Descripcion = item.descripcion });
        }

        return await Task.FromResult(result);
    }
}