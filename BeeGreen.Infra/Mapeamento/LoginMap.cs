using BeGreen.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeGreen.Infra.Mapeamento
{
    public class LoginMap : IEntityTypeConfiguration<Login>
    {
        public void Configure(EntityTypeBuilder<Login> builder)
        {
            builder.ToTable("Login");

            //Chave primária
            builder.HasKey(x => x.Id);

            //Identity
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            //propriedades
            builder.Property(x => x.Email);
            builder.Property(x => x.TipoCadastro);

            //Indices
            builder.HasIndex(x => x.Id, "IX_Id_Login")
                .IsUnique();

            //Relacionamentos
            builder
                .HasOne(x => x.Usuario)
                .WithOne(x => x.Login)
                .HasForeignKey<Usuario>(x => x.CodigoLogin);

            builder
                .HasOne(x => x.Parceiro)
                .WithOne(x => x.Login)
                .HasForeignKey<Parceiro>(x => x.CodigoLogin);
        }
    }
}
