using System.Data.Entity.ModelConfiguration;
using Nas.Core.Domain.Customers;

namespace Nas.Data.Mapping.Customers
{
    public partial class ExternalAuthenticationRecordMap : EntityTypeConfiguration<ExternalAuthenticationRecord>
    {
        public ExternalAuthenticationRecordMap()
        {
            this.ToTable("ExternalAuthenticationRecord");

            this.HasKey(ear => ear.Id);

            this.HasRequired(ear => ear.Customer)
                .WithMany(c => c.ExternalAuthenticationRecords)
                .HasForeignKey(ear => ear.CustomerId);

        }
    }
}