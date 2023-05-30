using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSH.WebApi.Domain.Catalog;
public class Canton
{
    public Guid Id { get; set; }
    public string? LocationID { get; set; }
    public string Name { get; set; } = default!;
    public Guid ProvinciaId { get; set; }
    public virtual Provincia Provincia { get; set; } = default!;
}
