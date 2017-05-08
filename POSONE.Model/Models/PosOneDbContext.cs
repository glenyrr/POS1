using Microsoft.EntityFrameworkCore;

namespace POSONE.Model.Models
{
    public partial class PosOneDbContext : DbContext
    {
        public virtual DbSet<Articulo> Articulo { get; set; }
        public virtual DbSet<CategoriaArticulo> CategoriaArticulo { get; set; }
        public virtual DbSet<CierreCaja> CierreCaja { get; set; }
        public virtual DbSet<ClienteFrecuente> ClienteFrecuente { get; set; }
        public virtual DbSet<Correlativos> Correlativos { get; set; }
        public virtual DbSet<FactorBono> FactorBono { get; set; }
        public virtual DbSet<FacturaDetalle> FacturaDetalle { get; set; }
        public virtual DbSet<FacturaDetalleCompra> FacturaDetalleCompra { get; set; }
        public virtual DbSet<FacturaEncabezadoBase> FacturaEncabezadoBase { get; set; }
        public virtual DbSet<FacturaEncabezadoCompraBase> FacturaEncabezadoCompraBase { get; set; }
        public virtual DbSet<FacturaVentaDetalle> FacturaVentaDetalle { get; set; }
        public virtual DbSet<Isv> Isv { get; set; }
        public virtual DbSet<TipoArticulo> TipoArticulo { get; set; }
        public virtual DbSet<TransaccionBono> TransaccionBono { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }

        // Unable to generate entity type for table 'dbo.CierreCajaDetalle'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CierreCajaSaldos'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
            optionsBuilder.UseSqlServer(@"Server=SXCAJA01\SQLEXPRESS;Database=posone;Trusted_Connection=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Articulo>(entity =>
            {
                entity.Property(e => e.ArticuloId).HasColumnType("varchar(50)");

                entity.Property(e => e.Cantidad).HasColumnType("decimal");

                entity.Property(e => e.CantidadMayoreo)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Categoria).HasColumnType("varchar(100)");

                entity.Property(e => e.Costo).HasColumnType("decimal");

                entity.Property(e => e.Descontinuado).HasDefaultValueSql("0");

                entity.Property(e => e.Descripcion).HasColumnType("varchar(50)");

                entity.Property(e => e.IsvTipo)
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Isvincluido)
                    .HasColumnName("ISVIncluido")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Precio).HasColumnType("decimal");

                entity.Property(e => e.Precio1).HasColumnType("decimal");

                entity.Property(e => e.TipoArticulo).HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<CategoriaArticulo>(entity =>
            {
                entity.Property(e => e.Categoria).HasColumnType("varchar(100)");
            });

            modelBuilder.Entity<CierreCaja>(entity =>
            {
                entity.Property(e => e.Balance)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Comentario).HasColumnType("varchar(500)");

                entity.Property(e => e.Debe)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaCierre).HasColumnType("datetime");

