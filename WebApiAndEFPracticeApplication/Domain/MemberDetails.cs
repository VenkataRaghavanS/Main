using System;

namespace Domain
{
    public class MemberDetails
    {                        
        public int Id { get; set; }        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public int MobileNumber { get; set; }
        public MemberAddress MemberAddress { get; set; }
        //public List<string> Hobbies { get; set; }                
        public virtual MemberLoginDetails MemberLoginDetails { get; set; }        
    }
}
