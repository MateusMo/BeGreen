using BeGreen.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeGreen.Mappings
{
    public class OfertaMap : IEntityTypeConfiguration<Oferta>
    {
        public void Configure(EntityTypeBuilder<Oferta> builder)
        {
            builder.ToTable("Oferta");

            //Chave primária
            builder.HasKey(x => x.Id);

            //Identity
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            //propriedades
            builder.Property(x => x.Titulo);
            builder.Property(x => x.Descricao);
            builder.Property(x => x.DataInicio);
            builder.Property(x => x.DataFinal);
            builder.Property(x => x.Latitude);
            builder.Property(x => x.Longitude);

            //Indices
            builder.HasIndex(x => x.Id, "IX_Id_Oferta")
                .IsUnique();

            //Relacionamentos
            builder
                .HasOne(x => x.Parceiro)
                .WithMany(x => x.Ofertas);
        }
    }
}
