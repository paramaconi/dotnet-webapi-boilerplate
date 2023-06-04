using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSH.WebApi.Domain.Catalog;
public class Provincia
{
    public Guid Id { get; set; }
    public string LocationID { get; set; } = default!;
    public string Name { get; set; } = default!;

    public Provincia()
    {
    }
}
