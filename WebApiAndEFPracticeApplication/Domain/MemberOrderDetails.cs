using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class MemberOrderDetails
    {
        public int Id { get; set; }
        public string OrderText { get; set; }

        public virtual MemberLoginDetails MemberLoginDetails {get; set;}
    }
}
