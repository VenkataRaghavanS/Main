using System.Data.Entity;
using Domain;
using DataLayer.EntityConfiguration;

namespace DataLayer
{
    public class SamplePracticeDbEntities : DbContext
    {
        public virtual DbSet<MemberDetails> MemberDetails { get; set; }

        public SamplePracticeDbEntities(): base("SamplePracticeDbEntities")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MemberLoginDetails>().HasKey(t => t.Id);
            modelBuilder.Entity<MemberDetails>().HasRequired(t => t.MemberLoginDetails).WithOptional(t => t.MemberDetails);
            modelBuilder.Entity<MemberOrderDetails>().HasKey(t => t.Id);
            modelBuilder.Entity<MemberOrderDetails>().HasRequired(t => t.MemberLoginDetails).WithMany(t => t.memberOrderDetails);
            modelBuilder.Configurations.Add(new MemberLoginDetailsConfiguration());
            modelBuilder.Configurations.Add(new MemberDetailsConfiguration());
            modelBuilder.Configurations.Add(new MemberOrderDetailsConfiguration());
            modelBuilder.ComplexType<Address>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
