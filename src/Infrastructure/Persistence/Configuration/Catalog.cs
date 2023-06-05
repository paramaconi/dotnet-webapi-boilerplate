﻿using Finbuckle.MultiTenant.EntityFrameworkCore;
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