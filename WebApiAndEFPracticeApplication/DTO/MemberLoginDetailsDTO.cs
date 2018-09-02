using System.Collections.Generic;

namespace DTO
{
    public class MemberLoginDetailsDTO
    {
        public int MemberId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public MemberDetailsDTO MemberDetailsDTO { get; set; }

        public ICollection<MemberOrderDetailsDTO> memberOrderDetails { get; set; }
    }
}
