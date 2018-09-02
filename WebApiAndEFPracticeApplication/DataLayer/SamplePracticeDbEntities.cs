using System.Data.Entity;
using Domain;
using DataLayer.EntityConfiguration;

namespace DataLayer
{
    public class SamplePracticeDbEntities : DbContext
    {
        public virtual DbSet<MemberLoginDetails> MemberLoginDetails { get; set; }
        public virtual DbSet<MemberDetails> MemberDetails { get; set; }
        public virtual DbSet<MemberOrderDetails> MemberOrderDetails { get; set; }

        public SamplePracticeDbEntities(): base("name=SamplePracticeDbEntities")
        {
            Database.SetInitializer<SamplePracticeDbEntities>(new DropCreateDatabaseIfModelChanges<SamplePracticeDbEntities>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.ComplexType<MemberAddress>();
            modelBuilder.Entity<MemberLoginDetails>().HasKey(t => t.Id);            
            //modelBuilder.Entity<MemberLoginDetails>().HasOptional(t => t.MemberDetails).WithRequired(t => t.MemberLoginDetails);
            modelBuilder.Entity<MemberDetails>().HasKey(t => t.Id);
            modelBuilder.Entity<MemberDetails>().HasRequired(t => t.MemberLoginDetails).WithMany(t => t.MemberDetails);
            modelBuilder.Entity<MemberOrderDetails>().HasKey(t => t.Id);
            modelBuilder.Entity<MemberOrderDetails>().HasRequired(t => t.MemberLoginDetails).WithMany(t => t.memberOrderDetails);
            modelBuilder.Configurations.Add(new MemberLoginDetailsConfiguration());
            modelBuilder.Configurations.Add(new MemberDetailsConfiguration());
            modelBuilder.Configurations.Add(new MemberOrderDetailsConfiguration());
            
            base.OnModelCreating(modelBuilder);

        }
    }
}
