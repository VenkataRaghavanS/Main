using System;
using System.Collections;
using System.Collections.Generic;

namespace Domain
{
    public class MemberDetails
    {        
        public int MemberId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public int MobileNumber { get; set; }
        public Address MemberAddress { get; set; }
        //public List<string> Hobbies { get; set; }
        
        public virtual MemberLoginDetails MemberLoginDetails { get; set; }        
    }
}
