using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructura.Data.Configuration;

public class DepartamentoConfiguration : IEntityTypeConfiguration<Departamento>
{
    public void Configure(EntityTypeBuilder<Departamento> builder)
    {
        builder.ToTable("departamento");
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Id);

        builder.Property(p => p.Id).IsRequired().HasMaxLength(50);

        builder.HasOne(p => p.Paises)
        .WithMany(p => p.Departamentos)
        .HasForeignKey(e => e.IdpaisFk);
        // Aqui puedes configurar las propiedades de la entidad 
        // Utilizando el objeto 'builder'
    }
}