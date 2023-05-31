using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSH.WebApi.Domain.Catalog;
public class Cabys
{
    public Guid Id { get; set; }
    public string CabysID { get; set; } = default!;
    public string? Descripcion { get; set; }
    public decimal Impuesto { get; set; }
    public string? NotaExplicativa1 { get; set; }
    public string? NotaExplicativa2 { get; set; }
}
