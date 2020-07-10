using SpotifyPro.DataBase.TablaConfiguracion;
using SpotifyPro.Models;
using Microsoft.EntityFrameworkCore;


namespace SpotifyPro.BD
{
    public class SpotifyContext: DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Cancion> Canciones { get; set; }
      
        public DbSet<Like> Likes { get; set; }
        public DbSet<Amistad> Amistades { get; set; }
        public DbSet<ListaReproduccion> ListaReproducciones { get; set; }
        public DbSet<DetalleListaReproduccionCancion> DetalleListaReproduccionCanciones { get; set; }

        public DbSet<Album> Albumes{ get; set; }

        public DbSet<CompartirCancion> CompartirCanciones { get; set; }
      
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=MIPC\\SQLEXPRESS; DataBase=Spotify;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new CancionConfiguration());
            modelBuilder.ApplyConfiguration(new LikeConfiguration());
            modelBuilder.ApplyConfiguration(new AmistadConfiguration());
            modelBuilder.ApplyConfiguration(new ListaReproduccionConfiguration());
            modelBuilder.ApplyConfiguration(new DetalleListaReproduccionCancionConfiguration());
            modelBuilder.ApplyConfiguration(new AlbumConfiguration());
            modelBuilder.ApplyConfiguration(new CompartirCancionConfiguration());
        }
    }
}
