using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.DomainModels;
using Company.DataLayer;
using Company.RepositoryContracts;
using AutoMapper;
using Company.ServiceLayer;

namespace Company.RespositoryLayer
{
    public class TasksRepository : ITasksRepository
    {

        CompanyDbContext db;

        public TasksRepository()
        {
            this.db = new CompanyDbContext();
        }

        public void AddTask(DomainModels.Task t)
        {
            db.Tasks.Add(t);
            db.SaveChanges();
        }

        public void DeleteTask(long id)
        {
            DomainModels.Task existingTask = db.Tasks.Where(o => o.TaskID == id).FirstOrDefault();
            db.Tasks.Remove(existingTask);
            db.SaveChanges();
        }

        public void EditTask(DomainModels.Task t)
        {
            DomainModels.Task task = db.Tasks.Where(temp => temp.TaskID == t.TaskID).FirstOrDefault();
            if(task != null)
            {
                task.Description = t.Description;
                task.Screen = t.Screen;
                db.SaveChanges();
            }
        }

        public DomainModels.Task GetTaskByTaskId(long taskId)
        {
            DomainModels.Task task = db.Tasks.Where(temp => temp.TaskID == taskId).SingleOrDefault();
            return task;
        }

        public List<DomainModels.Task> GetTaskByUserIdAndAdminIdAndDate(string userId, string adminId, DateTime dateTime)
        {
            List <DomainModels.Task> tasks = db.Tasks.Where(temp => temp.UserID == userId && temp.DateOfTask == dateTime && temp.AdminUserID == adminId).ToList();
            return tasks;
        }

        public List<DomainModels.Task> GetTasks()
        {
            List<DomainModels.Task> tasks = db.Tasks.ToList();
            return tasks;

        }
    }
    
}
