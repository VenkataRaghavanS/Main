using Domain;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.EntityConfiguration
{
    public class MemberLoginDetailsConfiguration : EntityTypeConfiguration<MemberLoginDetails>
    {
        public MemberLoginDetailsConfiguration()
        {
            Property(t => t.Id).HasColumnName("MemberId").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(t => t.UserName).HasMaxLength(50);
            Property(t => t.Password).HasMaxLength(100);
        }
    }
}
