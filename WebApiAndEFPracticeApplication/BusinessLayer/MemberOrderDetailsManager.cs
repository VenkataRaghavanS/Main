using AutoMapper;
using DatabaseFirstDataLayer;
using DatabaseFirstDataLayer.RepositoryAndUnitOfWork;
using System;
using System.Collections.Generic;
using DTO;

namespace BusinessLayer
{
    public class MemberOrderDetailsManager : IDisposable
    {
        GenericUnitOfWork unitOfWork = new GenericUnitOfWork();
        private bool disposed = false;

        public MemberOrderDetailsDTO AddMemberOrderDetails(MemberOrderDetails memberOrderDetails)
        {
            GenericRepository<MemberOrderDetails> samplePracticeRepo = unitOfWork.GetRepoInstance<MemberOrderDetails>();
            samplePracticeRepo.Add(memberOrderDetails);
            unitOfWork.SaveChanges();
            return Mapper.Map<MemberOrderDetailsDTO>(memberOrderDetails);
        }

        public MemberOrderDetailsDTO GetSpecificMemberOrderDetailsRecord(int OrderId)
        {
            GenericRepository<MemberOrderDetails> samplePracticeRepo = unitOfWork.GetRepoInstance<MemberOrderDetails>();
            var memberOrderDetail = samplePracticeRepo.GetFirstOrDefault(OrderId);
            return Mapper.Map<MemberOrderDetailsDTO>(memberOrderDetail);
        }

        public IEnumerable<MemberOrderDetailsDTO> GetAllMemberOrderDetailsRecords()
        {
            GenericRepository<MemberOrderDetails> samplePracticeRepo = unitOfWork.GetRepoInstance<MemberOrderDetails>();
            var memberOrderDetails = samplePracticeRepo.GetAllRecords();
            return Mapper.Map<IEnumerable<MemberOrderDetailsDTO>>(memberOrderDetails);
        }

        public void UpdateMemberOrderDetails(MemberOrderDetails memberOrderDetails)
        {
            GenericRepository<MemberOrderDetails> samplePracticeRepo = unitOfWork.GetRepoInstance<MemberOrderDetails>();
            samplePracticeRepo.Update(memberOrderDetails);
            unitOfWork.SaveChanges();
        }

        public void DeleteMemberOrderDetails(MemberOrderDetails memberOrderDetails)
        {
            GenericRepository<MemberOrderDetails> samplePracticeRepo = unitOfWork.GetRepoInstance<MemberOrderDetails>();
            samplePracticeRepo.Delete(memberOrderDetails);
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
