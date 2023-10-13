using EstagioTech.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EstagioTech.Data.Map
{
    public class TipoEstagioMap : IEntityTypeConfiguration<TipoEstagioModel>
    {
        public void Configure(EntityTypeBuilder<TipoEstagioModel> builder)
        {
            builder.HasKey(x => x.idTipoEstagio);
            builder.Property(x => x.descricaoTipoEstagio).IsRequired().HasMaxLength(200);
        }
    }
}
