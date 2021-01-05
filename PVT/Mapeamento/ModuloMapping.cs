using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PVT.Models;

namespace PVT.Mapeamento
{
    public partial class ModuloMapping : IEntityTypeConfiguration<Modulo>
    {
        public void Configure(EntityTypeBuilder<Modulo> builder)
        {
            builder.HasKey(m => m.ID);
            builder.Property(m => m.NOME).IsRequired();
            builder.Property(m => m.DESCRICAO).IsRequired();
            builder.HasMany(m => m.SetorModulo).WithOne(sm => sm.Modulo).HasForeignKey(sm => sm.ID_MODULO);
            builder.HasMany(m => m.Cursos).WithOne(c => c.Modulo).HasForeignKey(c => c.ID_MODULO);

        }
    }
}

