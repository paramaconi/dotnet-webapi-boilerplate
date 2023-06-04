using FSH.WebApi.Application.Common.Persistence;
using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSH.WebApi.Application.Catalog.Provincias;
public class SearchProvinciasRequest : IRequest<IReadOnlyList<ProvinciaDto>>
{
}

public class SearchProvinciasRequestHandler : IRequestHandler<SearchProvinciasRequest, IReadOnlyList<ProvinciaDto>>
{
    private readonly IDapperRepository _repository;

    public SearchProvinciasRequestHandler(IDapperRepository repository)
    {
        _repository = repository;
    }

    public async Task<IReadOnlyList<ProvinciaDto>> Handle(SearchProvinciasRequest request, CancellationToken cancellationToken)
    {
        var lst = await _repository.ExecSpQueryDynamicAsync("ProvinciasGetAll", null, isTenantRequired: false, null, cancellationToken: cancellationToken);
        return lst.Adapt<List<ProvinciaDto>>();
    }
}
