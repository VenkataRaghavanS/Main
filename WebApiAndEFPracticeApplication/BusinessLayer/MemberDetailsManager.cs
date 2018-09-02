using System;
using System.Collections.Generic;
using DatabaseFirstDataLayer.RepositoryAndUnitOfWork;
using DatabaseFirstDataLayer;
using DTO;
using AutoMapper;

namespace BusinessLayer
{
    public class MemberDetailsManager : IDisposable
    {
        GenericUnitOfWork unitOfWork = new GenericUnitOfWork();
        private bool disposed = false;

        public MemberDetailsDTO AddMemberDetails(MemberDetails memberDetail)
        {
            GenericRepository<MemberDetails> samplePracticeRepo = unitOfWork.GetRepoInstance<MemberDetails>();
            samplePracticeRepo.Add(memberDetail);
            unitOfWork.SaveChanges();
            var memberDetailsDTO = Mapper.Map<MemberDetailsDTO>(memberDetail);
            memberDetailsDTO.MemberAddress = Mapper.Map<MemberAddressDTO>(memberDetail.MemberAddress);
            return Mapper.Map<MemberDetailsDTO>(memberDetailsDTO);
        }

        public MemberDetailsDTO GetSpecificMemberDetailsRecord(int memberDetailsId)
        {
            GenericRepository<MemberDetails> samplePracticeRepo = unitOfWork.GetRepoInstance<MemberDetails>();
            var memberDetail = samplePracticeRepo.GetFirstOrDefault(memberDetailsId);
            var memberDetailsDTO = Mapper.Map<MemberDetailsDTO>(memberDetail);
            memberDetailsDTO.MemberAddress = Mapper.Map<MemberAddressDTO>(memberDetail.MemberAddress);
            return memberDetailsDTO;
        }

        public IEnumerable<MemberDetailsDTO> GetAllMemberDetailsRecords()
        {
            GenericRepository<MemberDetails> samplePracticeRepo = unitOfWork.GetRepoInstance<MemberDetails>();
            var memberDetails = samplePracticeRepo.GetAllRecords();
            var memberDetailsDTO = Mapper.Map<IEnumerable<MemberDetailsDTO>>(memberDetails);
            foreach (var memberDetail in memberDetailsDTO)
            {
                memberDetail.MemberAddress = Mapper.Map<MemberAddressDTO>(memberDetail.MemberAddress);
            }
            return memberDetailsDTO;
        }

        public void UpdateMemberDetails(MemberDetails memberDetails)
        {
            GenericRepository<MemberDetails> samplePracticeRepo = unitOfWork.GetRepoInstance<MemberDetails>();
            samplePracticeRepo.Update(memberDetails);
            unitOfWork.SaveChanges();
        }

        public void DeleteMemberDetails(MemberDetails memberDetails)
        {
            GenericRepository<MemberDetails> samplePracticeRepo = unitOfWork.GetRepoInstance<MemberDetails>();
            samplePracticeRepo.Delete(memberDetails);
            unitOfWork.SaveChanges();
        }

        public void Dispose()
        {
            if (!this.disposed)
            {
                unitOfWork.Dispose();
                GC.SuppressFinalize(this);
            }
            this.disposed = true;
        }
    }
}
