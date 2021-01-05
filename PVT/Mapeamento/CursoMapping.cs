using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PVT.Models;

namespace PVT.Mapeamento
{
    public partial class CursoMapping : IEntityTypeConfiguration<Curso>
    {
        public void Configure(EntityTypeBuilder<Curso> builder)
        {
            builder.HasKey(c => c.ID);

            builder.Property(c => c.NOME).IsRequired();

            builder.Property(c => c.DESCRICAO).IsRequired();

            builder.HasMany(c => c.Disciplinas).WithOne(d => d.Curso).HasForeignKey(d => d.ID_CURSO);
        }
    }
}

