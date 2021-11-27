using BeGreen.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeGreen.Mappings
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario");

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
            builder.Property(x => x.Genero);
            builder.Property(x => x.DataNascimento);
            builder.Property(x => x.Cpf);
            builder.Property(x => x.Senha);

            //Indices
            builder.HasIndex(x => x.Id, "IX_Id_Usuario")
                .IsUnique();

            ////Relacionamentos
            //builder
            //    .HasOne(x => x.Login)
            //    .WithOne(x => x.Usuario);
        }
    }
}
