using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSH.WebApi.Shared.Identificacion;
public static class TiposIdentificacion
{
    private static readonly TipoIdentificacion[] _all = new TipoIdentificacion[]
    {
        new TipoIdentificacion("01", "Cédula Física", true),
        new TipoIdentificacion("02", "Cédula Jurídica", true),
        new TipoIdentificacion("03", "DIMEX", true),
        new TipoIdentificacion("04", "NITE", true),
        new TipoIdentificacion("1", "Persona física nacional"),
        new TipoIdentificacion("2", "Persona jurídica nacional"),
        new TipoIdentificacion("3", "Extranjero residente"),
        new TipoIdentificacion("4", "Entidad Financiera Extranjera"),
        new TipoIdentificacion("5", "Otra persona extranjera (pasaporte y DIDI)"),
        new TipoIdentificacion("6", "Empresa extranjera no financiera"),
        new TipoIdentificacion("13", "Fideicomisos")
    };

    public static IReadOnlyList<TipoIdentificacion> All { get; } = new ReadOnlyCollection<TipoIdentificacion>(_all);
    public static IReadOnlyList<TipoIdentificacion> Hacienda { get; } = new ReadOnlyCollection<TipoIdentificacion>(_all.Where(x => x.IsHacienda).ToList());
    public static IReadOnlyList<TipoIdentificacion> Sugef { get; } = new ReadOnlyCollection<TipoIdentificacion>(_all.Where(x => !x.IsHacienda).ToList());
}

public record TipoIdentificacion(string id, string descripcion, bool IsHacienda = false);
