using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            CreateMap<MemberDetails, MemberDetailsDTO>();
            CreateMap<MemberOrderDetails, MemberOrderDetailsDTO>();            
        }
    }
}
