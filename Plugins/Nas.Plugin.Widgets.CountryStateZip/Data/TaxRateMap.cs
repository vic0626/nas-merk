using System.Data.Entity.ModelConfiguration;
using Nas.Plugin.Tax.CountryStateZip.Domain;

namespace Nas.Plugin.Tax.CountryStateZip.Data
{
    public partial class TaxRateMap : EntityTypeConfiguration<TaxRate>
    {
        public TaxRateMap()
        {
            this.ToTable("TaxRate");
            this.HasKey(tr => tr.Id);
            this.Property(tr => tr.Percentage).HasPrecision(18, 4);
        }
    }
}