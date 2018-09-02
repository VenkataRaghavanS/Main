namespace Domain
{
    public class MemberOrderDetails
    {
        public int Id { get; set; }
        public string OrderText { get; set; }

        public virtual MemberLoginDetails MemberLoginDetails {get; set;}
    }
}
