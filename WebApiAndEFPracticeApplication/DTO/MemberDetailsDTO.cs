using System;

namespace DTO
{
    public class MemberDetailsDTO
    {
        public int MemberId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public int MobileNumber { get; set; }
        public MemberAddressDTO MemberAddress { get; set; }
        //public List<string> Hobbies { get; set; }                        
    }
}
