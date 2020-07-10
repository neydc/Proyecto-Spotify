
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SpotifyPro.Models;

namespace SpotifyPro.DataBase.TablaConfiguracion
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario");
            builder.HasKey(o => o.Id);
            
            
            //Likes
            builder.HasMany(o => o.likes).
                WithOne(o=>o.Usuario).
                HasForeignKey(o => o.IdUsuario);
            //amistad
            
            builder.ToTable("Usuario");
            builder.HasKey(o => o.Id);
            builder.HasMany(o => o.Amistad1).WithOne(o => o.UsuarioLocal).HasForeignKey(o => o.IdLocal);
            builder.HasMany(o => o.Amistad2).WithOne(o => o.UsuarioAmigo).HasForeignKey(o => o.IdAmigo);
            //ListaReproduccion
            builder.HasMany(o => o.ListaReproducciones).
                WithOne(o=>o.usuario).
                HasForeignKey(o => o.UsuarioId);
            //CompartirCanciones
            builder.HasMany(o => o.Amistad1C).WithOne(o => o.UsuarioLocalC).HasForeignKey(o => o.IdLocalC);
            builder.HasMany(o => o.Amistad2C).WithOne(o => o.UsuarioAmigoC).HasForeignKey(o => o.IdAmigoC);



        }
    }
}