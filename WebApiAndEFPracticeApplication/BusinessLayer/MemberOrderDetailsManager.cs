using DataLayer.RepositoryAndUnitOfWork;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class MemberOrderDetailsManager : IDisposable
    {
        GenericUnitOfWork unitOfWork = new GenericUnitOfWork();
        private bool disposed = false;

        public MemberOrderDetails AddMemberOrderDetails(MemberOrderDetails memberOrderDetails)
        {
            GenericRepository<MemberOrderDetails> samplePracticeRepo = unitOfWork.GetRepoInstance<MemberOrderDetails>();
            samplePracticeRepo.Add(memberOrderDetails);
            unitOfWork.SaveChanges();
            return memberOrderDetails;
        }

        public MemberOrderDetails GetSpecificMemberOrderDetailsRecord(int OrderId)
        {
            GenericRepository<MemberOrderDetails> samplePracticeRepo = unitOfWork.GetRepoInstance<MemberOrderDetails>();
            return samplePracticeRepo.GetFirstOrDefault(OrderId);
        }

        public IEnumerable<MemberOrderDetails> GetAllMemberOrderDetailsRecords()
        {
            GenericRepository<MemberOrderDetails> samplePracticeRepo = unitOfWork.GetRepoInstance<MemberOrderDetails>();
            return samplePracticeRepo.GetAllRecords();
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
