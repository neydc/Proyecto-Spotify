using SpotifyPro.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SpotifyPro.DataBase.TablaConfiguracion
{
    public class CancionConfiguration: IEntityTypeConfiguration<Cancion>
    {
        public void Configure(EntityTypeBuilder<Cancion> builder)
        {
            builder.ToTable("Cancion");
            builder.HasKey(o => o.Id);
            
            builder.HasMany(o => o.likes).
                WithOne(o=>o.Cancion).
             
                HasForeignKey(o => o.IdCancion);
            
            //detalleListaReproduccionCancion
            builder.HasMany(o => o.DetalleListaReproduccionCanciones).
                WithOne(o=>o.Cancion).
                HasForeignKey(o => o.IdCancion);

            builder.HasMany(o => o.CompartirCanciones).
                WithOne(o => o.cancion).HasForeignKey(o => o.IdCancion);

        }
    }
}