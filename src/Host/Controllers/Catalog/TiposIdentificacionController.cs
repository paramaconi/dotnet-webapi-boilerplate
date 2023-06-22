using FSH.WebApi.Application.Catalog.Barrios;
using FSH.WebApi.Application.Catalog.Identificaciones;
using FSH.WebApi.Shared.Identificacion;

namespace FSH.WebApi.Host.Controllers.Catalog;

public class TiposIdentificacionController : VersionedApiController
{
    [HttpGet("hacienda")]
    [AllowAnonymous]
    [OpenApiOperation("Listado de identificaciones de hacienda.", "")]
    public Task<IReadOnlyList<TipoIdentificacionDto>> GetIdentificacionesHaciendadAsync()
    {
        return Mediator.Send(new GetIdentificacionesHaciendaRequest());
    }

    [HttpGet("sugef")]
    [AllowAnonymous]
    [OpenApiOperation("Listado de identificaciones de sugef.", "")]
    public Task<IReadOnlyList<TipoIdentificacionDto>> GetIdentificacionesSugefAsync()
    {
        return Mediator.Send(new GetIdentificacionesSugefRequest());
    }
}
