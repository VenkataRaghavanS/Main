using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MemberDetailsDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public int MobileNumber { get; set; }
        public MemberAddressDTO MemberAddress { get; set; }
        //public List<string> Hobbies { get; set; }                
        public MemberLoginDetailsDTO MemberLoginDetails { get; set; }
    }
}
