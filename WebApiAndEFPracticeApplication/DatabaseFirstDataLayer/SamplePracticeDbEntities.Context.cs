﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatabaseFirstDataLayer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SamplePracticeDbEntities : DbContext
    {
        public SamplePracticeDbEntities()
            : base("name=SamplePracticeDbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<MemberDetails> MemberDetails { get; set; }
        public virtual DbSet<MemberLoginDetails> MemberLoginDetails { get; set; }
        public virtual DbSet<MemberOrderDetails> MemberOrderDetails { get; set; }
    }
}