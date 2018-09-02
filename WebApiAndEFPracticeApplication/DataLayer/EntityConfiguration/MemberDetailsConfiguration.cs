using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using Domain;

namespace DataLayer.EntityConfiguration
{
    public class MemberDetailsConfiguration : EntityTypeConfiguration<MemberDetails>
    {
        public MemberDetailsConfiguration()
        {
            Property(x => x.Id).HasColumnName("MemberDetailsId").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.FirstName).HasMaxLength(50);
            Property(x => x.LastName).HasMaxLength(50);
            Property(x => x.Gender).HasColumnType("char").HasMaxLength(1);
            Property(x => x.DateOfBirth).HasColumnType("Date");
            Property(x => x.Email).HasMaxLength(100);
            Property(x => x.MobileNumber).IsRequired();
            Property(x => x.MemberAddress.AddressLine1).IsOptional();
            Property(x => x.MemberAddress.AddressLine2).IsOptional();
            Property(x => x.MemberAddress.PinCode).IsOptional();
            //Property(x => x.MemberLoginDetailsId).IsRequired();
            //Property(x => x.MemberAddress.State).IsOptional();
            //Property(x => x.MemberAddress.Country).IsOptional();
        }
    }
}
