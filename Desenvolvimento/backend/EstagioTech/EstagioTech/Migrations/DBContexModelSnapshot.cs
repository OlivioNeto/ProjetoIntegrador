using EstagioTech.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace EstagioTech.Migrations
{
    [DbContext(typeof(DBContex))]
    partial class DBContexModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("EstagioTech.Models.CursoModel", b =>
                {
                    b.Property<int>("idCurso")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("idCurso"));

                    b.Property<string>("nomeCurso")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.HasKey("idCurso");

                    b.ToTable("Curso");
                });

            modelBuilder.Entity("EstagioTech.Models.DocumentoModel", b =>
                {
                    b.Property<int>("idDocumento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("idDocumento"));

                    b.Property<string>("descricaoDocumento")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<string>("documento")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<string>("situacaoDocumento")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.HasKey("idDocumento");

                    b.ToTable("Documento");
                });

            modelBuilder.Entity("EstagioTech.Models.TipoDocumentoModel", b =>
                {
                    b.Property<int>("idTipoDocumento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("idTipoDocumento"));

                    b.Property<string>("descricaoTipoDocumento")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.HasKey("idTipoDocumento");

                    b.ToTable("TipoDocumento");
                });
            modelBuilder.Entity("EstagioTech.Models.TipoEstagioModel", b =>
                {
                    b.Property<int>("idTipoEstagio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("idTipoEstagio"));

                    b.Property<string>("descricaoTipoEstagio")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.HasKey("idTipoEstagio");

                    b.ToTable("TipoEstagio");
                });
#pragma warning restore 612, 618
        }
    }
}
