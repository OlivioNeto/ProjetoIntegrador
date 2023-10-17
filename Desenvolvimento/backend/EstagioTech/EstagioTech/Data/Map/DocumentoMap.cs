﻿using EstagioTech.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EstagioTech.Data.Map
{
    public class DocumentoMap : IEntityTypeConfiguration<DocumentoModel>
    {
        public void Configure(EntityTypeBuilder<DocumentoModel> builder)
        {
            builder.HasKey(x => x.idDocumento);
            builder.Property(x => x.descricaoDocumento).IsRequired().HasMaxLength(200);
            builder.Property(x => x.documento).IsRequired().HasMaxLength(200);
            builder.Property(x => x.situacaoDocumento).IsRequired().HasMaxLength(200);
        }
    }
}
