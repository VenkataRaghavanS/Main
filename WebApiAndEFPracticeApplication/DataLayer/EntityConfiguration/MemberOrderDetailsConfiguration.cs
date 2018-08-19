using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.EntityConfiguration
{
    public class MemberOrderDetailsConfiguration : EntityTypeConfiguration<MemberOrderDetails>
    {
        public MemberOrderDetailsConfiguration()
        {
            Property(t => t.Id).HasColumnName("OrderId").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(t => t.OrderText).HasMaxLength(100);
        }
    }
}
