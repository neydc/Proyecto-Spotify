using SpotifyPro.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SpotifyPro.DataBase.TablaConfiguracion
{
    public class ListaReproduccionConfiguration: IEntityTypeConfiguration<ListaReproduccion>
    {
        public void Configure(EntityTypeBuilder<ListaReproduccion> builder)
        {
            builder.ToTable("ListaReproduccion");
            builder.HasKey(o => o.Id);
            builder.HasOne(o => o.usuario).WithMany(o => o.ListaReproducciones).HasForeignKey(o => o.UsuarioId);
           
            //detalleListaReproduccionCancion
            builder.HasMany(o => o.DetalleListaReproduccionCanciones).
                WithOne(o=>o.ListaReproduccion).
                HasForeignKey(o => o.IdListaReproduccion);
        }
    }
}