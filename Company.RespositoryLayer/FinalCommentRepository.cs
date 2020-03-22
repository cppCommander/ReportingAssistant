using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.DataLayer;
using Company.DomainModels;
using Company.RepositoryContracts;

namespace Company.RespositoryLayer
{
    public class FinalCommentRepository : IFinalCommentRepository
    {

        CompanyDbContext db;

        public FinalCommentRepository()
        {
            this.db = new CompanyDbContext();
        }
        public void AddFinalComment(FinalComment c)
        {
            db.FinalComments.Add(c);
            db.SaveChanges();
        }

        public void DeleteFinalComment(long id)
        {
            FinalComment existingComment = db.FinalComments.Where(o => o.FinalCommentID == id).FirstOrDefault();
            db.FinalComments.Remove(existingComment);
            db.SaveChanges();
        }

        public void EditFinalComment(FinalComment c)
        {
            FinalComment finalComment = db.FinalComments.Where(temp => temp.FinalCommentID == c.FinalCommentID).FirstOrDefault();
            if(finalComment!=null)
            {
                finalComment.Description = c.Description;
                finalComment.Screen = c.Screen;
                db.SaveChanges();
            }
        }
        public FinalComment GetFinalCommentByFinalCommentId(long finalCommentId)
        {
            FinalComment finalComment = db.FinalComments.Where(temp => temp.FinalCommentID == finalCommentId).SingleOrDefault();
            return finalComment;
        }

        public List<FinalComment> GetFinalComments()
        {
            List<FinalComment> finalComments = db.FinalComments.ToList();
            return finalComments;
        }
    }
}
