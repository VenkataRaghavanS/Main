using AutoMapper;
using DTO;
using DatabaseFirstDataLayer;

namespace BusinessLayer
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<MemberLoginDetails, MemberLoginDetailsDTO>();
            CreateMap<MemberAddress, MemberAddressDTO>();
            CreateMap<MemberDetails, MemberDetailsDTO>();            
            CreateMap<MemberOrderDetails, MemberOrderDetailsDTO>();            
        }
    }
}