                entity.Property(e => e.Haber)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UsuarioId).HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<ClienteFrecuente>(entity =>
            {
                entity.Property(e => e.Cedula).HasColumnType("varchar(30)");

                entity.Property(e => e.Cliente)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Correo).HasColumnType("varchar(50)");

                entity.Property(e => e.Direccion).HasColumnType("varchar(500)");

                entity.Property(e => e.Telefono).HasColumnType("varchar(20)");
            });

            modelBuilder.Entity<Correlativos>(entity =>
            {
                entity.Property(e => e.Caja).HasColumnType("varchar(10)");

                entity.Property(e => e.Documento).HasColumnType("varchar(20)");

                entity.Property(e => e.FechaValido).HasColumnType("datetime");

                entity.Property(e => e.KeyId).HasColumnType("varchar(50)");

                entity.Property(e => e.Prefijo).HasColumnType("varchar(20)");
            });

            modelBuilder.Entity<FactorBono>(entity =>
            {
                entity.HasKey(e => e.BonoId)
                    .HasName("PK__FactorBo__D162A61BC84D3F90");

                entity.Property(e => e.Bono).HasColumnType("varchar(50)");

                entity.Property(e => e.FactorConversion).HasColumnType("decimal");

                entity.Property(e => e.MontoRetirable).HasColumnType("decimal");
            });

            modelBuilder.Entity<FacturaDetalle>(entity =>
            {
                entity.Property(e => e.FacturaDetalleId).ValueGeneratedNever();

                entity.Property(e => e.ArticuloId).HasColumnType("varchar(50)");

                entity.Property(e => e.Cantidad).HasColumnType("decimal");

                entity.Property(e => e.Costo).HasColumnType("decimal");

                entity.Property(e => e.Descripcion).HasColumnType("varchar(50)");

                entity.Property(e => e.Factura)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Isv)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsvPorcentaje)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsvTipo).HasColumnType("varchar(50)");

                entity.Property(e => e.Precio).HasColumnType("decimal");

                entity.Property(e => e.Total).HasColumnType("decimal");

                entity.Property(e => e.TotalProducto).HasColumnType("decimal");
            });

            modelBuilder.Entity<FacturaDetalleCompra>(entity =>
            {
                entity.HasKey(e => e.FacturaDetalleId)
                    .HasName("PK__FacturaD__A9674AFA332A3A9D");

                entity.Property(e => e.ArticuloId).HasColumnType("varchar(50)");

                entity.Property(e => e.Cantidad).HasColumnType("decimal");

                entity.Property(e => e.Costo).HasColumnType("decimal");

                entity.Property(e => e.Descripcion).HasColumnType("varchar(50)");

                entity.Property(e => e.Factura)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Isv)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsvPorcentaje)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsvTipo).HasColumnType("varchar(50)");

                entity.Property(e => e.Precio).HasColumnType("decimal");

                entity.Property(e => e.Total).HasColumnType("decimal");

                entity.Property(e => e.TotalProducto).HasColumnType("decimal");
            });

            modelBuilder.Entity<FacturaEncabezadoBase>(entity =>
            {
                entity.HasKey(e => e.Factura)
                    .HasName("PK__FacturaE__83BC389B46DF7E77");

                entity.Property(e => e.Factura).HasColumnType("varchar(50)");

                entity.Property(e => e.Caja).HasColumnType("varchar(10)");

                entity.Property(e => e.Cambio)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Cliente).HasColumnType("varchar(255)");

                entity.Property(e => e.DesCodigo).HasColumnType("varchar(50)");

                entity.Property(e => e.DescPorcentaje).HasColumnType("decimal");

                entity.Property(e => e.Descuento).HasColumnType("decimal");

                entity.Property(e => e.Efectivo)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EnCierre).HasDefaultValueSql("0");

                entity.Property(e => e.Estado).HasColumnType("varchar(30)");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.RtnCliente).HasColumnType("varchar(30)");

                entity.Property(e => e.TipoFactura)
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'CONTADO'");

                entity.Property(e => e.Usuario).HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<FacturaEncabezadoCompraBase>(entity =>
            {
                entity.HasKey(e => e.Factura)
                    .HasName("PK__FacturaE__83BC389B24B18FE3");

                entity.Property(e => e.Factura).HasColumnType("varchar(50)");

                entity.Property(e => e.Caja).HasColumnType("varchar(10)");

                entity.Property(e => e.Estado).HasColumnType("varchar(30)");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.RtnProveedor).HasColumnType("varchar(30)");

                entity.Property(e => e.TipoFactura)
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'CONTADO'");

                entity.Property(e => e.Usuario).HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<FacturaVentaDetalle>(entity =>
            {
                entity.HasKey(e => e.FacturaDetalleId)
                    .HasName("PK__FacturaV__A9674AFAE8440FB5");

                entity.Property(e => e.ArticuloId).HasColumnType("varchar(50)");

                entity.Property(e => e.Cantidad).HasColumnType("decimal");

                entity.Property(e => e.Costo).HasColumnType("decimal");

                entity.Property(e => e.Descripcion).HasColumnType("varchar(50)");

                entity.Property(e => e.Factura)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Isv)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsvPorcentaje)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsvTipo).HasColumnType("varchar(50)");

                entity.Property(e => e.Precio).HasColumnType("decimal");

                entity.Property(e => e.Total).HasColumnType("decimal");

                entity.Property(e => e.TotalProducto).HasColumnType("decimal");
            });

            modelBuilder.Entity<Isv>(entity =>
            {
                entity.ToTable("ISV");

                entity.Property(e => e.IsvPorcentaje).HasColumnType("decimal");

                entity.Property(e => e.IsvTipo).HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<TipoArticulo>(entity =>
            {
                entity.Property(e => e.TipoArticulo1)
                    .HasColumnName("TipoArticulo")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<TransaccionBono>(entity =>
            {
                entity.Property(e => e.TransaccionBonoId).ValueGeneratedNever();

                entity.Property(e => e.Bono).HasColumnType("decimal");

                entity.Property(e => e.Factura).HasColumnType("varchar(50)");

                entity.Property(e => e.TipoTransaccion).HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.Property(e => e.UsuarioId).HasColumnType("varchar(50)");

                entity.Property(e => e.Activo).HasDefaultValueSql("1");

                entity.Property(e => e.Clave).HasColumnType("varchar(50)");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Nombre).HasColumnType("varchar(120)");

                entity.Property(e => e.Perfil)
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'CAJA'");
            });
        }
    }
}