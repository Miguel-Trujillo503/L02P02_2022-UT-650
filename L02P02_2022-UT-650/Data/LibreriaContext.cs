using Microsoft.EntityFrameworkCore;
using L02P02_2022_UT_650.Models;

namespace L02P02_2022_UT_650.Data
{
    public class LibreriaContext : DbContext
    {
        public LibreriaContext(DbContextOptions<LibreriaContext> options) : base(options)
        {
        }

        // DbSets (tablas en la BD)
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Libro> Libros { get; set; }
        public DbSet<PedidoEncabezado> PedidoEncabezados { get; set; }
        public DbSet<PedidoDetalle> PedidoDetalles { get; set; }
        public DbSet<ComentariosLibros> ComentariosLibros { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuración de claves foráneas
            modelBuilder.Entity<Libro>()
                .HasOne(l => l.Autor)
                .WithMany()
                .HasForeignKey(l => l.IdAutor);

            modelBuilder.Entity<Libro>()
                .HasOne(l => l.Categoria)
                .WithMany()
                .HasForeignKey(l => l.IdCategoria);

            modelBuilder.Entity<PedidoEncabezado>()
                .HasOne(p => p.Cliente)
                .WithMany()
                .HasForeignKey(p => p.IdCliente);

            modelBuilder.Entity<PedidoDetalle>()
                .HasOne(pd => pd.PedidoEncabezado)
                .WithMany()
                .HasForeignKey(pd => pd.IdPedido);

            modelBuilder.Entity<PedidoDetalle>()
                .HasOne(pd => pd.Libro)
                .WithMany()
                .HasForeignKey(pd => pd.IdLibro);

            modelBuilder.Entity<ComentariosLibros>()
                .HasOne(cl => cl.Libro)
                .WithMany()
                .HasForeignKey(cl => cl.IdLibro);
        }
    }
}
