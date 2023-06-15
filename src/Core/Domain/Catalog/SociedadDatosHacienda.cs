namespace FSH.WebApi.Domain.Catalog;
public class SociedadDatosHacienda : AuditableEntity, IAggregateRoot
{
    public string? LlaveCriptografica { get; private set; }
    public int? Pin { get; private set; } = default!;
    public string? UsuarioHacienda { get; private set; }
    public string? ClaveUsuarioHacienda { get; private set; }
    public string? EmailEnvio { get; private set; }
    public string? ClaveEmailEnvio { get; private set; }
    public string? AsuntoEmail { get; private set; }
    public string? ServidorSmtp { get; private set; }
    public Guid SociedadId { get; private set; }
    public virtual Sociedad Sociedad { get; private set; } = default!;

    public SociedadDatosHacienda(string? llaveCriptografica, int? pin, string? usuarioHacienda, string? claveUsuarioHacienda, string? emailEnvio, string? claveEmailEnvio, string? asuntoEmail, string? servidorSmtp, Guid sociedadId)
    {
        LlaveCriptografica = llaveCriptografica;
        Pin = pin;
        UsuarioHacienda = usuarioHacienda;
        ClaveUsuarioHacienda = claveUsuarioHacienda;
        EmailEnvio = emailEnvio;
        ClaveEmailEnvio = claveEmailEnvio;
        AsuntoEmail = asuntoEmail;
        ServidorSmtp = servidorSmtp;
        SociedadId = sociedadId;
    }

    public SociedadDatosHacienda Update(string? llaveCriptografica, int? pin, string? usuarioHacienda, string? claveUsuarioHacienda, string? emailEnvio, string? claveEmailEnvio, string? asuntoEmail, string? servidorSmtp, Guid? sociedadId)
    {
        if (llaveCriptografica is not null && LlaveCriptografica?.Equals(llaveCriptografica) is not true) LlaveCriptografica = llaveCriptografica;
        if (pin is not null && Pin?.Equals(pin) is not true) Pin = pin;
        if (usuarioHacienda is not null && UsuarioHacienda?.Equals(usuarioHacienda) is not true) UsuarioHacienda = usuarioHacienda;
        if (claveUsuarioHacienda is not null && ClaveUsuarioHacienda?.Equals(claveUsuarioHacienda) is not true) ClaveUsuarioHacienda = claveUsuarioHacienda;
        if (emailEnvio is not null && EmailEnvio?.Equals(emailEnvio) is not true) EmailEnvio = emailEnvio;
        if (claveEmailEnvio is not null && ClaveEmailEnvio?.Equals(claveEmailEnvio) is not true) ClaveEmailEnvio = claveEmailEnvio;
        if (asuntoEmail is not null && AsuntoEmail?.Equals(asuntoEmail) is not true) AsuntoEmail = asuntoEmail;
        if (servidorSmtp is not null && ServidorSmtp?.Equals(servidorSmtp) is not true) ServidorSmtp = servidorSmtp;
        if (sociedadId.HasValue && sociedadId.Value != Guid.Empty && SociedadId.Equals(sociedadId.Value) is not true) SociedadId = sociedadId.Value;
        return this;
    }
}
