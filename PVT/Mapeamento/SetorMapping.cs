using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PVT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PVT.Mapeamento
{
    public class SetorMapping : IEntityTypeConfiguration<Setor>
    {
        public void Configure(EntityTypeBuilder<Setor> builder)
        {
            builder.HasKey(s => s.ID);

            builder.Property(s => s.NOME).IsRequired();

            builder.Property(s => s.DESCRICAO).IsRequired();

            builder.HasMany(s => s.SetorModulo).WithOne(sm => sm.Setor).HasForeignKey(sm => sm.ID_SETOR);

            builder.HasMany(s => s.UsuarioGestores).WithOne(u => u.Setor).HasForeignKey(u => u.ID_SETOR);


        }
    }
}

