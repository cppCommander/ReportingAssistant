using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.DataLayer;
using Company.DomainModels;
using Company.RepositoryContracts;
using Company.RespositoryLayer;
using Company.ServiceContracts;

namespace Company.ServiceLayer
{

    

    public class TasksService : ITasksService
    {
        ITasksRepository taskRepository;

        public TasksService(ITasksRepository r)
        {
            this.taskRepository = r;
        }
        public void AddTask(DomainModels.Task t)
        {
            taskRepository.AddTask(t);
        }

        public DomainModels.Task GetTaskByTaskId(long taskId)
        {
            DomainModels.Task task = taskRepository.GetTaskByTaskId(taskId);
            return task;
        }

        public List<DomainModels.Task> GetTaskByUserIdAndAdminIdAndDate(string userId, string adminId, DateTime dateTime)
        {
            List<DomainModels.Task> tasks = taskRepository.GetTaskByUserIdAndAdminIdAndDate(userId, adminId, dateTime);
            return tasks;
        }



        public List<DomainModels.Task> GetTasks()
        {
            List<DomainModels.Task> tasks = taskRepository.GetTasks();
            return tasks;
        }

        public void EditTask(DomainModels.Task t)
        {
            taskRepository.EditTask(t);
        }

        public void DeleteTask(long id)
        {
            taskRepository.DeleteTask(id);
        }
    }
}
