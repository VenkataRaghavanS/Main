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

        public MemberDetailsDTO AddMemberDetails(MemberDetails memberDetails)
        {
            GenericRepository<MemberDetails> samplePracticeRepo = unitOfWork.GetRepoInstance<MemberDetails>();
            samplePracticeRepo.Add(memberDetails);
            unitOfWork.SaveChanges();
            return Mapper.Map<MemberDetailsDTO>(memberDetails);
        }

        public MemberDetailsDTO GetSpecificMemberDetailsRecord(int memberDetailsId)
        {
            GenericRepository<MemberDetails> samplePracticeRepo = unitOfWork.GetRepoInstance<MemberDetails>();
            var memberDetail = samplePracticeRepo.GetFirstOrDefault(memberDetailsId);            
            return Mapper.Map<MemberDetailsDTO>(memberDetail);
        }

        public IEnumerable<MemberDetailsDTO> GetAllMemberDetailsRecords()
        {
            GenericRepository<MemberDetails> samplePracticeRepo = unitOfWork.GetRepoInstance<MemberDetails>();
            var memberDetails = samplePracticeRepo.GetAllRecords();
            return Mapper.Map<IEnumerable<MemberDetailsDTO>>(memberDetails);
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
