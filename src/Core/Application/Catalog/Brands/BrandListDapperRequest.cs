using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSH.WebApi.Application.Catalog.Brands;
public class BrandListDapperRequest : IRequest<IReadOnlyList<BrandDto>>
{
}

public class BrandListDapperRequestHandler : IRequestHandler<BrandListDapperRequest, IReadOnlyList<BrandDto>>
{
    private readonly IDapperRepository _repository;
    private readonly ICurrentUser _currentUser;

    public BrandListDapperRequestHandler(IDapperRepository repository, ICurrentUser currentUser)
    {
        _repository = repository;
        _currentUser = currentUser;
    }

    public async Task<IReadOnlyList<BrandDto>> Handle(BrandListDapperRequest request, CancellationToken cancellationToken)
    {
        // Guid userId = _currentUser.GetUserId();

        // Dictionary<string, object>? parametros = new Dictionary<string, object>
        // {
        //    { "@Id", "91AA0B88-EAEA-45D9-906C-08DB5C94EB27" },
        //    { "@Name", "MAVESA GREAT" },
        //    { "@Description", "MAVESA es la marca por excelencia en mantequilla en VZLA" },
        //    { "@LastModifiedBy", userId }
        // };

        // int totalRec = await _repository.ExecSpNonQueryAsync("BrandUpdate", parametros, cancellationToken: cancellationToken);

        List<BrandDto> lstresult = new List<BrandDto>();

        var values = new Dictionary<string, object>
        {
            { "@Name", "Random"}
        };

        var lstx = await _repository.ExecSpQueryAsync<Brand>("BrandGetAll", values, cancellationToken: cancellationToken);

        // var lst = lstx.Adapt<List<BrandDto>>();

        // if (lstx is not null)
        // {
        //    foreach (var item in lstx)
        //    {
        //        lstresult.Add(new BrandDto { Id = item.Id, Description = item.Description, Name = item.Name });
        //    }
        // }

        return lstx.Adapt<List<BrandDto>>();
    }
}
