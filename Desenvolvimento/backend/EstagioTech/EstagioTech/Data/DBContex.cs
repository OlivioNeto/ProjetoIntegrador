using EstagioTech.Data.Map;
using EstagioTech.Models;
using Microsoft.EntityFrameworkCore;

namespace EstagioTech.Data
{
    public class DBContex : DbContext
    {
        public DBContex(DbContextOptions<DBContex> options)
            : base(options)
        {

        }
        public DbSet<TipoEstagioModel> TipoEstagio { get; set; }
        public DbSet<CursoModel> Curso { get; set; }

        public DbSet<TipoDocumentoModel> TipoDocumento { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TipoEstagioMap());
            modelBuilder.ApplyConfiguration(new CursoMap());
            modelBuilder.ApplyConfiguration(new TipoDocumentoMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
