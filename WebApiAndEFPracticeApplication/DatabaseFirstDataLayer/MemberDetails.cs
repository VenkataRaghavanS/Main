//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class MemberDetails
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MemberDetails()
        {
            this.ComplexProperty = new MemberAddress();
        }
    
        public int MemberId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Gender { get; set; }
        public System.DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public Nullable<int> MobileNumber { get; set; }
    
        public MemberAddress ComplexProperty { get; set; }
    
        public virtual MemberLoginDetails MemberLoginDetails { get; set; }
    }
}