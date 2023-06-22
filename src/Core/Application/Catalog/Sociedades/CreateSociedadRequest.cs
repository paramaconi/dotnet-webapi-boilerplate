using FSH.WebApi.Application.Catalog.Brands;
using FSH.WebApi.Shared.Identificacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace FSH.WebApi.Application.Catalog.Sociedades;
public class CreateSociedadRequest : IRequest<Guid>
{
    public string RazonSocial { get; set; } = default!;
    public string? NombreComercial { get; set; }
    public string TipoIdentificacion { get; set; } = default!;
    public string Identificacion { get; set; } = default!;
    public Guid ProvinciaId { get; set; }
    public Guid CantonId { get; set; }
    public Guid DistritoId { get; set; }
    public Guid? BarrioId { get; set; }
    public string OtrasSenas { get; set; } = default!;
    public string? CodigoPaisPrincipal { get; set; }
    public string? NumTelefonoPrincipal { get; set; }
    public string? CodigoPaisSecundario { get; set; }
    public string? NumTelefonoSecundario { get; set; }
    public string? CodigoPaisFax { get; set; }
    public string? Fax { get; set; }
    public string? CorreoElectronico { get; set; }
    public string? LogoPath { get; set; }
}

public class CreateSociedadRequestValidator : CustomValidator<CreateSociedadRequest>
{
    public CreateSociedadRequestValidator(IReadRepository<Sociedad> repository, IStringLocalizer<CreateSociedadRequestValidator> T)
    {
        RuleFor(p => p.RazonSocial)
            .NotEmpty().WithMessage("Debe ingresar una razón social")
            .MaximumLength(100).WithMessage("La razón social no debe de exceder de los 100 caracteres")
            .MustAsync(async (razonSocial, ct) => await repository.FirstOrDefaultAsync(new SociedadByRazonSocialSpec(razonSocial), ct) is null)
                .WithMessage((_, razonSocial) => T["La razón social {0} ya existe.", razonSocial]);

        RuleFor(p => p.Identificacion)
            .NotEmpty().WithMessage("Debe ingresar un número de identificación")
            .Length(9, 12).WithMessage("La identificación debe tener una longitud entre 9 y 12 caracteres")
            .MustAsync(async (identificacion, ct) => await repository.FirstOrDefaultAsync(new SociedadByIdentificacionSpec(identificacion), ct) is null);

        RuleFor(p => p.TipoIdentificacion)
            .NotEmpty().WithMessage("Debe ingresar un tipo de identificación")
            .MaximumLength(1).WithMessage("El tipo de identificación debe contar con al menos un caracter");

            // .Must(TiposIdentificacion.Hacienda);
    }
}

public class CreateSociedadRequestHandler : IRequestHandler<CreateSociedadRequest, Guid>
{
    // Add Domain Events automatically by using IRepositoryWithEvents
    private readonly IRepositoryWithEvents<Sociedad> _repository;

    public CreateSociedadRequestHandler(IRepositoryWithEvents<Sociedad> repository) => _repository = repository;

    public async Task<Guid> Handle(CreateSociedadRequest request, CancellationToken cancellationToken)
    {
        var sociedad = new Sociedad(request.RazonSocial, request.NombreComercial, request.TipoIdentificacion, request.Identificacion, request.ProvinciaId, request.CantonId, request.DistritoId, request.BarrioId, request.OtrasSenas, request.CodigoPaisPrincipal, request.NumTelefonoPrincipal, request.CodigoPaisSecundario, request.NumTelefonoSecundario, request.CodigoPaisFax, request.Fax, request.CorreoElectronico, request.LogoPath);

        await _repository.AddAsync(sociedad, cancellationToken);

        return sociedad.Id;
    }
}
