using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.DomainModels;
using Company.ServiceContracts;
using Company.RepositoryContracts;

namespace Company.ServiceLayer
{
    public class FinalCommentService : IFinalCommentService
    {
        IFinalCommentRepository finalCommentRepository;

        public FinalCommentService(IFinalCommentRepository r)
        {
            this.finalCommentRepository = r;
        }

        public void AddFinalComment(FinalComment c)
        {
            finalCommentRepository.AddFinalComment(c);
        }

        public void DeleteFinalComment(long id)
        {
            finalCommentRepository.DeleteFinalComment(id);
        }

        public void EditFinalComment(FinalComment c)
        {
            finalCommentRepository.EditFinalComment(c);
        }

        public FinalComment GetFinalCommentByFinalCommentId(long finalCommentId)
        {
            FinalComment finalComment = finalCommentRepository.GetFinalCommentByFinalCommentId(finalCommentId);
            return finalComment;
        }

        public List<FinalComment> GetFinalComments()
        {
            List<FinalComment> finalComments = finalCommentRepository.GetFinalComments();
            return finalComments;
        }
    }
}
