using BeGreen.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeGreen.Mappings
{
    public class ParceiroMap : IEntityTypeConfiguration<Parceiro>
    {
        public void Configure(EntityTypeBuilder<Parceiro> builder)
        {
            builder.ToTable("Parceiro");

            //Chave primária
            builder.HasKey(x => x.Id);

            //Identity
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            //propriedades
            builder.Property(x => x.Nome);
            builder.Property(x => x.Email);
            builder.Property(x => x.TipoCadastro);
            builder.Property(x => x.Ramo);
            builder.Property(x => x.Cnpj);
            builder.Property(x => x.Senha);
            builder.Property(x => x.Cep);
            builder.Property(x => x.Logradouro);
            builder.Property(x => x.Numero);
            builder.Property(x => x.Complemento);

            //Indices
            builder.HasIndex(x => x.Id, "IX_Id_Parceiro")
                .IsUnique();
        }
    }
}
