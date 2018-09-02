using DatabaseFirstDataLayer.RepositoryAndUnitOfWork;
using DatabaseFirstDataLayer;
using System;

namespace BusinessLayer
{
    public class MemberLoginDetailsManager : IDisposable
    {
        GenericUnitOfWork unitOfWork = new GenericUnitOfWork();
        private bool disposed = false;

        public bool RegisterMember(MemberLoginDetails memberLoginDetails)
        {
            GenericRepository<MemberLoginDetails> samplePracticeRepo = unitOfWork.GetRepoInstance<MemberLoginDetails>();
            samplePracticeRepo.Add(memberLoginDetails);
            unitOfWork.SaveChanges();
            if (memberLoginDetails.MemberId > 0)            
                return true;            
            else
                return false;
        }

        public int LoginMember(string userName, string password)
        {
            GenericRepository<MemberLoginDetails> samplePracticeRepo = unitOfWork.GetRepoInstance<MemberLoginDetails>();
            int memberId = samplePracticeRepo.LoginMember(userName, password);
            return memberId;
        }

        public bool CheckIfMemberAlreadyExists(string userName)
        {
            GenericRepository<MemberLoginDetails> samplePracticeRepo = unitOfWork.GetRepoInstance<MemberLoginDetails>();
            return (samplePracticeRepo.CheckIfUserExisits(userName));            
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
