using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.DomainModels;

namespace Company.RepositoryContracts
{
    public interface IFinalCommentRepository
    {
        void AddFinalComment(FinalComment c);

        void EditFinalComment(FinalComment c);

        List<FinalComment> GetFinalComments();

        FinalComment GetFinalCommentByFinalCommentId(long finalCommentId);

        void DeleteFinalComment(long id);
    }
}
