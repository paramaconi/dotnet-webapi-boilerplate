using Finbuckle.MultiTenant.EntityFrameworkCore;
using FSH.WebApi.Domain.Catalog;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FSH.WebApi.Infrastructure.Persistence.Configuration;

public class BrandConfig : IEntityTypeConfiguration<Brand>
{
    public void Configure(EntityTypeBuilder<Brand> builder)
    {
        builder.IsMultiTenant();

        builder
            .Property(b => b.Name)
                .HasMaxLength(256);
    }
}

public class ProductConfig : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.IsMultiTenant();

        builder
            .Property(b => b.Name)
                .HasMaxLength(1024);

        builder
            .Property(p => p.ImagePath)
                .HasMaxLength(2048);
    }
}

public class ProvinciaConfig : IEntityTypeConfiguration<Provincia>
{
    public void Configure(EntityTypeBuilder<Provincia> builder)
    {
        builder
            .Property(p => p.Name)
                .HasMaxLength(50);
        builder
            .Property(p => p.LocationID)
                .HasMaxLength(1);
        builder
            .HasKey(p => p.Id)
                .HasName("Pk_Provincia");
    }
}

public class CantonConfig : IEntityTypeConfiguration<Canton>
{
    public void Configure(EntityTypeBuilder<Canton> builder)
    {
        builder.
            Property(p => p.Name)
                .HasMaxLength(100);
        builder.
            Property(p => p.LocationID).
                HasMaxLength(2);
        builder
            .HasKey(p => p.Id)
                .HasName("Pk_Canton");
    }
}

public class DistritoConfig : IEntityTypeConfiguration<Distrito>
{
    public void Configure(EntityTypeBuilder<Distrito> builder)
    {
        builder.
            Property(p => p.Name)
                .HasMaxLength(100);
        builder.
            Property(p => p.LocationID).
                HasMaxLength(2);
        builder
            .HasKey(p => p.Id)
                .HasName("Pk_Distrito");
    }
}

public class BarrioConfig : IEntityTypeConfiguration<Barrio>
{
    public void Configure(EntityTypeBuilder<Barrio> builder)
    {
        builder.
           Property(p => p.Name)
               .HasMaxLength(100);
        builder.
            Property(p => p.LocationID).
                HasMaxLength(2);
        builder
            .HasKey(p => p.Id)
                .HasName("Pk_Barrio");
    }
}

public class CabysConfig : IEntityTypeConfiguration<Cabys>
{
    public void Configure(EntityTypeBuilder<Cabys> builder)
    {
        builder
            .Property(p => p.CabysID)
                .HasMaxLength(13);
        builder
            .Property(p => p.Descripcion)
                .HasMaxLength(1024);
        builder.
            HasIndex(p => p.CabysID)
                .HasDatabaseName("IDX_Cabys_CabysId");
        builder.
            HasIndex(p => p.Descripcion)
                .HasDatabaseName("IDX_Cabys_Descripcion");
        builder
            .HasKey(k => k.Id)
                .HasName("Pk_Cabys");
    }
}

public class SociedadConfig : IEntityTypeConfiguration<Sociedad>
{
    public void Configure(EntityTypeBuilder<Sociedad> builder)
    {
        builder.IsMultiTenant();

        builder
            .Property(b => b.RazonSocial)
                .HasMaxLength(100);
        builder
            .Property(b => b.NombreComercial)
                .HasMaxLength(80);
        builder
            .Property(b => b.TipoIdentificacion)
                .HasMaxLength(1);
        builder
            .Property(b => b.Identificacion)
                .HasMaxLength(12);
        builder
            .Property(b => b.Provincia)
                .HasMaxLength(1);
        builder
            .Property(b => b.Canton)
                .HasMaxLength(2);
        builder
            .Property(b => b.Distrito)
                .HasMaxLength(2);
        builder
            .Property(b => b.Barrio)
                .HasMaxLength(2);
        builder
            .Property(b => b.OtrasSenas)
                .HasMaxLength(250);
        builder
            .Property(b => b.CodigoPaisPrincipal)
                .HasMaxLength(3);
        builder
            .Property(b => b.NumTelefonoPrincipal)
                .HasMaxLength(20);
        builder
            .Property(b => b.CodigoPaisSecundario)
                .HasMaxLength(3);
        builder
            .Property(b => b.NumTelefonoSecundario)
                .HasMaxLength(20);
        builder
            .Property(b => b.CodigoPaisFax)
                .HasMaxLength(3);
        builder
            .Property(b => b.Fax)
                .HasMaxLength(20);
        builder
            .Property(b => b.CorreoElectronico)
                .HasMaxLength(160);
    }
}

public class ActividadEconomicaPorSociedadConfig : IEntityTypeConfiguration<ActividadEconomicaPorSociedad>
{
    public void Configure(EntityTypeBuilder<ActividadEconomicaPorSociedad> builder)
    {
        builder
            .IsMultiTenant();
        builder
            .Property(b => b.Codigo)
                .HasMaxLength(6);
        builder
            .Property(b => b.Descripcion)
                .HasMaxLength(250);
    }
}

public class SociedadDatosHaciendaConfig : IEntityTypeConfiguration<SociedadDatosHacienda>
{
    public void Configure(EntityTypeBuilder<SociedadDatosHacienda> builder)
    {
        builder
            .IsMultiTenant();
        builder
            .Property(b => b.UsuarioHacienda)
                .HasMaxLength(150);
        builder
            .Property(b => b.ClaveUsuarioHacienda)
                .HasMaxLength(20);
        builder
            .Property(b => b.EmailEnvio)
                .HasMaxLength(160);
        builder
            .Property(b => b.ClaveEmailEnvio)
                .HasMaxLength(20);
        builder
            .Property(b => b.AsuntoEmail)
                .HasMaxLength(150);
        builder
            .Property(b => b.ServidorSmtp)
                .HasMaxLength(50);
    }
}