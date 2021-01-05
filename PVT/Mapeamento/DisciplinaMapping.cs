using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PVT.Models;

namespace PVT.Mapeamento
{
    public partial class DisciplinaMapping : IEntityTypeConfiguration<Disciplina>
    {
        public void Configure(EntityTypeBuilder<Disciplina> builder)
        {
            builder.HasKey(d => d.ID);

            builder.Property(d => d.NOME).IsRequired();

            builder.Property(d => d.DESCRICAO).IsRequired();

            builder.HasMany(d => d.Aulas).WithOne(a => a.Disciplina).HasForeignKey(a => a.ID_DISCIPLINA);
        }
    }
}

