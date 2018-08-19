using System;
using System.Collections.Generic;
using DataLayer.RepositoryAndUnitOfWork;
using Domain;

namespace BusinessLayer
{
    public class MemberDetailsManager : IDisposable
    {
        GenericUnitOfWork unitOfWork = new GenericUnitOfWork();
        private bool disposed = false;

        public MemberDetails AddMemberDetails(MemberDetails memberDetails)
        {
            GenericRepository<MemberDetails> samplePracticeRepo = unitOfWork.GetRepoInstance<MemberDetails>();
            samplePracticeRepo.Add(memberDetails);
            unitOfWork.SaveChanges();
            return memberDetails;
        }

        public MemberDetails GetSpecificMemberDetailsRecord(int memberDetailsId)
        {
            GenericRepository<MemberDetails> samplePracticeRepo = unitOfWork.GetRepoInstance<MemberDetails>();
            return samplePracticeRepo.GetFirstOrDefault(memberDetailsId);
        }

        public IEnumerable<MemberDetails> GetAllMemberDetailsRecords()
        {
            GenericRepository<MemberDetails> samplePracticeRepo = unitOfWork.GetRepoInstance<MemberDetails>();
            return samplePracticeRepo.GetAllRecords();
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
