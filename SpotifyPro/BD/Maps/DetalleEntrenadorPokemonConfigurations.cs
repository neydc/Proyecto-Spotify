using SpotifyPro.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SpotifyPro.DataBase.TablaConfiguracion
{
    public class DetalleEntrenadorPokemonConfigurations : IEntityTypeConfiguration<DetalleEntrenadorPokemon>
    {
        public void Configure(EntityTypeBuilder<DetalleEntrenadorPokemon> builder)
        {
            builder.ToTable("Entrenador");
            builder.HasKey(o => o.Id);
            
           
        }
    }
}