using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSH.WebApi.Domain.Catalog;
public class Distrito
{
    public Guid Id { get; set; }
    public string? LocationID { get; set; }
    public string Name { get; set; } = default!;
    public Guid CantonId { get; set; }
    public virtual Canton Canton { get; set; } = default!;
}
