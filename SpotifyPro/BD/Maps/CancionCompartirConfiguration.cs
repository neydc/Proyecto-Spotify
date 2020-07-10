using SpotifyPro.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SpotifyPro.DataBase.TablaConfiguracion
{
    public class CompartirCancionConfiguration : IEntityTypeConfiguration<CompartirCancion>
    {
        public void Configure(EntityTypeBuilder<CompartirCancion> builder)
        {
            builder.ToTable("CompartirCancion");
            builder.HasKey(o => o.Id);


        }
    }
}

