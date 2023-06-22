using FSH.WebApi.Shared.Identificacion;
using Mapster;

namespace FSH.WebApi.Application.Catalog.Identificaciones;
public class GetIdentificacionesSugefRequest : IRequest<IReadOnlyList<TipoIdentificacionDto>>
{
}

public class GetIdentificacionesSugefRequestHandler : IRequestHandler<GetIdentificacionesSugefRequest, IReadOnlyList<TipoIdentificacionDto>>
{
    public async Task<IReadOnlyList<TipoIdentificacionDto>> Handle(GetIdentificacionesSugefRequest request, CancellationToken cancellationToken)
    {
        List<TipoIdentificacionDto> result = new();
        var lst = await Task.FromResult(TiposIdentificacion.Sugef);

        foreach (var item in lst)
        {
            result.Add(new TipoIdentificacionDto { Id = item.id, Descripcion = item.descripcion });
        }

        return await Task.FromResult(result);
    }
}