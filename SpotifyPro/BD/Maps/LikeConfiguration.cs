using SpotifyPro.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SpotifyPro.DataBase.TablaConfiguracion
{
    public class LikeConfiguration: IEntityTypeConfiguration<Like>
    {
        public void Configure(EntityTypeBuilder<Like> builder)
        {
            builder.ToTable("Like");
            builder.HasKey(o => o.Id);
            builder.HasOne(o => o.Usuario).WithMany(o => o.likes).HasForeignKey(o => o.IdUsuario);
            builder.HasOne(o => o.Cancion).WithMany(o => o.likes).HasForeignKey(o => o.IdCancion);

           
        }
    }
}