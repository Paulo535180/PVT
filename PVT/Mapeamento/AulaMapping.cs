using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PVT.Models;

namespace PVT.Mapeamento
{
    public partial class AulaMapping : IEntityTypeConfiguration<Aula>
    {
        public void Configure(EntityTypeBuilder<Aula> builder)
        {
            builder.HasKey(a => a.ID);

            builder.Property(a => a.NOME).IsRequired();

            builder.Property(a => a.DESCRICAO).IsRequired();

            builder.Property(a => a.ORDEM_AULA).IsRequired();

        }
    }
}

