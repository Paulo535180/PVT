using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PVT.Models;

namespace PVT.Mapeamento
{
    public partial class TipoAulaMapping : IEntityTypeConfiguration<TipoAula>
    {
        public void Configure(EntityTypeBuilder<TipoAula> builder)
        {
            builder.HasKey(s => s.ID);
            builder.HasMany(tp => tp.Aulas).WithOne(a => a.TipoAula).HasForeignKey(a => a.ID_TIPO_AULA);
        }
    }
}

