using API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.Data.Map
{
    public class WalletMap : IEntityTypeConfiguration<WalletModel>
    {
        public void Configure(EntityTypeBuilder<WalletModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.UserId).IsRequired();
            builder.Property(x => x.ValorAtual).HasDefaultValue(0);
            builder.Property(x => x.Banco).HasMaxLength(255);
            builder.Property(x => x.UltimaAtualizacao).HasDefaultValueSql("getdate()");
        }
    }
}