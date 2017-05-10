using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace POSONE.Model.Entities
{
    public partial class POS1DbContext : DbContext
    {
        public virtual DbSet<Articulo> Articulo { get; set; }
        public virtual DbSet<Categoria> Categoria { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<FacturaVenta> FacturaVenta { get; set; }
        public virtual DbSet<Isv> Isv { get; set; }
        public virtual DbSet<Marca> Marca { get; set; }
        public virtual DbSet<Tipo> Tipo { get; set; }
        public virtual DbSet<UnidadMedida> UnidadMedida { get; set; }

        // Unable to generate entity type for table 'dbo.EscalaPrecioVenta'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
            optionsBuilder.UseSqlServer(@"Server=(LocalDB)\MSSQLLocalDB;Database=POS1;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Articulo>(entity =>
            {
                entity.Property(e => e.Id).HasColumnType("varchar(50)");

                entity.Property(e => e.Activo).HasDefaultValueSql("1");

                entity.Property(e => e.CostoPromedio)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.DescripcionLarga)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.IncluyeImpuesto).HasDefaultValueSql("0");

                entity.Property(e => e.PrecioVenta)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.Umid).HasColumnName("UMId");

                entity.HasOne(d => d.Categoria)
                    .WithMany(p => p.Articulo)
                    .HasForeignKey(d => d.CategoriaId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Articulo_CategoriaArticulo");

                entity.HasOne(d => d.Isv)
                    .WithMany(p => p.Articulo)
                    .HasForeignKey(d => d.IsvId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Articulo_ISV");

                entity.HasOne(d => d.Marca)
                    .WithMany(p => p.Articulo)
                    .HasForeignKey(d => d.MarcaId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Articulo_Marca");

                entity.HasOne(d => d.Tipo)
                    .WithMany(p => p.Articulo)
                    .HasForeignKey(d => d.TipoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Articulo_TipoArticulo");

                entity.HasOne(d => d.Um)
                    .WithMany(p => p.Articulo)
                    .HasForeignKey(d => d.Umid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Articulo_UnidadMedida");
            });

            modelBuilder.Entity<Categoria>(entity =>
            {
                entity.Property(e => e.Nombre).HasColumnType("varchar(100)");
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.Property(e => e.Cliente1)
                    .HasColumnName("Cliente")
                    .HasMaxLength(100);

                entity.Property(e => e.RtnCliente).HasMaxLength(50);
            });

            modelBuilder.Entity<FacturaVenta>(entity =>
            {
                entity.HasKey(e => e.Factura)
                    .HasName("PK_FacturaVenta");

                entity.Property(e => e.Factura).HasColumnType("varchar(80)");

                entity.Property(e => e.Cambio).HasColumnType("decimal");

                entity.Property(e => e.Cliente).HasMaxLength(100);

                entity.Property(e => e.ClienteFrecuenteId).HasMaxLength(50);

                entity.Property(e => e.EnCierre).HasDefaultValueSql("0");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasDefaultValueSql("N'ABIERTA'");

                entity.Property(e => e.FacturaTipo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("N'CONTADO'");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Recibido).HasColumnType("decimal");

                entity.Property(e => e.RtnCliente).HasMaxLength(50);

                entity.Property(e => e.UsuarioId)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Isv>(entity =>
            {
                entity.ToTable("ISV");

                entity.Property(e => e.IsvPorcentaje).HasColumnType("decimal");

                entity.Property(e => e.Nombre).HasMaxLength(20);
            });

            modelBuilder.Entity<Marca>(entity =>
            {
                entity.Property(e => e.Nombre).HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<Tipo>(entity =>
            {
                entity.Property(e => e.Nombre).HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<UnidadMedida>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasColumnType("varchar(5)");

                entity.Property(e => e.Nombre).HasColumnType("varchar(50)");
            });
        }
    }
}