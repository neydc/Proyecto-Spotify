using SpotifyPro.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SpotifyPro.DataBase.TablaConfiguracion
{
    public class AmistadConfiguration: IEntityTypeConfiguration<Amistad>
    {
        public void Configure(EntityTypeBuilder<Amistad> builder)
        {
            builder.ToTable("Amistad");
            builder.HasKey(o => o.Id);
        }
    }
}