using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MemberOrderDetailsDTO
    {
        public int OrderId { get; set; }
        public string OrderText { get; set; }
        public MemberLoginDetailsDTO MemberLoginDetails { get; set; }
    }
}
