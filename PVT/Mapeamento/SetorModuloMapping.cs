using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PVT.Models;

namespace PVT.Mapeamento
{

    public partial class ModuloMapping
    {
        public class SetorModuloMapping : IEntityTypeConfiguration<SetorModulo>
        {
            public void Configure(EntityTypeBuilder<SetorModulo> builder)
            {
                builder.HasKey(sm => sm.ID);
            }
        }
    }
}
