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
    public class TasksDoneRepository : ITasksDoneRepository
    {
        CompanyDbContext db;

        public TasksDoneRepository()
        {
            this.db = new CompanyDbContext();
        }
        public void AddTaskDone(TaskDone t)
        {
            db.TasksDone.Add(t);
            db.SaveChanges();
        }

        public void EditTaskDone(TaskDone t)
        {
            TaskDone taskDone = db.TasksDone.Where(o => o.TaskDoneID == t.TaskDoneID).FirstOrDefault();
            if(taskDone!=null)
            {
                taskDone.Project = t.Project;
                taskDone.ProjectID = t.ProjectID;
                taskDone.Screen = t.Screen;
                taskDone.UserID = t.UserID;
                db.SaveChanges();
            }
        }

        public TaskDone GetTaskByTaskDoneById(long taskId)
        {
            TaskDone taskDone = db.TasksDone.Where(o => o.TaskDoneID == taskId).FirstOrDefault();
            return taskDone;
        }

        public List<TaskDone> GetTasksDone()
        {
            List<TaskDone> tasksDone = db.TasksDone.ToList();
            return tasksDone;
        }
    }
}
