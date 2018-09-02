using System.Collections.Generic;

namespace Domain
{
    public class MemberLoginDetails
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public virtual ICollection<MemberDetails> MemberDetails {get; set; }

        public virtual ICollection<MemberOrderDetails> memberOrderDetails { get; set; }
    }
}
