using EstagioTech.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EstagioTech.Data.Map
{
    public class TipoDocumentoMap : IEntityTypeConfiguration<TipoDocumentoModel>
    {
        public void Configure(EntityTypeBuilder<TipoDocumentoModel> builder)
        {
            builder.HasKey(x => x.idTipoDocumento);
            builder.Property(x => x.descricaoTipoDocumento).IsRequired().HasMaxLength(200);
        }
    }
}
